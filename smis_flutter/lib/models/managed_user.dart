class ManagedUser {
  const ManagedUser({
    required this.id,
    required this.userName,
    required this.email,
    required this.shopId,
    required this.languageId,
    required this.roles,
    required this.isActive,
    required this.isLocked,
    this.lockoutEnd,
    this.firstName,
    this.lastName,
    this.phoneNumber,
    this.shopName,
  });

  final String id;
  final String userName;
  final String email;
  final String? phoneNumber;
  final String? firstName;
  final String? lastName;
  final String shopId;
  final String? shopName;
  final String languageId;
  final List<String> roles;
  final bool isActive;
  final bool isLocked;
  final DateTime? lockoutEnd;

  bool get isSuperAdmin =>
      roles.any((role) => role.trim().toLowerCase() == 'superadmin');

  String get displayName {
    final name = [firstName, lastName]
        .whereType<String>()
        .map((value) => value.trim())
        .where((value) => value.isNotEmpty)
        .join(' ');
    return name.isEmpty ? userName : name;
  }

  factory ManagedUser.fromJson(Map<String, dynamic> json) {
    final shop = json['shop'] ?? json['Shop'];
    final rawRoles = json['roles'] ?? json['Roles'] ?? const <dynamic>[];
    return ManagedUser(
      id: _string(json, 'id', 'Id'),
      userName: _string(json, 'userName', 'UserName'),
      email: _string(json, 'email', 'Email'),
      phoneNumber: _optionalString(json, 'phoneNumber', 'PhoneNumber'),
      firstName: _optionalString(json, 'firstName', 'FirstName'),
      lastName: _optionalString(json, 'lastName', 'LastName'),
      shopId: _string(json, 'shopId', 'ShopId'),
      shopName: shop is Map
          ? _optionalString(Map<String, dynamic>.from(shop), 'name', 'Name')
          : null,
      languageId: _string(json, 'languageId', 'LanguageId'),
      roles: rawRoles is List
          ? rawRoles.whereType<String>().toList(growable: false)
          : const <String>[],
      isActive: _bool(json, 'isActive', 'IsActive'),
      isLocked: _bool(json, 'isLocked', 'IsLocked'),
      lockoutEnd: _dateTime(json, 'lockoutEnd', 'LockoutEnd'),
    );
  }

  static String _string(
    Map<String, dynamic> json,
    String camelCase,
    String pascalCase,
  ) => (json[camelCase] ?? json[pascalCase] ?? '').toString();

  static bool _bool(
    Map<String, dynamic> json,
    String camelCase,
    String pascalCase,
  ) => (json[camelCase] ?? json[pascalCase]) == true;

  static DateTime? _dateTime(
    Map<String, dynamic> json,
    String camelCase,
    String pascalCase,
  ) {
    final value = json[camelCase] ?? json[pascalCase];
    if (value == null) return null;
    return DateTime.tryParse(value.toString());
  }

  static String? _optionalString(
    Map<String, dynamic> json,
    String camelCase,
    String pascalCase,
  ) {
    final value = json[camelCase] ?? json[pascalCase];
    if (value == null) return null;
    final text = value.toString().trim();
    return text.isEmpty ? null : text;
  }
}

class ManagedUserPage {
  const ManagedUserPage({
    required this.items,
    required this.pageNumber,
    required this.pageSize,
    required this.totalCount,
    required this.totalPages,
  });

  final List<ManagedUser> items;
  final int pageNumber;
  final int pageSize;
  final int totalCount;
  final int totalPages;
}

class UserShopOption {
  const UserShopOption({required this.id, required this.name});

  final String id;
  final String name;
}
