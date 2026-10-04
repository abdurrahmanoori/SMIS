import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/managed_user.dart';
import 'data_exception.dart';

class UserManagementApi {
  factory UserManagementApi({required String token, Dio? dio}) =>
      UserManagementApi._(
        token,
        dio ??
            Dio(
              BaseOptions(
                baseUrl: AppConfig.apiBaseUrl,
                connectTimeout: const Duration(seconds: 10),
                receiveTimeout: const Duration(seconds: 20),
                sendTimeout: const Duration(seconds: 20),
                headers: const {'Accept': 'application/json'},
              ),
            ),
      );

  UserManagementApi._(this._token, this._dio);

  final String _token;
  final Dio _dio;

  Options get _options => Options(headers: {'Authorization': 'Bearer $_token'});

  Future<ManagedUserPage> getUsers({
    required int pageNumber,
    int pageSize = 25,
    String? search,
  }) async {
    try {
      final response = await _dio.get<Map<String, dynamic>>(
        AppConfig.accountEndpoint,
        queryParameters: {
          'pageNumber': pageNumber,
          'pageSize': pageSize,
          'includeShop': true,
          if (search != null && search.trim().isNotEmpty)
            'search': search.trim(),
        },
        options: _options,
      );
      final data = response.data ?? const <String, dynamic>{};
      final rawItems = data['items'] ?? data['Items'] ?? const <dynamic>[];
      return ManagedUserPage(
        items: rawItems is List
            ? rawItems
                  .whereType<Map>()
                  .map(
                    (item) =>
                        ManagedUser.fromJson(Map<String, dynamic>.from(item)),
                  )
                  .toList(growable: false)
            : const <ManagedUser>[],
        pageNumber: _int(data, 'pageNumber', 'PageNumber', pageNumber),
        pageSize: _int(data, 'pageSize', 'PageSize', pageSize),
        totalCount: _int(data, 'totalCount', 'TotalCount', 0),
        totalPages: _int(data, 'totalPages', 'TotalPages', 1),
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to load users from the server.',
      );
    }
  }

  Future<List<UserShopOption>> getActiveShops() async {
    try {
      final response = await _dio.get<Map<String, dynamic>>(
        AppConfig.shopEndpoint,
        queryParameters: const {'pageNumber': 1, 'pageSize': 500},
        options: _options,
      );
      final data = response.data ?? const <String, dynamic>{};
      final rawItems = data['items'] ?? data['Items'] ?? const <dynamic>[];
      if (rawItems is! List) return const <UserShopOption>[];
      final shops = <UserShopOption>[];
      for (final raw in rawItems.whereType<Map>()) {
        final item = Map<String, dynamic>.from(raw);
        final isActive = item['isActive'] ?? item['IsActive'] ?? false;
        final isDeleted = item['isDeleted'] ?? item['IsDeleted'] ?? false;
        if (isActive != true || isDeleted == true) continue;
        final id = (item['id'] ?? item['Id'] ?? '').toString();
        final name = (item['name'] ?? item['Name'] ?? '').toString();
        if (id.isNotEmpty && name.isNotEmpty) {
          shops.add(UserShopOption(id: id, name: name));
        }
      }
      shops.sort((a, b) => a.name.compareTo(b.name));
      return shops;
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to load shops from the server.',
      );
    }
  }

  Future<void> createUser({
    required String userName,
    required String email,
    required String password,
    required String languageId,
    required List<String> roles,
    String? firstName,
    String? lastName,
    String? phoneNumber,
  }) async {
    try {
      await _dio.post<void>(
        '${AppConfig.accountEndpoint}/register',
        data: {
          'userName': userName.trim(),
          'email': email.trim(),
          'password': password,
          // ShopId deliberately comes from the authenticated JWT on the server.
          'languageId': languageId,
          'roles': roles,
          'firstName': _trimOrNull(firstName),
          'lastName': _trimOrNull(lastName),
          'phoneNumber': _trimOrNull(phoneNumber),
        },
        options: _options,
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to create the user.',
      );
    }
  }

  Future<void> updateUser({
    required ManagedUser user,
    required String userName,
    required String email,
    required String shopId,
    required List<String> roles,
    String? firstName,
    String? lastName,
    String? phoneNumber,
  }) async {
    try {
      await _dio.put<void>(
        '${AppConfig.accountEndpoint}/${user.id}',
        data: {
          'userName': userName.trim(),
          'email': email.trim(),
          'shopId': shopId,
          'languageId': user.languageId,
          'roles': roles,
          'firstName': _trimOrNull(firstName),
          'lastName': _trimOrNull(lastName),
          'phoneNumber': _trimOrNull(phoneNumber),
        },
        options: _options,
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to update the user.',
      );
    }
  }

  Future<void> deleteUser(String userId) async {
    try {
      await _dio.delete<void>(
        '${AppConfig.accountEndpoint}/$userId',
        options: _options,
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to delete the user.',
      );
    }
  }

  Future<List<String>> getUserRoles(String userId) async {
    try {
      final response = await _dio.get<List<dynamic>>(
        '${AppConfig.accountEndpoint}/$userId/roles',
        options: _options,
      );
      return (response.data ?? const <dynamic>[]).whereType<String>().toList(
        growable: false,
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to load user roles.',
      );
    }
  }

  Future<void> assignRoles({
    required String userId,
    required List<String> roles,
  }) async {
    try {
      await _dio.post<void>(
        '${AppConfig.accountEndpoint}/$userId/roles',
        data: roles,
        options: _options,
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to update user roles.',
      );
    }
  }

  Future<void> resetPassword(String userId) async {
    try {
      await _dio.post<void>(
        '${AppConfig.accountEndpoint}/$userId/reset-password',
        options: _options,
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to reset the user password.',
      );
    }
  }

  Future<void> lockUser(String userId) async {
    try {
      await _dio.post<void>(
        '${AppConfig.accountEndpoint}/$userId/lock',
        options: _options,
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to lock the user.',
      );
    }
  }

  Future<void> unlockUser(String userId) async {
    try {
      await _dio.post<void>(
        '${AppConfig.accountEndpoint}/$userId/unlock',
        options: _options,
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: 'Unable to unlock the user.',
      );
    }
  }

  Future<void> setActiveStatus({
    required String userId,
    required bool isActive,
  }) async {
    try {
      await _dio.post<void>(
        '${AppConfig.accountEndpoint}/$userId/${isActive ? 'activate' : 'deactivate'}',
        options: _options,
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: isActive
            ? 'Unable to activate the user.'
            : 'Unable to deactivate the user.',
      );
    }
  }

  Future<void> setAllShopAdminsActiveStatus(bool isActive) async {
    try {
      await _dio.post<void>(
        '${AppConfig.accountEndpoint}/shop-admins/${isActive ? 'activate' : 'deactivate'}',
        options: _options,
      );
    } catch (error, stackTrace) {
      _mapAndThrow(
        error,
        stackTrace,
        fallbackMessage: isActive
            ? 'Unable to activate ShopAdmin accounts.'
            : 'Unable to deactivate ShopAdmin accounts.',
      );
    }
  }

  static Never _mapAndThrow(
    Object error,
    StackTrace stackTrace, {
    required String fallbackMessage,
  }) {
    final offline = error is DioException && error.response == null;
    ApiErrorParser.mapAndThrow(
      error,
      stackTrace,
      fallbackMessage: offline
          ? 'User management is online-only. Connect to the internet and try again.'
          : fallbackMessage,
    );
  }

  static int _int(
    Map<String, dynamic> json,
    String camelCase,
    String pascalCase,
    int fallback,
  ) {
    final value = json[camelCase] ?? json[pascalCase];
    return value is num ? value.toInt() : fallback;
  }

  static String? _trimOrNull(String? value) {
    final trimmed = value?.trim();
    return trimmed == null || trimmed.isEmpty ? null : trimmed;
  }
}
