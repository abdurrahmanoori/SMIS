import 'package:powersync/powersync.dart';
import 'package:sqflite/sqflite.dart';
import 'package:uuid/uuid.dart';

import '../../models/category.dart';
import '../data_exception.dart';
import '../database.dart';
import 'category_powersync_database.dart';

class CategoryPowerSyncRepository {
  CategoryPowerSyncRepository(
    this._powerSync,
    this._legacyDatabase, {
    String Function()? idGenerator,
  }) : _idGenerator = idGenerator ?? const Uuid().v4;

  final CategoryPowerSyncDatabase _powerSync;
  final AppDatabase _legacyDatabase;
  final String Function() _idGenerator;

  Future<Stream<void>> watchChanges(String shopId) async {
    final database = await _database();
    return database
        .watch(
          'SELECT id, name, code, description, is_active, shop_id '
          'FROM category WHERE shop_id = ?',
          parameters: [shopId],
          throttle: const Duration(milliseconds: 250),
        )
        .map((_) {});
  }

  Future<List<Category>> getAll(
    String shopId, {
    String? searchQuery,
    int? limit,
    int? offset,
  }) async {
    final database = await _database();
    final args = <Object?>[shopId];
    var where = 'shop_id = ?';

    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final search = '%${searchQuery.trim()}%';
      where += ' AND (name LIKE ? OR code LIKE ? OR description LIKE ?)';
      args.addAll([search, search, search]);
    }

    var sql =
        'SELECT id, name, code, description, is_active, shop_id '
        'FROM category WHERE $where ORDER BY name COLLATE NOCASE ASC';
    if (limit != null) {
      sql += ' LIMIT ?';
      args.add(limit);
      if (offset != null) {
        sql += ' OFFSET ?';
        args.add(offset);
      }
    }

    final rows = await database.getAll(sql, args);
    return rows.map(_toCategory).toList(growable: false);
  }

  Future<int> getTotalCount(String shopId, {String? searchQuery}) async {
    final database = await _database();
    final args = <Object?>[shopId];
    var where = 'shop_id = ?';

    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final search = '%${searchQuery.trim()}%';
      where += ' AND (name LIKE ? OR code LIKE ? OR description LIKE ?)';
      args.addAll([search, search, search]);
    }

    final row = await database.get(
      'SELECT COUNT(*) AS count FROM category WHERE $where',
      args,
    );
    return row['count'] as int;
  }

  Future<Category> create(CategoryDraft draft, String shopId) async {
    final normalized = draft.normalized();
    final database = await _database();
    await _ensureUniqueName(database, shopId, normalized.name);

    final id = _idGenerator();
    await database.execute(
      'INSERT INTO category('
      'id, name, code, description, is_active, shop_id'
      ') VALUES (?, ?, ?, ?, ?, ?)',
      [
        id,
        normalized.name,
        normalized.code,
        normalized.description,
        normalized.isActive ? 1 : 0,
        shopId,
      ],
    );

    return _byId(database, id);
  }

  Future<Category> update(String id, CategoryDraft draft) async {
    final normalized = draft.normalized();
    final database = await _database();
    final current = await database.getOptional(
      'SELECT shop_id FROM category WHERE id = ?',
      [id],
    );
    if (current == null) {
      throw const LocalStorageException('Category was not found.');
    }

    final shopId = current['shop_id'] as String;
    await _ensureUniqueName(database, shopId, normalized.name, excludeId: id);

    await database.execute(
      'UPDATE category SET name = ?, code = ?, description = ?, '
      'is_active = ?, shop_id = ? WHERE id = ?',
      [
        normalized.name,
        normalized.code,
        normalized.description,
        normalized.isActive ? 1 : 0,
        shopId,
        id,
      ],
    );

    return _byId(database, id);
  }

  Future<void> delete(String id) async {
    final productCount = await countProductsUsingCategory(id);
    if (productCount > 0) throw CategoryInUseException(productCount);

    final database = await _database();
    await database.execute('DELETE FROM category WHERE id = ?', [id]);
  }

  Future<int> getPendingCount(String shopId) async {
    // This proof-of-concept PowerSync database contains Category only, so the
    // queue count is the Category pending-write count.
    final database = await _database();
    return (await database.getUploadQueueStats()).count;
  }

  Future<int> countProductsUsingCategory(String categoryId) async {
    // Product has not moved to PowerSync yet. Reuse the existing local product
    // table so Category deletion still protects current local relationships.
    final database = await _legacyDatabase.instance;
    final result = await database.rawQuery(
      'SELECT COUNT(*) AS count FROM products '
      'WHERE is_deleted = 0 AND category_id = ?',
      [categoryId],
    );
    return Sqflite.firstIntValue(result) ?? 0;
  }

  Future<PowerSyncDatabase> _database() async {
    final database = await _powerSync.database;
    // Start replication when configured, without making offline local reads
    // depend on network availability.
    _powerSync.connectIfConfigured().catchError((_) => database);
    return database;
  }

  Future<Category> _byId(PowerSyncDatabase database, String id) async {
    final row = await database.getOptional(
      'SELECT id, name, code, description, is_active, shop_id '
      'FROM category WHERE id = ?',
      [id],
    );
    if (row == null) {
      throw const LocalStorageException('Category was not found.');
    }
    return _toCategory(row);
  }

  Future<void> _ensureUniqueName(
    PowerSyncDatabase database,
    String shopId,
    String name, {
    String? excludeId,
  }) async {
    final args = <Object?>[shopId, name.trim()];
    var sql =
        'SELECT id FROM category '
        'WHERE shop_id = ? AND name = ? COLLATE NOCASE';
    if (excludeId != null) {
      sql += ' AND id != ?';
      args.add(excludeId);
    }
    sql += ' LIMIT 1';

    if (await database.getOptional(sql, args) != null) {
      throw CategoryAlreadyExistsException();
    }
  }

  Category _toCategory(Map<String, Object?> row) {
    final now = DateTime.fromMillisecondsSinceEpoch(0, isUtc: true);
    return Category(
      id: row['id']! as String,
      name: row['name']! as String,
      code: row['code'] as String?,
      description: row['description'] as String?,
      isActive: row['is_active'] == 1,
      shopId: row['shop_id'] as String?,
      createdAt: now,
      updatedAt: now,
      lastModifiedUtc: now,
      syncStatus: CategorySyncStatus.synced,
    );
  }
}
