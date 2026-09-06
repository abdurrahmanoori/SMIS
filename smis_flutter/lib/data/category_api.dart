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

class DioCategoryApi implements CategoryApi {
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
      _mapAndThrow(error, stackTrace);
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
      _mapAndThrow(error, stackTrace);
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
      _mapAndThrow(error, stackTrace);
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
      _mapAndThrow(error, stackTrace);
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
      _mapAndThrow(error, stackTrace);
    }
  }

  Never _mapAndThrow(Object error, StackTrace stackTrace) {
    if (error is! DioException) {
      Error.throwWithStackTrace(
        RemoteTransientException(
          'The server request failed unexpectedly.',
          cause: error,
        ),
        stackTrace,
      );
    }

    final status = error.response?.statusCode;
    final message =
        _messageFrom(error.response?.data) ??
        error.message ??
        'The server request failed.';
    final isTransient =
        status == null ||
        status == 408 ||
        status == 429 ||
        status >= 500 ||
        error.type == DioExceptionType.connectionError ||
        error.type == DioExceptionType.connectionTimeout ||
        error.type == DioExceptionType.receiveTimeout ||
        error.type == DioExceptionType.sendTimeout;
    final mapped = isTransient
        ? RemoteTransientException(message, cause: error)
        : RemotePermanentException(message, cause: error);
    Error.throwWithStackTrace(mapped, stackTrace);
  }

  String? _messageFrom(Object? data) {
    if (data is String && data.trim().isNotEmpty) return data;
    if (data is Map<String, dynamic>) {
      final message = data['message'] ?? data['title'];
      if (message is String) return message;
    }
    if (data is List && data.isNotEmpty) {
      final first = data.first;
      if (first is Map<String, dynamic>) {
        final message = first['message'] ?? first['description'];
        if (message is String) return message;
      }
    }
    return null;
  }
}
