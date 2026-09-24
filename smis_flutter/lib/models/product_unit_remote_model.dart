import 'product_unit_local_record.dart';

class ProductUnitRemoteModel {
  const ProductUnitRemoteModel({
    required this.id,
    required this.productId,
    required this.unitOfMeasureId,
    required this.baseUnitQuantity,
    required this.lastModifiedUtc,
    required this.isDeleted,
    this.clientModifiedDate,
    this.createdDate,
    this.updatedDate,
    this.createdBy,
    this.updatedBy,
  });

  final String id;
  final String productId;
  final String unitOfMeasureId;
  final double baseUnitQuantity;
  final DateTime lastModifiedUtc;
  final bool isDeleted;
  final DateTime? clientModifiedDate;
  final DateTime? createdDate;
  final DateTime? updatedDate;
  final String? createdBy;
  final String? updatedBy;

  factory ProductUnitRemoteModel.fromJson(Map<String, dynamic> json) {
    final lastModifiedUtc = DateTime.parse(
      json['lastModifiedUtc'] as String,
    ).toUtc();
    final clientModifiedDate = _dateOrNull(json['clientModifiedDate']);
    final updatedDate = _dateOrNull(json['updatedDate']);
    final createdDate = _dateOrNull(json['createdDate']);
    return ProductUnitRemoteModel(
      id: json['id'] as String,
      productId: json['productId'] as String,
      unitOfMeasureId: json['unitOfMeasureId'] as String,
      baseUnitQuantity: (json['baseUnitQuantity'] as num).toDouble(),
      lastModifiedUtc: lastModifiedUtc,
      isDeleted: json['isDeleted'] as bool? ?? false,
      clientModifiedDate: clientModifiedDate,
      createdDate: createdDate,
      updatedDate: updatedDate,
      createdBy: json['createdBy'] as String?,
      updatedBy: json['updatedBy'] as String?,
    );
  }

  static Map<String, Object?> createPayload(ProductUnitLocalRecord record) => {
    'id': record.id,
    ...updatePayload(record),
  };

  static Map<String, Object?> updatePayload(ProductUnitLocalRecord record) => {
    'productId': record.productId,
    'unitOfMeasureId': record.unitOfMeasureId,
    'baseUnitQuantity': record.baseUnitQuantity,
    'clientModifiedDate': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static Map<String, Object?> deletePayload(ProductUnitLocalRecord record) => {
    'clientModifiedDate': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static DateTime? _dateOrNull(Object? value) =>
      value == null ? null : DateTime.parse(value as String).toUtc();
}
