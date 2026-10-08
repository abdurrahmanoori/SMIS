import 'dart:async';

import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import '../controllers/app_dependencies.dart';
import '../controllers/product_controller.dart';
import '../controllers/product_unit_controller.dart';
import '../controllers/supplier_controller.dart';
import '../controllers/unit_of_measure_controller.dart';
import '../data/data_exception.dart';
import '../data/purchase_order_offline_store.dart';
import '../data/stock_api.dart';
import '../l10n/app_localizations.dart';
import '../models/application_component_keys.dart';
import '../models/application_task_keys.dart';
import '../models/product.dart';
import '../models/product_unit.dart';
import '../models/purchase_order.dart';
import '../models/supplier.dart';
import '../models/unit_of_measure.dart';
import 'supplier_finances_screen.dart';
import '../widgets/active_shop_context.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/home_action.dart';
import '../widgets/locale_action.dart';
import '../widgets/theme_mode_action.dart';

final purchaseOrderStoreProvider = Provider<PurchaseOrderOfflineStore>(
  (ref) => ref.watch(appPowerSyncDatabaseProvider).purchaseOrderStore,
);

class PurchaseOrdersScreen extends ConsumerWidget {
  const PurchaseOrdersScreen({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final session = ref.watch(authControllerProvider).session;
    final permission = session?.permissionFor(
      ApplicationComponentKeys.purchasing,
    );
    if (permission == null || !permission.canView || !permission.canRead) {
      return Scaffold(
        appBar: AppBar(title: Text(context.l10n.text('Purchase orders'))),
        drawer: const AppDrawer(),
        body: Center(
          child: Text(
            context.l10n.text(
              'You do not have permission to view purchase orders.',
            ),
          ),
        ),
      );
    }
    return _PurchaseOrdersContent(
      key: ValueKey('${session!.userId}/${session.shopId}'),
      shopId: session.shopId,
      canCreate: permission.canCreate,
      canReceive:
          permission.canUpdate &&
          session.hasTaskPermission(ApplicationTaskKeys.receivePurchaseOrder),
      canReturn:
          permission.canUpdate &&
          session.hasTaskPermission(
            ApplicationTaskKeys.processPurchaseOrderSupplierReturn,
          ) &&
          session.canReadComponent(ApplicationComponentKeys.inventory),
      canCancel:
          permission.canUpdate &&
          session.hasTaskPermission(ApplicationTaskKeys.cancelPurchaseOrder),
    );
  }
}

class _PurchaseOrdersContent extends ConsumerStatefulWidget {
  const _PurchaseOrdersContent({
    super.key,
    required this.shopId,
    required this.canCreate,
    required this.canReceive,
    required this.canReturn,
    required this.canCancel,
  });

  final String shopId;
  final bool canCreate;
  final bool canReceive;
  final bool canReturn;
  final bool canCancel;

  @override
  ConsumerState<_PurchaseOrdersContent> createState() =>
      _PurchaseOrdersContentState();
}

class _PurchaseOrdersContentState
    extends ConsumerState<_PurchaseOrdersContent> {
  late Future<List<PurchaseOrder>> _orders;
  final _items = <PurchaseOrder>[];
  bool _busy = false;

  PurchaseOrderOfflineStore get _store => ref.read(purchaseOrderStoreProvider);

  @override
  void initState() {
    super.initState();
    _orders = _store.list(widget.shopId);
  }

  Future<void> _reload() async {
    setState(() {
      _orders = _store.list(widget.shopId);
    });
    await _orders;
  }

  Future<void> _run(Future<void> Function() action) async {
    if (_busy) return;
    setState(() => _busy = true);
    try {
      await action();
      if (mounted) await _reload();
      unawaited(
        _store
            .syncNow()
            .then((_) {
              if (mounted) _reload();
            })
            .catchError((Object _) {}),
      );
    } catch (error, stack) {
      if (mounted) AppErrorNotification.show(context, error, stack);
    } finally {
      if (mounted) setState(() => _busy = false);
    }
  }

  Future<void> _create() async {
    try {
      final suppliers =
          (await ref
                  .read(supplierRepositoryProvider)
                  .getAll(widget.shopId, isActive: true))
              .where((item) => item.syncStatus == SupplierSyncStatus.synced)
              .toList();
      final products =
          (await ref.read(productRepositoryProvider).getAll(widget.shopId))
              .where(
                (item) =>
                    item.isActive &&
                    item.syncStatus == ProductSyncStatus.synced,
              )
              .toList();
      final units =
          (await ref.read(productUnitRepositoryProvider).getAll(widget.shopId))
              .where((item) => item.syncStatus == ProductUnitSyncStatus.synced)
              .toList();
      final measures = await ref.read(unitOfMeasureRepositoryProvider).getAll();
      if (!mounted) return;
      final payload = await Navigator.of(context).push<Map<String, dynamic>>(
        MaterialPageRoute(
          builder: (_) => _CreateOrderScreen(
            suppliers: suppliers,
            products: products,
            units: units,
            measures: measures,
          ),
        ),
      );
      if (payload != null && mounted) {
        await _run(() async {
          await _store.enqueueCreate(payload);
        });
      }
    } catch (error, stack) {
      if (mounted) AppErrorNotification.show(context, error, stack);
    }
  }

  Future<void> _receive(PurchaseOrder order) async {
    final lines = order.lines
        .where((line) => line.remainingQuantity > 0)
        .toList();
    final payload = await showDialog<Map<String, dynamic>>(
      context: context,
      builder: (_) => _ReceiveDialog(lines: lines),
    );
    if (payload != null && mounted) {
      await _run(() async {
        await _store.enqueue(order.id, 'receive', payload);
      });
    }
  }

  Future<void> _return(PurchaseOrder order) async {
    try {
      final lines = order.lines
          .where((line) => line.netReceivedQuantity > 0)
          .toList();
      final batches = <String, List<String>>{};
      for (final line in lines) {
        final movements =
            await ref
                .read(appPowerSyncDatabaseProvider)
                .stockStore
                .cachedList('movements') ??
            const <Map<String, dynamic>>[];
        batches[line.id] = movements
            .where(
              (movement) =>
                  stockText(movement, 'referenceType') == 'PurchaseOrderLine' &&
                  stockText(movement, 'referenceId') == line.id &&
                  stockText(movement, 'reason') == 'PurchaseReceipt',
            )
            .map((movement) => stockText(movement, 'stockBatchId'))
            .where((id) => id.isNotEmpty)
            .toSet()
            .toList();
      }
      if (!mounted) return;
      final stockBatches =
          await ref
              .read(appPowerSyncDatabaseProvider)
              .stockStore
              .cachedList('batches') ??
          const <Map<String, dynamic>>[];
      if (!mounted) return;
      final batchLabels = <String, String>{
        for (final batch in stockBatches)
          stockText(
            batch,
            'id',
          ): '${stockText(batch, 'batchNumber').isEmpty ? context.l10n.text('Unnumbered batch') : stockText(batch, 'batchNumber')} • ${context.l10n.text('Available (base units)')}: ${stockNumber(batch, 'remainingQuantityBase')}',
      };
      final payload = await showDialog<Map<String, dynamic>>(
        context: context,
        builder: (_) => _ReturnDialog(
          lines: lines,
          batches: batches,
          batchLabels: batchLabels,
        ),
      );
      if (payload != null && mounted) {
        await _run(() async {
          await _store.enqueue(order.id, 'supplier-return', payload);
        });
      }
    } catch (error, stack) {
      if (mounted) AppErrorNotification.show(context, error, stack);
    }
  }

  Future<void> _cancel(PurchaseOrder order) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (dialogContext) => AlertDialog(
        title: Text(dialogContext.l10n.text('Cancel purchase order?')),
        content: Text(
          dialogContext.l10n.text(
            'Only orders with no received stock can be cancelled.',
          ),
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(dialogContext, false),
            child: Text(dialogContext.l10n.text('Back')),
          ),
          FilledButton(
            onPressed: () => Navigator.pop(dialogContext, true),
            child: Text(dialogContext.l10n.text('Cancel order')),
          ),
        ],
      ),
    );
    if (confirmed == true && mounted) {
      await _run(() async {
        await _store.enqueue(order.id, 'cancel', const {});
      });
    }
  }

  @override
  Widget build(BuildContext context) => Scaffold(
    appBar: AppBar(
      title: Text(context.l10n.text('Purchase orders')),
      actions: [
        IconButton(
          tooltip: context.l10n.text('Supplier balances'),
          icon: const Icon(Icons.account_balance_wallet_outlined),
          onPressed: () => Navigator.of(context).push(
            MaterialPageRoute(builder: (_) => const SupplierFinancesScreen()),
          ),
        ),
        const ActiveShopAction(),
        IconButton(
          tooltip: context.l10n.text('Refresh'),
          onPressed: _busy ? null : _reload,
          icon: const Icon(Icons.refresh),
        ),
        const HomeAction(),
        const LocaleAction(),
        const ThemeModeAction(),
        const SizedBox(width: 8),
      ],
    ),
    drawer: const AppDrawer(),
    floatingActionButton: widget.canCreate
        ? FloatingActionButton.extended(
            onPressed: _busy ? null : _create,
            icon: const Icon(Icons.add),
            label: Text(context.l10n.text('New purchase order')),
          )
        : null,
    body: SafeArea(
      child: Center(
        child: ConstrainedBox(
          constraints: const BoxConstraints(maxWidth: 950),
          child: FutureBuilder<List<PurchaseOrder>>(
            future: _orders,
            builder: (context, snapshot) {
              if (snapshot.hasError) {
                return AppErrorView(
                  error: snapshot.error!,
                  stackTrace: snapshot.stackTrace,
                  onRetry: _reload,
                );
              }
              if (!snapshot.hasData) {
                return const Center(child: CircularProgressIndicator());
              }
              _items
                ..clear()
                ..addAll(snapshot.data!);
              return RefreshIndicator(
                onRefresh: _reload,
                child: ListView(
                  padding: const EdgeInsets.fromLTRB(16, 12, 16, 96),
                  children: [
                    Card(
                      child: ListTile(
                        leading: const Icon(Icons.wifi),
                        title: Text(
                          context.l10n.text(
                            'Purchase orders are available offline.',
                          ),
                        ),
                        subtitle: Text(
                          context.l10n.text(
                            'Purchase actions are saved locally and synchronized in order when connected.',
                          ),
                        ),
                      ),
                    ),
                    if (_items.isEmpty)
                      Padding(
                        padding: const EdgeInsets.all(40),
                        child: Center(
                          child: Text(
                            context.l10n.text('No purchase orders found.'),
                          ),
                        ),
                      ),
                    for (final order in _items)
                      Card(
                        child: ExpansionTile(
                          title: Text(
                            order.referenceNumber?.isNotEmpty == true
                                ? order.referenceNumber!
                                : order.supplierName,
                          ),
                          subtitle: Text(
                            '${order.supplierName} • ${context.l10n.text(order.status)} • ${order.orderedAtUtc.toLocal().toString().split('.').first}',
                          ),
                          childrenPadding: const EdgeInsets.all(16),
                          children: [
                            if (order.notes?.isNotEmpty == true)
                              Align(
                                alignment: Alignment.centerLeft,
                                child: Text(order.notes!),
                              ),
                            for (final line in order.lines)
                              ListTile(
                                title: Text(line.productName),
                                subtitle: Text(
                                  '${context.l10n.text('Ordered')}: ${line.orderedQuantity}  •  ${context.l10n.text('Received')}: ${line.receivedQuantity}  •  ${context.l10n.text('Returned')}: ${line.returnedQuantity}\n${context.l10n.text('Unit cost')}: ${line.unitCostBase}',
                                ),
                              ),
                            Wrap(
                              spacing: 8,
                              children: [
                                if (widget.canReceive &&
                                    !order.isCancelled &&
                                    order.lines.any(
                                      (line) => line.remainingQuantity > 0,
                                    ))
                                  OutlinedButton(
                                    onPressed: _busy
                                        ? null
                                        : () => _receive(order),
                                    child: Text(
                                      context.l10n.text('Receive stock'),
                                    ),
                                  ),
                                if (widget.canReturn &&
                                    order.lines.any(
                                      (line) => line.netReceivedQuantity > 0,
                                    ))
                                  OutlinedButton(
                                    onPressed: _busy
                                        ? null
                                        : () => _return(order),
                                    child: Text(
                                      context.l10n.text('Return to supplier'),
                                    ),
                                  ),
                                if (widget.canCancel &&
                                    !order.isCancelled &&
                                    !order.hasReceipts)
                                  OutlinedButton(
                                    onPressed: _busy
                                        ? null
                                        : () => _cancel(order),
                                    child: Text(
                                      context.l10n.text('Cancel order'),
                                    ),
                                  ),
                              ],
                            ),
                          ],
                        ),
                      ),
                  ],
                ),
              );
            },
          ),
        ),
      ),
    ),
  );
}

class _CreateOrderScreen extends StatefulWidget {
  const _CreateOrderScreen({
    required this.suppliers,
    required this.products,
    required this.units,
    required this.measures,
  });

  final List<Supplier> suppliers;
  final List<Product> products;
  final List<ProductUnit> units;
  final List<UnitOfMeasure> measures;

  @override
  State<_CreateOrderScreen> createState() => _CreateOrderScreenState();
}

class _CreateOrderScreenState extends State<_CreateOrderScreen> {
  final _form = GlobalKey<FormState>();
  final _reference = TextEditingController();
  final _notes = TextEditingController();
  String? _supplierId;
  final _lines = <_OrderLineDraft>[];

  @override
  void dispose() {
    _reference.dispose();
    _notes.dispose();
    for (final line in _lines) {
      line.dispose();
    }
    super.dispose();
  }

  void _save() {
    if (!_form.currentState!.validate() || _lines.isEmpty) {
      if (_lines.isEmpty) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text(context.l10n.text('Add at least one line.'))),
        );
      }
      return;
    }
    Navigator.pop(context, {
      'supplierId': _supplierId,
      'referenceNumber': _reference.text.trim().isEmpty
          ? null
          : _reference.text.trim(),
      'notes': _notes.text.trim().isEmpty ? null : _notes.text.trim(),
      'lines': _lines.map((line) {
        final unit = widget.units.firstWhere((item) => item.id == line.unitId);
        return {
          'productId': unit.productId,
          'productUnitId': unit.id,
          'quantityEntered': double.parse(line.quantity.text),
          'unitCostBase': int.parse(line.cost.text),
        };
      }).toList(),
    });
  }

  @override
  Widget build(BuildContext context) {
    final eligibleUnits = widget.units
        .where(
          (unit) =>
              widget.products.any((product) => product.id == unit.productId),
        )
        .toList();
    return Scaffold(
      appBar: AppBar(title: Text(context.l10n.text('New purchase order'))),
      body: Center(
        child: ConstrainedBox(
          constraints: const BoxConstraints(maxWidth: 700),
          child: Form(
            key: _form,
            child: ListView(
              padding: const EdgeInsets.all(16),
              children: [
                if (widget.suppliers.isEmpty || eligibleUnits.isEmpty)
                  Card(
                    child: ListTile(
                      title: Text(
                        context.l10n.text(
                          'Synced suppliers and product units are required.',
                        ),
                      ),
                    ),
                  ),
                DropdownButtonFormField<String>(
                  initialValue: _supplierId,
                  decoration: InputDecoration(
                    labelText: context.l10n.text('Supplier'),
                  ),
                  items: widget.suppliers
                      .map(
                        (supplier) => DropdownMenuItem(
                          value: supplier.id,
                          child: Text(supplier.name),
                        ),
                      )
                      .toList(),
                  onChanged: (value) => setState(() => _supplierId = value),
                  validator: (value) => value == null
                      ? context.l10n.text('Select a supplier.')
                      : null,
                ),
                TextFormField(
                  controller: _reference,
                  maxLength: 100,
                  decoration: InputDecoration(
                    labelText: context.l10n.text('Reference number'),
                  ),
                ),
                TextFormField(
                  controller: _notes,
                  maxLength: 500,
                  maxLines: 2,
                  decoration: InputDecoration(
                    labelText: context.l10n.text('Notes'),
                  ),
                ),
                for (final line in _lines)
                  Card(
                    child: Padding(
                      padding: const EdgeInsets.all(12),
                      child: Column(
                        children: [
                          DropdownButtonFormField<String>(
                            initialValue: line.unitId,
                            isExpanded: true,
                            decoration: InputDecoration(
                              labelText: context.l10n.text('Product unit'),
                            ),
                            items: eligibleUnits
                                .where(
                                  (unit) => !_lines.any(
                                    (other) =>
                                        other != line &&
                                        other.unitId == unit.id,
                                  ),
                                )
                                .map((unit) {
                                  final product = widget.products.firstWhere(
                                    (item) => item.id == unit.productId,
                                  );
                                  final measure = widget.measures.where(
                                    (item) => item.id == unit.unitOfMeasureId,
                                  );
                                  return DropdownMenuItem(
                                    value: unit.id,
                                    child: Text(
                                      '${product.name} • ${measure.isEmpty ? unit.unitOfMeasureId : measure.first.name} (×${unit.baseUnitQuantity})',
                                    ),
                                  );
                                })
                                .toList(),
                            onChanged: (value) =>
                                setState(() => line.unitId = value),
                            validator: (value) => value == null
                                ? context.l10n.text('Select a product unit.')
                                : null,
                          ),
                          TextFormField(
                            controller: line.quantity,
                            keyboardType: const TextInputType.numberWithOptions(
                              decimal: true,
                            ),
                            decoration: InputDecoration(
                              labelText: context.l10n.text('Quantity'),
                            ),
                            validator: (value) =>
                                (double.tryParse(value ?? '') ?? 0) > 0
                                ? null
                                : context.l10n.text(
                                    'Enter a positive quantity.',
                                  ),
                          ),
                          TextFormField(
                            controller: line.cost,
                            keyboardType: TextInputType.number,
                            decoration: InputDecoration(
                              labelText: context.l10n.text(
                                'Unit cost (base currency)',
                              ),
                            ),
                            validator: (value) =>
                                (int.tryParse(value ?? '') ?? -1) >= 0
                                ? null
                                : context.l10n.text(
                                    'Enter a non-negative whole cost.',
                                  ),
                          ),
                          Align(
                            alignment: Alignment.centerRight,
                            child: TextButton.icon(
                              onPressed: () => setState(() {
                                _lines.remove(line);
                                line.dispose();
                              }),
                              icon: const Icon(Icons.remove_circle_outline),
                              label: Text(context.l10n.text('Remove line')),
                            ),
                          ),
                        ],
                      ),
                    ),
                  ),
                TextButton.icon(
                  onPressed: eligibleUnits.isEmpty
                      ? null
                      : () => setState(() => _lines.add(_OrderLineDraft())),
                  icon: const Icon(Icons.add),
                  label: Text(context.l10n.text('Add line')),
                ),
                const SizedBox(height: 12),
                FilledButton(
                  onPressed: widget.suppliers.isEmpty || eligibleUnits.isEmpty
                      ? null
                      : _save,
                  child: Text(context.l10n.text('Create purchase order')),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}

class _OrderLineDraft {
  String? unitId;
  final quantity = TextEditingController();
  final cost = TextEditingController();

  void dispose() {
    quantity.dispose();
    cost.dispose();
  }
}

class _ReceiveDialog extends StatefulWidget {
  const _ReceiveDialog({required this.lines});

  final List<PurchaseOrderLine> lines;

  @override
  State<_ReceiveDialog> createState() => _ReceiveDialogState();
}

class _ReceiveDialogState extends State<_ReceiveDialog> {
  final _form = GlobalKey<FormState>();
  final _quantity = TextEditingController();
  final _batch = TextEditingController();
  DateTime? _expiration;
  String? _lineId;

  @override
  void dispose() {
    _quantity.dispose();
    _batch.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final line = widget.lines.where((item) => item.id == _lineId);
    return AlertDialog(
      title: Text(context.l10n.text('Receive stock')),
      content: SizedBox(
        width: 480,
        child: Form(
          key: _form,
          child: SingleChildScrollView(
            child: Column(
              mainAxisSize: MainAxisSize.min,
              children: [
                DropdownButtonFormField<String>(
                  initialValue: _lineId,
                  isExpanded: true,
                  decoration: InputDecoration(
                    labelText: context.l10n.text('Order line'),
                  ),
                  items: widget.lines
                      .map(
                        (item) => DropdownMenuItem(
                          value: item.id,
                          child: Text(
                            '${item.productName} • ${context.l10n.text('Remaining')}: ${item.remainingQuantity}',
                          ),
                        ),
                      )
                      .toList(),
                  onChanged: (value) => setState(() => _lineId = value),
                  validator: (value) => value == null
                      ? context.l10n.text('Select a line.')
                      : null,
                ),
                TextFormField(
                  controller: _quantity,
                  keyboardType: const TextInputType.numberWithOptions(
                    decimal: true,
                  ),
                  decoration: InputDecoration(
                    labelText: context.l10n.text('Quantity'),
                  ),
                  validator: (value) {
                    final q = double.tryParse(value ?? '') ?? 0;
                    return q > 0 &&
                            (line.isEmpty || q <= line.first.remainingQuantity)
                        ? null
                        : context.l10n.text(
                            'Quantity exceeds the remaining amount.',
                          );
                  },
                ),
                TextFormField(
                  controller: _batch,
                  maxLength: 50,
                  decoration: InputDecoration(
                    labelText: context.l10n.text('Batch number'),
                  ),
                ),
                TextButton.icon(
                  onPressed: () async {
                    final picked = await showDatePicker(
                      context: context,
                      initialDate: _expiration ?? DateTime.now(),
                      firstDate: DateTime(2000),
                      lastDate: DateTime(2100),
                    );
                    if (picked != null) setState(() => _expiration = picked);
                  },
                  icon: const Icon(Icons.event),
                  label: Text(
                    _expiration == null
                        ? context.l10n.text('Expiration date (optional)')
                        : _expiration!.toIso8601String().split('T').first,
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
          child: Text(context.l10n.text('Cancel')),
        ),
        FilledButton(
          onPressed: () {
            if (!_form.currentState!.validate()) return;
            Navigator.pop(context, {
              'lines': [
                {
                  'purchaseOrderLineId': _lineId,
                  'quantityEntered': double.parse(_quantity.text),
                  'batchNumber': _batch.text.trim().isEmpty
                      ? null
                      : _batch.text.trim(),
                  'expirationDate': _expiration?.toIso8601String(),
                },
              ],
            });
          },
          child: Text(context.l10n.text('Receive stock')),
        ),
      ],
    );
  }
}

class _ReturnDialog extends StatefulWidget {
  const _ReturnDialog({
    required this.lines,
    required this.batches,
    required this.batchLabels,
  });

  final List<PurchaseOrderLine> lines;
  final Map<String, List<String>> batches;
  final Map<String, String> batchLabels;

  @override
  State<_ReturnDialog> createState() => _ReturnDialogState();
}

class _ReturnDialogState extends State<_ReturnDialog> {
  final _form = GlobalKey<FormState>();
  final _quantity = TextEditingController();
  String? _lineId;
  String? _batchId;

  @override
  void dispose() {
    _quantity.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final batches = widget.batches[_lineId] ?? const <String>[];
    final line = widget.lines.where((item) => item.id == _lineId);
    return AlertDialog(
      title: Text(context.l10n.text('Return to supplier')),
      content: SizedBox(
        width: 480,
        child: Form(
          key: _form,
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              DropdownButtonFormField<String>(
                initialValue: _lineId,
                isExpanded: true,
                decoration: InputDecoration(
                  labelText: context.l10n.text('Order line'),
                ),
                items: widget.lines
                    .map(
                      (item) => DropdownMenuItem(
                        value: item.id,
                        child: Text(
                          '${item.productName} • ${context.l10n.text('Net received')}: ${item.netReceivedQuantity}',
                        ),
                      ),
                    )
                    .toList(),
                onChanged: (value) => setState(() {
                  _lineId = value;
                  _batchId = null;
                }),
                validator: (value) =>
                    value == null ? context.l10n.text('Select a line.') : null,
              ),
              DropdownButtonFormField<String>(
                key: ValueKey(_lineId),
                initialValue: _batchId,
                isExpanded: true,
                decoration: InputDecoration(
                  labelText: context.l10n.text('Received batch'),
                ),
                items: batches
                    .map(
                      (id) => DropdownMenuItem(
                        value: id,
                        child: Text(widget.batchLabels[id] ?? id),
                      ),
                    )
                    .toList(),
                onChanged: (value) => setState(() => _batchId = value),
                validator: (value) => value == null
                    ? context.l10n.text('Select a received batch.')
                    : null,
              ),
              TextFormField(
                controller: _quantity,
                keyboardType: const TextInputType.numberWithOptions(
                  decimal: true,
                ),
                decoration: InputDecoration(
                  labelText: context.l10n.text('Quantity'),
                ),
                validator: (value) {
                  final q = double.tryParse(value ?? '') ?? 0;
                  return q > 0 &&
                          (line.isEmpty || q <= line.first.netReceivedQuantity)
                      ? null
                      : context.l10n.text('Quantity exceeds net received.');
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
            if (!_form.currentState!.validate()) return;
            Navigator.pop(context, {
              'purchaseOrderLineId': _lineId,
              'stockBatchId': _batchId,
              'quantityEntered': double.parse(_quantity.text),
            });
          },
          child: Text(context.l10n.text('Return to supplier')),
        ),
      ],
    );
  }
}
