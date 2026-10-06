import 'package:dio/dio.dart';

import '../../../config/app_config.dart';
import 'powersync_upload_handler.dart';

class SupplierUploadHandler implements PowerSyncUploadHandler {
  SupplierUploadHandler(this._dio);

  final Dio _dio;

  @override
  String get table => 'supplier';

  @override
  Future<void> create(String id, Map<String, dynamic> row) async {
    await _dio.post<void>(
      '${AppConfig.supplierEndpoint}/sync',
      data: {'id': id, ..._payload(row), 'clientModifiedDate': _timestamp(row)},
    );
  }

  @override
  Future<void> update(String id, Map<String, dynamic> row) async {
    await _dio.put<void>(
      '${AppConfig.supplierEndpoint}/$id/sync',
      data: {..._payload(row), 'clientModifiedDate': _timestamp(row)},
    );
  }

  @override
  Future<void> delete(String id, String lastModifiedUtc) async {
    throw UnsupportedError(
      'Supplier records are deactivated instead of deleted.',
    );
  }

  Map<String, Object?> _payload(Map<String, dynamic> row) => {
    'name': row['name'] as String,
    'phoneNumber': row['phone_number'] as String?,
    'notes': row['notes'] as String?,
    'isActive': _asBool(row['is_active']),
  };

  bool _asBool(Object? value) => value == true || value == 1;

  String _timestamp(Map<String, dynamic> row) =>
      normalizePowerSyncTimestamp(row['last_modified_utc'] as String);
}
