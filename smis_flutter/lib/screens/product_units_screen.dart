import 'dart:async';

import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/product_controller.dart';
import '../controllers/product_unit_controller.dart';
import '../controllers/unit_of_measure_controller.dart';
import '../data/data_exception.dart';
import '../l10n/app_localizations.dart';
import '../models/product_unit.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/home_action.dart';
import '../widgets/locale_action.dart';
import '../widgets/product_unit_form_dialog.dart';
import '../widgets/theme_mode_action.dart';

class ProductUnitsScreen extends ConsumerStatefulWidget {
  const ProductUnitsScreen({super.key});

  @override
  ConsumerState<ProductUnitsScreen> createState() => _ProductUnitsScreenState();
}

class _ProductUnitsScreenState extends ConsumerState<ProductUnitsScreen>
    with WidgetsBindingObserver {
  final _searchController = TextEditingController();
  Timer? _searchDebounce;
  bool _isSearching = false;

  @override
  void initState() {
    super.initState();
    WidgetsBinding.instance.addObserver(this);
  }

  @override
  void dispose() {
    _searchController.dispose();
    _searchDebounce?.cancel();
    WidgetsBinding.instance.removeObserver(this);
    super.dispose();
  }

  @override
  void didChangeAppLifecycleState(AppLifecycleState state) {
    if (state == AppLifecycleState.resumed) {
      ref.read(productUnitControllerProvider.notifier).reload();
    }
  }

  @override
  Widget build(BuildContext context) {
    final state = ref.watch(productUnitControllerProvider);
    return Scaffold(
      appBar: AppBar(
        title: _isSearching
            ? TextField(
                controller: _searchController,
                autofocus: true,
                decoration: InputDecoration(
                  hintText: context.l10n.text('Search product units...'),
                  border: InputBorder.none,
                ),
                onChanged: _onSearchChanged,
              )
            : Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(context.l10n.text('Product units')),
                  Text(
                    context.l10n.text('Local-first inventory setup'),
                    style: const TextStyle(fontSize: 12),
                  ),
                ],
              ),
        actions: [
          IconButton(
            icon: Icon(_isSearching ? Icons.close : Icons.search),
            onPressed: _isSearching
                ? _stopSearching
                : () => setState(() => _isSearching = true),
          ),
          state.maybeWhen(
            data: (value) => Badge(
              isLabelVisible: value.pendingCount > 0,
              label: Text('${value.pendingCount}'),
              child: IconButton.filledTonal(
                tooltip: context.l10n.text('Sync product units'),
                onPressed: value.isSyncing ? null : _sync,
                icon: value.isSyncing
                    ? const SizedBox.square(
                        dimension: 18,
                        child: CircularProgressIndicator(strokeWidth: 2),
                      )
                    : const Icon(Icons.sync),
              ),
            ),
            orElse: () => const SizedBox.shrink(),
          ),
          const HomeAction(),
          const LocaleAction(),
          const ThemeModeAction(),
          const SizedBox(width: 8),
        ],
      ),
      drawer: const AppDrawer(),
      body: state.when(
        loading: () => const Center(child: CircularProgressIndicator()),
        error: (error, stackTrace) => AppErrorView(
          error: error,
          stackTrace: stackTrace,
          onRetry: () =>
              ref.read(productUnitControllerProvider.notifier).reload(),
        ),
        data: (value) => _Content(
          state: value,
          onEdit: _edit,
          onDelete: _delete,
          onLoadMore: () =>
              ref.read(productUnitControllerProvider.notifier).loadNextPage(),
        ),
      ),
      floatingActionButton: FloatingActionButton.extended(
        onPressed: _create,
        icon: const Icon(Icons.add),
        label: Text(context.l10n.text('Add product unit')),
      ),
    );
  }

  void _onSearchChanged(String query) {
    _searchDebounce?.cancel();
    _searchDebounce = Timer(const Duration(milliseconds: 400), () {
      ref.read(productUnitControllerProvider.notifier).search(query);
    });
  }

  void _stopSearching() {
    setState(() {
      _isSearching = false;
      _searchController.clear();
    });
    ref.read(productUnitControllerProvider.notifier).search('');
  }

  Future<void> _create() async {
    final draft = await _showForm();
    if (!mounted || draft == null) return;
    await _runMutation(
      () => ref.read(productUnitControllerProvider.notifier).create(draft),
      context.l10n.text('Product unit saved locally.'),
    );
  }

  Future<void> _edit(ProductUnit item) async {
    final draft = await _showForm(productUnit: item);
    if (!mounted || draft == null) return;
    await _runMutation(
      () => ref
          .read(productUnitControllerProvider.notifier)
          .updateProductUnit(item.id, draft),
      context.l10n.text('Product unit updated locally.'),
    );
  }

  Future<ProductUnitDraft?> _showForm({ProductUnit? productUnit}) async {
    final products = await ref.read(productLookupProvider.future);
    final units = await ref.read(unitOfMeasureLookupProvider.future);
    if (!mounted) return null;
    return showDialog<ProductUnitDraft>(
      context: context,
      builder: (context) => ProductUnitFormDialog(
        products: products,
        units: units,
        productUnit: productUnit,
      ),
    );
  }

  Future<void> _delete(ProductUnit item) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text(context.l10n.text('Delete product unit?')),
        content: Text(
          context.l10n.text(
            'This product unit will disappear now and its deletion will sync later.',
          ),
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: Text(context.l10n.text('Cancel')),
          ),
          FilledButton.tonal(
            onPressed: () => Navigator.pop(context, true),
            child: Text(context.l10n.text('Delete offline')),
          ),
        ],
      ),
    );
    if (!mounted || confirmed != true) return;
    await _runMutation(
      () => ref.read(productUnitControllerProvider.notifier).delete(item.id),
      context.l10n.text('Product unit deleted locally.'),
    );
  }

  Future<void> _sync() async {
    try {
      final result = await ref
          .read(productUnitControllerProvider.notifier)
          .syncNow();
      if (!mounted || !result.success) return;
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text(context.l10n.syncMessage(result.message))),
      );
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    }
  }

  Future<void> _runMutation(
    Future<void> Function() action,
    String message,
  ) async {
    try {
      await action();
      if (mounted) {
        ScaffoldMessenger.of(
          context,
        ).showSnackBar(SnackBar(content: Text(message)));
      }
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    }
  }
}

class _Content extends ConsumerWidget {
  const _Content({
    required this.state,
    required this.onEdit,
    required this.onDelete,
    required this.onLoadMore,
  });

  final ProductUnitScreenState state;
  final ValueChanged<ProductUnit> onEdit;
  final ValueChanged<ProductUnit> onDelete;
  final VoidCallback onLoadMore;

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final products = ref
        .watch(productLookupProvider)
        .when(
          data: (items) => items,
          loading: () => const [],
          error: (_, _) => const [],
        );
    final units = ref
        .watch(unitOfMeasureLookupProvider)
        .when(
          data: (items) => items,
          loading: () => const [],
          error: (_, _) => const [],
        );
    String productName(String id) {
      for (final product in products) {
        if (product.id == id) return product.name;
      }
      return id;
    }

    String unitName(String id) {
      for (final unit in units) {
        if (unit.id == id) return unit.name;
      }
      return id;
    }

    return Column(
      children: [
        if (state.lastSyncResult case final result?)
          Padding(
            padding: const EdgeInsets.all(12),
            child: Text(context.l10n.text(result.message)),
          ),
        Expanded(
          child: state.items.isEmpty
              ? Center(
                  child: Text(
                    context.l10n.text(
                      state.searchQuery.isEmpty
                          ? 'No product units yet'
                          : 'No matching product units',
                    ),
                  ),
                )
              : ListView.separated(
                  padding: const EdgeInsets.fromLTRB(16, 16, 16, 100),
                  itemCount: state.items.length,
                  separatorBuilder: (_, _) => const SizedBox(height: 8),
                  itemBuilder: (context, index) {
                    final item = state.items[index];
                    final failed =
                        item.syncStatus == ProductUnitSyncStatus.failed;
                    final synced =
                        item.syncStatus == ProductUnitSyncStatus.synced;
                    return Card(
                      child: ListTile(
                        leading: const CircleAvatar(
                          child: Icon(Icons.straighten_outlined),
                        ),
                        title: Text(productName(item.productId)),
                        subtitle: Text(
                          '${unitName(item.unitOfMeasureId)} • ${item.conversionFactor}',
                        ),
                        trailing: Row(
                          mainAxisSize: MainAxisSize.min,
                          children: [
                            Tooltip(
                              message:
                                  item.lastSyncError ??
                                  context.l10n.text(
                                    synced
                                        ? 'Synced'
                                        : failed
                                        ? 'Sync failed'
                                        : 'Waiting to sync',
                                  ),
                              child: Icon(
                                failed
                                    ? Icons.cloud_off_outlined
                                    : synced
                                    ? Icons.cloud_done_outlined
                                    : Icons.cloud_upload_outlined,
                              ),
                            ),
                            PopupMenuButton<String>(
                              onSelected: (value) => value == 'edit'
                                  ? onEdit(item)
                                  : onDelete(item),
                              itemBuilder: (context) => [
                                PopupMenuItem(
                                  value: 'edit',
                                  child: Text(context.l10n.text('Edit')),
                                ),
                                PopupMenuItem(
                                  value: 'delete',
                                  child: Text(context.l10n.text('Delete')),
                                ),
                              ],
                            ),
                          ],
                        ),
                      ),
                    );
                  },
                ),
        ),
        if (state.hasNextPage)
          Padding(
            padding: const EdgeInsets.fromLTRB(16, 8, 16, 16),
            child: FilledButton.tonalIcon(
              onPressed: state.isLoadingMore ? null : onLoadMore,
              icon: state.isLoadingMore
                  ? const SizedBox.square(
                      dimension: 18,
                      child: CircularProgressIndicator(strokeWidth: 2),
                    )
                  : const Icon(Icons.expand_more),
              label: Text(context.l10n.text('Load more')),
            ),
          ),
      ],
    );
  }
}
