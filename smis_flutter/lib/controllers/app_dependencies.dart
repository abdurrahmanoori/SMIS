import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/powersync/app_powersync_database.dart';
import '../services/auth_session_store.dart';

final appPowerSyncDatabaseProvider = Provider<AppPowerSyncDatabase>((ref) {
  final database = AppPowerSyncDatabase(SecureAuthSessionStore());
  ref.onDispose(database.close);
  return database;
});
