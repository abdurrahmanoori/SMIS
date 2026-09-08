import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import 'app_dependencies.dart';
import 'auth_controller.dart';
import '../data/shop_api.dart';
import '../data/shop_repository.dart';
import '../models/shop.dart';
import '../services/shop_sync_service.dart';

class ShopScreenState {
  const ShopScreenState({required this.shops, required this.pendingCount, this.isSyncing = false, this.lastSyncResult});
  final List<Shop> shops;
  final int pendingCount;
  final bool isSyncing;
  final ShopSyncResult? lastSyncResult;
  ShopScreenState copyWith({List<Shop>? shops, int? pendingCount, bool? isSyncing, ShopSyncResult? lastSyncResult}) => ShopScreenState(
    shops: shops ?? this.shops, pendingCount: pendingCount ?? this.pendingCount,
    isSyncing: isSyncing ?? this.isSyncing, lastSyncResult: lastSyncResult ?? this.lastSyncResult,
  );
}

class ShopController extends AsyncNotifier<ShopScreenState> {
  ShopRepository get _repository => ref.read(shopRepositoryProvider);
  ShopSyncService get _syncService => ref.read(shopSyncServiceProvider);
  @override Future<ShopScreenState> build() => _load();
  Future<void> reload() async { final previous = state.value; try { state = AsyncData(await _load(lastSyncResult: previous?.lastSyncResult)); } catch (error, stackTrace) { state = AsyncError(error, stackTrace); } }
  Future<void> create(ShopDraft draft) async { await _repository.create(draft); await reload(); }
  Future<void> updateShop(String id, ShopDraft draft) async { await _repository.update(id, draft); await reload(); }
  Future<void> delete(String id) async { await _repository.delete(id); await reload(); }
  Future<ShopSyncResult> syncNow() async {
    final current = state.value ?? await _load(); state = AsyncData(current.copyWith(isSyncing: true));
    final result = await _syncService.synchronize(force: true);
    if (kDebugMode && !result.success) debugPrint('${result.message}\n\n${result.failures.map((failure) => failure.toDevelopmentString()).join('\n\n')}');
    state = AsyncData(await _load(lastSyncResult: result)); return result;
  }
  Future<ShopScreenState> _load({ShopSyncResult? lastSyncResult}) async => ShopScreenState(shops: await _repository.getAll(), pendingCount: await _repository.getPendingCount(), lastSyncResult: lastSyncResult);
}

final shopRepositoryProvider = Provider<ShopRepository>((ref) => ShopRepository(ref.watch(appDatabaseProvider)));
final shopApiProvider = Provider<ShopApi>((ref) => DioShopApi(sessionStore: ref.watch(authSessionStoreProvider)));
final shopSyncServiceProvider = Provider<ShopSyncService>((ref) => ShopSyncService(ref.watch(shopRepositoryProvider), ref.watch(shopApiProvider), ref.watch(connectivityProvider)));
final shopControllerProvider = AsyncNotifierProvider<ShopController, ShopScreenState>(ShopController.new);
