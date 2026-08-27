enum CategorySyncStatus {
  synced,
  pendingCreate,
  pendingUpdate,
  pendingDelete,
  failed;

  bool get isPending => this != synced;
}

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

  CategoryDraft normalized() {
    final normalizedName = name.trim();
    final normalizedCode = code?.trim();
    final normalizedDescription = description?.trim();

    if (normalizedName.isEmpty) {
      throw const CategoryValidationException('Name is required.');
    }
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
