import 'dart:async';

import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/product_controller.dart';
import '../controllers/product_price_controller.dart';
import '../controllers/product_unit_controller.dart';
import '../controllers/unit_of_measure_controller.dart';
import '../data/data_exception.dart';
import '../l10n/app_localizations.dart';
import '../models/product_price.dart';
import '../models/product_unit.dart';
import '../widgets/active_shop_context.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/home_action.dart';
import '../widgets/locale_action.dart';
import '../widgets/product_price_form_dialog.dart';
import '../widgets/theme_mode_action.dart';

class ProductPricesScreen extends ConsumerStatefulWidget {
  const ProductPricesScreen({super.key});

  @override
  ConsumerState<ProductPricesScreen> createState() =>
      _ProductPricesScreenState();
}

class _ProductPricesScreenState extends ConsumerState<ProductPricesScreen>
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
      ref.read(productPriceControllerProvider.notifier).reload();
    }
  }

  @override
  Widget build(BuildContext context) {
    final state = ref.watch(productPriceControllerProvider);
    return Scaffold(
      appBar: AppBar(
        title: _isSearching
            ? TextField(
                controller: _searchController,
                autofocus: true,
                decoration: InputDecoration(
                  hintText: context.l10n.text('Search product prices...'),
                  border: InputBorder.none,
                ),
                onChanged: _onSearchChanged,
              )
            : Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(context.l10n.text('Product prices')),
                  Text(
                    context.l10n.text('Local-first selling price history'),
                    style: const TextStyle(fontSize: 12),
                  ),
                ],
              ),
        actions: [
          const ActiveShopAction(),
          IconButton(
            icon: Icon(_isSearching ? Icons.close : Icons.search),
            onPressed: _isSearching
                ? _stopSearching
                : () => setState(() => _isSearching = true),
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
              ref.read(productPriceControllerProvider.notifier).reload(),
        ),
        data: (value) => _Content(
          state: value,
          onEdit: _edit,
          onDelete: _delete,
          onLoadMore: () =>
              ref.read(productPriceControllerProvider.notifier).loadNextPage(),
        ),
      ),
      floatingActionButton: FloatingActionButton.extended(
        onPressed: _create,
        icon: const Icon(Icons.add),
        label: Text(context.l10n.text('Add product price')),
      ),
    );
  }

  void _onSearchChanged(String query) {
    _searchDebounce?.cancel();
    _searchDebounce = Timer(const Duration(milliseconds: 400), () {
      ref.read(productPriceControllerProvider.notifier).search(query);
    });
  }

  void _stopSearching() {
    _searchDebounce?.cancel();
    setState(() {
      _isSearching = false;
      _searchController.clear();
    });
    ref.read(productPriceControllerProvider.notifier).search('');
  }

  Future<void> _create() async {
    final draft = await _showForm();
    if (!mounted || draft == null) return;
    await _runMutation(
      () => ref.read(productPriceControllerProvider.notifier).create(draft),
      context.l10n.text('Product price saved locally.'),
    );
  }

  Future<void> _edit(ProductPrice item) async {
    final draft = await _showForm(productPrice: item);
    if (!mounted || draft == null) return;
    await _runMutation(
      () => ref
          .read(productPriceControllerProvider.notifier)
          .createSuccessor(item.id, draft),
      context.l10n.text('Successor price saved locally.'),
    );
  }

  Future<ProductPriceDraft?> _showForm({ProductPrice? productPrice}) async {
    try {
      final productUnits = await ref.read(productUnitLookupProvider.future);
      final products = await ref.read(productLookupProvider.future);
      final units = await ref.read(unitOfMeasureLookupProvider.future);
      if (!mounted) return null;

      return showDialog<ProductPriceDraft>(
        context: context,
        builder: (context) => ProductPriceFormDialog(
          productUnits: productUnits,
          products: products,
          units: units,
          productPrice: productPrice,
        ),
      );
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
      return null;
    }
  }

  Future<void> _delete(ProductPrice item) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text(context.l10n.text('Delete product price?')),
        content: Text(
          context.l10n.text(
            'This price record will disappear now and its deletion will sync later.',
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
      () => ref.read(productPriceControllerProvider.notifier).delete(item.id),
      context.l10n.text('Product price deleted locally.'),
    );
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

  final ProductPriceScreenState state;
  final ValueChanged<ProductPrice> onEdit;
  final ValueChanged<ProductPrice> onDelete;
  final VoidCallback onLoadMore;

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final products = ref.watch(productLookupProvider).value ?? const [];
    final units = ref.watch(unitOfMeasureLookupProvider).value ?? const [];
    final productUnits = ref.watch(productUnitLookupProvider).value ?? const [];

    String label(ProductPrice price) {
      ProductUnit? productUnit;
      for (final item in productUnits) {
        if (item.id == price.productUnitId) {
          productUnit = item;
          break;
        }
      }
      if (productUnit == null) return price.productUnitId;

      var productName = productUnit.productId;
      for (final product in products) {
        if (product.id == productUnit.productId) {
          productName = product.name;
          break;
        }
      }

      var unitName = productUnit.unitOfMeasureId;
      for (final unit in units) {
        if (unit.id == productUnit.unitOfMeasureId) {
          unitName = unit.name;
          break;
        }
      }
      return '$productName - $unitName';
    }

    return Column(
      children: [
        Expanded(
          child: state.items.isEmpty
              ? Center(
                  child: Text(
                    context.l10n.text(
                      state.searchQuery.isEmpty
                          ? 'No product prices yet'
                          : 'No matching product prices',
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
                        item.syncStatus == ProductPriceSyncStatus.failed;
                    final synced =
                        item.syncStatus == ProductPriceSyncStatus.synced;
                    return Card(
                      child: ListTile(
                        leading: const CircleAvatar(
                          child: Icon(Icons.price_change_outlined),
                        ),
                        title: Text(label(item)),
                        subtitle: Text(
                          'Sell price: ${item.sellPrice}\n'
                          'Effective: ${item.effectiveDate.toLocal()}'
                          '${item.endDate == null ? '' : '\nEnds: ${item.endDate!.toLocal()}'}',
                        ),
                        isThreeLine: true,
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
                                  child: Text(
                                    context.l10n.text('Add successor price'),
                                  ),
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
