enum UnitOfMeasureSyncStatus {
  synced,
  pendingCreate,
  pendingUpdate,
  pendingDelete,
  failed;

  bool get isPending => this != synced;
}

class UnitOfMeasure {
  const UnitOfMeasure({
    required this.id,
    required this.name,
    required this.symbol,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.syncStatus,
    this.description,
    this.shopId,
    this.lastSyncError,
  });

  final String id;
  final String name;
  final String symbol;
  final String? description;
  final String? shopId;
  final DateTime createdAt;
  final DateTime updatedAt;
  final DateTime lastModifiedUtc;
  final UnitOfMeasureSyncStatus syncStatus;
  final String? lastSyncError;
}

class UnitOfMeasureDraft {
  const UnitOfMeasureDraft({
    required this.name,
    required this.symbol,
    this.description,
  });

  final String name;
  final String symbol;
  final String? description;

  UnitOfMeasureDraft normalized() {
    final normalizedName = name.trim();
    final normalizedSymbol = symbol.trim();
    final normalizedDescription = description?.trim();

    if (normalizedName.isEmpty) {
      throw const UnitOfMeasureValidationException('Name is required.');
    }
    if (normalizedName.length > 100) {
      throw const UnitOfMeasureValidationException(
        'Name cannot exceed 100 characters.',
      );
    }
    if (normalizedSymbol.isEmpty) {
      throw const UnitOfMeasureValidationException('Symbol is required.');
    }
    if (normalizedSymbol.length > 20) {
      throw const UnitOfMeasureValidationException(
        'Symbol cannot exceed 20 characters.',
      );
    }
    if (normalizedDescription != null && normalizedDescription.length > 500) {
      throw const UnitOfMeasureValidationException(
        'Description cannot exceed 500 characters.',
      );
    }

    return UnitOfMeasureDraft(
      name: normalizedName,
      symbol: normalizedSymbol,
      description: normalizedDescription?.isEmpty == true
          ? null
          : normalizedDescription,
    );
  }
}

class UnitOfMeasureValidationException implements Exception {
  const UnitOfMeasureValidationException(this.message);

  final String message;

  @override
  String toString() => message;
}
