import 'dart:io';

class AppConfig {
  const AppConfig._();

  static const _configuredBaseUrl = String.fromEnvironment('SMIS_API_BASE_URL');

  static String get apiBaseUrl {
    if (_configuredBaseUrl.isNotEmpty) return _configuredBaseUrl;
    return Platform.isAndroid
        ? 'http://10.0.2.2:5238'
        : 'http://127.0.0.1:5238';
  }

  // A development token remains available as a fallback for non-interactive
  // background tooling. Normal app requests use the securely stored login token.
  static const authToken = String.fromEnvironment('SMIS_AUTH_TOKEN');

  static const databaseName = 'smis_offline.db';
  static const loginEndpoint = '/api/Account/login';
  static const categoryEndpoint = '/api/Category';
  static const backgroundTaskIdentifier =
      'com.example.smisFlutter.categorySync';
}
