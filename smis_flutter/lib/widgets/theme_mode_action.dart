import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';
import '../controllers/theme_controller.dart';

class ThemeModeAction extends ConsumerWidget {
  const ThemeModeAction({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final themeMode = ref.watch(themeControllerProvider);
    
    IconData icon;
    switch (themeMode) {
      case ThemeMode.light:
        icon = Icons.light_mode_outlined;
      case ThemeMode.dark:
        icon = Icons.dark_mode_outlined;
      case ThemeMode.system:
        icon = Icons.settings_brightness_outlined;
    }

    return PopupMenuButton<ThemeMode>(
      icon: Icon(icon),
      tooltip: 'Appearance',
      initialValue: themeMode,
      onSelected: (mode) => ref.read(themeControllerProvider.notifier).setThemeMode(mode),
      itemBuilder: (context) => [
        const PopupMenuItem(
          value: ThemeMode.system,
          child: Row(
            children: [
              Icon(Icons.settings_brightness_outlined),
              SizedBox(width: 12),
              Text('System default'),
            ],
          ),
        ),
        const PopupMenuItem(
          value: ThemeMode.light,
          child: Row(
            children: [
              Icon(Icons.light_mode_outlined),
              SizedBox(width: 12),
              Text('Light mode'),
            ],
          ),
        ),
        const PopupMenuItem(
          value: ThemeMode.dark,
          child: Row(
            children: [
              Icon(Icons.dark_mode_outlined),
              SizedBox(width: 12),
              Text('Dark mode'),
            ],
          ),
        ),
      ],
    );
  }
}
