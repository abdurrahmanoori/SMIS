import 'dart:async';

import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/powersync/product_price_powersync_repository.dart';
import '../models/product_price.dart';
import 'app_dependencies.dart';
import 'auth_controller.dart';

class ProductPriceScreenState {
  const ProductPriceScreenState({
    required this.items,
    required this.pendingCount,
    required this.totalCount,
    required this.pageNumber,
    required this.pageSize,
    required this.searchQuery,
    this.isLoadingMore = false,
  });

  final List<ProductPrice> items;
  final int pendingCount;
  final int totalCount;
  final int pageNumber;
  final int pageSize;
  final String searchQuery;
  final bool isLoadingMore;

  int get totalPages => (totalCount / pageSize).ceil();
  bool get hasNextPage => pageNumber < totalPages;

  ProductPriceScreenState copyWith({
    List<ProductPrice>? items,
    int? pendingCount,
    int? totalCount,
    int? pageNumber,
    int? pageSize,
    String? searchQuery,
    bool? isLoadingMore,
  }) => ProductPriceScreenState(
    items: items ?? this.items,
    pendingCount: pendingCount ?? this.pendingCount,
    totalCount: totalCount ?? this.totalCount,
    pageNumber: pageNumber ?? this.pageNumber,
    pageSize: pageSize ?? this.pageSize,
    searchQuery: searchQuery ?? this.searchQuery,
    isLoadingMore: isLoadingMore ?? this.isLoadingMore,
  );
}

class ProductPriceController extends AsyncNotifier<ProductPriceScreenState> {
  static const _pageSize = 25;
  StreamSubscription<void>? _changesSubscription;
  bool _refreshingFromPowerSync = false;
  int _searchRequestId = 0;

  ProductPricePowerSyncRepository get _repository =>
      ref.read(productPriceRepositoryProvider);

  String get _shopId {
    final session = ref.watch(
      authControllerProvider.select((state) => state.session),
    );
    if (session == null) throw StateError('User is not authenticated.');
    return session.shopId;
  }

  @override
  Future<ProductPriceScreenState> build() async {
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
    } catch (error, stackTrace) {
      if (kDebugMode) {
        debugPrint('Product price PowerSync refresh failed: $error\n$stackTrace');
      }
    } finally {
      _refreshingFromPowerSync = false;
    }
  }

  Future<void> reload() async {
    final previous = state.value;
    state = AsyncData(await _load(searchQuery: previous?.searchQuery));
  }

  Future<void> search(String query) async {
    if (state.value?.searchQuery == query) return;
    final requestId = ++_searchRequestId;
    final loaded = await _load(searchQuery: query);
    if (requestId != _searchRequestId) return;
    state = AsyncData(loaded);
  }

  Future<void> create(ProductPriceDraft draft) async {
    await _repository.create(draft, _shopId);
    await reload();
  }

  Future<void> createSuccessor(String id, ProductPriceDraft draft) async {
    await _repository.createSuccessor(id, draft, _shopId);
    await reload();
  }

  Future<void> delete(String id) async {
    await _repository.delete(id);
    await reload();
  }

  Future<void> loadNextPage() async {
    final current = state.value;
    if (current == null || current.isLoadingMore || !current.hasNextPage) return;

    state = AsyncData(current.copyWith(isLoadingMore: true));
    try {
      final nextPage = current.pageNumber + 1;
      final next = await _readLocal(
        pageNumber: nextPage,
        searchQuery: current.searchQuery,
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

  Future<ProductPriceScreenState> _load({String? searchQuery}) =>
      _readLocal(pageNumber: 1, searchQuery: searchQuery);

  Future<ProductPriceScreenState> _readLocal({
    required int pageNumber,
    String? searchQuery,
  }) async {
    final shopId = _shopId;
    final totalCount = await _repository.getTotalCount(
      shopId,
      searchQuery: searchQuery,
    );
    return ProductPriceScreenState(
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
    );
  }
}

final productPriceRepositoryProvider = Provider<ProductPricePowerSyncRepository>(
  (ref) =>
      ProductPricePowerSyncRepository(ref.watch(appPowerSyncDatabaseProvider)),
);

final productPriceControllerProvider =
    AsyncNotifierProvider<ProductPriceController, ProductPriceScreenState>(
      ProductPriceController.new,
    );
