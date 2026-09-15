import 'package:sqflite/sqflite.dart';
import 'package:uuid/uuid.dart';

import '../models/product_unit.dart';
import '../models/product_unit_local_record.dart';
import 'data_exception.dart';
import 'database.dart';

class ProductUnitRepository {
  ProductUnitRepository(this._database, {DateTime Function()? utcNow})
    : _utcNow = utcNow ?? (() => DateTime.now().toUtc());

  static const _table = 'product_units';
  static const _pullCursorKey = 'product_unit_pull_cursor';
  static const _syncLockKey = 'product_unit_sync_lock';

  final AppDatabase _database;
  final DateTime Function() _utcNow;

  Future<List<ProductUnit>> getAll(
    String shopId, {
    String? searchQuery,
    int? limit,
    int? offset,
  }) async {
    final database = await _database.instance;
    final query = searchQuery?.trim();
    final filters = <String>[
      'pu.is_deleted = 0',
      'p.is_deleted = 0',
      'u.is_deleted = 0',
      'p.shop_id = ?',
    ];
    final arguments = <Object?>[shopId];
    if (query != null && query.isNotEmpty) {
      filters.add('(p.name LIKE ? OR u.name LIKE ?)');
      arguments.addAll(['%$query%', '%$query%']);
    }
    final rows = await database.rawQuery(
      '''
      SELECT pu.*
      FROM $_table pu
      INNER JOIN products p ON p.id = pu.product_id
      INNER JOIN unit_of_measures u ON u.id = pu.unit_of_measure_id
      WHERE ${filters.join(' AND ')}
      ORDER BY p.name COLLATE NOCASE, u.name COLLATE NOCASE
      ${limit == null ? '' : 'LIMIT ?'}
      ${offset == null ? '' : 'OFFSET ?'}
    ''',
      [...arguments, if (limit != null) limit, if (offset != null) offset],
    );
    return rows
        .map(ProductUnitLocalRecord.fromMap)
        .map((record) => record.toProductUnit())
        .toList(growable: false);
  }

  Future<int> getTotalCount(String shopId, {String? searchQuery}) async {
    final database = await _database.instance;
    final query = searchQuery?.trim();
    final filters = <String>[
      'pu.is_deleted = 0',
      'p.is_deleted = 0',
      'u.is_deleted = 0',
      'p.shop_id = ?',
    ];
    final arguments = <Object?>[shopId];
    if (query != null && query.isNotEmpty) {
      filters.add('(p.name LIKE ? OR u.name LIKE ?)');
      arguments.addAll(['%$query%', '%$query%']);
    }
    final rows = await database.rawQuery('''
      SELECT COUNT(*) AS count
      FROM $_table pu
      INNER JOIN products p ON p.id = pu.product_id
      INNER JOIN unit_of_measures u ON u.id = pu.unit_of_measure_id
      WHERE ${filters.join(' AND ')}
    ''', arguments);
    return Sqflite.firstIntValue(rows) ?? 0;
  }

  Future<ProductUnit> create(ProductUnitDraft draft, String shopId) async {
    final normalized = draft.normalized();
    await _ensureReferences(shopId, normalized);
    final now = _utcNow();
    final record = ProductUnitLocalRecord(
      id: const Uuid().v4(),
      productId: normalized.productId,
      unitOfMeasureId: normalized.unitOfMeasureId,
      baseUnitQuantity: normalized.baseUnitQuantity,
      createdAt: now,
      updatedAt: now,
      lastModifiedUtc: now,
      isDeleted: false,
      pendingOperation: ProductUnitPendingOperation.create,
      syncStatus: ProductUnitSyncStatus.pendingCreate,
      retryCount: 0,
    );
    await saveRecord(record);
    return record.toProductUnit();
  }

  Future<ProductUnit> update(
    String id,
    ProductUnitDraft draft,
    String shopId,
  ) async {
    final existing = await getRecord(id);
    if (existing == null || existing.isDeleted) {
      throw const LocalStorageException('Product unit was not found.');
    }
    final normalized = draft.normalized();
    await _ensureReferences(shopId, normalized);
    final timestamp = _monotonicNow(existing.lastModifiedUtc);
    final remainsCreate =
        existing.pendingOperation == ProductUnitPendingOperation.create;
    final record = existing.copyWith(
      productId: normalized.productId,
      unitOfMeasureId: normalized.unitOfMeasureId,
      baseUnitQuantity: normalized.baseUnitQuantity,
      updatedAt: timestamp,
      lastModifiedUtc: timestamp,
      pendingOperation: remainsCreate
          ? ProductUnitPendingOperation.create
          : ProductUnitPendingOperation.update,
      syncStatus: remainsCreate
          ? ProductUnitSyncStatus.pendingCreate
          : ProductUnitSyncStatus.pendingUpdate,
      retryCount: 0,
      clearNextRetryAt: true,
      clearLastSyncError: true,
    );
    await saveRecord(record);
    return record.toProductUnit();
  }

  Future<void> delete(String id) async {
    final existing = await getRecord(id);
    if (existing == null) return;
    if (existing.pendingOperation == ProductUnitPendingOperation.create) {
      await removeRecord(id);
      return;
    }
    final timestamp = _monotonicNow(existing.lastModifiedUtc);
    await saveRecord(
      existing.copyWith(
        isDeleted: true,
        updatedAt: timestamp,
        lastModifiedUtc: timestamp,
        pendingOperation: ProductUnitPendingOperation.delete,
        syncStatus: ProductUnitSyncStatus.pendingDelete,
        retryCount: 0,
        clearNextRetryAt: true,
        clearLastSyncError: true,
      ),
    );
  }

  Future<ProductUnitLocalRecord?> getRecord(String id) async {
    final database = await _database.instance;
    final rows = await database.query(_table, where: 'id = ?', whereArgs: [id]);
    return rows.isEmpty ? null : ProductUnitLocalRecord.fromMap(rows.first);
  }

  Future<void> saveRecord(ProductUnitLocalRecord record) async {
    final database = await _database.instance;
    final duplicates = await database.query(
      _table,
      columns: ['id'],
      where: 'product_id = ? AND unit_of_measure_id = ? AND id != ?',
      whereArgs: [record.productId, record.unitOfMeasureId, record.id],
      limit: 1,
    );
    if (duplicates.isNotEmpty) {
      throw const LocalStorageException(
        'This unit is already configured for the selected product.',
      );
    }
    try {
      final changed = await database.update(
        _table,
        record.toMap(),
        where: 'id = ?',
        whereArgs: [record.id],
      );
      if (changed == 0) await database.insert(_table, record.toMap());
    } on DatabaseException catch (error) {
      if (error.toString().contains('UNIQUE constraint failed')) {
        throw const LocalStorageException(
          'This unit is already configured for the selected product.',
        );
      }
      rethrow;
    }
  }

  Future<void> removeRecord(String id) async {
    final database = await _database.instance;
    await database.delete(_table, where: 'id = ?', whereArgs: [id]);
  }

  Future<List<ProductUnitLocalRecord>> getPendingRecords({
    required String shopId,
    required bool force,
  }) async {
    final database = await _database.instance;
    final retryFilter = force
        ? ''
        : " AND pu.retry_count < 5 AND (pu.next_retry_at IS NULL OR pu.next_retry_at <= ?)";
    final rows = await database.rawQuery(
      '''
      SELECT pu.* FROM $_table pu
      INNER JOIN products p ON p.id = pu.product_id
      WHERE pu.pending_operation != 'none' AND p.shop_id = ?$retryFilter
      ORDER BY pu.last_modified_utc ASC
    ''',
      [shopId, if (!force) DateTime.now().toUtc().toIso8601String()],
    );
    return rows.map(ProductUnitLocalRecord.fromMap).toList(growable: false);
  }

  Future<int> getPendingCount(String shopId) async {
    final database = await _database.instance;
    final rows = await database.rawQuery(
      '''
      SELECT COUNT(*) AS count FROM $_table pu
      INNER JOIN products p ON p.id = pu.product_id
      WHERE pu.pending_operation != 'none' AND p.shop_id = ?
    ''',
      [shopId],
    );
    return Sqflite.firstIntValue(rows) ?? 0;
  }

  Future<DateTime> getPullCursor(String shopId) async {
    final value = await _getMetadata('${_pullCursorKey}_$shopId');
    return value == null
        ? DateTime.fromMillisecondsSinceEpoch(0, isUtc: true)
        : DateTime.parse(value).toUtc();
  }

  Future<void> setPullCursor(String shopId, DateTime value) => _setMetadata(
    '${_pullCursorKey}_$shopId',
    value.toUtc().toIso8601String(),
  );

  Future<bool> tryAcquireSyncLock(String owner, String shopId) async {
    final database = await _database.instance;
    return database.transaction((transaction) async {
      final key = '${_syncLockKey}_$shopId';
      final rows = await transaction.query(
        'sync_metadata',
        where: 'key = ?',
        whereArgs: [key],
        limit: 1,
      );
      final lockedAt = rows.isEmpty
          ? null
          : DateTime.tryParse(
              (rows.first['value']! as String).split('|').last,
            )?.toUtc();
      if (lockedAt != null &&
          DateTime.now().toUtc().difference(lockedAt) <
              const Duration(minutes: 10)) {
        return false;
      }
      await transaction.insert('sync_metadata', {
        'key': key,
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

  Future<void> _ensureReferences(String shopId, ProductUnitDraft draft) async {
    final database = await _database.instance;
    final products = await database.query(
      'products',
      columns: ['id'],
      where: 'id = ? AND shop_id = ? AND is_deleted = 0',
      whereArgs: [draft.productId, shopId],
      limit: 1,
    );
    if (products.isEmpty) {
      throw const LocalStorageException(
        'The selected product is not available locally. Sync products first.',
      );
    }
    final units = await database.query(
      'unit_of_measures',
      columns: ['id'],
      where: 'id = ? AND is_deleted = 0',
      whereArgs: [draft.unitOfMeasureId],
      limit: 1,
    );
    if (units.isEmpty) {
      throw const LocalStorageException(
        'The selected unit is not available locally. Sync units first.',
      );
    }
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
