import 'package:uuid/uuid.dart';

import '../../../../core/error/app_exception.dart';
import '../../../../core/network/connectivity_service.dart';
import '../../domain/entities/category.dart';
import '../datasources/category_local_data_source.dart';
import '../datasources/category_remote_data_source.dart';
import '../models/category_local_record.dart';
import '../models/category_remote_model.dart';

/// Represents the result of a sync operation.
/// Similar to a 'SyncResult' or 'CommandResult' DTO in .NET.
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
}

/// Orchestrates synchronization between local storage and remote API.
/// This implements an 'Offline-First' pattern: data is saved locally first, 
/// then synced to the server whenever connectivity is available.
class CategorySyncService {
  CategorySyncService(this._local, this._remote, this._connectivity);

  final CategoryLocalDataSource _local;
  final CategoryRemoteDataSource _remote;
  final NetworkConnectivity _connectivity;

  Future<CategorySyncResult> synchronize({bool force = false}) async {
    final owner = const Uuid().v4();
    // Using a simple 'Sync Lock' in the database to prevent concurrent sync operations.
    if (!await _local.tryAcquireSyncLock(owner)) {
      return CategorySyncResult(
        success: true,
        message: 'A Category sync is already running.',
        pending: await _local.getPendingCount(),
      );
    }

    var pulled = 0;
    var pushed = 0;
    var failed = 0;
    var conflicts = 0;
    var transientFailure = false;

    try {
      if (!await _isConnected()) {
        return CategorySyncResult(
          success: false,
          message: 'Offline. Local changes are safe and will retry later.',
          pending: await _local.getPendingCount(),
          transientFailure: true,
          skippedOffline: true,
        );
      }

      // 1. PULL PHASE: Get changes from the server.
      final cursor = await _local.getPullCursor();
      final remoteChanges = await _remote.pull(cursor);
      DateTime? newestRemoteWrite;
      for (final remote in remoteChanges) {
        newestRemoteWrite = _later(newestRemoteWrite, remote.lastModifiedUtc);
        final outcome = await _mergeRemote(remote);
        pulled += outcome.applied ? 1 : 0;
        conflicts += outcome.conflictResolved ? 1 : 0;
      }
      
      // Update our cursor so next time we only pull NEW records.
      if (newestRemoteWrite != null) {
        final overlapped = newestRemoteWrite.subtract(
          const Duration(milliseconds: 1),
        );
        await _local.setPullCursor(
          overlapped.isAfter(cursor) ? overlapped : cursor,
        );
      }

      // 2. PUSH PHASE: Send local changes to the server.
      final pending = await _local.getPending(force: force);
      for (final localRecord in pending) {
        try {
          final outcome = await _push(localRecord);
          pushed += outcome.pushed ? 1 : 0;
          conflicts += outcome.conflictResolved ? 1 : 0;
        } on RemoteTransientException catch (error) {
          // If it's a temporary network error, we track it for retry.
          await _markFailure(localRecord, error.message);
          failed++;
          transientFailure = true;
          break;
        } catch (error) {
          await _markFailure(localRecord, error.toString());
          failed++;
          transientFailure = true;
          break;
        }
      }

      final remaining = await _local.getPendingCount();
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
      );
    } on RemoteTransientException catch (error) {
      return CategorySyncResult(
        success: false,
        message: '${error.message} Local changes will retry later.',
        pulled: pulled,
        pushed: pushed,
        failed: failed + 1,
        conflictsResolved: conflicts,
        pending: await _local.getPendingCount(),
        transientFailure: true,
      );
    } on RemotePermanentException catch (error) {
      return CategorySyncResult(
        success: false,
        message: error.message,
        pulled: pulled,
        pushed: pushed,
        failed: failed + 1,
        conflictsResolved: conflicts,
        pending: await _local.getPendingCount(),
      );
    } finally {
      await _local.releaseSyncLock(owner);
    }
  }

  Future<_MergeOutcome> _mergeRemote(CategoryRemoteModel remote) async {
    final localRecord = await _local.getById(remote.id);
    if (localRecord == null) {
      if (!remote.isDeleted) {
        await _local.put(_recordFromRemote(remote));
        return const _MergeOutcome(applied: true);
      }
      return const _MergeOutcome();
    }

    // Last-write-wins; server wins exact ties for deterministic convergence.
    if (localRecord.lastModifiedUtc.isAfter(remote.lastModifiedUtc)) {
      return const _MergeOutcome();
    }

    final conflict =
        localRecord.pendingOperation != CategoryPendingOperation.none;
    if (remote.isDeleted) {
      await _local.deletePermanently(remote.id);
    } else {
      await _local.put(_recordFromRemote(remote, existing: localRecord));
    }
    return _MergeOutcome(applied: true, conflictResolved: conflict);
  }

  Future<_PushOutcome> _push(CategoryLocalRecord localRecord) async {
    final server = await _remote.getById(localRecord.id);

    if (localRecord.pendingOperation == CategoryPendingOperation.delete) {
      if (server == null) {
        await _local.deletePermanently(localRecord.id);
        return const _PushOutcome(pushed: true);
      }
      if (!localRecord.lastModifiedUtc.isAfter(server.lastModifiedUtc)) {
        await _local.put(_recordFromRemote(server, existing: localRecord));
        return const _PushOutcome(conflictResolved: true);
      }
      await _remote.delete(localRecord.id);
      await _local.deletePermanently(localRecord.id);
      return const _PushOutcome(pushed: true);
    }

    if (server == null) {
      final created = await _remote.create(localRecord);
      await _local.put(_recordFromRemote(created, existing: localRecord));
      return const _PushOutcome(pushed: true);
    }

    if (!localRecord.lastModifiedUtc.isAfter(server.lastModifiedUtc)) {
      await _local.put(_recordFromRemote(server, existing: localRecord));
      return const _PushOutcome(conflictResolved: true);
    }

    final updated = await _remote.update(localRecord);
    await _local.put(_recordFromRemote(updated, existing: localRecord));
    return const _PushOutcome(pushed: true);
  }

  CategoryLocalRecord _recordFromRemote(
    CategoryRemoteModel remote, {
    CategoryLocalRecord? existing,
  }) {
    final timestamp = remote.lastModifiedUtc.toUtc();
    return CategoryLocalRecord(
      id: remote.id,
      name: remote.name,
      code: remote.code,
      description: remote.description,
      isActive: remote.isActive,
      shopId: remote.shopId,
      createdAt: existing?.createdAt ?? timestamp,
      updatedAt: timestamp,
      lastModifiedUtc: timestamp,
      isDeleted: false,
      pendingOperation: CategoryPendingOperation.none,
      syncStatus: CategorySyncStatus.synced,
      retryCount: 0,
    );
  }

  Future<void> _markFailure(CategoryLocalRecord record, String message) async {
    final retryCount = record.retryCount + 1;
    final exponent = retryCount.clamp(1, 6);
    final delay = Duration(minutes: 1 << (exponent - 1));
    await _local.put(
      record.copyWith(
        syncStatus: CategorySyncStatus.failed,
        retryCount: retryCount,
        nextRetryAt: DateTime.now().toUtc().add(delay),
        lastSyncError: message,
      ),
    );
  }

  Future<bool> _isConnected() async {
    try {
      return await _connectivity.hasConnection;
    } catch (_) {
      return false;
    }
  }

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
