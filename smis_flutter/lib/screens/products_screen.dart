import 'package:flutter/foundation.dart' show kDebugMode;
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
import '../services/product_sync_service.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/product_form_dialog.dart';
import '../widgets/theme_mode_action.dart';
import '../widgets/locale_action.dart';
import 'unit_of_measures_screen.dart';

class ProductsScreen extends ConsumerStatefulWidget {
  const ProductsScreen({super.key});
  @override
  ConsumerState<ProductsScreen> createState() => _ProductsScreenState();
}

class _ProductsScreenState extends ConsumerState<ProductsScreen> with WidgetsBindingObserver {
  @override
  void initState() { super.initState(); WidgetsBinding.instance.addObserver(this); }
  @override
  void dispose() { WidgetsBinding.instance.removeObserver(this); super.dispose(); }
  @override
  void didChangeAppLifecycleState(AppLifecycleState state) {
    if (state == AppLifecycleState.resumed) ref.read(productControllerProvider.notifier).reload();
  }

  @override
  Widget build(BuildContext context) {
    final productState = ref.watch(productControllerProvider);
    final units = ref.watch(unitOfMeasureControllerProvider).value?.units ?? const <UnitOfMeasure>[];
    final categories = ref.watch(categoryControllerProvider).value?.categories ?? const <Category>[];
    final hasUnits = units.isNotEmpty;
    return Scaffold(
      appBar: AppBar(
        title: Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
          Text(context.l10n.text('Products')), Text(context.l10n.text('Local-first inventory setup'), style: const TextStyle(fontSize: 12, fontWeight: FontWeight.normal)),
        ]),
        actions: [
          productState.maybeWhen(
            data: (state) => Badge(
              isLabelVisible: state.pendingCount > 0, label: Text('${state.pendingCount}'),
              child: IconButton.filledTonal(
                tooltip: context.l10n.text('Sync products'), onPressed: state.isSyncing ? null : _sync,
                icon: state.isSyncing ? const SizedBox.square(dimension: 18, child: CircularProgressIndicator(strokeWidth: 2)) : const Icon(Icons.sync),
              ),
            ),
            orElse: () => const SizedBox.shrink(),
          ),
          const LocaleAction(),
          const ThemeModeAction(), const SizedBox(width: 8),
        ],
      ),
      drawer: const AppDrawer(),
      body: SafeArea(child: Center(child: ConstrainedBox(
        constraints: const BoxConstraints(maxWidth: 900),
        child: productState.when(
          loading: () => const Center(child: CircularProgressIndicator()),
          error: (error, stackTrace) => AppErrorView(error: error, stackTrace: stackTrace, onRetry: () => ref.read(productControllerProvider.notifier).reload()),
          data: (state) => _Content(state: state, hasUnits: hasUnits, units: units, categories: categories, onEdit: _edit, onDelete: _delete),
        ),
      ))),
      floatingActionButton: FloatingActionButton.extended(
        onPressed: hasUnits ? () => _create(units, categories) : null,
        icon: const Icon(Icons.add), label: Text(context.l10n.text('Add product')),
      ),
    );
  }

  Future<void> _create(List<UnitOfMeasure> units, List<Category> categories) async {
    final draft = await showDialog<ProductDraft>(context: context, builder: (context) => ProductFormDialog(units: units, categories: categories));
    if (draft == null) return;
    await _runMutation(() => ref.read(productControllerProvider.notifier).create(draft), context.l10n.text('Product saved locally.'));
  }
  Future<void> _edit(Product product) async {
    final units = ref.read(unitOfMeasureControllerProvider).value?.units ?? const <UnitOfMeasure>[];
    final categories = ref.read(categoryControllerProvider).value?.categories ?? const <Category>[];
    final draft = await showDialog<ProductDraft>(context: context, builder: (context) => ProductFormDialog(product: product, units: units, categories: categories));
    if (draft == null) return;
    await _runMutation(() => ref.read(productControllerProvider.notifier).updateProduct(product.id, draft), context.l10n.text('Product updated locally.'));
  }
  Future<void> _delete(Product product) async {
    final confirmed = await showDialog<bool>(context: context, builder: (context) => AlertDialog(
      title: Text(context.l10n.text('Delete product?')), content: Text(context.l10n.text('“{name}” will disappear now and its deletion will sync later.', {'name': product.name})),
      actions: [TextButton(onPressed: () => Navigator.pop(context, false), child: Text(context.l10n.text('Cancel'))), FilledButton.tonal(onPressed: () => Navigator.pop(context, true), child: Text(context.l10n.text('Delete offline')))],
    ));
    if (confirmed != true) return;
    await _runMutation(() => ref.read(productControllerProvider.notifier).delete(product.id), context.l10n.text('Product deleted locally.'));
  }
  Future<void> _sync() async {
    try {
      final result = await ref.read(productControllerProvider.notifier).syncNow();
      if (!mounted || !result.success) return;
      ScaffoldMessenger.of(context).showSnackBar(SnackBar(content: Text(context.l10n.syncMessage(result.message)), backgroundColor: Theme.of(context).colorScheme.primary));
    } catch (error, stackTrace) {
      if (!mounted) return;
      AppErrorNotification.show(context, error, stackTrace);
      await ref.read(productControllerProvider.notifier).reload();
    }
  }
  Future<void> _runMutation(Future<void> Function() action, String message) async {
    try { await action(); if (mounted) ScaffoldMessenger.of(context).showSnackBar(SnackBar(content: Text(message))); }
    catch (error, stackTrace) { if (mounted) AppErrorNotification.show(context, error, stackTrace); }
  }
}

class _Content extends StatelessWidget {
  const _Content({required this.state, required this.hasUnits, required this.units, required this.categories, required this.onEdit, required this.onDelete});
  final ProductScreenState state;
  final bool hasUnits;
  final List<UnitOfMeasure> units;
  final List<Category> categories;
  final ValueChanged<Product> onEdit;
  final ValueChanged<Product> onDelete;
  @override
  Widget build(BuildContext context) => Column(children: [
    if (state.lastSyncResult case final result?) _SyncSummary(result: result),
    if (!hasUnits) const _MissingUnitNotice(),
    Expanded(child: state.products.isEmpty ? const _EmptyView() : ListView.separated(
      padding: const EdgeInsets.fromLTRB(16, 16, 16, 100), itemCount: state.products.length,
      separatorBuilder: (_, _) => const SizedBox(height: 10),
      itemBuilder: (context, index) { final product = state.products[index]; return _ProductCard(product: product, unitName: _unitName(product.baseUnitId), categoryName: _categoryName(product.categoryId), onEdit: () => onEdit(product), onDelete: () => onDelete(product)); },
    )),
  ]);
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

class _SyncSummary extends StatelessWidget {
  const _SyncSummary({required this.result}); final ProductSyncResult result;
  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    final summary = '${context.l10n.syncMessage(result.message)} ${context.l10n.text('Pulled {pulled}, pushed {pushed}, conflicts resolved {conflicts}, pending {pending}.', {'pulled': result.pulled, 'pushed': result.pushed, 'conflicts': result.conflictsResolved, 'pending': result.pending})}';
    final message = kDebugMode && result.failures.isNotEmpty ? '$summary\n\n${result.failures.map((failure) => failure.toDevelopmentString()).join('\n\n')}' : summary;
    return Container(width: double.infinity, margin: const EdgeInsets.fromLTRB(16, 12, 16, 0), padding: const EdgeInsets.all(12), decoration: BoxDecoration(color: result.success ? colors.primaryContainer : colors.errorContainer, borderRadius: BorderRadius.circular(12)), child: ConstrainedBox(constraints: BoxConstraints(maxHeight: kDebugMode && !result.success ? 280 : double.infinity), child: SingleChildScrollView(child: SelectableText(message, style: TextStyle(color: result.success ? colors.onPrimaryContainer : colors.onErrorContainer)))));
  }
}

class _ProductCard extends StatelessWidget {
  const _ProductCard({required this.product, required this.unitName, required this.categoryName, required this.onEdit, required this.onDelete});
  final Product product; final String unitName; final String? categoryName; final VoidCallback onEdit; final VoidCallback onDelete;
  @override
  Widget build(BuildContext context) => Card(child: ListTile(
    leading: CircleAvatar(child: Text(product.name.characters.first.toUpperCase())),
    title: Row(children: [Flexible(child: Text(product.name)), const SizedBox(width: 8), _SyncStateIcon(product: product)]),
    subtitle: Column(crossAxisAlignment: CrossAxisAlignment.start, children: [Text(context.l10n.text('Base unit: {name}', {'name': unitName})), if (categoryName != null) Text(context.l10n.text('Category: {name}', {'name': categoryName!})), if (product.sku case final sku?) Text(context.l10n.text('SKU: {value}', {'value': sku})), if (product.description case final description?) Text(description, maxLines: 2, overflow: TextOverflow.ellipsis)]),
    isThreeLine: true,
    trailing: PopupMenuButton<String>(onSelected: (value) => value == 'edit' ? onEdit() : onDelete(), itemBuilder: (context) => [PopupMenuItem(value: 'edit', child: Text(context.l10n.text('Edit'))), PopupMenuItem(value: 'delete', child: Text(context.l10n.text('Delete')))]),
  ));
}
class _SyncStateIcon extends StatelessWidget { const _SyncStateIcon({required this.product}); final Product product; @override Widget build(BuildContext context) { final failed = product.syncStatus == ProductSyncStatus.failed; final synced = product.syncStatus == ProductSyncStatus.synced; return Tooltip(message: product.lastSyncError ?? context.l10n.text(synced ? 'Synced' : failed ? 'Sync failed' : 'Waiting to sync'), child: Icon(failed ? Icons.cloud_off_outlined : synced ? Icons.cloud_done_outlined : Icons.cloud_upload_outlined, size: 18, color: failed ? Theme.of(context).colorScheme.error : Theme.of(context).colorScheme.outline)); } }
class _EmptyView extends StatelessWidget { const _EmptyView(); @override Widget build(BuildContext context) => Center(child: Padding(padding: const EdgeInsets.all(32), child: Column(mainAxisSize: MainAxisSize.min, children: [const Icon(Icons.inventory_2_outlined, size: 56), const SizedBox(height: 12), Text(context.l10n.text('No products yet')), const SizedBox(height: 4), Text(context.l10n.text('Add one now—even while completely offline.'))]))) ; }
class _MissingUnitNotice extends StatelessWidget {
  const _MissingUnitNotice();
  @override
  Widget build(BuildContext context) => Padding(
    padding: const EdgeInsets.fromLTRB(16, 12, 16, 0),
    child: MaterialBanner(
      content: Text(context.l10n.text('Create or sync a unit of measurement before adding a product.')),
      leading: const Icon(Icons.info_outline),
      actions: [
        TextButton(
          onPressed: () => Navigator.of(context).push(
            MaterialPageRoute<void>(builder: (context) => const UnitOfMeasuresScreen()),
          ),
          child: Text(context.l10n.text('Manage units').toUpperCase()),
        ),
      ],
    ),
  );
}
