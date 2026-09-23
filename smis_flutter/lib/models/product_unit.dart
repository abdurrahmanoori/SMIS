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
    required this.baseUnitQuantity,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.syncStatus,
    this.lastSyncError,
  });

  final String id;
  final String productId;
  final String unitOfMeasureId;
  final double baseUnitQuantity;
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
    required this.baseUnitQuantity,
  });

  final String productId;
  final String unitOfMeasureId;
  final double baseUnitQuantity;

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
    if (!baseUnitQuantity.isFinite || baseUnitQuantity <= 0) {
      throw const ProductUnitValidationException(
        'Base unit quantity must be greater than zero.',
      );
    }
    if ((baseUnitQuantity * 100).roundToDouble() != baseUnitQuantity * 100) {
      throw const ProductUnitValidationException(
        'Base unit quantity can have at most two decimal places.',
      );
    }
    return ProductUnitDraft(
      productId: productId,
      unitOfMeasureId: unitId,
      baseUnitQuantity: baseUnitQuantity,
    );
  }
}

class ProductUnitValidationException implements Exception {
  const ProductUnitValidationException(this.message);

  final String message;

  @override
  String toString() => message;
}
