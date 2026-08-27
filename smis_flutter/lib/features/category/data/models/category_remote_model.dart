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
  });

  final String id;
  final String name;
  final String? code;
  final String? description;
  final bool isActive;
  final String shopId;
  final DateTime lastModifiedUtc;
  final bool isDeleted;

  factory CategoryRemoteModel.fromJson(Map<String, dynamic> json) =>
      CategoryRemoteModel(
        id: json['id'] as String,
        name: json['name'] as String,
        code: json['code'] as String?,
        description: json['description'] as String?,
        isActive: json['isActive'] as bool? ?? true,
        shopId: json['shopId'] as String? ?? '',
        lastModifiedUtc: DateTime.parse(
          json['lastModifiedUtc'] as String,
        ).toUtc(),
        isDeleted: json['isDeleted'] as bool? ?? false,
      );

  static Map<String, Object?> createPayload(CategoryLocalRecord record) => {
    'id': record.id,
    'name': record.name,
    'code': record.code,
    'description': record.description,
    'isActive': record.isActive,
    'createdDate': record.createdAt.toUtc().toIso8601String(),
    'lastModifiedUtc': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static Map<String, Object?> updatePayload(CategoryLocalRecord record) => {
    'name': record.name,
    'code': record.code,
    'description': record.description,
    'isActive': record.isActive,
    'updatedDate': record.updatedAt.toUtc().toIso8601String(),
    'lastModifiedUtc': record.lastModifiedUtc.toUtc().toIso8601String(),
  };
}
