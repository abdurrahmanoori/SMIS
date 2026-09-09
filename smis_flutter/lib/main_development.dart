import 'dart:io';
import 'package:flutter/foundation.dart';
import 'config/flavor_config.dart';
import 'main.dart' as app;

void main() {
  FlavorConfig.initialize(
    flavor: Flavor.development,
    apiBaseUrl: kIsWeb 
        ? 'http://localhost:5238' 
        : (Platform.isAndroid ? 'http://10.0.2.2:5238' : 'http://localhost:5238'),
    appTitle: 'SMIS (Dev)',
  );
  
  app.mainEntryPoint();
}
