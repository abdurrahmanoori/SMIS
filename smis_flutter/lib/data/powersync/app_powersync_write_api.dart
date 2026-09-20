import 'package:dio/dio.dart';

import '../../config/app_config.dart';
import '../../services/auth_session_store.dart';
import '../../services/bearer_token_interceptor.dart';
import '../data_exception.dart';

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
  }

  final Dio _dio;
  final AuthSessionStore _sessionStore;

  Future<void> create(String table, String id, Map<String, dynamic> row) async {
    try {
      switch (table) {
        case 'category':
          await _dio.post<void>(
            AppConfig.categoryEndpoint,
            data: {'id': id, ..._categoryPayload(row)},
          );
        case 'shop':
          await _dio.post<void>(
            '${AppConfig.shopEndpoint}/sync',
            data: {
              'id': id,
              ..._shopPayload(row),
              'clientCreatedDate': _timestamp(row),
              'clientModifiedDate': _timestamp(row),
            },
          );
        case 'unit_of_measure':
          await _dio.post<void>(
            '${AppConfig.unitOfMeasureEndpoint}/sync',
            data: {
              'id': id,
              ..._unitPayload(row),
              'clientCreatedDate': _timestamp(row),
              'clientModifiedDate': _timestamp(row),
            },
          );
        case 'product':
          await _dio.post<void>(
            '${AppConfig.productEndpoint}/sync',
            data: {
              'id': id,
              ..._productPayload(row),
              'clientCreatedDate': _timestamp(row),
              'clientModifiedDate': _timestamp(row),
            },
          );
        case 'product_unit':
          await _dio.post<void>(
            '${AppConfig.productUnitEndpoint}/sync',
            data: {
              'id': id,
              ..._productUnitPayload(row),
              'clientCreatedDate': _timestamp(row),
              'clientModifiedDate': _timestamp(row),
            },
          );
        default:
          throw StateError('Unsupported PowerSync table: $table');
      }
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
      switch (table) {
        case 'category':
          await _dio.put<void>(
            '${AppConfig.categoryEndpoint}/$id',
            data: _categoryPayload(row),
          );
        case 'shop':
          await _dio.put<void>(
            '${AppConfig.shopEndpoint}/$id/sync',
            data: {..._shopPayload(row), 'clientModifiedDate': _timestamp(row)},
          );
        case 'unit_of_measure':
          await _dio.put<void>(
            '${AppConfig.unitOfMeasureEndpoint}/$id/sync',
            data: {..._unitPayload(row), 'clientModifiedDate': _timestamp(row)},
          );
        case 'product':
          await _dio.put<void>(
            '${AppConfig.productEndpoint}/$id/sync',
            data: {
              ..._productPayload(row),
              'clientModifiedDate': _timestamp(row),
            },
          );
        case 'product_unit':
          await _dio.put<void>(
            '${AppConfig.productUnitEndpoint}/$id/sync',
            data: {
              ..._productUnitPayload(row),
              'clientModifiedDate': _timestamp(row),
            },
          );
        default:
          throw StateError('Unsupported PowerSync table: $table');
      }
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
      switch (table) {
        case 'category':
          await _dio.delete<void>('${AppConfig.categoryEndpoint}/$id');
        case 'shop':
          await _dio.delete<void>(
            '${AppConfig.shopEndpoint}/$id/sync',
            data: {'clientModifiedDate': lastModifiedUtc},
          );
        case 'unit_of_measure':
          await _dio.delete<void>(
            '${AppConfig.unitOfMeasureEndpoint}/$id/sync',
            data: {'clientModifiedDate': lastModifiedUtc},
          );
        case 'product':
          await _dio.delete<void>(
            '${AppConfig.productEndpoint}/$id/sync',
            data: {'clientModifiedDate': lastModifiedUtc},
          );
        case 'product_unit':
          await _dio.delete<void>(
            '${AppConfig.productUnitEndpoint}/$id/sync',
            data: {'clientModifiedDate': lastModifiedUtc},
          );
        default:
          throw StateError('Unsupported PowerSync table: $table');
      }
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  Map<String, Object?> _categoryPayload(Map<String, dynamic> row) => {
    'name': row['name'] as String,
    'code': row['code'] as String?,
    'description': row['description'] as String?,
    'isActive': _asBool(row['is_active']),
  };

  Map<String, Object?> _shopPayload(Map<String, dynamic> row) => {
    'name': row['name'] as String,
    'shopType': _shopType(row['shop_type']),
    'address': row['address'] as String?,
    'phoneNumber': row['phone_number'] as String?,
    'email': row['email'] as String?,
    'taxNumber': row['tax_number'] as String?,
    'isActive': _asBool(row['is_active']),
  };

  Map<String, Object?> _unitPayload(Map<String, dynamic> row) => {
    'name': row['name'] as String,
    'symbol': row['symbol'] as String?,
    'description': row['description'] as String?,
  };

  Map<String, Object?> _productPayload(Map<String, dynamic> row) => {
    'name': row['name'] as String,
    'baseUnitId': row['base_unit_id'] as String,
    'description': row['description'] as String?,
    'isActive': _asBool(row['is_active']),
    'sku': row['sku'] as String?,
    'barcode': row['barcode'] as String?,
    'imageUrl': row['image_url'] as String?,
    'categoryId': row['category_id'] as String?,
    'reorderPointBase': 0,
    'reorderQuantityBase': 0,
  };

  Map<String, Object?> _productUnitPayload(Map<String, dynamic> row) => {
    'productId': row['product_id'] as String,
    'unitOfMeasureId': row['unit_of_measure_id'] as String,
    'baseUnitQuantity': (row['base_unit_quantity'] as num).toDouble(),
  };

  String _timestamp(Map<String, dynamic> row) =>
      row['last_modified_utc'] as String;

  bool _asBool(Object? value) => value == true || value == 1;

  String _shopType(Object? value) {
    final normalized = value?.toString().trim().toLowerCase();
    return normalized == 'wholesaleshop' || normalized == 'wholesale_shop'
        ? 'wholesaleShop'
        : 'retailShop';
  }
}
