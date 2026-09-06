class UserProfile {
  const UserProfile({
    required this.id,
    required this.userName,
    required this.email,
    required this.phoneNumber,
    required this.firstName,
    required this.lastName,
    required this.shopId,
    required this.languageId,
    required this.emailConfirmed,
    required this.phoneNumberConfirmed,
    required this.roles,
    this.shop,
  });

  final String id;
  final String? userName;
  final String? email;
  final String? phoneNumber;
  final String? firstName;
  final String? lastName;
  final String shopId;
  final String languageId;
  final bool emailConfirmed;
  final bool phoneNumberConfirmed;
  final List<String> roles;
  final UserShop? shop;

  String get displayName {
    final name = [firstName, lastName]
        .whereType<String>()
        .map((part) => part.trim())
        .where((part) => part.isNotEmpty)
        .join(' ');
    return name.isNotEmpty ? name : (userName?.trim().isNotEmpty ?? false)
        ? userName!
        : email ?? 'SMIS user';
  }

  String get initials {
    final words = displayName.split(RegExp(r'\s+')).where((word) => word.isNotEmpty);
    final letters = words.take(2).map((word) => word[0].toUpperCase()).join();
    return letters.isEmpty ? '?' : letters;
  }

  factory UserProfile.fromJson(Map<String, dynamic> json) {
    String value(String camelCase, String pascalCase, {String fallback = ''}) {
      final raw = json[camelCase] ?? json[pascalCase];
      return raw is String ? raw : fallback;
    }

    bool boolValue(String camelCase, String pascalCase) {
      final raw = json[camelCase] ?? json[pascalCase];
      return raw is bool && raw;
    }

    final rawRoles = json['roles'] ?? json['Roles'];
    final rawShop = json['shop'] ?? json['Shop'];
    return UserProfile(
      id: value('id', 'Id'),
      userName: _nullable(value('userName', 'UserName')),
      email: _nullable(value('email', 'Email')),
      phoneNumber: _nullable(value('phoneNumber', 'PhoneNumber')),
      firstName: _nullable(value('firstName', 'FirstName')),
      lastName: _nullable(value('lastName', 'LastName')),
      shopId: value('shopId', 'ShopId'),
      languageId: value('languageId', 'LanguageId', fallback: '1'),
      emailConfirmed: boolValue('emailConfirmed', 'EmailConfirmed'),
      phoneNumberConfirmed: boolValue(
        'phoneNumberConfirmed',
        'PhoneNumberConfirmed',
      ),
      roles: rawRoles is List
          ? rawRoles.whereType<String>().toList(growable: false)
          : const <String>[],
      shop: rawShop is Map
          ? UserShop.fromJson(Map<String, dynamic>.from(rawShop))
          : null,
    );
  }

  static String? _nullable(String value) => value.trim().isEmpty ? null : value;
}

class UserShop {
  const UserShop({
    required this.id,
    required this.name,
    this.shopType,
    this.address,
    this.phoneNumber,
    this.email,
    this.taxNumber,
    this.isActive,
  });

  final String id;
  final String name;
  final String? shopType;
  final String? address;
  final String? phoneNumber;
  final String? email;
  final String? taxNumber;
  final bool? isActive;

  factory UserShop.fromJson(Map<String, dynamic> json) {
    String? nullable(String camelCase, String pascalCase) {
      final value = json[camelCase] ?? json[pascalCase];
      return value is String && value.trim().isNotEmpty ? value : null;
    }

    final rawShopType = json['shopType'] ?? json['ShopType'];
    final rawActive = json['isActive'] ?? json['IsActive'];
    return UserShop(
      id: nullable('id', 'Id') ?? '',
      name: nullable('name', 'Name') ?? 'Unnamed shop',
      shopType: rawShopType?.toString(),
      address: nullable('address', 'Address'),
      phoneNumber: nullable('phoneNumber', 'PhoneNumber'),
      email: nullable('email', 'Email'),
      taxNumber: nullable('taxNumber', 'TaxNumber'),
      isActive: rawActive is bool ? rawActive : null,
    );
  }
}

class ProfileUpdateDraft {
  const ProfileUpdateDraft({
    required this.userName,
    required this.email,
    required this.languageId,
    required this.shopId,
    this.phoneNumber,
    this.firstName,
    this.lastName,
  });

  final String userName;
  final String email;
  final String languageId;
  final String shopId;
  final String? phoneNumber;
  final String? firstName;
  final String? lastName;

  ProfileUpdateDraft normalized() {
    final normalizedUserName = userName.trim();
    if (normalizedUserName.isEmpty || normalizedUserName.length > 256) {
      throw const ProfileValidationException('Username must be between 1 and 256 characters.');
    }
    final normalizedEmail = email.trim();
    if (normalizedEmail.isEmpty || !normalizedEmail.contains('@')) {
      throw const ProfileValidationException('Enter a valid email address.');
    }
    final normalizedLanguageId = languageId.trim();
    if (normalizedLanguageId.isEmpty) {
      throw const ProfileValidationException('Select a language.');
    }
    final normalizedShopId = shopId.trim();
    if (normalizedShopId.isEmpty) {
      throw const ProfileValidationException('Your account does not have a shop assigned.');
    }
    if (firstName != null && firstName!.trim().length > 100) {
      throw const ProfileValidationException('First name must not exceed 100 characters.');
    }
    if (lastName != null && lastName!.trim().length > 100) {
      throw const ProfileValidationException('Last name must not exceed 100 characters.');
    }
    final normalizedPhone = phoneNumber?.trim();
    if (normalizedPhone != null && normalizedPhone.isNotEmpty) {
      if (!RegExp(r'^\+?[\d\s\-\(\)]+$').hasMatch(normalizedPhone) ||
          normalizedPhone.length < 8 ||
          normalizedPhone.length > 20) {
        throw const ProfileValidationException('Enter a valid phone number.');
      }
    }
    return ProfileUpdateDraft(
      userName: normalizedUserName,
      email: normalizedEmail,
      languageId: normalizedLanguageId,
      shopId: normalizedShopId,
      phoneNumber: normalizedPhone,
      firstName: firstName?.trim(),
      lastName: lastName?.trim(),
    );
  }

  Map<String, dynamic> toJson() => {
    'userName': userName,
    'email': email,
    'languageId': languageId,
    'shopId': shopId,
    if (phoneNumber?.isNotEmpty ?? false) 'phoneNumber': phoneNumber,
    if (firstName?.isNotEmpty ?? false) 'firstName': firstName,
    if (lastName?.isNotEmpty ?? false) 'lastName': lastName,
  };
}

class ProfileLanguage {
  const ProfileLanguage({required this.id, required this.name, this.code});

  final String id;
  final String name;
  final String? code;

  String get label => code == null || code!.isEmpty ? name : '$name ($code)';

  factory ProfileLanguage.fromJson(Map<String, dynamic> json) {
    String value(String camelCase, String pascalCase) {
      final raw = json[camelCase] ?? json[pascalCase];
      return raw is String ? raw : '';
    }

    final code = value('code', 'Code');
    return ProfileLanguage(
      id: value('id', 'Id'),
      name: value('name', 'Name'),
      code: code.isEmpty ? null : code,
    );
  }
}

class ChangePasswordDraft {
  const ChangePasswordDraft({
    required this.currentPassword,
    required this.newPassword,
  });

  final String currentPassword;
  final String newPassword;

  ChangePasswordDraft normalized() {
    if (currentPassword.isEmpty) {
      throw const ProfileValidationException('Current password is required.');
    }
    if (newPassword.length < 6) {
      throw const ProfileValidationException('New password must be at least 6 characters.');
    }
    return ChangePasswordDraft(
      currentPassword: currentPassword,
      newPassword: newPassword,
    );
  }

  Map<String, dynamic> toJson() => {
    'currentPassword': currentPassword,
    'newPassword': newPassword,
  };
}

class ProfileValidationException implements Exception {
  const ProfileValidationException(this.message);

  final String message;

  @override
  String toString() => message;
}
