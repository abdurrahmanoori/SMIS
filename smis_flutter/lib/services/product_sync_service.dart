import 'package:dio/dio.dart';
import 'package:uuid/uuid.dart';

import '../data/data_exception.dart';
import '../data/product_api.dart';
import '../data/product_repository.dart';
import '../models/product.dart';
import '../models/product_local_record.dart';
import '../models/product_remote_model.dart';
import 'connectivity_service.dart';

class ProductSyncFailure {
  const ProductSyncFailure({
    required this.phase,
    required this.error,
    required this.stackTrace,
    this.productId,
  });
  final String phase;
  final String? productId;
  final Object error;
  final StackTrace stackTrace;

  String toDevelopmentString() {
    final buffer = StringBuffer()
      ..writeln('Phase: $phase')
      ..writeln('Product ID: ${productId ?? '(not available)'}')
      ..writeln('Exception: ${error.runtimeType}: $error');
    if (error case final AppException appException when appException.cause != null) {
      final cause = appException.cause!;
      buffer.writeln('Cause: ${cause.runtimeType}: $cause');
      if (cause is DioException) {
        buffer
          ..writeln('Request: ${cause.requestOptions.method} ${cause.requestOptions.uri}')
          ..writeln('Dio type: ${cause.type}')
          ..writeln('HTTP status: ${cause.response?.statusCode ?? '(none)'}')
          ..writeln('Response body: ${cause.response?.data ?? '(none)'}');
      }
    }
    buffer..writeln('Stack trace:')..write(stackTrace);
    return buffer.toString();
  }
}

class ProductSyncResult {
  const ProductSyncResult({
    required this.success,
    required this.message,
    this.pulled = 0,
    this.pushed = 0,
    this.failed = 0,
    this.conflictsResolved = 0,
    this.pending = 0,
    this.transientFailure = false,
    this.skippedOffline = false,
    this.failures = const [],
  });
  final bool success;
  final String message;
  final int pulled;
  final int pushed;
  final int failed;
  final int conflictsResolved;
  final int pending;
  final bool transientFailure;
  final bool skippedOffline;
  final List<ProductSyncFailure> failures;
}

class ProductSyncService {
  ProductSyncService(this._repository, this._api, this._connectivity);
  final ProductRepository _repository;
  final ProductApi _api;
  final NetworkConnectivity _connectivity;

  Future<ProductSyncResult> synchronize({required String shopId, bool force = false}) async {
    final owner = const Uuid().v4();
    if (!await _repository.tryAcquireSyncLock(owner, shopId)) {
      return ProductSyncResult(success: true, message: 'A product sync is already running.', pending: await _repository.getPendingCount(shopId));
    }
    var pulled = 0;
    var pushed = 0;
    var failed = 0;
    var conflicts = 0;
    var transient = false;
    var phase = 'connectivity check';
    final failures = <ProductSyncFailure>[];
    try {
      if (!await _connectivity.hasConnection) {
        return ProductSyncResult(
          success: false,
          message: 'Offline. Local changes are safe and will retry later.',
          pending: await _repository.getPendingCount(shopId),
          transientFailure: true,
          skippedOffline: true,
        );
      }
      phase = 'pull';
      final cursor = await _repository.getPullCursor(shopId);
      final remoteChanges = await _api.pull(cursor);
      DateTime? newest;
      for (final remote in remoteChanges) {
        newest = _later(newest, remote.lastModifiedUtc);
        final outcome = await _mergeRemote(remote);
        pulled += outcome.applied ? 1 : 0;
        conflicts += outcome.conflictResolved ? 1 : 0;
      }
      if (newest != null) {
        final overlap = newest.subtract(const Duration(milliseconds: 1));
        await _repository.setPullCursor(shopId, overlap.isAfter(cursor) ? overlap : cursor);
      }
      phase = 'push';
      for (final record in await _repository.getPendingRecords(shopId: shopId, force: force)) {
        try {
          final outcome = await _push(record);
          pushed += outcome.pushed ? 1 : 0;
          conflicts += outcome.conflictResolved ? 1 : 0;
        } on RemoteTransientException catch (error, stackTrace) {
          failures.add(_failure(record, error, stackTrace));
          await _markFailure(record, error.message);
          failed++;
          transient = true;
          break;
        } on RemotePermanentException catch (error, stackTrace) {
          failures.add(_failure(record, error, stackTrace));
          await _markFailure(record, error.message);
          failed++;
        } catch (error, stackTrace) {
          failures.add(_failure(record, error, stackTrace));
          await _markFailure(record, error.toString());
          failed++;
          transient = true;
          break;
        }
      }
      return ProductSyncResult(
        success: failed == 0,
        message: failed == 0 ? 'Product sync completed.' : 'Product sync completed with $failed failed request(s).',
        pulled: pulled,
        pushed: pushed,
        failed: failed,
        conflictsResolved: conflicts,
        pending: await _repository.getPendingCount(shopId),
        transientFailure: transient,
        failures: failures,
      );
    } on RemoteTransientException catch (error, stackTrace) {
      return _failureResult(shopId, error, stackTrace, phase, pulled, pushed, failed, conflicts, true, failures);
    } on RemotePermanentException catch (error, stackTrace) {
      return _failureResult(shopId, error, stackTrace, phase, pulled, pushed, failed, conflicts, false, failures);
    } catch (error, stackTrace) {
      return _failureResult(shopId, error, stackTrace, phase, pulled, pushed, failed, conflicts, true, failures);
    } finally {
      await _repository.releaseSyncLock(owner, shopId);
    }
  }

  Future<ProductSyncResult> _failureResult(String shopId, Object error, StackTrace stackTrace, String phase, int pulled, int pushed, int failed, int conflicts, bool transient, List<ProductSyncFailure> failures) async => ProductSyncResult(
    success: false,
    message: error is AppException
        ? '${error.message}${transient ? ' Local changes will retry later.' : ''}'
        : 'Product sync failed unexpectedly.',
    pulled: pulled,
    pushed: pushed,
    failed: failed + 1,
    conflictsResolved: conflicts,
    pending: await _repository.getPendingCount(shopId),
    transientFailure: transient,
    failures: [...failures, ProductSyncFailure(phase: phase, error: error, stackTrace: stackTrace)],
  );

  ProductSyncFailure _failure(ProductLocalRecord record, Object error, StackTrace stackTrace) => ProductSyncFailure(
    phase: 'push ${record.pendingOperation.name}', productId: record.id, error: error, stackTrace: stackTrace);

  Future<_MergeOutcome> _mergeRemote(ProductRemoteModel remote) async {
    final local = await _repository.getRecord(remote.id);
    if (local == null) {
      if (!remote.isDeleted) {
        await _repository.saveRecord(_recordFromRemote(remote));
        return const _MergeOutcome(applied: true);
      }
      return const _MergeOutcome();
    }
    // Last-write-wins. The server wins exact timestamp ties.
    if (local.lastModifiedUtc.isAfter(remote.conflictModifiedUtc)) return const _MergeOutcome();
    final conflict = local.pendingOperation != ProductPendingOperation.none;
    if (remote.isDeleted) {
      await _repository.removeRecord(remote.id);
    } else {
      await _repository.saveRecord(_recordFromRemote(remote, existing: local));
    }
    return _MergeOutcome(applied: true, conflictResolved: conflict);
  }

  Future<_PushOutcome> _push(ProductLocalRecord local) async {
    final server = await _api.getById(local.id);
    if (local.pendingOperation == ProductPendingOperation.delete) {
      if (server == null) {
        await _repository.removeRecord(local.id);
        return const _PushOutcome(pushed: true);
      }
      if (!local.lastModifiedUtc.isAfter(server.conflictModifiedUtc)) {
        await _repository.saveRecord(_recordFromRemote(server, existing: local));
        return const _PushOutcome(conflictResolved: true);
      }
      final deleted = await _api.delete(local);
      if (deleted == null || deleted.isDeleted) {
        await _repository.removeRecord(local.id);
        return const _PushOutcome(pushed: true);
      }
      await _repository.saveRecord(_recordFromRemote(deleted, existing: local));
      return const _PushOutcome(conflictResolved: true);
    }
    if (server == null) {
      final created = await _api.create(local);
      if (created.isDeleted) {
        await _repository.removeRecord(local.id);
        return const _PushOutcome(conflictResolved: true);
      }
      await _repository.saveRecord(_recordFromRemote(created, existing: local));
      return const _PushOutcome(pushed: true);
    }
    if (!local.lastModifiedUtc.isAfter(server.conflictModifiedUtc)) {
      await _repository.saveRecord(_recordFromRemote(server, existing: local));
      return const _PushOutcome(conflictResolved: true);
    }
    final updated = await _api.update(local);
    if (updated.isDeleted) {
      await _repository.removeRecord(local.id);
      return const _PushOutcome(conflictResolved: true);
    }
    await _repository.saveRecord(_recordFromRemote(updated, existing: local));
    return const _PushOutcome(pushed: true);
  }

  ProductLocalRecord _recordFromRemote(ProductRemoteModel remote, {ProductLocalRecord? existing}) {
    final timestamp = remote.conflictModifiedUtc.toUtc();
    return ProductLocalRecord(
      id: remote.id,
      name: remote.name,
      baseUnitId: remote.baseUnitId,
      sku: remote.sku,
      description: remote.description,
      isActive: remote.isActive,
      barcode: remote.barcode,
      imageUrl: remote.imageUrl,
      categoryId: remote.categoryId,
      shopId: remote.shopId,
      createdAt: existing?.createdAt ?? remote.clientCreatedDate ?? remote.createdDate ?? timestamp,
      updatedAt: timestamp,
      lastModifiedUtc: timestamp,
      isDeleted: false,
      pendingOperation: ProductPendingOperation.none,
      syncStatus: ProductSyncStatus.synced,
      retryCount: 0,
      serverCreatedDate: remote.createdDate,
      serverUpdatedDate: remote.updatedDate,
      serverCreatedBy: remote.createdBy,
      serverUpdatedBy: remote.updatedBy,
      serverLastModifiedUtc: remote.lastModifiedUtc,
    );
  }

  Future<void> _markFailure(ProductLocalRecord record, String message) async {
    final retryCount = record.retryCount + 1;
    final exponent = retryCount.clamp(1, 6).toInt();
    await _repository.saveRecord(record.copyWith(
      syncStatus: ProductSyncStatus.failed,
      retryCount: retryCount,
      nextRetryAt: DateTime.now().toUtc().add(Duration(minutes: 1 << (exponent - 1))),
      lastSyncError: message,
    ));
  }
  DateTime _later(DateTime? current, DateTime candidate) => current == null || candidate.isAfter(current) ? candidate : current;
}

class _MergeOutcome { const _MergeOutcome({this.applied = false, this.conflictResolved = false}); final bool applied; final bool conflictResolved; }
class _PushOutcome { const _PushOutcome({this.pushed = false, this.conflictResolved = false}); final bool pushed; final bool conflictResolved; }
