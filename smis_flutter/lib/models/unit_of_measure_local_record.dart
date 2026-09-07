import 'unit_of_measure.dart';

enum UnitOfMeasurePendingOperation { none, create, update, delete }

class UnitOfMeasureLocalRecord {
  const UnitOfMeasureLocalRecord({
    required this.id,
    required this.name,
    required this.symbol,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.isDeleted,
    required this.pendingOperation,
    required this.syncStatus,
    required this.retryCount,
    this.description,
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
  final String symbol;
  final String? description;
  final String? shopId;
  final DateTime createdAt;
  final DateTime updatedAt;
  final DateTime lastModifiedUtc;
  final bool isDeleted;
  final UnitOfMeasurePendingOperation pendingOperation;
  final UnitOfMeasureSyncStatus syncStatus;
  final int retryCount;
  final DateTime? nextRetryAt;
  final String? lastSyncError;
  final DateTime? serverCreatedDate;
  final DateTime? serverUpdatedDate;
  final String? serverCreatedBy;
  final String? serverUpdatedBy;
  final DateTime? serverLastModifiedUtc;

  UnitOfMeasure toUnitOfMeasure() => UnitOfMeasure(
    id: id,
    name: name,
    symbol: symbol,
    description: description,
    shopId: shopId,
    createdAt: createdAt,
    updatedAt: updatedAt,
    lastModifiedUtc: lastModifiedUtc,
    syncStatus: syncStatus,
    lastSyncError: lastSyncError,
  );

  UnitOfMeasureLocalRecord copyWith({
    String? name,
    String? symbol,
    String? description,
    bool clearDescription = false,
    String? shopId,
    DateTime? updatedAt,
    DateTime? lastModifiedUtc,
    bool? isDeleted,
    UnitOfMeasurePendingOperation? pendingOperation,
    UnitOfMeasureSyncStatus? syncStatus,
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
  }) => UnitOfMeasureLocalRecord(
    id: id,
    name: name ?? this.name,
    symbol: symbol ?? this.symbol,
    description: clearDescription ? null : description ?? this.description,
    shopId: shopId ?? this.shopId,
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
    'name': name,
    'symbol': symbol,
    'description': description,
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
    'server_last_modified_utc': serverLastModifiedUtc
        ?.toUtc()
        .toIso8601String(),
  };

  factory UnitOfMeasureLocalRecord.fromMap(Map<String, Object?> map) =>
      UnitOfMeasureLocalRecord(
        id: map['id']! as String,
        name: map['name']! as String,
        symbol: map['symbol']! as String,
        description: map['description'] as String?,
        shopId: map['shop_id'] as String?,
        createdAt: DateTime.parse(map['created_at']! as String).toUtc(),
        updatedAt: DateTime.parse(map['updated_at']! as String).toUtc(),
        lastModifiedUtc: DateTime.parse(
          map['last_modified_utc']! as String,
        ).toUtc(),
        isDeleted: map['is_deleted'] == 1,
        pendingOperation: UnitOfMeasurePendingOperation.values.byName(
          map['pending_operation']! as String,
        ),
        syncStatus: UnitOfMeasureSyncStatus.values.byName(
          map['sync_status']! as String,
        ),
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
