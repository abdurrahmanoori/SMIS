import 'package:dio/dio.dart';

import '../../../../core/config/app_config.dart';
import '../../../../core/network/api_client.dart';
import '../models/category_local_record.dart';
import '../models/category_remote_model.dart';

abstract interface class CategoryRemoteDataSource {
  Future<List<CategoryRemoteModel>> pull(DateTime changedSince);

  Future<CategoryRemoteModel?> getById(String id);

  Future<CategoryRemoteModel> create(CategoryLocalRecord category);

  Future<CategoryRemoteModel> update(CategoryLocalRecord category);

  Future<void> delete(String id);
}

class CategoryRemoteDataSourceImpl implements CategoryRemoteDataSource {
  CategoryRemoteDataSourceImpl(this._client);

  final ApiClient _client;

  @override
  Future<List<CategoryRemoteModel>> pull(DateTime changedSince) async {
    try {
      final response = await _client.dio.get<List<dynamic>>(
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
    } catch (error) {
      _client.mapAndThrow(error);
    }
  }

  @override
  Future<CategoryRemoteModel?> getById(String id) async {
    try {
      final response = await _client.dio.get<Map<String, dynamic>>(
        '${AppConfig.categoryEndpoint}/$id',
      );
      return CategoryRemoteModel.fromJson(response.data!);
    } on DioException catch (error) {
      if (error.response?.statusCode == 404) return null;
      _client.mapAndThrow(error);
    }
  }

  @override
  Future<CategoryRemoteModel> create(CategoryLocalRecord category) async {
    try {
      final response = await _client.dio.post<Map<String, dynamic>>(
        AppConfig.categoryEndpoint,
        data: CategoryRemoteModel.createPayload(category),
      );
      return CategoryRemoteModel.fromJson(response.data!);
    } catch (error) {
      _client.mapAndThrow(error);
    }
  }

  @override
  Future<CategoryRemoteModel> update(CategoryLocalRecord category) async {
    try {
      final response = await _client.dio.put<Map<String, dynamic>>(
        '${AppConfig.categoryEndpoint}/${category.id}',
        data: CategoryRemoteModel.updatePayload(category),
      );
      return CategoryRemoteModel.fromJson(response.data!);
    } catch (error) {
      _client.mapAndThrow(error);
    }
  }

  @override
  Future<void> delete(String id) async {
    try {
      await _client.dio.delete<void>('${AppConfig.categoryEndpoint}/$id');
    } on DioException catch (error) {
      if (error.response?.statusCode == 404) return;
      _client.mapAndThrow(error);
    }
  }
}
