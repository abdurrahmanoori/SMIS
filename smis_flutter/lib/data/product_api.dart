import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/product_local_record.dart';
import '../models/product_remote_model.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

abstract interface class ProductApi {
  Future<List<ProductRemoteModel>> pull(DateTime changedSince);
  Future<ProductRemoteModel?> getById(String id);
  Future<ProductRemoteModel> create(ProductLocalRecord product);
  Future<ProductRemoteModel> update(ProductLocalRecord product);
  Future<ProductRemoteModel?> delete(ProductLocalRecord product);
}

class DioProductApi implements ProductApi {
  DioProductApi({Dio? dio, AuthSessionStore? sessionStore})
    : _sessionStore = sessionStore ?? SecureAuthSessionStore(),
      _dio = dio ?? Dio(BaseOptions(
        baseUrl: AppConfig.apiBaseUrl,
        connectTimeout: const Duration(seconds: 10),
        receiveTimeout: const Duration(seconds: 20),
        sendTimeout: const Duration(seconds: 20),
        headers: const {'Accept': 'application/json'},
      )) {
    _dio.interceptors.add(BearerTokenInterceptor(_sessionStore));
  }

  final Dio _dio;
  final AuthSessionStore _sessionStore;

  @override
  Future<List<ProductRemoteModel>> pull(DateTime changedSince) async {
    try {
      final response = await _dio.get<List<dynamic>>(
        '${AppConfig.productEndpoint}/pull',
        queryParameters: {'changedSince': changedSince.toUtc().toIso8601String()},
      );
      return (response.data ?? const <dynamic>[])
          .map((item) => ProductRemoteModel.fromJson(Map<String, dynamic>.from(item as Map)))
          .toList(growable: false);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ProductRemoteModel?> getById(String id) async {
    try {
      final response = await _dio.get<Map<String, dynamic>>('${AppConfig.productEndpoint}/$id');
      return ProductRemoteModel.fromJson(response.data!);
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return null;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ProductRemoteModel> create(ProductLocalRecord product) async {
    try {
      final response = await _dio.post<Map<String, dynamic>>(
        '${AppConfig.productEndpoint}/sync',
        data: ProductRemoteModel.createPayload(product),
      );
      return ProductRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ProductRemoteModel> update(ProductLocalRecord product) async {
    try {
      final response = await _dio.put<Map<String, dynamic>>(
        '${AppConfig.productEndpoint}/${product.id}/sync',
        data: ProductRemoteModel.updatePayload(product),
      );
      return ProductRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ProductRemoteModel?> delete(ProductLocalRecord product) async {
    try {
      final response = await _dio.delete<Map<String, dynamic>>(
        '${AppConfig.productEndpoint}/${product.id}/sync',
        data: ProductRemoteModel.deletePayload(product),
      );
      return ProductRemoteModel.fromJson(response.data!);
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return null;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }
}
