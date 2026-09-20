import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/database.dart';
import '../data/powersync/app_powersync_database.dart';
import '../services/app_powersync_sync_services.dart';
import '../services/auth_session_store.dart';
import '../services/connectivity_service.dart';

final appDatabaseProvider = Provider<AppDatabase>(
  (ref) => throw StateError('AppDatabase must be initialized in main.dart.'),
);

final connectivityProvider = Provider<NetworkConnectivity>(
  (ref) => ConnectivityService(),
);

final appPowerSyncDatabaseProvider = Provider<AppPowerSyncDatabase>((ref) {
  final database = AppPowerSyncDatabase(SecureAuthSessionStore());
  ref.onDispose(database.close);
  return database;
});

final appPowerSyncStatusServiceProvider = Provider<AppPowerSyncStatusService>(
  (ref) => AppPowerSyncStatusService(ref.watch(appPowerSyncDatabaseProvider)),
);
