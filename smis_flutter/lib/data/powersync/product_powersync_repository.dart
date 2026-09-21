import 'package:uuid/uuid.dart';

import '../../models/product.dart';
import '../data_exception.dart';
import 'powersync_repository_support.dart';

class ProductPowerSyncRepository extends PowerSyncRepositorySupport {
  ProductPowerSyncRepository(super.powerSync, {String Function()? idGenerator})
    : _idGenerator = idGenerator ?? const Uuid().v4;

  final String Function() _idGenerator;

  Future<Stream<void>> watchChanges(String shopId) async {
    final db = await database;
    return db
        .watch(
          'SELECT id, name, base_unit_id, sku, description, is_active, barcode, '
          'image_url, category_id, shop_id, reorder_point_base, '
          'reorder_quantity_base, last_modified_utc '
          'FROM product WHERE shop_id = ?',
          parameters: [shopId],
          throttle: const Duration(milliseconds: 250),
        )
        .map((_) {});
  }

  Future<List<Product>> getAll(
    String shopId, {
    String? searchQuery,
    int? limit,
    int? offset,
  }) async {
    final db = await database;
    final pending = await pendingOperations('product');
    final args = <Object?>[shopId];
    var where = 'shop_id = ?';
    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final q = '%${searchQuery.trim()}%';
      where +=
          ' AND (name LIKE ? OR sku LIKE ? OR barcode LIKE ? OR description LIKE ?)';
      args.addAll([q, q, q, q]);
    }
    var sql =
        'SELECT id, name, base_unit_id, sku, description, is_active, barcode, '
        'image_url, category_id, shop_id, reorder_point_base, '
        'reorder_quantity_base, last_modified_utc '
        'FROM product WHERE $where ORDER BY name COLLATE NOCASE ASC';
    if (limit != null) {
      sql += ' LIMIT ?';
      args.add(limit);
      if (offset != null) {
        sql += ' OFFSET ?';
        args.add(offset);
      }
    }
    final rows = await db.getAll(sql, args);
    return rows.map((row) => _toProduct(row, pending[row['id']])).toList();
  }

  Future<int> getTotalCount(String shopId, {String? searchQuery}) async {
    final db = await database;
    final args = <Object?>[shopId];
    var where = 'shop_id = ?';
    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final q = '%${searchQuery.trim()}%';
      where +=
          ' AND (name LIKE ? OR sku LIKE ? OR barcode LIKE ? OR description LIKE ?)';
      args.addAll([q, q, q, q]);
    }
    final row = await db.get(
      'SELECT COUNT(*) AS count FROM product WHERE $where',
      args,
    );
    return row['count'] as int;
  }

  Future<Product> create(ProductDraft draft, String shopId) async {
    final normalized = draft.normalized();
    await _ensureReferences(
      shopId,
      normalized.baseUnitId,
      normalized.categoryId,
    );
    final db = await database;
    final id = _idGenerator();
    await db.execute(
      'INSERT INTO product(id, name, base_unit_id, sku, description, is_active, '
      'barcode, image_url, category_id, shop_id, reorder_point_base, '
      'reorder_quantity_base, last_modified_utc) '
      'VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)',
      [
        id,
        normalized.name,
        normalized.baseUnitId,
        normalized.sku,
        normalized.description,
        normalized.isActive ? 1 : 0,
        normalized.barcode,
        normalized.imageUrl,
        normalized.categoryId,
        shopId,
        0,
        0,
        nowIso(),
      ],
    );
    return _byId(id);
  }

  Future<Product> update(String id, ProductDraft draft) async {
    final normalized = draft.normalized();
    final db = await database;
    final current = await db.getOptional(
      'SELECT base_unit_id, shop_id FROM product WHERE id = ?',
      [id],
    );
    if (current == null) {
      throw const LocalStorageException('Product was not found.');
    }
    final shopId = current['shop_id'] as String;
    if (current['base_unit_id'] != normalized.baseUnitId &&
        await _hasConversions(id)) {
      throw const LocalStorageException(
        'Base unit cannot be changed after product-unit conversions exist.',
      );
    }
    await _ensureReferences(
      shopId,
      normalized.baseUnitId,
      normalized.categoryId,
    );
    await db.execute(
      'UPDATE product SET name = ?, base_unit_id = ?, sku = ?, description = ?, '
      'is_active = ?, barcode = ?, image_url = ?, category_id = ?, '
      'last_modified_utc = ? WHERE id = ?',
      [
        normalized.name,
        normalized.baseUnitId,
        normalized.sku,
        normalized.description,
        normalized.isActive ? 1 : 0,
        normalized.barcode,
        normalized.imageUrl,
        normalized.categoryId,
        nowIso(),
        id,
      ],
    );
    return _byId(id);
  }

  Future<void> delete(String id) async {
    final db = await database;
    if (await db.getOptional('SELECT id FROM product WHERE id = ?', [id]) ==
        null) {
      return;
    }
    await db.execute('UPDATE product SET last_modified_utc = ? WHERE id = ?', [
      nowIso(),
      id,
    ]);
    await db.execute('DELETE FROM product WHERE id = ?', [id]);
  }

  Future<int> getPendingCount(String shopId) => pendingCount('product');

  Future<void> _ensureReferences(
    String shopId,
    String baseUnitId,
    String? categoryId,
  ) async {
    final db = await database;
    if (await db.getOptional('SELECT id FROM unit_of_measure WHERE id = ?', [
          baseUnitId,
        ]) ==
        null) {
      throw const LocalStorageException(
        'The selected base unit does not exist in local storage.',
      );
    }
    if (categoryId != null && categoryId.trim().isNotEmpty) {
      if (await db.getOptional(
            'SELECT id FROM category WHERE id = ? AND shop_id = ?',
            [categoryId, shopId],
          ) ==
          null) {
        throw const LocalStorageException(
          'The selected category does not exist in local storage.',
        );
      }
    }
  }

  Future<bool> _hasConversions(String productId) async {
    final db = await database;
    return await db.getOptional(
          'SELECT id FROM product_unit WHERE product_id = ? LIMIT 1',
          [productId],
        ) !=
        null;
  }

  Future<Product> _byId(String id) async {
    final db = await database;
    final row = await db.getOptional(
      'SELECT id, name, base_unit_id, sku, description, is_active, barcode, '
      'image_url, category_id, shop_id, reorder_point_base, '
      'reorder_quantity_base, last_modified_utc '
      'FROM product WHERE id = ?',
      [id],
    );
    if (row == null) {
      throw const LocalStorageException('Product was not found.');
    }
    final pending = await pendingOperations('product');
    return _toProduct(row, pending[id]);
  }

  Product _toProduct(Map<String, Object?> row, String? operation) {
    final changedAt = timestamp(row['last_modified_utc']);
    return Product(
      id: row['id']! as String,
      name: row['name']! as String,
      baseUnitId: row['base_unit_id']! as String,
      sku: row['sku'] as String?,
      description: row['description'] as String?,
      isActive: row['is_active'] == 1,
      barcode: row['barcode'] as String?,
      imageUrl: row['image_url'] as String?,
      categoryId: row['category_id'] as String?,
      shopId: row['shop_id'] as String?,
      createdAt: changedAt,
      updatedAt: changedAt,
      lastModifiedUtc: changedAt,
      syncStatus: operation == null
          ? ProductSyncStatus.synced
          : operation == 'PUT'
          ? ProductSyncStatus.pendingCreate
          : ProductSyncStatus.pendingUpdate,
    );
  }
}
