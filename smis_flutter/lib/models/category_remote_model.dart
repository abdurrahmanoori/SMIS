import 'category_local_record.dart';

class CategoryRemoteModel {
  const CategoryRemoteModel({
    required this.id,
    required this.name,
    required this.isActive,
    required this.shopId,
    required this.lastModifiedUtc,
    required this.isDeleted,
    this.code,
    this.description,
    this.createdDate,
    this.updatedDate,
    this.createdBy,
    this.updatedBy,
    this.clientModifiedDate,
  });

  final String id;
  final String name;
  final String? code;
  final String? description;
  final bool isActive;
  final String shopId;
  final DateTime lastModifiedUtc;
  final bool isDeleted;
  final DateTime? createdDate;
  final DateTime? updatedDate;
  final String? createdBy;
  final String? updatedBy;
  final DateTime? clientModifiedDate;

  factory CategoryRemoteModel.fromJson(Map<String, dynamic> json) {
    final lastModifiedUtc = _requiredDate(json, 'lastModifiedUtc');
    final createdDate = _optionalDate(json['createdDate']);
    final updatedDate = _optionalDate(json['updatedDate']);
    final clientModifiedDate = _optionalDate(json['clientModifiedDate']);
    return CategoryRemoteModel(
      id: json['id'] as String,
      name: json['name'] as String,
      code: json['code'] as String?,
      description: json['description'] as String?,
      isActive: json['isActive'] as bool? ?? true,
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

  static Map<String, Object?> createPayload(CategoryLocalRecord record) => {
    'id': record.id,
    'name': record.name,
    'code': record.code,
    'description': record.description,
    'isActive': record.isActive,
    'clientModifiedDate': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static Map<String, Object?> updatePayload(CategoryLocalRecord record) => {
    'name': record.name,
    'code': record.code,
    'description': record.description,
    'isActive': record.isActive,
    'clientModifiedDate': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static Map<String, Object?> deletePayload(CategoryLocalRecord record) => {
    'clientModifiedDate': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static DateTime _requiredDate(Map<String, dynamic> json, String key) =>
      DateTime.parse(json[key] as String).toUtc();

  static DateTime? _optionalDate(Object? value) =>
      value == null ? null : DateTime.parse(value as String).toUtc();
}
