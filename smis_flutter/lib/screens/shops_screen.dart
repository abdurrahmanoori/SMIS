import 'package:flutter/foundation.dart' show kDebugMode;
import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../controllers/shop_controller.dart';
import '../data/data_exception.dart';
import '../models/shop.dart';
import '../services/shop_sync_service.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/shop_form_dialog.dart';
import '../widgets/theme_mode_action.dart';

class ShopsScreen extends ConsumerStatefulWidget {
  const ShopsScreen({super.key});
  @override ConsumerState<ShopsScreen> createState() => _ShopsScreenState();
}
class _ShopsScreenState extends ConsumerState<ShopsScreen> with WidgetsBindingObserver {
  @override void initState() { super.initState(); WidgetsBinding.instance.addObserver(this); }
  @override void dispose() { WidgetsBinding.instance.removeObserver(this); super.dispose(); }
  @override void didChangeAppLifecycleState(AppLifecycleState state) { if (state == AppLifecycleState.resumed) ref.read(shopControllerProvider.notifier).reload(); }
  @override Widget build(BuildContext context) {
    final shops = ref.watch(shopControllerProvider);
    final session = ref.watch(authControllerProvider).session;
    final canCreate = session?.roles.any((role) => role.trim().toLowerCase() == 'superadmin') ?? false;
    return Scaffold(
      appBar: AppBar(title: const Column(crossAxisAlignment: CrossAxisAlignment.start, children: [Text('Shops'), Text('Local-first administration', style: TextStyle(fontSize: 12, fontWeight: FontWeight.normal))]), actions: [
        shops.maybeWhen(data: (state) => Badge(isLabelVisible: state.pendingCount > 0, label: Text('${state.pendingCount}'), child: IconButton.filledTonal(tooltip: 'Sync shops', onPressed: state.isSyncing ? null : _sync, icon: state.isSyncing ? const SizedBox.square(dimension: 18, child: CircularProgressIndicator(strokeWidth: 2)) : const Icon(Icons.sync))), orElse: () => const SizedBox.shrink()),
        const ThemeModeAction(), const SizedBox(width: 8),
      ]),
      drawer: const AppDrawer(),
      body: SafeArea(child: Center(child: ConstrainedBox(constraints: const BoxConstraints(maxWidth: 900), child: shops.when(
        loading: () => const Center(child: CircularProgressIndicator()),
        error: (error, stackTrace) => AppErrorView(error: error, stackTrace: stackTrace, onRetry: () => ref.read(shopControllerProvider.notifier).reload()),
        data: (state) => _Content(state: state, canCreate: canCreate, onEdit: _edit, onDelete: _delete),
      )))),
      floatingActionButton: canCreate ? FloatingActionButton.extended(onPressed: _create, icon: const Icon(Icons.add_business_outlined), label: const Text('Add shop')) : null,
    );
  }
  Future<void> _create() async { final draft = await showDialog<ShopDraft>(context: context, builder: (context) => const ShopFormDialog()); if (draft != null) await _runMutation(() => ref.read(shopControllerProvider.notifier).create(draft), 'Shop saved locally.'); }
  Future<void> _edit(Shop shop) async { final draft = await showDialog<ShopDraft>(context: context, builder: (context) => ShopFormDialog(shop: shop)); if (draft != null) await _runMutation(() => ref.read(shopControllerProvider.notifier).updateShop(shop.id, draft), 'Shop updated locally.'); }
  Future<void> _delete(Shop shop) async { final confirmed = await showDialog<bool>(context: context, builder: (context) => AlertDialog(title: const Text('Delete shop?'), content: Text('“${shop.name}” will disappear now and its deletion will sync later.'), actions: [TextButton(onPressed: () => Navigator.pop(context, false), child: const Text('Cancel')), FilledButton.tonal(onPressed: () => Navigator.pop(context, true), child: const Text('Delete offline'))])); if (confirmed == true) await _runMutation(() => ref.read(shopControllerProvider.notifier).delete(shop.id), 'Shop deleted locally.'); }
  Future<void> _sync() async { try { final result = await ref.read(shopControllerProvider.notifier).syncNow(); if (!mounted || !result.success) return; ScaffoldMessenger.of(context).showSnackBar(SnackBar(content: Text(result.message), backgroundColor: Theme.of(context).colorScheme.primary)); } catch (error, stackTrace) { if (!mounted) return; AppErrorNotification.show(context, error, stackTrace); await ref.read(shopControllerProvider.notifier).reload(); } }
  Future<void> _runMutation(Future<void> Function() action, String message) async { try { await action(); if (mounted) ScaffoldMessenger.of(context).showSnackBar(SnackBar(content: Text(message))); } catch (error, stackTrace) { if (mounted) AppErrorNotification.show(context, error, stackTrace); } }
}

class _Content extends StatelessWidget {
  const _Content({required this.state, required this.canCreate, required this.onEdit, required this.onDelete});
  final ShopScreenState state; final bool canCreate; final ValueChanged<Shop> onEdit; final ValueChanged<Shop> onDelete;
  @override Widget build(BuildContext context) => Column(children: [
    if (state.lastSyncResult case final result?) _SyncSummary(result: result),
    if (!canCreate) const _ShopPermissionNotice(),
    Expanded(child: state.shops.isEmpty ? const _EmptyView() : ListView.separated(padding: const EdgeInsets.fromLTRB(16, 16, 16, 100), itemCount: state.shops.length, separatorBuilder: (_, _) => const SizedBox(height: 10), itemBuilder: (context, index) { final shop = state.shops[index]; return _ShopCard(shop: shop, onEdit: () => onEdit(shop), onDelete: () => onDelete(shop)); })),
  ]);
}
class _SyncSummary extends StatelessWidget { const _SyncSummary({required this.result}); final ShopSyncResult result; @override Widget build(BuildContext context) { final colors = Theme.of(context).colorScheme; final summary = '${result.message} Pulled ${result.pulled}, pushed ${result.pushed}, conflicts resolved ${result.conflictsResolved}, pending ${result.pending}.'; final message = kDebugMode && result.failures.isNotEmpty ? '$summary\n\n${result.failures.map((failure) => failure.toDevelopmentString()).join('\n\n')}' : summary; return Container(width: double.infinity, margin: const EdgeInsets.fromLTRB(16, 12, 16, 0), padding: const EdgeInsets.all(12), decoration: BoxDecoration(color: result.success ? colors.primaryContainer : colors.errorContainer, borderRadius: BorderRadius.circular(12)), child: ConstrainedBox(constraints: BoxConstraints(maxHeight: kDebugMode && !result.success ? 280 : double.infinity), child: SingleChildScrollView(child: SelectableText(message, style: TextStyle(color: result.success ? colors.onPrimaryContainer : colors.onErrorContainer))))); } }
class _ShopCard extends StatelessWidget { const _ShopCard({required this.shop, required this.onEdit, required this.onDelete}); final Shop shop; final VoidCallback onEdit; final VoidCallback onDelete; @override Widget build(BuildContext context) => Card(child: ListTile(leading: CircleAvatar(child: Text(shop.name.characters.first.toUpperCase())), title: Row(children: [Flexible(child: Text(shop.name)), const SizedBox(width: 8), _SyncStateIcon(shop: shop)]), subtitle: Column(crossAxisAlignment: CrossAxisAlignment.start, children: [Text(shop.shopType == ShopType.retailShop ? 'Retail shop' : 'Wholesale shop'), if (shop.address case final address?) Text(address, maxLines: 1, overflow: TextOverflow.ellipsis), Text(shop.isActive ? 'Active' : 'Inactive')]), isThreeLine: true, trailing: PopupMenuButton<String>(onSelected: (value) => value == 'edit' ? onEdit() : onDelete(), itemBuilder: (context) => const [PopupMenuItem(value: 'edit', child: Text('Edit')), PopupMenuItem(value: 'delete', child: Text('Delete'))]))); }
class _SyncStateIcon extends StatelessWidget { const _SyncStateIcon({required this.shop}); final Shop shop; @override Widget build(BuildContext context) { final failed = shop.syncStatus == ShopSyncStatus.failed; final synced = shop.syncStatus == ShopSyncStatus.synced; return Tooltip(message: shop.lastSyncError ?? (synced ? 'Synced' : failed ? 'Sync failed' : 'Waiting to sync'), child: Icon(failed ? Icons.cloud_off_outlined : synced ? Icons.cloud_done_outlined : Icons.cloud_upload_outlined, size: 18, color: failed ? Theme.of(context).colorScheme.error : Theme.of(context).colorScheme.outline)); } }
class _EmptyView extends StatelessWidget { const _EmptyView(); @override Widget build(BuildContext context) => const Center(child: Padding(padding: EdgeInsets.all(32), child: Column(mainAxisSize: MainAxisSize.min, children: [Icon(Icons.storefront_outlined, size: 56), SizedBox(height: 12), Text('No shops available offline'), SizedBox(height: 4), Text('Press Sync to pull your assigned shop.')]))) ; }
class _ShopPermissionNotice extends StatelessWidget { const _ShopPermissionNotice(); @override Widget build(BuildContext context) => Padding(padding: const EdgeInsets.fromLTRB(16, 12, 16, 0), child: MaterialBanner(content: const Text('Your account can edit its assigned shop. Creating additional shops requires a SuperAdmin account.'), leading: const Icon(Icons.admin_panel_settings_outlined), actions: const [])); }
