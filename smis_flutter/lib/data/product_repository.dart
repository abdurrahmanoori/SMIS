import 'package:sqflite/sqflite.dart';
import 'package:uuid/uuid.dart';

import '../models/product.dart';
import '../models/product_local_record.dart';
import 'data_exception.dart';
import 'database.dart';

typedef ProductUtcNow = DateTime Function();
typedef ProductIdGenerator = String Function();

class ProductRepository {
  ProductRepository(this._database, {ProductUtcNow? utcNow, ProductIdGenerator? idGenerator})
    : _utcNow = utcNow ?? (() => DateTime.now().toUtc()),
      _idGenerator = idGenerator ?? const Uuid().v4;

  static const _table = 'products';
  static const _pullCursorKey = 'product_pull_cursor';
  static const _syncLockKey = 'product_sync_lock';
  final AppDatabase _database;
  final ProductUtcNow _utcNow;
  final ProductIdGenerator _idGenerator;

  Future<List<Product>> getAll(String shopId) async {
    try {
      final database = await _database.instance;
      final rows = await database.query(
        _table,
        where: 'is_deleted = 0 AND shop_id = ?',
        whereArgs: [shopId],
        orderBy: 'name COLLATE NOCASE ASC',
      );
      return rows.map(ProductLocalRecord.fromMap).map((record) => record.toProduct()).toList(growable: false);
    } catch (error) {
      throw LocalStorageException('Could not read products from local storage.', cause: error);
    }
  }

  Future<Product> create(ProductDraft draft, String shopId) async {
    final normalized = draft.normalized();
    final now = _utcNow();
    final record = ProductLocalRecord(
      id: _idGenerator(),
      name: normalized.name,
      baseUnitId: normalized.baseUnitId,
      sku: normalized.sku,
      description: normalized.description,
      isActive: normalized.isActive,
      barcode: normalized.barcode,
      imageUrl: normalized.imageUrl,
      categoryId: normalized.categoryId,
      shopId: shopId,
      createdAt: now,
      updatedAt: now,
      lastModifiedUtc: now,
      isDeleted: false,
      pendingOperation: ProductPendingOperation.create,
      syncStatus: ProductSyncStatus.pendingCreate,
      retryCount: 0,
    );
    await saveRecord(record);
    return record.toProduct();
  }

  Future<Product> update(String id, ProductDraft draft) async {
    final existing = await getRecord(id);
    if (existing == null || existing.isDeleted) {
      throw const LocalStorageException('Product was not found.');
    }
    final normalized = draft.normalized();
    final timestamp = _monotonicNow(existing.lastModifiedUtc);
    final remainsCreate = existing.pendingOperation == ProductPendingOperation.create;
    final record = existing.copyWith(
      name: normalized.name,
      baseUnitId: normalized.baseUnitId,
      sku: normalized.sku,
      clearSku: normalized.sku == null,
      description: normalized.description,
      clearDescription: normalized.description == null,
      isActive: normalized.isActive,
      barcode: normalized.barcode,
      clearBarcode: normalized.barcode == null,
      imageUrl: normalized.imageUrl,
      clearImageUrl: normalized.imageUrl == null,
      categoryId: normalized.categoryId,
      clearCategoryId: normalized.categoryId == null,
      updatedAt: timestamp,
      lastModifiedUtc: timestamp,
      pendingOperation: remainsCreate ? ProductPendingOperation.create : ProductPendingOperation.update,
      syncStatus: remainsCreate ? ProductSyncStatus.pendingCreate : ProductSyncStatus.pendingUpdate,
      retryCount: 0,
      clearNextRetryAt: true,
      clearLastSyncError: true,
    );
    await saveRecord(record);
    return record.toProduct();
  }

  Future<void> delete(String id) async {
    final existing = await getRecord(id);
    if (existing == null) return;
    if (existing.pendingOperation == ProductPendingOperation.create) {
      await removeRecord(id);
      return;
    }
    final timestamp = _monotonicNow(existing.lastModifiedUtc);
    await saveRecord(existing.copyWith(
      isDeleted: true,
      updatedAt: timestamp,
      lastModifiedUtc: timestamp,
      pendingOperation: ProductPendingOperation.delete,
      syncStatus: ProductSyncStatus.pendingDelete,
      retryCount: 0,
      clearNextRetryAt: true,
      clearLastSyncError: true,
    ));
  }

  Future<ProductLocalRecord?> getRecord(String id) async {
    final database = await _database.instance;
    final rows = await database.query(_table, where: 'id = ?', whereArgs: [id], limit: 1);
    return rows.isEmpty ? null : ProductLocalRecord.fromMap(rows.first);
  }

  Future<void> saveRecord(ProductLocalRecord record) async {
    final database = await _database.instance;
    await database.insert(_table, record.toMap(), conflictAlgorithm: ConflictAlgorithm.replace);
  }

  Future<void> removeRecord(String id) async {
    final database = await _database.instance;
    await database.delete(_table, where: 'id = ?', whereArgs: [id]);
  }

  Future<List<ProductLocalRecord>> getPendingRecords({required String shopId, required bool force}) async {
    final database = await _database.instance;
    final now = DateTime.now().toUtc().toIso8601String();
    final retryFilter = force ? '' : ' AND retry_count < 5 AND (next_retry_at IS NULL OR next_retry_at <= ?)';
    final rows = await database.query(
      _table,
      where: "pending_operation != 'none' AND shop_id = ?$retryFilter",
      whereArgs: force ? [shopId] : [shopId, now],
      orderBy: 'last_modified_utc ASC',
    );
    return rows.map(ProductLocalRecord.fromMap).toList(growable: false);
  }

  Future<int> getPendingCount(String shopId) async {
    final database = await _database.instance;
    final rows = await database.rawQuery(
        "SELECT COUNT(*) AS count FROM $_table WHERE pending_operation != 'none' AND shop_id = ?",
        [shopId],
    );
    return Sqflite.firstIntValue(rows) ?? 0;
  }

  Future<DateTime> getPullCursor(String shopId) async {
    final value = await _getMetadata('${_pullCursorKey}_$shopId');
    return value == null ? DateTime.fromMillisecondsSinceEpoch(0, isUtc: true) : DateTime.parse(value).toUtc();
  }
  Future<void> setPullCursor(String shopId, DateTime value) => _setMetadata('${_pullCursorKey}_$shopId', value.toUtc().toIso8601String());

  Future<bool> tryAcquireSyncLock(String owner, String shopId) async {
    final database = await _database.instance;
    return database.transaction((transaction) async {
      final rows = await transaction.query('sync_metadata', where: 'key = ?', whereArgs: ['${_syncLockKey}_$shopId'], limit: 1);
      if (rows.isNotEmpty) {
        final lockedAt = DateTime.tryParse((rows.first['value']! as String).split('|').last)?.toUtc();
        if (lockedAt != null && DateTime.now().toUtc().difference(lockedAt) < const Duration(minutes: 10)) return false;
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
    await database.delete('sync_metadata', where: 'key = ? AND value LIKE ?', whereArgs: ['${_syncLockKey}_$shopId', '$owner|%']);
  }

  Future<String?> _getMetadata(String key) async {
    final database = await _database.instance;
    final rows = await database.query('sync_metadata', columns: ['value'], where: 'key = ?', whereArgs: [key], limit: 1);
    return rows.isEmpty ? null : rows.first['value']! as String;
  }
  Future<void> _setMetadata(String key, String value) async {
    final database = await _database.instance;
    await database.insert('sync_metadata', {'key': key, 'value': value}, conflictAlgorithm: ConflictAlgorithm.replace);
  }
  DateTime _monotonicNow(DateTime previous) {
    final now = _utcNow();
    return now.isAfter(previous) ? now : previous.add(const Duration(microseconds: 1));
  }
}
