import 'package:flutter/foundation.dart' show kDebugMode;
import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/unit_of_measure_controller.dart';
import '../data/data_exception.dart';
import '../models/unit_of_measure.dart';
import '../services/unit_of_measure_sync_service.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/theme_mode_action.dart';
import '../widgets/unit_of_measure_form_dialog.dart';

class UnitOfMeasuresScreen extends ConsumerStatefulWidget {
  const UnitOfMeasuresScreen({super.key});

  @override
  ConsumerState<UnitOfMeasuresScreen> createState() => _UnitOfMeasuresScreenState();
}

class _UnitOfMeasuresScreenState extends ConsumerState<UnitOfMeasuresScreen>
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
      ref.read(unitOfMeasureControllerProvider.notifier).reload();
    }
  }

  @override
  Widget build(BuildContext context) {
    final units = ref.watch(unitOfMeasureControllerProvider);
    return Scaffold(
      appBar: AppBar(
        title: const Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text('Units of measurement'),
            Text('Local-first inventory setup', style: TextStyle(fontSize: 12, fontWeight: FontWeight.normal)),
          ],
        ),
        actions: [
          units.maybeWhen(
            data: (value) => Badge(
              isLabelVisible: value.pendingCount > 0,
              label: Text('${value.pendingCount}'),
              child: IconButton.filledTonal(
                tooltip: 'Sync units of measurement',
                onPressed: value.isSyncing ? null : _sync,
                icon: value.isSyncing
                    ? const SizedBox.square(dimension: 18, child: CircularProgressIndicator(strokeWidth: 2))
                    : const Icon(Icons.sync),
              ),
            ),
            orElse: () => const SizedBox.shrink(),
          ),
          const ThemeModeAction(),
          const SizedBox(width: 8),
        ],
      ),
      drawer: const AppDrawer(),
      body: SafeArea(
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 900),
            child: units.when(
              loading: () => const Center(child: CircularProgressIndicator()),
              error: (error, stackTrace) => AppErrorView(
                error: error,
                stackTrace: stackTrace,
                onRetry: () => ref.read(unitOfMeasureControllerProvider.notifier).reload(),
              ),
              data: (value) => _Content(state: value, onEdit: _edit, onDelete: _delete),
            ),
          ),
        ),
      ),
      floatingActionButton: FloatingActionButton.extended(
        onPressed: _create,
        icon: const Icon(Icons.add),
        label: const Text('Add unit'),
      ),
    );
  }

  Future<void> _create() async {
    final draft = await showDialog<UnitOfMeasureDraft>(
      context: context,
      builder: (context) => const UnitOfMeasureFormDialog(),
    );
    if (draft == null) return;
    await _runMutation(
      () => ref.read(unitOfMeasureControllerProvider.notifier).create(draft),
      'Unit of measurement saved locally.',
    );
  }

  Future<void> _edit(UnitOfMeasure unit) async {
    final draft = await showDialog<UnitOfMeasureDraft>(
      context: context,
      builder: (context) => UnitOfMeasureFormDialog(unit: unit),
    );
    if (draft == null) return;
    await _runMutation(
      () => ref.read(unitOfMeasureControllerProvider.notifier).updateUnit(unit.id, draft),
      'Unit of measurement updated locally.',
    );
  }

  Future<void> _delete(UnitOfMeasure unit) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Delete unit of measurement?'),
        content: Text('“${unit.name}” will disappear now and its deletion will sync later.'),
        actions: [
          TextButton(onPressed: () => Navigator.pop(context, false), child: const Text('Cancel')),
          FilledButton.tonal(onPressed: () => Navigator.pop(context, true), child: const Text('Delete offline')),
        ],
      ),
    );
    if (confirmed != true) return;
    await _runMutation(
      () => ref.read(unitOfMeasureControllerProvider.notifier).delete(unit.id),
      'Unit of measurement deleted locally.',
    );
  }

  Future<void> _sync() async {
    try {
      final result = await ref.read(unitOfMeasureControllerProvider.notifier).syncNow();
      if (!mounted || !result.success) return;
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content: Text(result.message),
          duration: const Duration(seconds: 4),
          backgroundColor: Theme.of(context).colorScheme.primary,
        ),
      );
    } catch (error, stackTrace) {
      if (!mounted) return;
      AppErrorNotification.show(context, error, stackTrace);
      await ref.read(unitOfMeasureControllerProvider.notifier).reload();
    }
  }

  Future<void> _runMutation(Future<void> Function() action, String successMessage) async {
    try {
      await action();
      if (!mounted) return;
      ScaffoldMessenger.of(context).showSnackBar(SnackBar(content: Text(successMessage)));
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    }
  }
}

class _Content extends StatelessWidget {
  const _Content({required this.state, required this.onEdit, required this.onDelete});
  final UnitOfMeasureScreenState state;
  final ValueChanged<UnitOfMeasure> onEdit;
  final ValueChanged<UnitOfMeasure> onDelete;

  @override
  Widget build(BuildContext context) => Column(
    children: [
      if (state.lastSyncResult case final result?) _SyncSummary(result: result),
      Expanded(
        child: state.units.isEmpty
            ? const _EmptyView()
            : ListView.separated(
                padding: const EdgeInsets.fromLTRB(16, 16, 16, 100),
                itemCount: state.units.length,
                separatorBuilder: (_, _) => const SizedBox(height: 10),
                itemBuilder: (context, index) {
                  final unit = state.units[index];
                  return _UnitCard(unit: unit, onEdit: () => onEdit(unit), onDelete: () => onDelete(unit));
                },
              ),
      ),
    ],
  );
}

class _SyncSummary extends StatelessWidget {
  const _SyncSummary({required this.result});
  final UnitOfMeasureSyncResult result;
  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    final summary = '${result.message} Pulled ${result.pulled}, pushed ${result.pushed}, conflicts resolved ${result.conflictsResolved}, pending ${result.pending}.';
    final message = kDebugMode && result.failures.isNotEmpty
        ? '$summary\n\n${result.failures.map((failure) => failure.toDevelopmentString()).join('\n\n')}'
        : summary;
    return Container(
      width: double.infinity,
      margin: const EdgeInsets.fromLTRB(16, 12, 16, 0),
      padding: const EdgeInsets.all(12),
      decoration: BoxDecoration(color: result.success ? colors.primaryContainer : colors.errorContainer, borderRadius: BorderRadius.circular(12)),
      child: ConstrainedBox(
        constraints: BoxConstraints(maxHeight: kDebugMode && !result.success ? 280 : double.infinity),
        child: SingleChildScrollView(
          child: SelectableText(message, style: TextStyle(color: result.success ? colors.onPrimaryContainer : colors.onErrorContainer)),
        ),
      ),
    );
  }
}

class _UnitCard extends StatelessWidget {
  const _UnitCard({required this.unit, required this.onEdit, required this.onDelete});
  final UnitOfMeasure unit;
  final VoidCallback onEdit;
  final VoidCallback onDelete;
  @override
  Widget build(BuildContext context) => Card(
    child: ListTile(
      leading: CircleAvatar(child: Text(unit.symbol.characters.first.toUpperCase())),
      title: Row(children: [Flexible(child: Text(unit.name)), const SizedBox(width: 8), _SyncStateIcon(unit: unit)]),
      subtitle: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [Text(unit.symbol), if (unit.description case final description?) Text(description, maxLines: 2, overflow: TextOverflow.ellipsis)],
      ),
      isThreeLine: unit.description != null,
      trailing: PopupMenuButton<String>(
        onSelected: (value) => value == 'edit' ? onEdit() : onDelete(),
        itemBuilder: (context) => const [PopupMenuItem(value: 'edit', child: Text('Edit')), PopupMenuItem(value: 'delete', child: Text('Delete'))],
      ),
    ),
  );
}

class _SyncStateIcon extends StatelessWidget {
  const _SyncStateIcon({required this.unit});
  final UnitOfMeasure unit;
  @override
  Widget build(BuildContext context) {
    final failed = unit.syncStatus == UnitOfMeasureSyncStatus.failed;
    final synced = unit.syncStatus == UnitOfMeasureSyncStatus.synced;
    return Tooltip(
      message: unit.lastSyncError ?? (synced ? 'Synced' : failed ? 'Sync failed' : 'Waiting to sync'),
      child: Icon(failed ? Icons.cloud_off_outlined : synced ? Icons.cloud_done_outlined : Icons.cloud_upload_outlined, size: 18, color: failed ? Theme.of(context).colorScheme.error : Theme.of(context).colorScheme.outline),
    );
  }
}

class _EmptyView extends StatelessWidget {
  const _EmptyView();
  @override
  Widget build(BuildContext context) => const Center(
    child: Padding(
      padding: EdgeInsets.all(32),
      child: Column(mainAxisSize: MainAxisSize.min, children: [Icon(Icons.straighten_outlined, size: 56), SizedBox(height: 12), Text('No units of measurement yet'), SizedBox(height: 4), Text('Add one now—even while completely offline.')]),
    ),
  );
}
