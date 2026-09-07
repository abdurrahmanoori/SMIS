import 'dart:io';

import 'package:flutter_test/flutter_test.dart';
import 'package:smis_flutter/data/database.dart';
import 'package:sqflite_common_ffi/sqflite_ffi.dart';

void main() {
  test('v1 database upgrades additively and keeps Category rows', () async {
    sqfliteFfiInit();
    final directory = await Directory.systemTemp.createTemp(
      'smis-category-db-',
    );
    addTearDown(() => directory.delete(recursive: true));
    final path = '${directory.path}${Platform.pathSeparator}category.db';
    final v1 = await databaseFactoryFfi.openDatabase(
      path,
      options: OpenDatabaseOptions(
        version: 1,
        onCreate: (database, version) async {
          await database.execute('''
            CREATE TABLE categories (
              id TEXT PRIMARY KEY, name TEXT NOT NULL, code TEXT,
              description TEXT, is_active INTEGER NOT NULL DEFAULT 1,
              shop_id TEXT, created_at TEXT NOT NULL, updated_at TEXT NOT NULL,
              last_modified_utc TEXT NOT NULL,
              is_deleted INTEGER NOT NULL DEFAULT 0,
              pending_operation TEXT NOT NULL DEFAULT 'none',
              sync_status TEXT NOT NULL DEFAULT 'synced',
              retry_count INTEGER NOT NULL DEFAULT 0,
              next_retry_at TEXT, last_sync_error TEXT
            )
          ''');
          await database.execute(
            'CREATE TABLE sync_metadata (key TEXT PRIMARY KEY, value TEXT NOT NULL)',
          );
        },
      ),
    );
    await v1.insert('categories', {
      'id': 'existing',
      'name': 'Existing',
      'created_at': '2026-01-01T00:00:00Z',
      'updated_at': '2026-01-01T00:00:00Z',
      'last_modified_utc': '2026-01-01T00:00:00Z',
    });
    await v1.close();

    final appDatabase = AppDatabase(
      factory: databaseFactoryFfi,
      databasePath: path,
    );
    addTearDown(appDatabase.close);
    final upgraded = await appDatabase.instance;
    final columns = await upgraded.rawQuery('PRAGMA table_info(categories)');
    final names = columns.map((column) => column['name']).toSet();

    expect(names, contains('server_created_date'));
    expect(names, contains('server_last_modified_utc'));
    expect((await upgraded.query('categories')).single['name'], 'Existing');
    final unitColumns = await upgraded.rawQuery(
      'PRAGMA table_info(unit_of_measures)',
    );
    expect(unitColumns.map((column) => column['name']), contains('symbol'));
  });
}
