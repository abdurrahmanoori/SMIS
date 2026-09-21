import 'dart:async';

import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'app_dependencies.dart';
import 'auth_controller.dart';
import '../data/powersync/shop_powersync_repository.dart';
import '../models/shop.dart';

class ShopScreenState {
  const ShopScreenState({
    required this.shops,
    required this.pendingCount,
    this.searchQuery = '',
  });
  final List<Shop> shops;
  final int pendingCount;
  final String searchQuery;

  ShopScreenState copyWith({
    List<Shop>? shops,
    int? pendingCount,
    String? searchQuery,
  }) => ShopScreenState(
    shops: shops ?? this.shops,
    pendingCount: pendingCount ?? this.pendingCount,
    searchQuery: searchQuery ?? this.searchQuery,
  );
}

class ShopController extends AsyncNotifier<ShopScreenState> {
  StreamSubscription<void>? _changesSubscription;
  bool _refreshingFromPowerSync = false;
  int _searchRequestId = 0;

  ShopPowerSyncRepository get _repository => ref.read(shopRepositoryProvider);

  @override
  Future<ShopScreenState> build() async {
    ref.watch(
      authControllerProvider.select(
        (state) => state.session == null
            ? null
            : '${state.session!.userId}:${state.session!.shopId}',
      ),
    );
    await _changesSubscription?.cancel();
    final changes = await _repository.watchChanges();
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
        await _load(searchQuery: current.searchQuery),
      );
    } catch (error, stackTrace) {
      if (kDebugMode) {
        debugPrint('Shop PowerSync refresh failed: $error\n$stackTrace');
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
      previous?.copyWith(searchQuery: query, shops: []) ??
          ShopScreenState(shops: [], pendingCount: 0, searchQuery: query),
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

  Future<void> create(ShopDraft draft) async {
    await _repository.create(draft);
    await reload();
  }

  Future<void> updateShop(String id, ShopDraft draft) async {
    await _repository.update(id, draft);
    await reload();
  }

  Future<void> delete(String id) async {
    await _repository.delete(id);
    await reload();
  }

  Future<int> countLocalRecords(String id) => _repository.countLocalRecords(id);

  Future<ShopScreenState> _load({String? searchQuery}) async => ShopScreenState(
    shops: await _repository.getAll(searchQuery: searchQuery),
    pendingCount: await _repository.getPendingCount(),
    searchQuery: searchQuery ?? '',
  );
}

final shopRepositoryProvider = Provider<ShopPowerSyncRepository>(
  (ref) => ShopPowerSyncRepository(ref.watch(appPowerSyncDatabaseProvider)),
);
final shopControllerProvider =
    AsyncNotifierProvider<ShopController, ShopScreenState>(ShopController.new);
