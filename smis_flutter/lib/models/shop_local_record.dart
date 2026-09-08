import 'shop.dart';

enum ShopPendingOperation { none, create, update, delete }

class ShopLocalRecord {
  const ShopLocalRecord({
    required this.id,
    required this.name,
    required this.shopType,
    required this.isActive,
    required this.createdAt,
    required this.updatedAt,
    required this.lastModifiedUtc,
    required this.isDeleted,
    required this.pendingOperation,
    required this.syncStatus,
    required this.retryCount,
    this.address,
    this.phoneNumber,
    this.email,
    this.taxNumber,
    this.nextRetryAt,
    this.lastSyncError,
    this.serverLastModifiedUtc,
  });

  final String id;
  final String name;
  final ShopType shopType;
  final String? address;
  final String? phoneNumber;
  final String? email;
  final String? taxNumber;
  final bool isActive;
  final DateTime createdAt;
  final DateTime updatedAt;
  final DateTime lastModifiedUtc;
  final bool isDeleted;
  final ShopPendingOperation pendingOperation;
  final ShopSyncStatus syncStatus;
  final int retryCount;
  final DateTime? nextRetryAt;
  final String? lastSyncError;
  final DateTime? serverLastModifiedUtc;

  Shop toShop() => Shop(
    id: id,
    name: name,
    shopType: shopType,
    address: address,
    phoneNumber: phoneNumber,
    email: email,
    taxNumber: taxNumber,
    isActive: isActive,
    createdAt: createdAt,
    updatedAt: updatedAt,
    lastModifiedUtc: lastModifiedUtc,
    syncStatus: syncStatus,
    lastSyncError: lastSyncError,
  );

  ShopLocalRecord copyWith({
    String? name,
    ShopType? shopType,
    String? address,
    bool clearAddress = false,
    String? phoneNumber,
    bool clearPhoneNumber = false,
    String? email,
    bool clearEmail = false,
    String? taxNumber,
    bool clearTaxNumber = false,
    bool? isActive,
    DateTime? updatedAt,
    DateTime? lastModifiedUtc,
    bool? isDeleted,
    ShopPendingOperation? pendingOperation,
    ShopSyncStatus? syncStatus,
    int? retryCount,
    DateTime? nextRetryAt,
    bool clearNextRetryAt = false,
    String? lastSyncError,
    bool clearLastSyncError = false,
    DateTime? serverLastModifiedUtc,
  }) => ShopLocalRecord(
    id: id,
    name: name ?? this.name,
    shopType: shopType ?? this.shopType,
    address: clearAddress ? null : address ?? this.address,
    phoneNumber: clearPhoneNumber ? null : phoneNumber ?? this.phoneNumber,
    email: clearEmail ? null : email ?? this.email,
    taxNumber: clearTaxNumber ? null : taxNumber ?? this.taxNumber,
    isActive: isActive ?? this.isActive,
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
    serverLastModifiedUtc:
        serverLastModifiedUtc ?? this.serverLastModifiedUtc,
  );

  Map<String, Object?> toMap() => {
    'id': id,
    'name': name,
    'shop_type': shopType.apiValue,
    'address': address,
    'phone_number': phoneNumber,
    'email': email,
    'tax_number': taxNumber,
    'is_active': isActive ? 1 : 0,
    'created_at': createdAt.toUtc().toIso8601String(),
    'updated_at': updatedAt.toUtc().toIso8601String(),
    'last_modified_utc': lastModifiedUtc.toUtc().toIso8601String(),
    'is_deleted': isDeleted ? 1 : 0,
    'pending_operation': pendingOperation.name,
    'sync_status': syncStatus.name,
    'retry_count': retryCount,
    'next_retry_at': nextRetryAt?.toUtc().toIso8601String(),
    'last_sync_error': lastSyncError,
    'server_last_modified_utc': serverLastModifiedUtc
        ?.toUtc()
        .toIso8601String(),
  };

  factory ShopLocalRecord.fromMap(Map<String, Object?> map) => ShopLocalRecord(
    id: map['id']! as String,
    name: map['name']! as String,
    shopType: ShopType.fromApiValue(map['shop_type']),
    address: map['address'] as String?,
    phoneNumber: map['phone_number'] as String?,
    email: map['email'] as String?,
    taxNumber: map['tax_number'] as String?,
    isActive: map['is_active'] == 1,
    createdAt: DateTime.parse(map['created_at']! as String).toUtc(),
    updatedAt: DateTime.parse(map['updated_at']! as String).toUtc(),
    lastModifiedUtc: DateTime.parse(
      map['last_modified_utc']! as String,
    ).toUtc(),
    isDeleted: map['is_deleted'] == 1,
    pendingOperation: ShopPendingOperation.values.byName(
      map['pending_operation']! as String,
    ),
    syncStatus: ShopSyncStatus.values.byName(map['sync_status']! as String),
    retryCount: map['retry_count']! as int,
    nextRetryAt: _optionalDate(map['next_retry_at']),
    lastSyncError: map['last_sync_error'] as String?,
    serverLastModifiedUtc: _optionalDate(map['server_last_modified_utc']),
  );

  static DateTime? _optionalDate(Object? value) =>
      value == null ? null : DateTime.parse(value as String).toUtc();
}
