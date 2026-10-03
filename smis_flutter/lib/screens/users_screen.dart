import 'dart:async';

import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../data/data_exception.dart';
import '../data/user_management_api.dart';
import '../models/managed_user.dart';
import 'user_details_screen.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';

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

  UserManagementApi? get _api {
    final session = ref.read(authControllerProvider).session;
    if (session == null || (!session.isSuperAdmin && !session.isShopAdmin)) {
      return null;
    }
    return UserManagementApi(token: session.token);
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
      final shops = session.isSuperAdmin && (refreshShops || _shops.isEmpty)
          ? await api.getActiveShops()
          : _shops;
      if (!mounted || requestId != _loadRequestId) return;
      setState(() {
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

  Future<void> _openForm([ManagedUser? user]) async {
    if (_mutating || _shops.isEmpty) return;
    final session = ref.read(authControllerProvider).session;
    if (session == null) return;
    final draft = await showDialog<_UserDraft>(
      context: context,
      barrierDismissible: false,
      builder: (context) =>
          _UserFormDialog(user: user, shops: _shops, roles: _roles),
    );
    if (draft == null) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      if (user == null) {
        await api.createUser(
          userName: draft.userName,
          email: draft.email,
          password: draft.password!,
          shopId: draft.shopId,
          languageId: session.languageId,
          roles: draft.roles,
          firstName: draft.firstName,
          lastName: draft.lastName,
          phoneNumber: draft.phoneNumber,
        );
        if (mounted) _showSuccess('User created successfully.');
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
        if (mounted) _showSuccess('User updated successfully.');
      }
      await _load();
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  Future<void> _openDetails(ManagedUser user) async {
    await Navigator.of(context).push(
      MaterialPageRoute<void>(
        builder: (context) => UserDetailsScreen(user: user),
      ),
    );
  }

  Future<void> _manageRoles(ManagedUser user) async {
    if (_mutating) return;
    final selectedRoles = await showDialog<List<String>>(
      context: context,
      barrierDismissible: false,
      builder: (context) => _RoleManagementDialog(
        userName: user.displayName,
        roles: _roles,
        selectedRoles: user.roles,
      ),
    );
    if (selectedRoles == null) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      await api.assignRoles(userId: user.id, roles: selectedRoles);
      await _load();
      if (mounted) _showSuccess('Roles updated for ${user.displayName}.');
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  Future<void> _resetPassword(ManagedUser user) async {
    if (_mutating) return;
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Reset password?'),
        content: Text(
          'Reset ${user.displayName}\'s password? The server will immediately set the password to the user\'s current username. This operation is online-only and is not stored locally.',
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: const Text('Cancel'),
          ),
          FilledButton(
            onPressed: () => Navigator.pop(context, true),
            child: const Text('Reset password'),
          ),
        ],
      ),
    );
    if (confirmed != true) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      await api.resetPassword(user.id);
      if (mounted) {
        _showSuccess(
          'Password reset for ${user.displayName}. The new password is the current username.',
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

    final action = locked ? 'Lock' : 'Unlock';
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text('$action user?'),
        content: Text(
          '$action ${user.displayName}? This change is applied immediately on the server.',
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: const Text('Cancel'),
          ),
          FilledButton(
            onPressed: () => Navigator.pop(context, true),
            child: Text(action),
          ),
        ],
      ),
    );
    if (confirmed != true) return;

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
        _showSuccess(
          locked
              ? '${user.displayName} is now locked.'
              : '${user.displayName} is now unlocked.',
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

    final action = isActive ? 'Activate' : 'Deactivate';
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text('$action user?'),
        content: Text(
          '$action ${user.displayName}? ${isActive ? 'The user will be able to sign in again.' : 'Existing authenticated requests will be rejected immediately.'}',
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: const Text('Cancel'),
          ),
          FilledButton(
            onPressed: () => Navigator.pop(context, true),
            child: Text(action),
          ),
        ],
      ),
    );
    if (confirmed != true) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      await api.setActiveStatus(userId: user.id, isActive: isActive);
      await _load();
      if (mounted) {
        _showSuccess(
          isActive
              ? '${user.displayName} is now active.'
              : '${user.displayName} is now inactive.',
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
    final action = isActive ? 'Activate' : 'Deactivate';
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text('$action all ShopAdmins?'),
        content: Text(
          '$action every ShopAdmin account? Accounts that are also SuperAdmin are excluded.',
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: const Text('Cancel'),
          ),
          FilledButton(
            onPressed: () => Navigator.pop(context, true),
            child: Text('$action all'),
          ),
        ],
      ),
    );
    if (confirmed != true) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      await api.setAllShopAdminsActiveStatus(isActive);
      await _load();
      if (mounted) {
        _showSuccess(
          isActive
              ? 'All ShopAdmin accounts are active.'
              : 'All ShopAdmin accounts are inactive.',
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
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Delete user?'),
        content: Text(
          'Delete ${user.displayName}? This action is performed directly on the server.',
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: const Text('Cancel'),
          ),
          FilledButton(
            onPressed: () => Navigator.pop(context, true),
            child: const Text('Delete'),
          ),
        ],
      ),
    );
    if (confirmed != true) return;

    final api = _api;
    if (api == null) return;
    setState(() => _mutating = true);
    try {
      await api.deleteUser(user.id);
      if ((_page?.items.length ?? 0) == 1 && _pageNumber > 1) {
        _pageNumber--;
      }
      await _load();
      if (mounted) _showSuccess('${user.displayName} was deleted.');
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  void _showSuccess(String message) {
    ScaffoldMessenger.of(context)
      ..hideCurrentSnackBar()
      ..showSnackBar(SnackBar(content: Text(message)));
  }

  String _lockStatus(ManagedUser user) {
    if (!user.isActive) return 'Account status: inactive';
    if (!user.isLocked) return 'Account status: unlocked';
    final end = user.lockoutEnd;
    if (end == null) return 'Account status: locked';
    return 'Account status: locked until ${_formatDateTime(end)}';
  }

  String _formatDateTime(DateTime value) {
    final local = value.toLocal();
    String two(int number) => number.toString().padLeft(2, '0');
    return '${local.year}-${two(local.month)}-${two(local.day)} '
        '${two(local.hour)}:${two(local.minute)}';
  }

  @override
  Widget build(BuildContext context) {
    final session = ref.watch(authControllerProvider).session;
    if (session == null || (!session.isSuperAdmin && !session.isShopAdmin)) {
      return const Scaffold(
        drawer: AppDrawer(),
        body: Center(
          child: Text(
            'User administration requires SuperAdmin or ShopAdmin access.',
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
                decoration: const InputDecoration(
                  hintText: 'Search users...',
                  border: InputBorder.none,
                ),
                onChanged: _onSearchChanged,
              )
            : const Text('User management'),
        actions: [
          if (_isSearching)
            IconButton(
              tooltip: 'Close search',
              icon: const Icon(Icons.close),
              onPressed: _stopSearching,
            )
          else
            IconButton(
              tooltip: 'Search users',
              icon: const Icon(Icons.search),
              onPressed: () => setState(() => _isSearching = true),
            ),
          if (session.isSuperAdmin)
            PopupMenuButton<String>(
              tooltip: 'ShopAdmin activation',
              onSelected: (value) {
                if (value == 'activate-shop-admins') {
                  _setAllShopAdminsActiveStatus(true);
                } else if (value == 'deactivate-shop-admins') {
                  _setAllShopAdminsActiveStatus(false);
                }
              },
              itemBuilder: (context) => const [
                PopupMenuItem(
                  value: 'activate-shop-admins',
                  child: Text('Activate all ShopAdmins'),
                ),
                PopupMenuItem(
                  value: 'deactivate-shop-admins',
                  child: Text('Deactivate all ShopAdmins'),
                ),
              ],
            ),
          IconButton(
            tooltip: 'Refresh',
            onPressed: _loading || _mutating ? null : _load,
            icon: const Icon(Icons.refresh),
          ),
        ],
      ),
      drawer: const AppDrawer(),
      floatingActionButton: !session.isSuperAdmin || _shops.isEmpty
          ? null
          : FloatingActionButton.extended(
              onPressed: _loading || _mutating ? null : () => _openForm(),
              icon: const Icon(Icons.person_add_alt_1),
              label: const Text('Add user'),
            ),
      body: Column(
        children: [
          MaterialBanner(
            leading: const Icon(Icons.cloud_outlined),
            content: const Text(
              'User administration is online-only. User CRUD, roles, activation, password resets, and lock/unlock changes call the server directly and are never queued in PowerSync or local offline storage.',
            ),
            actions: [
              TextButton(onPressed: _load, child: const Text('Refresh')),
            ],
          ),
          Expanded(
            child: _buildBody(
              session.userId,
              isSuperAdmin: session.isSuperAdmin,
            ),
          ),
        ],
      ),
    );
  }

  Widget _buildBody(String currentUserId, {required bool isSuperAdmin}) {
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
              _searchQuery.isEmpty ? 'No users found.' : 'No matching users.',
            ),
            if (_searchQuery.isNotEmpty) ...[
              const SizedBox(height: 4),
              const Text('Try a different search term.'),
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
                  child: ListTile(
                    onTap: _mutating ? null : () => _openDetails(user),
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
                    subtitle: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text('${user.userName} · ${user.email}'),
                        Text(user.shopName ?? user.shopId),
                        Text(
                          user.roles.isEmpty
                              ? 'Roles: none'
                              : 'Roles: ${user.roles.join(', ')}',
                        ),
                        Text(_lockStatus(user)),
                      ],
                    ),
                    isThreeLine: true,
                    trailing: PopupMenuButton<String>(
                      enabled: !_mutating,
                      onSelected: (value) {
                        if (value == 'details') {
                          _openDetails(user);
                        } else if (value == 'edit') {
                          _openForm(user);
                        } else if (value == 'roles') {
                          _manageRoles(user);
                        } else if (value == 'reset-password') {
                          _resetPassword(user);
                        } else if (value == 'lock') {
                          _setLocked(user, true);
                        } else if (value == 'unlock') {
                          _setLocked(user, false);
                        } else if (value == 'activate') {
                          _setActiveStatus(user, true);
                        } else if (value == 'deactivate') {
                          _setActiveStatus(user, false);
                        } else if (value == 'delete') {
                          _delete(user);
                        }
                      },
                      itemBuilder: (context) => [
                        const PopupMenuItem(
                          value: 'details',
                          child: Text('View details'),
                        ),
                        if (isSuperAdmin)
                          const PopupMenuItem(
                            value: 'edit',
                            child: Text('Edit'),
                          ),
                        if (isSuperAdmin)
                          const PopupMenuItem(
                            value: 'roles',
                            child: Text('Manage roles'),
                          ),
                        const PopupMenuItem(
                          value: 'reset-password',
                          child: Text('Reset password'),
                        ),
                        if (user.isLocked)
                          const PopupMenuItem(
                            value: 'unlock',
                            child: Text('Unlock account'),
                          )
                        else if (user.id != currentUserId)
                          const PopupMenuItem(
                            value: 'lock',
                            child: Text('Lock account'),
                          ),
                        if (user.id != currentUserId && user.isActive)
                          const PopupMenuItem(
                            value: 'deactivate',
                            child: Text('Deactivate account'),
                          )
                        else if (user.id != currentUserId && !user.isActive)
                          const PopupMenuItem(
                            value: 'activate',
                            child: Text('Activate account'),
                          ),
                        if (isSuperAdmin && user.id != currentUserId)
                          const PopupMenuItem(
                            value: 'delete',
                            child: Text('Delete'),
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
                  tooltip: 'Previous page',
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
                    'Page ${page.pageNumber} of ${page.totalPages == 0 ? 1 : page.totalPages} · ${page.totalCount} users',
                    textAlign: TextAlign.center,
                  ),
                ),
                IconButton(
                  tooltip: 'Next page',
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
    title: Text('Manage roles · ${widget.userName}'),
    content: SizedBox(
      width: 420,
      child: SingleChildScrollView(
        child: Column(
          mainAxisSize: MainAxisSize.min,
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            const Text(
              'The submitted list replaces the user\'s complete role list on the server.',
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
                'Select at least one role.',
                style: TextStyle(color: Theme.of(context).colorScheme.error),
              ),
          ],
        ),
      ),
    ),
    actions: [
      TextButton(
        onPressed: () => Navigator.pop(context),
        child: const Text('Cancel'),
      ),
      FilledButton(
        onPressed: _selectedRoles.isEmpty
            ? null
            : () => Navigator.pop(
                context,
                _selectedRoles.toList(growable: false),
              ),
        child: const Text('Save roles'),
      ),
    ],
  );
}

class _UserFormDialog extends StatefulWidget {
  const _UserFormDialog({
    required this.user,
    required this.shops,
    required this.roles,
  });

  final ManagedUser? user;
  final List<UserShopOption> shops;
  final List<String> roles;

  @override
  State<_UserFormDialog> createState() => _UserFormDialogState();
}

class _UserFormDialogState extends State<_UserFormDialog> {
  final _formKey = GlobalKey<FormState>();
  late final TextEditingController _userName;
  late final TextEditingController _email;
  late final TextEditingController _phone;
  late final TextEditingController _firstName;
  late final TextEditingController _lastName;
  late final TextEditingController _password;
  late String _shopId;
  late Set<String> _roles;
  bool _showRoleError = false;

  bool get _isEditing => widget.user != null;

  @override
  void initState() {
    super.initState();
    final user = widget.user;
    _userName = TextEditingController(text: user?.userName ?? '');
    _email = TextEditingController(text: user?.email ?? '');
    _phone = TextEditingController(text: user?.phoneNumber ?? '');
    _firstName = TextEditingController(text: user?.firstName ?? '');
    _lastName = TextEditingController(text: user?.lastName ?? '');
    _password = TextEditingController();
    _shopId = widget.shops.any((shop) => shop.id == user?.shopId)
        ? user!.shopId
        : widget.shops.first.id;
    _roles = {...?user?.roles};
  }

  @override
  void dispose() {
    _userName.dispose();
    _email.dispose();
    _phone.dispose();
    _firstName.dispose();
    _lastName.dispose();
    _password.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final theme = Theme.of(context);
    final maxHeight = MediaQuery.sizeOf(context).height * 0.88;

    return Dialog(
      clipBehavior: Clip.antiAlias,
      child: ConstrainedBox(
        constraints: BoxConstraints(maxWidth: 760, maxHeight: maxHeight),
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            Padding(
              padding: const EdgeInsets.fromLTRB(24, 20, 16, 16),
              child: Row(
                children: [
                  Icon(
                    _isEditing
                        ? Icons.manage_accounts_outlined
                        : Icons.person_add_alt_1,
                  ),
                  const SizedBox(width: 12),
                  Expanded(
                    child: Text(
                      _isEditing ? 'Edit user' : 'Create user',
                      style: theme.textTheme.headlineSmall,
                    ),
                  ),
                  IconButton(
                    tooltip: 'Close',
                    onPressed: () => Navigator.pop(context),
                    icon: const Icon(Icons.close),
                  ),
                ],
              ),
            ),
            const Divider(height: 1),
            Flexible(
              child: SingleChildScrollView(
                padding: const EdgeInsets.all(24),
                child: Form(
                  key: _formKey,
                  child: LayoutBuilder(
                    builder: (context, constraints) {
                      final useTwoColumns = constraints.maxWidth >= 620;
                      return Column(
                        crossAxisAlignment: CrossAxisAlignment.stretch,
                        children: [
                          Text(
                            'Account information',
                            style: theme.textTheme.titleMedium,
                          ),
                          const SizedBox(height: 12),
                          _fieldPair(
                            useTwoColumns: useTwoColumns,
                            first: TextFormField(
                              controller: _userName,
                              decoration: const InputDecoration(
                                labelText: 'Username',
                                border: OutlineInputBorder(),
                              ),
                              validator: _required,
                            ),
                            second: TextFormField(
                              controller: _email,
                              decoration: const InputDecoration(
                                labelText: 'Email',
                                border: OutlineInputBorder(),
                              ),
                              keyboardType: TextInputType.emailAddress,
                              validator: _required,
                            ),
                          ),
                          if (!_isEditing) ...[
                            const SizedBox(height: 12),
                            TextFormField(
                              controller: _password,
                              decoration: const InputDecoration(
                                labelText: 'Password',
                                border: OutlineInputBorder(),
                              ),
                              obscureText: true,
                              validator: _required,
                            ),
                          ],
                          const SizedBox(height: 12),
                          _fieldPair(
                            useTwoColumns: useTwoColumns,
                            first: TextFormField(
                              controller: _firstName,
                              decoration: const InputDecoration(
                                labelText: 'First name',
                                border: OutlineInputBorder(),
                              ),
                            ),
                            second: TextFormField(
                              controller: _lastName,
                              decoration: const InputDecoration(
                                labelText: 'Last name',
                                border: OutlineInputBorder(),
                              ),
                            ),
                          ),
                          const SizedBox(height: 12),
                          _fieldPair(
                            useTwoColumns: useTwoColumns,
                            first: TextFormField(
                              controller: _phone,
                              decoration: const InputDecoration(
                                labelText: 'Phone number',
                                border: OutlineInputBorder(),
                              ),
                              keyboardType: TextInputType.phone,
                            ),
                            second: DropdownButtonFormField<String>(
                              initialValue: _shopId,
                              isExpanded: true,
                              decoration: const InputDecoration(
                                labelText: 'Shop',
                                border: OutlineInputBorder(),
                              ),
                              items: widget.shops
                                  .map(
                                    (shop) => DropdownMenuItem(
                                      value: shop.id,
                                      child: Text(
                                        shop.name,
                                        overflow: TextOverflow.ellipsis,
                                      ),
                                    ),
                                  )
                                  .toList(growable: false),
                              onChanged: (value) {
                                if (value != null) {
                                  setState(() => _shopId = value);
                                }
                              },
                            ),
                          ),
                          const SizedBox(height: 24),
                          Row(
                            children: [
                              Text('Roles', style: theme.textTheme.titleMedium),
                              const Spacer(),
                              Text(
                                '${_roles.length} selected',
                                style: theme.textTheme.bodySmall,
                              ),
                            ],
                          ),
                          const SizedBox(height: 10),
                          Wrap(
                            spacing: 8,
                            runSpacing: 8,
                            children: widget.roles
                                .map((role) {
                                  final selected = _roles.contains(role);
                                  return FilterChip(
                                    label: Text(role),
                                    selected: selected,
                                    onSelected: (value) {
                                      setState(() {
                                        if (value) {
                                          _roles.add(role);
                                        } else {
                                          _roles.remove(role);
                                        }
                                        _showRoleError = false;
                                      });
                                    },
                                  );
                                })
                                .toList(growable: false),
                          ),
                          if (_showRoleError) ...[
                            const SizedBox(height: 8),
                            Text(
                              'Select at least one role.',
                              style: theme.textTheme.bodySmall?.copyWith(
                                color: theme.colorScheme.error,
                              ),
                            ),
                          ],
                        ],
                      );
                    },
                  ),
                ),
              ),
            ),
            const Divider(height: 1),
            Padding(
              padding: const EdgeInsets.fromLTRB(24, 12, 24, 16),
              child: Row(
                mainAxisAlignment: MainAxisAlignment.end,
                children: [
                  TextButton(
                    onPressed: () => Navigator.pop(context),
                    child: const Text('Cancel'),
                  ),
                  const SizedBox(width: 8),
                  FilledButton.icon(
                    onPressed: _submit,
                    icon: const Icon(Icons.save_outlined),
                    label: Text(_isEditing ? 'Save changes' : 'Create user'),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget _fieldPair({
    required bool useTwoColumns,
    required Widget first,
    required Widget second,
  }) {
    if (!useTwoColumns) {
      return Column(children: [first, const SizedBox(height: 12), second]);
    }

    return Row(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Expanded(child: first),
        const SizedBox(width: 12),
        Expanded(child: second),
      ],
    );
  }

  void _submit() {
    if (!_formKey.currentState!.validate()) return;
    if (_roles.isEmpty) {
      setState(() => _showRoleError = true);
      return;
    }

    Navigator.pop(
      context,
      _UserDraft(
        userName: _userName.text.trim(),
        email: _email.text.trim(),
        password: _isEditing ? null : _password.text,
        firstName: _firstName.text,
        lastName: _lastName.text,
        phoneNumber: _phone.text,
        shopId: _shopId,
        roles: _roles.toList(growable: false),
      ),
    );
  }

  String? _required(String? value) =>
      value == null || value.trim().isEmpty ? 'Required' : null;
}

class _UserDraft {
  const _UserDraft({
    required this.userName,
    required this.email,
    required this.password,
    required this.firstName,
    required this.lastName,
    required this.phoneNumber,
    required this.shopId,
    required this.roles,
  });

  final String userName;
  final String email;
  final String? password;
  final String firstName;
  final String lastName;
  final String phoneNumber;
  final String shopId;
  final List<String> roles;
}
