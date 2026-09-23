enum ShopType {
  retailShop,
  wholesaleShop;

  String get apiValue => name;

  static ShopType fromApiValue(Object? value) {
    if (value is String) {
      return ShopType.values.byName(value);
    }
    throw FormatException('Unsupported shop type: $value');
  }
}

enum ShopSyncStatus {
  synced,
  pendingCreate,
  pendingUpdate,
  pendingDelete,
  failed;

  bool get isPending => this != synced;
}

class Shop {
  const Shop({
    required this.id,
    required this.name,
    required this.shopType,
    required this.isActive,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.syncStatus,
    this.address,
    this.phoneNumber,
    this.email,
    this.taxNumber,
    this.lastSyncError,
  });

  final String id;
  final String name;
  final ShopType shopType;
  final String? address;
  final String? phoneNumber;
  final String? email;
  final String? taxNumber;
  final bool isActive;
  final DateTime createdAt;
  final DateTime updatedAt;
  final DateTime lastModifiedUtc;
  final ShopSyncStatus syncStatus;
  final String? lastSyncError;
}

class ShopDraft {
  const ShopDraft({
    required this.name,
    required this.shopType,
    this.address,
    this.phoneNumber,
    this.email,
    this.taxNumber,
    this.isActive = true,
  });

  static final _phoneNumberPattern = RegExp(r'^\+?[\d\s\-()]+$');
  static final _emailPattern = RegExp(r'^[^@\s]+@[^@\s]+\.[^@\s]+$');
  static final _taxNumberPattern = RegExp(r'^[A-Z0-9-]+$');

  final String name;
  final ShopType shopType;
  final String? address;
  final String? phoneNumber;
  final String? email;
  final String? taxNumber;
  final bool isActive;

  ShopDraft normalized() {
    final normalizedName = name.trim();
    final normalizedAddress = _optionalTrim(address);
    final normalizedPhoneNumber = _optionalTrim(phoneNumber);
    final normalizedEmail = _optionalTrim(email)?.toLowerCase();
    final normalizedTaxNumber = _optionalTrim(taxNumber)?.toUpperCase();

    if (normalizedName.isEmpty) {
      throw const ShopValidationException('Name is required.');
    }
    if (normalizedName.length > 200) {
      throw const ShopValidationException('Name cannot exceed 200 characters.');
    }
    if (normalizedAddress != null && normalizedAddress.length > 500) {
      throw const ShopValidationException(
        'Address cannot exceed 500 characters.',
      );
    }
    if (normalizedPhoneNumber != null &&
        (normalizedPhoneNumber.length < 8 ||
            normalizedPhoneNumber.length > 20 ||
            !_phoneNumberPattern.hasMatch(normalizedPhoneNumber))) {
      throw const ShopValidationException(
        'Phone number must be 8 to 20 characters and use only valid phone characters.',
      );
    }
    if (normalizedEmail != null &&
        (normalizedEmail.length > 100 ||
            !_emailPattern.hasMatch(normalizedEmail))) {
      throw const ShopValidationException('Enter a valid email address.');
    }
    if (normalizedTaxNumber != null &&
        (normalizedTaxNumber.length < 5 ||
            normalizedTaxNumber.length > 20 ||
            !_taxNumberPattern.hasMatch(normalizedTaxNumber))) {
      throw const ShopValidationException(
        'Tax number must be 5 to 20 uppercase letters, digits, or hyphens.',
      );
    }

    return ShopDraft(
      name: normalizedName,
      shopType: shopType,
      address: normalizedAddress,
      phoneNumber: normalizedPhoneNumber,
      email: normalizedEmail,
      taxNumber: normalizedTaxNumber,
      isActive: isActive,
    );
  }

  static String? _optionalTrim(String? value) {
    final trimmed = value?.trim();
    return trimmed == null || trimmed.isEmpty ? null : trimmed;
  }
}

class ShopValidationException implements Exception {
  const ShopValidationException(this.message);

  final String message;

  @override
  String toString() => message;
}
