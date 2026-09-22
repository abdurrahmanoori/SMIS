import 'package:uuid/uuid.dart';

import '../../models/product_price.dart';
import '../data_exception.dart';
import 'powersync_repository_support.dart';

class ProductPricePowerSyncRepository extends PowerSyncRepositorySupport {
  ProductPricePowerSyncRepository(
    super.powerSync, {
    String Function()? idGenerator,
  }) : _idGenerator = idGenerator ?? const Uuid().v4;

  final String Function() _idGenerator;

  Future<Stream<void>> watchChanges(String shopId) async {
    final db = await database;
    return db
        .watch(
          'SELECT pp.id, pp.product_unit_id, pp.sell_price, pp.effective_date, '
          'pp.end_date, pp.last_modified_utc '
          'FROM product_price pp '
          'INNER JOIN product_unit pu ON pu.id = pp.product_unit_id '
          'INNER JOIN product p ON p.id = pu.product_id '
          'WHERE p.shop_id = ?',
          parameters: [shopId],
          throttle: const Duration(milliseconds: 250),
        )
        .map((_) {});
  }

  Future<List<ProductPrice>> getAll(
    String shopId, {
    String? searchQuery,
    int? limit,
    int? offset,
  }) async {
    final db = await database;
    final pending = await pendingOperations('product_price');
    final args = <Object?>[shopId];
    var where = 'p.shop_id = ?';

    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final q = '%${searchQuery.trim()}%';
      where += ' AND (p.name LIKE ? OR u.name LIKE ?)';
      args.addAll([q, q]);
    }

    var sql =
        'SELECT pp.id, pp.product_unit_id, pp.sell_price, pp.effective_date, '
        'pp.end_date, pp.last_modified_utc '
        'FROM product_price pp '
        'INNER JOIN product_unit pu ON pu.id = pp.product_unit_id '
        'INNER JOIN product p ON p.id = pu.product_id '
        'INNER JOIN unit_of_measure u ON u.id = pu.unit_of_measure_id '
        'WHERE $where '
        'ORDER BY pp.effective_date DESC, p.name COLLATE NOCASE, u.name COLLATE NOCASE';

    if (limit != null) {
      sql += ' LIMIT ?';
      args.add(limit);
      if (offset != null) {
        sql += ' OFFSET ?';
        args.add(offset);
      }
    }

    final rows = await db.getAll(sql, args);
    return rows.map((row) => _toProductPrice(row, pending[row['id']])).toList();
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
      'SELECT COUNT(*) AS count '
      'FROM product_price pp '
      'INNER JOIN product_unit pu ON pu.id = pp.product_unit_id '
      'INNER JOIN product p ON p.id = pu.product_id '
      'INNER JOIN unit_of_measure u ON u.id = pu.unit_of_measure_id '
      'WHERE $where',
      args,
    );
    return row['count'] as int;
  }

  Future<ProductPrice> create(ProductPriceDraft draft, String shopId) async {
    final normalized = draft.normalized();
    await _ensureProductUnit(shopId, normalized.productUnitId);
    await _ensureChronological(
      normalized.productUnitId,
      normalized.effectiveDate,
    );

    final db = await database;
    final id = _idGenerator();
    await db.execute(
      'INSERT INTO product_price('
      'id, product_unit_id, sell_price, effective_date, end_date, last_modified_utc'
      ') VALUES (?, ?, ?, ?, ?, ?)',
      [
        id,
        normalized.productUnitId,
        normalized.sellPrice,
        normalized.effectiveDate.toIso8601String(),
        normalized.endDate?.toIso8601String(),
        nowIso(),
      ],
    );
    return _byId(id);
  }

  Future<ProductPrice> createSuccessor(
    String currentId,
    ProductPriceDraft draft,
    String shopId,
  ) async {
    final normalized = draft.normalized();
    final db = await database;
    final current = await db.getOptional(
      'SELECT id, product_unit_id, effective_date '
      'FROM product_price WHERE id = ?',
      [currentId],
    );
    if (current == null) {
      throw const LocalStorageException('Product price was not found.');
    }

    final productUnitId = current['product_unit_id']! as String;
    if (productUnitId != normalized.productUnitId) {
      throw const LocalStorageException(
        'A historical price cannot be moved to another product unit.',
      );
    }

    await _ensureProductUnit(shopId, productUnitId);

    final latest = await db.getOptional(
      'SELECT id FROM product_price '
      'WHERE product_unit_id = ? '
      'ORDER BY effective_date DESC LIMIT 1',
      [productUnitId],
    );
    if (latest == null || latest['id'] != currentId) {
      throw const LocalStorageException(
        'Historical prices cannot be rewritten. Add a new effective price instead.',
      );
    }

    final currentEffectiveDate = DateTime.parse(
      current['effective_date']! as String,
    ).toUtc();
    if (!normalized.effectiveDate.isAfter(currentEffectiveDate)) {
      throw const LocalStorageException(
        'A new price must become effective after the latest price for this product unit.',
      );
    }

    return create(normalized, shopId);
  }

  Future<void> delete(String id) async {
    final db = await database;
    if (await db.getOptional('SELECT id FROM product_price WHERE id = ?', [
          id,
        ]) ==
        null) {
      return;
    }
    await db.execute(
      'UPDATE product_price SET last_modified_utc = ? WHERE id = ?',
      [nowIso(), id],
    );
    await db.execute('DELETE FROM product_price WHERE id = ?', [id]);
  }

  Future<int> getPendingCount(String shopId) => pendingCount('product_price');

  Future<void> _ensureProductUnit(String shopId, String productUnitId) async {
    final db = await database;
    if (await db.getOptional(
          'SELECT pu.id FROM product_unit pu '
          'INNER JOIN product p ON p.id = pu.product_id '
          'WHERE pu.id = ? AND p.shop_id = ?',
          [productUnitId, shopId],
        ) ==
        null) {
      throw const LocalStorageException(
        'The selected product unit is not available locally.',
      );
    }
  }

  Future<void> _ensureChronological(
    String productUnitId,
    DateTime effectiveDate,
  ) async {
    final db = await database;
    final latest = await db.getOptional(
      'SELECT effective_date FROM product_price '
      'WHERE product_unit_id = ? '
      'ORDER BY effective_date DESC LIMIT 1',
      [productUnitId],
    );
    if (latest == null) return;

    final latestEffectiveDate = DateTime.parse(
      latest['effective_date']! as String,
    ).toUtc();
    if (!effectiveDate.isAfter(latestEffectiveDate)) {
      throw const LocalStorageException(
        'A new price must become effective after the latest price for this product unit.',
      );
    }
  }

  Future<ProductPrice> _byId(String id) async {
    final db = await database;
    final row = await db.getOptional(
      'SELECT id, product_unit_id, sell_price, effective_date, end_date, '
      'last_modified_utc FROM product_price WHERE id = ?',
      [id],
    );
    if (row == null) {
      throw const LocalStorageException('Product price was not found.');
    }
    final pending = await pendingOperations('product_price');
    return _toProductPrice(row, pending[id]);
  }

  ProductPrice _toProductPrice(Map<String, Object?> row, String? operation) {
    return ProductPrice(
      id: row['id']! as String,
      productUnitId: row['product_unit_id']! as String,
      sellPrice: (row['sell_price'] as num).toInt(),
      effectiveDate: DateTime.parse(row['effective_date']! as String).toUtc(),
      endDate: _optionalDate(row['end_date']),
      lastModifiedUtc: timestamp(row['last_modified_utc']),
      syncStatus: operation == null
          ? ProductPriceSyncStatus.synced
          : operation == 'PUT'
          ? ProductPriceSyncStatus.pendingCreate
          : ProductPriceSyncStatus.pendingUpdate,
    );
  }

  DateTime? _optionalDate(Object? value) =>
      value == null ? null : DateTime.parse(value as String).toUtc();
}
