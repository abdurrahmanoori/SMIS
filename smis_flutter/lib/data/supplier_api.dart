import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

class SupplierItem {
  const SupplierItem({
    required this.id,
    required this.shopId,
    required this.name,
    required this.isActive,
    this.phoneNumber,
    this.notes,
  });

  final String id;
  final String shopId;
  final String name;
  final String? phoneNumber;
  final String? notes;
  final bool isActive;

  factory SupplierItem.fromJson(Map<String, dynamic> json) => SupplierItem(
    id: (json['id'] ?? json['Id'] ?? '').toString(),
    shopId: (json['shopId'] ?? json['ShopId'] ?? '').toString(),
    name: (json['name'] ?? json['Name'] ?? '').toString(),
    phoneNumber: _nullableText(json['phoneNumber'] ?? json['PhoneNumber']),
    notes: _nullableText(json['notes'] ?? json['Notes']),
    isActive: (json['isActive'] ?? json['IsActive']) == true,
  );

  static String? _nullableText(Object? value) {
    final text = value?.toString().trim();
    return text == null || text.isEmpty ? null : text;
  }
}

class SupplierApi {
  SupplierApi({Dio? dio, AuthSessionStore? sessionStore})
    : _dio =
          dio ??
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

  Future<List<SupplierItem>> getAll() => _request(() async {
    final suppliers = <SupplierItem>[];
    const pageSize = 100;

    for (var page = 1; ; page++) {
      Response<Map<String, dynamic>> response;
      try {
        response = await _dio.get<Map<String, dynamic>>(
          AppConfig.supplierEndpoint,
          queryParameters: {'pageNumber': page, 'pageSize': pageSize},
        );
      } on DioException catch (error) {
        final body = error.response?.data;
        if (ApiErrorParser.hasErrorCode(body, 'EmptyList') ||
            ApiErrorParser.hasErrorCode(body, 'common.empty')) {
          break;
        }
        rethrow;
      }

      final data = response.data ?? const <String, dynamic>{};
      final rawItems = data['items'] ?? data['Items'] ?? const <dynamic>[];
      final items = (rawItems as List)
          .whereType<Map>()
          .map((item) => SupplierItem.fromJson(Map<String, dynamic>.from(item)))
          .toList(growable: false);

      suppliers.addAll(items);
      if (items.length < pageSize) break;
    }

    suppliers.sort(
      (a, b) => a.name.toLowerCase().compareTo(b.name.toLowerCase()),
    );
    return suppliers;
  });

  Future<void> create({
    required String name,
    String? phoneNumber,
    String? notes,
  }) => _request(() async {
    await _dio.post<Object?>(
      AppConfig.supplierEndpoint,
      data: {
        'name': name,
        'phoneNumber': _nullableText(phoneNumber),
        'notes': _nullableText(notes),
      },
    );
  });

  Future<void> update(
    String id, {
    required String name,
    String? phoneNumber,
    String? notes,
  }) => _request(() async {
    await _dio.put<Object?>(
      '${AppConfig.supplierEndpoint}/$id',
      data: {
        'name': name,
        'phoneNumber': _nullableText(phoneNumber),
        'notes': _nullableText(notes),
      },
    );
  });

  Future<void> updateStatus(String id, {required bool isActive}) =>
      _request(() async {
        await _dio.patch<Object?>(
          '${AppConfig.supplierEndpoint}/$id/status',
          data: {'isActive': isActive},
        );
      });

  Future<T> _request<T>(Future<T> Function() action) async {
    try {
      return await action();
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  static String? _nullableText(String? value) {
    final text = value?.trim();
    return text == null || text.isEmpty ? null : text;
  }
}
