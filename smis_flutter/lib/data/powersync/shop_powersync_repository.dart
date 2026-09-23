import 'package:uuid/uuid.dart';

import '../../models/shop.dart';
import '../data_exception.dart';
import 'powersync_repository_support.dart';

class ShopPowerSyncRepository extends PowerSyncRepositorySupport {
  ShopPowerSyncRepository(
    super.powerSync,
    super.dateTimeService, {
    String Function()? idGenerator,
  }) : _idGenerator = idGenerator ?? const Uuid().v4;

  final String Function() _idGenerator;

  Future<Stream<void>> watchChanges() async {
    final db = await database;
    return db
        .watch(
          'SELECT id, name, shop_type, address, phone_number, email, '
          'tax_number, is_active, last_modified_utc FROM shop',
          throttle: const Duration(milliseconds: 250),
        )
        .map((_) {});
  }

  Future<List<Shop>> getAll({String? searchQuery}) async {
    final db = await database;
    final pending = await pendingOperations('shop');
    final args = <Object?>[];
    var where = '1 = 1';
    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final q = '%${searchQuery.trim()}%';
      where += ' AND (name LIKE ? OR address LIKE ? OR tax_number LIKE ?)';
      args.addAll([q, q, q]);
    }
    final rows = await db.getAll(
      'SELECT id, name, shop_type, address, phone_number, email, tax_number, '
      'is_active, last_modified_utc FROM shop WHERE $where '
      'ORDER BY name COLLATE NOCASE ASC',
      args,
    );
    return rows.map((row) => _toShop(row, pending[row['id']])).toList();
  }

  Future<Shop> create(ShopDraft draft) async {
    final normalized = draft.normalized();
    final db = await database;
    final id = _idGenerator();
    final now = nowIso();
    await db.execute(
      'INSERT INTO shop(id, name, shop_type, address, phone_number, email, '
      'tax_number, is_active, last_modified_utc) '
      'VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)',
      [
        id,
        normalized.name,
        normalized.shopType.apiValue,
        normalized.address,
        normalized.phoneNumber,
        normalized.email,
        normalized.taxNumber,
        normalized.isActive ? 1 : 0,
        now,
      ],
    );
    return _byId(id);
  }

  Future<Shop> update(String id, ShopDraft draft) async {
    final normalized = draft.normalized();
    final db = await database;
    if (await db.getOptional('SELECT id FROM shop WHERE id = ?', [id]) ==
        null) {
      throw const LocalStorageException('Shop was not found.');
    }
    await db.execute(
      'UPDATE shop SET name = ?, shop_type = ?, address = ?, phone_number = ?, '
      'email = ?, tax_number = ?, is_active = ?, last_modified_utc = ? '
      'WHERE id = ?',
      [
        normalized.name,
        normalized.shopType.apiValue,
        normalized.address,
        normalized.phoneNumber,
        normalized.email,
        normalized.taxNumber,
        normalized.isActive ? 1 : 0,
        nowIso(),
        id,
      ],
    );
    return _byId(id);
  }

  Future<void> delete(String id) async {
    final count = await countLocalRecords(id);
    if (count > 0) throw ShopInUseException(count);
    final db = await database;
    if (await db.getOptional('SELECT id FROM shop WHERE id = ?', [id]) ==
        null) {
      return;
    }
    await db.execute('UPDATE shop SET last_modified_utc = ? WHERE id = ?', [
      nowIso(),
      id,
    ]);
    await db.execute('DELETE FROM shop WHERE id = ?', [id]);
  }

  Future<int> getPendingCount() => pendingCount('shop');

  Future<int> countLocalRecords(String shopId) async {
    final db = await database;
    final row = await db.get(
      'SELECT '
      '(SELECT COUNT(*) FROM category WHERE shop_id = ?) + '
      '(SELECT COUNT(*) FROM product WHERE shop_id = ?) AS count',
      [shopId, shopId],
    );
    return row['count'] as int;
  }

  Future<Shop> _byId(String id) async {
    final db = await database;
    final row = await db.getOptional(
      'SELECT id, name, shop_type, address, phone_number, email, tax_number, '
      'is_active, last_modified_utc FROM shop WHERE id = ?',
      [id],
    );
    if (row == null) throw const LocalStorageException('Shop was not found.');
    final pending = await pendingOperations('shop');
    return _toShop(row, pending[id]);
  }

  Shop _toShop(Map<String, Object?> row, String? operation) {
    final changedAt = timestamp(row['last_modified_utc']);
    return Shop(
      id: row['id']! as String,
      name: row['name']! as String,
      shopType: _shopType(row['shop_type']),
      address: row['address'] as String?,
      phoneNumber: row['phone_number'] as String?,
      email: row['email'] as String?,
      taxNumber: row['tax_number'] as String?,
      isActive: row['is_active'] == 1,
      createdAt: changedAt,
      updatedAt: changedAt,
      lastModifiedUtc: changedAt,
      syncStatus: operation == null
          ? ShopSyncStatus.synced
          : operation == 'PUT'
          ? ShopSyncStatus.pendingCreate
          : ShopSyncStatus.pendingUpdate,
    );
  }

  ShopType _shopType(Object? value) {
    final normalized = value?.toString().trim().toLowerCase();
    return normalized == 'wholesaleshop' || normalized == 'wholesale_shop'
        ? ShopType.wholesaleShop
        : ShopType.retailShop;
  }
}
