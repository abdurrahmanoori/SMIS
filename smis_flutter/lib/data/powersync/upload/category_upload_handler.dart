import 'package:dio/dio.dart';

import '../../../config/app_config.dart';
import '../../../models/language_defaults.dart';
import 'powersync_upload_handler.dart';

class CategoryUploadHandler implements PowerSyncUploadHandler {
  CategoryUploadHandler(this._dio);

  final Dio _dio;

  @override
  String get table => 'category';

  @override
  Future<void> create(String id, Map<String, dynamic> row) async {
    await _dio.post<void>(
      '${AppConfig.categoryEndpoint}/sync',
      data: {'id': id, ..._payload(row), 'clientModifiedDate': _timestamp(row)},
    );
  }

  @override
  Future<void> update(String id, Map<String, dynamic> row) async {
    await _dio.put<void>(
      '${AppConfig.categoryEndpoint}/$id/sync',
      data: {..._payload(row), 'clientModifiedDate': _timestamp(row)},
    );
  }

  @override
  Future<void> delete(String id, String lastModifiedUtc) async {
    await _dio.delete<void>(
      '${AppConfig.categoryEndpoint}/$id/sync',
      data: {
        'clientModifiedDate': normalizePowerSyncTimestamp(lastModifiedUtc),
      },
    );
  }

  Map<String, Object?> _payload(Map<String, dynamic> row) {
    final dariName = (row['name_dari'] as String?)?.trim();

    return {
      'name': row['name'] as String,
      'nameTranslations': [
        {
          'languageId': LanguageDefaults.dariId,
          'value': dariName ?? '',
        },
      ],
      'code': row['code'] as String?,
      'description': row['description'] as String?,
      'isActive': _asBool(row['is_active']),
    };
  }

  bool _asBool(Object? value) => value == true || value == 1;

  String _timestamp(Map<String, dynamic> row) =>
      normalizePowerSyncTimestamp(row['last_modified_utc'] as String);
}
