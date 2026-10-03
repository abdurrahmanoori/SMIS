import 'package:flutter/material.dart';

import '../models/managed_user.dart';

class UserDetailsScreen extends StatelessWidget {
  const UserDetailsScreen({super.key, required this.user});

  final ManagedUser user;

  @override
  Widget build(BuildContext context) {
    final theme = Theme.of(context);

    return Scaffold(
      appBar: AppBar(title: const Text('User details')),
      body: SafeArea(
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 820),
            child: ListView(
              padding: const EdgeInsets.all(16),
              children: [
                Card(
                  child: Padding(
                    padding: const EdgeInsets.all(20),
                    child: Row(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        CircleAvatar(
                          radius: 32,
                          child: Text(
                            user.userName.isEmpty
                                ? '?'
                                : user.userName.characters.first.toUpperCase(),
                            style: theme.textTheme.headlineSmall,
                          ),
                        ),
                        const SizedBox(width: 16),
                        Expanded(
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(
                                user.displayName,
                                style: theme.textTheme.headlineSmall,
                              ),
                              const SizedBox(height: 4),
                              SelectableText(
                                user.userName,
                                style: theme.textTheme.bodyLarge,
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
                                    label: user.isActive
                                        ? 'Active'
                                        : 'Inactive',
                                  ),
                                  _StatusChip(
                                    icon: user.isLocked
                                        ? Icons.lock_outline
                                        : Icons.lock_open_outlined,
                                    label: user.isLocked
                                        ? 'Locked'
                                        : 'Unlocked',
                                  ),
                                ],
                              ),
                            ],
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
                const SizedBox(height: 16),
                _DetailsSection(
                  title: 'Account information',
                  children: [
                    _DetailTile(label: 'Username', value: user.userName),
                    _DetailTile(label: 'Email', value: user.email),
                    _DetailTile(
                      label: 'Phone number',
                      value: _valueOrNotSet(user.phoneNumber),
                    ),
                    _DetailTile(
                      label: 'First name',
                      value: _valueOrNotSet(user.firstName),
                    ),
                    _DetailTile(
                      label: 'Last name',
                      value: _valueOrNotSet(user.lastName),
                    ),
                    _DetailTile(
                      label: 'Language ID',
                      value: _valueOrNotSet(user.languageId),
                    ),
                  ],
                ),
                const SizedBox(height: 16),
                _DetailsSection(
                  title: 'Shop access',
                  children: [
                    _DetailTile(
                      label: 'Shop',
                      value: _valueOrNotSet(user.shopName ?? user.shopId),
                    ),
                    _DetailTile(label: 'Shop ID', value: user.shopId),
                  ],
                ),
                const SizedBox(height: 16),
                _DetailsSection(
                  title: 'Roles',
                  children: [
                    Padding(
                      padding: const EdgeInsets.all(16),
                      child: user.roles.isEmpty
                          ? const Text('No roles assigned.')
                          : Wrap(
                              spacing: 8,
                              runSpacing: 8,
                              children: user.roles
                                  .map((role) => Chip(label: Text(role)))
                                  .toList(growable: false),
                            ),
                    ),
                  ],
                ),
                const SizedBox(height: 16),
                _DetailsSection(
                  title: 'Account status',
                  children: [
                    _DetailTile(
                      label: 'Active',
                      value: user.isActive ? 'Yes' : 'No',
                    ),
                    _DetailTile(
                      label: 'Locked',
                      value: user.isLocked ? 'Yes' : 'No',
                    ),
                    _DetailTile(
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
    final normalized = value?.trim();
    return normalized == null || normalized.isEmpty ? 'Not set' : normalized;
  }

  static String _formatDateTime(DateTime value) {
    final local = value.toLocal();
    String twoDigits(int number) => number.toString().padLeft(2, '0');

    return '${local.year}-${twoDigits(local.month)}-${twoDigits(local.day)} '
        '${twoDigits(local.hour)}:${twoDigits(local.minute)}';
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
  const _DetailsSection({required this.title, required this.children});

  final String title;
  final List<Widget> children;

  @override
  Widget build(BuildContext context) => Card(
    clipBehavior: Clip.antiAlias,
    child: Column(
      crossAxisAlignment: CrossAxisAlignment.stretch,
      children: [
        Padding(
          padding: const EdgeInsets.fromLTRB(16, 16, 16, 8),
          child: Text(title, style: Theme.of(context).textTheme.titleMedium),
        ),
        ..._withDividers(children),
      ],
    ),
  );

  static List<Widget> _withDividers(List<Widget> children) {
    if (children.length < 2) return children;

    return [
      for (var index = 0; index < children.length; index++) ...[
        children[index],
        if (index < children.length - 1) const Divider(height: 1),
      ],
    ];
  }
}

class _DetailTile extends StatelessWidget {
  const _DetailTile({required this.label, required this.value});

  final String label;
  final String value;

  @override
  Widget build(BuildContext context) =>
      ListTile(title: Text(label), subtitle: SelectableText(value));
}
