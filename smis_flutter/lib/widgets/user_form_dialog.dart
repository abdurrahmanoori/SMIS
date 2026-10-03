import 'package:flutter/material.dart';

import '../models/managed_user.dart';

class UserFormDraft {
  const UserFormDraft({
    required this.userName,
    required this.email,
    required this.password,
    required this.firstName,
    required this.lastName,
    required this.phoneNumber,
    required this.shopId,
    required this.roles,
  });

  final String userName;
  final String email;
  final String? password;
  final String firstName;
  final String lastName;
  final String phoneNumber;
  final String shopId;
  final List<String> roles;
}

class UserFormDialog extends StatefulWidget {
  const UserFormDialog({
    super.key,
    required this.user,
    required this.shops,
    required this.roles,
  });

  final ManagedUser? user;
  final List<UserShopOption> shops;
  final List<String> roles;

  @override
  State<UserFormDialog> createState() => _UserFormDialogState();
}

class _UserFormDialogState extends State<UserFormDialog> {
  final _formKey = GlobalKey<FormState>();
  late final TextEditingController _userName;
  late final TextEditingController _email;
  late final TextEditingController _phone;
  late final TextEditingController _firstName;
  late final TextEditingController _lastName;
  late final TextEditingController _password;
  late String _shopId;
  late Set<String> _roles;
  bool _showRoleValidation = false;
  bool _obscurePassword = true;

  bool get _isEditing => widget.user != null;

  @override
  void initState() {
    super.initState();
    final user = widget.user;
    _userName = TextEditingController(text: user?.userName ?? '');
    _email = TextEditingController(text: user?.email ?? '');
    _phone = TextEditingController(text: user?.phoneNumber ?? '');
    _firstName = TextEditingController(text: user?.firstName ?? '');
    _lastName = TextEditingController(text: user?.lastName ?? '');
    _password = TextEditingController();
    _shopId = widget.shops.any((shop) => shop.id == user?.shopId)
        ? user!.shopId
        : widget.shops.first.id;
    _roles = {...?user?.roles};
  }

  @override
  void dispose() {
    _userName.dispose();
    _email.dispose();
    _phone.dispose();
    _firstName.dispose();
    _lastName.dispose();
    _password.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final media = MediaQuery.of(context);
    final maxHeight = media.size.height * 0.9;

    return Dialog(
      insetPadding: const EdgeInsets.symmetric(horizontal: 16, vertical: 24),
      child: ConstrainedBox(
        constraints: BoxConstraints(maxWidth: 760, maxHeight: maxHeight),
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            Padding(
              padding: const EdgeInsets.fromLTRB(24, 20, 12, 12),
              child: Row(
                children: [
                  CircleAvatar(
                    child: Icon(
                      _isEditing
                          ? Icons.manage_accounts_outlined
                          : Icons.person_add_alt_1_outlined,
                    ),
                  ),
                  const SizedBox(width: 12),
                  Expanded(
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          _isEditing ? 'Edit user' : 'Create user',
                          style: Theme.of(context).textTheme.titleLarge,
                        ),
                        Text(
                          _isEditing
                              ? 'Update account information, shop assignment, and roles.'
                              : 'Create the account and assign its initial access.',
                          style: Theme.of(context).textTheme.bodySmall,
                        ),
                      ],
                    ),
                  ),
                  IconButton(
                    tooltip: 'Close',
                    onPressed: () => Navigator.pop(context),
                    icon: const Icon(Icons.close),
                  ),
                ],
              ),
            ),
            const Divider(height: 1),
            Flexible(
              child: Form(
                key: _formKey,
                child: SingleChildScrollView(
                  padding: const EdgeInsets.all(24),
                  child: LayoutBuilder(
                    builder: (context, constraints) {
                      final wide = constraints.maxWidth >= 620;
                      return Column(
                        crossAxisAlignment: CrossAxisAlignment.stretch,
                        children: [
                          _SectionCard(
                            title: 'Account',
                            icon: Icons.account_circle_outlined,
                            child: Column(
                              children: [
                                _ResponsiveFields(
                                  wide: wide,
                                  children: [
                                    TextFormField(
                                      controller: _userName,
                                      decoration: const InputDecoration(
                                        labelText: 'Username',
                                        border: OutlineInputBorder(),
                                      ),
                                      textInputAction: TextInputAction.next,
                                      validator: _required,
                                    ),
                                    TextFormField(
                                      controller: _email,
                                      decoration: const InputDecoration(
                                        labelText: 'Email',
                                        border: OutlineInputBorder(),
                                      ),
                                      keyboardType: TextInputType.emailAddress,
                                      textInputAction: TextInputAction.next,
                                      validator: _required,
                                    ),
                                  ],
                                ),
                                if (!_isEditing) ...[
                                  const SizedBox(height: 12),
                                  TextFormField(
                                    controller: _password,
                                    decoration: InputDecoration(
                                      labelText: 'Password',
                                      border: const OutlineInputBorder(),
                                      suffixIcon: IconButton(
                                        tooltip: _obscurePassword
                                            ? 'Show password'
                                            : 'Hide password',
                                        onPressed: () => setState(
                                          () => _obscurePassword =
                                              !_obscurePassword,
                                        ),
                                        icon: Icon(
                                          _obscurePassword
                                              ? Icons.visibility_outlined
                                              : Icons.visibility_off_outlined,
                                        ),
                                      ),
                                    ),
                                    obscureText: _obscurePassword,
                                    validator: _required,
                                  ),
                                ],
                              ],
                            ),
                          ),
                          const SizedBox(height: 16),
                          _SectionCard(
                            title: 'Personal information',
                            icon: Icons.badge_outlined,
                            child: Column(
                              children: [
                                _ResponsiveFields(
                                  wide: wide,
                                  children: [
                                    TextFormField(
                                      controller: _firstName,
                                      decoration: const InputDecoration(
                                        labelText: 'First name',
                                        border: OutlineInputBorder(),
                                      ),
                                      textInputAction: TextInputAction.next,
                                    ),
                                    TextFormField(
                                      controller: _lastName,
                                      decoration: const InputDecoration(
                                        labelText: 'Last name',
                                        border: OutlineInputBorder(),
                                      ),
                                      textInputAction: TextInputAction.next,
                                    ),
                                  ],
                                ),
                                const SizedBox(height: 12),
                                TextFormField(
                                  controller: _phone,
                                  decoration: const InputDecoration(
                                    labelText: 'Phone number',
                                    border: OutlineInputBorder(),
                                  ),
                                  keyboardType: TextInputType.phone,
                                ),
                              ],
                            ),
                          ),
                          const SizedBox(height: 16),
                          _SectionCard(
                            title: 'Access',
                            icon: Icons.admin_panel_settings_outlined,
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.stretch,
                              children: [
                                DropdownButtonFormField<String>(
                                  initialValue: _shopId,
                                  decoration: const InputDecoration(
                                    labelText: 'Shop',
                                    border: OutlineInputBorder(),
                                  ),
                                  items: widget.shops
                                      .map(
                                        (shop) => DropdownMenuItem(
                                          value: shop.id,
                                          child: Text(
                                            shop.name,
                                            overflow: TextOverflow.ellipsis,
                                          ),
                                        ),
                                      )
                                      .toList(growable: false),
                                  onChanged: (value) {
                                    if (value != null) {
                                      setState(() => _shopId = value);
                                    }
                                  },
                                ),
                                const SizedBox(height: 16),
                                Text(
                                  'Roles',
                                  style: Theme.of(context).textTheme.titleSmall,
                                ),
                                const SizedBox(height: 8),
                                Wrap(
                                  spacing: 8,
                                  runSpacing: 8,
                                  children: widget.roles
                                      .map(
                                        (role) => FilterChip(
                                          label: Text(role),
                                          selected: _roles.contains(role),
                                          onSelected: (selected) {
                                            setState(() {
                                              if (selected) {
                                                _roles.add(role);
                                              } else {
                                                _roles.remove(role);
                                              }
                                              _showRoleValidation = false;
                                            });
                                          },
                                        ),
                                      )
                                      .toList(growable: false),
                                ),
                                if (_showRoleValidation && _roles.isEmpty) ...[
                                  const SizedBox(height: 8),
                                  Text(
                                    'Select at least one role.',
                                    style: TextStyle(
                                      color: Theme.of(context).colorScheme.error,
                                    ),
                                  ),
                                ],
                              ],
                            ),
                          ),
                        ],
                      );
                    },
                  ),
                ),
              ),
            ),
            const Divider(height: 1),
            Padding(
              padding: const EdgeInsets.fromLTRB(16, 12, 16, 16),
              child: Row(
                mainAxisAlignment: MainAxisAlignment.end,
                children: [
                  TextButton(
                    onPressed: () => Navigator.pop(context),
                    child: const Text('Cancel'),
                  ),
                  const SizedBox(width: 8),
                  FilledButton.icon(
                    onPressed: _submit,
                    icon: Icon(_isEditing ? Icons.save_outlined : Icons.add),
                    label: Text(_isEditing ? 'Save changes' : 'Create user'),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  void _submit() {
    final formValid = _formKey.currentState?.validate() ?? false;
    if (_roles.isEmpty) {
      setState(() => _showRoleValidation = true);
    }
    if (!formValid || _roles.isEmpty) return;

    Navigator.pop(
      context,
      UserFormDraft(
        userName: _userName.text.trim(),
        email: _email.text.trim(),
        password: _isEditing ? null : _password.text,
        firstName: _firstName.text.trim(),
        lastName: _lastName.text.trim(),
        phoneNumber: _phone.text.trim(),
        shopId: _shopId,
        roles: _roles.toList(growable: false),
      ),
    );
  }

  String? _required(String? value) =>
      value == null || value.trim().isEmpty ? 'Required' : null;
}

class _SectionCard extends StatelessWidget {
  const _SectionCard({
    required this.title,
    required this.icon,
    required this.child,
  });

  final String title;
  final IconData icon;
  final Widget child;

  @override
  Widget build(BuildContext context) => DecoratedBox(
    decoration: BoxDecoration(
      border: Border.all(color: Theme.of(context).colorScheme.outlineVariant),
      borderRadius: BorderRadius.circular(12),
    ),
    child: Padding(
      padding: const EdgeInsets.all(16),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          Row(
            children: [
              Icon(icon, size: 20),
              const SizedBox(width: 8),
              Text(title, style: Theme.of(context).textTheme.titleMedium),
            ],
          ),
          const SizedBox(height: 16),
          child,
        ],
      ),
    ),
  );
}

class _ResponsiveFields extends StatelessWidget {
  const _ResponsiveFields({required this.wide, required this.children});

  final bool wide;
  final List<Widget> children;

  @override
  Widget build(BuildContext context) {
    if (!wide) {
      return Column(
        children: [
          for (var i = 0; i < children.length; i++) ...[
            children[i],
            if (i != children.length - 1) const SizedBox(height: 12),
          ],
        ],
      );
    }

    return Row(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        for (var i = 0; i < children.length; i++) ...[
          Expanded(child: children[i]),
          if (i != children.length - 1) const SizedBox(width: 12),
        ],
      ],
    );
  }
}
