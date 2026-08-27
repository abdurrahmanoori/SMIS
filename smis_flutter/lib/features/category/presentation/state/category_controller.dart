import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../../data/sync/category_sync_service.dart';
import '../../domain/entities/category.dart';
import '../../domain/usecases/category_use_cases.dart';
import '../providers/category_providers.dart';

class CategoryScreenState {
  const CategoryScreenState({
    required this.categories,
    required this.pendingCount,
    this.isSyncing = false,
    this.lastSyncResult,
  });

  final List<Category> categories;
  final int pendingCount;
  final bool isSyncing;
  final CategorySyncResult? lastSyncResult;

  CategoryScreenState copyWith({
    List<Category>? categories,
    int? pendingCount,
    bool? isSyncing,
    CategorySyncResult? lastSyncResult,
  }) => CategoryScreenState(
    categories: categories ?? this.categories,
    pendingCount: pendingCount ?? this.pendingCount,
    isSyncing: isSyncing ?? this.isSyncing,
    lastSyncResult: lastSyncResult ?? this.lastSyncResult,
  );
}

class CategoryController extends AsyncNotifier<CategoryScreenState> {
  CategoryUseCases get _useCases => ref.read(categoryUseCasesProvider);
  CategorySyncService get _syncService => ref.read(categorySyncServiceProvider);

  @override
  Future<CategoryScreenState> build() => _load();

  Future<void> reload() async {
    final previous = state.value;
    try {
      final loaded = await _load(lastSyncResult: previous?.lastSyncResult);
      state = AsyncData(loaded);
    } catch (error, stackTrace) {
      state = AsyncError(error, stackTrace);
    }
  }

  Future<void> create(CategoryDraft draft) async {
    await _useCases.create(draft);
    await reload();
  }

  Future<void> updateCategory(String id, CategoryDraft draft) async {
    await _useCases.update(id, draft);
    await reload();
  }

  Future<void> delete(String id) async {
    await _useCases.delete(id);
    await reload();
  }

  Future<CategorySyncResult> syncNow() async {
    final current = state.value ?? await _load();
    state = AsyncData(current.copyWith(isSyncing: true));
    final result = await _syncService.synchronize(force: true);
    state = AsyncData(await _load(lastSyncResult: result));
    return result;
  }

  Future<CategoryScreenState> _load({
    CategorySyncResult? lastSyncResult,
    bool isSyncing = false,
  }) async => CategoryScreenState(
    categories: await _useCases.getAll(),
    pendingCount: await _useCases.getPendingCount(),
    isSyncing: isSyncing,
    lastSyncResult: lastSyncResult,
  );
}
