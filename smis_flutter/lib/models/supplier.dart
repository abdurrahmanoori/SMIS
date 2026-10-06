enum SupplierSyncStatus {
  synced,
  pendingCreate,
  pendingUpdate,
  failed;

  bool get isPending => this != synced;
}

class Supplier {
  const Supplier({
    required this.id,
    required this.shopId,
    required this.name,
    required this.isActive,
    required this.lastModifiedUtc,
    required this.syncStatus,
    this.phoneNumber,
    this.notes,
    this.lastSyncError,
  });

  final String id;
  final String shopId;
  final String name;
  final String? phoneNumber;
  final String? notes;
  final bool isActive;
  final DateTime lastModifiedUtc;
  final SupplierSyncStatus syncStatus;
  final String? lastSyncError;
}

class SupplierDraft {
  const SupplierDraft({
    required this.name,
    required this.isActive,
    this.phoneNumber,
    this.notes,
  });

  final String name;
  final String? phoneNumber;
  final String? notes;
  final bool isActive;

  SupplierDraft normalized() {
    final normalizedName = name.trim();
    final normalizedPhone = phoneNumber?.trim();
    final normalizedNotes = notes?.trim();

    if (normalizedName.isEmpty) {
      throw const SupplierValidationException('Name is required.');
    }
    if (normalizedName.length > 200) {
      throw const SupplierValidationException(
        'Name must not exceed 200 characters.',
      );
    }
    if (normalizedPhone != null && normalizedPhone.length > 50) {
      throw const SupplierValidationException(
        'Phone number must not exceed 50 characters.',
      );
    }
    if (normalizedNotes != null && normalizedNotes.length > 500) {
      throw const SupplierValidationException(
        'Notes must not exceed 500 characters.',
      );
    }

    return SupplierDraft(
      name: normalizedName,
      phoneNumber: normalizedPhone?.isEmpty == true ? null : normalizedPhone,
      notes: normalizedNotes?.isEmpty == true ? null : normalizedNotes,
      isActive: isActive,
    );
  }
}

class SupplierValidationException implements Exception {
  const SupplierValidationException(this.message);

  final String message;

  @override
  String toString() => message;
}
