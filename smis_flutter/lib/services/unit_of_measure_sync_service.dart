import 'package:dio/dio.dart';
import 'package:uuid/uuid.dart';

import '../data/data_exception.dart';
import '../data/unit_of_measure_api.dart';
import '../data/unit_of_measure_repository.dart';
import '../models/unit_of_measure.dart';
import '../models/unit_of_measure_local_record.dart';
import '../models/unit_of_measure_remote_model.dart';
import 'connectivity_service.dart';

class UnitOfMeasureSyncFailure {
  const UnitOfMeasureSyncFailure({
    required this.phase,
    required this.error,
    required this.stackTrace,
    this.unitOfMeasureId,
  });

  final String phase;
  final String? unitOfMeasureId;
  final Object error;
  final StackTrace stackTrace;

  String toDevelopmentString() {
    final buffer = StringBuffer()
      ..writeln('Phase: $phase')
      ..writeln('Unit of measurement ID: ${unitOfMeasureId ?? '(not available)'}')
      ..writeln('Exception: ${error.runtimeType}: $error');
    if (error case final AppException appException
        when appException.cause != null) {
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
    buffer
      ..writeln('Stack trace:')
      ..write(stackTrace);
    return buffer.toString();
  }
}

class UnitOfMeasureSyncResult {
  const UnitOfMeasureSyncResult({
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
  final List<UnitOfMeasureSyncFailure> failures;
}

class UnitOfMeasureSyncService {
  UnitOfMeasureSyncService(this._repository, this._api, this._connectivity);

  final UnitOfMeasureRepository _repository;
  final UnitOfMeasureApi _api;
  final NetworkConnectivity _connectivity;

  Future<UnitOfMeasureSyncResult> synchronize({
    required String shopId,
    bool force = false,
  }) async {
    final owner = const Uuid().v4();
    if (!await _repository.tryAcquireSyncLock(owner, shopId)) {
      return UnitOfMeasureSyncResult(
        success: true,
        message: 'A unit of measurement sync is already running.',
        pending: await _repository.getPendingCount(shopId),
      );
    }

    var pulled = 0;
    var pushed = 0;
    var failed = 0;
    var conflicts = 0;
    var transientFailure = false;
    var phase = 'connectivity check';
    final failures = <UnitOfMeasureSyncFailure>[];
    try {
      if (!await _connectivity.hasConnection) {
        return UnitOfMeasureSyncResult(
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
          shopId,
          overlapped.isAfter(cursor) ? overlapped : cursor,
        );
      }

      phase = 'push';
      for (final localRecord in await _repository.getPendingRecords(
        shopId: shopId,
        force: force,
      )) {
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
      final remaining = await _repository.getPendingCount(shopId);
      return UnitOfMeasureSyncResult(
        success: failed == 0,
        message: failed == 0
            ? 'Unit of measurement sync completed.'
            : 'Unit of measurement sync completed with $failed failed request(s).',
        pulled: pulled,
        pushed: pushed,
        failed: failed,
        conflictsResolved: conflicts,
        pending: remaining,
        transientFailure: transientFailure,
        failures: failures,
      );
    } on RemoteTransientException catch (error, stackTrace) {
      return await _failedResult(
        shopId: shopId,
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
      return await _failedResult(
        shopId: shopId,
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
      return await _failedResult(
        shopId: shopId,
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
      await _repository.releaseSyncLock(owner, shopId);
    }
  }

  Future<UnitOfMeasureSyncResult> _failedResult({
    required String shopId,
    required Object error,
    required StackTrace stackTrace,
    required String phase,
    required int pulled,
    required int pushed,
    required int failed,
    required int conflicts,
    required bool transient,
    required List<UnitOfMeasureSyncFailure> failures,
  }) async => UnitOfMeasureSyncResult(
    success: false,
    message: error is AppException
        ? '${error.message}${transient ? ' Local changes will retry later.' : ''}'
        : 'Unit of measurement sync failed unexpectedly.',
    pulled: pulled,
    pushed: pushed,
    failed: failed + 1,
    conflictsResolved: conflicts,
    pending: await _repository.getPendingCount(shopId),
    transientFailure: transient,
    failures: [
      ...failures,
      UnitOfMeasureSyncFailure(
        phase: phase,
        error: error,
        stackTrace: stackTrace,
      ),
    ],
  );

  UnitOfMeasureSyncFailure _failure(
    UnitOfMeasureLocalRecord record,
    Object error,
    StackTrace stackTrace,
  ) => UnitOfMeasureSyncFailure(
    phase: 'push ${record.pendingOperation.name}',
    unitOfMeasureId: record.id,
    error: error,
    stackTrace: stackTrace,
  );

  Future<_UnitMergeOutcome> _mergeRemote(UnitOfMeasureRemoteModel remote) async {
    final local = await _repository.getRecord(remote.id);
    if (local == null) {
      if (!remote.isDeleted) {
        await _repository.saveRecord(_recordFromRemote(remote));
        return const _UnitMergeOutcome(applied: true);
      }
      return const _UnitMergeOutcome();
    }
    // Last-write-wins. The server wins exact timestamp ties.
    if (local.lastModifiedUtc.isAfter(remote.conflictModifiedUtc)) {
      return const _UnitMergeOutcome();
    }
    final conflict = local.pendingOperation != UnitOfMeasurePendingOperation.none;
    if (remote.isDeleted) {
      await _repository.removeRecord(remote.id);
    } else {
      await _repository.saveRecord(_recordFromRemote(remote, existing: local));
    }
    return _UnitMergeOutcome(applied: true, conflictResolved: conflict);
  }

  Future<_UnitPushOutcome> _push(UnitOfMeasureLocalRecord local) async {
    final server = await _api.getById(local.id);
    if (local.pendingOperation == UnitOfMeasurePendingOperation.delete) {
      if (server == null) {
        await _repository.removeRecord(local.id);
        return const _UnitPushOutcome(pushed: true);
      }
      if (!local.lastModifiedUtc.isAfter(server.conflictModifiedUtc)) {
        await _repository.saveRecord(_recordFromRemote(server, existing: local));
        return const _UnitPushOutcome(conflictResolved: true);
      }
      await _api.delete(local);
      await _repository.removeRecord(local.id);
      return const _UnitPushOutcome(pushed: true);
    }
    if (server == null) {
      final created = await _api.create(local);
      if (created.isDeleted) {
        await _repository.removeRecord(local.id);
        return const _UnitPushOutcome(conflictResolved: true);
      }
      await _repository.saveRecord(_recordFromRemote(created, existing: local));
      return const _UnitPushOutcome(pushed: true);
    }
    if (!local.lastModifiedUtc.isAfter(server.conflictModifiedUtc)) {
      await _repository.saveRecord(_recordFromRemote(server, existing: local));
      return const _UnitPushOutcome(conflictResolved: true);
    }
    final updated = await _api.update(local);
    if (updated.isDeleted) {
      await _repository.removeRecord(local.id);
      return const _UnitPushOutcome(conflictResolved: true);
    }
    await _repository.saveRecord(_recordFromRemote(updated, existing: local));
    return const _UnitPushOutcome(pushed: true);
  }

  UnitOfMeasureLocalRecord _recordFromRemote(
    UnitOfMeasureRemoteModel remote, {
    UnitOfMeasureLocalRecord? existing,
  }) {
    final timestamp = remote.conflictModifiedUtc.toUtc();
    return UnitOfMeasureLocalRecord(
      id: remote.id,
      name: remote.name,
      symbol: remote.symbol,
      description: remote.description,
      shopId: remote.shopId,
      createdAt: existing?.createdAt ?? remote.clientCreatedDate ?? remote.createdDate ?? timestamp,
      updatedAt: timestamp,
      lastModifiedUtc: timestamp,
      isDeleted: false,
      pendingOperation: UnitOfMeasurePendingOperation.none,
      syncStatus: UnitOfMeasureSyncStatus.synced,
      retryCount: 0,
      serverCreatedDate: remote.createdDate,
      serverUpdatedDate: remote.updatedDate,
      serverCreatedBy: remote.createdBy,
      serverUpdatedBy: remote.updatedBy,
      serverLastModifiedUtc: remote.lastModifiedUtc,
    );
  }

  Future<void> _markFailure(UnitOfMeasureLocalRecord record, String message) async {
    final retryCount = record.retryCount + 1;
    final exponent = retryCount.clamp(1, 6).toInt();
    await _repository.saveRecord(
      record.copyWith(
        syncStatus: UnitOfMeasureSyncStatus.failed,
        retryCount: retryCount,
        nextRetryAt: DateTime.now().toUtc().add(Duration(minutes: 1 << (exponent - 1))),
        lastSyncError: message,
      ),
    );
  }

  DateTime _later(DateTime? current, DateTime candidate) =>
      current == null || candidate.isAfter(current) ? candidate : current;
}

class _UnitMergeOutcome {
  const _UnitMergeOutcome({this.applied = false, this.conflictResolved = false});
  final bool applied;
  final bool conflictResolved;
}

class _UnitPushOutcome {
  const _UnitPushOutcome({this.pushed = false, this.conflictResolved = false});
  final bool pushed;
  final bool conflictResolved;
}
