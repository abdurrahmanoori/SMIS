import 'config/flavor_config.dart';
import 'main.dart' as app;

Future<void> main() async {
  FlavorConfig.initialize(
    flavor: Flavor.production,
    apiBaseUrl: 'http://api-smis.runasp.net',
    appTitle: 'SMIS',
  );

  await app.mainEntryPoint();
}
