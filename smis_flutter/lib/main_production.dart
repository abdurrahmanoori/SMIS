import 'config/flavor_config.dart';
import 'main.dart' as app;

void main() {
  FlavorConfig.initialize(
    flavor: Flavor.production,
    apiBaseUrl: 'http://api-smis.runasp.net',
    appTitle: 'SMIS',
  );
  
  app.mainEntryPoint();
}
