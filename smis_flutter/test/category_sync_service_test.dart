import 'package:flutter_test/flutter_test.dart';
import 'package:smis_flutter/data/category_api.dart';
import 'package:smis_flutter/data/category_repository.dart';
import 'package:smis_flutter/data/data_exception.dart';
import 'package:smis_flutter/models/category.dart';
import 'package:smis_flutter/models/category_local_record.dart';
import 'package:smis_flutter/models/category_remote_model.dart';
import 'package:smis_flutter/services/category_sync_service.dart';
import 'package:smis_flutter/services/connectivity_service.dart';

import 'support/test_database.dart';

void main() {
  test('last-write-wins pushes the newer local update', () async {
    final database = await createTestDatabase();
    addTearDown(database.close);
    final repository = CategoryRepository(database);
    final older = DateTime.utc(2026, 1, 1);
    final newer = older.add(const Duration(minutes: 5));
    await repository.saveRecord(
      _pendingRecord(name: 'Local', timestamp: newer),
    );
    final remote = _FakeRemote(
      server: _remoteModel(name: 'Server', timestamp: older),
    );
    final service = CategorySyncService(repository, remote, _Online());

    final result = await service.synchronize(force: true);

    expect(result.success, isTrue);
    expect(result.pushed, 1);
    expect(remote.updatedName, 'Local');
    expect(
      (await repository.getRecord('category-1'))!.syncStatus,
      CategorySyncStatus.synced,
    );
  });

  test('last-write-wins applies the newer server update', () async {
    final database = await createTestDatabase();
    addTearDown(database.close);
    final repository = CategoryRepository(database);
    final older = DateTime.utc(2026, 1, 1);
    final newer = older.add(const Duration(minutes: 5));
    await repository.saveRecord(
      _pendingRecord(name: 'Local', timestamp: older),
    );
    final server = _remoteModel(name: 'Server', timestamp: newer);
    final remote = _FakeRemote(server: server, pullChanges: [server]);
    final service = CategorySyncService(repository, remote, _Online());

    final result = await service.synchronize(force: true);

    expect(result.success, isTrue);
    expect(result.conflictsResolved, 1);
    final merged = await repository.getRecord('category-1');
    expect(merged!.name, 'Server');
    expect(merged.pendingOperation, CategoryPendingOperation.none);
  });

  test('transient failures remain queued with retry metadata', () async {
    final database = await createTestDatabase();
    addTearDown(database.close);
    final repository = CategoryRepository(database);
    await repository.saveRecord(
      _pendingRecord(name: 'Local', timestamp: DateTime.utc(2026, 1, 1)),
    );
    final remote = _FakeRemote(failGet: true);
    final service = CategorySyncService(repository, remote, _Online());

    final result = await service.synchronize(force: true);

    expect(result.success, isFalse);
    expect(result.transientFailure, isTrue);
    expect(result.pending, 1);
    expect(result.failures, hasLength(1));
    expect(result.failures.single.categoryId, 'category-1');
    expect(
      result.messageFor(includeDiagnostics: false),
      'Category sync completed with 1 failed request(s).',
    );
    final diagnostics = result.messageFor(includeDiagnostics: true);
    expect(diagnostics, contains('Phase: push update'));
    expect(diagnostics, contains('RemoteTransientException'));
    expect(diagnostics, contains('Connection lost.'));
    expect(diagnostics, contains('Socket refused'));
    expect(diagnostics, contains('Stack trace:'));
    final failed = await repository.getRecord('category-1');
    expect(failed!.syncStatus, CategorySyncStatus.failed);
    expect(failed.retryCount, 1);
    expect(failed.nextRetryAt, isNotNull);
  });

  test(
    'unexpected connectivity errors retain diagnostics only on request',
    () async {
      final database = await createTestDatabase();
      addTearDown(database.close);
      final repository = CategoryRepository(database);
      final service = CategorySyncService(
        repository,
        _FakeRemote(),
        _BrokenConnectivity(),
      );

      final result = await service.synchronize(force: true);

      expect(result.success, isFalse);
      expect(result.message, 'Category sync failed unexpectedly.');
      expect(
        result.messageFor(includeDiagnostics: false),
        'Category sync failed unexpectedly.',
      );
      expect(
        result.messageFor(includeDiagnostics: true),
        allOf(
          contains('Phase: connectivity check'),
          contains('Connectivity plugin failed'),
          contains('Stack trace:'),
        ),
      );
    },
  );
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

class _BrokenConnectivity implements NetworkConnectivity {
  @override
  Future<bool> get hasConnection async =>
      throw StateError('Connectivity plugin failed');
}

class _FakeRemote implements CategoryApi {
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
      throw RemoteTransientException(
        'Connection lost.',
        cause: StateError('Socket refused'),
      );
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
