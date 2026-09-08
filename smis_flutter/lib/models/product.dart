enum ProductSyncStatus {
  synced,
  pendingCreate,
  pendingUpdate,
  pendingDelete,
  failed;

  bool get isPending => this != synced;
}

class Product {
  const Product({
    required this.id,
    required this.name,
    required this.baseUnitId,
    required this.isActive,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.syncStatus,
    this.sku,
    this.description,
    this.barcode,
    this.imageUrl,
    this.categoryId,
    this.shopId,
    this.lastSyncError,
  });

  final String id;
  final String name;
  final String baseUnitId;
  final String? sku;
  final String? description;
  final bool isActive;
  final String? barcode;
  final String? imageUrl;
  final String? categoryId;
  final String? shopId;
  final DateTime createdAt;
  final DateTime updatedAt;
  final DateTime lastModifiedUtc;
  final ProductSyncStatus syncStatus;
  final String? lastSyncError;
}

class ProductDraft {
  const ProductDraft({
    required this.name,
    required this.baseUnitId,
    required this.isActive,
    this.sku,
    this.description,
    this.barcode,
    this.imageUrl,
    this.categoryId,
  });

  final String name;
  final String baseUnitId;
  final String? sku;
  final String? description;
  final bool isActive;
  final String? barcode;
  final String? imageUrl;
  final String? categoryId;

  ProductDraft normalized() {
    final normalizedName = name.trim();
    final normalizedBaseUnitId = baseUnitId.trim();
    final normalizedSku = sku?.trim();
    final normalizedDescription = description?.trim();
    final normalizedBarcode = barcode?.trim();
    final normalizedImageUrl = imageUrl?.trim();
    final normalizedCategoryId = categoryId?.trim();

    if (normalizedName.isEmpty) {
      throw const ProductValidationException('Name is required.');
    }
    if (normalizedName.length > 200) {
      throw const ProductValidationException('Name cannot exceed 200 characters.');
    }
    if (normalizedBaseUnitId.isEmpty) {
      throw const ProductValidationException('Select a base unit.');
    }
    if (normalizedBaseUnitId.length > 450) {
      throw const ProductValidationException('Base unit ID cannot exceed 450 characters.');
    }
    if (normalizedDescription != null && normalizedDescription.length > 500) {
      throw const ProductValidationException('Description cannot exceed 500 characters.');
    }
    if (normalizedSku != null && normalizedSku.length > 100) {
      throw const ProductValidationException('SKU cannot exceed 100 characters.');
    }
    if (normalizedBarcode != null && normalizedBarcode.length > 100) {
      throw const ProductValidationException('Barcode cannot exceed 100 characters.');
    }
    if (normalizedImageUrl != null && normalizedImageUrl.length > 500) {
      throw const ProductValidationException('Image URL cannot exceed 500 characters.');
    }
    if (normalizedCategoryId != null && normalizedCategoryId.length > 450) {
      throw const ProductValidationException('Category ID cannot exceed 450 characters.');
    }

    return ProductDraft(
      name: normalizedName,
      baseUnitId: normalizedBaseUnitId,
      sku: _emptyToNull(normalizedSku),
      description: _emptyToNull(normalizedDescription),
      isActive: isActive,
      barcode: _emptyToNull(normalizedBarcode),
      imageUrl: _emptyToNull(normalizedImageUrl),
      categoryId: _emptyToNull(normalizedCategoryId),
    );
  }

  static String? _emptyToNull(String? value) =>
      value == null || value.isEmpty ? null : value;
}

class ProductValidationException implements Exception {
  const ProductValidationException(this.message);

  final String message;

  @override
  String toString() => message;
}
