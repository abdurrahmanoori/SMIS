import 'dart:async';

import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'app_dependencies.dart';
import 'auth_controller.dart';
import '../data/powersync/product_powersync_repository.dart';
import '../models/product.dart';

class ProductScreenState {
  const ProductScreenState({
    required this.products,
    required this.pendingCount,
    this.searchQuery = '',
    this.pageNumber = 1,
    this.pageSize = 25,
    this.totalCount = 0,
    this.totalPages = 1,
    this.isLoadingMore = false,
  });

  final List<Product> products;
  final int pendingCount;
  final String searchQuery;
  final int pageNumber;
  final int pageSize;
  final int totalCount;
  final int totalPages;
  final bool isLoadingMore;

  bool get hasNextPage => pageNumber < totalPages;

  ProductScreenState copyWith({
    List<Product>? products,
    int? pendingCount,
    String? searchQuery,
    int? pageNumber,
    int? pageSize,
    int? totalCount,
    int? totalPages,
    bool? isLoadingMore,
  }) => ProductScreenState(
    products: products ?? this.products,
    pendingCount: pendingCount ?? this.pendingCount,
    searchQuery: searchQuery ?? this.searchQuery,
    pageNumber: pageNumber ?? this.pageNumber,
    pageSize: pageSize ?? this.pageSize,
    totalCount: totalCount ?? this.totalCount,
    totalPages: totalPages ?? this.totalPages,
    isLoadingMore: isLoadingMore ?? this.isLoadingMore,
  );
}

class ProductController extends AsyncNotifier<ProductScreenState> {
  static const _pageSize = 25;
  StreamSubscription<void>? _changesSubscription;
  bool _refreshingFromPowerSync = false;
  int _searchRequestId = 0;

  ProductPowerSyncRepository get _repository =>
      ref.read(productRepositoryProvider);

  String get _shopId {
    final session = ref.watch(authControllerProvider.select((s) => s.session));
    if (session == null) throw StateError('User is not authenticated.');
    return session.shopId;
  }

  @override
  Future<ProductScreenState> build() async {
    final shopId = _shopId;
    await _changesSubscription?.cancel();
    final changes = await _repository.watchChanges(shopId);
    _changesSubscription = changes
        .skip(1)
        .listen((_) => _refreshFromPowerSync());
    ref.onDispose(() => _changesSubscription?.cancel());
    return _load();
  }

  Future<void> _refreshFromPowerSync() async {
    if (_refreshingFromPowerSync || !state.hasValue) return;
    _refreshingFromPowerSync = true;
    try {
      final current = state.value!;
      state = AsyncData(await _load(searchQuery: current.searchQuery));
      ref.invalidate(productLookupProvider);
    } catch (error, stackTrace) {
      if (kDebugMode) {
        debugPrint('Product PowerSync refresh failed: $error\n$stackTrace');
      }
    } finally {
      _refreshingFromPowerSync = false;
    }
  }

  Future<void> reload() async {
    final previousQuery = state.hasValue ? state.value?.searchQuery : null;

    try {
      state = AsyncData(await _load(searchQuery: previousQuery));
    } catch (error, stackTrace) {
      state = AsyncError(error, stackTrace);
    }
  }

  Future<void> search(String query) async {
    final previous = state.value;
    if (previous?.searchQuery == query) return;
    final requestId = ++_searchRequestId;

    state = AsyncData(
      previous?.copyWith(searchQuery: query, isLoadingMore: true) ??
          ProductScreenState(
            products: [],
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

  Future<void> create(ProductDraft draft) async {
    await _repository.create(draft, _shopId);
    await reload();
    ref.invalidate(productLookupProvider);
  }

  Future<void> updateProduct(String id, ProductDraft draft) async {
    await _repository.update(id, draft);
    await reload();
    ref.invalidate(productLookupProvider);
  }

  Future<void> delete(String id) async {
    await _repository.delete(id);
    await reload();
    ref.invalidate(productLookupProvider);
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
      );

      state = AsyncData(
        current.copyWith(
          products: [...current.products, ...loaded.products],
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

  Future<ProductScreenState> _load({String? searchQuery}) async {
    return _readLocal(
      pageNumber: 1,
      pageSize: _pageSize,
      searchQuery: searchQuery,
    );
  }

  Future<ProductScreenState> _readLocal({
    required int pageNumber,
    required int pageSize,
    String? searchQuery,
  }) async {
    final shopId = _shopId;
    final totalCount = await _repository.getTotalCount(
      shopId,
      searchQuery: searchQuery,
    );
    return ProductScreenState(
      products: await _repository.getAll(
        shopId,
        searchQuery: searchQuery,
        limit: pageSize,
        offset: (pageNumber - 1) * pageSize,
      ),
      pendingCount: await _repository.getPendingCount(shopId),
      searchQuery: searchQuery ?? '',
      pageNumber: pageNumber,
      pageSize: pageSize,
      totalCount: totalCount,
      totalPages: (totalCount / pageSize).ceil(),
    );
  }
}

final productRepositoryProvider = Provider<ProductPowerSyncRepository>(
  (ref) => ProductPowerSyncRepository(
    ref.watch(appPowerSyncDatabaseProvider),
    ref.watch(dateTimeServiceProvider),
  ),
);
final productControllerProvider =
    AsyncNotifierProvider<ProductController, ProductScreenState>(
      ProductController.new,
    );

final productLookupProvider = FutureProvider<List<Product>>((ref) async {
  final session = ref.watch(
    authControllerProvider.select((state) => state.session),
  );
  if (session == null) return const <Product>[];
  return ref.watch(productRepositoryProvider).getAll(session.shopId);
});
