import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/auth_session.dart';
import '../models/component_permission.dart';
import '../services/auth_session_store.dart';
import 'data_exception.dart';

abstract interface class AuthApi {
  Future<AuthSession> login({required String email, required String password});

  Future<AuthSession> switchShop(String shopId);

  Future<AuthSession> refreshSession();
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
      final session = AuthSession.fromJson(data);
      try {
        return await _withPermissions(session);
      } on DioException catch (permissionError) {
        // Preserve offline-first login only when no server response exists.
        // If the server actually rejected the permission request, let the outer
        // parser surface its exact ProblemDetails response.
        if (permissionError.response == null) return session;
        rethrow;
      }
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
      return _withPermissions(AuthSession.fromJson(data));
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to switch the active shop.',
      );
    }
  }

  @override
  Future<AuthSession> refreshSession() async {
    final current = await _sessionStore.read();
    if (current == null) {
      throw const AuthenticationException(
        'You must be signed in to refresh the session.',
      );
    }

    try {
      final response = await _dio.post<Map<String, dynamic>>(
        AppConfig.refreshSessionEndpoint,
        options: Options(headers: {'Authorization': 'Bearer ${current.token}'}),
      );
      final data = response.data;
      if (data == null) {
        throw const AuthenticationException(
          'The session refresh response was empty.',
        );
      }
      return _withPermissions(AuthSession.fromJson(data));
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to refresh the signed-in session.',
      );
    }
  }

  Future<AuthSession> _withPermissions(AuthSession session) async {
    final componentResponse = await _dio.get<List<dynamic>>(
      AppConfig.permissionsEndpoint,
      options: Options(headers: {'Authorization': 'Bearer ${session.token}'}),
    );

    final permissions = (componentResponse.data ?? const <dynamic>[])
        .whereType<Map>()
        .map(
          (item) =>
              ComponentPermission.fromJson(Map<String, dynamic>.from(item)),
        )
        .toList(growable: false);

    final taskResponse = await _dio.get<List<dynamic>>(
      AppConfig.taskPermissionsEndpoint,
      options: Options(headers: {'Authorization': 'Bearer ${session.token}'}),
    );
    final taskPermissions = (taskResponse.data ?? const <dynamic>[])
        .whereType<String>()
        .toList(growable: false);

    return session.copyWith(
      permissions: permissions,
      taskPermissions: taskPermissions,
      taskPermissionsLoaded: true,
    );
  }
}
