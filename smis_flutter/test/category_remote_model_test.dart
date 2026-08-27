import 'package:flutter_test/flutter_test.dart';
import 'package:smis_flutter/features/category/data/models/category_local_record.dart';
import 'package:smis_flutter/features/category/data/models/category_remote_model.dart';
import 'package:smis_flutter/features/category/domain/entities/category.dart';

void main() {
  test('sync payloads never send trusted server audit fields', () {
    final created = DateTime.utc(2026, 1, 1);
    final modified = created.add(const Duration(hours: 1));
    final record = CategoryLocalRecord(
      id: '6cf1e12a-5039-4917-9879-65b63c27999f',
      name: 'Food',
      isActive: true,
      createdAt: created,
      updatedAt: modified,
      lastModifiedUtc: modified,
      isDeleted: false,
      pendingOperation: CategoryPendingOperation.update,
      syncStatus: CategorySyncStatus.pendingUpdate,
      retryCount: 0,
    );

    final create = CategoryRemoteModel.createPayload(record);
    final update = CategoryRemoteModel.updatePayload(record);
    final delete = CategoryRemoteModel.deletePayload(record);

    expect(create['id'], record.id);
    expect(create['clientCreatedDate'], created.toIso8601String());
    expect(create['clientModifiedDate'], modified.toIso8601String());
    for (final payload in [create, update, delete]) {
      expect(payload, isNot(contains('createdDate')));
      expect(payload, isNot(contains('updatedDate')));
      expect(payload, isNot(contains('createdBy')));
      expect(payload, isNot(contains('updatedBy')));
      expect(payload, isNot(contains('lastModifiedUtc')));
    }
  });

  test('remote response keeps trusted audit separate from conflict time', () {
    final model = CategoryRemoteModel.fromJson({
      'id': '6cf1e12a-5039-4917-9879-65b63c27999f',
      'name': 'Food',
      'shopId': 'shop-1',
      'isActive': true,
      'isDeleted': false,
      'createdDate': '2026-01-02T00:00:00Z',
      'createdBy': 'server-user',
      'updatedDate': '2026-01-03T00:00:00Z',
      'updatedBy': 'server-user',
      'clientCreatedDate': '2026-01-01T00:00:00Z',
      'clientModifiedDate': '2026-01-01T01:00:00Z',
      'conflictModifiedUtc': '2026-01-01T01:00:00Z',
      'lastModifiedUtc': '2026-01-03T00:00:01Z',
    });

    expect(model.conflictModifiedUtc, DateTime.utc(2026, 1, 1, 1));
    expect(model.lastModifiedUtc, DateTime.utc(2026, 1, 3, 0, 0, 1));
    expect(model.createdBy, 'server-user');
    expect(model.clientCreatedDate, DateTime.utc(2026, 1, 1));
  });
}
