import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../controllers/category_controller.dart';
import '../controllers/profile_controller.dart';
import 'categories_screen.dart';
import 'profile_screen.dart';

class HomeScreen extends ConsumerWidget {
  const HomeScreen({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final session = ref.watch(authControllerProvider).session;
    final categoryState = ref.watch(categoryControllerProvider);
    final pendingCount = categoryState.value?.pendingCount ?? 0;

    // HomeScreen is only shown by the authentication gate after a session is
    // restored or created, but keep this defensive fallback for state changes.
    if (session == null) return const SizedBox.shrink();

    return Scaffold(
      appBar: AppBar(
        title: const Text('SMIS'),
        actions: [
          PopupMenuButton<String>(
            tooltip: 'Account',
            onSelected: (value) {
              switch (value) {
                case 'profile':
                  _openProfile(context);
                case 'logout':
                  ref.invalidate(profileControllerProvider);
                  ref.read(authControllerProvider.notifier).logout();
              }
            },
            itemBuilder: (context) => [
              PopupMenuItem<String>(
                enabled: false,
                child: Text(session.email),
              ),
              const PopupMenuDivider(),
              const PopupMenuItem<String>(
                value: 'profile',
                child: Text('My profile'),
              ),
              const PopupMenuItem<String>(
                value: 'logout',
                child: Text('Sign out'),
              ),
            ],
            child: Padding(
              padding: const EdgeInsets.all(8),
              child: CircleAvatar(
                child: Text(session.userName.characters.first.toUpperCase()),
              ),
            ),
          ),
          const SizedBox(width: 8),
        ],
      ),
      body: SafeArea(
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 900),
            child: ListView(
              padding: const EdgeInsets.fromLTRB(20, 24, 20, 32),
              children: [
                Text(
                  'Welcome back, ${session.userName}',
                  style: Theme.of(context).textTheme.headlineMedium,
                ),
                const SizedBox(height: 8),
                Text(
                  'Choose an area to continue managing your shop.',
                  style: Theme.of(context).textTheme.bodyLarge,
                ),
                const SizedBox(height: 28),
                LayoutBuilder(
                  builder: (context, constraints) {
                    final wideLayout = constraints.maxWidth >= 620;
                    final categoriesCard = _HomeActionCard(
                      icon: Icons.category_outlined,
                      title: 'Categories',
                      description: pendingCount == 0
                          ? 'Manage your local category list.'
                          : '$pendingCount local change${pendingCount == 1 ? '' : 's'} waiting to sync.',
                      badgeLabel: pendingCount == 0 ? null : '$pendingCount pending',
                      onTap: () => _openCategories(context),
                    );
                    final profileCard = _HomeActionCard(
                      icon: Icons.person_outline,
                      title: 'My profile',
                      description: 'View your account, shop details, and profile settings.',
                      onTap: () => _openProfile(context),
                    );
                    return wideLayout
                        ? Row(
                            children: [
                              Expanded(child: categoriesCard),
                              const SizedBox(width: 16),
                              Expanded(child: profileCard),
                            ],
                          )
                        : Column(
                            children: [
                              categoriesCard,
                              const SizedBox(height: 16),
                              profileCard,
                            ],
                          );
                  },
                ),
                const SizedBox(height: 24),
                _OfflineFirstNotice(pendingCount: pendingCount),
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
                    'Offline-first Categories',
                    style: Theme.of(context).textTheme.titleSmall?.copyWith(
                      color: colors.onSecondaryContainer,
                    ),
                  ),
                  const SizedBox(height: 4),
                  Text(
                    pendingCount == 0
                        ? 'Your local Category changes are synchronized.'
                        : 'Your changes are safely stored locally and will synchronize when you choose Sync or a background job runs.',
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
