import 'package:flutter/foundation.dart' show kDebugMode;
import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../../data/sync/category_sync_service.dart';
import '../../domain/entities/category.dart';
import '../providers/category_providers.dart';
import '../state/category_controller.dart';
import '../widgets/category_form_dialog.dart';

/// ConsumerStatefulWidget is a Riverpod-aware StatefulWidget.
/// It gives you access to 'ref' to watch or read providers within the state.
class CategoryListPage extends ConsumerStatefulWidget {
  const CategoryListPage({super.key});

  @override
  ConsumerState<CategoryListPage> createState() => _CategoryListPageState();
}

/// WidgetsBindingObserver allows this class to listen to app-level events
/// like the app going to background or coming back to foreground.
class _CategoryListPageState extends ConsumerState<CategoryListPage>
    with WidgetsBindingObserver {
  @override
  void initState() {
    super.initState();
    // Register this class to observe lifecycle changes.
    WidgetsBinding.instance.addObserver(this);
  }

  @override
  void dispose() {
    // Unregister to avoid memory leaks.
    WidgetsBinding.instance.removeObserver(this);
    super.dispose();
  }

  /// Triggered when the app lifecycle changes (e.g., user minimizes the app).
  @override
  void didChangeAppLifecycleState(AppLifecycleState state) {
    // When the app comes back to the front, we might want to refresh data.
    if (state == AppLifecycleState.resumed) {
      ref.read(categoryControllerProvider.notifier).reload();
    }
  }

  @override
  Widget build(BuildContext context) {
    /// ref.watch(provider) makes the widget rebuild whenever the provider's state changes.
    /// Since categoryControllerProvider is an AsyncNotifier, it returns an [AsyncValue].
    final categories = ref.watch(categoryControllerProvider);

    /// Scaffold provides the basic Material Design layout structure (AppBar, Body, FAB, etc.)
    return Scaffold(
      appBar: AppBar(
        title: const Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text('Categories'),
            Text(
              'Local-first inventory setup',
              style: TextStyle(fontSize: 12, fontWeight: FontWeight.normal),
            ),
          ],
        ),
        actions: [
          /// .maybeWhen is an extension on AsyncValue to handle different states (Loading, Error, Data).
          categories.maybeWhen(
            data: (value) => _SyncButton(
              state: value,
              onPressed: value.isSyncing ? null : _sync,
            ),
            orElse: () => const SizedBox.shrink(), // shrink() is a 0x0 widget.
          ),
          const SizedBox(width: 12),
        ],
      ),

      /// SafeArea ensures the UI doesn't overlap with system notches or home indicators.
      body: SafeArea(
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 900),
            child: categories.when(
              loading: () => const Center(child: CircularProgressIndicator()),
              error: (error, stackTrace) => _ErrorView(
                message: error.toString(),
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
        label: const Text('Add category'),
      ),
    );
  }

  Future<void> _create() async {
    /// showDialog is how you push a modal in Flutter.
    /// It returns a Future that completes when the dialog is closed.
    final draft = await showDialog<CategoryDraft>(
      context: context,
      builder: (context) => const CategoryFormDialog(),
    );
    if (draft == null) return;
    await _runMutation(
      () => ref.read(categoryControllerProvider.notifier).create(draft),
      'Category saved locally.',
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
      'Category updated locally.',
    );
  }

  Future<void> _delete(Category category) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Delete category?'),
        content: Text(
          '“${category.name}” will disappear now and its deletion will sync later.',
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            // Closes dialog, returns false.
            child: const Text('Cancel'),
          ),
          FilledButton.tonal(
            onPressed: () => Navigator.pop(context, true),
            // Closes dialog, returns true.
            child: const Text('Delete offline'),
          ),
        ],
      ),
    );
    if (confirmed != true) return;
    await _runMutation(
      () => ref.read(categoryControllerProvider.notifier).delete(category.id),
      'Category deleted locally.',
    );
  }

  Future<void> _sync() async {
    try {
      final result = await ref
          .read(categoryControllerProvider.notifier)
          .syncNow();

      /// IMPORTANT: Always check 'mounted' before using 'context' after an 'await'.
      /// If the user navigated away while we were waiting, 'context' is no longer valid.
      if (!mounted) return;

      // Failed sync details already appear in the persistent summary at the
      // top of the page. Avoid showing the same exception and stack trace a
      // second time in a bottom SnackBar.
      if (result.success) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Text(result.message),
            duration: const Duration(seconds: 4),
            backgroundColor: Theme.of(context).colorScheme.primary,
          ),
        );
      }
    } catch (error, stackTrace) {
      if (!mounted) return;
      _showError(error, stackTrace);
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
      if (mounted) _showError(error, stackTrace);
    }
  }

  void _showError(Object error, [StackTrace? stackTrace]) {
    final message = kDebugMode && stackTrace != null
        ? '${error.runtimeType}: $error\n\nStack trace:\n$stackTrace'
        : error.toString();
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: SelectableText(message),
        backgroundColor: Theme.of(context).colorScheme.error,
      ),
    );
  }
}

/// StatelessWidget is a widget that doesn't hold any internal mutable state.
/// It only depends on the configuration passed to it.
class _SyncButton extends StatelessWidget {
  const _SyncButton({required this.state, required this.onPressed});

  final CategoryScreenState state;
  final VoidCallback? onPressed;

  @override
  Widget build(BuildContext context) => Badge(
    isLabelVisible: state.pendingCount > 0,
    label: Text('${state.pendingCount}'),
    child: IconButton.filledTonal(
      tooltip: 'Sync Categories',
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
      /// Using the 'if case' syntax (Dart 3+) for pattern matching.
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
    /// Theme.of(context) allows you to access the app's global styling.
    final colors = Theme.of(context).colorScheme;
    final successful = result.success;
    final summary =
        '${result.message} Pulled ${result.pulled}, pushed ${result.pushed}, '
        'conflicts resolved ${result.conflictsResolved}, pending ${result.pending}.';
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
        padding: const EdgeInsets.fromLTRB(16, 12, 8, 12),
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
                    category.isActive ? 'Active' : 'Inactive',
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
              itemBuilder: (context) => const [
                PopupMenuItem(value: 'edit', child: Text('Edit')),
                PopupMenuItem(value: 'delete', child: Text('Delete')),
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
              ? 'Synced'
              : failed
              ? 'Sync failed'
              : 'Waiting to sync'),
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
  Widget build(BuildContext context) => const Center(
    child: Padding(
      padding: EdgeInsets.all(32),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          Icon(Icons.category_outlined, size: 56),
          SizedBox(height: 12),
          Text('No categories yet'),
          SizedBox(height: 4),
          Text('Add one now—even while completely offline.'),
        ],
      ),
    ),
  );
}

class _ErrorView extends StatelessWidget {
  const _ErrorView({required this.message, required this.onRetry});

  final String message;
  final VoidCallback onRetry;

  @override
  Widget build(BuildContext context) => Center(
    child: Padding(
      padding: const EdgeInsets.all(24),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          const Icon(Icons.storage_outlined, size: 48),
          const SizedBox(height: 12),
          Text(message, textAlign: TextAlign.center),
          const SizedBox(height: 12),
          FilledButton.tonal(onPressed: onRetry, child: const Text('Retry')),
        ],
      ),
    ),
  );
}
