import 'package:uuid/uuid.dart';

import '../data/data_exception.dart';
import '../data/product_unit_api.dart';
import '../data/product_unit_repository.dart';
import '../models/product_unit.dart';
import '../models/product_unit_local_record.dart';
import '../models/product_unit_remote_model.dart';
import 'connectivity_service.dart';

class ProductUnitSyncResult {
  const ProductUnitSyncResult({
    required this.success,
    required this.message,
    this.pulled = 0,
    this.pushed = 0,
    this.failed = 0,
    this.conflictsResolved = 0,
    this.pending = 0,
    this.transientFailure = false,
  });

  final bool success;
  final String message;
  final int pulled;
  final int pushed;
  final int failed;
  final int conflictsResolved;
  final int pending;
  final bool transientFailure;
}

class ProductUnitSyncService {
  ProductUnitSyncService(this._repository, this._api, this._connectivity);

  final ProductUnitRepository _repository;
  final ProductUnitApi _api;
  final NetworkConnectivity _connectivity;

  Future<ProductUnitSyncResult> synchronize({
    required String shopId,
    bool force = false,
  }) async {
    final owner = const Uuid().v4();
    if (!await _repository.tryAcquireSyncLock(owner, shopId)) {
      return ProductUnitSyncResult(
        success: true,
        message: 'A product unit sync is already running.',
        pending: await _repository.getPendingCount(shopId),
      );
    }

    var pulled = 0;
    var pushed = 0;
    var failed = 0;
    var conflicts = 0;
    var transientFailure = false;
    try {
      if (!await _connectivity.hasConnection) {
        return ProductUnitSyncResult(
          success: false,
          message: 'Offline. Local changes are safe and will retry later.',
          pending: await _repository.getPendingCount(shopId),
          transientFailure: true,
        );
      }

      final cursor = await _repository.getPullCursor(shopId);
      final remoteChanges = await _api.pull(cursor);
      DateTime? newest;
      for (final remote in remoteChanges) {
        if (newest == null || remote.lastModifiedUtc.isAfter(newest)) {
          newest = remote.lastModifiedUtc;
        }
        final outcome = await _mergeRemote(remote);
        pulled += outcome.applied ? 1 : 0;
        conflicts += outcome.conflict ? 1 : 0;
      }
      if (newest != null) {
        final overlap = newest.subtract(const Duration(milliseconds: 1));
        await _repository.setPullCursor(
          shopId,
          overlap.isAfter(cursor) ? overlap : cursor,
        );
      }

      for (final record in await _repository.getPendingRecords(
        shopId: shopId,
        force: force,
      )) {
        try {
          final outcome = await _push(record);
          pushed += outcome.pushed ? 1 : 0;
          conflicts += outcome.conflict ? 1 : 0;
        } on RemoteTransientException catch (error) {
          await _markFailure(record, error.message);
          failed++;
          transientFailure = true;
          break;
        } on RemotePermanentException catch (error) {
          await _markFailure(record, error.message);
          failed++;
        } catch (error) {
          await _markFailure(record, error.toString());
          failed++;
          transientFailure = true;
          break;
        }
      }
      return ProductUnitSyncResult(
        success: failed == 0,
        message: failed == 0
            ? 'Product unit sync completed.'
            : 'Product unit sync completed with $failed failed request(s).',
        pulled: pulled,
        pushed: pushed,
        failed: failed,
        conflictsResolved: conflicts,
        pending: await _repository.getPendingCount(shopId),
        transientFailure: transientFailure,
      );
    } on RemoteTransientException catch (error) {
      return _failure(
        shopId,
        error.message,
        pulled,
        pushed,
        failed,
        conflicts,
        transient: true,
      );
    } on RemotePermanentException catch (error) {
      return _failure(shopId, error.message, pulled, pushed, failed, conflicts);
    } catch (_) {
      return _failure(
        shopId,
        'Product unit sync failed unexpectedly.',
        pulled,
        pushed,
        failed,
        conflicts,
        transient: true,
      );
    } finally {
      await _repository.releaseSyncLock(owner, shopId);
    }
  }

  Future<ProductUnitSyncResult> _failure(
    String shopId,
    String message,
    int pulled,
    int pushed,
    int failed,
    int conflicts, {
    bool transient = false,
  }) async => ProductUnitSyncResult(
    success: false,
    message: message,
    pulled: pulled,
    pushed: pushed,
    failed: failed + 1,
    conflictsResolved: conflicts,
    pending: await _repository.getPendingCount(shopId),
    transientFailure: transient,
  );

  Future<_MergeOutcome> _mergeRemote(ProductUnitRemoteModel remote) async {
    final local = await _repository.getRecord(remote.id);
    if (local == null) {
      if (!remote.isDeleted) {
        await _repository.saveRecord(_recordFromRemote(remote));
        return const _MergeOutcome(applied: true);
      }
      return const _MergeOutcome();
    }
    if (local.lastModifiedUtc.isAfter(remote.conflictModifiedUtc)) {
      return const _MergeOutcome();
    }
    final conflict = local.pendingOperation != ProductUnitPendingOperation.none;
    if (remote.isDeleted) {
      await _repository.removeRecord(local.id);
    } else {
      await _repository.saveRecord(_recordFromRemote(remote, existing: local));
    }
    return _MergeOutcome(applied: true, conflict: conflict);
  }

  Future<_PushOutcome> _push(ProductUnitLocalRecord local) async {
    final server = await _api.getById(local.id);
    if (local.pendingOperation == ProductUnitPendingOperation.delete) {
      if (server == null) {
        await _repository.removeRecord(local.id);
        return const _PushOutcome(pushed: true);
      }
      if (!local.lastModifiedUtc.isAfter(server.conflictModifiedUtc)) {
        await _repository.saveRecord(
          _recordFromRemote(server, existing: local),
        );
        return const _PushOutcome(conflict: true);
      }
      try {
        final deleted = await _api.delete(local);
        if (deleted == null || deleted.isDeleted) {
          await _repository.removeRecord(local.id);
          return const _PushOutcome(pushed: true);
        }
        await _repository.saveRecord(
          _recordFromRemote(deleted, existing: local),
        );
        return const _PushOutcome(conflict: true);
      } on RemotePermanentException {
        await _repository.saveRecord(
          _recordFromRemote(server, existing: local),
        );
        rethrow;
      }
    }
    if (server == null) {
      final created = await _api.create(local);
      if (created.isDeleted) {
        await _repository.removeRecord(local.id);
        return const _PushOutcome(conflict: true);
      }
      await _repository.saveRecord(_recordFromRemote(created, existing: local));
      return const _PushOutcome(pushed: true);
    }
    if (!local.lastModifiedUtc.isAfter(server.conflictModifiedUtc)) {
      await _repository.saveRecord(_recordFromRemote(server, existing: local));
      return const _PushOutcome(conflict: true);
    }
    final updated = await _api.update(local);
    if (updated.isDeleted) {
      await _repository.removeRecord(local.id);
      return const _PushOutcome(conflict: true);
    }
    await _repository.saveRecord(_recordFromRemote(updated, existing: local));
    return const _PushOutcome(pushed: true);
  }

  ProductUnitLocalRecord _recordFromRemote(
    ProductUnitRemoteModel remote, {
    ProductUnitLocalRecord? existing,
  }) {
    final timestamp = remote.conflictModifiedUtc.toUtc();
    return ProductUnitLocalRecord(
      id: remote.id,
      productId: remote.productId,
      unitOfMeasureId: remote.unitOfMeasureId,
      conversionFactor: remote.conversionFactor,
      createdAt:
          existing?.createdAt ??
          remote.clientCreatedDate ??
          remote.createdDate ??
          timestamp,
      updatedAt: timestamp,
      lastModifiedUtc: timestamp,
      isDeleted: false,
      pendingOperation: ProductUnitPendingOperation.none,
      syncStatus: ProductUnitSyncStatus.synced,
      retryCount: 0,
      serverCreatedDate: remote.createdDate,
      serverUpdatedDate: remote.updatedDate,
      serverCreatedBy: remote.createdBy,
      serverUpdatedBy: remote.updatedBy,
      serverLastModifiedUtc: remote.lastModifiedUtc,
    );
  }

  Future<void> _markFailure(
    ProductUnitLocalRecord record,
    String message,
  ) async {
    final current = await _repository.getRecord(record.id);
    if (current == null ||
        current.pendingOperation == ProductUnitPendingOperation.none) {
      return;
    }
    final retryCount = current.retryCount + 1;
    final exponent = retryCount.clamp(1, 6).toInt();
    await _repository.saveRecord(
      current.copyWith(
        syncStatus: ProductUnitSyncStatus.failed,
        retryCount: retryCount,
        nextRetryAt: DateTime.now().toUtc().add(
          Duration(minutes: 1 << (exponent - 1)),
        ),
        lastSyncError: message,
      ),
    );
  }
}

class _MergeOutcome {
  const _MergeOutcome({this.applied = false, this.conflict = false});
  final bool applied;
  final bool conflict;
}

class _PushOutcome {
  const _PushOutcome({this.pushed = false, this.conflict = false});
  final bool pushed;
  final bool conflict;
}
