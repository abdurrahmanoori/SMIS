import 'package:sqflite/sqflite.dart';

/// Configuration returned by platform-specific initialization.
class DbPlatformConfig {
  final DatabaseFactory factory;
  final String? path;

  DbPlatformConfig({required this.factory, this.path});
}

/// Stub for platform-specific database factory initialization.
Future<DbPlatformConfig> initDatabasePlatform(String databaseName) {
  throw UnsupportedError('Cannot initialize database without a platform implementation.');
}
