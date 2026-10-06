import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/auth_session.dart';
import '../models/component_permission.dart';
import '../services/auth_session_store.dart';
import '../services/auth_token_refresher.dart';
import 'data_exception.dart';

abstract interface class AuthApi {
  Future<AuthSession> login({required String email, required String password});

  Future<AuthSession> switchShop(String shopId);

  Future<AuthSession> refreshSession();

  Future<void> revokeRefreshToken();
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
      if (session.refreshToken.isEmpty) {
        throw const AuthenticationException(
          'The login response did not include a refresh token.',
        );
      }
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
      Response<Map<String, dynamic>> response;
      var active = current;
      try {
        response = await _switchShopRequest(shopId, active.token);
      } on DioException catch (error) {
        if (error.response?.statusCode != 401) rethrow;
        active = await AuthTokenRefresher.refresh(
          _sessionStore,
          failedToken: active.token,
          userId: active.userId,
        );
        response = await _switchShopRequest(shopId, active.token);
      }
      final data = response.data;
      if (data == null) {
        throw const AuthenticationException(
          'The shop switch response was empty.',
        );
      }
      return _withPermissions(
        AuthSession.fromJson(data).copyWith(refreshToken: active.refreshToken),
      );
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
      final refreshed = await AuthTokenRefresher.refresh(
        _sessionStore,
        failedToken: current.token,
        userId: current.userId,
      );
      final withPermissions = await _withPermissions(refreshed);
      final latest = await _sessionStore.read();
      if (latest == null || latest.userId != refreshed.userId) {
        throw const AuthenticationException('The signed-in session changed.');
      }
      return latest.copyWith(
        permissions: withPermissions.permissions,
        taskPermissions: withPermissions.taskPermissions,
        taskPermissionsLoaded: true,
      );
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to refresh the signed-in session.',
      );
    }
  }

  Future<Response<Map<String, dynamic>>> _switchShopRequest(
    String shopId,
    String token,
  ) => _dio.post<Map<String, dynamic>>(
    AppConfig.switchShopEndpoint,
    data: {'shopId': shopId},
    options: Options(headers: {'Authorization': 'Bearer $token'}),
  );

  @override
  Future<void> revokeRefreshToken() async {
    final current = await _sessionStore.read();
    if (current == null || current.refreshToken.isEmpty) return;

    try {
      await _dio.post<Object?>(
        AppConfig.revokeRefreshTokenEndpoint,
        data: {'refreshToken': current.refreshToken},
      );
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to revoke the signed-in session.',
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
