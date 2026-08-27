import 'category_local_record.dart';

/// Represents the data structure returned by the external API.
/// In Flutter, manual JSON parsing using `fromJson` is common for smaller projects.
/// For larger projects, tools like `json_serializable` are often used.
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

  /// Creates a model from a JSON map (e.g., from a Dio response).
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

  /// Helper to create the payload for a POST request.
  static Map<String, Object?> createPayload(CategoryLocalRecord record) => {
    'id': record.id,
    'name': record.name,
    'code': record.code,
    'description': record.description,
    'isActive': record.isActive,
    'createdDate': record.createdAt.toUtc().toIso8601String(),
    'lastModifiedUtc': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  /// Helper to create the payload for a PUT request.
  static Map<String, Object?> updatePayload(CategoryLocalRecord record) => {
    'name': record.name,
    'code': record.code,
    'description': record.description,
    'isActive': record.isActive,
    'updatedDate': record.updatedAt.toUtc().toIso8601String(),
    'lastModifiedUtc': record.lastModifiedUtc.toUtc().toIso8601String(),
  };
}
