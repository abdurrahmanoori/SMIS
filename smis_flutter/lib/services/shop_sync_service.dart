import 'package:dio/dio.dart';
import 'package:uuid/uuid.dart';

import '../data/data_exception.dart';
import '../data/shop_api.dart';
import '../data/shop_repository.dart';
import '../models/shop.dart';
import '../models/shop_local_record.dart';
import '../models/shop_remote_model.dart';
import 'connectivity_service.dart';

class ShopSyncFailure {
  const ShopSyncFailure({
    required this.phase,
    required this.error,
    required this.stackTrace,
    this.shopId,
  });

  final String phase;
  final String? shopId;
  final Object error;
  final StackTrace stackTrace;

  String toDevelopmentString() {
    final buffer = StringBuffer()
      ..writeln('Phase: $phase')
      ..writeln('Shop ID: ${shopId ?? '(not available)'}')
      ..writeln('Exception: ${error.runtimeType}: $error');
    if (error case final AppException appException
        when appException.cause != null) {
      final cause = appException.cause!;
      buffer.writeln('Cause: ${cause.runtimeType}: $cause');
      if (cause is DioException) {
        buffer
          ..writeln(
            'Request: ${cause.requestOptions.method} ${cause.requestOptions.uri}',
          )
          ..writeln('Dio type: ${cause.type}')
          ..writeln(
            'HTTP status: ${cause.response?.statusCode ?? '(none)'}',
          )
          ..writeln(
            'Response body: ${cause.response?.data ?? '(none)'}',
          );
      }
    }
    buffer
      ..writeln('Stack trace:')
      ..write(stackTrace);
    return buffer.toString();
  }
}

class ShopSyncResult {
  const ShopSyncResult({
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
  final List<ShopSyncFailure> failures;
}

class ShopSyncService {
  ShopSyncService(this._repository, this._api, this._connectivity);

  final ShopRepository _repository;
  final ShopApi _api;
  final NetworkConnectivity _connectivity;

  Future<ShopSyncResult> synchronize({bool force = false}) async {
    final owner = const Uuid().v4();
    if (!await _repository.tryAcquireSyncLock(owner)) {
      return ShopSyncResult(
        success: true,
        message: 'A shop sync is already running.',
        pending: await _repository.getPendingCount(),
      );
    }

    var pulled = 0;
    var pushed = 0;
    var failed = 0;
    var conflicts = 0;
    var transientFailure = false;
    var phase = 'connectivity check';
    final failures = <ShopSyncFailure>[];
    try {
      if (!await _connectivity.hasConnection) {
        return ShopSyncResult(
          success: false,
          message: 'Offline. Local changes are safe and will retry later.',
          pending: await _repository.getPendingCount(),
          transientFailure: true,
          skippedOffline: true,
        );
      }

      phase = 'pull';
      final cursor = await _repository.getPullCursor();
      final remoteChanges = await _api.pull(cursor);
      DateTime? newestRemoteWrite;
      for (final remote in remoteChanges) {
        newestRemoteWrite = _later(newestRemoteWrite, remote.lastModifiedUtc);
        final outcome = await _mergeRemote(remote);
        pulled += outcome.applied ? 1 : 0;
        conflicts += outcome.conflictResolved ? 1 : 0;
      }
      if (newestRemoteWrite != null) {
        final overlapped = newestRemoteWrite.subtract(
          const Duration(milliseconds: 1),
        );
        await _repository.setPullCursor(
          overlapped.isAfter(cursor) ? overlapped : cursor,
        );
      }

      phase = 'push';
      for (final localRecord
          in await _repository.getPendingRecords(force: force)) {
        try {
          final outcome = await _push(localRecord);
          pushed += outcome.pushed ? 1 : 0;
          conflicts += outcome.conflictResolved ? 1 : 0;
        } on RemoteTransientException catch (error, stackTrace) {
          failures.add(_failure(localRecord, error, stackTrace));
          await _markFailure(localRecord, error.message);
          failed++;
          transientFailure = true;
          break;
        } on RemotePermanentException catch (error, stackTrace) {
          failures.add(_failure(localRecord, error, stackTrace));
          await _markFailure(localRecord, error.message);
          failed++;
        } catch (error, stackTrace) {
          failures.add(_failure(localRecord, error, stackTrace));
          await _markFailure(localRecord, error.toString());
          failed++;
          transientFailure = true;
          break;
        }
      }
      final remaining = await _repository.getPendingCount();
      return ShopSyncResult(
        success: failed == 0,
        message: failed == 0
            ? 'Shop sync completed.'
            : 'Shop sync completed with $failed failed request(s).',
        pulled: pulled,
        pushed: pushed,
        failed: failed,
        conflictsResolved: conflicts,
        pending: remaining,
        transientFailure: transientFailure,
        failures: failures,
      );
    } on RemoteTransientException catch (error, stackTrace) {
      return _failedResult(
        error: error,
        stackTrace: stackTrace,
        phase: phase,
        pulled: pulled,
        pushed: pushed,
        failed: failed,
        conflicts: conflicts,
        transient: true,
        failures: failures,
      );
    } on RemotePermanentException catch (error, stackTrace) {
      return _failedResult(
        error: error,
        stackTrace: stackTrace,
        phase: phase,
        pulled: pulled,
        pushed: pushed,
        failed: failed,
        conflicts: conflicts,
        transient: false,
        failures: failures,
      );
    } catch (error, stackTrace) {
      return _failedResult(
        error: error,
        stackTrace: stackTrace,
        phase: phase,
        pulled: pulled,
        pushed: pushed,
        failed: failed,
        conflicts: conflicts,
        transient: true,
        failures: failures,
      );
    } finally {
      await _repository.releaseSyncLock(owner);
    }
  }

  Future<ShopSyncResult> _failedResult({
    required Object error,
    required StackTrace stackTrace,
    required String phase,
    required int pulled,
    required int pushed,
    required int failed,
    required int conflicts,
    required bool transient,
    required List<ShopSyncFailure> failures,
  }) async => ShopSyncResult(
    success: false,
    message: error is AppException
        ? '${error.message}${transient ? ' Local changes will retry later.' : ''}'
        : 'Shop sync failed unexpectedly.',
    pulled: pulled,
    pushed: pushed,
    failed: failed + 1,
    conflictsResolved: conflicts,
    pending: await _repository.getPendingCount(),
    transientFailure: transient,
    failures: [
      ...failures,
      ShopSyncFailure(
        phase: phase,
        error: error,
        stackTrace: stackTrace,
      ),
    ],
  );

  ShopSyncFailure _failure(
    ShopLocalRecord record,
    Object error,
    StackTrace stackTrace,
  ) => ShopSyncFailure(
    phase: 'push ${record.pendingOperation.name}',
    shopId: record.id,
    error: error,
    stackTrace: stackTrace,
  );

  Future<_ShopMergeOutcome> _mergeRemote(ShopRemoteModel remote) async {
    final local = await _repository.getRecord(remote.id);
    if (local == null) {
      if (!remote.isDeleted) {
        await _repository.saveRecord(_recordFromRemote(remote));
        return const _ShopMergeOutcome(applied: true);
      }
      return const _ShopMergeOutcome();
    }

    // Last-write-wins. The server wins exact timestamp ties.
    if (local.lastModifiedUtc.isAfter(remote.conflictModifiedUtc)) {
      return const _ShopMergeOutcome();
    }
    final conflict =
        local.pendingOperation != ShopPendingOperation.none;
    if (remote.isDeleted) {
      await _repository.removeRecord(remote.id);
    } else {
      await _repository.saveRecord(_recordFromRemote(remote, existing: local));
    }
    return _ShopMergeOutcome(applied: true, conflictResolved: conflict);
  }

  Future<_ShopPushOutcome> _push(ShopLocalRecord local) async {
    final server = await _api.getById(local.id);
    if (local.pendingOperation == ShopPendingOperation.delete) {
      if (server == null) {
        await _repository.removeRecord(local.id);
        return const _ShopPushOutcome(pushed: true);
      }
      if (!local.lastModifiedUtc.isAfter(server.conflictModifiedUtc)) {
        await _repository.saveRecord(_recordFromRemote(server, existing: local));
        return const _ShopPushOutcome(conflictResolved: true);
      }
      final deleted = await _api.delete(local);
      if (deleted == null || deleted.isDeleted) {
        await _repository.removeRecord(local.id);
        return _ShopPushOutcome(
          pushed: deleted == null ||
              !deleted.conflictModifiedUtc.isAfter(local.lastModifiedUtc),
          conflictResolved: deleted != null &&
              deleted.conflictModifiedUtc.isAfter(local.lastModifiedUtc),
        );
      }
      await _repository.saveRecord(_recordFromRemote(deleted, existing: local));
      return const _ShopPushOutcome(conflictResolved: true);
    }

    if (server == null) {
      final created = await _api.create(local);
      return _applyWriteResponse(local, created);
    }
    if (!local.lastModifiedUtc.isAfter(server.conflictModifiedUtc)) {
      await _repository.saveRecord(_recordFromRemote(server, existing: local));
      return const _ShopPushOutcome(conflictResolved: true);
    }
    final updated = await _api.update(local);
    return _applyWriteResponse(local, updated);
  }

  Future<_ShopPushOutcome> _applyWriteResponse(
    ShopLocalRecord local,
    ShopRemoteModel remote,
  ) async {
    if (remote.isDeleted) {
      await _repository.removeRecord(local.id);
      return const _ShopPushOutcome(conflictResolved: true);
    }
    await _repository.saveRecord(_recordFromRemote(remote, existing: local));
    final serverWon = _serverWonWrite(local, remote);
    return _ShopPushOutcome(
      pushed: !serverWon,
      conflictResolved: serverWon,
    );
  }

  bool _serverWonWrite(ShopLocalRecord local, ShopRemoteModel remote) {
    final comparison =
        remote.conflictModifiedUtc.compareTo(local.lastModifiedUtc);
    return comparison > 0 ||
        (comparison == 0 && !_sameBusinessValues(local, remote));
  }

  bool _sameBusinessValues(ShopLocalRecord local, ShopRemoteModel remote) =>
      local.name == remote.name &&
      local.shopType == remote.shopType &&
      local.address == remote.address &&
      local.phoneNumber == remote.phoneNumber &&
      local.email == remote.email &&
      local.taxNumber == remote.taxNumber &&
      local.isActive == remote.isActive;

  ShopLocalRecord _recordFromRemote(
    ShopRemoteModel remote, {
    ShopLocalRecord? existing,
  }) {
    final timestamp = remote.conflictModifiedUtc.toUtc();
    return ShopLocalRecord(
      id: remote.id,
      name: remote.name,
      shopType: remote.shopType,
      address: remote.address,
      phoneNumber: remote.phoneNumber,
      email: remote.email,
      taxNumber: remote.taxNumber,
      isActive: remote.isActive,
      createdAt:
          existing?.createdAt ??
          remote.clientCreatedDate ??
          remote.clientModifiedDate ??
          timestamp,
      updatedAt: timestamp,
      lastModifiedUtc: timestamp,
      isDeleted: false,
      pendingOperation: ShopPendingOperation.none,
      syncStatus: ShopSyncStatus.synced,
      retryCount: 0,
      serverLastModifiedUtc: remote.lastModifiedUtc,
    );
  }

  Future<void> _markFailure(ShopLocalRecord record, String message) async {
    final retryCount = record.retryCount + 1;
    final exponent = retryCount.clamp(1, 6).toInt();
    await _repository.saveRecord(
      record.copyWith(
        syncStatus: ShopSyncStatus.failed,
        retryCount: retryCount,
        nextRetryAt: DateTime.now().toUtc().add(
          Duration(minutes: 1 << (exponent - 1)),
        ),
        lastSyncError: message,
      ),
    );
  }

  DateTime _later(DateTime? current, DateTime candidate) =>
      current == null || candidate.isAfter(current) ? candidate : current;
}

class _ShopMergeOutcome {
  const _ShopMergeOutcome({
    this.applied = false,
    this.conflictResolved = false,
  });

  final bool applied;
  final bool conflictResolved;
}

class _ShopPushOutcome {
  const _ShopPushOutcome({
    this.pushed = false,
    this.conflictResolved = false,
  });

  final bool pushed;
  final bool conflictResolved;
}
