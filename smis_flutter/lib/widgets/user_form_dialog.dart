import 'package:flutter/material.dart';

import '../l10n/app_localizations.dart';
import '../models/managed_user.dart';
import '../validation/user_management_validation.dart';

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
    final l10n = context.l10n;

    String? localized(String? message) =>
        message == null ? null : l10n.text(message);

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
                          l10n.text(_isEditing ? 'Edit user' : 'Create user'),
                          style: Theme.of(context).textTheme.titleLarge,
                        ),
                        Text(
                          l10n.text(
                            _isEditing
                                ? 'Update account information, shop assignment, and roles.'
                                : 'Create the account in the active session shop and assign its initial access.',
                          ),
                          style: Theme.of(context).textTheme.bodySmall,
                        ),
                      ],
                    ),
                  ),
                  IconButton(
                    tooltip: l10n.text('Close'),
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
                autovalidateMode: AutovalidateMode.onUserInteraction,
                child: SingleChildScrollView(
                  padding: const EdgeInsets.all(24),
                  child: LayoutBuilder(
                    builder: (context, constraints) {
                      final wide = constraints.maxWidth >= 620;
                      return Column(
                        crossAxisAlignment: CrossAxisAlignment.stretch,
                        children: [
                          _SectionCard(
                            title: l10n.text('Account'),
                            icon: Icons.account_circle_outlined,
                            child: Column(
                              children: [
                                _ResponsiveFields(
                                  wide: wide,
                                  children: [
                                    TextFormField(
                                      controller: _userName,
                                      maxLength: UserManagementValidation
                                          .maxUserNameLength,
                                      decoration: InputDecoration(
                                        labelText: l10n.text('Username'),
                                        border: const OutlineInputBorder(),
                                      ),
                                      textInputAction: TextInputAction.next,
                                      validator: (value) => localized(
                                        UserManagementValidation.userName(
                                          value,
                                        ),
                                      ),
                                    ),
                                    TextFormField(
                                      controller: _email,
                                      maxLength: UserManagementValidation
                                          .maxEmailLength,
                                      decoration: InputDecoration(
                                        labelText: l10n.text('Email'),
                                        border: const OutlineInputBorder(),
                                      ),
                                      keyboardType: TextInputType.emailAddress,
                                      textInputAction: TextInputAction.next,
                                      validator: (value) => localized(
                                        UserManagementValidation.email(value),
                                      ),
                                    ),
                                  ],
                                ),
                                if (!_isEditing) ...[
                                  const SizedBox(height: 12),
                                  TextFormField(
                                    controller: _password,
                                    decoration: InputDecoration(
                                      labelText: l10n.text('Password'),
                                      helperText: l10n.text(
                                        'Password must be at least 6 characters',
                                      ),
                                      border: const OutlineInputBorder(),
                                      suffixIcon: IconButton(
                                        tooltip: l10n.text(
                                          _obscurePassword
                                              ? 'Show password'
                                              : 'Hide password',
                                        ),
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
                                    validator: (value) => localized(
                                      UserManagementValidation.password(
                                        value,
                                        required: true,
                                      ),
                                    ),
                                  ),
                                ],
                              ],
                            ),
                          ),
                          const SizedBox(height: 16),
                          _SectionCard(
                            title: l10n.text('Personal information'),
                            icon: Icons.badge_outlined,
                            child: Column(
                              children: [
                                _ResponsiveFields(
                                  wide: wide,
                                  children: [
                                    TextFormField(
                                      controller: _firstName,
                                      maxLength: UserManagementValidation
                                          .maxPersonNameLength,
                                      decoration: InputDecoration(
                                        labelText: l10n.text('First name'),
                                        border: const OutlineInputBorder(),
                                      ),
                                      textInputAction: TextInputAction.next,
                                      validator: (value) => localized(
                                        UserManagementValidation.firstName(
                                          value,
                                        ),
                                      ),
                                    ),
                                    TextFormField(
                                      controller: _lastName,
                                      maxLength: UserManagementValidation
                                          .maxPersonNameLength,
                                      decoration: InputDecoration(
                                        labelText: l10n.text('Last name'),
                                        border: const OutlineInputBorder(),
                                      ),
                                      textInputAction: TextInputAction.next,
                                      validator: (value) => localized(
                                        UserManagementValidation.lastName(
                                          value,
                                        ),
                                      ),
                                    ),
                                  ],
                                ),
                                const SizedBox(height: 12),
                                TextFormField(
                                  controller: _phone,
                                  maxLength:
                                      UserManagementValidation.maxPhoneLength,
                                  decoration: InputDecoration(
                                    labelText: l10n.text('Phone number'),
                                    hintText: l10n.text(
                                      'Example: +93 700 123 456',
                                    ),
                                    border: const OutlineInputBorder(),
                                  ),
                                  keyboardType: TextInputType.phone,
                                  validator: (value) => localized(
                                    UserManagementValidation.phoneNumber(value),
                                  ),
                                ),
                              ],
                            ),
                          ),
                          const SizedBox(height: 16),
                          _SectionCard(
                            title: l10n.text('Access'),
                            icon: Icons.admin_panel_settings_outlined,
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.stretch,
                              children: [
                                if (_isEditing) ...[
                                  DropdownButtonFormField<String>(
                                    initialValue: _shopId,
                                    decoration: InputDecoration(
                                      labelText: l10n.text('Shop'),
                                      border: const OutlineInputBorder(),
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
                                    validator: (value) => localized(
                                      UserManagementValidation.shopId(value),
                                    ),
                                    onChanged: (value) {
                                      if (value != null) {
                                        setState(() => _shopId = value);
                                      }
                                    },
                                  ),
                                  const SizedBox(height: 16),
                                ] else ...[
                                  Text(
                                    l10n.text(
                                      'The new user will be assigned to the shop currently active in your session.',
                                    ),
                                    style: Theme.of(
                                      context,
                                    ).textTheme.bodyMedium,
                                  ),
                                  const SizedBox(height: 16),
                                ],
                                Text(
                                  l10n.text('Roles'),
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
                                    l10n.text('Select at least one role.'),
                                    style: TextStyle(
                                      color: Theme.of(
                                        context,
                                      ).colorScheme.error,
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
                    child: Text(l10n.text('Cancel')),
                  ),
                  const SizedBox(width: 8),
                  FilledButton.icon(
                    onPressed: _submit,
                    icon: Icon(_isEditing ? Icons.save_outlined : Icons.add),
                    label: Text(
                      l10n.text(_isEditing ? 'Save changes' : 'Create user'),
                    ),
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
