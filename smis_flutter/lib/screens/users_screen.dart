import 'dart:async';

import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../data/data_exception.dart';
import '../data/user_management_api.dart';
import '../data/permission_administration_api.dart';
import '../l10n/app_localizations.dart';
import '../models/managed_user.dart';
import '../validation/user_management_validation.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/user_form_dialog.dart';
import 'user_details_screen.dart';

class UsersScreen extends ConsumerStatefulWidget {
  const UsersScreen({super.key});

  @override
  ConsumerState<UsersScreen> createState() => _UsersScreenState();
}

class _UsersScreenState extends ConsumerState<UsersScreen> {
  static const _pageSize = 25;
  static const _roles = <String>[
    'SuperAdmin',
    'ShopAdmin',
    'Manager',
    'InventoryManager',
    'SalesManager',
    'Cashier',
    'Staff',
    'Viewer',
  ];

  List<String> _configuredRoles = List.of(_roles);
  ManagedUserPage? _page;
  List<UserShopOption> _shops = const [];
  final _searchController = TextEditingController();
  Timer? _searchDebounce;
  bool _isSearching = false;
  String _searchQuery = '';
  int _loadRequestId = 0;
  bool _loading = true;
  bool _mutating = false;
  Object? _error;
  int _pageNumber = 1;

  @override
  void initState() {
    super.initState();
    Future<void>.microtask(_load);
  }

  @override
  void dispose() {
    _searchDebounce?.cancel();
    _searchController.dispose();
    super.dispose();
  }

  UserManagementApi? get _api {
    final session = ref.read(authControllerProvider).session;
    if (session == null || (!session.isSuperAdmin && !session.isShopAdmin)) {
      return null;
    }
    return UserManagementApi(token: session.token);
  }

  void _onSearchChanged(String value) {
    _searchDebounce?.cancel();
    _searchDebounce = Timer(const Duration(milliseconds: 500), () {
      final query = value.trim();
      if (query == _searchQuery) return;
      setState(() {
        _searchQuery = query;
        _pageNumber = 1;
      });
      _load(refreshShops: false);
    });
  }

  void _stopSearching() {
    _searchDebounce?.cancel();
    final hadSearch = _searchQuery.isNotEmpty;
    setState(() {
      _isSearching = false;
      _searchController.clear();
      _searchQuery = '';
      _pageNumber = 1;
    });
    if (hadSearch) _load(refreshShops: false);
  }

  Future<void> _load({bool refreshShops = true}) async {
    final requestId = ++_loadRequestId;
    final api = _api;
    if (api == null) {
      if (mounted) setState(() => _loading = false);
      return;
    }

    setState(() {
      _loading = true;
      _error = null;
    });

    try {
      final session = ref.read(authControllerProvider).session!;
      final page = await api.getUsers(
        pageNumber: _pageNumber,
        pageSize: _pageSize,
        search: _searchQuery,
      );
      final shops = session.isSuperAdmin
          ? (refreshShops || _shops.isEmpty)
                ? await api.getActiveShops()
                : _shops
          : <UserShopOption>[
              UserShopOption(
                id: session.shopId,
                name: _resolveCurrentShopName(page, session.shopId),
              ),
            ];
      final configuredRoles = session.isSuperAdmin
          ? (await PermissionAdministrationApi(
              token: session.token,
            ).getRoles()).map((r) => r.name).toList()
          : List<String>.of(_roles);
      if (!mounted || requestId != _loadRequestId) return;
      setState(() {
        _configuredRoles = configuredRoles;
        _page = page;
        _shops = shops;
        _loading = false;
      });
    } catch (error) {
      if (!mounted || requestId != _loadRequestId) return;
      setState(() {
        _error = error;
        _loading = false;
      });
    }
  }

  void _openDetails(ManagedUser user) {
    Navigator.of(context).push(
      MaterialPageRoute<void>(
        builder: (context) => UserDetailsScreen(user: user),
      ),
    );
  }

  Future<void> _openForm([ManagedUser? user]) async {
    if (_mutating || _shops.isEmpty) return;
    final session = ref.read(authControllerProvider).session;
    if (session == null) return;

    final assignableRoles = session.isSuperAdmin
        ? _configuredRoles
        : _roles
              .where((role) => role.toLowerCase() != 'superadmin')
              .toList(growable: false);

    final draft = await showDialog<UserFormDraft>(
      context: context,
      barrierDismissible: false,
      builder: (context) =>
          UserFormDialog(user: user, shops: _shops, roles: assignableRoles),
    );
    if (draft == null || !mounted) return;

    // The form validates interactively, and this second check protects the API
    // boundary if the dialog or another caller changes later.
    final validationMessage = UserManagementValidation.userPayload(
      userName: draft.userName,
      email: draft.email,
      password: draft.password,
      requirePassword: user == null,
      firstName: draft.firstName,
      lastName: draft.lastName,
      phoneNumber: draft.phoneNumber,
      shopId: draft.shopId,
      roles: draft.roles,
    );
    if (validationMessage != null) {
      _showMessage(context.l10n.text(validationMessage));
      return;
    }

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      if (user == null) {
        await api.createUser(
          userName: draft.userName,
          email: draft.email,
          password: draft.password!,
          languageId: session.languageId,
          roles: draft.roles,
          firstName: draft.firstName,
          lastName: draft.lastName,
          phoneNumber: draft.phoneNumber,
        );
        if (mounted) {
          _showMessage(context.l10n.text('User created successfully.'));
        }
      } else {
        await api.updateUser(
          user: user,
          userName: draft.userName,
          email: draft.email,
          shopId: draft.shopId,
          roles: draft.roles,
          firstName: draft.firstName,
          lastName: draft.lastName,
          phoneNumber: draft.phoneNumber,
        );
        if (mounted) {
          _showMessage(context.l10n.text('User updated successfully.'));
        }
      }
      await _load();
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  Future<void> _manageRoles(ManagedUser user) async {
    if (_mutating) return;
    final session = ref.read(authControllerProvider).session;
    if (session == null) return;

    final assignableRoles = session.isSuperAdmin
        ? _configuredRoles
        : _roles
              .where((role) => role.toLowerCase() != 'superadmin')
              .toList(growable: false);

    final selectedRoles = await showDialog<List<String>>(
      context: context,
      barrierDismissible: false,
      builder: (context) => _RoleManagementDialog(
        userName: user.displayName,
        roles: assignableRoles,
        selectedRoles: user.roles,
      ),
    );
    if (selectedRoles == null || !mounted) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      await api.assignRoles(userId: user.id, roles: selectedRoles);
      await _load();
      if (mounted) {
        _showMessage(
          context.l10n.text('Roles updated for {name}.', {
            'name': user.displayName,
          }),
        );
      }
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  Future<void> _resetPassword(ManagedUser user) async {
    if (_mutating) return;
    final l10n = context.l10n;
    final confirmed = await _confirm(
      title: l10n.text('Reset password?'),
      message: l10n.text(
        'Reset {name}\'s password? The server will immediately set the password to the user\'s current username. This operation is online-only and is not stored locally.',
        {'name': user.displayName},
      ),
      confirmLabel: l10n.text('Reset password'),
    );
    if (!confirmed) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      await api.resetPassword(user.id);
      if (mounted) {
        _showMessage(
          context.l10n.text(
            'Password reset for {name}. The new password is the current username.',
            {'name': user.displayName},
          ),
        );
      }
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  Future<void> _setLocked(ManagedUser user, bool locked) async {
    final session = ref.read(authControllerProvider).session;
    if (_mutating || session == null) return;
    if (locked && user.id == session.userId) return;

    final l10n = context.l10n;
    final actionKey = locked ? 'Lock' : 'Unlock';
    final confirmed = await _confirm(
      title: l10n.text(locked ? 'Lock user?' : 'Unlock user?'),
      message: l10n.text(
        locked
            ? 'Lock {name}? This change is applied immediately on the server.'
            : 'Unlock {name}? This change is applied immediately on the server.',
        {'name': user.displayName},
      ),
      confirmLabel: l10n.text(actionKey),
    );
    if (!confirmed) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      if (locked) {
        await api.lockUser(user.id);
      } else {
        await api.unlockUser(user.id);
      }
      await _load();
      if (mounted) {
        _showMessage(
          context.l10n.text(
            locked ? '{name} is now locked.' : '{name} is now unlocked.',
            {'name': user.displayName},
          ),
        );
      }
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  Future<void> _setActiveStatus(ManagedUser user, bool isActive) async {
    final session = ref.read(authControllerProvider).session;
    if (_mutating || session == null || user.id == session.userId) return;

    final l10n = context.l10n;
    final confirmed = await _confirm(
      title: l10n.text(isActive ? 'Activate user?' : 'Deactivate user?'),
      message: l10n.text(
        isActive
            ? 'Activate {name}? The user will be able to sign in again.'
            : 'Deactivate {name}? Existing authenticated requests will be rejected immediately.',
        {'name': user.displayName},
      ),
      confirmLabel: l10n.text(isActive ? 'Activate' : 'Deactivate'),
    );
    if (!confirmed) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      await api.setActiveStatus(userId: user.id, isActive: isActive);
      await _load();
      if (mounted) {
        _showMessage(
          context.l10n.text(
            isActive ? '{name} is now active.' : '{name} is now inactive.',
            {'name': user.displayName},
          ),
        );
      }
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  Future<void> _setAllShopAdminsActiveStatus(bool isActive) async {
    if (_mutating) return;
    final l10n = context.l10n;
    final confirmed = await _confirm(
      title: l10n.text(
        isActive ? 'Activate all ShopAdmins?' : 'Deactivate all ShopAdmins?',
      ),
      message: l10n.text(
        isActive
            ? 'Activate every ShopAdmin account? Accounts that are also SuperAdmin are excluded.'
            : 'Deactivate every ShopAdmin account? Accounts that are also SuperAdmin are excluded.',
      ),
      confirmLabel: l10n.text(isActive ? 'Activate all' : 'Deactivate all'),
    );
    if (!confirmed) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      await api.setAllShopAdminsActiveStatus(isActive);
      await _load();
      if (mounted) {
        _showMessage(
          context.l10n.text(
            isActive
                ? 'All ShopAdmin accounts are active.'
                : 'All ShopAdmin accounts are inactive.',
          ),
        );
      }
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  Future<void> _delete(ManagedUser user) async {
    final session = ref.read(authControllerProvider).session;
    if (_mutating || session == null || user.id == session.userId) return;

    final l10n = context.l10n;
    final confirmed = await _confirm(
      title: l10n.text('Delete user?'),
      message: l10n.text(
        'Delete {name}? This action is performed directly on the server.',
        {'name': user.displayName},
      ),
      confirmLabel: l10n.text('Delete'),
    );
    if (!confirmed) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      await api.deleteUser(user.id);
      if ((_page?.items.length ?? 0) == 1 && _pageNumber > 1) {
        _pageNumber--;
      }
      await _load();
      if (mounted) {
        _showMessage(
          context.l10n.text('{name} was deleted.', {'name': user.displayName}),
        );
      }
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  Future<bool> _confirm({
    required String title,
    required String message,
    required String confirmLabel,
  }) async {
    final result = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text(title),
        content: Text(message),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: Text(context.l10n.text('Cancel')),
          ),
          FilledButton(
            onPressed: () => Navigator.pop(context, true),
            child: Text(confirmLabel),
          ),
        ],
      ),
    );
    return result == true;
  }

  void _showMessage(String message) {
    ScaffoldMessenger.of(context)
      ..hideCurrentSnackBar()
      ..showSnackBar(SnackBar(content: Text(message)));
  }

  String _lockStatus(ManagedUser user) {
    final l10n = context.l10n;
    if (!user.isActive) return l10n.text('Account status: inactive');
    if (!user.isLocked) return l10n.text('Account status: unlocked');
    final end = user.lockoutEnd;
    if (end == null) return l10n.text('Account status: locked');
    return l10n.text('Account status: locked until {date}', {
      'date': _formatDateTime(end),
    });
  }

  String _formatDateTime(DateTime value) {
    final local = value.toLocal();
    String two(int number) => number.toString().padLeft(2, '0');
    return '${local.year}-${two(local.month)}-${two(local.day)} '
        '${two(local.hour)}:${two(local.minute)}';
  }

  String _resolveCurrentShopName(ManagedUserPage page, String shopId) {
    for (final user in page.items) {
      if (user.shopId != shopId) continue;
      final name = user.shopName?.trim();
      if (name != null && name.isNotEmpty) return name;
    }
    return context.l10n.text('Current shop');
  }

  @override
  Widget build(BuildContext context) {
    final session = ref.watch(authControllerProvider).session;
    final l10n = context.l10n;
    if (session == null || (!session.isSuperAdmin && !session.isShopAdmin)) {
      return Scaffold(
        drawer: const AppDrawer(),
        body: Center(
          child: Text(
            l10n.text(
              'User administration requires SuperAdmin or ShopAdmin access.',
            ),
            textAlign: TextAlign.center,
          ),
        ),
      );
    }

    return Scaffold(
      appBar: AppBar(
        title: _isSearching
            ? TextField(
                controller: _searchController,
                autofocus: true,
                decoration: InputDecoration(
                  hintText: l10n.text('Search users...'),
                  border: InputBorder.none,
                ),
                onChanged: _onSearchChanged,
              )
            : Text(l10n.text('User management')),
        actions: [
          if (_isSearching)
            IconButton(
              tooltip: l10n.text('Close search'),
              icon: const Icon(Icons.close),
              onPressed: _stopSearching,
            )
          else
            IconButton(
              tooltip: l10n.text('Search users'),
              icon: const Icon(Icons.search),
              onPressed: () => setState(() => _isSearching = true),
            ),
          if (session.isSuperAdmin)
            PopupMenuButton<String>(
              tooltip: l10n.text('ShopAdmin activation'),
              onSelected: (value) {
                if (value == 'activate-shop-admins') {
                  _setAllShopAdminsActiveStatus(true);
                } else if (value == 'deactivate-shop-admins') {
                  _setAllShopAdminsActiveStatus(false);
                }
              },
              itemBuilder: (context) => [
                PopupMenuItem(
                  value: 'activate-shop-admins',
                  child: Text(l10n.text('Activate all ShopAdmins')),
                ),
                PopupMenuItem(
                  value: 'deactivate-shop-admins',
                  child: Text(l10n.text('Deactivate all ShopAdmins')),
                ),
              ],
            ),
          IconButton(
            tooltip: l10n.text('Refresh'),
            onPressed: _loading || _mutating ? null : _load,
            icon: const Icon(Icons.refresh),
          ),
        ],
      ),
      drawer: const AppDrawer(),
      floatingActionButton: _shops.isEmpty
          ? null
          : FloatingActionButton.extended(
              onPressed: _loading || _mutating ? null : () => _openForm(),
              icon: const Icon(Icons.person_add_alt_1),
              label: Text(l10n.text('Add user')),
            ),
      body: Column(
        children: [
          MaterialBanner(
            leading: const Icon(Icons.cloud_outlined),
            content: Text(
              l10n.text(
                'User administration is online-only. User CRUD, roles, activation, password resets, and lock/unlock changes call the server directly and are never queued in PowerSync or local offline storage.',
              ),
            ),
            actions: [
              TextButton(onPressed: _load, child: Text(l10n.text('Refresh'))),
            ],
          ),
          Expanded(child: _buildBody(session.userId)),
        ],
      ),
    );
  }

  Widget _buildBody(String currentUserId) {
    final l10n = context.l10n;
    if (_loading && _page == null) {
      return const Center(child: CircularProgressIndicator());
    }
    if (_error != null && _page == null) {
      return AppErrorView(error: _error!, onRetry: _load);
    }

    final page = _page;
    if (page == null || page.items.isEmpty) {
      return Center(
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            Icon(
              _searchQuery.isEmpty ? Icons.people_outline : Icons.search_off,
              size: 52,
            ),
            const SizedBox(height: 12),
            Text(
              l10n.text(
                _searchQuery.isEmpty ? 'No users found.' : 'No matching users.',
              ),
            ),
            if (_searchQuery.isNotEmpty) ...[
              const SizedBox(height: 4),
              Text(l10n.text('Try a different search term.')),
            ],
          ],
        ),
      );
    }

    return Column(
      children: [
        if (_mutating || _loading) const LinearProgressIndicator(),
        Expanded(
          child: RefreshIndicator(
            onRefresh: _load,
            child: ListView.separated(
              physics: const AlwaysScrollableScrollPhysics(),
              padding: const EdgeInsets.fromLTRB(12, 8, 12, 96),
              itemCount: page.items.length,
              separatorBuilder: (_, _) => const SizedBox(height: 8),
              itemBuilder: (context, index) {
                final user = page.items[index];
                return Card(
                  clipBehavior: Clip.antiAlias,
                  child: ListTile(
                    contentPadding: const EdgeInsets.fromLTRB(16, 10, 8, 10),
                    onTap: () => _openDetails(user),
                    leading: CircleAvatar(
                      child: Text(
                        user.userName.isEmpty
                            ? '?'
                            : user.userName.characters.first.toUpperCase(),
                      ),
                    ),
                    title: Row(
                      children: [
                        Expanded(child: Text(user.displayName)),
                        if (!user.isActive)
                          const Padding(
                            padding: EdgeInsets.only(left: 8),
                            child: Icon(Icons.block_outlined, size: 18),
                          ),
                        if (user.isLocked)
                          const Padding(
                            padding: EdgeInsets.only(left: 8),
                            child: Icon(Icons.lock_outline, size: 18),
                          ),
                      ],
                    ),
                    subtitle: Padding(
                      padding: const EdgeInsets.only(top: 4),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text('${user.userName} · ${user.email}'),
                          const SizedBox(height: 2),
                          Text(user.shopName ?? user.shopId),
                          const SizedBox(height: 2),
                          Text(
                            user.roles.isEmpty
                                ? l10n.text('Roles: none')
                                : l10n.text('Roles: {roles}', {
                                    'roles': user.roles.join(', '),
                                  }),
                          ),
                          const SizedBox(height: 2),
                          Text(_lockStatus(user)),
                        ],
                      ),
                    ),
                    trailing: PopupMenuButton<String>(
                      enabled: !_mutating,
                      onSelected: (value) {
                        switch (value) {
                          case 'details':
                            _openDetails(user);
                            break;
                          case 'edit':
                            _openForm(user);
                            break;
                          case 'roles':
                            _manageRoles(user);
                            break;
                          case 'reset-password':
                            _resetPassword(user);
                            break;
                          case 'lock':
                            _setLocked(user, true);
                            break;
                          case 'unlock':
                            _setLocked(user, false);
                            break;
                          case 'activate':
                            _setActiveStatus(user, true);
                            break;
                          case 'deactivate':
                            _setActiveStatus(user, false);
                            break;
                          case 'delete':
                            _delete(user);
                            break;
                        }
                      },
                      itemBuilder: (context) => [
                        PopupMenuItem(
                          value: 'details',
                          child: ListTile(
                            contentPadding: EdgeInsets.zero,
                            leading: const Icon(Icons.visibility_outlined),
                            title: Text(l10n.text('View details')),
                          ),
                        ),
                        PopupMenuItem(
                          value: 'edit',
                          child: ListTile(
                            contentPadding: EdgeInsets.zero,
                            leading: const Icon(Icons.edit_outlined),
                            title: Text(l10n.text('Edit')),
                          ),
                        ),
                        PopupMenuItem(
                          value: 'roles',
                          child: ListTile(
                            contentPadding: EdgeInsets.zero,
                            leading: const Icon(
                              Icons.admin_panel_settings_outlined,
                            ),
                            title: Text(l10n.text('Manage roles')),
                          ),
                        ),
                        PopupMenuItem(
                          value: 'reset-password',
                          child: ListTile(
                            contentPadding: EdgeInsets.zero,
                            leading: const Icon(Icons.password_outlined),
                            title: Text(l10n.text('Reset password')),
                          ),
                        ),
                        if (user.isLocked)
                          PopupMenuItem(
                            value: 'unlock',
                            child: Text(l10n.text('Unlock account')),
                          )
                        else if (user.id != currentUserId)
                          PopupMenuItem(
                            value: 'lock',
                            child: Text(l10n.text('Lock account')),
                          ),
                        if (user.id != currentUserId && user.isActive)
                          PopupMenuItem(
                            value: 'deactivate',
                            child: Text(l10n.text('Deactivate account')),
                          )
                        else if (user.id != currentUserId && !user.isActive)
                          PopupMenuItem(
                            value: 'activate',
                            child: Text(l10n.text('Activate account')),
                          ),
                        if (user.id != currentUserId)
                          PopupMenuItem(
                            value: 'delete',
                            child: Text(l10n.text('Delete')),
                          ),
                      ],
                    ),
                  ),
                );
              },
            ),
          ),
        ),
        SafeArea(
          top: false,
          child: Padding(
            padding: const EdgeInsets.fromLTRB(12, 6, 12, 10),
            child: Row(
              children: [
                IconButton(
                  tooltip: l10n.text('Previous page'),
                  onPressed: _pageNumber > 1 && !_loading && !_mutating
                      ? () {
                          _pageNumber--;
                          _load();
                        }
                      : null,
                  icon: const Icon(Icons.chevron_left),
                ),
                Expanded(
                  child: Text(
                    l10n.text('Page {page} of {totalPages} · {count} users', {
                      'page': page.pageNumber,
                      'totalPages': page.totalPages == 0 ? 1 : page.totalPages,
                      'count': page.totalCount,
                    }),
                    textAlign: TextAlign.center,
                  ),
                ),
                IconButton(
                  tooltip: l10n.text('Next page'),
                  onPressed:
                      _pageNumber < page.totalPages && !_loading && !_mutating
                      ? () {
                          _pageNumber++;
                          _load();
                        }
                      : null,
                  icon: const Icon(Icons.chevron_right),
                ),
              ],
            ),
          ),
        ),
      ],
    );
  }
}

class _RoleManagementDialog extends StatefulWidget {
  const _RoleManagementDialog({
    required this.userName,
    required this.roles,
    required this.selectedRoles,
  });

  final String userName;
  final List<String> roles;
  final List<String> selectedRoles;

  @override
  State<_RoleManagementDialog> createState() => _RoleManagementDialogState();
}

class _RoleManagementDialogState extends State<_RoleManagementDialog> {
  late final Set<String> _selectedRoles;

  @override
  void initState() {
    super.initState();
    _selectedRoles = widget.selectedRoles.toSet();
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: Text(
      context.l10n.text('Manage roles · {name}', {'name': widget.userName}),
    ),
    content: SizedBox(
      width: 420,
      child: SingleChildScrollView(
        child: Column(
          mainAxisSize: MainAxisSize.min,
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
              context.l10n.text(
                'The submitted list replaces the user\'s complete role list on the server.',
              ),
            ),
            const SizedBox(height: 8),
            ...widget.roles.map(
              (role) => CheckboxListTile(
                dense: true,
                contentPadding: EdgeInsets.zero,
                title: Text(role),
                value: _selectedRoles.contains(role),
                onChanged: (selected) {
                  setState(() {
                    if (selected == true) {
                      _selectedRoles.add(role);
                    } else {
                      _selectedRoles.remove(role);
                    }
                  });
                },
              ),
            ),
            if (_selectedRoles.isEmpty)
              Text(
                context.l10n.text('Select at least one role.'),
                style: TextStyle(color: Theme.of(context).colorScheme.error),
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
        onPressed: _selectedRoles.isEmpty
            ? null
            : () => Navigator.pop(
                context,
                _selectedRoles.toList(growable: false),
              ),
        child: Text(context.l10n.text('Save roles')),
      ),
    ],
  );
}
