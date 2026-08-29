import 'dart:io';

import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';
import 'package:path/path.dart' as p;
import 'package:sqflite_common_ffi/sqflite_ffi.dart';

import 'app/app.dart';
import 'core/config/app_config.dart';
import 'core/database/app_database.dart';
import 'core/sync/background_sync.dart';
import 'features/category/presentation/providers/category_providers.dart';

Future<void> main() async {
  WidgetsFlutterBinding.ensureInitialized();

  String? customDatabasePath;

  if (!kIsWeb && (Platform.isWindows || Platform.isLinux)) {
    sqfliteFfiInit();
    databaseFactory = databaseFactoryFfi;

    if (Platform.isWindows) {
      // Set the path directly to a 'database' folder inside your project directory.
      final projectDir = Directory.current.path;
      final databaseFolder = Directory(p.join(projectDir, 'database'));

      // Ensure the directory exists
      if (!await databaseFolder.exists()) {
        await databaseFolder.create(recursive: true);
      }

      customDatabasePath = p.join(databaseFolder.path, AppConfig.databaseName);

      // ignore: avoid_print
      print('PROJECT_DATABASE_PATH: $customDatabasePath');
    }
  }

  final database = AppDatabase(databasePath: customDatabasePath);
  await database.instance;

  try {
    await BackgroundSyncScheduler.initialize();
  } catch (error, stackTrace) {
    FlutterError.reportError(
      FlutterErrorDetails(
        exception: error,
        stack: stackTrace,
        library: 'background synchronization',
      ),
    );
  }

  runApp(
    ProviderScope(
      overrides: [appDatabaseProvider.overrideWithValue(database)],
      child: const SmisApp(),
    ),
  );
}

