import 'package:sqflite/sqflite.dart';

import '../../../../core/database/app_database.dart';
import '../../../../core/error/app_exception.dart';
import '../models/category_local_record.dart';

/// Handles SQLite operations.
/// Think of this as your Data Access Layer (DAL) or a repository that uses Dapper.
class CategoryLocalDataSource {
  CategoryLocalDataSource(this._appDatabase);

  static const _table = 'categories';
  static const _pullCursorKey = 'category_pull_cursor';
  static const _syncLockKey = 'category_sync_lock';

  final AppDatabase _appDatabase;

  Future<List<CategoryLocalRecord>> getVisible() async {
    try {
      final database = await _appDatabase.instance;
      // .query() is a helper that generates a SELECT statement.
      final rows = await database.query(
        _table,
        where: 'is_deleted = 0',
        orderBy: 'name COLLATE NOCASE ASC',
      );
      // We map the raw Map<String, Object?> from SQLite to our LocalRecord objects.
      return rows.map(CategoryLocalRecord.fromMap).toList(growable: false);
    } catch (error) {
      throw LocalStorageException(
        'Could not read categories from local storage.',
        cause: error,
      );
    }
  }

  Future<CategoryLocalRecord?> getById(String id) async {
    final database = await _appDatabase.instance;
    final rows = await database.query(
      _table,
      where: 'id = ?', // Use '?' for parameter injection to prevent SQL injection.
      whereArgs: [id],
      limit: 1,
    );
    return rows.isEmpty ? null : CategoryLocalRecord.fromMap(rows.first);
  }

  Future<void> put(CategoryLocalRecord record) async {
    final database = await _appDatabase.instance;
    await database.insert(
      _table,
      record.toMap(),
      // 'replace' means if the ID exists, it will overwrite the row.
      conflictAlgorithm: ConflictAlgorithm.replace,
    );
  }

  Future<void> deletePermanently(String id) async {
    final database = await _appDatabase.instance;
    await database.delete(_table, where: 'id = ?', whereArgs: [id]);
  }

  Future<List<CategoryLocalRecord>> getPending({required bool force}) async {
    final database = await _appDatabase.instance;
    final now = DateTime.now().toUtc().toIso8601String();
    final retryFilter = force
        ? ''
        : ' AND retry_count < 5 AND '
              '(next_retry_at IS NULL OR next_retry_at <= ?)';
    final rows = await database.query(
      _table,
      where: "pending_operation != 'none'$retryFilter",
      whereArgs: force ? null : [now],
      orderBy: 'last_modified_utc ASC',
    );
    return rows.map(CategoryLocalRecord.fromMap).toList(growable: false);
  }

  Future<int> getPendingCount() async {
    final database = await _appDatabase.instance;
    final result = await database.rawQuery(
      "SELECT COUNT(*) AS count FROM $_table WHERE pending_operation != 'none'",
    );
    return Sqflite.firstIntValue(result) ?? 0;
  }

  Future<DateTime> getPullCursor() async {
    final value = await _getMetadata(_pullCursorKey);
    return value == null
        ? DateTime.fromMillisecondsSinceEpoch(0, isUtc: true)
        : DateTime.parse(value).toUtc();
  }

  Future<void> setPullCursor(DateTime value) =>
      _setMetadata(_pullCursorKey, value.toUtc().toIso8601String());

  Future<bool> tryAcquireSyncLock(String owner) async {
    final database = await _appDatabase.instance;
    return database.transaction((transaction) async {
      final rows = await transaction.query(
        'sync_metadata',
        where: 'key = ?',
        whereArgs: [_syncLockKey],
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
        'key': _syncLockKey,
        'value': '$owner|${DateTime.now().toUtc().toIso8601String()}',
      }, conflictAlgorithm: ConflictAlgorithm.replace);
      return true;
    });
  }

  Future<void> releaseSyncLock(String owner) async {
    final database = await _appDatabase.instance;
    await database.delete(
      'sync_metadata',
      where: "key = ? AND value LIKE ?",
      whereArgs: [_syncLockKey, '$owner|%'],
    );
  }

  Future<String?> _getMetadata(String key) async {
    final database = await _appDatabase.instance;
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
    final database = await _appDatabase.instance;
    await database.insert('sync_metadata', {
      'key': key,
      'value': value,
    }, conflictAlgorithm: ConflictAlgorithm.replace);
  }
}
