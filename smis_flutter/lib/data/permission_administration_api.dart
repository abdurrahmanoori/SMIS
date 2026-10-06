import 'package:dio/dio.dart';
import '../config/app_config.dart';
import '../models/permission_administration.dart';
import '../models/task_role_administration.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
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
      ) {
    _dio.interceptors.add(
      BearerTokenInterceptor(SecureAuthSessionStore(), fallbackToken: token),
    );
  }
  final Dio _dio;
  static const _path = '/api/permission-administration';

  Future<List<ManagedTask>> getTasks() => _request(() async {
    final response = await _dio.get<List<dynamic>>('$_path/tasks');
    return response.data!
        .map((e) => ManagedTask.fromJson(Map<String, dynamic>.from(e as Map)))
        .toList();
  });

  Future<List<ManagedRole>> getRoles() => _request(() async {
    final response = await _dio.get<List<dynamic>>('$_path/roles');
    return response.data!
        .map((e) => ManagedRole.fromJson(Map<String, dynamic>.from(e as Map)))
        .toList();
  });

  Future<Map<String, bool>> getTaskPermissions(String roleId) =>
      _request(() async {
        final response = await _dio.get<List<dynamic>>(
          '$_path/roles/$roleId/task-permissions',
        );
        return {
          for (final row in response.data!)
            row['taskId'] as String: row['isAllowed'] == true,
        };
      });

  Future<void> saveTaskPermissions(String roleId, Map<String, bool> grants) =>
      _request(() async {
        await _dio.put<void>(
          '$_path/roles/$roleId/task-permissions',
          data: {
            'permissions': [
              for (final entry in grants.entries)
                {'taskId': entry.key, 'isAllowed': entry.value},
            ],
          },
        );
      });

  Future<void> saveRole(String name, {String? id}) => _request(() async {
    final data = {'name': name.trim()};
    if (id == null) {
      await _dio.post<void>('$_path/roles', data: data);
    } else {
      await _dio.put<void>('$_path/roles/$id', data: data);
    }
  });

  Future<void> deleteRole(String id) => _request(() async {
    await _dio.delete<void>('$_path/roles/$id');
  });

  Future<void> saveTask({
    String? id,
    required String key,
    required String name,
    required String componentId,
    required bool isActive,
  }) => _request(() async {
    final data = {
      'key': key.trim(),
      'name': name.trim(),
      'componentId': componentId,
      'isActive': isActive,
    };
    if (id == null) {
      await _dio.post<void>('$_path/tasks', data: data);
    } else {
      await _dio.put<void>('$_path/tasks/$id', data: data);
    }
  });

  Future<void> deleteTask(String id) => _request(() async {
    await _dio.delete<void>('$_path/tasks/$id');
  });

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
