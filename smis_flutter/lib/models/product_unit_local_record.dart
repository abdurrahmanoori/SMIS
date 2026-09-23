import 'product_unit.dart';

enum ProductUnitPendingOperation { none, create, update, delete }

class ProductUnitLocalRecord {
  const ProductUnitLocalRecord({
    required this.id,
    required this.productId,
    required this.unitOfMeasureId,
    required this.baseUnitQuantity,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.isDeleted,
    required this.pendingOperation,
    required this.syncStatus,
    required this.retryCount,
    this.nextRetryAt,
    this.lastSyncError,
    this.serverCreatedDate,
    this.serverUpdatedDate,
    this.serverCreatedBy,
    this.serverUpdatedBy,
    this.serverLastModifiedUtc,
  });

  final String id;
  final String productId;
  final String unitOfMeasureId;
  final double baseUnitQuantity;
  final DateTime createdAt;
  final DateTime updatedAt;
  final DateTime lastModifiedUtc;
  final bool isDeleted;
  final ProductUnitPendingOperation pendingOperation;
  final ProductUnitSyncStatus syncStatus;
  final int retryCount;
  final DateTime? nextRetryAt;
  final String? lastSyncError;
  final DateTime? serverCreatedDate;
  final DateTime? serverUpdatedDate;
  final String? serverCreatedBy;
  final String? serverUpdatedBy;
  final DateTime? serverLastModifiedUtc;

  ProductUnit toProductUnit() => ProductUnit(
    id: id,
    productId: productId,
    unitOfMeasureId: unitOfMeasureId,
    baseUnitQuantity: baseUnitQuantity,
    createdAt: createdAt,
    updatedAt: updatedAt,
    lastModifiedUtc: lastModifiedUtc,
    syncStatus: syncStatus,
    lastSyncError: lastSyncError,
  );

  ProductUnitLocalRecord copyWith({
    String? productId,
    String? unitOfMeasureId,
    double? baseUnitQuantity,
    DateTime? updatedAt,
    DateTime? lastModifiedUtc,
    bool? isDeleted,
    ProductUnitPendingOperation? pendingOperation,
    ProductUnitSyncStatus? syncStatus,
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
  }) => ProductUnitLocalRecord(
    id: id,
    productId: productId ?? this.productId,
    unitOfMeasureId: unitOfMeasureId ?? this.unitOfMeasureId,
    baseUnitQuantity: baseUnitQuantity ?? this.baseUnitQuantity,
    createdAt: createdAt,
    updatedAt: updatedAt ?? this.updatedAt,
    lastModifiedUtc: lastModifiedUtc ?? this.lastModifiedUtc,
    isDeleted: isDeleted ?? this.isDeleted,
    pendingOperation: pendingOperation ?? this.pendingOperation,
    syncStatus: syncStatus ?? this.syncStatus,
    retryCount: retryCount ?? this.retryCount,
    nextRetryAt: clearNextRetryAt ? null : nextRetryAt ?? this.nextRetryAt,
    lastSyncError: clearLastSyncError
        ? null
        : lastSyncError ?? this.lastSyncError,
    serverCreatedDate: serverCreatedDate ?? this.serverCreatedDate,
    serverUpdatedDate: serverUpdatedDate ?? this.serverUpdatedDate,
    serverCreatedBy: serverCreatedBy ?? this.serverCreatedBy,
    serverUpdatedBy: serverUpdatedBy ?? this.serverUpdatedBy,
    serverLastModifiedUtc: serverLastModifiedUtc ?? this.serverLastModifiedUtc,
  );

  Map<String, Object?> toMap() => {
    'id': id,
    'product_id': productId,
    'unit_of_measure_id': unitOfMeasureId,
    'base_unit_quantity': baseUnitQuantity,
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
    'server_last_modified_utc': serverLastModifiedUtc
        ?.toUtc()
        .toIso8601String(),
  };

  factory ProductUnitLocalRecord.fromMap(Map<String, Object?> map) =>
      ProductUnitLocalRecord(
        id: map['id']! as String,
        productId: map['product_id']! as String,
        unitOfMeasureId: map['unit_of_measure_id']! as String,
        baseUnitQuantity: (map['base_unit_quantity']! as num).toDouble(),
        createdAt: DateTime.parse(map['created_at']! as String).toUtc(),
        updatedAt: DateTime.parse(map['updated_at']! as String).toUtc(),
        lastModifiedUtc: DateTime.parse(
          map['last_modified_utc']! as String,
        ).toUtc(),
        isDeleted: map['is_deleted'] == 1,
        pendingOperation: ProductUnitPendingOperation.values.byName(
          map['pending_operation']! as String,
        ),
        syncStatus: ProductUnitSyncStatus.values.byName(
          map['sync_status']! as String,
        ),
        retryCount: map['retry_count']! as int,
        nextRetryAt: _dateOrNull(map['next_retry_at']),
        lastSyncError: map['last_sync_error'] as String?,
        serverCreatedDate: _dateOrNull(map['server_created_date']),
        serverUpdatedDate: _dateOrNull(map['server_updated_date']),
        serverCreatedBy: map['server_created_by'] as String?,
        serverUpdatedBy: map['server_updated_by'] as String?,
        serverLastModifiedUtc: _dateOrNull(map['server_last_modified_utc']),
      );

  static DateTime? _dateOrNull(Object? value) =>
      value == null ? null : DateTime.parse(value as String).toUtc();
}
