import 'dart:async';

import 'package:flutter/foundation.dart' show debugPrint, kDebugMode;
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/powersync/supplier_powersync_repository.dart';
import '../models/supplier.dart';
import 'app_dependencies.dart';
import 'auth_controller.dart';

class SupplierScreenState {
  const SupplierScreenState({
    required this.suppliers,
    required this.pendingCount,
    this.searchQuery = '',
    this.pageNumber = 1,
    this.pageSize = 25,
    this.totalCount = 0,
    this.totalPages = 1,
    this.isLoadingMore = false,
  });

  final List<Supplier> suppliers;
  final int pendingCount;
  final String searchQuery;
  final int pageNumber;
  final int pageSize;
  final int totalCount;
  final int totalPages;
  final bool isLoadingMore;

  bool get hasNextPage => pageNumber < totalPages;

  SupplierScreenState copyWith({
    List<Supplier>? suppliers,
    int? pendingCount,
    String? searchQuery,
    int? pageNumber,
    int? pageSize,
    int? totalCount,
    int? totalPages,
    bool? isLoadingMore,
  }) => SupplierScreenState(
    suppliers: suppliers ?? this.suppliers,
    pendingCount: pendingCount ?? this.pendingCount,
    searchQuery: searchQuery ?? this.searchQuery,
    pageNumber: pageNumber ?? this.pageNumber,
    pageSize: pageSize ?? this.pageSize,
    totalCount: totalCount ?? this.totalCount,
    totalPages: totalPages ?? this.totalPages,
    isLoadingMore: isLoadingMore ?? this.isLoadingMore,
  );
}

class SupplierController extends AsyncNotifier<SupplierScreenState> {
  static const _pageSize = 25;
  StreamSubscription<void>? _changesSubscription;
  bool _refreshingFromPowerSync = false;
  int _searchRequestId = 0;

  SupplierPowerSyncRepository get _repository =>
      ref.read(supplierRepositoryProvider);

  String get _shopId {
    final session = ref.watch(authControllerProvider.select((s) => s.session));
    if (session == null) throw StateError('User is not authenticated.');
    return session.shopId;
  }

  @override
  Future<SupplierScreenState> build() async {
    final shopId = _shopId;

    await _changesSubscription?.cancel();
    final changes = await _repository.watchChanges(shopId);
    _changesSubscription = changes.skip(1).listen((_) {
      _refreshFromPowerSync();
    });
    ref.onDispose(() => _changesSubscription?.cancel());

    return _load();
  }

  Future<void> _refreshFromPowerSync() async {
    if (_refreshingFromPowerSync || !state.hasValue) return;
    _refreshingFromPowerSync = true;
    try {
      final current = state.value!;
      state = AsyncData(await _load(searchQuery: current.searchQuery));
      ref.invalidate(activeSupplierLookupProvider);
    } catch (error, stackTrace) {
      if (kDebugMode) {
        debugPrint('Supplier PowerSync refresh failed: $error\n$stackTrace');
      }
    } finally {
      _refreshingFromPowerSync = false;
    }
  }

  Future<void> reload() async {
    final previous = state.value;
    try {
      state = AsyncData(await _load(searchQuery: previous?.searchQuery));
      ref.invalidate(activeSupplierLookupProvider);
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
          SupplierScreenState(
            suppliers: const [],
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

  Future<void> create(SupplierDraft draft) async {
    await _repository.create(draft, _shopId);
    await reload();
  }

  Future<void> updateSupplier(String id, SupplierDraft draft) async {
    await _repository.update(id, draft);
    await reload();
  }

  Future<void> updateStatus(String id, bool isActive) async {
    await _repository.updateStatus(id, isActive);
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
      final loaded = await _readLocal(
        pageNumber: nextPage,
        pageSize: current.pageSize,
        searchQuery: current.searchQuery,
      );
      state = AsyncData(
        current.copyWith(
          suppliers: [...current.suppliers, ...loaded.suppliers],
          pageNumber: loaded.pageNumber,
          totalCount: loaded.totalCount,
          totalPages: loaded.totalPages,
          pendingCount: loaded.pendingCount,
          isLoadingMore: false,
        ),
      );
    } catch (error, stackTrace) {
      state = AsyncError(error, stackTrace);
    }
  }

  Future<SupplierScreenState> _load({String? searchQuery}) =>
      _readLocal(pageNumber: 1, pageSize: _pageSize, searchQuery: searchQuery);

  Future<SupplierScreenState> _readLocal({
    required int pageNumber,
    required int pageSize,
    String? searchQuery,
  }) async {
    final shopId = _shopId;
    final totalCount = await _repository.getTotalCount(
      shopId,
      searchQuery: searchQuery,
    );
    final suppliers = await _repository.getAll(
      shopId,
      searchQuery: searchQuery,
      limit: pageSize,
      offset: (pageNumber - 1) * pageSize,
    );

    return SupplierScreenState(
      suppliers: suppliers,
      pendingCount: await _repository.getPendingCount(shopId),
      searchQuery: searchQuery ?? '',
      pageNumber: pageNumber,
      pageSize: pageSize,
      totalCount: totalCount,
      totalPages: (totalCount / pageSize).ceil(),
    );
  }
}

final supplierRepositoryProvider = Provider<SupplierPowerSyncRepository>(
  (ref) => SupplierPowerSyncRepository(
    ref.watch(appPowerSyncDatabaseProvider),
    ref.watch(dateTimeServiceProvider),
  ),
);

final supplierControllerProvider =
    AsyncNotifierProvider<SupplierController, SupplierScreenState>(
      SupplierController.new,
    );

final activeSupplierLookupProvider = FutureProvider<List<Supplier>>((
  ref,
) async {
  final session = ref.watch(
    authControllerProvider.select((state) => state.session),
  );
  if (session == null) return const <Supplier>[];
  return ref
      .watch(supplierRepositoryProvider)
      .getAll(session.shopId, isActive: true);
});
