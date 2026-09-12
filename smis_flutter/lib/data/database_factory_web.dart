import 'package:sqflite/sqflite.dart';
import 'package:sqflite_common_ffi_web/sqflite_ffi_web.dart';
import 'database_factory_init.dart';

Future<DbPlatformConfig> initDatabasePlatform(String databaseName) async {
  return DbPlatformConfig(factory: databaseFactoryFfiWeb);
}
