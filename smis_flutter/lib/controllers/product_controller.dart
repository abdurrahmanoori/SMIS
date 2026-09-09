import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'app_dependencies.dart';
import 'auth_controller.dart';
import '../data/product_api.dart';
import '../data/product_repository.dart';
import '../models/product.dart';
import '../services/product_sync_service.dart';

class ProductScreenState {
  const ProductScreenState({
    required this.products,
    required this.pendingCount,
    this.isSyncing = false,
    this.lastSyncResult,
  });
  final List<Product> products;
  final int pendingCount;
  final bool isSyncing;
  final ProductSyncResult? lastSyncResult;
  ProductScreenState copyWith({
    List<Product>? products,
    int? pendingCount,
    bool? isSyncing,
    ProductSyncResult? lastSyncResult,
  }) => ProductScreenState(
    products: products ?? this.products,
    pendingCount: pendingCount ?? this.pendingCount,
    isSyncing: isSyncing ?? this.isSyncing,
    lastSyncResult: lastSyncResult ?? this.lastSyncResult,
  );
}

class ProductController extends AsyncNotifier<ProductScreenState> {
  ProductRepository get _repository => ref.read(productRepositoryProvider);
  ProductSyncService get _syncService => ref.read(productSyncServiceProvider);

  String get _shopId {
    final session = ref.watch(authControllerProvider.select((s) => s.session));
    if (session == null) throw StateError('User is not authenticated.');
    return session.shopId;
  }

  @override
  Future<ProductScreenState> build() {
    _shopId;
    return _load();
  }

  Future<void> reload() async {
    final previous = state.value;
    try {
      state = AsyncData(await _load(lastSyncResult: previous?.lastSyncResult));
    } catch (error, stackTrace) {
      state = AsyncError(error, stackTrace);
    }
  }
  Future<void> create(ProductDraft draft) async { await _repository.create(draft, _shopId); await reload(); }
  Future<void> updateProduct(String id, ProductDraft draft) async { await _repository.update(id, draft); await reload(); }
  Future<void> delete(String id) async { await _repository.delete(id); await reload(); }

  Future<ProductSyncResult> syncNow() async {
    final current = state.value ?? await _load();
    state = AsyncData(current.copyWith(isSyncing: true));
    final result = await _syncService.synchronize(shopId: _shopId, force: true);
    if (kDebugMode && !result.success) {
      debugPrint('${result.message}\n\n${result.failures.map((failure) => failure.toDevelopmentString()).join('\n\n')}');
    }
    state = AsyncData(await _load(lastSyncResult: result));
    return result;
  }
  Future<ProductScreenState> _load({ProductSyncResult? lastSyncResult}) async {
    final shopId = _shopId;
    return ProductScreenState(
      products: await _repository.getAll(shopId),
      pendingCount: await _repository.getPendingCount(shopId),
      lastSyncResult: lastSyncResult,
    );
  }
}

final productRepositoryProvider = Provider<ProductRepository>(
  (ref) => ProductRepository(ref.watch(appDatabaseProvider)),
);
final productApiProvider = Provider<ProductApi>(
  (ref) => DioProductApi(sessionStore: ref.watch(authSessionStoreProvider)),
);
final productSyncServiceProvider = Provider<ProductSyncService>(
  (ref) => ProductSyncService(
    ref.watch(productRepositoryProvider),
    ref.watch(productApiProvider),
    ref.watch(connectivityProvider),
  ),
);
final productControllerProvider = AsyncNotifierProvider<ProductController, ProductScreenState>(ProductController.new);
