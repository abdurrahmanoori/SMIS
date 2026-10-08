import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

/// Command transport only. Confirmed finance rows come from PowerSync.
class SupplierFinanceApi {
  SupplierFinanceApi({Dio? dio, AuthSessionStore? sessionStore})
    : _dio = dio ?? Dio(BaseOptions(
        baseUrl: AppConfig.apiBaseUrl,
        connectTimeout: const Duration(seconds: 10),
        receiveTimeout: const Duration(seconds: 25),
        sendTimeout: const Duration(seconds: 25),
      )) {
    _dio.interceptors.add(
      BearerTokenInterceptor(sessionStore ?? SecureAuthSessionStore()),
    );
  }

  final Dio _dio;

  Future<void> sendPayment(String supplierId, Map<String, dynamic> payload) async {
    try {
      await _dio.post<Object?>(
        '${AppConfig.supplierEndpoint}/$supplierId/payments',
        data: payload,
      );
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }
}
