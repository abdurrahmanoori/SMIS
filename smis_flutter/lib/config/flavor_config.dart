enum Flavor {
  development,
  production,
}

class FlavorConfig {
  final Flavor flavor;
  final String apiBaseUrl;
  final String appTitle;
  final String databaseName;

  static FlavorConfig? _instance;

  FlavorConfig._internal(this.flavor, this.apiBaseUrl, this.appTitle, this.databaseName);

  static void initialize({
    required Flavor flavor,
    required String apiBaseUrl,
    required String appTitle,
    required String databaseName,
  }) {
    _instance = FlavorConfig._internal(flavor, apiBaseUrl, appTitle, databaseName);
  }

  static FlavorConfig get instance {
    if (_instance == null) {
      throw Exception("FlavorConfig must be initialized before use.");
    }
    return _instance!;
  }

  static bool get isDevelopment => instance.flavor == Flavor.development;
  static bool get isProduction => instance.flavor == Flavor.production;
}
