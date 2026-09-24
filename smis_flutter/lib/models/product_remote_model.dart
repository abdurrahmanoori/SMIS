import 'product_local_record.dart';

class ProductRemoteModel {
  const ProductRemoteModel({
    required this.id,
    required this.name,
    required this.baseUnitId,
    required this.categoryId,
    required this.isActive,
    required this.shopId,
    required this.lastModifiedUtc,
    required this.isDeleted,
    this.sku,
    this.description,
    this.barcode,
    this.imageUrl,
    this.createdDate,
    this.updatedDate,
    this.createdBy,
    this.updatedBy,
    this.clientModifiedDate,
  });

  final String id;
  final String name;
  final String baseUnitId;
  final String? sku;
  final String? description;
  final bool isActive;
  final String? barcode;
  final String? imageUrl;
  final String categoryId;
  final String shopId;
  final DateTime lastModifiedUtc;
  final bool isDeleted;
  final DateTime? createdDate;
  final DateTime? updatedDate;
  final String? createdBy;
  final String? updatedBy;
  final DateTime? clientModifiedDate;

  factory ProductRemoteModel.fromJson(Map<String, dynamic> json) {
    final lastModifiedUtc = _requiredDate(json, 'lastModifiedUtc');
    final createdDate = _optionalDate(json['createdDate']);
    final updatedDate = _optionalDate(json['updatedDate']);
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
      categoryId: json['categoryId'] as String,
      shopId: json['shopId'] as String? ?? '',
      lastModifiedUtc: lastModifiedUtc,
      isDeleted: json['isDeleted'] as bool? ?? false,
      createdDate: createdDate,
      updatedDate: updatedDate,
      createdBy: json['createdBy'] as String?,
      updatedBy: json['updatedBy'] as String?,
      clientModifiedDate: clientModifiedDate,
    );
  }

  static Map<String, Object?> createPayload(ProductLocalRecord record) => {
    'id': record.id,
    ...updatePayload(record),
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
