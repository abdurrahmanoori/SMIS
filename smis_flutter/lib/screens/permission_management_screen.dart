import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../data/permission_administration_api.dart';
import '../l10n/app_localizations.dart';
import '../models/permission_administration.dart';
import '../widgets/app_error_view.dart';

class PermissionManagementScreen extends ConsumerStatefulWidget {
  const PermissionManagementScreen({super.key});
  @override
  ConsumerState<PermissionManagementScreen> createState() =>
      _PermissionManagementScreenState();
}

class _PermissionManagementScreenState
    extends ConsumerState<PermissionManagementScreen> {
  PermissionCatalog? _catalog;
  PermissionRole? _role;
  List<ManagedComponentPermission> _rows = [];
  String _saved = '';
  bool _loading = true;
  bool _busy = false;
  bool _canLeave = false;
  Object? _error;
  int _requestId = 0;

  bool get _dirty =>
      _saved.isNotEmpty &&
      jsonEncode(_rows.map((r) => r.toJson()).toList()) != _saved;
  bool get _superAdminRole => _role?.name == 'SuperAdmin';
  bool get _locked => _loading || _busy || _error != null;
  PermissionAdministrationApi? get _api {
    final session = ref.read(authControllerProvider).session;
    return session?.isSuperAdmin == true
        ? PermissionAdministrationApi(token: session!.token)
        : null;
  }

  @override
  void initState() {
    super.initState();
    Future<void>.microtask(_load);
  }

  void _message(String text) {
    if (!mounted) return;
    ScaffoldMessenger.of(
      context,
    ).showSnackBar(SnackBar(content: Text(context.l10n.text(text))));
  }

  Future<bool> _discardChanges() async {
    if (!_dirty) return true;
    return await showDialog<bool>(
          context: context,
          builder: (context) => AlertDialog(
            title: Text(context.l10n.text('Discard unsaved changes?')),
            content: Text(
              context.l10n.text('Your permission changes have not been saved.'),
            ),
            actions: [
              TextButton(
                onPressed: () => Navigator.pop(context, false),
                child: Text(context.l10n.text('Cancel')),
              ),
              FilledButton(
                onPressed: () => Navigator.pop(context, true),
                child: Text(context.l10n.text('Discard')),
              ),
            ],
          ),
        ) ??
        false;
  }

  Future<void> _load({PermissionRole? role}) async {
    final api = _api;
    if (api == null || !mounted) return;
    final id = ++_requestId;
    setState(() {
      _loading = true;
      _error = null;
      _rows = [];
      _saved = '';
    });
    try {
      final catalog = await api.getCatalog();
      final requestedId = role?.id ?? _role?.id;
      final selected =
          catalog.roles.where((r) => r.id == requestedId).firstOrNull ??
          catalog.roles.where((r) => r.name != 'SuperAdmin').firstOrNull ??
          catalog.roles.firstOrNull;
      final grants = selected == null
          ? <ManagedComponentPermission>[]
          : await api.getPermissions(selected.id);
      if (!mounted || id != _requestId || _api == null) return;
      final byId = {for (final row in grants) row.componentId: row};
      final rows = [
        for (final component in catalog.components)
          selected?.name == 'SuperAdmin'
              ? ManagedComponentPermission(
                  componentId: component.id,
                  grants: List<bool>.filled(5, true),
                )
              : byId[component.id] ??
                    ManagedComponentPermission(componentId: component.id),
      ];
      setState(() {
        _catalog = catalog;
        _role = selected;
        _rows = rows;
        _saved = jsonEncode(rows.map((r) => r.toJson()).toList());
        _loading = false;
      });
    } catch (error) {
      if (!mounted || id != _requestId) return;
      setState(() {
        _catalog = null;
        _rows = [];
        _saved = '';
        _error = error;
        _loading = false;
      });
    }
  }

  Future<void> _reload() async {
    if (_busy || _loading || !await _discardChanges() || !mounted) return;
    await _load();
  }

  Future<void> _selectRole(String? id) async {
    if (_locked ||
        id == null ||
        id == _role?.id ||
        !await _discardChanges() ||
        !mounted) {
      return;
    }
    final role = _catalog!.roles.firstWhere((r) => r.id == id);
    await _load(role: role);
  }

  Future<void> _refreshSession() async {
    try {
      await ref.read(authControllerProvider.notifier).refreshSession();
    } catch (_) {
      _message(
        'Changes were saved. Refresh your session when the server is available.',
      );
    }
  }

  Future<void> _save() async {
    final api = _api;
    final role = _role;
    if (api == null || role == null || _locked || !_dirty || _superAdminRole) {
      return;
    }
    setState(() => _busy = true);
    try {
      await api.savePermissions(role.id, _rows);
      if (!mounted) return;
      setState(
        () => _saved = jsonEncode(_rows.map((r) => r.toJson()).toList()),
      );
      _message('Permissions saved.');
      await _refreshSession();
    } catch (error) {
      if (!mounted) return;
      // Never queue or persist permission edits for a later offline upload.
      setState(() => _error = error);
    } finally {
      if (mounted) setState(() => _busy = false);
    }
  }

  Future<void> _editComponent(ManagedComponent component) async {
    if (_locked || _api == null || !await _discardChanges() || !mounted) return;
    final result = await showDialog<_ComponentEdit>(
      context: context,
      builder: (_) => _ComponentDialog(component: component),
    );
    if (result == null || !mounted) return;
    final api = _api;
    if (api == null) return;
    setState(() => _busy = true);
    try {
      await api.updateComponent(
        component,
        name: result.name,
        displayOrder: result.displayOrder,
        isActive: result.isActive,
      );
      _message('Component saved.');
      await _refreshSession();
      if (mounted) await _load();
    } catch (error) {
      if (mounted) setState(() => _error = error);
    } finally {
      if (mounted) setState(() => _busy = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    final session = ref.watch(authControllerProvider).session;
    ref.listen(
      authControllerProvider.select((state) => state.session?.userId),
      (previous, next) {
        if (previous == next) return;
        ++_requestId;
        setState(() {
          _catalog = null;
          _rows = [];
          _saved = '';
          _error = null;
          _loading = true;
          _role = null;
        });
        Future<void>.microtask(_load);
      },
    );
    final l10n = context.l10n;
    final allowed = session?.isSuperAdmin == true;
    return PopScope(
      canPop: _canLeave || (!_dirty && !_busy),
      onPopInvokedWithResult: (didPop, result) async {
        if (didPop || _busy) return;
        if (await _discardChanges() && context.mounted) {
          setState(() => _canLeave = true);
          Navigator.of(context).pop();
        }
      },
      child: DefaultTabController(
        length: 2,
        child: Scaffold(
          appBar: AppBar(
            title: Text(l10n.text('Permission management')),
            actions: [
              IconButton(
                tooltip: l10n.text('Refresh'),
                onPressed: allowed && !_loading && !_busy ? _reload : null,
                icon: const Icon(Icons.refresh),
              ),
            ],
            bottom: allowed
                ? TabBar(
                    tabs: [
                      Tab(text: l10n.text('Role permissions')),
                      Tab(text: l10n.text('Application components')),
                    ],
                  )
                : null,
          ),
          body: !allowed
              ? Center(
                  child: Text(
                    l10n.text('Only SuperAdmin can manage permissions.'),
                  ),
                )
              : _loading
              ? const Center(child: CircularProgressIndicator())
              : _error != null
              ? SingleChildScrollView(
                  child: AppErrorView(
                    error: _error!,
                    onRetry: _busy ? null : _reload,
                  ),
                )
              : TabBarView(children: [_matrix(context), _components(context)]),
        ),
      ),
    );
  }

  Widget _matrix(BuildContext context) {
    final l10n = context.l10n;
    final catalog = _catalog;
    if (catalog == null || _role == null) {
      return Center(child: Text(l10n.text('No roles are configured.')));
    }
    return Column(
      children: [
        Padding(
          padding: const EdgeInsets.all(16),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Text(
                l10n.text(
                  'Online only. Changes affect every user assigned to the selected role.',
                ),
              ),
              const SizedBox(height: 12),
              InputDecorator(
                decoration: InputDecoration(
                  labelText: l10n.text('Role'),
                  border: const OutlineInputBorder(),
                ),
                child: DropdownButtonHideUnderline(
                  child: DropdownButton<String>(
                    value: _role!.id,
                    isExpanded: true,
                    isDense: true,
                    items: [
                      for (final role in catalog.roles)
                        DropdownMenuItem(
                          value: role.id,
                          child: Text(role.name),
                        ),
                    ],
                    onChanged: _locked ? null : _selectRole,
                  ),
                ),
              ),
              const SizedBox(height: 8),
              Text(
                l10n.text(
                  _superAdminRole
                      ? 'SuperAdmin always has full access. This matrix is read-only.'
                      : 'Multiple roles combine their grants. Inactive components remain unavailable.',
                ),
              ),
            ],
          ),
        ),
        Expanded(
          child: SingleChildScrollView(
            child: SingleChildScrollView(
              scrollDirection: Axis.horizontal,
              child: DataTable(
                columns: [
                  DataColumn(label: Text(l10n.text('Component'))),
                  for (final label in [
                    'View',
                    'Read',
                    'Create',
                    'Update',
                    'Delete',
                  ])
                    DataColumn(label: Text(l10n.text(label))),
                ],
                rows: [
                  for (
                    var index = 0;
                    index < catalog.components.length;
                    index++
                  )
                    DataRow(
                      cells: [
                        DataCell(
                          Column(
                            mainAxisAlignment: MainAxisAlignment.center,
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(catalog.components[index].name),
                              Text(
                                catalog.components[index].key,
                                style: Theme.of(context).textTheme.bodySmall,
                              ),
                              if (!catalog.components[index].isActive)
                                Text(l10n.text('Inactive')),
                            ],
                          ),
                        ),
                        for (var grant = 0; grant < 5; grant++)
                          DataCell(
                            Checkbox(
                              value: _rows[index].grants[grant],
                              onChanged: _locked || _superAdminRole
                                  ? null
                                  : (value) => setState(
                                      () => _rows[index].grants[grant] =
                                          value ?? false,
                                    ),
                            ),
                          ),
                      ],
                    ),
                ],
              ),
            ),
          ),
        ),
        SafeArea(
          top: false,
          child: Padding(
            padding: const EdgeInsets.all(16),
            child: Row(
              children: [
                Expanded(
                  child: Text(
                    l10n.text(_dirty ? 'Unsaved changes' : 'All changes saved'),
                  ),
                ),
                FilledButton.icon(
                  onPressed: _locked || !_dirty || _superAdminRole
                      ? null
                      : _save,
                  icon: const Icon(Icons.save_outlined),
                  label: Text(l10n.text(_busy ? 'Saving...' : 'Save')),
                ),
              ],
            ),
          ),
        ),
      ],
    );
  }

  Widget _components(BuildContext context) {
    final l10n = context.l10n;
    return ListView(
      padding: const EdgeInsets.all(16),
      children: [
        Text(
          l10n.text(
            'Component keys are defined by the application. Edit their name, order, and active status here.',
          ),
        ),
        const SizedBox(height: 12),
        for (final component in _catalog?.components ?? <ManagedComponent>[])
          Card(
            child: ListTile(
              title: Text(component.name),
              subtitle: Text(
                '${component.key} · ${component.displayOrder} · ${l10n.text(component.isActive ? 'Active' : 'Inactive')}',
              ),
              trailing: IconButton(
                tooltip: l10n.text('Edit'),
                icon: const Icon(Icons.edit_outlined),
                onPressed: _locked ? null : () => _editComponent(component),
              ),
            ),
          ),
      ],
    );
  }
}

class _ComponentEdit {
  const _ComponentEdit(this.name, this.displayOrder, this.isActive);
  final String name;
  final int displayOrder;
  final bool isActive;
}

class _ComponentDialog extends StatefulWidget {
  const _ComponentDialog({required this.component});
  final ManagedComponent component;
  @override
  State<_ComponentDialog> createState() => _ComponentDialogState();
}

class _ComponentDialogState extends State<_ComponentDialog> {
  final _form = GlobalKey<FormState>();
  late final _name = TextEditingController(text: widget.component.name);
  late final _order = TextEditingController(
    text: widget.component.displayOrder.toString(),
  );
  late bool _active = widget.component.isActive;
  @override
  void dispose() {
    _name.dispose();
    _order.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final l10n = context.l10n;
    return AlertDialog(
      title: Text(l10n.text('Edit component')),
      content: SizedBox(
        width: 440,
        child: SingleChildScrollView(
          child: Form(
            key: _form,
            child: Column(
              mainAxisSize: MainAxisSize.min,
              children: [
                SelectableText(widget.component.key),
                const SizedBox(height: 16),
                TextFormField(
                  controller: _name,
                  maxLength: 200,
                  decoration: InputDecoration(labelText: l10n.text('Name')),
                  validator: (value) =>
                      value == null ||
                          value.trim().isEmpty ||
                          value.trim().length > 200
                      ? l10n.text('Enter a name of up to 200 characters.')
                      : null,
                ),
                TextFormField(
                  controller: _order,
                  keyboardType: TextInputType.number,
                  decoration: InputDecoration(
                    labelText: l10n.text('Display order'),
                  ),
                  validator: (value) {
                    final order = int.tryParse(value ?? '');
                    return order == null || order < 0 || order > 2147483647
                        ? l10n.text('Enter a non-negative whole number.')
                        : null;
                  },
                ),
                SwitchListTile(
                  contentPadding: EdgeInsets.zero,
                  title: Text(l10n.text('Active')),
                  value: _active,
                  onChanged: (value) => setState(() => _active = value),
                ),
                if (!_active)
                  Text(
                    l10n.text(
                      'Deactivating this component blocks access to its feature.',
                    ),
                  ),
              ],
            ),
          ),
        ),
      ),
      actions: [
        TextButton(
          onPressed: () => Navigator.pop(context),
          child: Text(l10n.text('Cancel')),
        ),
        FilledButton(
          onPressed: () {
            if (_form.currentState!.validate()) {
              Navigator.pop(
                context,
                _ComponentEdit(
                  _name.text.trim(),
                  int.parse(_order.text),
                  _active,
                ),
              );
            }
          },
          child: Text(l10n.text('Save')),
        ),
      ],
    );
  }
}
