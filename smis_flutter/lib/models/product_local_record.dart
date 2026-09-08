import 'product.dart';

enum ProductPendingOperation { none, create, update, delete }

class ProductLocalRecord {
  const ProductLocalRecord({
    required this.id,
    required this.name,
    required this.baseUnitId,
    required this.isActive,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.isDeleted,
    required this.pendingOperation,
    required this.syncStatus,
    required this.retryCount,
    this.sku,
    this.description,
    this.barcode,
    this.imageUrl,
    this.categoryId,
    this.shopId,
    this.nextRetryAt,
    this.lastSyncError,
    this.serverCreatedDate,
    this.serverUpdatedDate,
    this.serverCreatedBy,
    this.serverUpdatedBy,
    this.serverLastModifiedUtc,
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
  final bool isDeleted;
  final ProductPendingOperation pendingOperation;
  final ProductSyncStatus syncStatus;
  final int retryCount;
  final DateTime? nextRetryAt;
  final String? lastSyncError;
  final DateTime? serverCreatedDate;
  final DateTime? serverUpdatedDate;
  final String? serverCreatedBy;
  final String? serverUpdatedBy;
  final DateTime? serverLastModifiedUtc;

  Product toProduct() => Product(
    id: id,
    name: name,
    baseUnitId: baseUnitId,
    sku: sku,
    description: description,
    isActive: isActive,
    barcode: barcode,
    imageUrl: imageUrl,
    categoryId: categoryId,
    shopId: shopId,
    createdAt: createdAt,
    updatedAt: updatedAt,
    lastModifiedUtc: lastModifiedUtc,
    syncStatus: syncStatus,
    lastSyncError: lastSyncError,
  );

  ProductLocalRecord copyWith({
    String? name,
    String? baseUnitId,
    String? sku,
    bool clearSku = false,
    String? description,
    bool clearDescription = false,
    bool? isActive,
    String? barcode,
    bool clearBarcode = false,
    String? imageUrl,
    bool clearImageUrl = false,
    String? categoryId,
    bool clearCategoryId = false,
    String? shopId,
    DateTime? updatedAt,
    DateTime? lastModifiedUtc,
    bool? isDeleted,
    ProductPendingOperation? pendingOperation,
    ProductSyncStatus? syncStatus,
    int? retryCount,
    DateTime? nextRetryAt,
    bool clearNextRetryAt = false,
    String? lastSyncError,
    bool clearLastSyncError = false,
    DateTime? serverCreatedDate,
    DateTime? serverUpdatedDate,
    String? serverCreatedBy,
    String? serverUpdatedBy,
    DateTime? serverLastModifiedUtc,
  }) => ProductLocalRecord(
    id: id,
    name: name ?? this.name,
    baseUnitId: baseUnitId ?? this.baseUnitId,
    sku: clearSku ? null : sku ?? this.sku,
    description: clearDescription ? null : description ?? this.description,
    isActive: isActive ?? this.isActive,
    barcode: clearBarcode ? null : barcode ?? this.barcode,
    imageUrl: clearImageUrl ? null : imageUrl ?? this.imageUrl,
    categoryId: clearCategoryId ? null : categoryId ?? this.categoryId,
    shopId: shopId ?? this.shopId,
    createdAt: createdAt,
    updatedAt: updatedAt ?? this.updatedAt,
    lastModifiedUtc: lastModifiedUtc ?? this.lastModifiedUtc,
    isDeleted: isDeleted ?? this.isDeleted,
    pendingOperation: pendingOperation ?? this.pendingOperation,
    syncStatus: syncStatus ?? this.syncStatus,
    retryCount: retryCount ?? this.retryCount,
    nextRetryAt: clearNextRetryAt ? null : nextRetryAt ?? this.nextRetryAt,
    lastSyncError: clearLastSyncError ? null : lastSyncError ?? this.lastSyncError,
    serverCreatedDate: serverCreatedDate ?? this.serverCreatedDate,
    serverUpdatedDate: serverUpdatedDate ?? this.serverUpdatedDate,
    serverCreatedBy: serverCreatedBy ?? this.serverCreatedBy,
    serverUpdatedBy: serverUpdatedBy ?? this.serverUpdatedBy,
    serverLastModifiedUtc: serverLastModifiedUtc ?? this.serverLastModifiedUtc,
  );

  Map<String, Object?> toMap() => {
    'id': id,
    'name': name,
    'base_unit_id': baseUnitId,
    'sku': sku,
    'description': description,
    'is_active': isActive ? 1 : 0,
    'barcode': barcode,
    'image_url': imageUrl,
    'category_id': categoryId,
    'shop_id': shopId,
    'created_at': createdAt.toUtc().toIso8601String(),
    'updated_at': updatedAt.toUtc().toIso8601String(),
    'last_modified_utc': lastModifiedUtc.toUtc().toIso8601String(),
    'is_deleted': isDeleted ? 1 : 0,
    'pending_operation': pendingOperation.name,
    'sync_status': syncStatus.name,
    'retry_count': retryCount,
    'next_retry_at': nextRetryAt?.toUtc().toIso8601String(),
    'last_sync_error': lastSyncError,
    'server_created_date': serverCreatedDate?.toUtc().toIso8601String(),
    'server_updated_date': serverUpdatedDate?.toUtc().toIso8601String(),
    'server_created_by': serverCreatedBy,
    'server_updated_by': serverUpdatedBy,
    'server_last_modified_utc': serverLastModifiedUtc?.toUtc().toIso8601String(),
  };

  factory ProductLocalRecord.fromMap(Map<String, Object?> map) => ProductLocalRecord(
    id: map['id']! as String,
    name: map['name']! as String,
    baseUnitId: map['base_unit_id']! as String,
    sku: map['sku'] as String?,
    description: map['description'] as String?,
    isActive: map['is_active'] == 1,
    barcode: map['barcode'] as String?,
    imageUrl: map['image_url'] as String?,
    categoryId: map['category_id'] as String?,
    shopId: map['shop_id'] as String?,
    createdAt: DateTime.parse(map['created_at']! as String).toUtc(),
    updatedAt: DateTime.parse(map['updated_at']! as String).toUtc(),
    lastModifiedUtc: DateTime.parse(map['last_modified_utc']! as String).toUtc(),
    isDeleted: map['is_deleted'] == 1,
    pendingOperation: ProductPendingOperation.values.byName(map['pending_operation']! as String),
    syncStatus: ProductSyncStatus.values.byName(map['sync_status']! as String),
    retryCount: map['retry_count']! as int,
    nextRetryAt: _optionalDate(map['next_retry_at']),
    lastSyncError: map['last_sync_error'] as String?,
    serverCreatedDate: _optionalDate(map['server_created_date']),
    serverUpdatedDate: _optionalDate(map['server_updated_date']),
    serverCreatedBy: map['server_created_by'] as String?,
    serverUpdatedBy: map['server_updated_by'] as String?,
    serverLastModifiedUtc: _optionalDate(map['server_last_modified_utc']),
  );

  static DateTime? _optionalDate(Object? value) =>
      value == null ? null : DateTime.parse(value as String).toUtc();
}
