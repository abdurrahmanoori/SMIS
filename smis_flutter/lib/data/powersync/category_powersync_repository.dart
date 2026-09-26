import 'package:powersync/powersync.dart';
import 'package:uuid/uuid.dart';

import '../../models/category.dart';
import '../data_exception.dart';
import 'powersync_repository_support.dart';

class CategoryPowerSyncRepository extends PowerSyncRepositorySupport {
  CategoryPowerSyncRepository(
    super.powerSync,
    super.dateTimeService, {
    String Function()? idGenerator,
  }) : _idGenerator = idGenerator ?? const Uuid().v4;

  final String Function() _idGenerator;

  Future<Stream<void>> watchChanges(String shopId) async {
    final database = await this.database;
    return database
        .watch(
          'SELECT id, name, code, '
          'description, is_active, shop_id, last_modified_utc '
          'FROM category WHERE shop_id = ?',
          parameters: [shopId],
          throttle: const Duration(milliseconds: 250),
        )
        .map((_) {});
  }

  Future<List<Category>> getAll(
    String shopId, {
    required String languageId,
    String? searchQuery,
    int? limit,
    int? offset,
  }) async {
    final database = await this.database;
    final pending = await pendingOperations('category');
    final args = <Object?>[shopId];
    var where = 'shop_id = ?';

    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final search = '%${searchQuery.trim()}%';
      where += ' AND (name LIKE ? OR code LIKE ? OR description LIKE ?)';
      args.addAll([search, search, search]);
    }

    var sql =
        'SELECT id, name, code, '
        'description, is_active, shop_id, last_modified_utc '
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
    return rows
        .map((row) => _toCategory(row, pending[row['id']], languageId))
        .toList(growable: false);
  }

  Future<int> getTotalCount(String shopId, {String? searchQuery}) async {
    final database = await this.database;
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

  Future<Category> create(
    CategoryDraft draft,
    String shopId, {
    required String languageId,
  }) async {
    final normalized = draft.normalized();
    final database = await this.database;
    await _ensureUniqueName(database, shopId, normalized.name);

    final id = _idGenerator();
    await database.execute(
      'INSERT INTO category('
      'id, name, code, description, is_active, shop_id, last_modified_utc'
      ') VALUES (?, ?, ?, ?, ?, ?, ?)',
      [
        id,
        normalized.name,
        normalized.code,
        normalized.description,
        normalized.isActive ? 1 : 0,
        shopId,
        nowIso(),
      ],
    );

    return _byId(database, id, languageId);
  }

  Future<Category> update(
    String id,
    CategoryDraft draft, {
    required String languageId,
  }) async {
    final normalized = draft.normalized();
    final database = await this.database;
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
      'UPDATE category SET name = ?, code = ?, '
      'description = ?, is_active = ?, shop_id = ?, last_modified_utc = ? '
      'WHERE id = ?',
      [
        normalized.name,
        normalized.code,
        normalized.description,
        normalized.isActive ? 1 : 0,
        shopId,
        nowIso(),
        id,
      ],
    );

    return _byId(database, id, languageId);
  }

  Future<void> delete(String id) async {
    final productCount = await countProductsUsingCategory(id);
    if (productCount > 0) throw CategoryInUseException(productCount);

    final database = await this.database;
    if (await database.getOptional('SELECT id FROM category WHERE id = ?', [
          id,
        ]) ==
        null) {
      return;
    }
    await database.execute(
      'UPDATE category SET last_modified_utc = ? WHERE id = ?',
      [nowIso(), id],
    );
    await database.execute('DELETE FROM category WHERE id = ?', [id]);
  }

  Future<int> getPendingCount(String shopId) => pendingCount('category');

  Future<int> countProductsUsingCategory(String categoryId) async {
    final database = await this.database;
    final result = await database.get(
      'SELECT COUNT(*) AS count FROM product WHERE category_id = ?',
      [categoryId],
    );
    return result['count'] as int;
  }

  Future<Category> _byId(
    PowerSyncDatabase database,
    String id,
    String languageId,
  ) async {
    final row = await database.getOptional(
      'SELECT id, name, code, '
      'description, is_active, shop_id, last_modified_utc '
      'FROM category WHERE id = ?',
      [id],
    );
    if (row == null) {
      throw const LocalStorageException('Category was not found.');
    }
    final pending = await pendingOperations('category');
    return _toCategory(row, pending[id], languageId);
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

  Category _toCategory(
    Map<String, Object?> row,
    String? operation,
    String languageId,
  ) {
    final changedAt = timestamp(row['last_modified_utc']);
    return Category(
      id: row['id']! as String,
      name: row['name']! as String,
      code: row['code'] as String?,
      description: row['description'] as String?,
      isActive: row['is_active'] == 1,
      shopId: row['shop_id'] as String?,
      createdAt: changedAt,
      updatedAt: changedAt,
      lastModifiedUtc: changedAt,
      syncStatus: operation == null
          ? CategorySyncStatus.synced
          : operation == 'PUT'
          ? CategorySyncStatus.pendingCreate
          : CategorySyncStatus.pendingUpdate,
    );
  }
}
