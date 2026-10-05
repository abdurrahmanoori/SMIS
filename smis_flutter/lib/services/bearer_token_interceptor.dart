import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/auth_session.dart';
import 'auth_session_store.dart';

class BearerTokenInterceptor extends Interceptor {
  BearerTokenInterceptor(this._sessionStore);

  final AuthSessionStore _sessionStore;

  @override
  Future<void> onRequest(
    RequestOptions options,
    RequestInterceptorHandler handler,
  ) async {
    final session = await _sessionStore.read();
    final token = session?.token ?? AppConfig.authToken;
    if (token.isNotEmpty) {
      options.headers['Authorization'] = 'Bearer $token';
    } else {
      options.headers.remove('Authorization');
    }
    handler.next(options);
  }

  @override
  Future<void> onError(
    DioException err,
    ErrorInterceptorHandler handler,
  ) async {
    final request = err.requestOptions;
    if (err.response?.statusCode != 401 ||
        request.extra['smisAuthRetried'] == true) {
      handler.next(err);
      return;
    }

    final session = await _sessionStore.read();
    if (session == null || session.refreshToken.isEmpty) {
      handler.next(err);
      return;
    }

    try {
      // This intentionally uses a separate Dio instance so the refresh request
      // cannot recursively trigger this interceptor.
      final refreshDio = Dio(
        BaseOptions(
          baseUrl: AppConfig.apiBaseUrl,
          connectTimeout: const Duration(seconds: 10),
          receiveTimeout: const Duration(seconds: 20),
          sendTimeout: const Duration(seconds: 20),
          headers: const {'Accept': 'application/json'},
        ),
      );

      final refreshResponse = await refreshDio.post<Map<String, dynamic>>(
        AppConfig.refreshTokenEndpoint,
        data: {'refreshToken': session.refreshToken, 'shopId': session.shopId},
      );

      final data = refreshResponse.data;
      if (data == null) {
        handler.next(err);
        return;
      }

      var refreshed = AuthSession.fromJson(data);
      if (refreshed.refreshToken.isEmpty) {
        handler.next(err);
        return;
      }

      refreshed = refreshed.copyWith(
        permissions: session.permissions,
        taskPermissions: session.taskPermissions,
        taskPermissionsLoaded: session.taskPermissionsLoaded,
      );
      await _sessionStore.save(refreshed);

      request.headers['Authorization'] = 'Bearer ${refreshed.token}';
      request.extra['smisAuthRetried'] = true;

      final retryResponse = await Dio().fetch<dynamic>(request);
      handler.resolve(retryResponse);
    } catch (_) {
      handler.next(err);
    }
  }
}
