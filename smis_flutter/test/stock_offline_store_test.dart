import 'dart:io';

import 'package:flutter_test/flutter_test.dart';
import 'package:powersync/powersync.dart';
import 'package:smis_flutter/data/data_exception.dart';
import 'package:smis_flutter/data/powersync/app_powersync_schema.dart';
import 'package:smis_flutter/data/stock_api.dart';
import 'package:smis_flutter/data/stock_offline_store.dart';

class _StockApiStub extends StockApi {
  bool online = false;
  final sent = <StockJson>[];

  @override
  Future<void> sendQueued(String kind, StockJson payload) async {
    if (!online) throw const RemoteTransientException('Offline');
    sent.add(Map<String, dynamic>.from(payload));
  }

  @override
  Future<List<StockJson>> batches() async => [];

  @override
  Future<List<StockJson>> report(String path, {
    Map<String, dynamic>? query,
  }) async => [];

  @override
  Future<StockJson> valuation() async => {};

  @override
  Future<List<StockJson>> reconciliation({bool onlyMismatches = true}) async => [];
}

void main() {
  TestWidgetsFlutterBinding.ensureInitialized();
  test('stock command persists across restart and keeps its replay key', () async {
    final directory = await Directory.systemTemp.createTemp('smis-stock-test-');
    final path = '${directory.path}/stock.db';
    PowerSyncDatabase? database;
    try {
      database = PowerSyncDatabase(schema: appPowerSyncSchema, path: path);
      await database.initialize();
      final api = _StockApiStub();
      var store = StockOfflineStore(() async => database!, api);
      final id = await store.enqueue('receipt', {
        'productId': 'product-1',
        'receivedProductUnitId': 'unit-1',
        'receivedQuantity': 2,
        'unitCostBase': 100,
      });

      await expectLater(store.syncNow(), throwsA(isA<RemoteTransientException>()));
      expect((await store.pending()).single.payload['idempotencyKey'], id);
      await database!.close();

      database = PowerSyncDatabase(schema: appPowerSyncSchema, path: path);
      await database.initialize();
      store = StockOfflineStore(() async => database!, api);
      expect((await store.pending()).single.id, id);

      api.online = true;
      await store.syncNow();
      expect(api.sent.single['idempotencyKey'], id);
      expect(await store.pending(), isEmpty);
      expect(await store.cachedList('batches'), isEmpty);
    } finally {
      await database?.close();
      await directory.delete(recursive: true);
    }
  });
}
