import 'package:dio/dio.dart';

import '../../../../core/config/app_config.dart';
import '../../../../core/network/api_client.dart';
import '../models/category_local_record.dart';
import '../models/category_remote_model.dart';

/// Interface for the remote API.
/// In Flutter, we use 'abstract interface class' for pure interfaces (similar to C# interface).
abstract interface class CategoryRemoteDataSource {
  Future<List<CategoryRemoteModel>> pull(DateTime changedSince);

  Future<CategoryRemoteModel?> getById(String id);

  Future<CategoryRemoteModel> create(CategoryLocalRecord category);

  Future<CategoryRemoteModel> update(CategoryLocalRecord category);

  Future<void> delete(CategoryLocalRecord category);
}

/// Implementation using Dio (a powerful HTTP client for Dart).
class CategoryRemoteDataSourceImpl implements CategoryRemoteDataSource {
  CategoryRemoteDataSourceImpl(this._client);

  final ApiClient _client;

  @override
  Future<List<CategoryRemoteModel>> pull(DateTime changedSince) async {
    try {
      // Dio makes it easy to send GET requests with query parameters.
      final response = await _client.dio.get<List<dynamic>>(
        '${AppConfig.categoryEndpoint}/pull',
        queryParameters: {
          'changedSince': changedSince.toUtc().toIso8601String(),
        },
      );
      
      // Dart is very expressive with collections. .map().toList() is very common.
      return (response.data ?? const <dynamic>[])
          .map(
            (item) => CategoryRemoteModel.fromJson(
              Map<String, dynamic>.from(item as Map),
            ),
          )
          .toList(growable: false);
    } catch (error, stackTrace) {
      _client.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<CategoryRemoteModel?> getById(String id) async {
    try {
      final response = await _client.dio.get<Map<String, dynamic>>(
        '${AppConfig.categoryEndpoint}/$id',
      );
      return CategoryRemoteModel.fromJson(response.data!);
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return null;
      _client.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<CategoryRemoteModel> create(CategoryLocalRecord category) async {
    try {
      final response = await _client.dio.post<Map<String, dynamic>>(
        '${AppConfig.categoryEndpoint}/sync',
        data: CategoryRemoteModel.createPayload(category),
      );
      return CategoryRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      _client.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<CategoryRemoteModel> update(CategoryLocalRecord category) async {
    try {
      final response = await _client.dio.put<Map<String, dynamic>>(
        '${AppConfig.categoryEndpoint}/${category.id}/sync',
        data: CategoryRemoteModel.updatePayload(category),
      );
      return CategoryRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      _client.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<void> delete(CategoryLocalRecord category) async {
    try {
      await _client.dio.delete<void>(
        '${AppConfig.categoryEndpoint}/${category.id}/sync',
        data: CategoryRemoteModel.deletePayload(category),
      );
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return;
      _client.mapAndThrow(error, stackTrace);
    }
  }
}
