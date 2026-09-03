import 'package:smis_flutter/data/database.dart';
import 'package:sqflite_common_ffi/sqflite_ffi.dart';

Future<AppDatabase> createTestDatabase() async {
  sqfliteFfiInit();
  final database = AppDatabase(
    factory: databaseFactoryFfi,
    databasePath: inMemoryDatabasePath,
  );
  await database.instance;
  return database;
}
