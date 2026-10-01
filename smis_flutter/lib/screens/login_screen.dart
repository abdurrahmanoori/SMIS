import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../data/data_exception.dart';
import '../models/auth_session.dart';
import '../l10n/app_localizations.dart';
import '../widgets/locale_action.dart';

class LoginScreen extends ConsumerStatefulWidget {
  const LoginScreen({super.key});

  @override
  ConsumerState<LoginScreen> createState() => _LoginScreenState();
}

class _LoginScreenState extends ConsumerState<LoginScreen> {
  final _formKey = GlobalKey<FormState>();
  final _emailController = TextEditingController();
  final _passwordController = TextEditingController();
  bool _obscurePassword = true;

  @override
  void dispose() {
    _emailController.dispose();
    _passwordController.dispose();
    super.dispose();
  }

  Future<void> _submit() async {
    if (!(_formKey.currentState?.validate() ?? false)) return;
    await ref
        .read(authControllerProvider.notifier)
        .login(
          email: _emailController.text,
          password: _passwordController.text,
        );
  }

  @override
  Widget build(BuildContext context) {
    final auth = ref.watch(authControllerProvider);
    final colors = Theme.of(context).colorScheme;
    final l10n = context.l10n;

    return Scaffold(
      body: SafeArea(
        child: Center(
          child: SingleChildScrollView(
            padding: const EdgeInsets.all(24),
            child: ConstrainedBox(
              constraints: const BoxConstraints(maxWidth: 420),
              child: Card(
                child: Padding(
                  padding: const EdgeInsets.all(24),
                  child: Form(
                    key: _formKey,
                    child: Column(
                      mainAxisSize: MainAxisSize.min,
                      crossAxisAlignment: CrossAxisAlignment.stretch,
                      children: [
                        const Align(
                          alignment: AlignmentDirectional.centerEnd,
                          child: LocaleAction(showLabel: true),
                        ),
                        Icon(
                          Icons.storefront_outlined,
                          size: 48,
                          color: colors.primary,
                        ),
                        const SizedBox(height: 16),
                        Text(
                          l10n.text('Sign in to SMIS'),
                          textAlign: TextAlign.center,
                          style: Theme.of(context).textTheme.headlineSmall,
                        ),
                        const SizedBox(height: 8),
                        Text(
                          l10n.text(
                            'Use your SMIS account to synchronize your local changes.',
                          ),
                          textAlign: TextAlign.center,
                          style: Theme.of(context).textTheme.bodyMedium,
                        ),
                        const SizedBox(height: 24),
                        if (auth.error case final error?) ...[
                          _LoginError(error: error),
                          const SizedBox(height: 16),
                        ],
                        if (auth.savedSessions.isNotEmpty) ...[
                          _SavedAccountsList(
                            sessions: auth.savedSessions,
                            activeUserId: auth.session?.userId,
                            disabled: auth.isSwitchingAccount,
                            onSwitch: (userId) => ref
                                .read(authControllerProvider.notifier)
                                .switchAccount(userId),
                            onRemove: (userId) => ref
                                .read(authControllerProvider.notifier)
                                .removeAccount(userId),
                          ),
                          const SizedBox(height: 24),
                          Row(
                            children: [
                              const Expanded(child: Divider()),
                              Padding(
                                padding: const EdgeInsets.symmetric(
                                  horizontal: 16,
                                ),
                                child: Text(
                                  l10n.text('OR SIGN IN WITH ANOTHER ACCOUNT'),
                                ),
                              ),
                              const Expanded(child: Divider()),
                            ],
                          ),
                          const SizedBox(height: 24),
                        ],
                        TextFormField(
                          controller: _emailController,
                          enabled: !auth.isSigningIn,
                          keyboardType: TextInputType.emailAddress,
                          textInputAction: TextInputAction.next,
                          autofillHints: const [AutofillHints.username],
                          decoration: InputDecoration(
                            labelText: l10n.text('Email'),
                            prefixIcon: const Icon(Icons.email_outlined),
                          ),
                          validator: (value) {
                            final email = value?.trim() ?? '';
                            if (email.isEmpty) {
                              return l10n.text('Email is required.');
                            }
                            if (!email.contains('@')) {
                              return l10n.text('Enter a valid email address.');
                            }
                            return null;
                          },
                        ),
                        const SizedBox(height: 16),
                        TextFormField(
                          controller: _passwordController,
                          enabled: !auth.isSigningIn,
                          obscureText: _obscurePassword,
                          textInputAction: TextInputAction.done,
                          autofillHints: const [AutofillHints.password],
                          onFieldSubmitted: (_) => _submit(),
                          decoration: InputDecoration(
                            labelText: l10n.text('Password'),
                            prefixIcon: const Icon(Icons.lock_outline),
                            suffixIcon: IconButton(
                              tooltip: l10n.text(
                                _obscurePassword
                                    ? 'Show password'
                                    : 'Hide password',
                              ),
                              onPressed: auth.isSigningIn
                                  ? null
                                  : () => setState(
                                      () =>
                                          _obscurePassword = !_obscurePassword,
                                    ),
                              icon: Icon(
                                _obscurePassword
                                    ? Icons.visibility_outlined
                                    : Icons.visibility_off_outlined,
                              ),
                            ),
                          ),
                          validator: (value) => (value?.isEmpty ?? true)
                              ? l10n.text('Password is required.')
                              : null,
                        ),
                        const SizedBox(height: 24),
                        FilledButton(
                          onPressed: auth.isSigningIn ? null : _submit,
                          child: auth.isSigningIn
                              ? const SizedBox.square(
                                  dimension: 20,
                                  child: CircularProgressIndicator(
                                    strokeWidth: 2,
                                  ),
                                )
                              : Text(l10n.text('Sign in')),
                        ),
                        const SizedBox(height: 16),
                        Text(
                          l10n.text(
                            'After signing in once, your local work remains available offline.',
                          ),
                          textAlign: TextAlign.center,
                          style: Theme.of(context).textTheme.bodySmall,
                        ),
                      ],
                    ),
                  ),
                ),
              ),
            ),
          ),
        ),
      ),
    );
  }
}

class _LoginError extends StatelessWidget {
  const _LoginError({required this.error});

  final Object error;

  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    final messages = AppErrorPresentation.messages(context, error);
    final referenceId = AppErrorPresentation.referenceId(error);
    final showDevelopmentDetails = AppErrorPresentation.showDevelopmentDetails;

    return DecoratedBox(
      decoration: BoxDecoration(
        color: colors.errorContainer,
        borderRadius: BorderRadius.circular(12),
      ),
      child: Padding(
        padding: const EdgeInsets.all(12),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Row(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Icon(Icons.error_outline, color: colors.onErrorContainer),
                const SizedBox(width: 10),
                Expanded(
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      for (var index = 0; index < messages.length; index++) ...[
                        if (index > 0) const SizedBox(height: 4),
                        Text(
                          messages[index],
                          style: TextStyle(color: colors.onErrorContainer),
                        ),
                      ],
                      if (!showDevelopmentDetails && referenceId != null) ...[
                        const SizedBox(height: 6),
                        Text(
                          '${context.l10n.text('Reference')}: $referenceId',
                          style: TextStyle(
                            color: colors.onErrorContainer.withValues(
                              alpha: 0.75,
                            ),
                            fontSize: 11,
                          ),
                        ),
                      ],
                    ],
                  ),
                ),
              ],
            ),
            if (showDevelopmentDetails) ...[
              const SizedBox(height: 8),
              ExpansionTile(
                tilePadding: EdgeInsets.zero,
                childrenPadding: EdgeInsets.zero,
                dense: true,
                leading: const Icon(Icons.bug_report_outlined, size: 18),
                title: Text(
                  context.l10n.text('Development details'),
                  style: TextStyle(
                    color: colors.onErrorContainer,
                    fontSize: 11,
                    fontWeight: FontWeight.bold,
                  ),
                ),
                children: [
                  Container(
                    width: double.infinity,
                    constraints: const BoxConstraints(maxHeight: 220),
                    padding: const EdgeInsets.all(10),
                    decoration: BoxDecoration(
                      color: Colors.black87,
                      borderRadius: BorderRadius.circular(6),
                    ),
                    child: SingleChildScrollView(
                      child: SelectableText(
                        AppErrorPresentation.developmentDetails(error),
                        style: const TextStyle(
                          color: Colors.greenAccent,
                          fontFamily: 'monospace',
                          fontSize: 10,
                        ),
                      ),
                    ),
                  ),
                ],
              ),
            ],
          ],
        ),
      ),
    );
  }
}

class _SavedAccountsList extends StatelessWidget {
  const _SavedAccountsList({
    required this.sessions,
    this.activeUserId,
    required this.disabled,
    required this.onSwitch,
    required this.onRemove,
  });

  final List<AuthSession> sessions;
  final String? activeUserId;
  final bool disabled;
  final ValueChanged<String> onSwitch;
  final ValueChanged<String> onRemove;

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.stretch,
      children: [
        Text(
          context.l10n.text('Saved accounts'),
          style: Theme.of(context).textTheme.titleSmall,
        ),
        const SizedBox(height: 8),
        ...sessions.map((session) {
          final isSelected = session.userId == activeUserId;
          return Card(
            elevation: isSelected ? 2 : 0,
            color: isSelected
                ? Theme.of(context).colorScheme.primaryContainer
                : Theme.of(
                    context,
                  ).colorScheme.surfaceContainerHighest.withValues(alpha: 0.5),
            margin: const EdgeInsets.only(bottom: 8),
            child: ListTile(
              leading: CircleAvatar(
                child: Text(session.userName[0].toUpperCase()),
              ),
              title: Text(session.userName),
              subtitle: Text(session.email),
              trailing: isSelected
                  ? const Icon(Icons.check_circle, color: Colors.green)
                  : IconButton(
                      icon: const Icon(Icons.close, size: 20),
                      onPressed: disabled
                          ? null
                          : () => onRemove(session.userId),
                    ),
              onTap: isSelected || disabled
                  ? null
                  : () => onSwitch(session.userId),
            ),
          );
        }),
      ],
    );
  }
}
