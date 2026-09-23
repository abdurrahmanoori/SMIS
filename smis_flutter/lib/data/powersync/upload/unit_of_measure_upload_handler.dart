import 'package:dio/dio.dart';

import '../../../config/app_config.dart';
import 'powersync_upload_handler.dart';

class UnitOfMeasureUploadHandler implements PowerSyncUploadHandler {
  UnitOfMeasureUploadHandler(this._dio);

  final Dio _dio;

  @override
  String get table => 'unit_of_measure';

  @override
  Future<void> create(String id, Map<String, dynamic> row) async {
    await _dio.post<void>(
      '${AppConfig.unitOfMeasureEndpoint}/sync',
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
      '${AppConfig.unitOfMeasureEndpoint}/$id/sync',
      data: {..._payload(row), 'clientModifiedDate': _timestamp(row)},
    );
  }

  @override
  Future<void> delete(String id, String lastModifiedUtc) async {
    await _dio.delete<void>(
      '${AppConfig.unitOfMeasureEndpoint}/$id/sync',
      data: {
        'clientModifiedDate': normalizePowerSyncTimestamp(lastModifiedUtc),
      },
    );
  }

  Map<String, Object?> _payload(Map<String, dynamic> row) => {
    'name': row['name'] as String,
    'symbol': row['symbol'] as String?,
    'description': row['description'] as String?,
  };

  String _timestamp(Map<String, dynamic> row) =>
      normalizePowerSyncTimestamp(row['last_modified_utc'] as String);
}
