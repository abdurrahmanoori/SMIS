import 'dart:io';
import 'dart:ui';

import 'package:flutter/widgets.dart';
import 'package:workmanager/workmanager.dart';

import '../../features/category/data/datasources/category_local_data_source.dart';
import '../../features/category/data/datasources/category_remote_data_source.dart';
import '../../features/category/data/sync/category_sync_service.dart';
import '../config/app_config.dart';
import '../database/app_database.dart';
import '../network/api_client.dart';
import '../network/connectivity_service.dart';

@pragma('vm:entry-point')
void callbackDispatcher() {
  Workmanager().executeTask((task, inputData) async {
    WidgetsFlutterBinding.ensureInitialized();
    DartPluginRegistrant.ensureInitialized();
    if (task != AppConfig.backgroundTaskIdentifier &&
        task != Workmanager.iOSBackgroundTask) {
      return true;
    }

    final database = AppDatabase();
    try {
      final local = CategoryLocalDataSource(database);
      final syncService = CategorySyncService(
        local,
        CategoryRemoteDataSourceImpl(ApiClient()),
        ConnectivityService(),
      );
      final result = await syncService.synchronize();
      return !result.transientFailure;
    } finally {
      await database.close();
    }
  });
}

class BackgroundSyncScheduler {
  const BackgroundSyncScheduler._();

  static Future<void> initialize() async {
    if (!Platform.isAndroid && !Platform.isIOS && !Platform.isMacOS) return;

    await Workmanager().initialize(callbackDispatcher);
    await Workmanager().registerPeriodicTask(
      AppConfig.backgroundTaskIdentifier,
      AppConfig.backgroundTaskIdentifier,
      frequency: const Duration(hours: 1),
      constraints: Constraints(networkType: NetworkType.connected),
    );
  }
}
