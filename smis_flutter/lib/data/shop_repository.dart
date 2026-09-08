import 'package:sqflite/sqflite.dart';
import 'package:uuid/uuid.dart';

import '../models/shop.dart';
import '../models/shop_local_record.dart';
import 'data_exception.dart';
import 'database.dart';

typedef ShopUtcNow = DateTime Function();
typedef ShopIdGenerator = String Function();

class ShopRepository {
  ShopRepository(
    this._database, {
    ShopUtcNow? utcNow,
    ShopIdGenerator? idGenerator,
  }) : _utcNow = utcNow ?? (() => DateTime.now().toUtc()),
       _idGenerator = idGenerator ?? const Uuid().v4;

  static const _table = 'shops';
  static const _pullCursorKey = 'shop_pull_cursor';
  static const _syncLockKey = 'shop_sync_lock';

  final AppDatabase _database;
  final ShopUtcNow _utcNow;
  final ShopIdGenerator _idGenerator;

  Future<List<Shop>> getAll() async {
    try {
      final database = await _database.instance;
      final rows = await database.query(
        _table,
        where: 'is_deleted = 0',
        orderBy: 'name COLLATE NOCASE ASC',
      );
      return rows
          .map(ShopLocalRecord.fromMap)
          .map((record) => record.toShop())
          .toList(growable: false);
    } catch (error) {
      throw LocalStorageException(
        'Could not read shops from local storage.',
        cause: error,
      );
    }
  }

  Future<Shop> create(ShopDraft draft) async {
    final normalized = draft.normalized();
    final now = _utcNow().toUtc();
    final record = ShopLocalRecord(
      id: _idGenerator(),
      name: normalized.name,
      shopType: normalized.shopType,
      address: normalized.address,
      phoneNumber: normalized.phoneNumber,
      email: normalized.email,
      taxNumber: normalized.taxNumber,
      isActive: normalized.isActive,
      createdAt: now,
      updatedAt: now,
      lastModifiedUtc: now,
      isDeleted: false,
      pendingOperation: ShopPendingOperation.create,
      syncStatus: ShopSyncStatus.pendingCreate,
      retryCount: 0,
    );
    await saveRecord(record);
    return record.toShop();
  }

  Future<Shop> update(String id, ShopDraft draft) async {
    final existing = await getRecord(id);
    if (existing == null || existing.isDeleted) {
      throw const LocalStorageException('Shop was not found.');
    }
    final normalized = draft.normalized();
    final now = _monotonicNow(existing.lastModifiedUtc);
    final remainsCreate =
        existing.pendingOperation == ShopPendingOperation.create;
    final updated = existing.copyWith(
      name: normalized.name,
      shopType: normalized.shopType,
      address: normalized.address,
      clearAddress: normalized.address == null,
      phoneNumber: normalized.phoneNumber,
      clearPhoneNumber: normalized.phoneNumber == null,
      email: normalized.email,
      clearEmail: normalized.email == null,
      taxNumber: normalized.taxNumber,
      clearTaxNumber: normalized.taxNumber == null,
      isActive: normalized.isActive,
      updatedAt: now,
      lastModifiedUtc: now,
      pendingOperation: remainsCreate
          ? ShopPendingOperation.create
          : ShopPendingOperation.update,
      syncStatus: remainsCreate
          ? ShopSyncStatus.pendingCreate
          : ShopSyncStatus.pendingUpdate,
      retryCount: 0,
      clearNextRetryAt: true,
      clearLastSyncError: true,
    );
    await saveRecord(updated);
    return updated.toShop();
  }

  Future<void> delete(String id) async {
    final existing = await getRecord(id);
    if (existing == null) return;
    if (existing.pendingOperation == ShopPendingOperation.create) {
      await removeRecord(id);
      return;
    }
    final now = _monotonicNow(existing.lastModifiedUtc);
    await saveRecord(
      existing.copyWith(
        isDeleted: true,
        updatedAt: now,
        lastModifiedUtc: now,
        pendingOperation: ShopPendingOperation.delete,
        syncStatus: ShopSyncStatus.pendingDelete,
        retryCount: 0,
        clearNextRetryAt: true,
        clearLastSyncError: true,
      ),
    );
  }

  Future<ShopLocalRecord?> getRecord(String id) async {
    final database = await _database.instance;
    final rows = await database.query(
      _table,
      where: 'id = ?',
      whereArgs: [id],
      limit: 1,
    );
    return rows.isEmpty ? null : ShopLocalRecord.fromMap(rows.first);
  }

  Future<void> saveRecord(ShopLocalRecord record) async {
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

  Future<List<ShopLocalRecord>> getPendingRecords({
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
      where: "pending_operation != 'none'$retryFilter",
      whereArgs: force ? null : [now],
      orderBy: 'last_modified_utc ASC',
    );
    return rows.map(ShopLocalRecord.fromMap).toList(growable: false);
  }

  Future<int> getPendingCount() async {
    final database = await _database.instance;
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
    final database = await _database.instance;
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
    final database = await _database.instance;
    await database.delete(
      'sync_metadata',
      where: 'key = ? AND value LIKE ?',
      whereArgs: [_syncLockKey, '$owner|%'],
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
    final now = _utcNow().toUtc();
    return now.isAfter(previous)
        ? now
        : previous.add(const Duration(microseconds: 1));
  }
}
