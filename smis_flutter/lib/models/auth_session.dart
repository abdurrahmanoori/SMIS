class AuthSession {
  const AuthSession({
    required this.token,
    required this.userId,
    required this.userName,
    required this.email,
    required this.roles,
    required this.shopId,
  });

  final String token;
  final String userId;
  final String userName;
  final String email;
  final List<String> roles;
  final String shopId;

  AuthSession copyWith({String? userName, String? email}) => AuthSession(
    token: token,
    userId: userId,
    userName: userName ?? this.userName,
    email: email ?? this.email,
    roles: roles,
    shopId: shopId,
  );

  factory AuthSession.fromJson(Map<String, dynamic> json) {
    String requiredString(String camelCase, String pascalCase) {
      final value = json[camelCase] ?? json[pascalCase];
      if (value is! String || value.trim().isEmpty) {
        throw const AuthFormatException('The login response was incomplete.');
      }
      return value;
    }

    final rawRoles = json['roles'] ?? json['Roles'] ?? const <dynamic>[];
    return AuthSession(
      token: requiredString('token', 'Token'),
      userId: requiredString('userId', 'UserId'),
      userName: requiredString('userName', 'UserName'),
      email: requiredString('email', 'Email'),
      shopId: requiredString('shopId', 'ShopId'),
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
  };
}

class AuthFormatException implements Exception {
  const AuthFormatException(this.message);

  final String message;

  @override
  String toString() => message;
}
