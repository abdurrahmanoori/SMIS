import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/product_unit_local_record.dart';
import '../models/product_unit_remote_model.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

abstract interface class ProductUnitApi {
  Future<List<ProductUnitRemoteModel>> pull(DateTime changedSince);
  Future<ProductUnitRemoteModel?> getById(String id);
  Future<ProductUnitRemoteModel> create(ProductUnitLocalRecord record);
  Future<ProductUnitRemoteModel> update(ProductUnitLocalRecord record);
  Future<ProductUnitRemoteModel?> delete(ProductUnitLocalRecord record);
}

class DioProductUnitApi implements ProductUnitApi {
  DioProductUnitApi({Dio? dio, AuthSessionStore? sessionStore})
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

  @override
  Future<List<ProductUnitRemoteModel>> pull(DateTime changedSince) async {
    try {
      final response = await _dio.get<List<dynamic>>(
        '${AppConfig.productUnitEndpoint}/pull',
        queryParameters: {
          'changedSince': changedSince.toUtc().toIso8601String(),
        },
      );
      return (response.data ?? const <dynamic>[])
          .map(
            (item) => ProductUnitRemoteModel.fromJson(
              Map<String, dynamic>.from(item as Map),
            ),
          )
          .toList(growable: false);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ProductUnitRemoteModel?> getById(String id) async {
    try {
      final response = await _dio.get<Map<String, dynamic>>(
        '${AppConfig.productUnitEndpoint}/$id',
      );
      return ProductUnitRemoteModel.fromJson(response.data!);
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return null;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ProductUnitRemoteModel> create(ProductUnitLocalRecord record) async {
    try {
      final response = await _dio.post<Map<String, dynamic>>(
        '${AppConfig.productUnitEndpoint}/sync',
        data: ProductUnitRemoteModel.createPayload(record),
      );
      return ProductUnitRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ProductUnitRemoteModel> update(ProductUnitLocalRecord record) async {
    try {
      final response = await _dio.put<Map<String, dynamic>>(
        '${AppConfig.productUnitEndpoint}/${record.id}/sync',
        data: ProductUnitRemoteModel.updatePayload(record),
      );
      return ProductUnitRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ProductUnitRemoteModel?> delete(ProductUnitLocalRecord record) async {
    try {
      final response = await _dio.delete<Map<String, dynamic>>(
        '${AppConfig.productUnitEndpoint}/${record.id}/sync',
        data: ProductUnitRemoteModel.deletePayload(record),
      );
      return ProductUnitRemoteModel.fromJson(response.data!);
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return null;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }
}
