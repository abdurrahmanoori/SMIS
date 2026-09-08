import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/shop_local_record.dart';
import '../models/shop_remote_model.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

abstract interface class ShopApi {
  Future<List<ShopRemoteModel>> pull(DateTime changedSince);

  Future<ShopRemoteModel?> getById(String id);

  Future<ShopRemoteModel> create(ShopLocalRecord shop);

  Future<ShopRemoteModel> update(ShopLocalRecord shop);

  Future<ShopRemoteModel?> delete(ShopLocalRecord shop);
}

class DioShopApi implements ShopApi {
  DioShopApi({Dio? dio, AuthSessionStore? sessionStore})
    : _sessionStore = sessionStore ?? SecureAuthSessionStore(),
      _dio =
          dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 20),
              sendTimeout: const Duration(seconds: 20),
              headers: {'Accept': 'application/json'},
            ),
          ) {
    _dio.interceptors.add(BearerTokenInterceptor(_sessionStore));
  }

  final Dio _dio;
  final AuthSessionStore _sessionStore;

  @override
  Future<List<ShopRemoteModel>> pull(DateTime changedSince) async {
    try {
      final response = await _dio.get<List<dynamic>>(
        '${AppConfig.shopEndpoint}/pull',
        queryParameters: {
          'changedSince': changedSince.toUtc().toIso8601String(),
        },
      );
      return (response.data ?? const <dynamic>[])
          .map(
            (item) =>
                ShopRemoteModel.fromJson(Map<String, dynamic>.from(item as Map)),
          )
          .toList(growable: false);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ShopRemoteModel?> getById(String id) async {
    try {
      final response = await _dio.get<Map<String, dynamic>>(
        '${AppConfig.shopEndpoint}/$id',
      );
      return ShopRemoteModel.fromJson(response.data!);
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return null;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ShopRemoteModel> create(ShopLocalRecord shop) async {
    try {
      final response = await _dio.post<Map<String, dynamic>>(
        '${AppConfig.shopEndpoint}/sync',
        data: ShopRemoteModel.createPayload(shop),
      );
      return ShopRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ShopRemoteModel> update(ShopLocalRecord shop) async {
    try {
      final response = await _dio.put<Map<String, dynamic>>(
        '${AppConfig.shopEndpoint}/${shop.id}/sync',
        data: ShopRemoteModel.updatePayload(shop),
      );
      return ShopRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<ShopRemoteModel?> delete(ShopLocalRecord shop) async {
    try {
      final response = await _dio.delete<Map<String, dynamic>>(
        '${AppConfig.shopEndpoint}/${shop.id}/sync',
        data: ShopRemoteModel.deletePayload(shop),
      );
      final data = response.data;
      return data == null ? null : ShopRemoteModel.fromJson(data);
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return null;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }
}
