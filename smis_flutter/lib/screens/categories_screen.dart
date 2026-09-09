import 'package:flutter/foundation.dart' show kDebugMode;
import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../controllers/category_controller.dart';
import '../controllers/profile_controller.dart';
import '../data/data_exception.dart';
import '../models/category.dart';
import '../l10n/app_localizations.dart';
import '../services/category_sync_service.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/theme_mode_action.dart';
import '../widgets/category_form_dialog.dart';
import '../widgets/locale_action.dart';
import 'profile_screen.dart';

class CategoriesScreen extends ConsumerStatefulWidget {
  const CategoriesScreen({super.key});

  @override
  ConsumerState<CategoriesScreen> createState() => _CategoriesScreenState();
}

class _CategoriesScreenState extends ConsumerState<CategoriesScreen>
    with WidgetsBindingObserver {
  @override
  void initState() {
    super.initState();
    WidgetsBinding.instance.addObserver(this);
  }

  @override
  void dispose() {
    WidgetsBinding.instance.removeObserver(this);
    super.dispose();
  }

  @override
  void didChangeAppLifecycleState(AppLifecycleState state) {
    if (state == AppLifecycleState.resumed) {
      ref.read(categoryControllerProvider.notifier).reload();
    }
  }

  @override
  Widget build(BuildContext context) {
    final categories = ref.watch(categoryControllerProvider);
    final authenticatedUser = ref.watch(authControllerProvider).session;

    return Scaffold(
      appBar: AppBar(
        title: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(context.l10n.text('Categories')),
            Text(
              context.l10n.text('Local-first inventory setup'),
              style: const TextStyle(fontSize: 12, fontWeight: FontWeight.normal),
            ),
          ],
        ),
        actions: [
          categories.maybeWhen(
            data: (value) => _SyncButton(
              state: value,
              onPressed: value.isSyncing ? null : _sync,
            ),
            orElse: () => const SizedBox.shrink(),
          ),
          const LocaleAction(),
          const ThemeModeAction(),
          const SizedBox(width: 8),
        ],
      ),
      drawer: const AppDrawer(),
      body: SafeArea(
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 900),
            child: categories.when(
              loading: () => const Center(child: CircularProgressIndicator()),
              error: (error, stackTrace) => AppErrorView(
                error: error,
                stackTrace: stackTrace,
                onRetry: () =>
                    ref.read(categoryControllerProvider.notifier).reload(),
              ),
              data: (value) => _CategoryContent(
                state: value,
                onEdit: _edit,
                onDelete: _delete,
              ),
            ),
          ),
        ),
      ),
      floatingActionButton: FloatingActionButton.extended(
        onPressed: _create,
        icon: const Icon(Icons.add),
        label: Text(context.l10n.text('Add category')),
      ),
    );
  }

  Future<void> _create() async {
    final draft = await showDialog<CategoryDraft>(
      context: context,
      builder: (context) => const CategoryFormDialog(),
    );
    if (draft == null) return;
    await _runMutation(
      () => ref.read(categoryControllerProvider.notifier).create(draft),
      context.l10n.text('Category saved locally.'),
    );
  }

  Future<void> _edit(Category category) async {
    final draft = await showDialog<CategoryDraft>(
      context: context,
      builder: (context) => CategoryFormDialog(category: category),
    );
    if (draft == null) return;
    await _runMutation(
      () => ref
          .read(categoryControllerProvider.notifier)
          .updateCategory(category.id, draft),
      context.l10n.text('Category updated locally.'),
    );
  }

  Future<void> _delete(Category category) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text(context.l10n.text('Delete category?')),
        content: Text(
          context.l10n.text(
            '“{name}” will disappear now and its deletion will sync later.',
            {'name': category.name},
          ),
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: Text(context.l10n.text('Cancel')),
          ),
          FilledButton.tonal(
            onPressed: () => Navigator.pop(context, true),
            child: Text(context.l10n.text('Delete offline')),
          ),
        ],
      ),
    );
    if (confirmed != true) return;
    await _runMutation(
      () => ref.read(categoryControllerProvider.notifier).delete(category.id),
      context.l10n.text('Category deleted locally.'),
    );
  }

  Future<void> _sync() async {
    try {
      final result = await ref
          .read(categoryControllerProvider.notifier)
          .syncNow();

      if (!mounted) return;

      if (result.success) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Text(context.l10n.syncMessage(result.message)),
            duration: const Duration(seconds: 4),
            backgroundColor: Theme.of(context).colorScheme.primary,
          ),
        );
      }
    } catch (error, stackTrace) {
      if (!mounted) return;
      AppErrorNotification.show(context, error, stackTrace);
      await ref.read(categoryControllerProvider.notifier).reload();
    }
  }

  Future<void> _runMutation(
    Future<void> Function() action,
    String successMessage,
  ) async {
    try {
      await action();
      if (!mounted) return;
      ScaffoldMessenger.of(
        context,
      ).showSnackBar(SnackBar(content: Text(successMessage)));
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    }
  }
}

class _SyncButton extends StatelessWidget {
  const _SyncButton({required this.state, required this.onPressed});

  final CategoryScreenState state;
  final VoidCallback? onPressed;

  @override
  Widget build(BuildContext context) => Badge(
    isLabelVisible: state.pendingCount > 0,
    label: Text('${state.pendingCount}'),
    child: IconButton.filledTonal(
      tooltip: context.l10n.text('Sync categories'),
      onPressed: onPressed,
      icon: state.isSyncing
          ? const SizedBox.square(
              dimension: 18,
              child: CircularProgressIndicator(strokeWidth: 2),
            )
          : const Icon(Icons.sync),
    ),
  );
}

class _CategoryContent extends StatelessWidget {
  const _CategoryContent({
    required this.state,
    required this.onEdit,
    required this.onDelete,
  });

  final CategoryScreenState state;
  final ValueChanged<Category> onEdit;
  final ValueChanged<Category> onDelete;

  @override
  Widget build(BuildContext context) => Column(
    children: [
      if (state.lastSyncResult case final result?) _SyncSummary(result: result),
      Expanded(
        child: state.categories.isEmpty
            ? const _EmptyView()
            : ListView.separated(
                padding: const EdgeInsets.fromLTRB(16, 16, 16, 100),
                itemCount: state.categories.length,
                separatorBuilder: (_, _) => const SizedBox(height: 10),
                itemBuilder: (context, index) {
                  final category = state.categories[index];
                  return _CategoryCard(
                    category: category,
                    onEdit: () => onEdit(category),
                    onDelete: () => onDelete(category),
                  );
                },
              ),
      ),
    ],
  );
}

class _SyncSummary extends StatelessWidget {
  const _SyncSummary({required this.result});

  final CategorySyncResult result;

  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    final successful = result.success;
    final summary =
        '${context.l10n.syncMessage(result.message)} '
        '${context.l10n.text(
          'Pulled {pulled}, pushed {pushed}, conflicts resolved {conflicts}, pending {pending}.',
          {
            'pulled': result.pulled,
            'pushed': result.pushed,
            'conflicts': result.conflictsResolved,
            'pending': result.pending,
          },
        )}';
    final displayMessage = kDebugMode && result.failures.isNotEmpty
        ? '$summary\n\n${result.failures.map((failure) => failure.toDevelopmentString()).join('\n\n')}'
        : summary;
    return Container(
      width: double.infinity,
      margin: const EdgeInsets.fromLTRB(16, 12, 16, 0),
      padding: const EdgeInsets.all(12),
      decoration: BoxDecoration(
        color: successful ? colors.primaryContainer : colors.errorContainer,
        borderRadius: BorderRadius.circular(12),
      ),
      child: ConstrainedBox(
        constraints: BoxConstraints(
          maxHeight: kDebugMode && !successful ? 280 : double.infinity,
        ),
        child: SingleChildScrollView(
          child: SelectableText(
            displayMessage,
            style: TextStyle(
              color: successful
                  ? colors.onPrimaryContainer
                  : colors.onErrorContainer,
            ),
          ),
        ),
      ),
    );
  }
}

class _CategoryCard extends StatelessWidget {
  const _CategoryCard({
    required this.category,
    required this.onEdit,
    required this.onDelete,
  });

  final Category category;
  final VoidCallback onEdit;
  final VoidCallback onDelete;

  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    return Card(
      color: colors.surface,
      child: Padding(
        padding: const EdgeInsetsDirectional.fromSTEB(16, 12, 8, 12),
        child: Row(
          children: [
            CircleAvatar(
              backgroundColor: category.isActive
                  ? colors.primaryContainer
                  : colors.surfaceContainerHighest,
              child: Text(
                category.name.characters.first.toUpperCase(),
                style: const TextStyle(fontWeight: FontWeight.bold),
              ),
            ),
            const SizedBox(width: 14),
            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Row(
                    children: [
                      Flexible(
                        child: Text(
                          category.name,
                          style: Theme.of(context).textTheme.titleMedium,
                        ),
                      ),
                      const SizedBox(width: 8),
                      _SyncStateIcon(category: category),
                    ],
                  ),
                  if (category.code case final code?)
                    Text(code, style: Theme.of(context).textTheme.labelMedium),
                  if (category.description case final description?)
                    Text(
                      description,
                      maxLines: 2,
                      overflow: TextOverflow.ellipsis,
                    ),
                  const SizedBox(height: 4),
                  Text(
                    context.l10n.text(category.isActive ? 'Active' : 'Inactive'),
                    style: TextStyle(
                      color: category.isActive
                          ? colors.primary
                          : colors.outline,
                    ),
                  ),
                ],
              ),
            ),
            PopupMenuButton<String>(
              onSelected: (value) => value == 'edit' ? onEdit() : onDelete(),
              itemBuilder: (context) => [
                PopupMenuItem(
                  value: 'edit',
                  child: Text(context.l10n.text('Edit')),
                ),
                PopupMenuItem(
                  value: 'delete',
                  child: Text(context.l10n.text('Delete')),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}

class _SyncStateIcon extends StatelessWidget {
  const _SyncStateIcon({required this.category});

  final Category category;

  @override
  Widget build(BuildContext context) {
    final failed = category.syncStatus == CategorySyncStatus.failed;
    final synced = category.syncStatus == CategorySyncStatus.synced;
    return Tooltip(
      message:
          category.lastSyncError ??
          (synced
              ? context.l10n.text('Synced')
              : failed
              ? context.l10n.text('Sync failed')
              : context.l10n.text('Waiting to sync')),
      child: Icon(
        failed
            ? Icons.cloud_off_outlined
            : synced
            ? Icons.cloud_done_outlined
            : Icons.cloud_upload_outlined,
        size: 18,
        color: failed
            ? Theme.of(context).colorScheme.error
            : Theme.of(context).colorScheme.outline,
      ),
    );
  }
}

class _EmptyView extends StatelessWidget {
  const _EmptyView();

  @override
  Widget build(BuildContext context) => Center(
    child: Padding(
      padding: const EdgeInsets.all(32),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          const Icon(Icons.category_outlined, size: 56),
          const SizedBox(height: 12),
          Text(context.l10n.text('No categories yet')),
          const SizedBox(height: 4),
          Text(context.l10n.text('Add one now—even while completely offline.')),
        ],
      ),
    ),
  );
}
