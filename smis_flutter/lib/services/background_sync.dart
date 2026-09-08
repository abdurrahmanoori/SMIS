import 'dart:io';
import 'dart:ui';

import 'package:flutter/widgets.dart';
import 'package:workmanager/workmanager.dart';

import '../config/app_config.dart';
import '../data/category_api.dart';
import '../data/category_repository.dart';
import '../data/database.dart';
import '../data/unit_of_measure_api.dart';
import '../data/unit_of_measure_repository.dart';
import '../data/product_api.dart';
import '../data/product_repository.dart';
import 'category_sync_service.dart';
import 'connectivity_service.dart';
import 'unit_of_measure_sync_service.dart';
import 'product_sync_service.dart';

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
      final categorySyncService = CategorySyncService(
        CategoryRepository(database),
        DioCategoryApi(),
        ConnectivityService(),
      );
      final unitOfMeasureSyncService = UnitOfMeasureSyncService(
        UnitOfMeasureRepository(database),
        DioUnitOfMeasureApi(),
        ConnectivityService(),
      );
      final productSyncService = ProductSyncService(
        ProductRepository(database),
        DioProductApi(),
        ConnectivityService(),
      );
      final categoryResult = await categorySyncService.synchronize();
      final unitOfMeasureResult = await unitOfMeasureSyncService.synchronize();
      final productResult = await productSyncService.synchronize();
      return !categoryResult.transientFailure &&
          !unitOfMeasureResult.transientFailure &&
          !productResult.transientFailure;
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
