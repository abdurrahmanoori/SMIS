import 'package:powersync/powersync.dart';
import 'package:uuid/uuid.dart';

import '../../models/supplier.dart';
import '../data_exception.dart';
import 'powersync_repository_support.dart';

class SupplierPowerSyncRepository extends PowerSyncRepositorySupport {
  SupplierPowerSyncRepository(
    super.powerSync,
    super.dateTimeService, {
    String Function()? idGenerator,
  }) : _idGenerator = idGenerator ?? const Uuid().v4;

  final String Function() _idGenerator;

  Future<Stream<void>> watchChanges(String shopId) async {
    final db = await database;
    return db
        .watch(
          'SELECT supplier.id, supplier.name, supplier.phone_number, '
          'supplier.notes, supplier.is_active, supplier.shop_id, '
          'supplier.last_modified_utc, sync_error.message AS sync_error_message '
          'FROM supplier LEFT JOIN sync_error ON sync_error.table_name = ? '
          'AND sync_error.record_id = supplier.id WHERE supplier.shop_id = ?',
          parameters: ['supplier', shopId],
          throttle: const Duration(milliseconds: 250),
        )
        .map((_) {});
  }

  Future<List<Supplier>> getAll(
    String shopId, {
    String? searchQuery,
    int? limit,
    int? offset,
    bool? isActive,
  }) async {
    final db = await database;
    final pending = await pendingOperations('supplier');
    final errors = await syncErrors('supplier');
    final args = <Object?>[shopId];
    var where = 'shop_id = ?';

    if (isActive != null) {
      where += ' AND is_active = ?';
      args.add(isActive ? 1 : 0);
    }

    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final search = '%${searchQuery.trim()}%';
      where += ' AND (name LIKE ? OR phone_number LIKE ? OR notes LIKE ?)';
      args.addAll([search, search, search]);
    }

    var sql =
        'SELECT id, name, phone_number, notes, is_active, shop_id, '
        'last_modified_utc FROM supplier WHERE $where '
        'ORDER BY name COLLATE NOCASE ASC';
    if (limit != null) {
      sql += ' LIMIT ?';
      args.add(limit);
      if (offset != null) {
        sql += ' OFFSET ?';
        args.add(offset);
      }
    }

    final rows = await db.getAll(sql, args);
    return rows
        .map((row) => _toSupplier(row, pending[row['id']], errors[row['id']]))
        .toList(growable: false);
  }

  Future<int> getTotalCount(String shopId, {String? searchQuery}) async {
    final db = await database;
    final args = <Object?>[shopId];
    var where = 'shop_id = ?';
    if (searchQuery != null && searchQuery.trim().isNotEmpty) {
      final search = '%${searchQuery.trim()}%';
      where += ' AND (name LIKE ? OR phone_number LIKE ? OR notes LIKE ?)';
      args.addAll([search, search, search]);
    }

    final row = await db.get(
      'SELECT COUNT(*) AS count FROM supplier WHERE $where',
      args,
    );
    return row['count'] as int;
  }

  Future<Supplier> create(SupplierDraft draft, String shopId) async {
    final normalized = draft.normalized();
    final db = await database;
    await _ensureUniqueName(db, shopId, normalized.name);

    final id = _idGenerator();
    await db.execute(
      'INSERT INTO supplier('
      'id, name, phone_number, notes, is_active, shop_id, last_modified_utc'
      ') VALUES (?, ?, ?, ?, ?, ?, ?)',
      [
        id,
        normalized.name,
        normalized.phoneNumber,
        normalized.notes,
        normalized.isActive ? 1 : 0,
        shopId,
        nowIso(),
      ],
    );

    return _byId(db, id);
  }

  Future<Supplier> update(String id, SupplierDraft draft) async {
    final normalized = draft.normalized();
    final db = await database;
    final current = await db.getOptional(
      'SELECT shop_id FROM supplier WHERE id = ?',
      [id],
    );
    if (current == null) {
      throw const LocalStorageException('Supplier was not found.');
    }

    final shopId = current['shop_id'] as String;
    await _ensureUniqueName(db, shopId, normalized.name, excludeId: id);

    await db.execute(
      'UPDATE supplier SET name = ?, phone_number = ?, notes = ?, '
      'is_active = ?, last_modified_utc = ? WHERE id = ?',
      [
        normalized.name,
        normalized.phoneNumber,
        normalized.notes,
        normalized.isActive ? 1 : 0,
        nowIso(),
        id,
      ],
    );

    return _byId(db, id);
  }

  Future<Supplier> updateStatus(String id, bool isActive) async {
    final db = await database;
    if (await db.getOptional('SELECT id FROM supplier WHERE id = ?', [id]) ==
        null) {
      throw const LocalStorageException('Supplier was not found.');
    }

    await db.execute(
      'UPDATE supplier SET is_active = ?, last_modified_utc = ? WHERE id = ?',
      [isActive ? 1 : 0, nowIso(), id],
    );
    return _byId(db, id);
  }

  Future<int> getPendingCount(String shopId) => pendingCount('supplier');

  Future<Supplier> _byId(PowerSyncDatabase db, String id) async {
    final row = await db.getOptional(
      'SELECT id, name, phone_number, notes, is_active, shop_id, '
      'last_modified_utc FROM supplier WHERE id = ?',
      [id],
    );
    if (row == null) {
      throw const LocalStorageException('Supplier was not found.');
    }
    final pending = await pendingOperations('supplier');
    final errors = await syncErrors('supplier');
    return _toSupplier(row, pending[id], errors[id]);
  }

  Future<void> _ensureUniqueName(
    PowerSyncDatabase db,
    String shopId,
    String name, {
    String? excludeId,
  }) async {
    final args = <Object?>[shopId, name.trim()];
    var sql =
        'SELECT id FROM supplier '
        'WHERE shop_id = ? AND name = ? COLLATE NOCASE';
    if (excludeId != null) {
      sql += ' AND id != ?';
      args.add(excludeId);
    }
    sql += ' LIMIT 1';

    if (await db.getOptional(sql, args) != null) {
      throw const LocalStorageException(
        'A supplier with this name already exists in the shop.',
      );
    }
  }

  Supplier _toSupplier(
    Map<String, Object?> row,
    String? operation,
    String? syncError,
  ) {
    final changedAt = timestamp(row['last_modified_utc']);
    return Supplier(
      id: row['id']! as String,
      shopId: row['shop_id']! as String,
      name: row['name']! as String,
      phoneNumber: row['phone_number'] as String?,
      notes: row['notes'] as String?,
      isActive: row['is_active'] == 1,
      lastModifiedUtc: changedAt,
      syncStatus: syncError != null
          ? SupplierSyncStatus.failed
          : operation == null
          ? SupplierSyncStatus.synced
          : operation == 'PUT'
          ? SupplierSyncStatus.pendingCreate
          : SupplierSyncStatus.pendingUpdate,
      lastSyncError: syncError,
    );
  }
}
