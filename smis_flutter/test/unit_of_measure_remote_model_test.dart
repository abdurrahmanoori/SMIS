import 'package:flutter_test/flutter_test.dart';
import 'package:smis_flutter/models/unit_of_measure.dart';
import 'package:smis_flutter/models/unit_of_measure_local_record.dart';
import 'package:smis_flutter/models/unit_of_measure_remote_model.dart';

void main() {
  test('sync payloads send only the UnitOfMeasure sync contract', () {
    final created = DateTime.utc(2026, 1, 1);
    final modified = created.add(const Duration(hours: 1));
    final record = UnitOfMeasureLocalRecord(
      id: '6cf1e12a-5039-4917-9879-65b63c27999f',
      name: 'Kilogram',
      symbol: 'kg',
      createdAt: created,
      updatedAt: modified,
      lastModifiedUtc: modified,
      isDeleted: false,
      pendingOperation: UnitOfMeasurePendingOperation.update,
      syncStatus: UnitOfMeasureSyncStatus.pendingUpdate,
      retryCount: 0,
    );

    final create = UnitOfMeasureRemoteModel.createPayload(record);
    final update = UnitOfMeasureRemoteModel.updatePayload(record);
    final delete = UnitOfMeasureRemoteModel.deletePayload(record);

    expect(create['id'], record.id);
    expect(create['symbol'], 'kg');
    expect(create['clientCreatedDate'], created.toIso8601String());
    expect(update['clientModifiedDate'], modified.toIso8601String());
    for (final payload in [create, update, delete]) {
      expect(payload, isNot(contains('shopId')));
      expect(payload, isNot(contains('createdDate')));
      expect(payload, isNot(contains('updatedDate')));
      expect(payload, isNot(contains('lastModifiedUtc')));
    }
  });

  test('remote response preserves server conflict time', () {
    final model = UnitOfMeasureRemoteModel.fromJson({
      'id': '6cf1e12a-5039-4917-9879-65b63c27999f',
      'name': 'Kilogram',
      'symbol': 'kg',
      'shopId': 'shop-1',
      'isDeleted': false,
      'clientCreatedDate': '2026-01-01T00:00:00Z',
      'clientModifiedDate': '2026-01-01T01:00:00Z',
      'conflictModifiedUtc': '2026-01-01T01:00:00Z',
      'lastModifiedUtc': '2026-01-03T00:00:01Z',
    });

    expect(model.conflictModifiedUtc, DateTime.utc(2026, 1, 1, 1));
    expect(model.lastModifiedUtc, DateTime.utc(2026, 1, 3, 0, 0, 1));
    expect(model.symbol, 'kg');
  });
}
