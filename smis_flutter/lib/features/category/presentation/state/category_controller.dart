import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../../data/sync/category_sync_service.dart';
import '../../domain/entities/category.dart';
import '../../domain/usecases/category_use_cases.dart';
import '../providers/category_providers.dart';

/// Represents the data state of the Category screen.
/// In Flutter, we prefer Immutable classes. Instead of modifying properties, 
/// we create a new instance with updated values using [copyWith].
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

  /// Helper method to create a new state based on the current one.
  /// This is similar to record types in C# 9.0+.
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

/// The Controller (similar to a ViewModel in MVVM or a Bloc).
/// It inherits from [AsyncNotifier] which handles asynchronous state (Loading, Error, Data) automatically.
class CategoryController extends AsyncNotifier<CategoryScreenState> {
  /// Accessing other providers. 
  /// ref.read() is used inside methods to get the current value of a provider.
  CategoryUseCases get _useCases => ref.read(categoryUseCasesProvider);
  CategorySyncService get _syncService => ref.read(categorySyncServiceProvider);

  /// The [build] method is the entry point. It defines the initial state.
  /// If it returns a Future, the state will initially be [AsyncLoading].
  @override
  Future<CategoryScreenState> build() => _load();

  /// Manually refreshing the state.
  /// We update [state] which is a built-in property of Notifiers.
  /// Assigning to [state] automatically notifies all UI listeners.
  Future<void> reload() async {
    final previous = state.value;
    try {
      final loaded = await _load(lastSyncResult: previous?.lastSyncResult);
      state = AsyncData(loaded);
    } catch (error, stackTrace) {
      // AsyncError helps the UI show error widgets automatically.
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
    // Temporarily set isSyncing to true while keeping existing data.
    state = AsyncData(current.copyWith(isSyncing: true));
    
    final result = await _syncService.synchronize(force: true);
    
    // Refresh fully after sync completes.
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
