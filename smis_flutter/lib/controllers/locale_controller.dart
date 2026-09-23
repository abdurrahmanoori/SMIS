import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';

class LocaleController extends Notifier<Locale> {
  static const _localeKey = 'smis.locale';
  static const _supportedLanguageCodes = {'en', 'fa', 'ps'};
  final _storage = const FlutterSecureStorage();
  bool _changedByUser = false;

  @override
  Locale build() {
    _loadLocale();
    final systemLanguageCode =
        WidgetsBinding.instance.platformDispatcher.locale.languageCode;
    return Locale(
      _supportedLanguageCodes.contains(systemLanguageCode)
          ? systemLanguageCode
          : 'en',
    );
  }

  Future<void> _loadLocale() async {
    final languageCode = await _storage.read(key: _localeKey);
    if (_changedByUser ||
        languageCode == null ||
        !_supportedLanguageCodes.contains(languageCode)) {
      return;
    }
    state = Locale(languageCode);
  }

  Future<void> setLocale(Locale locale) async {
    if (!_supportedLanguageCodes.contains(locale.languageCode)) return;
    _changedByUser = true;
    state = Locale(locale.languageCode);
    await _storage.write(key: _localeKey, value: locale.languageCode);
  }
}

final localeControllerProvider = NotifierProvider<LocaleController, Locale>(
  LocaleController.new,
);
