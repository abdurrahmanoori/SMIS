import 'package:dio/dio.dart';

import '../../../config/app_config.dart';
import 'powersync_upload_handler.dart';

class ProductUnitUploadHandler implements PowerSyncUploadHandler {
  ProductUnitUploadHandler(this._dio);

  final Dio _dio;

  @override
  String get table => 'product_unit';

  @override
  Future<void> create(String id, Map<String, dynamic> row) async {
    await _dio.post<void>(
      '${AppConfig.productUnitEndpoint}/sync',
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
      '${AppConfig.productUnitEndpoint}/$id/sync',
      data: {..._payload(row), 'clientModifiedDate': _timestamp(row)},
    );
  }

  @override
  Future<void> delete(String id, String lastModifiedUtc) async {
    await _dio.delete<void>(
      '${AppConfig.productUnitEndpoint}/$id/sync',
      data: {'clientModifiedDate': lastModifiedUtc},
    );
  }

  Map<String, Object?> _payload(Map<String, dynamic> row) => {
    'productId': row['product_id'] as String,
    'unitOfMeasureId': row['unit_of_measure_id'] as String,
    'baseUnitQuantity': (row['base_unit_quantity'] as num).toDouble(),
  };

  String _timestamp(Map<String, dynamic> row) =>
      row['last_modified_utc'] as String;
}
