import '../../domain/entities/category.dart';

/// Represents the database schema for the 'categories' table.
/// In Flutter, we often separate the Domain Entity (Category) from the 
/// Persistence Model (CategoryLocalRecord) to keep domain logic clean.
enum CategoryPendingOperation { none, create, update, delete }

class CategoryLocalRecord {
  const CategoryLocalRecord({
    required this.id,
    required this.name,
    required this.isActive,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.isDeleted,
    required this.pendingOperation,
    required this.syncStatus,
    required this.retryCount,
    this.code,
    this.description,
    this.shopId,
    this.nextRetryAt,
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
  final bool isDeleted;
  final CategoryPendingOperation pendingOperation;
  final CategorySyncStatus syncStatus;
  final int retryCount;
  final DateTime? nextRetryAt;
  final String? lastSyncError;

  /// Map this record back to the Domain Entity used by the UI.
  Category toDomain() => Category(
    id: id,
    name: name,
    code: code,
    description: description,
    isActive: isActive,
    shopId: shopId,
    createdAt: createdAt,
    updatedAt: updatedAt,
    lastModifiedUtc: lastModifiedUtc,
    syncStatus: syncStatus,
    lastSyncError: lastSyncError,
  );

  /// Standard 'copyWith' for immutability.
  /// Note the 'clear' flags: since Dart 3, this is how we explicitly set 
  /// optional fields to null (because a null argument would mean "don't change").
  CategoryLocalRecord copyWith({
    String? name,
    String? code,
    bool clearCode = false,
    String? description,
    bool clearDescription = false,
    bool? isActive,
    String? shopId,
    DateTime? updatedAt,
    DateTime? lastModifiedUtc,
    bool? isDeleted,
    CategoryPendingOperation? pendingOperation,
    CategorySyncStatus? syncStatus,
    int? retryCount,
    DateTime? nextRetryAt,
    bool clearNextRetryAt = false,
    String? lastSyncError,
    bool clearLastSyncError = false,
  }) => CategoryLocalRecord(
    id: id,
    name: name ?? this.name,
    code: clearCode ? null : code ?? this.code,
    description: clearDescription ? null : description ?? this.description,
    isActive: isActive ?? this.isActive,
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
  );

  /// Converts the record to a Map for sqflite.
  /// Similar to how you might use DTOs with Dapper in .NET.
  Map<String, Object?> toMap() => {
    'id': id,
    'name': name,
    'code': code,
    'description': description,
    'is_active': isActive ? 1 : 0, // sqflite doesn't have a boolean type, so we use 0/1.
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
  };

  /// Factory constructor to create a record from a database row.
  factory CategoryLocalRecord.fromMap(Map<String, Object?> map) =>
      CategoryLocalRecord(
        id: map['id']! as String,
        name: map['name']! as String,
        code: map['code'] as String?,
        description: map['description'] as String?,
        isActive: map['is_active'] == 1,
        shopId: map['shop_id'] as String?,
        createdAt: DateTime.parse(map['created_at']! as String).toUtc(),
        updatedAt: DateTime.parse(map['updated_at']! as String).toUtc(),
        lastModifiedUtc: DateTime.parse(
          map['last_modified_utc']! as String,
        ).toUtc(),
        isDeleted: map['is_deleted'] == 1,
        // Enums can be easily parsed from strings using .byName()
        pendingOperation: CategoryPendingOperation.values.byName(
          map['pending_operation']! as String,
        ),
        syncStatus: CategorySyncStatus.values.byName(
          map['sync_status']! as String,
        ),
        retryCount: map['retry_count']! as int,
        nextRetryAt: map['next_retry_at'] == null
            ? null
            : DateTime.parse(map['next_retry_at']! as String).toUtc(),
        lastSyncError: map['last_sync_error'] as String?,
      );
}

