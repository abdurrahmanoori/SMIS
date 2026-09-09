import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';
import '../controllers/theme_controller.dart';
import '../l10n/app_localizations.dart';

class ThemeModeAction extends ConsumerWidget {
  const ThemeModeAction({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final themeMode = ref.watch(themeControllerProvider);
    final l10n = context.l10n;
    
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
      tooltip: l10n.text('Appearance'),
      initialValue: themeMode,
      onSelected: (mode) => ref.read(themeControllerProvider.notifier).setThemeMode(mode),
      itemBuilder: (context) => [
        PopupMenuItem(
          value: ThemeMode.system,
          child: Row(
            children: [
              const Icon(Icons.settings_brightness_outlined),
              const SizedBox(width: 12),
              Text(l10n.text('System default')),
            ],
          ),
        ),
        PopupMenuItem(
          value: ThemeMode.light,
          child: Row(
            children: [
              const Icon(Icons.light_mode_outlined),
              const SizedBox(width: 12),
              Text(l10n.text('Light mode')),
            ],
          ),
        ),
        PopupMenuItem(
          value: ThemeMode.dark,
          child: Row(
            children: [
              const Icon(Icons.dark_mode_outlined),
              const SizedBox(width: 12),
              Text(l10n.text('Dark mode')),
            ],
          ),
        ),
      ],
    );
  }
}
