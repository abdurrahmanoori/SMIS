import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../controllers/category_controller.dart';
import '../controllers/profile_controller.dart';
import '../controllers/product_controller.dart';
import '../controllers/shop_controller.dart';
import '../controllers/unit_of_measure_controller.dart';
import '../screens/categories_screen.dart';
import '../screens/authentication_gate.dart';
import '../screens/profile_screen.dart';
import '../screens/products_screen.dart';
import '../screens/shops_screen.dart';
import '../screens/unit_of_measures_screen.dart';

class AppDrawer extends ConsumerWidget {
  const AppDrawer({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final session = ref.watch(authControllerProvider).session;
    final categoryState = ref.watch(categoryControllerProvider);
    final pendingCount = categoryState.value?.pendingCount ?? 0;
    final unitState = ref.watch(unitOfMeasureControllerProvider);
    final unitPendingCount = unitState.value?.pendingCount ?? 0;
    final shopState = ref.watch(shopControllerProvider);
    final shopPendingCount = shopState.value?.pendingCount ?? 0;
    final productState = ref.watch(productControllerProvider);
    final productPendingCount = productState.value?.pendingCount ?? 0;

    if (session == null) return const SizedBox.shrink();

    return Drawer(
      child: ListView(
        padding: EdgeInsets.zero,
        children: [
          UserAccountsDrawerHeader(
            accountName: Text(session.userName),
            accountEmail: Text(session.email),
            currentAccountPicture: CircleAvatar(
              backgroundColor: Theme.of(context).colorScheme.primaryContainer,
              child: Text(
                session.userName.characters.first.toUpperCase(),
                style: TextStyle(
                  fontSize: 24,
                  color: Theme.of(context).colorScheme.onPrimaryContainer,
                ),
              ),
            ),
          ),
          ListTile(
            leading: const Icon(Icons.home_outlined),
            title: const Text('Home'),
            onTap: () {
              Navigator.of(context).pop();
              Navigator.of(context).popUntil((route) => route.isFirst);
            },
          ),
          ListTile(
            leading: const Icon(Icons.storefront_outlined),
            title: const Text('Shops'),
            trailing: shopPendingCount > 0
                ? Badge(label: Text('$shopPendingCount'))
                : null,
            onTap: () {
              Navigator.of(context).pop();
              Navigator.of(context).pushReplacement(
                MaterialPageRoute<void>(
                  builder: (context) => const ShopsScreen(),
                ),
              );
            },
          ),
          ListTile(
            leading: const Icon(Icons.straighten_outlined),
            title: const Text('Units of Measurement'),
            trailing: unitPendingCount > 0
                ? Badge(label: Text('$unitPendingCount'))
                : null,
            onTap: () {
              Navigator.of(context).pop();
              Navigator.of(context).pushReplacement(
                MaterialPageRoute<void>(
                  builder: (context) => const UnitOfMeasuresScreen(),
                ),
              );
            },
          ),
          ListTile(
            leading: const Icon(Icons.category_outlined),
            title: const Text('Categories'),
            trailing: pendingCount > 0
                ? Badge(label: Text('$pendingCount'))
                : null,
            onTap: () {
              Navigator.of(context).pop();
              Navigator.of(context).pushReplacement(
                MaterialPageRoute<void>(builder: (context) => CategoriesScreen()),
              );
            },
          ),
          ListTile(
            leading: const Icon(Icons.inventory_2_outlined),
            title: const Text('Products'),
            trailing: productPendingCount > 0
                ? Badge(label: Text('$productPendingCount'))
                : null,
            onTap: () {
              Navigator.of(context).pop();
              Navigator.of(context).pushReplacement(
                MaterialPageRoute<void>(
                  builder: (context) => const ProductsScreen(),
                ),
              );
            },
          ),
          ListTile(
            leading: const Icon(Icons.person_outline),
            title: const Text('My Profile'),
            onTap: () {
              Navigator.of(context).pop();
              Navigator.of(context).pushReplacement(
                MaterialPageRoute<void>(builder: (context) => ProfileScreen()),
              );
            },
          ),
          const Divider(),
          ListTile(
            leading: const Icon(Icons.logout),
            title: const Text('Sign Out'),
            onTap: () async {
              final navigator = Navigator.of(context);
              navigator.pop();
              ref.invalidate(profileControllerProvider);
              await ref.read(authControllerProvider.notifier).logout();
              if (!navigator.mounted) return;
              navigator.pushAndRemoveUntil(
                MaterialPageRoute<void>(
                  builder: (context) => const AuthenticationGate(),
                ),
                (route) => false,
              );
            },
          ),
          const SizedBox(height: 16),
        ],
      ),
    );
  }
}
