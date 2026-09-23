import 'package:uuid/uuid.dart';

import '../../models/unit_of_measure.dart';
import '../data_exception.dart';
import 'powersync_repository_support.dart';

class UnitOfMeasurePowerSyncRepository extends PowerSyncRepositorySupport {
  UnitOfMeasurePowerSyncRepository(
    super.powerSync,
    super.dateTimeService, {
    String Function()? idGenerator,
  }) : _idGenerator = idGenerator ?? const Uuid().v4;

  final String Function() _idGenerator;

  Future<Stream<void>> watchChanges() async {
    final db = await database;
    return db
        .watch(
          'SELECT id, name, symbol, description, last_modified_utc '
          'FROM unit_of_measure',
          throttle: const Duration(milliseconds: 250),
        )
        .map((_) {});
  }

  Future<List<UnitOfMeasure>> getAll({
    String? searchQuery,
    int? limit,
    int? offset,
  }) async {
    final db = await database;
    final pending = await pendingOperations('unit_of_measure');
    final args = <Object?>[];
    var where = '1 = 1';
    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final q = '%${searchQuery.trim()}%';
      where += ' AND (name LIKE ? OR symbol LIKE ?)';
      args.addAll([q, q]);
    }
    var sql =
        'SELECT id, name, symbol, description, last_modified_utc '
        'FROM unit_of_measure WHERE $where ORDER BY name COLLATE NOCASE ASC';
    if (limit != null) {
      sql += ' LIMIT ?';
      args.add(limit);
      if (offset != null) {
        sql += ' OFFSET ?';
        args.add(offset);
      }
    }
    final rows = await db.getAll(sql, args);
    return rows.map((row) => _toUnit(row, pending[row['id']])).toList();
  }

  Future<int> getTotalCount({String? searchQuery}) async {
    final db = await database;
    final args = <Object?>[];
    var where = '1 = 1';
    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final q = '%${searchQuery.trim()}%';
      where += ' AND (name LIKE ? OR symbol LIKE ?)';
      args.addAll([q, q]);
    }
    final row = await db.get(
      'SELECT COUNT(*) AS count FROM unit_of_measure WHERE $where',
      args,
    );
    return row['count'] as int;
  }

  Future<UnitOfMeasure> create(UnitOfMeasureDraft draft) async {
    final normalized = draft.normalized();
    final db = await database;
    final id = _idGenerator();
    await db.execute(
      'INSERT INTO unit_of_measure(id, name, symbol, description, '
      'last_modified_utc) VALUES (?, ?, ?, ?, ?)',
      [
        id,
        normalized.name,
        normalized.symbol,
        normalized.description,
        nowIso(),
      ],
    );
    return _byId(id);
  }

  Future<UnitOfMeasure> update(String id, UnitOfMeasureDraft draft) async {
    final normalized = draft.normalized();
    final db = await database;
    if (await db.getOptional('SELECT id FROM unit_of_measure WHERE id = ?', [
          id,
        ]) ==
        null) {
      throw const LocalStorageException('Unit of measurement was not found.');
    }
    await db.execute(
      'UPDATE unit_of_measure SET name = ?, symbol = ?, description = ?, '
      'last_modified_utc = ? WHERE id = ?',
      [
        normalized.name,
        normalized.symbol,
        normalized.description,
        nowIso(),
        id,
      ],
    );
    return _byId(id);
  }

  Future<void> delete(String id) async {
    final count = await countProductsUsingUnit(id);
    if (count > 0) throw UnitOfMeasureInUseException(count);
    final db = await database;
    if (await db.getOptional('SELECT id FROM unit_of_measure WHERE id = ?', [
          id,
        ]) ==
        null) {
      return;
    }
    await db.execute(
      'UPDATE unit_of_measure SET last_modified_utc = ? WHERE id = ?',
      [nowIso(), id],
    );
    await db.execute('DELETE FROM unit_of_measure WHERE id = ?', [id]);
  }

  Future<int> getPendingCount() => pendingCount('unit_of_measure');

  Future<int> countProductsUsingUnit(String unitId) async {
    final db = await database;
    final row = await db.get(
      'SELECT COUNT(*) AS count FROM product WHERE base_unit_id = ?',
      [unitId],
    );
    return row['count'] as int;
  }

  Future<UnitOfMeasure> _byId(String id) async {
    final db = await database;
    final row = await db.getOptional(
      'SELECT id, name, symbol, description, last_modified_utc '
      'FROM unit_of_measure WHERE id = ?',
      [id],
    );
    if (row == null) {
      throw const LocalStorageException('Unit of measurement was not found.');
    }
    final pending = await pendingOperations('unit_of_measure');
    return _toUnit(row, pending[id]);
  }

  UnitOfMeasure _toUnit(Map<String, Object?> row, String? operation) {
    final changedAt = timestamp(row['last_modified_utc']);
    return UnitOfMeasure(
      id: row['id']! as String,
      name: row['name']! as String,
      symbol: row['symbol'] as String? ?? '',
      description: row['description'] as String?,
      createdAt: changedAt,
      updatedAt: changedAt,
      lastModifiedUtc: changedAt,
      syncStatus: operation == null
          ? UnitOfMeasureSyncStatus.synced
          : operation == 'PUT'
          ? UnitOfMeasureSyncStatus.pendingCreate
          : UnitOfMeasureSyncStatus.pendingUpdate,
    );
  }
}
