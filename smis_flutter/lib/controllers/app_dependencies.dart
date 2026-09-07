import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/database.dart';
import '../services/connectivity_service.dart';

final appDatabaseProvider = Provider<AppDatabase>(
  (ref) => throw StateError('AppDatabase must be initialized in main.dart.'),
);

final connectivityProvider = Provider<NetworkConnectivity>(
  (ref) => ConnectivityService(),
);
