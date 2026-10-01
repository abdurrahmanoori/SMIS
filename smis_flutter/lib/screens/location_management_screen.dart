import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../data/data_exception.dart';
import '../data/location_admin_api.dart';
import '../l10n/app_localizations.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
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
  bool _mutating = false;
  Object? _error;

  @override
  void initState() {
    super.initState();
    _reload();
  }

  Future<void> _reload() async {
    if (!mounted) return;

    setState(() {
      _loading = true;
      _error = null;
    });

    try {
      final results = await Future.wait([_api.provinces(), _api.districts()]);

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
            context.l10n.text(
              'Only SuperAdmin can manage provinces and districts.',
            ),
          ),
        ),
      );
    }

    return DefaultTabController(
      length: 2,
      child: Scaffold(
        appBar: AppBar(
          title: Text(context.l10n.text('Location management')),
          actions: [
            IconButton(
              tooltip: context.l10n.text('Refresh'),
              onPressed: _loading || _mutating ? null : _reload,
              icon: const Icon(Icons.refresh),
            ),
            const HomeAction(),
            const LocaleAction(),
            const ThemeModeAction(),
            const SizedBox(width: 8),
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
            ? AppErrorView(error: _error!, onRetry: _reload)
            : TabBarView(
                children: [
                  _LocationList(
                    items: _provinces,
                    emptyText: context.l10n.text('No provinces yet'),
                    addLabel: context.l10n.text('Add province'),
                    enabled: !_mutating,
                    onCreate: () => _create(isProvince: true),
                    onEdit: (item) => _edit(item, isProvince: true),
                    onDelete: (item) => _delete(item, isProvince: true),
                  ),
                  _LocationList(
                    items: _districts,
                    emptyText: context.l10n.text('No districts yet'),
                    addLabel: context.l10n.text('Add district'),
                    showProvince: true,
                    enabled: !_mutating,
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
    if (isProvince) {
      final name = await _nameDialog(title: context.l10n.text('Add province'));
      if (name == null) return;

      await _mutate(() => _api.createProvince(name));
      return;
    }

    final district = await _districtDialog(
      title: context.l10n.text('Add district'),
    );
    if (district == null) return;

    await _mutate(
      () => _api.createDistrict(district.name, district.provinceId),
    );
  }

  Future<void> _edit(LocationAdminItem item, {required bool isProvince}) async {
    if (isProvince) {
      final name = await _nameDialog(
        title: context.l10n.text('Edit province'),
        initialValue: item.name,
      );

      if (name == null || name == item.name) return;

      await _mutate(() => _api.updateProvince(item.id, name));
      return;
    }

    final district = await _districtDialog(
      title: context.l10n.text('Edit district'),
      initialName: item.name,
      initialProvinceId: item.provinceId,
    );

    if (district == null ||
        (district.name == item.name &&
            district.provinceId == item.provinceId)) {
      return;
    }

    await _mutate(
      () => _api.updateDistrict(item.id, district.name, district.provinceId),
    );
  }

  Future<void> _delete(
    LocationAdminItem item, {
    required bool isProvince,
  }) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (dialogContext) => AlertDialog(
        title: Text(
          dialogContext.l10n.text(
            isProvince ? 'Delete province?' : 'Delete district?',
          ),
        ),
        content: Text(item.name),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(dialogContext, false),
            child: Text(dialogContext.l10n.text('Cancel')),
          ),
          FilledButton.tonal(
            onPressed: () => Navigator.pop(dialogContext, true),
            child: Text(dialogContext.l10n.text('Delete')),
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
      builder: (dialogContext) => AlertDialog(
        title: Text(title),
        content: TextField(
          controller: controller,
          autofocus: true,
          decoration: InputDecoration(
            labelText: dialogContext.l10n.text('Name'),
          ),
          textInputAction: TextInputAction.done,
          onSubmitted: (_) {
            final value = controller.text.trim();
            if (value.isNotEmpty) Navigator.pop(dialogContext, value);
          },
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(dialogContext),
            child: Text(dialogContext.l10n.text('Cancel')),
          ),
          FilledButton(
            onPressed: () {
              final value = controller.text.trim();
              if (value.isNotEmpty) Navigator.pop(dialogContext, value);
            },
            child: Text(dialogContext.l10n.text('Save')),
          ),
        ],
      ),
    );

    controller.dispose();
    return result;
  }

  Future<_DistrictFormResult?> _districtDialog({
    required String title,
    String initialName = '',
    String? initialProvinceId,
  }) async {
    if (_provinces.isEmpty) {
      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Text(
              context.l10n.text('Create a province before adding a district.'),
            ),
          ),
        );
      }
      return null;
    }

    final controller = TextEditingController(text: initialName);
    var selectedProvinceId =
        _provinces.any((province) => province.id == initialProvinceId)
        ? initialProvinceId!
        : _provinces.first.id;

    final result = await showDialog<_DistrictFormResult>(
      context: context,
      builder: (dialogContext) => StatefulBuilder(
        builder: (dialogContext, setDialogState) => AlertDialog(
          title: Text(title),
          content: SizedBox(
            width: 420,
            child: Column(
              mainAxisSize: MainAxisSize.min,
              children: [
                TextField(
                  controller: controller,
                  autofocus: true,
                  decoration: InputDecoration(
                    labelText: dialogContext.l10n.text('Name'),
                  ),
                ),
                const SizedBox(height: 16),
                DropdownButtonFormField<String>(
                  initialValue: selectedProvinceId,
                  decoration: InputDecoration(
                    labelText: dialogContext.l10n.text('Province'),
                  ),
                  items: _provinces
                      .map(
                        (province) => DropdownMenuItem<String>(
                          value: province.id,
                          child: Text(province.name),
                        ),
                      )
                      .toList(growable: false),
                  onChanged: (value) {
                    if (value != null) {
                      setDialogState(() => selectedProvinceId = value);
                    }
                  },
                ),
              ],
            ),
          ),
          actions: [
            TextButton(
              onPressed: () => Navigator.pop(dialogContext),
              child: Text(dialogContext.l10n.text('Cancel')),
            ),
            FilledButton(
              onPressed: () {
                final name = controller.text.trim();
                if (name.isEmpty) return;

                Navigator.pop(
                  dialogContext,
                  _DistrictFormResult(
                    name: name,
                    provinceId: selectedProvinceId,
                  ),
                );
              },
              child: Text(dialogContext.l10n.text('Save')),
            ),
          ],
        ),
      ),
    );

    controller.dispose();
    return result;
  }

  Future<void> _mutate(Future<void> Function() action) async {
    if (_mutating) return;

    setState(() => _mutating = true);
    try {
      await action();
      await _reload();
    } catch (error, stackTrace) {
      if (!mounted) return;
      AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }
}

class _LocationList extends StatelessWidget {
  const _LocationList({
    required this.items,
    required this.emptyText,
    required this.addLabel,
    required this.enabled,
    required this.onCreate,
    required this.onEdit,
    required this.onDelete,
    this.showProvince = false,
  });

  final List<LocationAdminItem> items;
  final String emptyText;
  final String addLabel;
  final bool enabled;
  final bool showProvince;
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
                subtitle:
                    showProvince &&
                        item.provinceName != null &&
                        item.provinceName!.isNotEmpty
                    ? Text(item.provinceName!)
                    : null,
                trailing: enabled
                    ? PopupMenuButton<String>(
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
                      )
                    : null,
              ),
            );
          },
        ),
      Positioned(
        right: 16,
        bottom: 16,
        child: FloatingActionButton.extended(
          onPressed: enabled ? onCreate : null,
          icon: const Icon(Icons.add),
          label: Text(addLabel),
        ),
      ),
    ],
  );
}

class _DistrictFormResult {
  const _DistrictFormResult({required this.name, required this.provinceId});

  final String name;
  final String provinceId;
}
