import 'package:sqflite/sqflite.dart';
import 'package:uuid/uuid.dart';

import '../models/unit_of_measure.dart';
import '../models/unit_of_measure_local_record.dart';
import 'data_exception.dart';
import 'database.dart';

typedef UnitOfMeasureUtcNow = DateTime Function();
typedef UnitOfMeasureIdGenerator = String Function();

class UnitOfMeasureRepository {
  UnitOfMeasureRepository(
    this._database, {
    UnitOfMeasureUtcNow? utcNow,
    UnitOfMeasureIdGenerator? idGenerator,
  }) : _utcNow = utcNow ?? (() => DateTime.now().toUtc()),
       _idGenerator = idGenerator ?? const Uuid().v4;

  static const _table = 'unit_of_measures';
  static const _pullCursorKey = 'unit_of_measure_pull_cursor';
  static const _syncLockKey = 'unit_of_measure_sync_lock';

  final AppDatabase _database;
  final UnitOfMeasureUtcNow _utcNow;
  final UnitOfMeasureIdGenerator _idGenerator;

  Future<List<UnitOfMeasure>> getAll(String shopId) async {
    try {
      final database = await _database.instance;
      final rows = await database.query(
        _table,
        where: 'is_deleted = 0 AND shop_id = ?',
        whereArgs: [shopId],
        orderBy: 'name COLLATE NOCASE ASC',
      );
      return rows
          .map(UnitOfMeasureLocalRecord.fromMap)
          .map((record) => record.toUnitOfMeasure())
          .toList(growable: false);
    } catch (error) {
      throw LocalStorageException(
        'Could not read units of measurement from local storage.',
        cause: error,
      );
    }
  }

  Future<UnitOfMeasure> create(UnitOfMeasureDraft draft, String shopId) async {
    final normalized = draft.normalized();
    final now = _utcNow();
    final record = UnitOfMeasureLocalRecord(
      id: _idGenerator(),
      name: normalized.name,
      symbol: normalized.symbol,
      description: normalized.description,
      shopId: shopId,
      createdAt: now,
      updatedAt: now,
      lastModifiedUtc: now,
      isDeleted: false,
      pendingOperation: UnitOfMeasurePendingOperation.create,
      syncStatus: UnitOfMeasureSyncStatus.pendingCreate,
      retryCount: 0,
    );
    await saveRecord(record);
    return record.toUnitOfMeasure();
  }

  Future<UnitOfMeasure> update(String id, UnitOfMeasureDraft draft) async {
    final existing = await getRecord(id);
    if (existing == null || existing.isDeleted) {
      throw const LocalStorageException('Unit of measurement was not found.');
    }
    final normalized = draft.normalized();
    final now = _monotonicNow(existing.lastModifiedUtc);
    final remainsCreate =
        existing.pendingOperation == UnitOfMeasurePendingOperation.create;
    final updated = existing.copyWith(
      name: normalized.name,
      symbol: normalized.symbol,
      description: normalized.description,
      clearDescription: normalized.description == null,
      updatedAt: now,
      lastModifiedUtc: now,
      pendingOperation: remainsCreate
          ? UnitOfMeasurePendingOperation.create
          : UnitOfMeasurePendingOperation.update,
      syncStatus: remainsCreate
          ? UnitOfMeasureSyncStatus.pendingCreate
          : UnitOfMeasureSyncStatus.pendingUpdate,
      retryCount: 0,
      clearNextRetryAt: true,
      clearLastSyncError: true,
    );
    await saveRecord(updated);
    return updated.toUnitOfMeasure();
  }

  Future<void> delete(String id) async {
    final existing = await getRecord(id);
    if (existing == null) return;
    if (existing.pendingOperation == UnitOfMeasurePendingOperation.create) {
      await removeRecord(id);
      return;
    }
    final now = _monotonicNow(existing.lastModifiedUtc);
    await saveRecord(
      existing.copyWith(
        isDeleted: true,
        updatedAt: now,
        lastModifiedUtc: now,
        pendingOperation: UnitOfMeasurePendingOperation.delete,
        syncStatus: UnitOfMeasureSyncStatus.pendingDelete,
        retryCount: 0,
        clearNextRetryAt: true,
        clearLastSyncError: true,
      ),
    );
  }

  Future<UnitOfMeasureLocalRecord?> getRecord(String id) async {
    final database = await _database.instance;
    final rows = await database.query(
      _table,
      where: 'id = ?',
      whereArgs: [id],
      limit: 1,
    );
    return rows.isEmpty ? null : UnitOfMeasureLocalRecord.fromMap(rows.first);
  }

  Future<void> saveRecord(UnitOfMeasureLocalRecord record) async {
    final database = await _database.instance;
    await database.insert(
      _table,
      record.toMap(),
      conflictAlgorithm: ConflictAlgorithm.replace,
    );
  }

  Future<void> removeRecord(String id) async {
    final database = await _database.instance;
    await database.delete(_table, where: 'id = ?', whereArgs: [id]);
  }

  Future<List<UnitOfMeasureLocalRecord>> getPendingRecords({
    required String shopId,
    required bool force,
  }) async {
    final database = await _database.instance;
    final now = DateTime.now().toUtc().toIso8601String();
    final retryFilter = force
        ? ''
        : ' AND retry_count < 5 AND '
              '(next_retry_at IS NULL OR next_retry_at <= ?)';
    final rows = await database.query(
      _table,
      where: "pending_operation != 'none' AND shop_id = ?$retryFilter",
      whereArgs: force ? [shopId] : [shopId, now],
      orderBy: 'last_modified_utc ASC',
    );
    return rows
        .map(UnitOfMeasureLocalRecord.fromMap)
        .toList(growable: false);
  }

  Future<int> getPendingCount(String shopId) async {
    final database = await _database.instance;
    final result = await database.rawQuery(
      "SELECT COUNT(*) AS count FROM $_table WHERE pending_operation != 'none' AND shop_id = ?",
      [shopId],
    );
    return Sqflite.firstIntValue(result) ?? 0;
  }

  Future<DateTime> getPullCursor(String shopId) async {
    final value = await _getMetadata('${_pullCursorKey}_$shopId');
    return value == null
        ? DateTime.fromMillisecondsSinceEpoch(0, isUtc: true)
        : DateTime.parse(value).toUtc();
  }

  Future<void> setPullCursor(String shopId, DateTime value) =>
      _setMetadata('${_pullCursorKey}_$shopId', value.toUtc().toIso8601String());

  Future<bool> tryAcquireSyncLock(String owner, String shopId) async {
    final database = await _database.instance;
    return database.transaction((transaction) async {
      final rows = await transaction.query(
        'sync_metadata',
        where: 'key = ?',
        whereArgs: ['${_syncLockKey}_$shopId'],
        limit: 1,
      );
      if (rows.isNotEmpty) {
        final parts = (rows.first['value']! as String).split('|');
        final lockedAt = DateTime.tryParse(parts.last)?.toUtc();
        if (lockedAt != null &&
            DateTime.now().toUtc().difference(lockedAt) <
                const Duration(minutes: 10)) {
          return false;
        }
      }
      await transaction.insert('sync_metadata', {
        'key': '${_syncLockKey}_$shopId',
        'value': '$owner|${DateTime.now().toUtc().toIso8601String()}',
      }, conflictAlgorithm: ConflictAlgorithm.replace);
      return true;
    });
  }

  Future<void> releaseSyncLock(String owner, String shopId) async {
    final database = await _database.instance;
    await database.delete(
      'sync_metadata',
      where: 'key = ? AND value LIKE ?',
      whereArgs: ['${_syncLockKey}_$shopId', '$owner|%'],
    );
  }

  Future<String?> _getMetadata(String key) async {
    final database = await _database.instance;
    final rows = await database.query(
      'sync_metadata',
      columns: ['value'],
      where: 'key = ?',
      whereArgs: [key],
      limit: 1,
    );
    return rows.isEmpty ? null : rows.first['value']! as String;
  }

  Future<void> _setMetadata(String key, String value) async {
    final database = await _database.instance;
    await database.insert('sync_metadata', {
      'key': key,
      'value': value,
    }, conflictAlgorithm: ConflictAlgorithm.replace);
  }

  DateTime _monotonicNow(DateTime previous) {
    final now = _utcNow();
    return now.isAfter(previous)
        ? now
        : previous.add(const Duration(microseconds: 1));
  }
}
