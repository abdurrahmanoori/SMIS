import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../data/location_admin_api.dart';
import '../l10n/app_localizations.dart';
import '../widgets/app_drawer.dart';
import '../widgets/home_action.dart';
import '../widgets/locale_action.dart';
import '../widgets/theme_mode_action.dart';

class LocationManagementScreen extends ConsumerStatefulWidget {
  const LocationManagementScreen({super.key});

  @override
  ConsumerState<LocationManagementScreen> createState() =>
      _LocationManagementScreenState();
}

class _LocationManagementScreenState
    extends ConsumerState<LocationManagementScreen> {
  final _api = LocationAdminApi();
  List<LocationAdminItem> _provinces = const [];
  List<LocationAdminItem> _districts = const [];
  bool _loading = true;
  Object? _error;

  @override
  void initState() {
    super.initState();
    _reload();
  }

  Future<void> _reload() async {
    setState(() {
      _loading = true;
      _error = null;
    });
    try {
      final results = await Future.wait([
        _api.provinces(),
        _api.districts(),
      ]);
      if (!mounted) return;
      setState(() {
        _provinces = results[0];
        _districts = results[1];
        _loading = false;
      });
    } catch (error) {
      if (!mounted) return;
      setState(() {
        _error = error;
        _loading = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    final session = ref.watch(authControllerProvider).session;
    if (session == null || !session.isSuperAdmin) {
      return Scaffold(
        appBar: AppBar(title: Text(context.l10n.text('Locations'))),
        drawer: const AppDrawer(),
        body: Center(
          child: Text(
            context.l10n.text('Only SuperAdmin can manage provinces and districts.'),
          ),
        ),
      );
    }

    return DefaultTabController(
      length: 2,
      child: Scaffold(
        appBar: AppBar(
          title: Text(context.l10n.text('Location management')),
          actions: const [
            HomeAction(),
            LocaleAction(),
            ThemeModeAction(),
            SizedBox(width: 8),
          ],
          bottom: TabBar(
            tabs: [
              Tab(text: context.l10n.text('Provinces')),
              Tab(text: context.l10n.text('Districts')),
            ],
          ),
        ),
        drawer: const AppDrawer(),
        body: _loading
            ? const Center(child: CircularProgressIndicator())
            : _error != null
            ? _ErrorView(error: _error!, onRetry: _reload)
            : TabBarView(
                children: [
                  _LocationList(
                    items: _provinces,
                    emptyText: context.l10n.text('No provinces yet'),
                    addLabel: context.l10n.text('Add province'),
                    onCreate: () => _create(isProvince: true),
                    onEdit: (item) => _edit(item, isProvince: true),
                    onDelete: (item) => _delete(item, isProvince: true),
                  ),
                  _LocationList(
                    items: _districts,
                    emptyText: context.l10n.text('No districts yet'),
                    addLabel: context.l10n.text('Add district'),
                    onCreate: () => _create(isProvince: false),
                    onEdit: (item) => _edit(item, isProvince: false),
                    onDelete: (item) => _delete(item, isProvince: false),
                  ),
                ],
              ),
      ),
    );
  }

  Future<void> _create({required bool isProvince}) async {
    final name = await _nameDialog(
      title: context.l10n.text(isProvince ? 'Add province' : 'Add district'),
    );
    if (name == null) return;
    await _mutate(
      () => isProvince
          ? _api.createProvince(name)
          : _api.createDistrict(name),
    );
  }

  Future<void> _edit(
    LocationAdminItem item, {
    required bool isProvince,
  }) async {
    final name = await _nameDialog(
      title: context.l10n.text(isProvince ? 'Edit province' : 'Edit district'),
      initialValue: item.name,
    );
    if (name == null || name == item.name) return;
    await _mutate(
      () => isProvince
          ? _api.updateProvince(item.id, name)
          : _api.updateDistrict(item.id, name),
    );
  }

  Future<void> _delete(
    LocationAdminItem item, {
    required bool isProvince,
  }) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text(
          context.l10n.text(isProvince ? 'Delete province?' : 'Delete district?'),
        ),
        content: Text(item.name),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: Text(context.l10n.text('Cancel')),
          ),
          FilledButton.tonal(
            onPressed: () => Navigator.pop(context, true),
            child: Text(context.l10n.text('Delete')),
          ),
        ],
      ),
    );
    if (confirmed != true) return;
    await _mutate(
      () => isProvince
          ? _api.deleteProvince(item.id)
          : _api.deleteDistrict(item.id),
    );
  }

  Future<String?> _nameDialog({
    required String title,
    String initialValue = '',
  }) async {
    final controller = TextEditingController(text: initialValue);
    final result = await showDialog<String>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text(title),
        content: TextField(
          controller: controller,
          autofocus: true,
          decoration: InputDecoration(labelText: context.l10n.text('Name')),
          textInputAction: TextInputAction.done,
          onSubmitted: (_) => Navigator.pop(
            context,
            controller.text.trim(),
          ),
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context),
            child: Text(context.l10n.text('Cancel')),
          ),
          FilledButton(
            onPressed: () => Navigator.pop(
              context,
              controller.text.trim(),
            ),
            child: Text(context.l10n.text('Save')),
          ),
        ],
      ),
    );
    controller.dispose();
    if (result == null || result.trim().isEmpty) return null;
    return result.trim();
  }

  Future<void> _mutate(Future<void> Function() action) async {
    try {
      await action();
      await _reload();
    } catch (error) {
      if (!mounted) return;
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text(error.toString())),
      );
    }
  }
}

class _LocationList extends StatelessWidget {
  const _LocationList({
    required this.items,
    required this.emptyText,
    required this.addLabel,
    required this.onCreate,
    required this.onEdit,
    required this.onDelete,
  });

  final List<LocationAdminItem> items;
  final String emptyText;
  final String addLabel;
  final VoidCallback onCreate;
  final ValueChanged<LocationAdminItem> onEdit;
  final ValueChanged<LocationAdminItem> onDelete;

  @override
  Widget build(BuildContext context) => Stack(
    children: [
      if (items.isEmpty)
        Center(child: Text(emptyText))
      else
        ListView.separated(
          padding: const EdgeInsets.fromLTRB(16, 16, 16, 96),
          itemCount: items.length,
          separatorBuilder: (_, _) => const SizedBox(height: 8),
          itemBuilder: (context, index) {
            final item = items[index];
            return Card(
              child: ListTile(
                leading: const Icon(Icons.location_on_outlined),
                title: Text(item.name),
                trailing: PopupMenuButton<String>(
                  onSelected: (value) =>
                      value == 'edit' ? onEdit(item) : onDelete(item),
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
              ),
            );
          },
        ),
      Positioned(
        right: 16,
        bottom: 16,
        child: FloatingActionButton.extended(
          onPressed: onCreate,
          icon: const Icon(Icons.add),
          label: Text(addLabel),
        ),
      ),
    ],
  );
}

class _ErrorView extends StatelessWidget {
  const _ErrorView({required this.error, required this.onRetry});

  final Object error;
  final VoidCallback onRetry;

  @override
  Widget build(BuildContext context) => Center(
    child: Padding(
      padding: const EdgeInsets.all(24),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          Text(error.toString(), textAlign: TextAlign.center),
          const SizedBox(height: 12),
          FilledButton(
            onPressed: onRetry,
            child: Text(context.l10n.text('Retry')),
          ),
        ],
      ),
    ),
  );
}
