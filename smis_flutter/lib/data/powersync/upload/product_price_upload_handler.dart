import 'package:dio/dio.dart';

import '../../../config/app_config.dart';
import 'powersync_upload_handler.dart';

class ProductPriceUploadHandler implements PowerSyncUploadHandler {
  ProductPriceUploadHandler(this._dio);

  final Dio _dio;

  @override
  String get table => 'product_price';

  @override
  Future<void> create(String id, Map<String, dynamic> row) async {
    await _dio.post<void>(
      '${AppConfig.productPriceEndpoint}/sync',
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
      '${AppConfig.productPriceEndpoint}/$id/sync',
      data: {..._payload(row), 'clientModifiedDate': _timestamp(row)},
    );
  }

  @override
  Future<void> delete(String id, String lastModifiedUtc) async {
    await _dio.delete<void>(
      '${AppConfig.productPriceEndpoint}/$id/sync',
      data: {'clientModifiedDate': lastModifiedUtc},
    );
  }

  Map<String, Object?> _payload(Map<String, dynamic> row) => {
    'productUnitId': row['product_unit_id'] as String,
    'sellPrice': (row['sell_price'] as num).toInt(),
    'effectiveDate': row['effective_date'] as String,
    'endDate': row['end_date'] as String?,
  };

  String _timestamp(Map<String, dynamic> row) =>
      row['last_modified_utc'] as String;
}
