import 'package:dio/dio.dart';
import '../config/app_config.dart';
import '../models/permission_administration.dart';
import 'data_exception.dart';

class PermissionAdministrationApi {
  PermissionAdministrationApi({required String token})
    : _dio = Dio(
        BaseOptions(
          baseUrl: AppConfig.apiBaseUrl,
          connectTimeout: const Duration(seconds: 10),
          receiveTimeout: const Duration(seconds: 20),
          sendTimeout: const Duration(seconds: 20),
          headers: {
            'Accept': 'application/json',
            'Authorization': 'Bearer $token',
          },
        ),
      );
  final Dio _dio;
  static const _path = '/api/permission-administration';

  Future<T> _request<T>(Future<T> Function() call) async {
    try {
      return await call();
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: error is DioException && error.response == null
            ? 'Permission management is online-only. Connect to the server and try again.'
            : 'Unable to manage permissions.',
      );
    }
  }

  Future<PermissionCatalog> getCatalog() => _request(() async {
    final response = await _dio.get<Map<String, dynamic>>('$_path/catalog');
    return PermissionCatalog.fromJson(response.data!);
  });

  Future<List<ManagedComponentPermission>> getPermissions(String roleId) =>
      _request(() async {
        final response = await _dio.get<List<dynamic>>(
          '$_path/roles/$roleId/permissions',
        );
        return response.data!
            .map(
              (e) => ManagedComponentPermission.fromJson(
                Map<String, dynamic>.from(e as Map),
              ),
            )
            .toList();
      });

  Future<void> savePermissions(
    String roleId,
    Iterable<ManagedComponentPermission> rows,
  ) => _request(() async {
    await _dio.put<void>(
      '$_path/roles/$roleId/permissions',
      data: {'permissions': rows.map((r) => r.toJson()).toList()},
    );
  });

  Future<void> updateComponent(
    ManagedComponent component, {
    required String name,
    required int displayOrder,
    required bool isActive,
  }) => _request(() async {
    await _dio.put<void>(
      '$_path/components/${component.id}',
      data: {
        'name': name.trim(),
        'displayOrder': displayOrder,
        'isActive': isActive,
      },
    );
  });
}
