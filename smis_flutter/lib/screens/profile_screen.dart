import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/profile_controller.dart';
import '../data/profile_api.dart';
import '../data/data_exception.dart';
import '../models/user_profile.dart';
import '../l10n/app_localizations.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/theme_mode_action.dart';
import '../widgets/locale_action.dart';

class ProfileScreen extends ConsumerWidget {
  const ProfileScreen({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final profile = ref.watch(profileControllerProvider);

    return Scaffold(
      appBar: AppBar(
        title: Text(context.l10n.text('My profile')),
        actions: [
          IconButton(
            tooltip: context.l10n.text('Refresh profile'),
            onPressed: () => ref.read(profileControllerProvider.notifier).reload(),
            icon: const Icon(Icons.refresh),
          ),
          const LocaleAction(),
          const ThemeModeAction(),
          const SizedBox(width: 8),
        ],
      ),
      drawer: const AppDrawer(),
      body: SafeArea(
        child: profile.when(
          loading: () => const Center(child: CircularProgressIndicator()),
          error: (error, stackTrace) => AppErrorView(
            error: error,
            stackTrace: stackTrace,
            onRetry: () => ref.read(profileControllerProvider.notifier).reload(),
          ),
          data: (user) => _ProfileContent(user: user),
        ),
      ),
    );
  }
}

class _ProfileContent extends StatelessWidget {
  const _ProfileContent({required this.user});

  final UserProfile user;

  @override
  Widget build(BuildContext context) => Center(
    child: ConstrainedBox(
      constraints: const BoxConstraints(maxWidth: 900),
      child: ListView(
        padding: const EdgeInsets.fromLTRB(16, 16, 16, 32),
        children: [
          _ProfileHeader(user: user),
          const SizedBox(height: 16),
          _ProfileEditCard(key: ValueKey(user), user: user),
          const SizedBox(height: 16),
          const _PasswordCard(),
          const SizedBox(height: 16),
          _AccountDetailsCard(user: user),
          if (user.shop != null) ...[
            const SizedBox(height: 16),
            _ShopDetailsCard(shop: user.shop!),
          ],
        ],
      ),
    ),
  );
}

class _ProfileHeader extends StatelessWidget {
  const _ProfileHeader({required this.user});

  final UserProfile user;

  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    return Card(
      color: colors.primaryContainer,
      child: Padding(
        padding: const EdgeInsets.all(20),
        child: Row(
          children: [
            CircleAvatar(
              radius: 32,
              backgroundColor: colors.primary,
              foregroundColor: colors.onPrimary,
              child: Text(
                user.initials,
                style: Theme.of(context).textTheme.headlineSmall,
              ),
            ),
            const SizedBox(width: 16),
            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    user.displayName,
                    style: Theme.of(context).textTheme.titleLarge,
                  ),
                  if (user.email case final email?) ...[
                    const SizedBox(height: 4),
                    Text(email),
                  ],
                  if (user.roles.isNotEmpty) ...[
                    const SizedBox(height: 10),
                    Wrap(
                      spacing: 6,
                      runSpacing: 6,
                      children: user.roles
                          .map((role) => Chip(label: Text(role)))
                          .toList(growable: false),
                    ),
                  ],
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}

class _ProfileEditCard extends ConsumerStatefulWidget {
  const _ProfileEditCard({super.key, required this.user});

  final UserProfile user;

  @override
  ConsumerState<_ProfileEditCard> createState() => _ProfileEditCardState();
}

class _ProfileEditCardState extends ConsumerState<_ProfileEditCard> {
  final _formKey = GlobalKey<FormState>();
  late final TextEditingController _userName;
  late final TextEditingController _email;
  late final TextEditingController _firstName;
  late final TextEditingController _lastName;
  late final TextEditingController _phoneNumber;
  late String _languageId;
  bool _isSaving = false;

  @override
  void initState() {
    super.initState();
    _userName = TextEditingController(text: widget.user.userName ?? '');
    _email = TextEditingController(text: widget.user.email ?? '');
    _firstName = TextEditingController(text: widget.user.firstName ?? '');
    _lastName = TextEditingController(text: widget.user.lastName ?? '');
    _phoneNumber = TextEditingController(text: widget.user.phoneNumber ?? '');
    _languageId = widget.user.languageId;
  }

  @override
  void didUpdateWidget(covariant _ProfileEditCard oldWidget) {
    super.didUpdateWidget(oldWidget);
    if (oldWidget.user != widget.user) {
      _userName.text = widget.user.userName ?? '';
      _email.text = widget.user.email ?? '';
      _firstName.text = widget.user.firstName ?? '';
      _lastName.text = widget.user.lastName ?? '';
      _phoneNumber.text = widget.user.phoneNumber ?? '';
      _languageId = widget.user.languageId;
    }
  }

  @override
  void dispose() {
    _userName.dispose();
    _email.dispose();
    _firstName.dispose();
    _lastName.dispose();
    _phoneNumber.dispose();
    super.dispose();
  }

  Future<void> _save() async {
    if (!(_formKey.currentState?.validate() ?? false)) return;
    setState(() => _isSaving = true);
    try {
      await ref
          .read(profileControllerProvider.notifier)
          .updateProfile(
            ProfileUpdateDraft(
              userName: _userName.text,
              email: _email.text,
              languageId: _languageId,
              shopId: widget.user.shopId,
              firstName: _firstName.text,
              lastName: _lastName.text,
              phoneNumber: _phoneNumber.text,
            ),
          );
      if (!mounted) return;
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text(context.l10n.text('Profile updated.'))),
      );
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _isSaving = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    final languageState = ref.watch(profileLanguagesProvider);
    final languages = [...?languageState.value];
    if (!languages.any((language) => language.id == _languageId)) {
      languages.add(ProfileLanguage(
        id: _languageId,
        name: context.l10n.text('Current language'),
      ));
    }

    return Card(
      child: Padding(
        padding: const EdgeInsets.all(20),
        child: Form(
          key: _formKey,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
            Text(context.l10n.text('Personal details'), style: Theme.of(context).textTheme.titleLarge),
            const SizedBox(height: 4),
            Text(
              context.l10n.text('Update the contact information associated with your account.'),
              style: Theme.of(context).textTheme.bodyMedium,
            ),
            const SizedBox(height: 20),
            LayoutBuilder(
              builder: (context, constraints) {
                final twoColumns = constraints.maxWidth >= 600;
                final firstNameField = _NameField(
                  controller: _firstName,
                  label: context.l10n.text('First name'),
                  enabled: !_isSaving,
                );
                final lastNameField = _NameField(
                  controller: _lastName,
                  label: context.l10n.text('Last name'),
                  enabled: !_isSaving,
                );
                return twoColumns
                    ? Row(
                        children: [
                          Expanded(child: firstNameField),
                          const SizedBox(width: 16),
                          Expanded(child: lastNameField),
                        ],
                      )
                    : Column(
                        children: [
                          firstNameField,
                          const SizedBox(height: 16),
                          lastNameField,
                        ],
                      );
              },
            ),
            const SizedBox(height: 16),
            TextFormField(
              controller: _userName,
              enabled: !_isSaving,
              autofillHints: const [AutofillHints.username],
              decoration: InputDecoration(
                labelText: context.l10n.text('Username'),
                prefixIcon: const Icon(Icons.account_circle_outlined),
              ),
              validator: (value) {
                final userName = value?.trim() ?? '';
                if (userName.isEmpty || userName.length > 256) {
                  return context.l10n.text('Username must be between 1 and 256 characters.');
                }
                return null;
              },
            ),
            const SizedBox(height: 16),
            DropdownButtonFormField<String>(
              value: _languageId,
              isExpanded: true,
              decoration: InputDecoration(
                labelText: context.l10n.text('Language'),
                prefixIcon: const Icon(Icons.language_outlined),
                helperText: languageState.hasError
                    ? context.l10n.text('Unable to load languages. Your current selection will be kept.')
                    : null,
              ),
              items: languages
                  .map(
                    (language) => DropdownMenuItem<String>(
                      value: language.id,
                      child: Text(context.l10n.text(language.label)),
                    ),
                  )
                  .toList(growable: false),
              onChanged: _isSaving || languageState.isLoading
                  ? null
                  : (value) {
                      if (value != null) setState(() => _languageId = value);
                    },
              validator: (value) => value == null || value.isEmpty
                  ? context.l10n.text('Select a language.')
                  : null,
            ),
            const SizedBox(height: 16),
            TextFormField(
              controller: _email,
              enabled: !_isSaving,
              keyboardType: TextInputType.emailAddress,
              autofillHints: const [AutofillHints.email],
              decoration: InputDecoration(
                labelText: context.l10n.text('Email'),
                prefixIcon: const Icon(Icons.email_outlined),
              ),
              validator: (value) {
                final email = value?.trim() ?? '';
                if (email.isEmpty || !email.contains('@')) {
                  return context.l10n.text('Enter a valid email address.');
                }
                return null;
              },
            ),
            const SizedBox(height: 16),
            TextFormField(
              controller: _phoneNumber,
              enabled: !_isSaving,
              keyboardType: TextInputType.phone,
              autofillHints: const [AutofillHints.telephoneNumber],
              decoration: InputDecoration(
                labelText: context.l10n.text('Phone number'),
                prefixIcon: const Icon(Icons.phone_outlined),
                helperText: context.l10n.text('Optional. The server keeps the current value when left blank.'),
              ),
            ),
            const SizedBox(height: 20),
            Align(
              alignment: AlignmentDirectional.centerEnd,
              child: FilledButton.icon(
                onPressed: _isSaving ? null : _save,
                icon: _isSaving
                    ? const SizedBox.square(
                        dimension: 18,
                        child: CircularProgressIndicator(strokeWidth: 2),
                      )
                    : const Icon(Icons.save_outlined),
                label: Text(context.l10n.text('Save changes')),
              ),
            ),
            ],
          ),
        ),
      ),
    );
  }
}

class _NameField extends StatelessWidget {
  const _NameField({
    required this.controller,
    required this.label,
    required this.enabled,
  });

  final TextEditingController controller;
  final String label;
  final bool enabled;

  @override
  Widget build(BuildContext context) => TextFormField(
    controller: controller,
    enabled: enabled,
    textCapitalization: TextCapitalization.words,
    decoration: InputDecoration(labelText: label),
    validator: (value) => (value?.trim().length ?? 0) > 100
        ? context.l10n.text(
            '{field} must not exceed 100 characters.',
            {'field': label},
          )
        : null,
  );
}

class _PasswordCard extends StatelessWidget {
  const _PasswordCard();

  @override
  Widget build(BuildContext context) => Card(
    child: ListTile(
      leading: const Icon(Icons.password_outlined),
      title: Text(context.l10n.text('Password')),
      subtitle: Text(context.l10n.text('Change your account password.')),
      trailing: FilledButton.tonal(
        onPressed: () => _showChangePasswordDialog(context),
        child: Text(context.l10n.text('Change password')),
      ),
    ),
  );
}

Future<void> _showChangePasswordDialog(BuildContext context) =>
    showDialog<void>(
      context: context,
      builder: (context) => const _ChangePasswordDialog(),
    );

class _ChangePasswordDialog extends ConsumerStatefulWidget {
  const _ChangePasswordDialog();

  @override
  ConsumerState<_ChangePasswordDialog> createState() => _ChangePasswordDialogState();
}

class _ChangePasswordDialogState extends ConsumerState<_ChangePasswordDialog> {
  final _formKey = GlobalKey<FormState>();
  final _currentPassword = TextEditingController();
  final _newPassword = TextEditingController();
  final _confirmation = TextEditingController();
  bool _isSaving = false;

  @override
  void dispose() {
    _currentPassword.dispose();
    _newPassword.dispose();
    _confirmation.dispose();
    super.dispose();
  }

  Future<void> _save() async {
    if (!(_formKey.currentState?.validate() ?? false)) return;
    setState(() => _isSaving = true);
    try {
      await ref
          .read(profileControllerProvider.notifier)
          .changePassword(
            ChangePasswordDraft(
              currentPassword: _currentPassword.text,
              newPassword: _newPassword.text,
            ),
          );
      if (!mounted) return;
      final messenger = ScaffoldMessenger.of(context);
      Navigator.pop(context);
      messenger.showSnackBar(
        SnackBar(content: Text(context.l10n.text('Password changed.'))),
      );
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _isSaving = false);
    }
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: Text(context.l10n.text('Change password')),
    content: Form(
      key: _formKey,
      child: SingleChildScrollView(
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            _PasswordField(
              controller: _currentPassword,
              label: context.l10n.text('Current password'),
              enabled: !_isSaving,
            ),
            const SizedBox(height: 16),
            _PasswordField(
              controller: _newPassword,
              label: context.l10n.text('New password'),
              enabled: !_isSaving,
              validator: (value) => (value?.length ?? 0) < 6
                  ? context.l10n.text('New password must be at least 6 characters.')
                  : null,
            ),
            const SizedBox(height: 16),
            _PasswordField(
              controller: _confirmation,
              label: context.l10n.text('Confirm new password'),
              enabled: !_isSaving,
              validator: (value) => value != _newPassword.text
                  ? context.l10n.text('Passwords do not match.')
                  : null,
            ),
          ],
        ),
      ),
    ),
    actions: [
      TextButton(
        onPressed: _isSaving ? null : () => Navigator.pop(context),
        child: Text(context.l10n.text('Cancel')),
      ),
      FilledButton(
        onPressed: _isSaving ? null : _save,
        child: Text(context.l10n.text(_isSaving ? 'Saving…' : 'Change password')),
      ),
    ],
  );
}

class _PasswordField extends StatelessWidget {
  const _PasswordField({
    required this.controller,
    required this.label,
    required this.enabled,
    this.validator,
  });

  final TextEditingController controller;
  final String label;
  final bool enabled;
  final FormFieldValidator<String>? validator;

  @override
  Widget build(BuildContext context) => TextFormField(
    controller: controller,
    enabled: enabled,
    obscureText: true,
    decoration: InputDecoration(labelText: label),
    validator: validator ??
        (value) => (value?.isEmpty ?? true)
            ? context.l10n.text('{field} is required.', {'field': label})
            : null,
  );
}

class _AccountDetailsCard extends StatelessWidget {
  const _AccountDetailsCard({required this.user});

  final UserProfile user;

  @override
  Widget build(BuildContext context) => Card(
    child: Padding(
      padding: const EdgeInsets.all(20),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(context.l10n.text('Account information'), style: Theme.of(context).textTheme.titleLarge),
          const SizedBox(height: 12),
          _DetailRow(label: context.l10n.text('User ID'), value: user.id, selectable: true),
          _DetailRow(label: context.l10n.text('Username'), value: user.userName ?? context.l10n.text('Not set')),
          _DetailRow(label: context.l10n.text('Language ID'), value: user.languageId),
          _DetailRow(
            label: context.l10n.text('Email verification'),
            value: context.l10n.text(user.emailConfirmed ? 'Confirmed' : 'Not confirmed'),
            icon: user.emailConfirmed ? Icons.verified_outlined : Icons.pending_outlined,
          ),
          _DetailRow(
            label: context.l10n.text('Phone verification'),
            value: context.l10n.text(user.phoneNumberConfirmed ? 'Confirmed' : 'Not confirmed'),
            icon: user.phoneNumberConfirmed ? Icons.verified_outlined : Icons.pending_outlined,
          ),
          _DetailRow(
            label: context.l10n.text('Roles'),
            value: user.roles.isEmpty ? context.l10n.text('No assigned roles') : user.roles.join(', '),
          ),
          _DetailRow(label: context.l10n.text('Shop ID'), value: user.shopId, selectable: true),
        ],
      ),
    ),
  );
}

class _ShopDetailsCard extends StatelessWidget {
  const _ShopDetailsCard({required this.shop});

  final UserShop shop;

  @override
  Widget build(BuildContext context) => Card(
    child: Padding(
      padding: const EdgeInsets.all(20),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(context.l10n.text('Shop'), style: Theme.of(context).textTheme.titleLarge),
          const SizedBox(height: 12),
          _DetailRow(label: context.l10n.text('Name'), value: shop.name),
          _DetailRow(label: context.l10n.text('Shop ID'), value: shop.id, selectable: true),
          if (shop.shopType case final value?)
            _DetailRow(
              label: context.l10n.text('Type'),
              value: _localizedShopType(context, value),
            ),
          if (shop.address case final value?) _DetailRow(label: context.l10n.text('Address'), value: value),
          if (shop.phoneNumber case final value?) _DetailRow(label: context.l10n.text('Phone'), value: value),
          if (shop.email case final value?) _DetailRow(label: context.l10n.text('Email'), value: value),
          if (shop.taxNumber case final value?)
            _DetailRow(label: context.l10n.text('Tax number'), value: value),
          if (shop.isActive case final value?)
            _DetailRow(
              label: context.l10n.text('Status'),
              value: context.l10n.text(value ? 'Active' : 'Inactive'),
            ),
        ],
      ),
    ),
  );
}

String _localizedShopType(BuildContext context, String value) {
  final normalized = value.replaceAll(RegExp(r'[ _-]'), '').toLowerCase();
  return switch (normalized) {
    'retailshop' => context.l10n.text('Retail shop'),
    'wholesaleshop' => context.l10n.text('Wholesale shop'),
    _ => value,
  };
}

class _DetailRow extends StatelessWidget {
  const _DetailRow({
    required this.label,
    required this.value,
    this.icon,
    this.selectable = false,
  });

  final String label;
  final String value;
  final IconData? icon;
  final bool selectable;

  @override
  Widget build(BuildContext context) => Padding(
    padding: const EdgeInsets.symmetric(vertical: 7),
    child: Row(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        SizedBox(
          width: 145,
          child: Text(label, style: Theme.of(context).textTheme.labelLarge),
        ),
        Expanded(
          child: Row(
            children: [
              if (icon != null) ...[
                Icon(icon, size: 18),
                const SizedBox(width: 6),
              ],
              Expanded(
                child: selectable ? SelectableText(value) : Text(value),
              ),
            ],
          ),
        ),
      ],
    ),
  );
}
