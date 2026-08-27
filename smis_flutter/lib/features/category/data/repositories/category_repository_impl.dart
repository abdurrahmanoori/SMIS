import 'package:uuid/uuid.dart';

import '../../../../core/error/app_exception.dart';
import '../../domain/entities/category.dart';
import '../../domain/repositories/category_repository.dart';
import '../datasources/category_local_data_source.dart';
import '../models/category_local_record.dart';

typedef UtcNow = DateTime Function();
typedef IdGenerator = String Function();

class CategoryRepositoryImpl implements CategoryRepository {
  CategoryRepositoryImpl(
    this._local, {
    UtcNow? utcNow,
    IdGenerator? idGenerator,
  }) : _utcNow = utcNow ?? (() => DateTime.now().toUtc()),
       _idGenerator = idGenerator ?? const Uuid().v4;

  final CategoryLocalDataSource _local;
  final UtcNow _utcNow;
  final IdGenerator _idGenerator;

  @override
  Future<List<Category>> getAll() async =>
      (await _local.getVisible()).map((record) => record.toDomain()).toList();

  @override
  Future<Category> create(CategoryDraft draft) async {
    final normalized = draft.normalized();
    final now = _utcNow();
    final record = CategoryLocalRecord(
      id: _idGenerator(),
      name: normalized.name,
      code: normalized.code,
      description: normalized.description,
      isActive: normalized.isActive,
      createdAt: now,
      updatedAt: now,
      lastModifiedUtc: now,
      isDeleted: false,
      pendingOperation: CategoryPendingOperation.create,
      syncStatus: CategorySyncStatus.pendingCreate,
      retryCount: 0,
    );
    await _local.put(record);
    return record.toDomain();
  }

  @override
  Future<Category> update(String id, CategoryDraft draft) async {
    final existing = await _local.getById(id);
    if (existing == null || existing.isDeleted) {
      throw const LocalStorageException('Category was not found.');
    }
    final normalized = draft.normalized();
    final now = _monotonicNow(existing.lastModifiedUtc);
    final remainsCreate =
        existing.pendingOperation == CategoryPendingOperation.create;
    final updated = existing.copyWith(
      name: normalized.name,
      code: normalized.code,
      clearCode: normalized.code == null,
      description: normalized.description,
      clearDescription: normalized.description == null,
      isActive: normalized.isActive,
      updatedAt: now,
      lastModifiedUtc: now,
      pendingOperation: remainsCreate
          ? CategoryPendingOperation.create
          : CategoryPendingOperation.update,
      syncStatus: remainsCreate
          ? CategorySyncStatus.pendingCreate
          : CategorySyncStatus.pendingUpdate,
      retryCount: 0,
      clearNextRetryAt: true,
      clearLastSyncError: true,
    );
    await _local.put(updated);
    return updated.toDomain();
  }

  @override
  Future<void> delete(String id) async {
    final existing = await _local.getById(id);
    if (existing == null) return;
    if (existing.pendingOperation == CategoryPendingOperation.create) {
      await _local.deletePermanently(id);
      return;
    }
    final now = _monotonicNow(existing.lastModifiedUtc);
    await _local.put(
      existing.copyWith(
        isDeleted: true,
        updatedAt: now,
        lastModifiedUtc: now,
        pendingOperation: CategoryPendingOperation.delete,
        syncStatus: CategorySyncStatus.pendingDelete,
        retryCount: 0,
        clearNextRetryAt: true,
        clearLastSyncError: true,
      ),
    );
  }

  @override
  Future<int> getPendingCount() => _local.getPendingCount();

  DateTime _monotonicNow(DateTime previous) {
    final now = _utcNow();
    return now.isAfter(previous)
        ? now
        : previous.add(const Duration(microseconds: 1));
  }
}
