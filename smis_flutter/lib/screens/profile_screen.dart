import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/profile_controller.dart';
import '../data/profile_api.dart';
import '../models/user_profile.dart';

class ProfileScreen extends ConsumerWidget {
  const ProfileScreen({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final profile = ref.watch(profileControllerProvider);

    return Scaffold(
      appBar: AppBar(
        title: const Text('My profile'),
        actions: [
          IconButton(
            tooltip: 'Refresh profile',
            onPressed: () => ref.read(profileControllerProvider.notifier).reload(),
            icon: const Icon(Icons.refresh),
          ),
          const SizedBox(width: 8),
        ],
      ),
      body: SafeArea(
        child: profile.when(
          loading: () => const Center(child: CircularProgressIndicator()),
          error: (error, _) => _ProfileError(
            message: error.toString(),
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
        const SnackBar(content: Text('Profile updated.')),
      );
    } on ProfileValidationException catch (error) {
      if (mounted) _showError(error.message);
    } on ProfileApiException catch (error) {
      if (mounted) _showError(error.message);
    } catch (_) {
      if (mounted) _showError('Unable to update your profile. Please try again.');
    } finally {
      if (mounted) setState(() => _isSaving = false);
    }
  }

  void _showError(String message) => ScaffoldMessenger.of(context).showSnackBar(
    SnackBar(
      content: Text(message),
      backgroundColor: Theme.of(context).colorScheme.error,
    ),
  );

  @override
  Widget build(BuildContext context) {
    final languageState = ref.watch(profileLanguagesProvider);
    final languages = [...?languageState.value];
    if (!languages.any((language) => language.id == _languageId)) {
      languages.add(ProfileLanguage(id: _languageId, name: 'Current language'));
    }

    return Card(
      child: Padding(
        padding: const EdgeInsets.all(20),
        child: Form(
          key: _formKey,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
            Text('Personal details', style: Theme.of(context).textTheme.titleLarge),
            const SizedBox(height: 4),
            Text(
              'Update the contact information associated with your account.',
              style: Theme.of(context).textTheme.bodyMedium,
            ),
            const SizedBox(height: 20),
            LayoutBuilder(
              builder: (context, constraints) {
                final twoColumns = constraints.maxWidth >= 600;
                final firstNameField = _NameField(
                  controller: _firstName,
                  label: 'First name',
                  enabled: !_isSaving,
                );
                final lastNameField = _NameField(
                  controller: _lastName,
                  label: 'Last name',
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
              decoration: const InputDecoration(
                labelText: 'Username',
                prefixIcon: Icon(Icons.account_circle_outlined),
              ),
              validator: (value) {
                final userName = value?.trim() ?? '';
                if (userName.isEmpty || userName.length > 256) {
                  return 'Username must be between 1 and 256 characters.';
                }
                return null;
              },
            ),
            const SizedBox(height: 16),
            DropdownButtonFormField<String>(
              value: _languageId,
              isExpanded: true,
              decoration: InputDecoration(
                labelText: 'Language',
                prefixIcon: const Icon(Icons.language_outlined),
                helperText: languageState.hasError
                    ? 'Unable to load languages. Your current selection will be kept.'
                    : null,
              ),
              items: languages
                  .map(
                    (language) => DropdownMenuItem<String>(
                      value: language.id,
                      child: Text(language.label),
                    ),
                  )
                  .toList(growable: false),
              onChanged: _isSaving || languageState.isLoading
                  ? null
                  : (value) {
                      if (value != null) setState(() => _languageId = value);
                    },
              validator: (value) => value == null || value.isEmpty
                  ? 'Select a language.'
                  : null,
            ),
            const SizedBox(height: 16),
            TextFormField(
              controller: _email,
              enabled: !_isSaving,
              keyboardType: TextInputType.emailAddress,
              autofillHints: const [AutofillHints.email],
              decoration: const InputDecoration(
                labelText: 'Email',
                prefixIcon: Icon(Icons.email_outlined),
              ),
              validator: (value) {
                final email = value?.trim() ?? '';
                if (email.isEmpty || !email.contains('@')) {
                  return 'Enter a valid email address.';
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
              decoration: const InputDecoration(
                labelText: 'Phone number',
                prefixIcon: Icon(Icons.phone_outlined),
                helperText: 'Optional. The server keeps the current value when left blank.',
              ),
            ),
            const SizedBox(height: 20),
            Align(
              alignment: Alignment.centerRight,
              child: FilledButton.icon(
                onPressed: _isSaving ? null : _save,
                icon: _isSaving
                    ? const SizedBox.square(
                        dimension: 18,
                        child: CircularProgressIndicator(strokeWidth: 2),
                      )
                    : const Icon(Icons.save_outlined),
                label: const Text('Save changes'),
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
        ? '$label must not exceed 100 characters.'
        : null,
  );
}

class _PasswordCard extends StatelessWidget {
  const _PasswordCard();

  @override
  Widget build(BuildContext context) => Card(
    child: ListTile(
      leading: const Icon(Icons.password_outlined),
      title: const Text('Password'),
      subtitle: const Text('Change your account password.'),
      trailing: FilledButton.tonal(
        onPressed: () => _showChangePasswordDialog(context),
        child: const Text('Change password'),
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
        const SnackBar(content: Text('Password changed.')),
      );
    } on ProfileValidationException catch (error) {
      _showError(error.message);
    } on ProfileApiException catch (error) {
      _showError(error.message);
    } catch (_) {
      _showError('Unable to change your password. Please try again.');
    } finally {
      if (mounted) setState(() => _isSaving = false);
    }
  }

  void _showError(String message) {
    if (!mounted) return;
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: Text(message),
        backgroundColor: Theme.of(context).colorScheme.error,
      ),
    );
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: const Text('Change password'),
    content: Form(
      key: _formKey,
      child: SingleChildScrollView(
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            _PasswordField(
              controller: _currentPassword,
              label: 'Current password',
              enabled: !_isSaving,
            ),
            const SizedBox(height: 16),
            _PasswordField(
              controller: _newPassword,
              label: 'New password',
              enabled: !_isSaving,
              validator: (value) => (value?.length ?? 0) < 6
                  ? 'New password must be at least 6 characters.'
                  : null,
            ),
            const SizedBox(height: 16),
            _PasswordField(
              controller: _confirmation,
              label: 'Confirm new password',
              enabled: !_isSaving,
              validator: (value) => value != _newPassword.text
                  ? 'Passwords do not match.'
                  : null,
            ),
          ],
        ),
      ),
    ),
    actions: [
      TextButton(
        onPressed: _isSaving ? null : () => Navigator.pop(context),
        child: const Text('Cancel'),
      ),
      FilledButton(
        onPressed: _isSaving ? null : _save,
        child: _isSaving ? const Text('Saving…') : const Text('Change password'),
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
        (value) => (value?.isEmpty ?? true) ? '$label is required.' : null,
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
          Text('Account information', style: Theme.of(context).textTheme.titleLarge),
          const SizedBox(height: 12),
          _DetailRow(label: 'User ID', value: user.id, selectable: true),
          _DetailRow(label: 'Username', value: user.userName ?? 'Not set'),
          _DetailRow(label: 'Language ID', value: user.languageId),
          _DetailRow(
            label: 'Email verification',
            value: user.emailConfirmed ? 'Confirmed' : 'Not confirmed',
            icon: user.emailConfirmed ? Icons.verified_outlined : Icons.pending_outlined,
          ),
          _DetailRow(
            label: 'Phone verification',
            value: user.phoneNumberConfirmed ? 'Confirmed' : 'Not confirmed',
            icon: user.phoneNumberConfirmed ? Icons.verified_outlined : Icons.pending_outlined,
          ),
          _DetailRow(
            label: 'Roles',
            value: user.roles.isEmpty ? 'No assigned roles' : user.roles.join(', '),
          ),
          _DetailRow(label: 'Shop ID', value: user.shopId, selectable: true),
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
          Text('Shop', style: Theme.of(context).textTheme.titleLarge),
          const SizedBox(height: 12),
          _DetailRow(label: 'Name', value: shop.name),
          _DetailRow(label: 'Shop ID', value: shop.id, selectable: true),
          if (shop.shopType case final value?) _DetailRow(label: 'Type', value: value),
          if (shop.address case final value?) _DetailRow(label: 'Address', value: value),
          if (shop.phoneNumber case final value?) _DetailRow(label: 'Phone', value: value),
          if (shop.email case final value?) _DetailRow(label: 'Email', value: value),
          if (shop.taxNumber case final value?) _DetailRow(label: 'Tax number', value: value),
          if (shop.isActive case final value?)
            _DetailRow(label: 'Status', value: value ? 'Active' : 'Inactive'),
        ],
      ),
    ),
  );
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

class _ProfileError extends StatelessWidget {
  const _ProfileError({required this.message, required this.onRetry});

  final String message;
  final VoidCallback onRetry;

  @override
  Widget build(BuildContext context) => Center(
    child: Padding(
      padding: const EdgeInsets.all(24),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          const Icon(Icons.person_off_outlined, size: 48),
          const SizedBox(height: 12),
          Text(message, textAlign: TextAlign.center),
          const SizedBox(height: 12),
          FilledButton.tonal(onPressed: onRetry, child: const Text('Retry')),
        ],
      ),
    ),
  );
}
