import 'package:dio/dio.dart';

import '../../config/app_config.dart';
import '../../services/auth_session_store.dart';
import '../../services/bearer_token_interceptor.dart';
import '../data_exception.dart';

class PowerSyncApiCredentials {
  const PowerSyncApiCredentials({
    required this.endpoint,
    required this.token,
    required this.expiresAtUtc,
  });

  final String endpoint;
  final String token;
  final DateTime expiresAtUtc;
}

/// Exchanges the normal SMIS bearer token for a short-lived PowerSync JWT.
/// PowerSync's SDK decides when this method needs to be called again.
class PowerSyncAuthApi {
  PowerSyncAuthApi({Dio? dio, AuthSessionStore? sessionStore})
    : _sessionStore = sessionStore ?? SecureAuthSessionStore(),
      _dio =
          dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 20),
              headers: const {'Accept': 'application/json'},
            ),
          ) {
    _dio.interceptors.add(BearerTokenInterceptor(_sessionStore));
  }

  final Dio _dio;
  final AuthSessionStore _sessionStore;

  Future<PowerSyncApiCredentials> fetchCredentials() async {
    try {
      final response = await _dio.get<Map<String, dynamic>>(
        AppConfig.powerSyncCredentialsEndpoint,
      );
      final data = response.data;
      if (data == null) {
        throw const LocalStorageException(
          'The PowerSync credentials endpoint returned an empty response.',
        );
      }

      final endpoint = data['endpoint'] as String?;
      final token = data['token'] as String?;
      final expiresAt = data['expiresAtUtc'] as String?;
      if (endpoint == null || token == null || expiresAt == null) {
        throw const LocalStorageException(
          'The PowerSync credentials response is incomplete.',
        );
      }

      return PowerSyncApiCredentials(
        endpoint: endpoint,
        token: token,
        expiresAtUtc: DateTime.parse(expiresAt).toUtc(),
      );
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Could not obtain PowerSync credentials.',
      );
    }
  }
}
