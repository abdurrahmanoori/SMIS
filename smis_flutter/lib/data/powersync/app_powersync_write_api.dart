import 'package:dio/dio.dart';

import '../../config/app_config.dart';
import '../../services/auth_session_store.dart';
import '../../services/bearer_token_interceptor.dart';
import '../data_exception.dart';
import 'upload/category_upload_handler.dart';
import 'upload/powersync_upload_handler.dart';
import 'upload/product_unit_upload_handler.dart';
import 'upload/product_price_upload_handler.dart';
import 'upload/product_upload_handler.dart';
import 'upload/shop_upload_handler.dart';
import 'upload/unit_of_measure_upload_handler.dart';

class AppPowerSyncWriteApi {
  AppPowerSyncWriteApi({Dio? dio, AuthSessionStore? sessionStore})
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

    final handlers = <PowerSyncUploadHandler>[
      CategoryUploadHandler(_dio),
      ShopUploadHandler(_dio),
      UnitOfMeasureUploadHandler(_dio),
      ProductUploadHandler(_dio),
      ProductUnitUploadHandler(_dio),
      ProductPriceUploadHandler(_dio),
    ];
    _handlers = {for (final handler in handlers) handler.table: handler};
  }

  final Dio _dio;
  final AuthSessionStore _sessionStore;
  late final Map<String, PowerSyncUploadHandler> _handlers;

  Future<void> create(String table, String id, Map<String, dynamic> row) async {
    try {
      await _handler(table).create(id, row);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Could not upload the new $table record.',
      );
    }
  }

  Future<void> update(String table, String id, Map<String, dynamic> row) async {
    try {
      await _handler(table).update(id, row);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Could not upload the $table update.',
      );
    }
  }

  Future<void> delete(String table, String id, String lastModifiedUtc) async {
    try {
      await _handler(table).delete(id, lastModifiedUtc);
    } on DioException catch (error, stackTrace) {
      final status = error.response?.statusCode;
      // Complete only recognized permanent rejections. Generic ASP.NET model-binding
      // 400 responses stay retryable so malformed payloads are not silently discarded.
      if (status == 404 ||
          status == 409 ||
          status == 422 ||
          (status == 400 &&
              _isBusinessValidationResponse(error.response?.data))) {
        return;
      }
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  PowerSyncUploadHandler _handler(String table) {
    final handler = _handlers[table];
    if (handler == null) {
      throw StateError('Unsupported PowerSync table: $table');
    }
    return handler;
  }

  bool _isBusinessValidationResponse(Object? data) {
    if (data is! List || data.isEmpty) return false;
    return data.every(
      (item) =>
          item is Map &&
          (item.containsKey('description') || item.containsKey('Description')),
    );
  }
}
