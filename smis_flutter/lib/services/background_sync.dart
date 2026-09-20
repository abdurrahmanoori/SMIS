import 'dart:ui';
import 'package:flutter/foundation.dart';
import 'package:flutter/widgets.dart';
import 'package:workmanager/workmanager.dart';

import '../config/app_config.dart';
import '../data/database.dart';
import '../data/unit_of_measure_api.dart';
import '../data/unit_of_measure_repository.dart';
import '../data/product_api.dart';
import '../data/product_repository.dart';
import '../data/product_unit_api.dart';
import '../data/product_unit_repository.dart';
import '../data/shop_api.dart';
import '../data/shop_repository.dart';
import 'auth_session_store.dart';
import 'connectivity_service.dart';
import 'unit_of_measure_sync_service.dart';
import 'product_sync_service.dart';
import 'product_unit_sync_service.dart';
import 'shop_sync_service.dart';

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
    final sessionStore = SecureAuthSessionStore();
    try {
      final session = await sessionStore.read();
      if (session == null) return true;

      final shopSyncService = ShopSyncService(
        ShopRepository(database),
        DioShopApi(sessionStore: sessionStore),
        ConnectivityService(),
      );
      final unitOfMeasureSyncService = UnitOfMeasureSyncService(
        UnitOfMeasureRepository(database),
        DioUnitOfMeasureApi(sessionStore: sessionStore),
        ConnectivityService(),
      );
      final productSyncService = ProductSyncService(
        ProductRepository(database),
        DioProductApi(sessionStore: sessionStore),
        ConnectivityService(),
      );
      final productUnitSyncService = ProductUnitSyncService(
        ProductUnitRepository(database),
        DioProductUnitApi(sessionStore: sessionStore),
        ConnectivityService(),
      );

      // Parent rows must exist before child rows now that SQLite enforces the
      // same relationships as the backend.
      final shopResult = await shopSyncService.synchronize();
      final unitOfMeasureResult = await unitOfMeasureSyncService.synchronize(
        shopId: session.shopId,
      );
      final productResult = await productSyncService.synchronize(
        shopId: session.shopId,
      );
      final productUnitResult = await productUnitSyncService.synchronize(
        shopId: session.shopId,
      );
      return !shopResult.transientFailure &&
          !unitOfMeasureResult.transientFailure &&
          !productResult.transientFailure &&
          !productUnitResult.transientFailure;
    } finally {
      await database.close();
    }
  });
}

class BackgroundSyncScheduler {
  const BackgroundSyncScheduler._();

  static Future<void> initialize() async {
    if (kIsWeb) return;

    if (defaultTargetPlatform != TargetPlatform.android &&
        defaultTargetPlatform != TargetPlatform.iOS &&
        defaultTargetPlatform != TargetPlatform.macOS) {
      return;
    }

    await Workmanager().initialize(callbackDispatcher);
    await Workmanager().registerPeriodicTask(
      AppConfig.backgroundTaskIdentifier,
      AppConfig.backgroundTaskIdentifier,
      frequency: const Duration(hours: 1),
      constraints: Constraints(networkType: NetworkType.connected),
    );
  }
}
