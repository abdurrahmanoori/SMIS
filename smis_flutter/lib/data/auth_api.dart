import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/auth_session.dart';
import '../services/auth_session_store.dart';
import 'data_exception.dart';

abstract interface class AuthApi {
  Future<AuthSession> login({required String email, required String password});

  Future<AuthSession> switchShop(String shopId);
}

class DioAuthApi implements AuthApi {
  DioAuthApi({Dio? dio, AuthSessionStore? sessionStore})
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
          ),
      _sessionStore = sessionStore ?? SecureAuthSessionStore();

  final Dio _dio;
  final AuthSessionStore _sessionStore;

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

  @override
  Future<AuthSession> switchShop(String shopId) async {
    final current = await _sessionStore.read();
    if (current == null) {
      throw const AuthenticationException(
        'You must be signed in to switch shops.',
      );
    }
    if (!current.isSuperAdmin) {
      throw const AuthenticationException(
        'Only a SuperAdmin can switch the active shop.',
      );
    }

    try {
      final response = await _dio.post<Map<String, dynamic>>(
        AppConfig.switchShopEndpoint,
        data: {'shopId': shopId},
        options: Options(headers: {'Authorization': 'Bearer ${current.token}'}),
      );
      final data = response.data;
      if (data == null) {
        throw const AuthenticationException(
          'The shop switch response was empty.',
        );
      }
      return AuthSession.fromJson(data);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to switch the active shop.',
      );
    }
  }
}
