import 'package:uuid/uuid.dart';

import '../../models/product_unit.dart';
import '../data_exception.dart';
import 'powersync_repository_support.dart';

class ProductUnitPowerSyncRepository extends PowerSyncRepositorySupport {
  ProductUnitPowerSyncRepository(
    super.powerSync, {
    String Function()? idGenerator,
  }) : _idGenerator = idGenerator ?? const Uuid().v4;

  final String Function() _idGenerator;

  Future<Stream<void>> watchChanges(String shopId) async {
    final db = await database;
    return db
        .watch(
          'SELECT pu.id, pu.product_id, pu.unit_of_measure_id, '
          'pu.base_unit_quantity, pu.last_modified_utc '
          'FROM product_unit pu INNER JOIN product p ON p.id = pu.product_id '
          'WHERE p.shop_id = ?',
          parameters: [shopId],
          throttle: const Duration(milliseconds: 250),
        )
        .map((_) {});
  }

  Future<List<ProductUnit>> getAll(
    String shopId, {
    String? searchQuery,
    int? limit,
    int? offset,
  }) async {
    final db = await database;
    final pending = await pendingOperations('product_unit');
    final args = <Object?>[shopId];
    var where = 'p.shop_id = ?';
    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final q = '%${searchQuery.trim()}%';
      where += ' AND (p.name LIKE ? OR u.name LIKE ?)';
      args.addAll([q, q]);
    }
    var sql =
        'SELECT pu.id, pu.product_id, pu.unit_of_measure_id, '
        'pu.base_unit_quantity, pu.last_modified_utc '
        'FROM product_unit pu '
        'INNER JOIN product p ON p.id = pu.product_id '
        'INNER JOIN unit_of_measure u ON u.id = pu.unit_of_measure_id '
        'WHERE $where ORDER BY p.name COLLATE NOCASE, u.name COLLATE NOCASE';
    if (limit != null) {
      sql += ' LIMIT ?';
      args.add(limit);
      if (offset != null) {
        sql += ' OFFSET ?';
        args.add(offset);
      }
    }
    final rows = await db.getAll(sql, args);
    return rows.map((row) => _toProductUnit(row, pending[row['id']])).toList();
  }

  Future<int> getTotalCount(String shopId, {String? searchQuery}) async {
    final db = await database;
    final args = <Object?>[shopId];
    var where = 'p.shop_id = ?';
    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final q = '%${searchQuery.trim()}%';
      where += ' AND (p.name LIKE ? OR u.name LIKE ?)';
      args.addAll([q, q]);
    }
    final row = await db.get(
      'SELECT COUNT(*) AS count FROM product_unit pu '
      'INNER JOIN product p ON p.id = pu.product_id '
      'INNER JOIN unit_of_measure u ON u.id = pu.unit_of_measure_id '
      'WHERE $where',
      args,
    );
    return row['count'] as int;
  }

  Future<ProductUnit> create(ProductUnitDraft draft, String shopId) async {
    final normalized = draft.normalized();
    await _ensureReferences(shopId, normalized);
    await _ensureUniquePair(normalized, excludeId: null);
    final db = await database;
    final id = _idGenerator();
    await db.execute(
      'INSERT INTO product_unit(id, product_id, unit_of_measure_id, '
      'base_unit_quantity, last_modified_utc) VALUES (?, ?, ?, ?, ?)',
      [
        id,
        normalized.productId,
        normalized.unitOfMeasureId,
        normalized.baseUnitQuantity,
        nowIso(),
      ],
    );
    return _byId(id);
  }

  Future<ProductUnit> update(
    String id,
    ProductUnitDraft draft,
    String shopId,
  ) async {
    final normalized = draft.normalized();
    final db = await database;
    if (await db.getOptional('SELECT id FROM product_unit WHERE id = ?', [
          id,
        ]) ==
        null) {
      throw const LocalStorageException('Product unit was not found.');
    }
    await _ensureReferences(shopId, normalized);
    await _ensureUniquePair(normalized, excludeId: id);
    await db.execute(
      'UPDATE product_unit SET product_id = ?, unit_of_measure_id = ?, '
      'base_unit_quantity = ?, last_modified_utc = ? WHERE id = ?',
      [
        normalized.productId,
        normalized.unitOfMeasureId,
        normalized.baseUnitQuantity,
        nowIso(),
        id,
      ],
    );
    return _byId(id);
  }

  Future<void> delete(String id) async {
    final db = await database;
    if (await db.getOptional('SELECT id FROM product_unit WHERE id = ?', [
          id,
        ]) ==
        null) {
      return;
    }
    await db.execute(
      'UPDATE product_unit SET last_modified_utc = ? WHERE id = ?',
      [nowIso(), id],
    );
    await db.execute('DELETE FROM product_unit WHERE id = ?', [id]);
  }

  Future<int> getPendingCount(String shopId) => pendingCount('product_unit');

  Future<void> _ensureReferences(String shopId, ProductUnitDraft draft) async {
    final db = await database;
    if (await db.getOptional(
          'SELECT id FROM product WHERE id = ? AND shop_id = ?',
          [draft.productId, shopId],
        ) ==
        null) {
      throw const LocalStorageException(
        'The selected product is not available locally yet.',
      );
    }
    if (await db.getOptional('SELECT id FROM unit_of_measure WHERE id = ?', [
          draft.unitOfMeasureId,
        ]) ==
        null) {
      throw const LocalStorageException(
        'The selected unit is not available locally yet.',
      );
    }
  }

  Future<void> _ensureUniquePair(
    ProductUnitDraft draft, {
    required String? excludeId,
  }) async {
    final db = await database;
    final args = <Object?>[draft.productId, draft.unitOfMeasureId];
    var sql =
        'SELECT id FROM product_unit WHERE product_id = ? AND unit_of_measure_id = ?';
    if (excludeId != null) {
      sql += ' AND id != ?';
      args.add(excludeId);
    }
    sql += ' LIMIT 1';
    if (await db.getOptional(sql, args) != null) {
      throw const LocalStorageException(
        'This unit is already configured for the selected product.',
      );
    }
  }

  Future<ProductUnit> _byId(String id) async {
    final db = await database;
    final row = await db.getOptional(
      'SELECT id, product_id, unit_of_measure_id, base_unit_quantity, '
      'last_modified_utc FROM product_unit WHERE id = ?',
      [id],
    );
    if (row == null) {
      throw const LocalStorageException('Product unit was not found.');
    }
    final pending = await pendingOperations('product_unit');
    return _toProductUnit(row, pending[id]);
  }

  ProductUnit _toProductUnit(Map<String, Object?> row, String? operation) {
    final changedAt = timestamp(row['last_modified_utc']);
    return ProductUnit(
      id: row['id']! as String,
      productId: row['product_id']! as String,
      unitOfMeasureId: row['unit_of_measure_id']! as String,
      baseUnitQuantity: (row['base_unit_quantity'] as num).toDouble(),
      createdAt: changedAt,
      updatedAt: changedAt,
      lastModifiedUtc: changedAt,
      syncStatus: operation == null
          ? ProductUnitSyncStatus.synced
          : operation == 'PUT'
          ? ProductUnitSyncStatus.pendingCreate
          : ProductUnitSyncStatus.pendingUpdate,
    );
  }
}
