import 'dart:async';

import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/app_dependencies.dart';
import '../controllers/auth_controller.dart';
import '../controllers/supplier_controller.dart';
import '../data/data_exception.dart';
import '../data/supplier_finance_offline_store.dart';
import '../l10n/app_localizations.dart';
import '../models/application_component_keys.dart';
import '../models/supplier.dart';
import '../widgets/app_error_view.dart';

/// Shows confirmed PowerSync balances and queues payment commands locally.
class SupplierFinancesScreen extends ConsumerStatefulWidget {
  const SupplierFinancesScreen({super.key});

  @override
  ConsumerState<SupplierFinancesScreen> createState() =>
      _SupplierFinancesScreenState();
}

class _SupplierFinancesScreenState extends ConsumerState<SupplierFinancesScreen> {
  List<Supplier> _suppliers = [];
  String? _selectedSupplierId;
  Future<SupplierFinanceSnapshot>? _snapshot;
  bool _busy = false;

  SupplierFinanceOfflineStore get _store =>
      ref.read(appPowerSyncDatabaseProvider).supplierFinanceStore;

  @override
  void initState() {
    super.initState();
    unawaited(_loadSuppliers());
  }

  Future<void> _loadSuppliers() async {
    try {
      final session = ref.read(authControllerProvider).session;
      if (session == null) return;
      final suppliers = await ref.read(supplierRepositoryProvider).getAll(session.shopId);
      if (!mounted) return;
      setState(() {
        _suppliers = suppliers.where((s) => s.syncStatus == SupplierSyncStatus.synced)
            .toList()..sort((a, b) => a.name.compareTo(b.name));
        if (_selectedSupplierId == null ||
            !_suppliers.any((s) => s.id == _selectedSupplierId)) {
          _selectedSupplierId = _suppliers.isEmpty ? null : _suppliers.first.id;
        }
      });
      _refresh();
    } catch (error, stack) {
      if (mounted) AppErrorNotification.show(context, error, stack);
    }
  }

  void _refresh() {
    final session = ref.read(authControllerProvider).session;
    final supplierId = _selectedSupplierId;
    if (session == null || supplierId == null) return;
    setState(() => _snapshot = _store.snapshot(session.shopId, supplierId));
  }

  Future<void> _pay(SupplierFinanceSnapshot current) async {
    if (_busy || current.outstanding <= 0 || current.pendingPayments.isNotEmpty) return;
    final supplierId = _selectedSupplierId;
    if (supplierId == null) return;
    final amountController = TextEditingController();
    final methodController = TextEditingController(text: 'Cash');
    final referenceController = TextEditingController();
    final notesController = TextEditingController();
    try {
      final form = GlobalKey<FormState>();
      final confirmed = await showDialog<bool>(
        context: context,
        builder: (dialogContext) => AlertDialog(
          title: Text(context.l10n.text('Record supplier payment')),
          content: Form(
            key: form,
            child: SingleChildScrollView(
              child: Column(
                mainAxisSize: MainAxisSize.min,
                children: [
                  Text('${context.l10n.text('Outstanding')}: ${current.outstanding}'),
                  TextFormField(
                    controller: amountController,
                    autofocus: true,
                    keyboardType: TextInputType.number,
                    decoration: InputDecoration(labelText: context.l10n.text('Amount')),
                    validator: (value) {
                      final amount = int.tryParse(value?.trim() ?? '');
                      if (amount == null || amount <= 0 || amount > current.outstanding) {
                        return context.l10n.text('Enter a valid amount within the outstanding balance.');
                      }
                      return null;
                    },
                  ),
                  TextFormField(
                    controller: methodController,
                    decoration: InputDecoration(labelText: context.l10n.text('Payment method')),
                    maxLength: 50,
                    validator: (value) =>
                        (value ?? '').trim().isEmpty ? context.l10n.text('Required') : null,
                  ),
                  TextFormField(
                    controller: referenceController,
                    maxLength: 100,
                    decoration: InputDecoration(labelText: context.l10n.text('Reference number')),
                  ),
                  TextFormField(
                    controller: notesController,
                    maxLength: 500,
                    decoration: InputDecoration(labelText: context.l10n.text('Notes')),
                  ),
                ],
              ),
            ),
          ),
          actions: [
            TextButton(
              onPressed: () => Navigator.pop(dialogContext, false),
              child: Text(context.l10n.text('Cancel')),
            ),
            FilledButton(
              onPressed: () {
                if (form.currentState?.validate() == true) {
                  Navigator.pop(dialogContext, true);
                }
              },
              child: Text(context.l10n.text('Save')),
            ),
          ],
        ),
      );
      if (confirmed != true || !mounted) return;
      setState(() => _busy = true);
      await _store.enqueuePayment(
        supplierId,
        amount: int.parse(amountController.text.trim()),
        paymentMethod: methodController.text.trim(),
        referenceNumber: referenceController.text.trim().isEmpty
            ? null : referenceController.text.trim(),
        notes: notesController.text.trim().isEmpty ? null : notesController.text.trim(),
      );
      // A queued payment is not settled yet. Show it as pending while the server
      // processes it; the confirmed balance arrives separately through PowerSync.
      _refresh();
      unawaited(_store.syncNow().then((_) {
        if (mounted) _refresh();
      }).catchError((Object _) {}));
    } catch (error, stack) {
      if (mounted) AppErrorNotification.show(context, error, stack);
    } finally {
      amountController.dispose();
      methodController.dispose();
      referenceController.dispose();
      notesController.dispose();
      if (mounted) setState(() => _busy = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    final session = ref.watch(authControllerProvider).session;
    final permission = session?.permissionFor(ApplicationComponentKeys.purchasing);
    if (permission == null || !permission.canView || !permission.canRead) {
      return Scaffold(
        appBar: AppBar(title: Text(context.l10n.text('Supplier balances'))),
        body: Center(child: Text(context.l10n.text('Permission denied'))),
      );
    }
    return Scaffold(
      appBar: AppBar(
        title: Text(context.l10n.text('Supplier balances')),
        actions: [
          IconButton(
            tooltip: context.l10n.text('Refresh'),
            icon: const Icon(Icons.refresh),
            onPressed: _loadSuppliers,
          ),
        ],
      ),
      body: Padding(
        padding: const EdgeInsets.all(16),
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 800),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.stretch,
              children: [
                DropdownButtonFormField<String>(
                  key: ValueKey(_selectedSupplierId),
                  initialValue: _selectedSupplierId,
                  decoration: InputDecoration(labelText: context.l10n.text('Supplier')),
                  items: [
                    for (final supplier in _suppliers)
                      DropdownMenuItem(value: supplier.id, child: Text(supplier.name)),
                  ],
                  onChanged: (value) {
                    setState(() => _selectedSupplierId = value);
                    _refresh();
                  },
                ),
                const SizedBox(height: 16),
                if (_snapshot != null)
                  Expanded(
                    child: FutureBuilder<SupplierFinanceSnapshot>(
                      future: _snapshot,
                      builder: (context, snapshot) {
                        if (snapshot.hasError) {
                          return AppErrorView(
                            error: snapshot.error!,
                            stackTrace: snapshot.stackTrace,
                            onRetry: _refresh,
                          );
                        }
                        if (!snapshot.hasData) {
                          return const Center(child: CircularProgressIndicator());
                        }
                        final data = snapshot.data!;
                        return ListView(
                          children: [
                            Card(child: ListTile(
                              title: Text(context.l10n.text('Outstanding')),
                              trailing: Text('${data.outstanding}'),
                              subtitle: Text(
                                '${context.l10n.text('Supplier credit')}: ${data.supplierCredit}',
                              ),
                            )),
                            if (permission.canUpdate && data.outstanding > 0)
                              Padding(
                                padding: const EdgeInsets.symmetric(vertical: 8),
                                child: FilledButton.icon(
                                  onPressed: _busy || data.pendingPayments.isNotEmpty
                                      ? null : () => _pay(data),
                                  icon: const Icon(Icons.payments_outlined),
                                  label: Text(context.l10n.text('Record payment')),
                                ),
                              ),
                            for (final pending in data.pendingPayments)
                              Card(child: ListTile(
                                title: Text('${context.l10n.text('Payment')}: ${pending['amount']}'),
                                subtitle: Text(
                                  '${context.l10n.text('Sync status')}: ${pending['state']}'
                                  '${pending['error'] == null ? '' : '\n${pending['error']}'}',
                                ),
                                trailing: pending['state'] == 'failed'
                                    ? Wrap(spacing: 4, children: [
                                        IconButton(
                                          tooltip: context.l10n.text('Retry'),
                                          icon: const Icon(Icons.refresh),
                                          onPressed: () async {
                                            await _store.retry(pending['id'] as String);
                                            if (mounted) _refresh();
                                          },
                                        ),
                                        IconButton(
                                          tooltip: context.l10n.text('Discard'),
                                          icon: const Icon(Icons.delete_outline),
                                          onPressed: () async {
                                            await _store.discard(pending['id'] as String);
                                            if (mounted) _refresh();
                                          },
                                        ),
                                      ])
                                    : const Icon(Icons.schedule),
                              )),
                            for (final payable in data.payables)
                              Card(child: ListTile(
                                title: Text('${context.l10n.text('Purchase order')}: ${payable.purchaseOrderId}'),
                                subtitle: Text(
                                  '${context.l10n.text('Received')}: ${payable.totalAmount}  '
                                  '${context.l10n.text('Returned')}: ${payable.creditAmount}  '
                                  '${context.l10n.text('Paid')}: ${payable.paidAmount}',
                                ),
                                trailing: Text('${payable.remaining}'),
                              )),
                            if (data.payments.isNotEmpty) ...[
                              const Divider(),
                              Text(context.l10n.text('Payment history'),
                                  style: Theme.of(context).textTheme.titleMedium),
                              for (final payment in data.payments)
                                ListTile(
                                  title: Text('${payment['amount']} • ${payment['payment_method']}'),
                                  subtitle: Text((payment['paid_at_utc'] ?? '').toString()),
                                ),
                            ],
                          ],
                        );
                      },
                    ),
                  ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
