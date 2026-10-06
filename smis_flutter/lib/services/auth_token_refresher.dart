import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../data/auth_session_invalidation.dart';
import '../models/auth_session.dart';
import 'auth_session_store.dart';

/// Serializes refresh-token rotation across all API clients in this isolate.
class AuthTokenRefresher {
  AuthTokenRefresher._();

  static Future<AuthSession>? _pending;

  static Future<AuthSession> refresh(
    AuthSessionStore store, {
    required String failedToken,
    required String userId,
    Dio? dio,
  }) async {
    final pending = _pending;
    if (pending != null) {
      await pending;
      final latest = await store.read();
      if (latest == null || latest.userId != userId) {
        throw StateError('The signed-in session changed.');
      }
      if (latest.token != failedToken) return latest;
    }

    final current = await store.read();
    if (current == null ||
        current.userId != userId ||
        current.refreshToken.isEmpty) {
      throw StateError('No refresh token is available for this session.');
    }
    if (current.token != failedToken) return current;
    // Another caller can enter while the secure-storage read is in flight.
    if (_pending != null) {
      return refresh(store, failedToken: failedToken, userId: userId, dio: dio);
    }

    final future = _exchange(store, current, dio);
    _pending = future;
    try {
      return await future;
    } finally {
      if (identical(_pending, future)) _pending = null;
    }
  }

  static Future<AuthSession> _exchange(
    AuthSessionStore store,
    AuthSession current,
    Dio? dio,
  ) async {
    // The refresh endpoint is anonymous and must never run through the bearer
    // interceptor, or its own 401 response could start another refresh.
    final client =
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
    try {
      final response = await client.post<Map<String, dynamic>>(
        AppConfig.refreshTokenEndpoint,
        data: {'refreshToken': current.refreshToken, 'shopId': current.shopId},
      );
      final data = response.data;
      if (data == null) throw const FormatException('Empty refresh response.');
      final exchanged = AuthSession.fromJson(data);
      if (exchanged.refreshToken.isEmpty) {
        throw const FormatException('Missing rotated refresh token.');
      }

      final latest = await store.read();
      if (latest == null || latest.userId != current.userId) {
        throw StateError('The signed-in session changed during refresh.');
      }
      if (latest.refreshToken != current.refreshToken) return latest;

      final refreshed = exchanged.copyWith(
        permissions: latest.permissions,
        taskPermissions: latest.taskPermissions,
        taskPermissionsLoaded: latest.taskPermissionsLoaded,
      );
      await store.save(refreshed);
      return refreshed;
    } on DioException catch (error) {
      if (error.response?.statusCode == 401) {
        final latest = await store.read();
        if (latest != null &&
            latest.userId == current.userId &&
            latest.refreshToken == current.refreshToken) {
          AuthSessionInvalidation.notify(
            'Your session has expired. Please sign in again.',
          );
        }
      }
      rethrow;
    }
  }
}
