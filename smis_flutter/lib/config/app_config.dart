import 'flavor_config.dart';

class AppConfig {
  const AppConfig._();

  static String get apiBaseUrl => FlavorConfig.instance.apiBaseUrl;

  static String get appTitle => FlavorConfig.instance.appTitle;

  // A development token remains available as a fallback for non-interactive
  // background tooling. Normal app requests use the securely stored login token.
  static const authToken = String.fromEnvironment('SMIS_AUTH_TOKEN');

  static String get databaseName => FlavorConfig.instance.databaseName;

  static const accountEndpoint = '/api/Account';
  static const languageEndpoint = '/api/Language';
  static const loginEndpoint = '/api/Account/login';
  static const categoryEndpoint = '/api/Category';
  static const unitOfMeasureEndpoint = '/api/UnitOfMeasure';
  static const backgroundTaskIdentifier =
      'com.example.smisFlutter.categorySync';
}
