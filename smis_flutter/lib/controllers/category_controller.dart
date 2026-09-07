import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'auth_controller.dart';
import 'app_dependencies.dart';
import '../data/category_api.dart';
import '../data/category_repository.dart';
import '../models/category.dart';
import '../services/category_sync_service.dart';

export 'app_dependencies.dart';

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
  CategoryRepository get _repository => ref.read(categoryRepositoryProvider);

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
    await _repository.create(draft);
    await reload();
  }

  Future<void> updateCategory(String id, CategoryDraft draft) async {
    await _repository.update(id, draft);
    await reload();
  }

  Future<void> delete(String id) async {
    await _repository.delete(id);
    await reload();
  }

  Future<CategorySyncResult> syncNow() async {
    final current = state.value ?? await _load();
    state = AsyncData(current.copyWith(isSyncing: true));

    final result = await _syncService.synchronize(force: true);

    if (kDebugMode && !result.success) {
      debugPrint(result.messageFor(includeDiagnostics: true));
    }

    state = AsyncData(await _load(lastSyncResult: result));
    return result;
  }

  Future<CategoryScreenState> _load({
    CategorySyncResult? lastSyncResult,
    bool isSyncing = false,
  }) async => CategoryScreenState(
    categories: await _repository.getAll(),
    pendingCount: await _repository.getPendingCount(),
    isSyncing: isSyncing,
    lastSyncResult: lastSyncResult,
  );
}

final categoryRepositoryProvider = Provider<CategoryRepository>(
  (ref) => CategoryRepository(ref.watch(appDatabaseProvider)),
);

final categoryApiProvider = Provider<CategoryApi>(
  (ref) => DioCategoryApi(sessionStore: ref.watch(authSessionStoreProvider)),
);

final categorySyncServiceProvider = Provider<CategorySyncService>(
  (ref) => CategorySyncService(
    ref.watch(categoryRepositoryProvider),
    ref.watch(categoryApiProvider),
    ref.watch(connectivityProvider),
  ),
);

final categoryControllerProvider =
    AsyncNotifierProvider<CategoryController, CategoryScreenState>(
      CategoryController.new,
    );
