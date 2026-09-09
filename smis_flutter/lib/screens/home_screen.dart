import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../controllers/category_controller.dart';
import '../controllers/product_controller.dart';
import '../controllers/shop_controller.dart';
import '../controllers/unit_of_measure_controller.dart';
import '../widgets/app_drawer.dart';
import '../widgets/locale_action.dart';
import '../widgets/theme_mode_action.dart';
import '../l10n/app_localizations.dart';
import 'categories_screen.dart';
import 'profile_screen.dart';
import 'products_screen.dart';
import 'shops_screen.dart';
import 'unit_of_measures_screen.dart';

class HomeScreen extends ConsumerWidget {
  const HomeScreen({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final session = ref.watch(authControllerProvider).session;
    final l10n = context.l10n;
    final categoryState = ref.watch(categoryControllerProvider);
    final pendingCount = categoryState.value?.pendingCount ?? 0;
    final unitState = ref.watch(unitOfMeasureControllerProvider);
    final unitPendingCount = unitState.value?.pendingCount ?? 0;
    final shopState = ref.watch(shopControllerProvider);
    final shopPendingCount = shopState.value?.pendingCount ?? 0;
    final productState = ref.watch(productControllerProvider);
    final productPendingCount = productState.value?.pendingCount ?? 0;
    final totalPendingCount = pendingCount +
        unitPendingCount +
        shopPendingCount +
        productPendingCount;

    // HomeScreen is only shown by the authentication gate after a session is
    // restored or created, but keep this defensive fallback for state changes.
    if (session == null) return const SizedBox.shrink();

    return Scaffold(
      appBar: AppBar(
        title: const Text('SMIS'),
        actions: const [
          LocaleAction(),
          ThemeModeAction(),
          SizedBox(width: 8),
        ],
      ),
      drawer: const AppDrawer(),
      body: SafeArea(
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 900),
            child: ListView(
              padding: const EdgeInsets.fromLTRB(20, 24, 20, 32),
              children: [
                Text(
                  l10n.text('Welcome back, {name}', {'name': session.userName}),
                  style: Theme.of(context).textTheme.headlineMedium,
                ),
                const SizedBox(height: 8),
                Text(
                  l10n.text('Choose an area to continue managing your shop.'),
                  style: Theme.of(context).textTheme.bodyLarge,
                ),
                const SizedBox(height: 28),
                LayoutBuilder(
                  builder: (context, constraints) {
                    final wideLayout = constraints.maxWidth >= 620;
                    final categoriesCard = _HomeActionCard(
                      icon: Icons.category_outlined,
                      title: l10n.text('Categories'),
                      description: pendingCount == 0
                          ? l10n.text('Manage your local category list.')
                          : l10n.text(
                              pendingCount == 1
                                  ? '{count} local change waiting to sync.'
                                  : '{count} local changes waiting to sync.',
                              {'count': pendingCount},
                            ),
                      badgeLabel: pendingCount == 0
                          ? null
                          : l10n.text('{count} pending', {'count': pendingCount}),
                      onTap: () => _openCategories(context),
                    );
                    final profileCard = _HomeActionCard(
                      icon: Icons.person_outline,
                      title: l10n.text('My profile'),
                      description: l10n.text(
                        'View your account, shop details, and profile settings.',
                      ),
                      onTap: () => _openProfile(context),
                    );
                    final unitsCard = _HomeActionCard(
                      icon: Icons.straighten_outlined,
                      title: l10n.text('Units of measurement'),
                      description: unitPendingCount == 0
                          ? l10n.text('Manage your local measurement units.')
                          : l10n.text(
                              unitPendingCount == 1
                                  ? '{count} local change waiting to sync.'
                                  : '{count} local changes waiting to sync.',
                              {'count': unitPendingCount},
                            ),
                      badgeLabel: unitPendingCount == 0
                          ? null
                          : l10n.text(
                              '{count} pending',
                              {'count': unitPendingCount},
                            ),
                      onTap: () => _openUnits(context),
                    );
                    final shopsCard = _HomeActionCard(
                      icon: Icons.storefront_outlined,
                      title: l10n.text('Shops'),
                      description: shopPendingCount == 0
                          ? l10n.text('Manage locally available shops.')
                          : l10n.text(
                              shopPendingCount == 1
                                  ? '{count} local change waiting to sync.'
                                  : '{count} local changes waiting to sync.',
                              {'count': shopPendingCount},
                            ),
                      badgeLabel: shopPendingCount == 0
                          ? null
                          : l10n.text(
                              '{count} pending',
                              {'count': shopPendingCount},
                            ),
                      onTap: () => _openShops(context),
                    );
                    final productsCard = _HomeActionCard(
                      icon: Icons.inventory_2_outlined,
                      title: l10n.text('Products'),
                      description: productPendingCount == 0
                          ? l10n.text('Manage your local product catalog.')
                          : l10n.text(
                              productPendingCount == 1
                                  ? '{count} local change waiting to sync.'
                                  : '{count} local changes waiting to sync.',
                              {'count': productPendingCount},
                            ),
                      badgeLabel: productPendingCount == 0
                          ? null
                          : l10n.text(
                              '{count} pending',
                              {'count': productPendingCount},
                            ),
                      onTap: () => _openProducts(context),
                    );
                    return wideLayout
                        ? Wrap(
                            spacing: 16,
                            runSpacing: 16,
                            children: [
                              SizedBox(width: (constraints.maxWidth - 16) / 2, child: categoriesCard),
                              SizedBox(width: (constraints.maxWidth - 16) / 2, child: unitsCard),
                              SizedBox(width: (constraints.maxWidth - 16) / 2, child: shopsCard),
                              SizedBox(width: (constraints.maxWidth - 16) / 2, child: productsCard),
                              SizedBox(width: (constraints.maxWidth - 16) / 2, child: profileCard),
                            ],
                          )
                        : Column(
                            children: [
                              categoriesCard,
                              const SizedBox(height: 16),
                              unitsCard,
                              const SizedBox(height: 16),
                              shopsCard,
                              const SizedBox(height: 16),
                              productsCard,
                              const SizedBox(height: 16),
                              profileCard,
                            ],
                          );
                  },
                ),
                const SizedBox(height: 24),
                _OfflineFirstNotice(pendingCount: totalPendingCount),
              ],
            ),
          ),
        ),
      ),
    );
  }

  void _openCategories(BuildContext context) {
    Navigator.of(context).push(
      MaterialPageRoute<void>(builder: (context) => const CategoriesScreen()),
    );
  }

  void _openProfile(BuildContext context) {
    Navigator.of(context).push(
      MaterialPageRoute<void>(builder: (context) => const ProfileScreen()),
    );
  }

  void _openUnits(BuildContext context) {
    Navigator.of(context).push(
      MaterialPageRoute<void>(
        builder: (context) => const UnitOfMeasuresScreen(),
      ),
    );
  }

  void _openShops(BuildContext context) {
    Navigator.of(context).push(
      MaterialPageRoute<void>(builder: (context) => const ShopsScreen()),
    );
  }

  void _openProducts(BuildContext context) {
    Navigator.of(context).push(
      MaterialPageRoute<void>(builder: (context) => const ProductsScreen()),
    );
  }
}

class _HomeActionCard extends StatelessWidget {
  const _HomeActionCard({
    required this.icon,
    required this.title,
    required this.description,
    required this.onTap,
    this.badgeLabel,
  });

  final IconData icon;
  final String title;
  final String description;
  final String? badgeLabel;
  final VoidCallback onTap;

  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    return Card(
      clipBehavior: Clip.antiAlias,
      child: InkWell(
        onTap: onTap,
        child: Padding(
          padding: const EdgeInsets.all(20),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Row(
                children: [
                  CircleAvatar(
                    backgroundColor: colors.primaryContainer,
                    foregroundColor: colors.onPrimaryContainer,
                    child: Icon(icon),
                  ),
                  const Spacer(),
                  if (badgeLabel case final label?)
                    Chip(
                      label: Text(label),
                      avatar: const Icon(Icons.cloud_upload_outlined, size: 16),
                    ),
                  const Icon(Icons.chevron_right),
                ],
              ),
              const SizedBox(height: 20),
              Text(title, style: Theme.of(context).textTheme.titleLarge),
              const SizedBox(height: 6),
              Text(description, style: Theme.of(context).textTheme.bodyMedium),
            ],
          ),
        ),
      ),
    );
  }
}

class _OfflineFirstNotice extends StatelessWidget {
  const _OfflineFirstNotice({required this.pendingCount});

  final int pendingCount;

  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    return DecoratedBox(
      decoration: BoxDecoration(
        color: colors.secondaryContainer,
        borderRadius: BorderRadius.circular(16),
      ),
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Row(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Icon(Icons.cloud_queue_outlined, color: colors.onSecondaryContainer),
            const SizedBox(width: 12),
            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    context.l10n.text('Offline-first data'),
                    style: Theme.of(context).textTheme.titleSmall?.copyWith(
                      color: colors.onSecondaryContainer,
                    ),
                  ),
                  const SizedBox(height: 4),
                  Text(
                    pendingCount == 0
                        ? context.l10n.text('Your local changes are synchronized.')
                        : context.l10n.text(
                            pendingCount == 1
                                ? '{count} local change is safely stored and waiting to synchronize.'
                                : '{count} local changes are safely stored and waiting to synchronize.',
                            {'count': pendingCount},
                          ),
                    style: TextStyle(color: colors.onSecondaryContainer),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
