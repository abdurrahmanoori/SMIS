enum ProductPriceSyncStatus {
  synced,
  pendingCreate,
  pendingUpdate,
  pendingDelete,
  failed;

  bool get isPending => this != synced;
}

class ProductPrice {
  const ProductPrice({
    required this.id,
    required this.productUnitId,
    required this.sellPrice,
    required this.effectiveDate,
    required this.lastModifiedUtc,
    required this.syncStatus,
    this.endDate,
    this.lastSyncError,
  });

  final String id;
  final String productUnitId;
  final int sellPrice;
  final DateTime effectiveDate;
  final DateTime? endDate;
  final DateTime lastModifiedUtc;
  final ProductPriceSyncStatus syncStatus;
  final String? lastSyncError;
}

class ProductPriceDraft {
  const ProductPriceDraft({
    required this.productUnitId,
    required this.sellPrice,
    required this.effectiveDate,
    this.endDate,
  });

  final String productUnitId;
  final int sellPrice;
  final DateTime effectiveDate;
  final DateTime? endDate;

  ProductPriceDraft normalized() {
    final productUnitId = this.productUnitId.trim();
    final effectiveDate = this.effectiveDate.toUtc();
    final endDate = this.endDate?.toUtc();

    if (productUnitId.isEmpty) {
      throw const ProductPriceValidationException('Select a product unit.');
    }
    if (sellPrice < 0) {
      throw const ProductPriceValidationException(
        'Sell price cannot be negative.',
      );
    }
    if (endDate != null && endDate.isBefore(effectiveDate)) {
      throw const ProductPriceValidationException(
        'End date cannot be before effective date.',
      );
    }

    return ProductPriceDraft(
      productUnitId: productUnitId,
      sellPrice: sellPrice,
      effectiveDate: effectiveDate,
      endDate: endDate,
    );
  }
}

class ProductPriceValidationException implements Exception {
  const ProductPriceValidationException(this.message);

  final String message;

  @override
  String toString() => message;
}
