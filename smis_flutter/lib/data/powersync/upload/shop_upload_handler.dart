import 'package:dio/dio.dart';

import '../../../config/app_config.dart';
import 'powersync_upload_handler.dart';

class ShopUploadHandler implements PowerSyncUploadHandler {
  ShopUploadHandler(this._dio);

  final Dio _dio;

  @override
  String get table => 'shop';

  @override
  Future<void> create(String id, Map<String, dynamic> row) async {
    await _dio.post<void>(
      '${AppConfig.shopEndpoint}/sync',
      data: {
        'id': id,
        ..._payload(row),
        'clientCreatedDate': _timestamp(row),
        'clientModifiedDate': _timestamp(row),
      },
    );
  }

  @override
  Future<void> update(String id, Map<String, dynamic> row) async {
    await _dio.put<void>(
      '${AppConfig.shopEndpoint}/$id/sync',
      data: {..._payload(row), 'clientModifiedDate': _timestamp(row)},
    );
  }

  @override
  Future<void> delete(String id, String lastModifiedUtc) async {
    await _dio.delete<void>(
      '${AppConfig.shopEndpoint}/$id/sync',
      data: {
        'clientModifiedDate': normalizePowerSyncTimestamp(lastModifiedUtc),
      },
    );
  }

  Map<String, Object?> _payload(Map<String, dynamic> row) => {
    'name': row['name'] as String,
    'shopType': _shopType(row['shop_type']),
    'address': row['address'] as String?,
    'phoneNumber': row['phone_number'] as String?,
    'email': row['email'] as String?,
    'taxNumber': row['tax_number'] as String?,
    'isActive': _asBool(row['is_active']),
  };

  String _timestamp(Map<String, dynamic> row) =>
      normalizePowerSyncTimestamp(row['last_modified_utc'] as String);

  bool _asBool(Object? value) => value == true || value == 1;

  String _shopType(Object? value) {
    final normalized = value?.toString().trim().toLowerCase();
    return normalized == 'wholesaleshop' || normalized == 'wholesale_shop'
        ? 'wholesaleShop'
        : 'retailShop';
  }
}
