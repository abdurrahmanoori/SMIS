import 'shop.dart';
import 'shop_local_record.dart';

class ShopRemoteModel {
  const ShopRemoteModel({
    required this.id,
    required this.name,
    required this.shopType,
    required this.isActive,
    required this.lastModifiedUtc,
    required this.isDeleted,
    this.address,
    this.phoneNumber,
    this.email,
    this.taxNumber,
    this.clientCreatedDate,
    this.clientCreatedBy,
    this.clientModifiedDate,
    this.clientModifiedBy,
    DateTime? conflictModifiedUtc,
  }) : conflictModifiedUtc = conflictModifiedUtc ?? lastModifiedUtc;

  final String id;
  final String name;
  final ShopType shopType;
  final String? address;
  final String? phoneNumber;
  final String? email;
  final String? taxNumber;
  final bool isActive;
  final DateTime lastModifiedUtc;
  final bool isDeleted;
  final DateTime? clientCreatedDate;
  final String? clientCreatedBy;
  final DateTime? clientModifiedDate;
  final String? clientModifiedBy;
  final DateTime conflictModifiedUtc;

  factory ShopRemoteModel.fromJson(Map<String, dynamic> json) {
    final lastModifiedUtc = _requiredDate(json, 'lastModifiedUtc');
    final clientCreatedDate = _optionalDate(json['clientCreatedDate']);
    final clientModifiedDate = _optionalDate(json['clientModifiedDate']);
    return ShopRemoteModel(
      id: json['id'] as String,
      name: json['name'] as String,
      shopType: ShopType.fromApiValue(json['shopType']),
      address: json['address'] as String?,
      phoneNumber: json['phoneNumber'] as String?,
      email: json['email'] as String?,
      taxNumber: json['taxNumber'] as String?,
      isActive: json['isActive'] as bool? ?? false,
      lastModifiedUtc: lastModifiedUtc,
      isDeleted: json['isDeleted'] as bool? ?? false,
      clientCreatedDate: clientCreatedDate,
      clientCreatedBy: json['clientCreatedBy'] as String?,
      clientModifiedDate: clientModifiedDate,
      clientModifiedBy: json['clientModifiedBy'] as String?,
      conflictModifiedUtc:
          _optionalDate(json['conflictModifiedUtc']) ??
          clientModifiedDate ??
          clientCreatedDate ??
          lastModifiedUtc,
    );
  }

  static Map<String, Object?> createPayload(ShopLocalRecord shop) => {
    'id': shop.id,
    'name': shop.name,
    'shopType': shop.shopType.apiValue,
    'address': shop.address,
    'phoneNumber': shop.phoneNumber,
    'email': shop.email,
    'taxNumber': shop.taxNumber,
    'isActive': shop.isActive,
    'clientCreatedDate': shop.createdAt.toUtc().toIso8601String(),
    'clientModifiedDate': shop.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static Map<String, Object?> updatePayload(ShopLocalRecord shop) => {
    'name': shop.name,
    'shopType': shop.shopType.apiValue,
    'address': shop.address,
    'phoneNumber': shop.phoneNumber,
    'email': shop.email,
    'taxNumber': shop.taxNumber,
    'isActive': shop.isActive,
    'clientModifiedDate': shop.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static Map<String, Object?> deletePayload(ShopLocalRecord shop) => {
    'clientModifiedDate': shop.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static DateTime _requiredDate(Map<String, dynamic> json, String key) =>
      DateTime.parse(json[key] as String).toUtc();

  static DateTime? _optionalDate(Object? value) =>
      value == null ? null : DateTime.parse(value as String).toUtc();
}
