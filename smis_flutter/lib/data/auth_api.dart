import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/auth_session.dart';
import 'data_exception.dart';

abstract interface class AuthApi {
  Future<AuthSession> login({required String email, required String password});
}

class DioAuthApi implements AuthApi {
  DioAuthApi({Dio? dio})
    : _dio =
          dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 20),
              sendTimeout: const Duration(seconds: 20),
              headers: const {'Accept': 'application/json'},
            ),
          );

  final Dio _dio;

  @override
  Future<AuthSession> login({
    required String email,
    required String password,
  }) async {
    try {
      final response = await _dio.post<Map<String, dynamic>>(
        AppConfig.loginEndpoint,
        data: {'email': email.trim(), 'password': password},
      );
      final data = response.data;
      if (data == null) {
        throw const AuthenticationException('The login response was empty.');
      }
      return AuthSession.fromJson(data);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to sign in. Please try again.',
      );
    }
  }
}
