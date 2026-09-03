import 'package:dio/dio.dart';
import 'package:uuid/uuid.dart';

import '../data/category_api.dart';
import '../data/category_repository.dart';
import '../data/data_exception.dart';
import '../models/category.dart';
import '../models/category_local_record.dart';
import '../models/category_remote_model.dart';
import 'connectivity_service.dart';

class CategorySyncFailure {
  const CategorySyncFailure({
    required this.phase,
    required this.error,
    required this.stackTrace,
    this.categoryId,
  });

  final String phase;
  final String? categoryId;
  final Object error;
  final StackTrace stackTrace;

  String toDevelopmentString() {
    final buffer = StringBuffer()
      ..writeln('Phase: $phase')
      ..writeln('Category ID: ${categoryId ?? '(not available)'}')
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

class CategorySyncResult {
  const CategorySyncResult({
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
  final List<CategorySyncFailure> failures;

  String messageFor({required bool includeDiagnostics}) {
    if (!includeDiagnostics || failures.isEmpty) return message;
    return '$message\n\n${failures.map((failure) => failure.toDevelopmentString()).join('\n\n')}';
  }
}

class CategorySyncService {
  CategorySyncService(this._repository, this._api, this._connectivity);

  final CategoryRepository _repository;
  final CategoryApi _api;
  final NetworkConnectivity _connectivity;

  Future<CategorySyncResult> synchronize({bool force = false}) async {
    final owner = const Uuid().v4();
    if (!await _repository.tryAcquireSyncLock(owner)) {
      return CategorySyncResult(
        success: true,
        message: 'A Category sync is already running.',
        pending: await _repository.getPendingCount(),
      );
    }

    var pulled = 0;
    var pushed = 0;
    var failed = 0;
    var conflicts = 0;
    var transientFailure = false;
    var phase = 'connectivity check';
    final failures = <CategorySyncFailure>[];

    try {
      if (!await _isConnected()) {
        return CategorySyncResult(
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
      final pending = await _repository.getPendingRecords(force: force);
      for (final localRecord in pending) {
        try {
          final outcome = await _push(localRecord);
          pushed += outcome.pushed ? 1 : 0;
          conflicts += outcome.conflictResolved ? 1 : 0;
        } on RemoteTransientException catch (error, stackTrace) {
          failures.add(
            CategorySyncFailure(
              phase: 'push ${localRecord.pendingOperation.name}',
              categoryId: localRecord.id,
              error: error,
              stackTrace: stackTrace,
            ),
          );
          await _markFailure(localRecord, error.message);
          failed++;
          transientFailure = true;
          break;
        } on RemotePermanentException catch (error, stackTrace) {
          failures.add(
            CategorySyncFailure(
              phase: 'push ${localRecord.pendingOperation.name}',
              categoryId: localRecord.id,
              error: error,
              stackTrace: stackTrace,
            ),
          );
          await _markFailure(localRecord, error.message);
          failed++;
        } catch (error, stackTrace) {
          failures.add(
            CategorySyncFailure(
              phase: 'push ${localRecord.pendingOperation.name}',
              categoryId: localRecord.id,
              error: error,
              stackTrace: stackTrace,
            ),
          );
          await _markFailure(localRecord, error.toString());
          failed++;
          transientFailure = true;
          break;
        }
      }

      final remaining = await _repository.getPendingCount();
      final success = failed == 0;
      return CategorySyncResult(
        success: success,
        message: success
            ? 'Category sync completed.'
            : 'Category sync completed with $failed failed request(s).',
        pulled: pulled,
        pushed: pushed,
        failed: failed,
        conflictsResolved: conflicts,
        pending: remaining,
        transientFailure: transientFailure,
        failures: failures,
      );
    } on RemoteTransientException catch (error, stackTrace) {
      return CategorySyncResult(
        success: false,
        message: '${error.message} Local changes will retry later.',
        pulled: pulled,
        pushed: pushed,
        failed: failed + 1,
        conflictsResolved: conflicts,
        pending: await _repository.getPendingCount(),
        transientFailure: true,
        failures: [
          ...failures,
          CategorySyncFailure(
            phase: phase,
            error: error,
            stackTrace: stackTrace,
          ),
        ],
      );
    } on RemotePermanentException catch (error, stackTrace) {
      return CategorySyncResult(
        success: false,
        message: error.message,
        pulled: pulled,
        pushed: pushed,
        failed: failed + 1,
        conflictsResolved: conflicts,
        pending: await _repository.getPendingCount(),
        failures: [
          ...failures,
          CategorySyncFailure(
            phase: phase,
            error: error,
            stackTrace: stackTrace,
          ),
        ],
      );
    } catch (error, stackTrace) {
      return CategorySyncResult(
        success: false,
        message: 'Category sync failed unexpectedly.',
        pulled: pulled,
        pushed: pushed,
        failed: failed + 1,
        conflictsResolved: conflicts,
        pending: await _repository.getPendingCount(),
        transientFailure: true,
        failures: [
          ...failures,
          CategorySyncFailure(
            phase: phase,
            error: error,
            stackTrace: stackTrace,
          ),
        ],
      );
    } finally {
      await _repository.releaseSyncLock(owner);
    }
  }

  Future<_MergeOutcome> _mergeRemote(CategoryRemoteModel remote) async {
    final localRecord = await _repository.getRecord(remote.id);
    if (localRecord == null) {
      if (!remote.isDeleted) {
        await _repository.saveRecord(_recordFromRemote(remote));
        return const _MergeOutcome(applied: true);
      }
      return const _MergeOutcome();
    }

    // Last-write-wins; server wins exact ties for deterministic convergence.
    if (localRecord.lastModifiedUtc.isAfter(remote.conflictModifiedUtc)) {
      return const _MergeOutcome();
    }

    final conflict =
        localRecord.pendingOperation != CategoryPendingOperation.none;
    if (remote.isDeleted) {
      await _repository.removeRecord(remote.id);
    } else {
      await _repository.saveRecord(
        _recordFromRemote(remote, existing: localRecord),
      );
    }
    return _MergeOutcome(applied: true, conflictResolved: conflict);
  }

  Future<_PushOutcome> _push(CategoryLocalRecord localRecord) async {
    final server = await _api.getById(localRecord.id);

    if (localRecord.pendingOperation == CategoryPendingOperation.delete) {
      if (server == null) {
        await _repository.removeRecord(localRecord.id);
        return const _PushOutcome(pushed: true);
      }
      if (!localRecord.lastModifiedUtc.isAfter(server.conflictModifiedUtc)) {
        await _repository.saveRecord(
          _recordFromRemote(server, existing: localRecord),
        );
        return const _PushOutcome(conflictResolved: true);
      }
      await _api.delete(localRecord);
      await _repository.removeRecord(localRecord.id);
      return const _PushOutcome(pushed: true);
    }

    if (server == null) {
      final created = await _api.create(localRecord);
      if (created.isDeleted) {
        await _repository.removeRecord(localRecord.id);
        return const _PushOutcome(conflictResolved: true);
      }
      await _repository.saveRecord(
        _recordFromRemote(created, existing: localRecord),
      );
      return const _PushOutcome(pushed: true);
    }

    if (!localRecord.lastModifiedUtc.isAfter(server.conflictModifiedUtc)) {
      await _repository.saveRecord(
        _recordFromRemote(server, existing: localRecord),
      );
      return const _PushOutcome(conflictResolved: true);
    }

    final updated = await _api.update(localRecord);
    if (updated.isDeleted) {
      await _repository.removeRecord(localRecord.id);
      return const _PushOutcome(conflictResolved: true);
    }
    await _repository.saveRecord(
      _recordFromRemote(updated, existing: localRecord),
    );
    return const _PushOutcome(pushed: true);
  }

  CategoryLocalRecord _recordFromRemote(
    CategoryRemoteModel remote, {
    CategoryLocalRecord? existing,
  }) {
    final conflictTimestamp = remote.conflictModifiedUtc.toUtc();
    return CategoryLocalRecord(
      id: remote.id,
      name: remote.name,
      code: remote.code,
      description: remote.description,
      isActive: remote.isActive,
      shopId: remote.shopId,
      createdAt:
          existing?.createdAt ??
          remote.clientCreatedDate ??
          remote.createdDate ??
          conflictTimestamp,
      updatedAt: conflictTimestamp,
      lastModifiedUtc: conflictTimestamp,
      isDeleted: false,
      pendingOperation: CategoryPendingOperation.none,
      syncStatus: CategorySyncStatus.synced,
      retryCount: 0,
      serverCreatedDate: remote.createdDate,
      serverUpdatedDate: remote.updatedDate,
      serverCreatedBy: remote.createdBy,
      serverUpdatedBy: remote.updatedBy,
      serverLastModifiedUtc: remote.lastModifiedUtc,
    );
  }

  Future<void> _markFailure(CategoryLocalRecord record, String message) async {
    final retryCount = record.retryCount + 1;
    final exponent = retryCount.clamp(1, 6);
    final delay = Duration(minutes: 1 << (exponent - 1));
    await _repository.saveRecord(
      record.copyWith(
        syncStatus: CategorySyncStatus.failed,
        retryCount: retryCount,
        nextRetryAt: DateTime.now().toUtc().add(delay),
        lastSyncError: message,
      ),
    );
  }

  Future<bool> _isConnected() => _connectivity.hasConnection;

  DateTime _later(DateTime? current, DateTime candidate) =>
      current == null || candidate.isAfter(current) ? candidate : current;
}

class _MergeOutcome {
  const _MergeOutcome({this.applied = false, this.conflictResolved = false});

  final bool applied;
  final bool conflictResolved;
}

class _PushOutcome {
  const _PushOutcome({this.pushed = false, this.conflictResolved = false});

  final bool pushed;
  final bool conflictResolved;
}
