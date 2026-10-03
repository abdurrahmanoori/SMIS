import 'language_defaults.dart';
import 'component_permission.dart';

class AuthSession {
  const AuthSession({
    required this.token,
    required this.userId,
    required this.userName,
    required this.email,
    required this.roles,
    required this.shopId,
    required this.languageId,
    required this.languageCode,
    this.permissions = const [],
    this.taskPermissions = const [],
    this.taskPermissionsLoaded = false,
  });

  final String token;
  final String userId;
  final String userName;
  final String email;
  final List<String> roles;
  final String shopId;
  final String languageId;
  final String languageCode;
  final List<ComponentPermission> permissions;
  final List<String> taskPermissions;
  final bool taskPermissionsLoaded;

  bool get isSuperAdmin =>
      roles.any((role) => role.trim().toLowerCase() == 'superadmin');

  bool get isShopAdmin =>
      roles.any((role) => role.trim().toLowerCase() == 'shopadmin');

  ComponentPermission? permissionFor(String componentKey) {
    for (final permission in permissions) {
      if (permission.componentKey.toLowerCase() == componentKey.toLowerCase()) {
        return permission;
      }
    }
    return null;
  }

  bool canViewComponent(String componentKey) =>
      permissionFor(componentKey)?.canView ?? false;

  bool canReadComponent(String componentKey) =>
      permissionFor(componentKey)?.canRead ?? false;

  bool canCreateComponent(String componentKey) =>
      permissionFor(componentKey)?.canCreate ?? false;

  bool canUpdateComponent(String componentKey) =>
      permissionFor(componentKey)?.canUpdate ?? false;

  bool canDeleteComponent(String componentKey) =>
      permissionFor(componentKey)?.canDelete ?? false;

  bool hasTaskPermission(String taskKey) => taskPermissions.any(
    (permission) => permission.toLowerCase() == taskKey.toLowerCase(),
  );

  AuthSession copyWith({
    String? token,
    String? userName,
    String? email,
    List<String>? roles,
    String? shopId,
    String? languageId,
    String? languageCode,
    List<ComponentPermission>? permissions,
    List<String>? taskPermissions,
    bool? taskPermissionsLoaded,
  }) => AuthSession(
    token: token ?? this.token,
    userId: userId,
    userName: userName ?? this.userName,
    email: email ?? this.email,
    roles: roles ?? this.roles,
    shopId: shopId ?? this.shopId,
    languageId: languageId ?? this.languageId,
    languageCode: languageCode ?? this.languageCode,
    permissions: permissions ?? this.permissions,
    taskPermissions: taskPermissions ?? this.taskPermissions,
    taskPermissionsLoaded: taskPermissionsLoaded ?? this.taskPermissionsLoaded,
  );

  factory AuthSession.fromJson(Map<String, dynamic> json) {
    String requiredString(String camelCase, String pascalCase) {
      final value = json[camelCase] ?? json[pascalCase];
      if (value is! String || value.trim().isEmpty) {
        throw const AuthFormatException('The login response was incomplete.');
      }
      return value;
    }

    String optionalString(
      String camelCase,
      String pascalCase,
      String fallback,
    ) {
      final value = json[camelCase] ?? json[pascalCase];
      return value is String && value.trim().isNotEmpty ? value : fallback;
    }

    final rawRoles = json['roles'] ?? json['Roles'] ?? const <dynamic>[];
    final rawPermissions =
        json['permissions'] ?? json['Permissions'] ?? const <dynamic>[];
    final rawTaskPermissions =
        json['taskPermissions'] ?? json['TaskPermissions'] ?? const <dynamic>[];
    return AuthSession(
      token: requiredString('token', 'Token'),
      userId: requiredString('userId', 'UserId'),
      userName: requiredString('userName', 'UserName'),
      email: requiredString('email', 'Email'),
      shopId: requiredString('shopId', 'ShopId'),
      languageId: optionalString(
        'languageId',
        'LanguageId',
        LanguageDefaults.englishId,
      ),
      languageCode: optionalString(
        'languageCode',
        'LanguageCode',
        LanguageDefaults.englishCode,
      ).toLowerCase(),
      roles: rawRoles is List
          ? rawRoles.whereType<String>().toList(growable: false)
          : const <String>[],
      permissions: rawPermissions is List
          ? rawPermissions
                .whereType<Map>()
                .map(
                  (item) => ComponentPermission.fromJson(
                    Map<String, dynamic>.from(item),
                  ),
                )
                .toList(growable: false)
          : const <ComponentPermission>[],
      taskPermissions: rawTaskPermissions is List
          ? rawTaskPermissions.whereType<String>().toList(growable: false)
          : const <String>[],
      taskPermissionsLoaded:
          json['taskPermissionsLoaded'] ??
          json['TaskPermissionsLoaded'] ??
          false,
    );
  }

  Map<String, dynamic> toJson() => {
    'token': token,
    'userId': userId,
    'userName': userName,
    'email': email,
    'roles': roles,
    'shopId': shopId,
    'languageId': languageId,
    'languageCode': languageCode,
    'permissions': permissions
        .map((permission) => permission.toJson())
        .toList(),
    'taskPermissions': taskPermissions,
    'taskPermissionsLoaded': taskPermissionsLoaded,
  };
}

class AuthFormatException implements Exception {
  const AuthFormatException(this.message);

  final String message;

  @override
  String toString() => message;
}
