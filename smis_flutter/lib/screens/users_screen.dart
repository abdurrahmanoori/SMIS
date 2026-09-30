import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../data/data_exception.dart';
import '../data/user_management_api.dart';
import '../models/managed_user.dart';
import '../widgets/app_drawer.dart';

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
  bool _loading = true;
  bool _mutating = false;
  Object? _error;
  int _pageNumber = 1;

  @override
  void initState() {
    super.initState();
    Future<void>.microtask(_load);
  }

  UserManagementApi? get _api {
    final session = ref.read(authControllerProvider).session;
    if (session == null || !session.isSuperAdmin) return null;
    return UserManagementApi(token: session.token);
  }

  Future<void> _load() async {
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
      final results = await Future.wait<Object>([
        api.getUsers(pageNumber: _pageNumber, pageSize: _pageSize),
        api.getActiveShops(),
      ]);
      if (!mounted) return;
      setState(() {
        _page = results[0] as ManagedUserPage;
        _shops = results[1] as List<UserShopOption>;
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
      }
      await _load();
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
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    } finally {
      if (mounted) setState(() => _mutating = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    final session = ref.watch(authControllerProvider).session;
    if (session == null || !session.isSuperAdmin) {
      return const Scaffold(
        drawer: AppDrawer(),
        body: Center(child: Text('Only a SuperAdmin can manage users.')),
      );
    }

    return Scaffold(
      appBar: AppBar(
        title: const Text('User management'),
        actions: [
          IconButton(
            tooltip: 'Refresh',
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
              label: const Text('Add user'),
            ),
      body: Column(
        children: [
          MaterialBanner(
            leading: const Icon(Icons.cloud_outlined),
            content: const Text(
              'User administration is online-only. Changes are saved directly to the server and are not queued for offline sync.',
            ),
            actions: [
              TextButton(onPressed: _load, child: const Text('Refresh')),
            ],
          ),
          Expanded(child: _buildBody(session.userId)),
        ],
      ),
    );
  }

  Widget _buildBody(String currentUserId) {
    if (_loading && _page == null) {
      return const Center(child: CircularProgressIndicator());
    }
    if (_error != null && _page == null) {
      return Center(
        child: Padding(
          padding: const EdgeInsets.all(24),
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              const Icon(Icons.cloud_off_outlined, size: 48),
              const SizedBox(height: 12),
              const Text(
                'User management requires a connection to the server.',
                textAlign: TextAlign.center,
              ),
              const SizedBox(height: 12),
              FilledButton(onPressed: _load, child: const Text('Retry')),
            ],
          ),
        ),
      );
    }

    final page = _page;
    if (page == null || page.items.isEmpty) {
      return const Center(child: Text('No users found.'));
    }

    return Column(
      children: [
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
                    leading: CircleAvatar(
                      child: Text(
                        user.userName.isEmpty
                            ? '?'
                            : user.userName.characters.first.toUpperCase(),
                      ),
                    ),
                    title: Text(user.displayName),
                    subtitle: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text('${user.userName} · ${user.email}'),
                        Text(user.shopName ?? user.shopId),
                        if (user.roles.isNotEmpty) Text(user.roles.join(', ')),
                      ],
                    ),
                    isThreeLine: true,
                    trailing: PopupMenuButton<String>(
                      onSelected: (value) {
                        if (value == 'edit') {
                          _openForm(user);
                        } else if (value == 'delete') {
                          _delete(user);
                        }
                      },
                      itemBuilder: (context) => [
                        const PopupMenuItem(value: 'edit', child: Text('Edit')),
                        if (user.id != currentUserId)
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
                  onPressed: _pageNumber > 1 && !_loading
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
                  onPressed: _pageNumber < page.totalPages && !_loading
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
  Widget build(BuildContext context) => AlertDialog(
    title: Text(_isEditing ? 'Edit user' : 'Create user'),
    content: SizedBox(
      width: 520,
      child: Form(
        key: _formKey,
        child: SingleChildScrollView(
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              TextFormField(
                controller: _userName,
                decoration: const InputDecoration(labelText: 'Username'),
                validator: _required,
              ),
              TextFormField(
                controller: _email,
                decoration: const InputDecoration(labelText: 'Email'),
                keyboardType: TextInputType.emailAddress,
                validator: _required,
              ),
              if (!_isEditing)
                TextFormField(
                  controller: _password,
                  decoration: const InputDecoration(labelText: 'Password'),
                  obscureText: true,
                  validator: _required,
                ),
              TextFormField(
                controller: _firstName,
                decoration: const InputDecoration(labelText: 'First name'),
              ),
              TextFormField(
                controller: _lastName,
                decoration: const InputDecoration(labelText: 'Last name'),
              ),
              TextFormField(
                controller: _phone,
                decoration: const InputDecoration(labelText: 'Phone number'),
                keyboardType: TextInputType.phone,
              ),
              const SizedBox(height: 12),
              DropdownButtonFormField<String>(
                initialValue: _shopId,
                decoration: const InputDecoration(labelText: 'Shop'),
                items: widget.shops
                    .map(
                      (shop) => DropdownMenuItem(
                        value: shop.id,
                        child: Text(shop.name),
                      ),
                    )
                    .toList(growable: false),
                onChanged: (value) {
                  if (value != null) setState(() => _shopId = value);
                },
              ),
              const SizedBox(height: 16),
              Align(
                alignment: Alignment.centerLeft,
                child: Text(
                  'Roles',
                  style: Theme.of(context).textTheme.titleSmall,
                ),
              ),
              ...widget.roles.map(
                (role) => CheckboxListTile(
                  dense: true,
                  contentPadding: EdgeInsets.zero,
                  title: Text(role),
                  value: _roles.contains(role),
                  onChanged: (selected) {
                    setState(() {
                      if (selected == true) {
                        _roles.add(role);
                      } else {
                        _roles.remove(role);
                      }
                    });
                  },
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
        child: const Text('Cancel'),
      ),
      FilledButton(
        onPressed: () {
          if (!_formKey.currentState!.validate()) return;
          if (_roles.isEmpty) {
            ScaffoldMessenger.of(context).showSnackBar(
              const SnackBar(content: Text('Select at least one role.')),
            );
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
        },
        child: Text(_isEditing ? 'Save' : 'Create'),
      ),
    ],
  );

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
