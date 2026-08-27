/// Enums in Dart 2.17+ can have fields, methods, and getters, 
/// similar to Java or C# classes.
enum CategorySyncStatus {
  synced,
  pendingCreate,
  pendingUpdate,
  pendingDelete,
  failed;

  bool get isPending => this != synced;
}

/// A Domain Entity representing a Category.
/// We use 'final' for all fields to enforce immutability, 
/// which is a core principle in Flutter's reactive UI model.
class Category {
  const Category({
    required this.id,
    required this.name,
    required this.isActive,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.syncStatus,
    this.code,
    this.description,
    this.shopId,
    this.lastSyncError,
  });

  final String id;
  final String name;
  final String? code;
  final String? description;
  final bool isActive;
  final String? shopId;
  final DateTime createdAt;
  final DateTime updatedAt;
  final DateTime lastModifiedUtc;
  final CategorySyncStatus syncStatus;
  final String? lastSyncError;
}

/// A data transfer object (DTO) used when creating or editing a category.
class CategoryDraft {
  const CategoryDraft({
    required this.name,
    required this.isActive,
    this.code,
    this.description,
  });

  final String name;
  final String? code;
  final String? description;
  final bool isActive;

  /// Performs basic validation and returns a clean version of the draft.
  /// Similar to FluentValidation or DataAnnotations in .NET.
  CategoryDraft normalized() {
    final normalizedName = name.trim();
    final normalizedCode = code?.trim();
    final normalizedDescription = description?.trim();

    if (normalizedName.isEmpty) {
      throw const CategoryValidationException('Name is required.');
    }
    // ... validation logic
    if (normalizedName.length > 200) {
      throw const CategoryValidationException(
        'Name cannot exceed 200 characters.',
      );
    }
    if (normalizedCode != null && normalizedCode.length > 50) {
      throw const CategoryValidationException(
        'Code cannot exceed 50 characters.',
      );
    }
    if (normalizedDescription != null && normalizedDescription.length > 500) {
      throw const CategoryValidationException(
        'Description cannot exceed 500 characters.',
      );
    }

    return CategoryDraft(
      name: normalizedName,
      code: normalizedCode?.isEmpty == true ? null : normalizedCode,
      description: normalizedDescription?.isEmpty == true
          ? null
          : normalizedDescription,
      isActive: isActive,
    );
  }
}

class CategoryValidationException implements Exception {
  const CategoryValidationException(this.message);

  final String message;

  @override
  String toString() => message;
}
