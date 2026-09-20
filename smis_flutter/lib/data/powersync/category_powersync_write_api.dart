import 'package:dio/dio.dart';

import '../../config/app_config.dart';
import '../../services/auth_session_store.dart';
import '../../services/bearer_token_interceptor.dart';
import '../data_exception.dart';

/// Uses the normal Category business API for PowerSync uploads.
///
/// There are deliberately no `/sync` endpoints here. The same ASP.NET API is
/// used by an online client and by a delayed offline write.
class CategoryPowerSyncWriteApi {
  CategoryPowerSyncWriteApi({Dio? dio, AuthSessionStore? sessionStore})
    : _sessionStore = sessionStore ?? SecureAuthSessionStore(),
      _dio =
          dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 20),
              sendTimeout: const Duration(seconds: 20),
              headers: const {'Accept': 'application/json'},
            ),
          ) {
    _dio.interceptors.add(BearerTokenInterceptor(_sessionStore));
  }

  final Dio _dio;
  final AuthSessionStore _sessionStore;

  Future<void> create(String id, Map<String, dynamic> row) async {
    try {
      await _dio.post<void>(
        AppConfig.categoryEndpoint,
        data: {'id': id, ..._businessPayload(row)},
      );
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Could not upload the new category.',
      );
    }
  }

  Future<void> update(String id, Map<String, dynamic> row) async {
    try {
      await _dio.put<void>(
        '${AppConfig.categoryEndpoint}/$id',
        data: _businessPayload(row),
      );
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Could not upload the category update.',
      );
    }
  }

  Future<void> delete(String id) async {
    try {
      await _dio.delete<void>('${AppConfig.categoryEndpoint}/$id');
    } on DioException catch (error, stackTrace) {
      // Replaying an already-applied delete is safe.
      if (error.response?.statusCode == 404) return;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  Map<String, Object?> _businessPayload(Map<String, dynamic> row) => {
    'name': row['name'] as String,
    'code': row['code'] as String?,
    'description': row['description'] as String?,
    'isActive': _asBool(row['is_active']),
  };

  bool _asBool(Object? value) => value == true || value == 1;
}
