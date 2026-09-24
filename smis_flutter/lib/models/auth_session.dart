import 'language_defaults.dart';

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
  });

  final String token;
  final String userId;
  final String userName;
  final String email;
  final List<String> roles;
  final String shopId;
  final String languageId;
  final String languageCode;

  bool get isSuperAdmin =>
      roles.any((role) => role.trim().toLowerCase() == 'superadmin');

  AuthSession copyWith({
    String? token,
    String? userName,
    String? email,
    List<String>? roles,
    String? shopId,
    String? languageId,
    String? languageCode,
  }) => AuthSession(
    token: token ?? this.token,
    userId: userId,
    userName: userName ?? this.userName,
    email: email ?? this.email,
    roles: roles ?? this.roles,
    shopId: shopId ?? this.shopId,
    languageId: languageId ?? this.languageId,
    languageCode: languageCode ?? this.languageCode,
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
  };
}

class AuthFormatException implements Exception {
  const AuthFormatException(this.message);

  final String message;

  @override
  String toString() => message;
}
