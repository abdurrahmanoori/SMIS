import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/powersync/app_powersync_database.dart';
import '../services/auth_session_store.dart';
import '../services/date_time_service.dart';

final dateTimeServiceProvider = Provider<DateTimeService>(
  (ref) => const DateTimeService(),
);

final appPowerSyncDatabaseProvider = Provider<AppPowerSyncDatabase>((ref) {
  final database = AppPowerSyncDatabase(
    SecureAuthSessionStore(),
    ref.watch(dateTimeServiceProvider),
  );
  ref.onDispose(database.close);
  return database;
});
