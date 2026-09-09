import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'app_dependencies.dart';
import 'auth_controller.dart';
import '../data/unit_of_measure_api.dart';
import '../data/unit_of_measure_repository.dart';
import '../models/unit_of_measure.dart';
import '../services/unit_of_measure_sync_service.dart';

class UnitOfMeasureScreenState {
  const UnitOfMeasureScreenState({
    required this.units,
    required this.pendingCount,
    this.isSyncing = false,
    this.lastSyncResult,
  });

  final List<UnitOfMeasure> units;
  final int pendingCount;
  final bool isSyncing;
  final UnitOfMeasureSyncResult? lastSyncResult;

  UnitOfMeasureScreenState copyWith({
    List<UnitOfMeasure>? units,
    int? pendingCount,
    bool? isSyncing,
    UnitOfMeasureSyncResult? lastSyncResult,
  }) => UnitOfMeasureScreenState(
    units: units ?? this.units,
    pendingCount: pendingCount ?? this.pendingCount,
    isSyncing: isSyncing ?? this.isSyncing,
    lastSyncResult: lastSyncResult ?? this.lastSyncResult,
  );
}

class UnitOfMeasureController extends AsyncNotifier<UnitOfMeasureScreenState> {
  UnitOfMeasureRepository get _repository =>
      ref.read(unitOfMeasureRepositoryProvider);
  UnitOfMeasureSyncService get _syncService =>
      ref.read(unitOfMeasureSyncServiceProvider);

  String get _shopId {
    final session = ref.watch(authControllerProvider.select((s) => s.session));
    if (session == null) throw StateError('User is not authenticated.');
    return session.shopId;
  }

  @override
  Future<UnitOfMeasureScreenState> build() {
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

  Future<void> create(UnitOfMeasureDraft draft) async {
    await _repository.create(draft, _shopId);
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

  Future<UnitOfMeasureSyncResult> syncNow() async {
    final current = state.value ?? await _load();
    state = AsyncData(current.copyWith(isSyncing: true));
    final result = await _syncService.synchronize(shopId: _shopId, force: true);
    if (kDebugMode && !result.success) {
      final details = result.failures
          .map((failure) => failure.toDevelopmentString())
          .join('\n\n');
      debugPrint('${result.message}\n\n$details');
    }
    state = AsyncData(await _load(lastSyncResult: result));
    return result;
  }

  Future<UnitOfMeasureScreenState> _load({
    UnitOfMeasureSyncResult? lastSyncResult,
  }) async {
    final shopId = _shopId;
    return UnitOfMeasureScreenState(
      units: await _repository.getAll(shopId),
      pendingCount: await _repository.getPendingCount(shopId),
      lastSyncResult: lastSyncResult,
    );
  }
}

final unitOfMeasureRepositoryProvider = Provider<UnitOfMeasureRepository>(
  (ref) => UnitOfMeasureRepository(ref.watch(appDatabaseProvider)),
);

final unitOfMeasureApiProvider = Provider<UnitOfMeasureApi>(
  (ref) => DioUnitOfMeasureApi(
    sessionStore: ref.watch(authSessionStoreProvider),
  ),
);

final unitOfMeasureSyncServiceProvider = Provider<UnitOfMeasureSyncService>(
  (ref) => UnitOfMeasureSyncService(
    ref.watch(unitOfMeasureRepositoryProvider),
    ref.watch(unitOfMeasureApiProvider),
    ref.watch(connectivityProvider),
  ),
);

final unitOfMeasureControllerProvider =
    AsyncNotifierProvider<UnitOfMeasureController, UnitOfMeasureScreenState>(
      UnitOfMeasureController.new,
    );
