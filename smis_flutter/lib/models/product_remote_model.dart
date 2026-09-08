import 'product_local_record.dart';

class ProductRemoteModel {
  const ProductRemoteModel({
    required this.id,
    required this.name,
    required this.baseUnitId,
    required this.isActive,
    required this.shopId,
    required this.lastModifiedUtc,
    required this.isDeleted,
    this.sku,
    this.description,
    this.barcode,
    this.imageUrl,
    this.categoryId,
    this.createdDate,
    this.updatedDate,
    this.createdBy,
    this.updatedBy,
    this.clientCreatedDate,
    this.clientModifiedDate,
    this.clientCreatedBy,
    this.clientModifiedBy,
    DateTime? conflictModifiedUtc,
  }) : conflictModifiedUtc = conflictModifiedUtc ?? lastModifiedUtc;

  final String id;
  final String name;
  final String baseUnitId;
  final String? sku;
  final String? description;
  final bool isActive;
  final String? barcode;
  final String? imageUrl;
  final String? categoryId;
  final String shopId;
  final DateTime lastModifiedUtc;
  final bool isDeleted;
  final DateTime? createdDate;
  final DateTime? updatedDate;
  final String? createdBy;
  final String? updatedBy;
  final DateTime? clientCreatedDate;
  final DateTime? clientModifiedDate;
  final String? clientCreatedBy;
  final String? clientModifiedBy;
  final DateTime conflictModifiedUtc;

  factory ProductRemoteModel.fromJson(Map<String, dynamic> json) {
    final lastModifiedUtc = _requiredDate(json, 'lastModifiedUtc');
    final createdDate = _optionalDate(json['createdDate']);
    final updatedDate = _optionalDate(json['updatedDate']);
    final clientCreatedDate = _optionalDate(json['clientCreatedDate']);
    final clientModifiedDate = _optionalDate(json['clientModifiedDate']);
    return ProductRemoteModel(
      id: json['id'] as String,
      name: json['name'] as String,
      baseUnitId: json['baseUnitId'] as String,
      sku: json['sku'] as String?,
      description: json['description'] as String?,
      isActive: json['isActive'] as bool? ?? true,
      barcode: json['barcode'] as String?,
      imageUrl: json['imageUrl'] as String?,
      categoryId: json['categoryId'] as String?,
      shopId: json['shopId'] as String? ?? '',
      lastModifiedUtc: lastModifiedUtc,
      isDeleted: json['isDeleted'] as bool? ?? false,
      createdDate: createdDate,
      updatedDate: updatedDate,
      createdBy: json['createdBy'] as String?,
      updatedBy: json['updatedBy'] as String?,
      clientCreatedDate: clientCreatedDate,
      clientModifiedDate: clientModifiedDate,
      clientCreatedBy: json['clientCreatedBy'] as String?,
      clientModifiedBy: json['clientModifiedBy'] as String?,
      conflictModifiedUtc: _optionalDate(json['conflictModifiedUtc']) ??
          clientModifiedDate ?? updatedDate ?? clientCreatedDate ?? createdDate ?? lastModifiedUtc,
    );
  }

  static Map<String, Object?> createPayload(ProductLocalRecord record) => {
    'id': record.id,
    ...updatePayload(record),
    'clientCreatedDate': record.createdAt.toUtc().toIso8601String(),
  };

  static Map<String, Object?> updatePayload(ProductLocalRecord record) => {
    'name': record.name,
    'baseUnitId': record.baseUnitId,
    'description': record.description,
    'isActive': record.isActive,
    'sku': record.sku,
    'barcode': record.barcode,
    'imageUrl': record.imageUrl,
    'categoryId': record.categoryId,
    'clientModifiedDate': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static Map<String, Object?> deletePayload(ProductLocalRecord record) => {
    'clientModifiedDate': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static DateTime _requiredDate(Map<String, dynamic> json, String key) =>
      DateTime.parse(json[key] as String).toUtc();
  static DateTime? _optionalDate(Object? value) =>
      value == null ? null : DateTime.parse(value as String).toUtc();
}
