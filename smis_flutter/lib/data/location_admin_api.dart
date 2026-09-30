import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

class LocationAdminItem {
  const LocationAdminItem({required this.id, required this.name});

  final String id;
  final String name;

  factory LocationAdminItem.fromJson(Map<String, dynamic> json) =>
      LocationAdminItem(
        id: (json['id'] ?? json['Id'] ?? '').toString(),
        name: (json['name'] ?? json['Name'] ?? '').toString(),
      );
}

class LocationAdminApi {
  LocationAdminApi({Dio? dio, AuthSessionStore? sessionStore})
    : _dio = dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 25),
              sendTimeout: const Duration(seconds: 25),
              headers: const {'Accept': 'application/json'},
            ),
          ) {
    _dio.interceptors.add(
      BearerTokenInterceptor(sessionStore ?? SecureAuthSessionStore()),
    );
  }

  final Dio _dio;

  Future<List<LocationAdminItem>> provinces() =>
      _getAll(AppConfig.provinceEndpoint);

  Future<List<LocationAdminItem>> districts() =>
      _getAll(AppConfig.districtEndpoint);

  Future<void> createProvince(String name) =>
      _create(AppConfig.provinceEndpoint, name);

  Future<void> createDistrict(String name) =>
      _create(AppConfig.districtEndpoint, name);

  Future<void> updateProvince(String id, String name) =>
      _update(AppConfig.provinceEndpoint, id, name);

  Future<void> updateDistrict(String id, String name) =>
      _update(AppConfig.districtEndpoint, id, name);

  Future<void> deleteProvince(String id) =>
      _delete(AppConfig.provinceEndpoint, id);

  Future<void> deleteDistrict(String id) =>
      _delete(AppConfig.districtEndpoint, id);

  Future<List<LocationAdminItem>> _getAll(String endpoint) =>
      _request(() async {
        final rows = <LocationAdminItem>[];
        const pageSize = 100;

        for (var page = 1; ; page++) {
          Response<Map<String, dynamic>> response;
          try {
            response = await _dio.get<Map<String, dynamic>>(
              endpoint,
              queryParameters: {'pageNumber': page, 'pageSize': pageSize},
            );
          } on DioException catch (error) {
            final body = error.response?.data;
            if (error.response?.statusCode == 400 &&
                body is List &&
                body.any(
                  (item) =>
                      item is Map &&
                      (item['code'] ?? item['Code']) == 'EmptyList',
                )) {
              break;
            }
            rethrow;
          }

          final data = response.data ?? const <String, dynamic>{};
          final rawItems = data['items'] ?? data['Items'] ?? const <dynamic>[];
          final items = (rawItems as List)
              .whereType<Map>()
              .map(
                (item) => LocationAdminItem.fromJson(
                  Map<String, dynamic>.from(item),
                ),
              )
              .toList(growable: false);

          rows.addAll(items);
          if (items.length < pageSize) break;
        }

        rows.sort(
          (a, b) => a.name.toLowerCase().compareTo(b.name.toLowerCase()),
        );
        return rows;
      });

  Future<void> _create(String endpoint, String name) => _request(() async {
    await _dio.post<Object?>(endpoint, data: {'name': name});
  });

  Future<void> _update(String endpoint, String id, String name) =>
      _request(() async {
        await _dio.put<Object?>('$endpoint/$id', data: {'name': name});
      });

  Future<void> _delete(String endpoint, String id) => _request(() async {
    await _dio.delete<Object?>('$endpoint/$id');
  });

  Future<T> _request<T>(Future<T> Function() action) async {
    try {
      return await action();
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }
}
