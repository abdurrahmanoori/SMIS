import 'dart:async';

import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'app_dependencies.dart';
import 'auth_controller.dart';
import '../data/powersync/shop_powersync_repository.dart';
import '../models/shop.dart';
import '../services/app_powersync_sync_services.dart';
import '../services/shop_sync_service.dart';

class ShopScreenState {
  const ShopScreenState({
    required this.shops,
    required this.pendingCount,
    this.searchQuery = '',
    this.isSyncing = false,
    this.lastSyncResult,
  });
  final List<Shop> shops;
  final int pendingCount;
  final String searchQuery;
  final bool isSyncing;
  final ShopSyncResult? lastSyncResult;

  ShopScreenState copyWith({
    List<Shop>? shops,
    int? pendingCount,
    String? searchQuery,
    bool? isSyncing,
    ShopSyncResult? lastSyncResult,
  }) => ShopScreenState(
    shops: shops ?? this.shops,
    pendingCount: pendingCount ?? this.pendingCount,
    searchQuery: searchQuery ?? this.searchQuery,
    isSyncing: isSyncing ?? this.isSyncing,
    lastSyncResult: lastSyncResult ?? this.lastSyncResult,
  );
}

class ShopController extends AsyncNotifier<ShopScreenState> {
  StreamSubscription<void>? _changesSubscription;
  bool _refreshingFromPowerSync = false;

  ShopPowerSyncRepository get _repository => ref.read(shopRepositoryProvider);
  ShopPowerSyncService get _syncService => ref.read(shopSyncServiceProvider);

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
        await _load(
          searchQuery: current.searchQuery,
          lastSyncResult: current.lastSyncResult,
        ),
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
      previous?.copyWith(searchQuery: query, shops: []) ??
          ShopScreenState(shops: [], pendingCount: 0, searchQuery: query),
    );

    try {
      state = AsyncData(await _load(searchQuery: query));
    } catch (error, stackTrace) {
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

  Future<ShopSyncResult> syncNow() async {
    final current = state.value ?? await _load();
    state = AsyncData(current.copyWith(isSyncing: true));
    final result = await _syncService.synchronize(force: true);
    if (kDebugMode && !result.success) {
      debugPrint(
        '${result.message}\n\n${result.failures.map((failure) => failure.toDevelopmentString()).join('\n\n')}',
      );
    }
    state = AsyncData(
      await _load(searchQuery: current.searchQuery, lastSyncResult: result),
    );
    return result;
  }

  Future<ShopScreenState> _load({
    String? searchQuery,
    ShopSyncResult? lastSyncResult,
  }) async => ShopScreenState(
    shops: await _repository.getAll(searchQuery: searchQuery),
    pendingCount: await _repository.getPendingCount(),
    searchQuery: searchQuery ?? '',
    lastSyncResult: lastSyncResult,
  );
}

final shopRepositoryProvider = Provider<ShopPowerSyncRepository>(
  (ref) => ShopPowerSyncRepository(ref.watch(appPowerSyncDatabaseProvider)),
);
final shopSyncServiceProvider = Provider<ShopPowerSyncService>(
  (ref) => ShopPowerSyncService(
    ref.watch(appPowerSyncStatusServiceProvider),
    ref.watch(shopRepositoryProvider),
  ),
);
final shopControllerProvider =
    AsyncNotifierProvider<ShopController, ShopScreenState>(ShopController.new);
