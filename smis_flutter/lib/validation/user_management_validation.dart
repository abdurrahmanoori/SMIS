abstract final class UserManagementValidation {
  static const int maxUserNameLength = 256;
  static const int maxEmailLength = 256;
  static const int minPasswordLength = 6;
  static const int maxPersonNameLength = 100;
  static const int minPhoneLength = 8;
  static const int maxPhoneLength = 20;

  // ASP.NET Identity's default AllowedUserNameCharacters. The backend does not
  // override this setting, so validating it here avoids an unnecessary request.
  static final RegExp _userNamePattern = RegExp(r'^[a-zA-Z0-9\-\._@\+]+$');
  static final RegExp _phonePattern = RegExp(r'^\+?[\d\s\-\(\)]+$');

  static String? userName(String? value) {
    final text = value?.trim() ?? '';
    if (text.isEmpty) return 'Username is required';
    if (text.length > maxUserNameLength) {
      return 'Username must not exceed $maxUserNameLength characters';
    }
    if (!_userNamePattern.hasMatch(text)) {
      return 'Username can contain only letters, numbers, and - . _ @ +';
    }
    return null;
  }

  static String? email(String? value) {
    final text = value?.trim() ?? '';
    if (text.isEmpty) return 'Email is required';
    if (text.length > maxEmailLength) {
      return 'Email must not exceed $maxEmailLength characters';
    }

    // Mirrors FluentValidation's intentionally lightweight email-address check:
    // exactly one @, with content on both sides. The server remains authoritative.
    final firstAt = text.indexOf('@');
    if (firstAt <= 0 ||
        firstAt == text.length - 1 ||
        firstAt != text.lastIndexOf('@')) {
      return 'Email must be a valid email address';
    }
    return null;
  }

  static String? password(String? value, {required bool required}) {
    final text = value ?? '';
    if (required && text.isEmpty) return 'Password is required';
    if (text.isNotEmpty && text.length < minPasswordLength) {
      return 'Password must be at least $minPasswordLength characters';
    }
    return null;
  }

  static String? firstName(String? value) => _optionalName(value, 'First name');

  static String? lastName(String? value) => _optionalName(value, 'Last name');

  static String? _optionalName(String? value, String label) {
    final text = value?.trim() ?? '';
    if (text.length > maxPersonNameLength) {
      return '$label must not exceed $maxPersonNameLength characters';
    }
    return null;
  }

  static String? phoneNumber(String? value) {
    final text = value?.trim() ?? '';
    if (text.isEmpty) return null;
    if (text.length < minPhoneLength) {
      return 'Phone number must be at least $minPhoneLength characters';
    }
    if (text.length > maxPhoneLength) {
      return 'Phone number must not exceed $maxPhoneLength characters';
    }
    if (!_phonePattern.hasMatch(text)) {
      return 'Phone number format is invalid';
    }
    return null;
  }

  static String? shopId(String? value) {
    if (value == null || value.trim().isEmpty) return 'Shop is required';
    return null;
  }

  static String? roles(Iterable<String> values) {
    if (values.where((role) => role.trim().isNotEmpty).isEmpty) {
      return 'Select at least one role.';
    }
    return null;
  }

  /// Defensive validation immediately before an API request. Form validation is
  /// the primary UX; this prevents future callers from accidentally bypassing it.
  static String? userPayload({
    required String userName,
    required String email,
    required String? password,
    required bool requirePassword,
    required String firstName,
    required String lastName,
    required String phoneNumber,
    required String shopId,
    required Iterable<String> roles,
  }) {
    return UserManagementValidation.userName(userName) ??
        UserManagementValidation.email(email) ??
        UserManagementValidation.password(
          password,
          required: requirePassword,
        ) ??
        UserManagementValidation.firstName(firstName) ??
        UserManagementValidation.lastName(lastName) ??
        UserManagementValidation.phoneNumber(phoneNumber) ??
        UserManagementValidation.shopId(shopId) ??
        UserManagementValidation.roles(roles);
  }
}
