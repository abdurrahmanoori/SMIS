import 'package:flutter_test/flutter_test.dart';
import 'package:smis_flutter/features/category/data/datasources/category_local_data_source.dart';
import 'package:smis_flutter/features/category/data/models/category_local_record.dart';
import 'package:smis_flutter/features/category/data/repositories/category_repository_impl.dart';
import 'package:smis_flutter/features/category/domain/entities/category.dart';

import 'support/test_database.dart';

void main() {
  test(
    'offline create, update, and delete never require a remote API',
    () async {
      final database = await createTestDatabase();
      addTearDown(database.close);
      final local = CategoryLocalDataSource(database);
      var now = DateTime.utc(2026, 1, 1);
      final repository = CategoryRepositoryImpl(
        local,
        utcNow: () => now,
        idGenerator: () => 'local-id',
      );

      final created = await repository.create(
        const CategoryDraft(name: ' Drinks ', code: ' BEV ', isActive: true),
      );
      expect(created.name, 'Drinks');
      expect(created.code, 'BEV');
      expect(created.syncStatus, CategorySyncStatus.pendingCreate);
      expect(await repository.getPendingCount(), 1);

      now = now.add(const Duration(minutes: 1));
      final updated = await repository.update(
        created.id,
        const CategoryDraft(name: 'Beverages', isActive: false),
      );
      expect(updated.name, 'Beverages');
      expect(updated.isActive, isFalse);
      expect(updated.syncStatus, CategorySyncStatus.pendingCreate);

      await repository.delete(created.id);
      expect(await repository.getAll(), isEmpty);
      expect(await repository.getPendingCount(), 0);
    },
  );

  test('deleting a server-backed category retains a local tombstone', () async {
    final database = await createTestDatabase();
    addTearDown(database.close);
    final local = CategoryLocalDataSource(database);
    final timestamp = DateTime.utc(2026, 1, 1);
    await local.put(
      CategoryLocalRecord(
        id: 'server-id',
        name: 'Food',
        isActive: true,
        createdAt: timestamp,
        updatedAt: timestamp,
        lastModifiedUtc: timestamp,
        isDeleted: false,
        pendingOperation: CategoryPendingOperation.none,
        syncStatus: CategorySyncStatus.synced,
        retryCount: 0,
      ),
    );
    final repository = CategoryRepositoryImpl(
      local,
      utcNow: () => timestamp.add(const Duration(hours: 1)),
    );

    await repository.delete('server-id');

    expect(await repository.getAll(), isEmpty);
    expect(await repository.getPendingCount(), 1);
    final tombstone = await local.getById('server-id');
    expect(tombstone!.isDeleted, isTrue);
    expect(tombstone.pendingOperation, CategoryPendingOperation.delete);
  });
}
