import 'package:dio/dio.dart';

import '../config/app_config.dart';
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
}
