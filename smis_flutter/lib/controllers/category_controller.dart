import 'dart:async';

import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'auth_controller.dart';
import 'app_dependencies.dart';
import '../data/powersync/category_powersync_repository.dart';
import '../models/category.dart';
import '../services/category_powersync_service.dart';
import '../services/category_sync_service.dart';

export 'app_dependencies.dart';

class CategoryScreenState {
  const CategoryScreenState({
    required this.categories,
    required this.pendingCount,
    this.searchQuery = '',
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
  final String searchQuery;
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
    String? searchQuery,
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
    searchQuery: searchQuery ?? this.searchQuery,
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
  StreamSubscription<void>? _changesSubscription;
  bool _refreshingFromPowerSync = false;
  int _searchRequestId = 0;

  CategoryPowerSyncRepository get _repository =>
      ref.read(categoryRepositoryProvider);

  CategoryPowerSyncService get _syncService =>
      ref.read(categorySyncServiceProvider);

  String get _shopId {
    final session = ref.watch(authControllerProvider.select((s) => s.session));
    if (session == null) throw StateError('User is not authenticated.');
    return session.shopId;
  }

  @override
  Future<CategoryScreenState> build() async {
    final shopId = _shopId;
    await _changesSubscription?.cancel();
    final changes = await _repository.watchChanges(shopId);
    _changesSubscription = changes.skip(1).listen((_) {
      _refreshFromPowerSync();
    });
    ref.onDispose(() => _changesSubscription?.cancel());
    return _load();
  }

  Future<void> _refreshFromPowerSync() async {
    if (_refreshingFromPowerSync || !state.hasValue) return;
    _refreshingFromPowerSync = true;
    try {
      final current = state.value!;
      state = AsyncData(
        await _load(
          searchQuery: current.searchQuery,
          lastSyncResult: current.lastSyncResult,
        ),
      );
      ref.invalidate(categoryLookupProvider);
    } catch (error, stackTrace) {
      if (kDebugMode) {
        debugPrint('Category PowerSync refresh failed: $error\n$stackTrace');
      }
    } finally {
      _refreshingFromPowerSync = false;
    }
  }

  Future<void> reload() async {
    final previous = state.value;
    try {
      final loaded = await _load(
        searchQuery: previous?.searchQuery,
        lastSyncResult: previous?.lastSyncResult,
      );
      state = AsyncData(loaded);
      ref.invalidate(categoryLookupProvider);
    } catch (error, stackTrace) {
      state = AsyncError(error, stackTrace);
    }
  }

  Future<void> search(String query) async {
    final previous = state.value;
    if (previous?.searchQuery == query) return;
    final requestId = ++_searchRequestId;

    // Defer the search slightly to avoid excessive rebuilding
    state = AsyncData(
      previous?.copyWith(searchQuery: query, isLoadingMore: true) ??
          CategoryScreenState(
            categories: [],
            pendingCount: 0,
            searchQuery: query,
            isLoadingMore: true,
          ),
    );

    try {
      final loaded = await _load(searchQuery: query);
      if (requestId != _searchRequestId) return;
      state = AsyncData(loaded);
    } catch (error, stackTrace) {
      if (requestId != _searchRequestId) return;
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

  Future<int> countProductsUsingCategory(String id) =>
      _repository.countProductsUsingCategory(id);

  Future<CategorySyncResult> syncNow() async {
    final current = state.value ?? await _load();
    state = AsyncData(current.copyWith(isSyncing: true));

    final result = await _syncService.synchronize(shopId: _shopId, force: true);

    if (kDebugMode && !result.success) {
      debugPrint(result.messageFor(includeDiagnostics: true));
    }

    state = AsyncData(
      await _load(searchQuery: current.searchQuery, lastSyncResult: result),
    );
    ref.invalidate(categoryLookupProvider);
    return result;
  }

  Future<void> loadNextPage() async {
    final current = state.value;
    if (current == null || current.isLoadingMore || !current.hasNextPage) {
      return;
    }

    state = AsyncData(current.copyWith(isLoadingMore: true));
    try {
      final nextPage = current.pageNumber + 1;
      final loaded = await _readLocal(
        pageNumber: nextPage,
        pageSize: current.pageSize,
        searchQuery: current.searchQuery,
        lastSyncResult: current.lastSyncResult,
      );

      state = AsyncData(
        current.copyWith(
          categories: [...current.categories, ...loaded.categories],
          pageNumber: loaded.pageNumber,
          totalCount: loaded.totalCount,
          totalPages: loaded.totalPages,
          isLoadingMore: false,
        ),
      );
    } catch (error, stackTrace) {
      state = AsyncError(error, stackTrace);
    }
  }

  Future<CategoryScreenState> _load({
    String? searchQuery,
    CategorySyncResult? lastSyncResult,
    bool isSyncing = false,
  }) async {
    return _readLocal(
      pageNumber: 1,
      pageSize: _pageSize,
      searchQuery: searchQuery,
      lastSyncResult: lastSyncResult,
      isSyncing: isSyncing,
    );
  }

  Future<CategoryScreenState> _readLocal({
    required int pageNumber,
    required int pageSize,
    String? searchQuery,
    CategorySyncResult? lastSyncResult,
    bool isSyncing = false,
  }) async {
    final shopId = _shopId;
    final totalCount = await _repository.getTotalCount(
      shopId,
      searchQuery: searchQuery,
    );
    final categories = await _repository.getAll(
      shopId,
      searchQuery: searchQuery,
      limit: pageSize,
      offset: (pageNumber - 1) * pageSize,
    );

    return CategoryScreenState(
      categories: categories,
      pendingCount: await _repository.getPendingCount(shopId),
      searchQuery: searchQuery ?? '',
      pageNumber: pageNumber,
      pageSize: pageSize,
      totalCount: totalCount,
      totalPages: (totalCount / pageSize).ceil(),
      isSyncing: isSyncing,
      lastSyncResult: lastSyncResult,
    );
  }
}

final categoryRepositoryProvider = Provider<CategoryPowerSyncRepository>(
  (ref) => CategoryPowerSyncRepository(ref.watch(appPowerSyncDatabaseProvider)),
);

final categorySyncServiceProvider = Provider<CategoryPowerSyncService>(
  (ref) => CategoryPowerSyncService(
    ref.watch(appPowerSyncDatabaseProvider),
    ref.watch(categoryRepositoryProvider),
  ),
);

final categoryControllerProvider =
    AsyncNotifierProvider<CategoryController, CategoryScreenState>(
      CategoryController.new,
    );

/// All locally available categories for selectors and relationship labels.
/// This is intentionally separate from the paginated Categories screen state.
final categoryLookupProvider = FutureProvider<List<Category>>((ref) async {
  final session = ref.watch(
    authControllerProvider.select((state) => state.session),
  );
  if (session == null) return const <Category>[];
  return ref.watch(categoryRepositoryProvider).getAll(session.shopId);
});
