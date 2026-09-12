import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/category_local_record.dart';
import '../models/category_remote_model.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

abstract interface class CategoryApi {
  Future<List<CategoryRemoteModel>> pull(DateTime changedSince);

  Future<CategoryRemoteModel?> getById(String id);

  Future<CategoryRemoteModel> create(CategoryLocalRecord category);

  Future<CategoryRemoteModel> update(CategoryLocalRecord category);

  Future<void> delete(CategoryLocalRecord category);
}

class CategoryPage {
  const CategoryPage({
    required this.items,
    required this.pageNumber,
    required this.pageSize,
    required this.totalCount,
    required this.totalPages,
  });

  final List<CategoryRemoteModel> items;
  final int pageNumber;
  final int pageSize;
  final int totalCount;
  final int totalPages;

  factory CategoryPage.fromJson(Map<String, dynamic> json) => CategoryPage(
    items: (json['items'] as List<dynamic>? ?? const <dynamic>[])
        .map(
          (item) => CategoryRemoteModel.fromJson(
            Map<String, dynamic>.from(item as Map),
          ),
        )
        .toList(growable: false),
    pageNumber: (json['pageNumber'] as num?)?.toInt() ?? 1,
    pageSize: (json['pageSize'] as num?)?.toInt() ?? 25,
    totalCount: (json['totalCount'] as num?)?.toInt() ?? 0,
    totalPages: (json['totalPages'] as num?)?.toInt() ?? 0,
  );
}

abstract interface class CategoryQueryApi {
  Future<CategoryPage> getPage({
    required String shopId,
    required int pageNumber,
    required int pageSize,
  });
}

class DioCategoryApi implements CategoryApi, CategoryQueryApi {
  DioCategoryApi({Dio? dio, AuthSessionStore? sessionStore})
    : _sessionStore = sessionStore ?? SecureAuthSessionStore(),
      _dio =
          dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 20),
              sendTimeout: const Duration(seconds: 20),
              headers: {
                'Accept': 'application/json',
              },
            ),
          ) {
    _dio.interceptors.add(BearerTokenInterceptor(_sessionStore));
  }

  final Dio _dio;
  final AuthSessionStore _sessionStore;

  @override
  Future<CategoryPage> getPage({
    required String shopId,
    required int pageNumber,
    required int pageSize,
  }) async {
    try {
      final response = await _dio.get<Map<String, dynamic>>(
        '${AppConfig.categoryEndpoint}/query',
        queryParameters: {
          'shopId': shopId,
          'pageNumber': pageNumber,
          'pageSize': pageSize,
        },
      );
      return CategoryPage.fromJson(response.data ?? const <String, dynamic>{});
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<List<CategoryRemoteModel>> pull(DateTime changedSince) async {
    try {
      final response = await _dio.get<List<dynamic>>(
        '${AppConfig.categoryEndpoint}/pull',
        queryParameters: {
          'changedSince': changedSince.toUtc().toIso8601String(),
        },
      );
      return (response.data ?? const <dynamic>[])
          .map(
            (item) => CategoryRemoteModel.fromJson(
              Map<String, dynamic>.from(item as Map),
            ),
          )
          .toList(growable: false);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<CategoryRemoteModel?> getById(String id) async {
    try {
      final response = await _dio.get<Map<String, dynamic>>(
        '${AppConfig.categoryEndpoint}/$id',
      );
      return CategoryRemoteModel.fromJson(response.data!);
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return null;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<CategoryRemoteModel> create(CategoryLocalRecord category) async {
    try {
      final response = await _dio.post<Map<String, dynamic>>(
        '${AppConfig.categoryEndpoint}/sync',
        data: CategoryRemoteModel.createPayload(category),
      );
      return CategoryRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<CategoryRemoteModel> update(CategoryLocalRecord category) async {
    try {
      final response = await _dio.put<Map<String, dynamic>>(
        '${AppConfig.categoryEndpoint}/${category.id}/sync',
        data: CategoryRemoteModel.updatePayload(category),
      );
      return CategoryRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<void> delete(CategoryLocalRecord category) async {
    try {
      await _dio.delete<void>(
        '${AppConfig.categoryEndpoint}/${category.id}/sync',
        data: CategoryRemoteModel.deletePayload(category),
      );
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }
}
