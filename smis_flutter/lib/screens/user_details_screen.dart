import 'package:flutter/material.dart';

import '../models/managed_user.dart';

class UserDetailsScreen extends StatelessWidget {
  const UserDetailsScreen({super.key, required this.user});

  final ManagedUser user;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text('User details')),
      body: SafeArea(
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 760),
            child: ListView(
              padding: const EdgeInsets.all(16),
              children: [
                _UserHeader(user: user),
                const SizedBox(height: 16),
                _DetailsSection(
                  title: 'Account',
                  icon: Icons.account_circle_outlined,
                  children: [
                    _DetailRow(label: 'Username', value: user.userName),
                    _DetailRow(label: 'Email', value: user.email),
                    _DetailRow(
                      label: 'Phone number',
                      value: _valueOrNotSet(user.phoneNumber),
                    ),
                    _DetailRow(label: 'User ID', value: user.id),
                    _DetailRow(
                      label: 'Language ID',
                      value: _valueOrNotSet(user.languageId),
                    ),
                  ],
                ),
                const SizedBox(height: 16),
                _DetailsSection(
                  title: 'Personal information',
                  icon: Icons.badge_outlined,
                  children: [
                    _DetailRow(
                      label: 'First name',
                      value: _valueOrNotSet(user.firstName),
                    ),
                    _DetailRow(
                      label: 'Last name',
                      value: _valueOrNotSet(user.lastName),
                    ),
                    _DetailRow(label: 'Display name', value: user.displayName),
                  ],
                ),
                const SizedBox(height: 16),
                _DetailsSection(
                  title: 'Organization and access',
                  icon: Icons.admin_panel_settings_outlined,
                  children: [
                    _DetailRow(
                      label: 'Shop',
                      value: user.shopName?.trim().isNotEmpty == true
                          ? user.shopName!
                          : user.shopId,
                    ),
                    _DetailRow(label: 'Shop ID', value: user.shopId),
                    _DetailRow(
                      label: 'Roles',
                      value: user.roles.isEmpty
                          ? 'No roles assigned'
                          : user.roles.join(', '),
                    ),
                  ],
                ),
                const SizedBox(height: 16),
                _DetailsSection(
                  title: 'Account status',
                  icon: Icons.security_outlined,
                  children: [
                    _DetailRow(
                      label: 'Activation',
                      value: user.isActive ? 'Active' : 'Inactive',
                    ),
                    _DetailRow(
                      label: 'Lock status',
                      value: user.isLocked ? 'Locked' : 'Unlocked',
                    ),
                    _DetailRow(
                      label: 'Lockout end',
                      value: user.lockoutEnd == null
                          ? 'Not set'
                          : _formatDateTime(user.lockoutEnd!),
                    ),
                  ],
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }

  static String _valueOrNotSet(String? value) {
    final text = value?.trim();
    return text == null || text.isEmpty ? 'Not set' : text;
  }

  static String _formatDateTime(DateTime value) {
    final local = value.toLocal();
    String twoDigits(int number) => number.toString().padLeft(2, '0');
    return '${local.year}-${twoDigits(local.month)}-${twoDigits(local.day)} '
        '${twoDigits(local.hour)}:${twoDigits(local.minute)}';
  }
}

class _UserHeader extends StatelessWidget {
  const _UserHeader({required this.user});

  final ManagedUser user;

  @override
  Widget build(BuildContext context) {
    final initial = user.displayName.trim().isEmpty
        ? '?'
        : user.displayName.trim().characters.first.toUpperCase();

    return Card(
      child: Padding(
        padding: const EdgeInsets.all(20),
        child: Row(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            CircleAvatar(radius: 34, child: Text(initial)),
            const SizedBox(width: 16),
            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    user.displayName,
                    style: Theme.of(context).textTheme.headlineSmall,
                  ),
                  const SizedBox(height: 4),
                  Text(
                    user.email,
                    style: Theme.of(context).textTheme.bodyMedium,
                  ),
                  const SizedBox(height: 12),
                  Wrap(
                    spacing: 8,
                    runSpacing: 8,
                    children: [
                      _StatusChip(
                        icon: user.isActive
                            ? Icons.check_circle_outline
                            : Icons.block_outlined,
                        label: user.isActive ? 'Active' : 'Inactive',
                      ),
                      _StatusChip(
                        icon: user.isLocked
                            ? Icons.lock_outline
                            : Icons.lock_open_outlined,
                        label: user.isLocked ? 'Locked' : 'Unlocked',
                      ),
                    ],
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

class _StatusChip extends StatelessWidget {
  const _StatusChip({required this.icon, required this.label});

  final IconData icon;
  final String label;

  @override
  Widget build(BuildContext context) =>
      Chip(avatar: Icon(icon, size: 18), label: Text(label));
}

class _DetailsSection extends StatelessWidget {
  const _DetailsSection({
    required this.title,
    required this.icon,
    required this.children,
  });

  final String title;
  final IconData icon;
  final List<Widget> children;

  @override
  Widget build(BuildContext context) => Card(
    clipBehavior: Clip.antiAlias,
    child: Column(
      crossAxisAlignment: CrossAxisAlignment.stretch,
      children: [
        Padding(
          padding: const EdgeInsets.fromLTRB(16, 16, 16, 10),
          child: Row(
            children: [
              Icon(icon, size: 20),
              const SizedBox(width: 8),
              Text(title, style: Theme.of(context).textTheme.titleMedium),
            ],
          ),
        ),
        ...List<Widget>.generate(children.length * 2 - 1, (index) {
          if (index.isOdd) return const Divider(height: 1);
          return children[index ~/ 2];
        }),
      ],
    ),
  );
}

class _DetailRow extends StatelessWidget {
  const _DetailRow({required this.label, required this.value});

  final String label;
  final String value;

  @override
  Widget build(BuildContext context) =>
      ListTile(title: Text(label), subtitle: SelectableText(value));
}
