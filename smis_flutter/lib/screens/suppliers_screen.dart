import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../data/data_exception.dart';
import '../data/supplier_api.dart';
import '../l10n/app_localizations.dart';
import '../models/application_component_keys.dart';
import '../widgets/active_shop_context.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/home_action.dart';
import '../widgets/locale_action.dart';
import '../widgets/theme_mode_action.dart';

class SuppliersScreen extends ConsumerStatefulWidget {
  const SuppliersScreen({super.key});

  @override
  ConsumerState<SuppliersScreen> createState() => _SuppliersScreenState();
}

class _SuppliersScreenState extends ConsumerState<SuppliersScreen> {
  final _api = SupplierApi();
  final _searchController = TextEditingController();

  List<SupplierItem> _suppliers = const [];
  bool _loading = true;
  bool _mutating = false;
  bool _isSearching = false;
  Object? _error;
  String? _shopId;

  @override
  void initState() {
    super.initState();
    _shopId = ref.read(authControllerProvider).session?.shopId;
    _reload();
  }

  @override
  void dispose() {
    _searchController.dispose();
    super.dispose();
  }

  Future<void> _reload() async {
    if (!mounted) return;
    setState(() {
      _loading = true;
      _error = null;
    });

    try {
      final suppliers = await _api.getAll();
      if (!mounted) return;
      setState(() {
        _suppliers = suppliers;
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
    final permission = session?.permissionFor(
      ApplicationComponentKeys.suppliers,
    );
    final currentShopId = session?.shopId;

    if (currentShopId != _shopId) {
      _shopId = currentShopId;
      WidgetsBinding.instance.addPostFrameCallback((_) {
        if (mounted) _reload();
      });
    }

    if (permission == null || !permission.canView || !permission.canRead) {
      return Scaffold(
        appBar: AppBar(title: Text(context.l10n.text('Suppliers'))),
        drawer: const AppDrawer(),
        body: Center(
          child: Text(
            context.l10n.text(
              'You do not have permission to access suppliers.',
            ),
          ),
        ),
      );
    }

    final query = _searchController.text.trim().toLowerCase();
    final visibleSuppliers = query.isEmpty
        ? _suppliers
        : _suppliers
              .where(
                (supplier) =>
                    supplier.name.toLowerCase().contains(query) ||
                    (supplier.phoneNumber?.toLowerCase().contains(query) ??
                        false) ||
                    (supplier.notes?.toLowerCase().contains(query) ?? false),
              )
              .toList(growable: false);

    return Scaffold(
      appBar: AppBar(
        title: _isSearching
            ? TextField(
                controller: _searchController,
                autofocus: true,
                decoration: InputDecoration(
                  hintText: context.l10n.text('Search suppliers...'),
                  border: InputBorder.none,
                ),
                onChanged: (_) => setState(() {}),
              )
            : Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(context.l10n.text('Suppliers')),
                  Text(
                    context.l10n.text('Manage suppliers for the active shop.'),
                    style: const TextStyle(
                      fontSize: 12,
                      fontWeight: FontWeight.normal,
                    ),
                  ),
                ],
              ),
        actions: [
          const ActiveShopAction(),
          if (_isSearching)
            IconButton(
              tooltip: context.l10n.text('Close search'),
              onPressed: _stopSearching,
              icon: const Icon(Icons.close),
            )
          else
            IconButton(
              tooltip: context.l10n.text('Search suppliers...'),
              onPressed: () => setState(() => _isSearching = true),
              icon: const Icon(Icons.search),
            ),
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
      ),
      drawer: const AppDrawer(),
      body: SafeArea(
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 900),
            child: Column(
              children: [
                Padding(
                  padding: const EdgeInsets.fromLTRB(16, 16, 16, 0),
                  child: Card(
                    child: ListTile(
                      leading: const Icon(Icons.cloud_outlined),
                      title: Text(
                        context.l10n.text(
                          'Supplier maintenance is online-only. Changes are applied directly to the server.',
                        ),
                      ),
                    ),
                  ),
                ),
                Expanded(
                  child: _loading
                      ? const Center(child: CircularProgressIndicator())
                      : _error != null
                      ? AppErrorView(error: _error!, onRetry: _reload)
                      : RefreshIndicator(
                          onRefresh: _reload,
                          child: visibleSuppliers.isEmpty
                              ? ListView(
                                  physics:
                                      const AlwaysScrollableScrollPhysics(),
                                  children: [
                                    SizedBox(
                                      height: 360,
                                      child: Center(
                                        child: Text(
                                          context.l10n.text(
                                            query.isEmpty
                                                ? 'No suppliers found.'
                                                : 'No matching suppliers.',
                                          ),
                                        ),
                                      ),
                                    ),
                                  ],
                                )
                              : ListView.separated(
                                  physics:
                                      const AlwaysScrollableScrollPhysics(),
                                  padding: const EdgeInsets.fromLTRB(
                                    16,
                                    16,
                                    16,
                                    100,
                                  ),
                                  itemCount: visibleSuppliers.length,
                                  separatorBuilder: (_, _) =>
                                      const SizedBox(height: 8),
                                  itemBuilder: (context, index) {
                                    final supplier = visibleSuppliers[index];
                                    return _SupplierCard(
                                      supplier: supplier,
                                      enabled: !_mutating,
                                      canUpdate: permission.canUpdate,
                                      onEdit: () => _edit(supplier),
                                      onToggleStatus: () =>
                                          _toggleStatus(supplier),
                                    );
                                  },
                                ),
                        ),
                ),
              ],
            ),
          ),
        ),
      ),
      floatingActionButton: permission.canCreate
          ? FloatingActionButton.extended(
              onPressed: _mutating ? null : _create,
              icon: const Icon(Icons.add),
              label: Text(context.l10n.text('Add supplier')),
            )
          : null,
    );
  }

  void _stopSearching() {
    setState(() {
      _isSearching = false;
      _searchController.clear();
    });
  }

  Future<void> _create() async {
    final draft = await showDialog<_SupplierDraft>(
      context: context,
      builder: (context) => const _SupplierFormDialog(),
    );
    if (draft == null || !mounted) return;

    await _mutate(
      () => _api.create(
        name: draft.name,
        phoneNumber: draft.phoneNumber,
        notes: draft.notes,
      ),
      context.l10n.text('Supplier created successfully.'),
    );
  }

  Future<void> _edit(SupplierItem supplier) async {
    final draft = await showDialog<_SupplierDraft>(
      context: context,
      builder: (context) => _SupplierFormDialog(supplier: supplier),
    );
    if (draft == null || !mounted) return;

    await _mutate(
      () => _api.update(
        supplier.id,
        name: draft.name,
        phoneNumber: draft.phoneNumber,
        notes: draft.notes,
      ),
      context.l10n.text('Supplier updated successfully.'),
    );
  }

  Future<void> _toggleStatus(SupplierItem supplier) async {
    final activate = !supplier.isActive;
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (dialogContext) => AlertDialog(
        title: Text(
          dialogContext.l10n.text(
            activate ? 'Activate supplier' : 'Deactivate supplier',
          ),
        ),
        content: Text(
          dialogContext.l10n.text(
            activate
                ? 'Activate {name}? New purchase orders can use this supplier again.'
                : 'Deactivate {name}? Existing purchase history will remain available, but new purchase orders cannot use this supplier.',
            {'name': supplier.name},
          ),
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(dialogContext, false),
            child: Text(dialogContext.l10n.text('Cancel')),
          ),
          FilledButton(
            onPressed: () => Navigator.pop(dialogContext, true),
            child: Text(
              dialogContext.l10n.text(activate ? 'Activate' : 'Deactivate'),
            ),
          ),
        ],
      ),
    );

    if (confirmed != true || !mounted) return;
    await _mutate(
      () => _api.updateStatus(supplier.id, isActive: activate),
      context.l10n.text(
        activate ? '{name} is now active.' : '{name} is now inactive.',
        {'name': supplier.name},
      ),
    );
  }

  Future<void> _mutate(
    Future<void> Function() action,
    String successMessage,
  ) async {
    if (_mutating) return;

    setState(() => _mutating = true);
    try {
      await action();
      await _reload();
      if (!mounted) return;
      ScaffoldMessenger.of(
        context,
      ).showSnackBar(SnackBar(content: Text(successMessage)));
    } catch (error, stackTrace) {
      if (!mounted) return;
      AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }
}

class _SupplierCard extends StatelessWidget {
  const _SupplierCard({
    required this.supplier,
    required this.enabled,
    required this.canUpdate,
    required this.onEdit,
    required this.onToggleStatus,
  });

  final SupplierItem supplier;
  final bool enabled;
  final bool canUpdate;
  final VoidCallback onEdit;
  final VoidCallback onToggleStatus;

  @override
  Widget build(BuildContext context) => Card(
    child: ListTile(
      leading: CircleAvatar(
        child: Text(
          supplier.name.isEmpty
              ? '?'
              : supplier.name.characters.first.toUpperCase(),
        ),
      ),
      title: Row(
        children: [
          Expanded(child: Text(supplier.name)),
          const SizedBox(width: 8),
          Chip(
            visualDensity: VisualDensity.compact,
            avatar: Icon(
              supplier.isActive
                  ? Icons.check_circle_outline
                  : Icons.pause_circle_outline,
              size: 16,
            ),
            label: Text(
              context.l10n.text(supplier.isActive ? 'Active' : 'Inactive'),
            ),
          ),
        ],
      ),
      subtitle: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          if (supplier.phoneNumber case final phone?) Text(phone),
          if (supplier.notes case final notes?)
            Text(notes, maxLines: 2, overflow: TextOverflow.ellipsis),
        ],
      ),
      isThreeLine: supplier.phoneNumber != null && supplier.notes != null,
      trailing: canUpdate
          ? PopupMenuButton<String>(
              enabled: enabled,
              onSelected: (value) {
                switch (value) {
                  case 'edit':
                    onEdit();
                  case 'status':
                    onToggleStatus();
                }
              },
              itemBuilder: (context) => [
                PopupMenuItem(
                  value: 'edit',
                  child: Text(context.l10n.text('Edit')),
                ),
                PopupMenuItem(
                  value: 'status',
                  child: Text(
                    context.l10n.text(
                      supplier.isActive ? 'Deactivate' : 'Activate',
                    ),
                  ),
                ),
              ],
            )
          : null,
    ),
  );
}

class _SupplierFormDialog extends StatefulWidget {
  const _SupplierFormDialog({this.supplier});

  final SupplierItem? supplier;

  @override
  State<_SupplierFormDialog> createState() => _SupplierFormDialogState();
}

class _SupplierFormDialogState extends State<_SupplierFormDialog> {
  final _formKey = GlobalKey<FormState>();
  late final TextEditingController _nameController;
  late final TextEditingController _phoneController;
  late final TextEditingController _notesController;

  @override
  void initState() {
    super.initState();
    _nameController = TextEditingController(text: widget.supplier?.name ?? '');
    _phoneController = TextEditingController(
      text: widget.supplier?.phoneNumber ?? '',
    );
    _notesController = TextEditingController(
      text: widget.supplier?.notes ?? '',
    );
  }

  @override
  void dispose() {
    _nameController.dispose();
    _phoneController.dispose();
    _notesController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: Text(
      context.l10n.text(
        widget.supplier == null ? 'Add supplier' : 'Edit supplier',
      ),
    ),
    content: SizedBox(
      width: 440,
      child: Form(
        key: _formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              controller: _nameController,
              autofocus: true,
              maxLength: 200,
              decoration: InputDecoration(
                labelText: context.l10n.text('Name *'),
              ),
              validator: (value) {
                final text = value?.trim() ?? '';
                if (text.isEmpty) return context.l10n.text('Name is required.');
                if (text.length > 200) {
                  return context.l10n.text(
                    'Name must not exceed 200 characters.',
                  );
                }
                return null;
              },
            ),
            TextFormField(
              controller: _phoneController,
              maxLength: 50,
              keyboardType: TextInputType.phone,
              decoration: InputDecoration(
                labelText: context.l10n.text('Phone number'),
              ),
              validator: (value) {
                if ((value ?? '').trim().length > 50) {
                  return context.l10n.text(
                    'Phone number must not exceed 50 characters.',
                  );
                }
                return null;
              },
            ),
            TextFormField(
              controller: _notesController,
              maxLength: 500,
              minLines: 2,
              maxLines: 4,
              decoration: InputDecoration(
                labelText: context.l10n.text('Notes'),
              ),
              validator: (value) {
                if ((value ?? '').trim().length > 500) {
                  return context.l10n.text(
                    'Notes must not exceed 500 characters.',
                  );
                }
                return null;
              },
            ),
          ],
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
          if (!(_formKey.currentState?.validate() ?? false)) return;
          Navigator.pop(
            context,
            _SupplierDraft(
              name: _nameController.text.trim(),
              phoneNumber: _nullableText(_phoneController.text),
              notes: _nullableText(_notesController.text),
            ),
          );
        },
        child: Text(context.l10n.text('Save changes')),
      ),
    ],
  );

  static String? _nullableText(String value) {
    final text = value.trim();
    return text.isEmpty ? null : text;
  }
}

class _SupplierDraft {
  const _SupplierDraft({required this.name, this.phoneNumber, this.notes});

  final String name;
  final String? phoneNumber;
  final String? notes;
}
