import 'dart:io';
import 'package:flutter/foundation.dart';
import 'package:path/path.dart' as p;
import 'package:sqflite_common_ffi/sqflite_ffi.dart';
import 'database_factory_init.dart';

Future<DbPlatformConfig> initDatabasePlatform(String databaseName) async {
  if (Platform.isWindows || Platform.isLinux) {
    sqfliteFfiInit();

    String? customPath;
    if (Platform.isWindows) {
      final projectDir = Directory.current.path;
      final databaseFolder = Directory(p.join(projectDir, 'database'));

      if (!await databaseFolder.exists()) {
        await databaseFolder.create(recursive: true);
      }

      customPath = p.join(databaseFolder.path, databaseName);
      debugPrint('PROJECT_DATABASE_PATH: $customPath');
    }

    return DbPlatformConfig(factory: databaseFactoryFfi, path: customPath);
  }

  // Android and iOS
  return DbPlatformConfig(factory: databaseFactory);
}
