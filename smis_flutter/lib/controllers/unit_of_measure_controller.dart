import 'dart:async';

import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'app_dependencies.dart';
import 'auth_controller.dart';
import '../data/powersync/unit_of_measure_powersync_repository.dart';
import '../models/unit_of_measure.dart';
import '../services/app_powersync_sync_services.dart';
import '../services/unit_of_measure_sync_service.dart';

class UnitOfMeasureScreenState {
  const UnitOfMeasureScreenState({
    required this.units,
    required this.pendingCount,
    this.searchQuery = '',
    this.isSyncing = false,
    this.lastSyncResult,
  });

  final List<UnitOfMeasure> units;
  final int pendingCount;
  final String searchQuery;
  final bool isSyncing;
  final UnitOfMeasureSyncResult? lastSyncResult;

  UnitOfMeasureScreenState copyWith({
    List<UnitOfMeasure>? units,
    int? pendingCount,
    String? searchQuery,
    bool? isSyncing,
    UnitOfMeasureSyncResult? lastSyncResult,
  }) => UnitOfMeasureScreenState(
    units: units ?? this.units,
    pendingCount: pendingCount ?? this.pendingCount,
    searchQuery: searchQuery ?? this.searchQuery,
    isSyncing: isSyncing ?? this.isSyncing,
    lastSyncResult: lastSyncResult ?? this.lastSyncResult,
  );
}

class UnitOfMeasureController extends AsyncNotifier<UnitOfMeasureScreenState> {
  StreamSubscription<void>? _changesSubscription;
  bool _refreshingFromPowerSync = false;
  int _searchRequestId = 0;

  UnitOfMeasurePowerSyncRepository get _repository =>
      ref.read(unitOfMeasureRepositoryProvider);
  UnitOfMeasurePowerSyncService get _syncService =>
      ref.read(unitOfMeasureSyncServiceProvider);

  @override
  Future<UnitOfMeasureScreenState> build() async {
    // UOM is global, but watch the active session context because PowerSync uses
    // a separate SQLite file per user/shop to keep all local caches isolated.
    ref.watch(authControllerProvider.select((s) => s.session?.shopId));
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
      ref.invalidate(unitOfMeasureLookupProvider);
    } catch (error, stackTrace) {
      if (kDebugMode) {
        debugPrint('Unit PowerSync refresh failed: $error\n$stackTrace');
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
      ref.invalidate(unitOfMeasureLookupProvider);
    } catch (error, stackTrace) {
      state = AsyncError(error, stackTrace);
    }
  }

  Future<void> search(String query) async {
    final previous = state.value;
    if (previous?.searchQuery == query) return;
    final requestId = ++_searchRequestId;

    state = AsyncData(
      previous?.copyWith(searchQuery: query, units: []) ??
          UnitOfMeasureScreenState(
            units: [],
            pendingCount: 0,
            searchQuery: query,
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

  Future<void> create(UnitOfMeasureDraft draft) async {
    await _repository.create(draft);
    await reload();
  }

  Future<void> updateUnit(String id, UnitOfMeasureDraft draft) async {
    await _repository.update(id, draft);
    await reload();
  }

  Future<void> delete(String id) async {
    await _repository.delete(id);
    await reload();
  }

  Future<int> countProductsUsingUnit(String id) =>
      _repository.countProductsUsingUnit(id);

  Future<UnitOfMeasureSyncResult> syncNow() async {
    final current = state.value ?? await _load();
    state = AsyncData(current.copyWith(isSyncing: true));
    final result = await _syncService.synchronize(force: true);
    if (kDebugMode && !result.success) {
      final details = result.failures
          .map((failure) => failure.toDevelopmentString())
          .join('\n\n');
      debugPrint('${result.message}\n\n$details');
    }
    state = AsyncData(
      await _load(searchQuery: current.searchQuery, lastSyncResult: result),
    );
    ref.invalidate(unitOfMeasureLookupProvider);
    return result;
  }

  Future<UnitOfMeasureScreenState> _load({
    String? searchQuery,
    UnitOfMeasureSyncResult? lastSyncResult,
  }) async {
    return UnitOfMeasureScreenState(
      units: await _repository.getAll(searchQuery: searchQuery),
      pendingCount: await _repository.getPendingCount(),
      searchQuery: searchQuery ?? '',
      lastSyncResult: lastSyncResult,
    );
  }
}

final unitOfMeasureRepositoryProvider =
    Provider<UnitOfMeasurePowerSyncRepository>(
      (ref) => UnitOfMeasurePowerSyncRepository(
        ref.watch(appPowerSyncDatabaseProvider),
      ),
    );

final unitOfMeasureSyncServiceProvider =
    Provider<UnitOfMeasurePowerSyncService>(
      (ref) => UnitOfMeasurePowerSyncService(
        ref.watch(appPowerSyncStatusServiceProvider),
        ref.watch(unitOfMeasureRepositoryProvider),
      ),
    );

final unitOfMeasureControllerProvider =
    AsyncNotifierProvider<UnitOfMeasureController, UnitOfMeasureScreenState>(
      UnitOfMeasureController.new,
    );

/// Complete local unit list for selectors, independent of screen searching.
final unitOfMeasureLookupProvider = FutureProvider<List<UnitOfMeasure>>((
  ref,
) async {
  final session = ref.watch(
    authControllerProvider.select((state) => state.session),
  );
  if (session == null) return const <UnitOfMeasure>[];
  return ref.watch(unitOfMeasureRepositoryProvider).getAll();
});
