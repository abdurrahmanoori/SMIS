import 'dart:async';
import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/category_controller.dart';
import '../controllers/product_controller.dart';
import '../controllers/unit_of_measure_controller.dart';
import '../data/data_exception.dart';
import '../models/category.dart';
import '../models/product.dart';
import '../models/unit_of_measure.dart';
import '../l10n/app_localizations.dart';
import '../widgets/app_drawer.dart';
import '../widgets/active_shop_context.dart';
import '../widgets/app_error_view.dart';
import '../widgets/product_form_dialog.dart';
import '../widgets/theme_mode_action.dart';
import '../widgets/locale_action.dart';
import '../widgets/home_action.dart';
import 'unit_of_measures_screen.dart';

class ProductsScreen extends ConsumerStatefulWidget {
  const ProductsScreen({super.key});
  @override
  ConsumerState<ProductsScreen> createState() => _ProductsScreenState();
}

class _ProductsScreenState extends ConsumerState<ProductsScreen>
    with WidgetsBindingObserver {
  final _searchController = TextEditingController();
  bool _isSearching = false;
  Timer? _searchDebounce;

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

  void _onSearchChanged(String query) {
    _searchDebounce?.cancel();
    _searchDebounce = Timer(const Duration(milliseconds: 500), () {
      ref.read(productControllerProvider.notifier).search(query);
    });
  }

  void _stopSearching() {
    _searchDebounce?.cancel();
    setState(() {
      _isSearching = false;
      _searchController.clear();
    });
    ref.read(productControllerProvider.notifier).search('');
  }

  @override
  void didChangeAppLifecycleState(AppLifecycleState state) {
    if (state == AppLifecycleState.resumed) {
      ref.invalidate(categoryLookupProvider);
      ref.invalidate(unitOfMeasureLookupProvider);
      ref.read(productControllerProvider.notifier).reload();
    }
  }

  @override
  Widget build(BuildContext context) {
    final productState = ref.watch(productControllerProvider);
    final units =
        ref.watch(unitOfMeasureLookupProvider).value ?? const <UnitOfMeasure>[];
    final categories =
        ref.watch(categoryLookupProvider).value ?? const <Category>[];
    final hasUnits = units.isNotEmpty;
    return Scaffold(
      appBar: AppBar(
        title: _isSearching
            ? TextField(
                controller: _searchController,
                autofocus: true,
                decoration: InputDecoration(
                  hintText: context.l10n.text('Search products...'),
                  border: InputBorder.none,
                ),
                onChanged: _onSearchChanged,
              )
            : Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(context.l10n.text('Products')),
                  Text(
                    context.l10n.text('Local-first inventory setup'),
                    style: const TextStyle(
                      fontSize: 12,
                      fontWeight: FontWeight.normal,
                    ),
                  ),
                ],
              ),
        actions: [
          const ActiveShopAction(),
          if (_isSearching)
            IconButton(icon: const Icon(Icons.close), onPressed: _stopSearching)
          else
            IconButton(
              icon: const Icon(Icons.search),
              onPressed: () => setState(() => _isSearching = true),
            ),
          const HomeAction(),
          const LocaleAction(),
          const ThemeModeAction(),
          const SizedBox(width: 8),
        ],
      ),
      drawer: const AppDrawer(),
      body: SafeArea(
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 900),
            child: productState.when(
              loading: () => const Center(child: CircularProgressIndicator()),
              error: (error, stackTrace) => AppErrorView(
                error: error,
                stackTrace: stackTrace,
                onRetry: () =>
                    ref.read(productControllerProvider.notifier).reload(),
              ),
              data: (state) => _Content(
                state: state,
                hasUnits: hasUnits,
                units: units,
                categories: categories,
                onEdit: _edit,
                onDelete: _delete,
              ),
            ),
          ),
        ),
      ),
      floatingActionButton: FloatingActionButton.extended(
        onPressed: hasUnits ? _create : null,
        icon: const Icon(Icons.add),
        label: Text(context.l10n.text('Add product')),
      ),
    );
  }

  Future<void> _create() async {
    final units = await _loadUnits();
    final categories = await _loadCategories();
    if (units == null || categories == null || !mounted) return;
    final draft = await showDialog<ProductDraft>(
      context: context,
      builder: (context) =>
          ProductFormDialog(units: units, categories: categories),
    );
    if (draft == null || !mounted) return;
    await _runMutation(
      () => ref.read(productControllerProvider.notifier).create(draft),
      context.l10n.text('Product saved locally.'),
    );
  }

  Future<void> _edit(Product product) async {
    final units = await _loadUnits();
    final categories = await _loadCategories();
    if (units == null || categories == null || !mounted) return;
    final draft = await showDialog<ProductDraft>(
      context: context,
      builder: (context) => ProductFormDialog(
        product: product,
        units: units,
        categories: categories,
      ),
    );
    if (draft == null || !mounted) return;
    await _runMutation(
      () => ref
          .read(productControllerProvider.notifier)
          .updateProduct(product.id, draft),
      context.l10n.text('Product updated locally.'),
    );
  }

  Future<void> _delete(Product product) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text(context.l10n.text('Delete product?')),
        content: Text(
          context.l10n.text(
            '“{name}” will disappear now and its deletion will sync later.',
            {'name': product.name},
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
    if (confirmed != true || !mounted) return;
    await _runMutation(
      () => ref.read(productControllerProvider.notifier).delete(product.id),
      context.l10n.text('Product deleted locally.'),
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

  Future<List<Category>?> _loadCategories() async {
    try {
      return await ref.read(categoryLookupProvider.future);
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
      return null;
    }
  }

  Future<List<UnitOfMeasure>?> _loadUnits() async {
    try {
      return await ref.read(unitOfMeasureLookupProvider.future);
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
      return null;
    }
  }
}

class _Content extends StatelessWidget {
  const _Content({
    required this.state,
    required this.hasUnits,
    required this.units,
    required this.categories,
    required this.onEdit,
    required this.onDelete,
  });
  final ProductScreenState state;
  final bool hasUnits;
  final List<UnitOfMeasure> units;
  final List<Category> categories;
  final ValueChanged<Product> onEdit;
  final ValueChanged<Product> onDelete;
  @override
  Widget build(BuildContext context) => Column(
    children: [
      if (!hasUnits) const _MissingUnitNotice(),
      Expanded(
        child: state.products.isEmpty
            ? _EmptyView(isSearch: state.searchQuery.isNotEmpty)
            : ListView.separated(
                padding: const EdgeInsets.fromLTRB(16, 16, 16, 100),
                itemCount: state.products.length,
                separatorBuilder: (_, _) => const SizedBox(height: 10),
                itemBuilder: (context, index) {
                  final product = state.products[index];
                  return _ProductCard(
                    product: product,
                    unitName: _unitName(product.baseUnitId),
                    categoryName: _categoryName(product.categoryId),
                    onEdit: () => onEdit(product),
                    onDelete: () => onDelete(product),
                  );
                },
              ),
      ),
    ],
  );
  String _unitName(String id) {
    for (final unit in units) {
      if (unit.id == id) return unit.name;
    }
    return id;
  }

  String? _categoryName(String? id) {
    if (id == null) return null;
    for (final category in categories) {
      if (category.id == id) return category.name;
    }
    return null;
  }
}

class _ProductCard extends StatelessWidget {
  const _ProductCard({
    required this.product,
    required this.unitName,
    required this.categoryName,
    required this.onEdit,
    required this.onDelete,
  });
  final Product product;
  final String unitName;
  final String? categoryName;
  final VoidCallback onEdit;
  final VoidCallback onDelete;
  @override
  Widget build(BuildContext context) => Card(
    child: ListTile(
      leading: CircleAvatar(
        child: Text(product.name.characters.first.toUpperCase()),
      ),
      title: Row(
        children: [
          Flexible(child: Text(product.name)),
          const SizedBox(width: 8),
          _SyncStateIcon(product: product),
        ],
      ),
      subtitle: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(context.l10n.text('Base unit: {name}', {'name': unitName})),
          if (categoryName != null)
            Text(
              context.l10n.text('Category: {name}', {'name': categoryName!}),
            ),
          if (product.sku case final sku?)
            Text(context.l10n.text('SKU: {value}', {'value': sku})),
          if (product.description case final description?)
            Text(description, maxLines: 2, overflow: TextOverflow.ellipsis),
        ],
      ),
      isThreeLine: true,
      trailing: PopupMenuButton<String>(
        onSelected: (value) => value == 'edit' ? onEdit() : onDelete(),
        itemBuilder: (context) => [
          PopupMenuItem(value: 'edit', child: Text(context.l10n.text('Edit'))),
          PopupMenuItem(
            value: 'delete',
            child: Text(context.l10n.text('Delete')),
          ),
        ],
      ),
    ),
  );
}

class _SyncStateIcon extends StatelessWidget {
  const _SyncStateIcon({required this.product});
  final Product product;
  @override
  Widget build(BuildContext context) {
    final failed = product.syncStatus == ProductSyncStatus.failed;
    final synced = product.syncStatus == ProductSyncStatus.synced;
    return Tooltip(
      message:
          product.lastSyncError ??
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
        size: 18,
        color: failed
            ? Theme.of(context).colorScheme.error
            : Theme.of(context).colorScheme.outline,
      ),
    );
  }
}

class _EmptyView extends StatelessWidget {
  const _EmptyView({this.isSearch = false});

  final bool isSearch;

  @override
  Widget build(BuildContext context) => Center(
    child: Padding(
      padding: const EdgeInsets.all(32),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          Icon(
            isSearch ? Icons.search_off : Icons.inventory_2_outlined,
            size: 56,
          ),
          const SizedBox(height: 12),
          Text(
            context.l10n.text(
              isSearch ? 'No matching products' : 'No products yet',
            ),
          ),
          const SizedBox(height: 4),
          Text(
            context.l10n.text(
              isSearch
                  ? 'Try a different search term.'
                  : 'Add one now—even while completely offline.',
            ),
          ),
        ],
      ),
    ),
  );
}

class _MissingUnitNotice extends StatelessWidget {
  const _MissingUnitNotice();
  @override
  Widget build(BuildContext context) => Padding(
    padding: const EdgeInsets.fromLTRB(16, 12, 16, 0),
    child: MaterialBanner(
      content: Text(
        context.l10n.text(
          'Create a unit of measurement before adding a product.',
        ),
      ),
      leading: const Icon(Icons.info_outline),
      actions: [
        TextButton(
          onPressed: () => Navigator.of(context).push(
            MaterialPageRoute<void>(
              builder: (context) => const UnitOfMeasuresScreen(),
            ),
          ),
          child: Text(context.l10n.text('Manage units').toUpperCase()),
        ),
      ],
    ),
  );
}
