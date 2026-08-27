import 'package:flutter/material.dart';

import '../features/category/presentation/pages/category_list_page.dart';

class SmisApp extends StatelessWidget {
  const SmisApp({super.key});

  @override
  Widget build(BuildContext context) {
    final colorScheme = ColorScheme.fromSeed(
      seedColor: const Color(0xFF315C49),
      brightness: Brightness.light,
    );
    return MaterialApp(
      title: 'SMIS Categories',
      debugShowCheckedModeBanner: false,
      theme: ThemeData(
        colorScheme: colorScheme,
        useMaterial3: true,
        scaffoldBackgroundColor: const Color(0xFFF7F8F5),
        cardTheme: const CardThemeData(elevation: 0, margin: EdgeInsets.zero),
        inputDecorationTheme: const InputDecorationTheme(
          border: OutlineInputBorder(),
        ),
      ),
      home: const CategoryListPage(),
    );
  }
}
