import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'config/app_config.dart';
import 'screens/authentication_gate.dart';
import 'controllers/theme_controller.dart';
import 'controllers/locale_controller.dart';
import 'l10n/app_localizations.dart';

import 'config/flavor_config.dart';

Future<void> main() async {
  FlavorConfig.initialize(
    flavor: Flavor.production,
    apiBaseUrl: 'http://api-smis.runasp.net',
    appTitle: 'SMIS',
  );

  await mainEntryPoint();
}

Future<void> mainEntryPoint() async {
  WidgetsFlutterBinding.ensureInitialized();

  runApp(const ProviderScope(child: SmisApp()));
}

class SmisApp extends ConsumerWidget {
  const SmisApp({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final themeMode = ref.watch(themeControllerProvider);
    final locale = ref.watch(localeControllerProvider);

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
      locale: locale,
      supportedLocales: AppLocalizations.supportedLocales,
      localizationsDelegates: AppLocalizations.localizationsDelegates,
      builder: (context, child) => Directionality(
        textDirection:
            locale.languageCode == 'fa' || locale.languageCode == 'ps'
            ? TextDirection.rtl
            : TextDirection.ltr,
        child: child ?? const SizedBox.shrink(),
      ),
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
      home: const AuthenticationGate(),
    );
  }
}
