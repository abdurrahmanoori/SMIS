import 'package:connectivity_plus/connectivity_plus.dart';

abstract interface class NetworkConnectivity {
  Future<bool> get hasConnection;
}

class ConnectivityService implements NetworkConnectivity {
  ConnectivityService([Connectivity? connectivity])
    : _connectivity = connectivity ?? Connectivity();

  final Connectivity _connectivity;

  @override
  Future<bool> get hasConnection async {
    final results = await _connectivity.checkConnectivity();
    return results.any((result) => result != ConnectivityResult.none);
  }
}
