import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/locale_controller.dart';
import '../l10n/app_localizations.dart';

class LocaleAction extends ConsumerWidget {
  const LocaleAction({super.key, this.showLabel = false});

  final bool showLabel;

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final locale = ref.watch(localeControllerProvider);
    final l10n = context.l10n;
    final currentLabel = _labelFor(l10n, locale.languageCode);

    return PopupMenuButton<Locale>(
      tooltip: l10n.text('Language'),
      initialValue: locale,
      onSelected: ref.read(localeControllerProvider.notifier).setLocale,
      itemBuilder: (context) => AppLocalizations.supportedLocales
          .map(
            (item) => PopupMenuItem<Locale>(
              value: item,
              child: Row(
                children: [
                  if (item.languageCode == locale.languageCode)
                    const Icon(Icons.check, size: 18)
                  else
                    const SizedBox(width: 18),
                  const SizedBox(width: 10),
                  Text(_labelFor(l10n, item.languageCode)),
                ],
              ),
            ),
          )
          .toList(growable: false),
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 10),
        child: Row(
          mainAxisSize: MainAxisSize.min,
          children: [
            const Icon(Icons.language_outlined),
            if (showLabel) ...[
              const SizedBox(width: 6),
              Text(currentLabel),
              const Icon(Icons.arrow_drop_down),
            ],
          ],
        ),
      ),
    );
  }

  String _labelFor(AppLocalizations l10n, String languageCode) => switch (
        languageCode
      ) {
        'fa' => l10n.text('Dari'),
        'ps' => l10n.text('Pashto'),
        _ => l10n.text('English'),
      };
}
