import 'package:dio/dio.dart';

import '../config/app_config.dart';
import 'auth_session_store.dart';
import 'auth_token_refresher.dart';

class BearerTokenInterceptor extends Interceptor {
  BearerTokenInterceptor(this._sessionStore, {this.fallbackToken = ''});

  final AuthSessionStore _sessionStore;
  final String fallbackToken;

  @override
  Future<void> onRequest(
    RequestOptions options,
    RequestInterceptorHandler handler,
  ) async {
    final session = await _sessionStore.read();
    if (session != null) options.extra['smisAuthUserId'] = session.userId;
    final token =
        session?.token ??
        (fallbackToken.isNotEmpty ? fallbackToken : AppConfig.authToken);
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
    if (session == null ||
        session.userId != request.extra['smisAuthUserId'] ||
        session.refreshToken.isEmpty) {
      handler.next(err);
      return;
    }

    final failedToken = _bearerToken(request);
    if (failedToken == null) {
      handler.next(err);
      return;
    }
    try {
      final refreshed = await AuthTokenRefresher.refresh(
        _sessionStore,
        failedToken: failedToken,
        userId: session.userId,
      );
      request.headers['Authorization'] = 'Bearer ${refreshed.token}';
      request.extra['smisAuthRetried'] = true;

      final retryResponse = await Dio().fetch<dynamic>(request);
      handler.resolve(retryResponse);
    } on DioException catch (refreshError) {
      handler.next(refreshError);
    } catch (refreshError) {
      handler.reject(
        DioException(
          requestOptions: request,
          error: refreshError,
          type: DioExceptionType.unknown,
        ),
      );
    }
  }

  String? _bearerToken(RequestOptions request) {
    for (final entry in request.headers.entries) {
      if (entry.key.toLowerCase() != 'authorization') continue;
      final value = entry.value.toString();
      if (value.toLowerCase().startsWith('bearer ')) return value.substring(7);
    }
    return null;
  }
}
