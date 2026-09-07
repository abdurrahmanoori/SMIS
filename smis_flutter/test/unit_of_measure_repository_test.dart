import 'package:flutter_test/flutter_test.dart';
import 'package:smis_flutter/data/unit_of_measure_repository.dart';
import 'package:smis_flutter/models/unit_of_measure.dart';
import 'package:smis_flutter/models/unit_of_measure_local_record.dart';

import 'support/test_database.dart';

void main() {
  test('offline create, update, and delete never require a remote API', () async {
    final database = await createTestDatabase();
    addTearDown(database.close);
    var now = DateTime.utc(2026, 1, 1);
    final repository = UnitOfMeasureRepository(
      database,
      utcNow: () => now,
      idGenerator: () => 'local-id',
    );

    final created = await repository.create(
      const UnitOfMeasureDraft(name: ' Kilogram ', symbol: ' kg '),
    );
    expect(created.name, 'Kilogram');
    expect(created.symbol, 'kg');
    expect(created.syncStatus, UnitOfMeasureSyncStatus.pendingCreate);
    expect(await repository.getPendingCount(), 1);

    now = now.add(const Duration(minutes: 1));
    final updated = await repository.update(
      created.id,
      const UnitOfMeasureDraft(name: 'Kilo', symbol: 'kg'),
    );
    expect(updated.name, 'Kilo');
    expect(updated.syncStatus, UnitOfMeasureSyncStatus.pendingCreate);

    await repository.delete(created.id);
    expect(await repository.getAll(), isEmpty);
    expect(await repository.getPendingCount(), 0);
  });

  test('deleting a server-backed unit retains a local tombstone', () async {
    final database = await createTestDatabase();
    addTearDown(database.close);
    final timestamp = DateTime.utc(2026, 1, 1);
    final repository = UnitOfMeasureRepository(
      database,
      utcNow: () => timestamp.add(const Duration(hours: 1)),
    );
    await repository.saveRecord(
      UnitOfMeasureLocalRecord(
        id: 'server-id',
        name: 'Piece',
        symbol: 'pcs',
        createdAt: timestamp,
        updatedAt: timestamp,
        lastModifiedUtc: timestamp,
        isDeleted: false,
        pendingOperation: UnitOfMeasurePendingOperation.none,
        syncStatus: UnitOfMeasureSyncStatus.synced,
        retryCount: 0,
      ),
    );

    await repository.delete('server-id');

    expect(await repository.getAll(), isEmpty);
    expect(await repository.getPendingCount(), 1);
    final tombstone = await repository.getRecord('server-id');
    expect(tombstone!.isDeleted, isTrue);
    expect(tombstone.pendingOperation, UnitOfMeasurePendingOperation.delete);
  });
}
