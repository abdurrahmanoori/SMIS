import 'package:flutter_test/flutter_test.dart';
import 'package:smis_flutter/core/error/app_exception.dart';
import 'package:smis_flutter/core/network/connectivity_service.dart';
import 'package:smis_flutter/features/category/data/datasources/category_local_data_source.dart';
import 'package:smis_flutter/features/category/data/datasources/category_remote_data_source.dart';
import 'package:smis_flutter/features/category/data/models/category_local_record.dart';
import 'package:smis_flutter/features/category/data/models/category_remote_model.dart';
import 'package:smis_flutter/features/category/data/sync/category_sync_service.dart';
import 'package:smis_flutter/features/category/domain/entities/category.dart';

import 'support/test_database.dart';

void main() {
  test('last-write-wins pushes the newer local update', () async {
    final database = await createTestDatabase();
    addTearDown(database.close);
    final local = CategoryLocalDataSource(database);
    final older = DateTime.utc(2026, 1, 1);
    final newer = older.add(const Duration(minutes: 5));
    await local.put(_pendingRecord(name: 'Local', timestamp: newer));
    final remote = _FakeRemote(
      server: _remoteModel(name: 'Server', timestamp: older),
    );
    final service = CategorySyncService(local, remote, _Online());

    final result = await service.synchronize(force: true);

    expect(result.success, isTrue);
    expect(result.pushed, 1);
    expect(remote.updatedName, 'Local');
    expect(
      (await local.getById('category-1'))!.syncStatus,
      CategorySyncStatus.synced,
    );
  });

  test('last-write-wins applies the newer server update', () async {
    final database = await createTestDatabase();
    addTearDown(database.close);
    final local = CategoryLocalDataSource(database);
    final older = DateTime.utc(2026, 1, 1);
    final newer = older.add(const Duration(minutes: 5));
    await local.put(_pendingRecord(name: 'Local', timestamp: older));
    final server = _remoteModel(name: 'Server', timestamp: newer);
    final remote = _FakeRemote(server: server, pullChanges: [server]);
    final service = CategorySyncService(local, remote, _Online());

    final result = await service.synchronize(force: true);

    expect(result.success, isTrue);
    expect(result.conflictsResolved, 1);
    final merged = await local.getById('category-1');
    expect(merged!.name, 'Server');
    expect(merged.pendingOperation, CategoryPendingOperation.none);
  });

  test('transient failures remain queued with retry metadata', () async {
    final database = await createTestDatabase();
    addTearDown(database.close);
    final local = CategoryLocalDataSource(database);
    await local.put(
      _pendingRecord(name: 'Local', timestamp: DateTime.utc(2026, 1, 1)),
    );
    final remote = _FakeRemote(failGet: true);
    final service = CategorySyncService(local, remote, _Online());

    final result = await service.synchronize(force: true);

    expect(result.success, isFalse);
    expect(result.transientFailure, isTrue);
    expect(result.pending, 1);
    final failed = await local.getById('category-1');
    expect(failed!.syncStatus, CategorySyncStatus.failed);
    expect(failed.retryCount, 1);
    expect(failed.nextRetryAt, isNotNull);
  });
}

CategoryLocalRecord _pendingRecord({
  required String name,
  required DateTime timestamp,
}) => CategoryLocalRecord(
  id: 'category-1',
  name: name,
  isActive: true,
  createdAt: timestamp,
  updatedAt: timestamp,
  lastModifiedUtc: timestamp,
  isDeleted: false,
  pendingOperation: CategoryPendingOperation.update,
  syncStatus: CategorySyncStatus.pendingUpdate,
  retryCount: 0,
);

CategoryRemoteModel _remoteModel({
  required String name,
  required DateTime timestamp,
}) => CategoryRemoteModel(
  id: 'category-1',
  name: name,
  isActive: true,
  shopId: 'shop-1',
  lastModifiedUtc: timestamp,
  isDeleted: false,
);

class _Online implements NetworkConnectivity {
  @override
  Future<bool> get hasConnection async => true;
}

class _FakeRemote implements CategoryRemoteDataSource {
  _FakeRemote({this.server, this.pullChanges = const [], this.failGet = false});

  CategoryRemoteModel? server;
  final List<CategoryRemoteModel> pullChanges;
  final bool failGet;
  String? updatedName;

  @override
  Future<CategoryRemoteModel> create(CategoryLocalRecord category) async =>
      _fromLocal(category);

  @override
  Future<void> delete(CategoryLocalRecord category) async => server = null;

  @override
  Future<CategoryRemoteModel?> getById(String id) async {
    if (failGet) {
      throw const RemoteTransientException('Connection lost.');
    }
    return server;
  }

  @override
  Future<List<CategoryRemoteModel>> pull(DateTime changedSince) async =>
      pullChanges;

  @override
  Future<CategoryRemoteModel> update(CategoryLocalRecord category) async {
    updatedName = category.name;
    return server = _fromLocal(category);
  }

  CategoryRemoteModel _fromLocal(CategoryLocalRecord category) =>
      CategoryRemoteModel(
        id: category.id,
        name: category.name,
        code: category.code,
        description: category.description,
        isActive: category.isActive,
        shopId: 'shop-1',
        lastModifiedUtc: category.lastModifiedUtc,
        isDeleted: false,
      );
}
