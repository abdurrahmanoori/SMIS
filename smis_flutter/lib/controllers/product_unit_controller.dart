import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/product_unit_api.dart';
import '../data/product_unit_repository.dart';
import '../models/product_unit.dart';
import '../services/product_unit_sync_service.dart';
import 'app_dependencies.dart';
import 'auth_controller.dart';

class ProductUnitScreenState {
  const ProductUnitScreenState({
    required this.items,
    required this.pendingCount,
    required this.totalCount,
    required this.pageNumber,
    required this.pageSize,
    required this.searchQuery,
    this.isSyncing = false,
    this.isLoadingMore = false,
    this.lastSyncResult,
  });

  final List<ProductUnit> items;
  final int pendingCount;
  final int totalCount;
  final int pageNumber;
  final int pageSize;
  final String searchQuery;
  final bool isSyncing;
  final bool isLoadingMore;
  final ProductUnitSyncResult? lastSyncResult;

  int get totalPages => (totalCount / pageSize).ceil();
  bool get hasNextPage => pageNumber < totalPages;

  ProductUnitScreenState copyWith({
    List<ProductUnit>? items,
    int? pendingCount,
    int? totalCount,
    int? pageNumber,
    int? pageSize,
    String? searchQuery,
    bool? isSyncing,
    bool? isLoadingMore,
    ProductUnitSyncResult? lastSyncResult,
  }) => ProductUnitScreenState(
    items: items ?? this.items,
    pendingCount: pendingCount ?? this.pendingCount,
    totalCount: totalCount ?? this.totalCount,
    pageNumber: pageNumber ?? this.pageNumber,
    pageSize: pageSize ?? this.pageSize,
    searchQuery: searchQuery ?? this.searchQuery,
    isSyncing: isSyncing ?? this.isSyncing,
    isLoadingMore: isLoadingMore ?? this.isLoadingMore,
    lastSyncResult: lastSyncResult ?? this.lastSyncResult,
  );
}

class ProductUnitController extends AsyncNotifier<ProductUnitScreenState> {
  static const _pageSize = 25;

  ProductUnitRepository get _repository =>
      ref.read(productUnitRepositoryProvider);
  ProductUnitSyncService get _syncService =>
      ref.read(productUnitSyncServiceProvider);

  String get _shopId {
    final session = ref.watch(
      authControllerProvider.select((state) => state.session),
    );
    if (session == null) throw StateError('User is not authenticated.');
    return session.shopId;
  }

  @override
  Future<ProductUnitScreenState> build() {
    _shopId;
    return _load();
  }

  Future<void> reload() async {
    final previous = state.value;
    state = AsyncData(
      await _load(
        searchQuery: previous?.searchQuery,
        lastSyncResult: previous?.lastSyncResult,
      ),
    );
  }

  Future<void> search(String query) async {
    if (state.value?.searchQuery == query) return;
    state = AsyncData(await _load(searchQuery: query));
  }

  Future<void> create(ProductUnitDraft draft) async {
    await _repository.create(draft, _shopId);
    await reload();
  }

  Future<void> updateProductUnit(String id, ProductUnitDraft draft) async {
    await _repository.update(id, draft, _shopId);
    await reload();
  }

  Future<void> delete(String id) async {
    await _repository.delete(id);
    await reload();
  }

  Future<void> loadNextPage() async {
    final current = state.value;
    if (current == null || current.isLoadingMore || !current.hasNextPage) {
      return;
    }
    state = AsyncData(current.copyWith(isLoadingMore: true));
    try {
      final nextPage = current.pageNumber + 1;
      final next = await _readLocal(
        pageNumber: nextPage,
        searchQuery: current.searchQuery,
        lastSyncResult: current.lastSyncResult,
      );
      state = AsyncData(
        current.copyWith(
          items: [...current.items, ...next.items],
          pageNumber: nextPage,
          totalCount: next.totalCount,
          isLoadingMore: false,
        ),
      );
    } catch (error, stackTrace) {
      state = AsyncError(error, stackTrace);
    }
  }

  Future<ProductUnitSyncResult> syncNow() async {
    final current = state.value ?? await _load();
    state = AsyncData(current.copyWith(isSyncing: true));
    final result = await _syncService.synchronize(shopId: _shopId, force: true);
    state = AsyncData(
      await _load(searchQuery: current.searchQuery, lastSyncResult: result),
    );
    return result;
  }

  Future<ProductUnitScreenState> _load({
    String? searchQuery,
    ProductUnitSyncResult? lastSyncResult,
  }) => _readLocal(
    pageNumber: 1,
    searchQuery: searchQuery,
    lastSyncResult: lastSyncResult,
  );

  Future<ProductUnitScreenState> _readLocal({
    required int pageNumber,
    String? searchQuery,
    ProductUnitSyncResult? lastSyncResult,
  }) async {
    final shopId = _shopId;
    final totalCount = await _repository.getTotalCount(
      shopId,
      searchQuery: searchQuery,
    );
    return ProductUnitScreenState(
      items: await _repository.getAll(
        shopId,
        searchQuery: searchQuery,
        limit: _pageSize,
        offset: (pageNumber - 1) * _pageSize,
      ),
      pendingCount: await _repository.getPendingCount(shopId),
      totalCount: totalCount,
      pageNumber: pageNumber,
      pageSize: _pageSize,
      searchQuery: searchQuery ?? '',
      lastSyncResult: lastSyncResult,
    );
  }
}

final productUnitRepositoryProvider = Provider<ProductUnitRepository>(
  (ref) => ProductUnitRepository(ref.watch(appDatabaseProvider)),
);
final productUnitApiProvider = Provider<ProductUnitApi>(
  (ref) => DioProductUnitApi(sessionStore: ref.watch(authSessionStoreProvider)),
);
final productUnitSyncServiceProvider = Provider<ProductUnitSyncService>(
  (ref) => ProductUnitSyncService(
    ref.watch(productUnitRepositoryProvider),
    ref.watch(productUnitApiProvider),
    ref.watch(connectivityProvider),
  ),
);
final productUnitControllerProvider =
    AsyncNotifierProvider<ProductUnitController, ProductUnitScreenState>(
      ProductUnitController.new,
    );
