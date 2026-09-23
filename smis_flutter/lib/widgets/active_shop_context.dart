import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../controllers/shop_context_controller.dart';
import '../controllers/shop_controller.dart';
import '../data/data_exception.dart';
import '../l10n/app_localizations.dart';
import '../models/shop.dart';

class ActiveShopAction extends ConsumerWidget {
  const ActiveShopAction({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final session = ref.watch(authControllerProvider).session;
    if (session == null) return const SizedBox.shrink();
    final shop = ref.watch(activeShopProvider);
    final switching = ref.watch(shopContextControllerProvider);
    final label = shop?.name ?? _shortShopId(session.shopId);

    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 8, horizontal: 4),
      child: session.isSuperAdmin
          ? ActionChip(
              avatar: switching
                  ? const SizedBox.square(
                      dimension: 16,
                      child: CircularProgressIndicator(strokeWidth: 2),
                    )
                  : const Icon(Icons.storefront_outlined, size: 18),
              label: Text(label),
              tooltip: context.l10n.text('Switch active shop'),
              onPressed: switching ? null : () => _chooseShop(context, ref),
            )
          : Chip(
              avatar: const Icon(Icons.storefront_outlined, size: 18),
              label: Text(label),
            ),
    );
  }
}

class ActiveShopDrawerTile extends ConsumerWidget {
  const ActiveShopDrawerTile({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final session = ref.watch(authControllerProvider).session;
    if (session == null) return const SizedBox.shrink();
    final shop = ref.watch(activeShopProvider);
    final switching = ref.watch(shopContextControllerProvider);

    return ListTile(
      leading: const Icon(Icons.storefront_outlined),
      title: Text(context.l10n.text('Active shop')),
      subtitle: Text(shop?.name ?? _shortShopId(session.shopId)),
      trailing: session.isSuperAdmin
          ? switching
                ? const SizedBox.square(
                    dimension: 20,
                    child: CircularProgressIndicator(strokeWidth: 2),
                  )
                : const Icon(Icons.swap_horiz)
          : const Icon(Icons.lock_outline, size: 18),
      onTap: session.isSuperAdmin && !switching
          ? () => _chooseShop(context, ref)
          : null,
    );
  }
}

Future<void> _chooseShop(BuildContext context, WidgetRef ref) async {
  final session = ref.read(authControllerProvider).session;
  if (session == null || !session.isSuperAdmin) return;

  final selected = await showDialog<Shop>(
    context: context,
    builder: (dialogContext) => Consumer(
      builder: (context, ref, _) {
        final shops = ref.watch(shopControllerProvider);
        return AlertDialog(
          title: Text(context.l10n.text('Switch shop')),
          content: SizedBox(
            width: 480,
            child: shops.when(
              loading: () => const Center(child: CircularProgressIndicator()),
              error: (error, _) => Text(error.toString()),
              data: (state) {
                final available = state.shops
                    .where((shop) => shop.isActive)
                    .toList(growable: false);
                if (available.isEmpty) {
                  return Text(
                    context.l10n.text('No active shops are available.'),
                  );
                }
                return ListView.separated(
                  shrinkWrap: true,
                  itemCount: available.length,
                  separatorBuilder: (_, _) => const Divider(height: 1),
                  itemBuilder: (context, index) {
                    final shop = available[index];
                    final active = shop.id == session.shopId;
                    return ListTile(
                      leading: Icon(
                        active ? Icons.check_circle : Icons.store_outlined,
                      ),
                      title: Text(shop.name),
                      subtitle: shop.address == null
                          ? null
                          : Text(shop.address!),
                      enabled: !active,
                      onTap: active
                          ? null
                          : () => Navigator.of(dialogContext).pop(shop),
                    );
                  },
                );
              },
            ),
          ),
          actions: [
            TextButton(
              onPressed: () => Navigator.of(dialogContext).pop(),
              child: Text(context.l10n.text('Cancel')),
            ),
          ],
        );
      },
    ),
  );

  if (selected == null || !context.mounted) return;
  try {
    await ref.read(shopContextControllerProvider.notifier).switchShop(selected);
    if (!context.mounted) return;
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: Text(
          context.l10n.text('Active shop changed to {name}.', {
            'name': selected.name,
          }),
        ),
      ),
    );
  } catch (error, stackTrace) {
    if (!context.mounted) return;
    AppErrorNotification.show(context, error, stackTrace);
  }
}

String _shortShopId(String shopId) =>
    shopId.length <= 8 ? shopId : '${shopId.substring(0, 8)}…';
