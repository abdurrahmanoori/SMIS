enum ProductUnitSyncStatus {
  synced,
  pendingCreate,
  pendingUpdate,
  pendingDelete,
  failed;

  bool get isPending => this != synced;
}

class ProductUnit {
  const ProductUnit({
    required this.id,
    required this.productId,
    required this.unitOfMeasureId,
    required this.conversionFactor,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.syncStatus,
    this.lastSyncError,
  });

  final String id;
  final String productId;
  final String unitOfMeasureId;
  final double conversionFactor;
  final DateTime createdAt;
  final DateTime updatedAt;
  final DateTime lastModifiedUtc;
  final ProductUnitSyncStatus syncStatus;
  final String? lastSyncError;
}

class ProductUnitDraft {
  const ProductUnitDraft({
    required this.productId,
    required this.unitOfMeasureId,
    required this.conversionFactor,
  });

  final String productId;
  final String unitOfMeasureId;
  final double conversionFactor;

  ProductUnitDraft normalized() {
    final productId = this.productId.trim();
    final unitId = unitOfMeasureId.trim();
    if (productId.isEmpty) {
      throw const ProductUnitValidationException('Select a product.');
    }
    if (unitId.isEmpty) {
      throw const ProductUnitValidationException(
        'Select a unit of measurement.',
      );
    }
    if (!conversionFactor.isFinite || conversionFactor <= 0) {
      throw const ProductUnitValidationException(
        'Conversion factor must be greater than zero.',
      );
    }
    if ((conversionFactor * 100).roundToDouble() != conversionFactor * 100) {
      throw const ProductUnitValidationException(
        'Conversion factor can have at most two decimal places.',
      );
    }
    return ProductUnitDraft(
      productId: productId,
      unitOfMeasureId: unitId,
      conversionFactor: conversionFactor,
    );
  }
}

class ProductUnitValidationException implements Exception {
  const ProductUnitValidationException(this.message);

  final String message;

  @override
  String toString() => message;
}
