import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';
import '../controllers/auth_controller.dart';
import '../data/permission_administration_api.dart';
import '../l10n/app_localizations.dart';
import '../models/permission_administration.dart';
import '../models/task_role_administration.dart';
import '../widgets/app_error_view.dart';

class TaskRoleManagementScreen extends ConsumerStatefulWidget {
  const TaskRoleManagementScreen({super.key});
  @override
  ConsumerState<TaskRoleManagementScreen> createState() =>
      _TaskRoleManagementScreenState();
}

class _TaskRoleManagementScreenState
    extends ConsumerState<TaskRoleManagementScreen> {
  List<ManagedTask> _tasks = [];
  List<ManagedRole> _roles = [];
  List<ManagedComponent> _components = [];
  ManagedRole? _role;
  Map<String, bool> _grants = {};
  String _saved = '';
  bool _loading = true, _busy = false, _canLeave = false;
  Object? _error;
  int _request = 0;
  String _snapshot() => jsonEncode(
    _grants.entries.toList()..sort((a, b) => a.key.compareTo(b.key)),
    toEncodable: (value) =>
        value is MapEntry<String, bool> ? [value.key, value.value] : value,
  );
  bool get _dirty => _saved.isNotEmpty && _snapshot() != _saved;
  bool get _locked => _loading || _busy || _error != null;
  bool get _superRole => _role?.name == 'SuperAdmin';
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
    if (mounted) {
      ScaffoldMessenger.of(
        context,
      ).showSnackBar(SnackBar(content: Text(context.l10n.text(text))));
    }
  }

  Future<bool> _discard() async {
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

  Future<void> _load({String? roleId}) async {
    final api = _api;
    if (api == null || !mounted) return;
    final request = ++_request;
    setState(() {
      _loading = true;
      _error = null;
    });
    try {
      final catalog = await api.getCatalog();
      final tasks = await api.getTasks();
      final roles = await api.getRoles();
      final selected =
          roles.where((r) => r.id == (roleId ?? _role?.id)).firstOrNull ??
          roles.where((r) => r.name != 'SuperAdmin').firstOrNull ??
          roles.firstOrNull;
      final grants = selected == null
          ? <String, bool>{}
          : await api.getTaskPermissions(selected.id);
      if (!mounted || request != _request || _api == null) return;
      setState(() {
        _components = catalog.components;
        _tasks = tasks;
        _roles = roles;
        _role = selected;
        _grants = grants;
        _saved = _snapshot();
        _loading = false;
      });
    } catch (error) {
      if (mounted && request == _request) {
        setState(() {
          _error = error;
          _loading = false;
        });
      }
    }
  }

  Future<void> _reload() async {
    if (_busy || _loading || !await _discard() || !mounted) return;
    await _load();
  }

  Future<void> _select(String? id) async {
    if (_locked ||
        id == null ||
        id == _role?.id ||
        !await _discard() ||
        !mounted) {
      return;
    }
    await _load(roleId: id);
  }

  Future<void> _mutate(
    Future<void> Function(PermissionAdministrationApi) action,
  ) async {
    final api = _api;
    if (api == null || _locked) return;
    setState(() => _busy = true);
    try {
      await action(api);
      if (!mounted) return;
      _message('Changes saved.');
      await _load();
      try {
        await ref.read(authControllerProvider.notifier).refreshSession();
      } catch (_) {
        _message(
          'Changes were saved. Refresh your session when the server is available.',
        );
      }
    } catch (error) {
      if (mounted) setState(() => _error = error);
    } finally {
      if (mounted) setState(() => _busy = false);
    }
  }

  Future<bool> _confirm(String text) async =>
      await showDialog<bool>(
        context: context,
        builder: (context) => AlertDialog(
          title: Text(context.l10n.text('Delete')),
          content: Text(context.l10n.text(text)),
          actions: [
            TextButton(
              onPressed: () => Navigator.pop(context, false),
              child: Text(context.l10n.text('Cancel')),
            ),
            FilledButton(
              onPressed: () => Navigator.pop(context, true),
              child: Text(context.l10n.text('Delete')),
            ),
          ],
        ),
      ) ??
      false;
  Future<void> _editRole([ManagedRole? role]) async {
    if (_locked || role?.isSystem == true || !await _discard() || !mounted) {
      return;
    }
    final name = await showDialog<String>(
      context: context,
      builder: (_) => _RoleDialog(role: role),
    );
    if (name == null || !mounted) return;
    await _mutate((api) => api.saveRole(name, id: role?.id));
  }

  Future<void> _editTask([ManagedTask? task]) async {
    if (_locked || !await _discard() || !mounted) return;
    final draft = await showDialog<_TaskDraft>(
      context: context,
      builder: (_) => _TaskDialog(task: task, components: _components),
    );
    if (draft == null || !mounted) return;
    await _mutate(
      (api) => api.saveTask(
        id: task?.id,
        key: draft.key,
        name: draft.name,
        componentId: draft.componentId,
        isActive: draft.active,
      ),
    );
  }

  Future<void> _deleteRole(ManagedRole role) async {
    if (_locked ||
        role.isSystem ||
        role.userCount > 0 ||
        !await _discard() ||
        !mounted) {
      return;
    }
    if (!await _confirm(
          'Delete this custom role and its permission records?',
        ) ||
        !mounted) {
      return;
    }
    await _mutate((api) => api.deleteRole(role.id));
  }

  Future<void> _deleteTask(ManagedTask task) async {
    if (_locked || task.isSystem || !await _discard() || !mounted) return;
    if (!await _confirm(
          'Delete this custom task? Remove its role permission records first.',
        ) ||
        !mounted) {
      return;
    }
    await _mutate((api) => api.deleteTask(task.id));
  }

  @override
  Widget build(BuildContext context) {
    final allowed =
        ref.watch(authControllerProvider).session?.isSuperAdmin == true;
    ref.listen(authControllerProvider.select((s) => s.session?.userId), (
      previous,
      next,
    ) {
      if (previous == next) return;
      ++_request;
      setState(() {
        _tasks = [];
        _roles = [];
        _components = [];
        _role = null;
        _grants = {};
        _saved = '';
        _error = null;
        _loading = true;
      });
      Future<void>.microtask(_load);
    });
    final l10n = context.l10n;
    return PopScope(
      canPop: _canLeave || (!_dirty && !_busy),
      onPopInvokedWithResult: (didPop, result) async {
        if (didPop || _busy) return;
        if (await _discard() && context.mounted) {
          setState(() => _canLeave = true);
          Navigator.pop(context);
        }
      },
      child: DefaultTabController(
        length: 3,
        child: Scaffold(
          appBar: AppBar(
            title: Text(l10n.text('Tasks and roles')),
            actions: [
              IconButton(
                tooltip: l10n.text('Refresh'),
                onPressed: allowed && !_busy && !_loading ? _reload : null,
                icon: const Icon(Icons.refresh),
              ),
            ],
            bottom: allowed
                ? TabBar(
                    isScrollable: true,
                    tabs: [
                      Tab(text: l10n.text('Task permissions')),
                      Tab(text: l10n.text('Application tasks')),
                      Tab(text: l10n.text('Roles')),
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
              : TabBarView(children: [_matrix(), _taskList(), _roleList()]),
        ),
      ),
    );
  }

  Widget _matrix() {
    final l10n = context.l10n;
    if (_role == null) {
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
              DropdownButtonFormField<String>(
                initialValue: _role!.id,
                key: ValueKey(_role!.id),
                decoration: InputDecoration(
                  labelText: l10n.text('Role'),
                  border: const OutlineInputBorder(),
                ),
                items: [
                  for (final r in _roles)
                    DropdownMenuItem(value: r.id, child: Text(r.name)),
                ],
                onChanged: _locked ? null : _select,
              ),
              const SizedBox(height: 8),
              Text(
                l10n.text(
                  _superRole
                      ? 'SuperAdmin always has full access. This matrix is read-only.'
                      : 'Task grants also require the matching component permission. Missing grants deny access.',
                ),
              ),
            ],
          ),
        ),
        Expanded(
          child: ListView(
            children: [
              for (final task in _tasks)
                ListTile(
                  title: Text(task.name),
                  subtitle: Text(
                    '${task.key} · ${l10n.text(task.isActive ? 'Active' : 'Inactive')}',
                  ),
                  leading: Checkbox(
                    value: _superRole ? true : (_grants[task.id] ?? false),
                    onChanged: _locked || _superRole
                        ? null
                        : (value) =>
                              setState(() => _grants[task.id] = value ?? false),
                  ),
                  trailing: _superRole
                      ? null
                      : IconButton(
                          tooltip: l10n.text('Remove permission record'),
                          icon: const Icon(Icons.delete_outline),
                          onPressed: _locked || !_grants.containsKey(task.id)
                              ? null
                              : () => setState(() => _grants.remove(task.id)),
                        ),
                ),
            ],
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
                  onPressed: _locked || !_dirty || _superRole
                      ? null
                      : () => _mutate(
                          (api) => api.saveTaskPermissions(
                            _role!.id,
                            Map.of(_grants),
                          ),
                        ),
                  icon: const Icon(Icons.save_outlined),
                  label: Text(l10n.text('Save')),
                ),
              ],
            ),
          ),
        ),
      ],
    );
  }

  Widget _taskList() {
    final l10n = context.l10n;
    return ListView(
      padding: const EdgeInsets.all(16),
      children: [
        Text(
          l10n.text(
            'Task keys identify application operations. New tasks require code integration before they protect an action.',
          ),
        ),
        const SizedBox(height: 12),
        Align(
          alignment: AlignmentDirectional.centerStart,
          child: FilledButton.icon(
            onPressed: _locked || _components.isEmpty
                ? null
                : () => _editTask(),
            icon: const Icon(Icons.add),
            label: Text(l10n.text('Add task')),
          ),
        ),
        for (final task in _tasks)
          Card(
            child: ListTile(
              title: Text(task.name),
              subtitle: Text(
                '${task.key}\n${_components.where((c) => c.id == task.componentId).firstOrNull?.name ?? task.componentId} · ${l10n.text(task.isActive ? 'Active' : 'Inactive')}',
              ),
              isThreeLine: true,
              trailing: Row(
                mainAxisSize: MainAxisSize.min,
                children: [
                  IconButton(
                    tooltip: l10n.text('Edit'),
                    onPressed: _locked ? null : () => _editTask(task),
                    icon: const Icon(Icons.edit_outlined),
                  ),
                  IconButton(
                    tooltip: l10n.text('Delete'),
                    onPressed: _locked || task.isSystem
                        ? null
                        : () => _deleteTask(task),
                    icon: const Icon(Icons.delete_outline),
                  ),
                ],
              ),
            ),
          ),
      ],
    );
  }

  Widget _roleList() {
    final l10n = context.l10n;
    return ListView(
      padding: const EdgeInsets.all(16),
      children: [
        Text(
          l10n.text(
            'Built-in roles are protected. New roles start without component or task grants.',
          ),
        ),
        const SizedBox(height: 12),
        Align(
          alignment: AlignmentDirectional.centerStart,
          child: FilledButton.icon(
            onPressed: _locked ? null : () => _editRole(),
            icon: const Icon(Icons.add),
            label: Text(l10n.text('Add role')),
          ),
        ),
        for (final role in _roles)
          Card(
            child: ListTile(
              title: Text(role.name),
              subtitle: Text(
                '${l10n.text(role.isSystem ? 'Built-in role' : 'Custom role')} · ${role.userCount} ${l10n.text('Users')}',
              ),
              trailing: Row(
                mainAxisSize: MainAxisSize.min,
                children: [
                  IconButton(
                    tooltip: l10n.text('Edit'),
                    onPressed: _locked || role.isSystem
                        ? null
                        : () => _editRole(role),
                    icon: const Icon(Icons.edit_outlined),
                  ),
                  IconButton(
                    tooltip: l10n.text('Delete'),
                    onPressed: _locked || role.isSystem || role.userCount > 0
                        ? null
                        : () => _deleteRole(role),
                    icon: const Icon(Icons.delete_outline),
                  ),
                ],
              ),
            ),
          ),
      ],
    );
  }
}

class _RoleDialog extends StatefulWidget {
  const _RoleDialog({this.role});
  final ManagedRole? role;
  @override
  State<_RoleDialog> createState() => _RoleDialogState();
}

class _RoleDialogState extends State<_RoleDialog> {
  final _form = GlobalKey<FormState>();
  late final _name = TextEditingController(text: widget.role?.name ?? '');
  @override
  void dispose() {
    _name.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: Text(
      context.l10n.text(widget.role == null ? 'Add role' : 'Edit role'),
    ),
    content: SizedBox(
      width: 420,
      child: Form(
        key: _form,
        child: TextFormField(
          controller: _name,
          autofocus: true,
          maxLength: 256,
          decoration: InputDecoration(labelText: context.l10n.text('Name')),
          validator: (v) =>
              v == null || v.trim().isEmpty || v.trim().length > 256
              ? context.l10n.text('Enter a valid name.')
              : null,
        ),
      ),
    ),
    actions: [
      TextButton(
        onPressed: () => Navigator.pop(context),
        child: Text(context.l10n.text('Cancel')),
      ),
      FilledButton(
        onPressed: () {
          if (_form.currentState!.validate()) {
            Navigator.pop(context, _name.text.trim());
          }
        },
        child: Text(context.l10n.text('Save')),
      ),
    ],
  );
}

class _TaskDraft {
  const _TaskDraft(this.key, this.name, this.componentId, this.active);
  final String key, name, componentId;
  final bool active;
}

class _TaskDialog extends StatefulWidget {
  const _TaskDialog({this.task, required this.components});
  final ManagedTask? task;
  final List<ManagedComponent> components;
  @override
  State<_TaskDialog> createState() => _TaskDialogState();
}

class _TaskDialogState extends State<_TaskDialog> {
  final _form = GlobalKey<FormState>();
  late final _key = TextEditingController(text: widget.task?.key ?? '');
  late final _name = TextEditingController(text: widget.task?.name ?? '');
  late String _component =
      widget.task?.componentId ?? widget.components.first.id;
  late bool _active = widget.task?.isActive ?? true;
  @override
  void dispose() {
    _key.dispose();
    _name.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final l10n = context.l10n;
    return AlertDialog(
      title: Text(l10n.text(widget.task == null ? 'Add task' : 'Edit task')),
      content: SizedBox(
        width: 440,
        child: SingleChildScrollView(
          child: Form(
            key: _form,
            child: Column(
              mainAxisSize: MainAxisSize.min,
              children: [
                TextFormField(
                  controller: _key,
                  readOnly: widget.task != null,
                  maxLength: 150,
                  decoration: InputDecoration(labelText: l10n.text('Task key')),
                  validator: (v) =>
                      v == null ||
                          !RegExp(
                            r'^[A-Za-z][A-Za-z0-9.]*$',
                          ).hasMatch(v.trim()) ||
                          v.trim().length > 150
                      ? l10n.text(
                          'Use letters, numbers, and dots; start with a letter.',
                        )
                      : null,
                ),
                TextFormField(
                  controller: _name,
                  maxLength: 200,
                  decoration: InputDecoration(labelText: l10n.text('Name')),
                  validator: (v) =>
                      v == null || v.trim().isEmpty || v.trim().length > 200
                      ? l10n.text('Enter a name of up to 200 characters.')
                      : null,
                ),
                DropdownButtonFormField<String>(
                  initialValue: _component,
                  isExpanded: true,
                  decoration: InputDecoration(
                    labelText: l10n.text('Component'),
                  ),
                  items: [
                    for (final c in widget.components)
                      DropdownMenuItem(value: c.id, child: Text(c.name)),
                  ],
                  onChanged: widget.task?.isSystem == true
                      ? null
                      : (v) => setState(() => _component = v!),
                ),
                SwitchListTile(
                  contentPadding: EdgeInsets.zero,
                  title: Text(l10n.text('Active')),
                  value: _active,
                  onChanged: (v) => setState(() => _active = v),
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
                _TaskDraft(
                  _key.text.trim(),
                  _name.text.trim(),
                  _component,
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
