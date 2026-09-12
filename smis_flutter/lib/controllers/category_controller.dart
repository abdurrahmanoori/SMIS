import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'auth_controller.dart';
import 'app_dependencies.dart';
import '../data/category_api.dart';
import '../data/data_exception.dart';
import '../data/category_repository.dart';
import '../models/category.dart';
import '../services/category_sync_service.dart';

export 'app_dependencies.dart';

class CategoryScreenState {
  const CategoryScreenState({
    required this.categories,
    required this.pendingCount,
    this.pageNumber = 1,
    this.pageSize = 25,
    this.totalCount = 0,
    this.totalPages = 1,
    this.isSyncing = false,
    this.isLoadingMore = false,
    this.lastSyncResult,
  });

  final List<Category> categories;
  final int pendingCount;
  final int pageNumber;
  final int pageSize;
  final int totalCount;
  final int totalPages;
  final bool isSyncing;
  final bool isLoadingMore;
  final CategorySyncResult? lastSyncResult;

  bool get hasNextPage => pageNumber < totalPages;

  CategoryScreenState copyWith({
    List<Category>? categories,
    int? pendingCount,
    int? pageNumber,
    int? pageSize,
    int? totalCount,
    int? totalPages,
    bool? isSyncing,
    bool? isLoadingMore,
    CategorySyncResult? lastSyncResult,
  }) => CategoryScreenState(
    categories: categories ?? this.categories,
    pendingCount: pendingCount ?? this.pendingCount,
    pageNumber: pageNumber ?? this.pageNumber,
    pageSize: pageSize ?? this.pageSize,
    totalCount: totalCount ?? this.totalCount,
    totalPages: totalPages ?? this.totalPages,
    isSyncing: isSyncing ?? this.isSyncing,
    isLoadingMore: isLoadingMore ?? this.isLoadingMore,
    lastSyncResult: lastSyncResult ?? this.lastSyncResult,
  );
}

class CategoryController extends AsyncNotifier<CategoryScreenState> {
  static const _pageSize = 25;

  CategoryRepository get _repository => ref.read(categoryRepositoryProvider);

  CategorySyncService get _syncService => ref.read(categorySyncServiceProvider);

  String get _shopId {
    final session = ref.watch(authControllerProvider.select((s) => s.session));
    if (session == null) throw StateError('User is not authenticated.');
    return session.shopId;
  }

  @override
  Future<CategoryScreenState> build() {
    // Watch shopId to rebuild when switching accounts
    _shopId;
    return _load();
  }

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
    await _repository.create(draft, _shopId);
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

    final result = await _syncService.synchronize(shopId: _shopId, force: true);

    if (kDebugMode && !result.success) {
      debugPrint(result.messageFor(includeDiagnostics: true));
    }

    state = AsyncData(await _load(lastSyncResult: result));
    return result;
  }

  Future<void> loadNextPage() async {
    final current = state.value;
    if (current == null || current.isLoadingMore || !current.hasNextPage) {
      return;
    }

    state = AsyncData(current.copyWith(isLoadingMore: true));
    try {
      final page = await _syncService.refreshFromServer(
        shopId: _shopId,
        pageNumber: current.pageNumber + 1,
        pageSize: current.pageSize,
      );
      if (page == null) {
        state = AsyncData(current.copyWith(isLoadingMore: false));
        return;
      }

      state = AsyncData(
        await _readLocal(
          pageNumber: page.pageNumber,
          pageSize: page.pageSize,
          totalCount: page.totalCount > 0
              ? page.totalCount
              : current.totalCount,
          totalPages: page.totalPages > 0
              ? page.totalPages
              : current.totalPages,
          lastSyncResult: current.lastSyncResult,
        ),
      );
    } on RemoteTransientException catch (error, stackTrace) {
      if (kDebugMode) {
        debugPrint('Category page load failed: $error\n$stackTrace');
      }
      state = AsyncData(current.copyWith(isLoadingMore: false));
    } catch (error, stackTrace) {
      state = AsyncError(error, stackTrace);
    }
  }

  Future<CategoryScreenState> _load({
    CategorySyncResult? lastSyncResult,
    bool isSyncing = false,
  }) async {
    final shopId = _shopId;
    CategoryPage? page;
    try {
      page = await _syncService.refreshFromServer(
        shopId: shopId,
        pageNumber: 1,
        pageSize: _pageSize,
      );
    } on RemoteTransientException catch (error, stackTrace) {
      if (kDebugMode) {
        debugPrint('Category refresh failed: $error\n$stackTrace');
      }
    }

    return _readLocal(
      pageNumber: page?.pageNumber ?? 1,
      pageSize: page?.pageSize ?? _pageSize,
      totalCount: page?.totalCount,
      totalPages: page?.totalPages,
      lastSyncResult: lastSyncResult,
      isSyncing: isSyncing,
    );
  }

  Future<CategoryScreenState> _readLocal({
    required int pageNumber,
    required int pageSize,
    int? totalCount,
    int? totalPages,
    CategorySyncResult? lastSyncResult,
    bool isSyncing = false,
  }) async {
    final shopId = _shopId;
    final categories = await _repository.getAll(shopId);
    return CategoryScreenState(
      categories: categories,
      pendingCount: await _repository.getPendingCount(shopId),
      pageNumber: pageNumber,
      pageSize: pageSize,
      totalCount: totalCount ?? categories.length,
      totalPages: totalPages ?? 1,
      isSyncing: isSyncing,
      lastSyncResult: lastSyncResult,
    );
  }
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
