import 'package:dio/dio.dart';

import '../../../config/app_config.dart';
import 'powersync_upload_handler.dart';

class ProductUploadHandler implements PowerSyncUploadHandler {
  ProductUploadHandler(this._dio);

  final Dio _dio;

  @override
  String get table => 'product';

  @override
  Future<void> create(String id, Map<String, dynamic> row) async {
    await _dio.post<void>(
      '${AppConfig.productEndpoint}/sync',
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
      '${AppConfig.productEndpoint}/$id/sync',
      data: {..._payload(row), 'clientModifiedDate': _timestamp(row)},
    );
  }

  @override
  Future<void> delete(String id, String lastModifiedUtc) async {
    await _dio.delete<void>(
      '${AppConfig.productEndpoint}/$id/sync',
      data: {'clientModifiedDate': lastModifiedUtc},
    );
  }

  Map<String, Object?> _payload(Map<String, dynamic> row) => {
    'name': row['name'] as String,
    'baseUnitId': row['base_unit_id'] as String,
    'description': row['description'] as String?,
    'isActive': _asBool(row['is_active']),
    'sku': row['sku'] as String?,
    'barcode': row['barcode'] as String?,
    'imageUrl': row['image_url'] as String?,
    'categoryId': row['category_id'] as String?,
    'reorderPointBase': (row['reorder_point_base'] as num?)?.toDouble() ?? 0,
    'reorderQuantityBase':
        (row['reorder_quantity_base'] as num?)?.toDouble() ?? 0,
  };

  String _timestamp(Map<String, dynamic> row) =>
      row['last_modified_utc'] as String;

  bool _asBool(Object? value) => value == true || value == 1;
}
