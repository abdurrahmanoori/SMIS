import 'package:flutter/foundation.dart';
import 'config/flavor_config.dart';
import 'main.dart' as app;

Future<void> main() async {
  FlavorConfig.initialize(
    flavor: Flavor.development,
    apiBaseUrl: kIsWeb
        ? 'http://localhost:5238'
        : (defaultTargetPlatform == TargetPlatform.android
              ? 'http://10.0.2.2:5238'
              : 'http://localhost:5238'),
    appTitle: 'SMIS (Dev)',
  );

  await app.mainEntryPoint();
}
