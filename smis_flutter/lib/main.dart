import 'dart:io';

import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';
import 'package:path/path.dart' as p;
import 'package:sqflite_common_ffi/sqflite_ffi.dart';

import 'config/app_config.dart';
import 'controllers/auth_controller.dart';
import 'controllers/category_controller.dart';
import 'data/database.dart';
import 'screens/home_screen.dart';
import 'screens/login_screen.dart';
import 'services/background_sync.dart';
import 'controllers/theme_controller.dart';

import 'config/flavor_config.dart';

Future<void> main() async {
  FlavorConfig.initialize(
    flavor: Flavor.production,
    apiBaseUrl: 'http://api-smis.runasp.net',
    appTitle: 'SMIS',
    databaseName: 'smis_prod.db',
  );
  
  await mainEntryPoint();
}

Future<void> mainEntryPoint() async {
  WidgetsFlutterBinding.ensureInitialized();

  String? customDatabasePath;

  if (!kIsWeb && (Platform.isWindows || Platform.isLinux)) {
    sqfliteFfiInit();
    databaseFactory = databaseFactoryFfi;

    if (Platform.isWindows) {
      final projectDir = Directory.current.path;
      final databaseFolder = Directory(p.join(projectDir, 'database'));

      if (!await databaseFolder.exists()) {
        await databaseFolder.create(recursive: true);
      }

      customDatabasePath = p.join(databaseFolder.path, AppConfig.databaseName);

      debugPrint('PROJECT_DATABASE_PATH: $customDatabasePath');
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

class SmisApp extends ConsumerWidget {
  const SmisApp({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final themeMode = ref.watch(themeControllerProvider);
    
    final lightColorScheme = ColorScheme.fromSeed(
      seedColor: const Color(0xFF315C49),
      brightness: Brightness.light,
    );
    
    final darkColorScheme = ColorScheme.fromSeed(
      seedColor: const Color(0xFF315C49),
      brightness: Brightness.dark,
    );

    return MaterialApp(
      title: AppConfig.appTitle,
      debugShowCheckedModeBanner: FlavorConfig.isDevelopment,
      themeMode: themeMode,
      theme: ThemeData(
        colorScheme: lightColorScheme,
        useMaterial3: true,
        scaffoldBackgroundColor: const Color(0xFFF7F8F5),
        cardTheme: const CardThemeData(elevation: 0, margin: EdgeInsets.zero),
        inputDecorationTheme: const InputDecorationTheme(
          border: OutlineInputBorder(),
        ),
      ),
      darkTheme: ThemeData(
        colorScheme: darkColorScheme,
        useMaterial3: true,
        cardTheme: const CardThemeData(elevation: 0, margin: EdgeInsets.zero),
        inputDecorationTheme: const InputDecorationTheme(
          border: OutlineInputBorder(),
        ),
      ),
      home: const _AuthenticationGate(),
    );
  }
}

class _AuthenticationGate extends ConsumerWidget {
  const _AuthenticationGate();

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final auth = ref.watch(authControllerProvider);
    if (auth.isRestoring) {
      return const Scaffold(
        body: Center(child: CircularProgressIndicator()),
      );
    }
    return auth.isAuthenticated ? const HomeScreen() : const LoginScreen();
  }
}
