import 'dart:async';

import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'app_dependencies.dart';
import 'auth_controller.dart';
import '../data/powersync/product_powersync_repository.dart';
import '../models/product.dart';
import '../services/app_powersync_sync_services.dart';
import '../services/product_sync_service.dart';

class ProductScreenState {
  const ProductScreenState({
    required this.products,
    required this.pendingCount,
    this.searchQuery = '',
    this.isSyncing = false,
    this.lastSyncResult,
  });
  final List<Product> products;
  final int pendingCount;
  final String searchQuery;
  final bool isSyncing;
  final ProductSyncResult? lastSyncResult;

  ProductScreenState copyWith({
    List<Product>? products,
    int? pendingCount,
    String? searchQuery,
    bool? isSyncing,
    ProductSyncResult? lastSyncResult,
  }) => ProductScreenState(
    products: products ?? this.products,
    pendingCount: pendingCount ?? this.pendingCount,
    searchQuery: searchQuery ?? this.searchQuery,
    isSyncing: isSyncing ?? this.isSyncing,
    lastSyncResult: lastSyncResult ?? this.lastSyncResult,
  );
}

class ProductController extends AsyncNotifier<ProductScreenState> {
  StreamSubscription<void>? _changesSubscription;
  bool _refreshingFromPowerSync = false;

  ProductPowerSyncRepository get _repository =>
      ref.read(productRepositoryProvider);
  ProductPowerSyncService get _syncService =>
      ref.read(productSyncServiceProvider);

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
      state = AsyncData(
        await _load(
          searchQuery: current.searchQuery,
          lastSyncResult: current.lastSyncResult,
        ),
      );
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
    final previousSyncResult = state.hasValue
        ? state.value?.lastSyncResult
        : null;

    try {
      state = AsyncData(
        await _load(
          searchQuery: previousQuery,
          lastSyncResult: previousSyncResult,
        ),
      );
    } catch (error, stackTrace) {
      state = AsyncError(error, stackTrace);
    }
  }

  Future<void> search(String query) async {
    final previous = state.value;
    if (previous?.searchQuery == query) return;

    state = AsyncData(
      previous?.copyWith(searchQuery: query, products: []) ??
          ProductScreenState(products: [], pendingCount: 0, searchQuery: query),
    );

    try {
      state = AsyncData(await _load(searchQuery: query));
    } catch (error, stackTrace) {
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

  Future<ProductSyncResult> syncNow() async {
    final current = state.value ?? await _load();
    state = AsyncData(current.copyWith(isSyncing: true));
    final result = await _syncService.synchronize(shopId: _shopId, force: true);
    if (kDebugMode && !result.success) {
      debugPrint(
        '${result.message}\n\n${result.failures.map((failure) => failure.toDevelopmentString()).join('\n\n')}',
      );
    }
    state = AsyncData(
      await _load(searchQuery: current.searchQuery, lastSyncResult: result),
    );
    ref.invalidate(productLookupProvider);
    return result;
  }

  Future<ProductScreenState> _load({
    String? searchQuery,
    ProductSyncResult? lastSyncResult,
  }) async {
    final shopId = _shopId;
    return ProductScreenState(
      products: await _repository.getAll(shopId, searchQuery: searchQuery),
      pendingCount: await _repository.getPendingCount(shopId),
      searchQuery: searchQuery ?? '',
      lastSyncResult: lastSyncResult,
    );
  }
}

final productRepositoryProvider = Provider<ProductPowerSyncRepository>(
  (ref) => ProductPowerSyncRepository(ref.watch(appPowerSyncDatabaseProvider)),
);
final productSyncServiceProvider = Provider<ProductPowerSyncService>(
  (ref) => ProductPowerSyncService(
    ref.watch(appPowerSyncStatusServiceProvider),
    ref.watch(productRepositoryProvider),
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
