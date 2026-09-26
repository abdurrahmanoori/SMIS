import 'dart:async';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';

import '../controllers/auth_controller.dart';
import '../controllers/app_dependencies.dart';
import '../controllers/product_controller.dart';
import '../controllers/product_unit_controller.dart';
import '../controllers/unit_of_measure_controller.dart';
import '../data/data_exception.dart';
import '../data/stock_api.dart';
import '../data/stock_offline_store.dart';
import '../l10n/app_localizations.dart';
import '../models/product.dart';
import '../models/product_unit.dart';
import '../models/unit_of_measure.dart';
import '../widgets/active_shop_context.dart';
import '../widgets/app_drawer.dart';
import '../widgets/app_error_view.dart';
import '../widgets/home_action.dart';

final stockApiProvider = Provider<StockApi>((ref) => StockApi());
final stockStoreProvider = Provider<StockOfflineStore>(
  (ref) => ref.watch(appPowerSyncDatabaseProvider).stockStore,
);
final stockPendingCountProvider = FutureProvider.autoDispose<int>(
  (ref) => ref.watch(stockStoreProvider).pendingCount(),
);

class StockScreen extends ConsumerWidget {
  const StockScreen({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final session = ref.watch(
      authControllerProvider.select((state) => state.session),
    );
    return _StockContent(
      key: ValueKey('${session?.userId}/${session?.shopId}'),
      shopId: session?.shopId,
      userId: session?.userId,
    );
  }
}

class _StockContent extends ConsumerStatefulWidget {
  const _StockContent({super.key, required this.shopId, required this.userId});
  final String? shopId;
  final String? userId;

  @override
  ConsumerState<_StockContent> createState() => _StockContentState();
}

class _StockContentState extends ConsumerState<_StockContent> {
  static const _storage = FlutterSecureStorage();
  late Future<_StockData> _data;
  int _tab = 0;
  String _report = 'current-stock';
  bool _busy = false;
  String? _countId;
  StreamSubscription<dynamic>? _cacheSubscription;
  Object? _syncError;

  @override
  void initState() {
    super.initState();
    _data = _load();
    _restoreCount();
    _watchCache();
    _syncInBackground();
  }

  Future<void> _watchCache() async {
    final db = await ref.read(appPowerSyncDatabaseProvider).databaseForCurrentSession();
    if (!mounted) return;
    _cacheSubscription = db.watch(
      'SELECT id, cached_at_utc FROM stock_cache',
      throttle: const Duration(milliseconds: 300),
    ).skip(1).listen((_) => _refreshLocal());
  }

  @override
  void dispose() {
    _cacheSubscription?.cancel();
    super.dispose();
  }

  String get _countStorageKey =>
      'stock-count-${widget.userId ?? ''}-${widget.shopId ?? ''}';

  Future<void> _restoreCount() async {
    final id = await _storage.read(key: _countStorageKey);
    if (mounted && id != null && id.isNotEmpty) {
      setState(() => _countId = id);
    }
  }

  Future<void> _discard(String id) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Discard failed stock action?'),
        content: const Text(
          'This removes the local command. Review the confirmed stock balance first.',
        ),
        actions: [
          TextButton(onPressed: () => Navigator.pop(context, false),
            child: const Text('Keep')),
          FilledButton(onPressed: () => Navigator.pop(context, true),
            child: const Text('Discard')),
        ],
      ),
    );
    if (confirmed == true && mounted) {
      await _run(() => _store.discard(id));
    }
  }

  StockApi get _api => ref.read(stockApiProvider);
  StockOfflineStore get _store => ref.read(stockStoreProvider);

  Future<_StockData> _load() async {
    if (widget.shopId == null) {
      throw const AuthenticationException('Sign in to view stock.');
    }
    final results = await Future.wait<Object?>([
      _store.cachedList('batches'),
      ref.read(productLookupProvider.future),
      ref.read(productUnitLookupProvider.future),
      ref.read(unitOfMeasureLookupProvider.future),
      if (_tab == 1)
          _report == 'valuation'
            ? _store.cachedObject('valuation')
            : _report == 'reconciliation'
            ? _store.cachedList('reconciliation')
            : _store.cachedList(_report),
      if (_tab == 2) _store.cachedList('movements'),
      _store.pending(),
    ]);
    return _StockData(
      batches: results[0] as List<StockJson>? ?? const [],
      hasCache: results[0] != null,
      products: results[1] as List<Product>,
      units: results[2] as List<ProductUnit>,
      measures: results[3] as List<UnitOfMeasure>,
      report: _tab == 1 ? results[4] : null,
      movements: _tab == 2 ? results[4] as List<StockJson>? ?? const [] : const [],
      pending: results.last as List<PendingStockCommand>,
    );
  }

  void _refreshLocal() {
    if (mounted) setState(() => _data = _load());
  }

  Future<void> _syncInBackground() async {
    try {
      await _store.syncNow();
      if (mounted) setState(() => _syncError = null);
    } catch (error) {
      if (mounted) setState(() => _syncError = error);
    }
    _refreshLocal();
  }

  Future<void> _refresh() async {
    await _syncInBackground();
    if (_syncError != null && mounted) {
      AppErrorNotification.show(context, _syncError!);
    }
  }

  Future<bool> _run(Future<void> Function() action, {bool queued = false}) async {
    if (_busy) return false;
    setState(() => _busy = true);
    try {
      await action();
      if (!mounted) return false;
      ref.invalidate(stockPendingCountProvider);
      _refreshLocal();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text(context.l10n.text(queued
            ? 'Stock action saved locally. It will sync when connected.'
            : 'Stock updated.'))),
      );
      if (queued) unawaited(_syncInBackground());
      return true;
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
      return false;
    } finally {
      if (mounted) setState(() => _busy = false);
    }
  }

  void _selectTab(int tab) {
    if (_tab == tab) return;
    setState(() {
      _tab = tab;
      _data = _load();
    });
  }

  @override
  Widget build(BuildContext context) => Scaffold(
    appBar: AppBar(
      title: Text(context.l10n.text('Stock management')),
      actions: [
        const ActiveShopAction(),
        IconButton(
          icon: const Icon(Icons.refresh),
          tooltip: context.l10n.text('Refresh'),
          onPressed: _refresh,
        ),
        const HomeAction(),
      ],
    ),
    drawer: const AppDrawer(),
    bottomNavigationBar: NavigationBar(
      selectedIndex: _tab,
      onDestinationSelected: _selectTab,
      destinations: [
        NavigationDestination(icon: const Icon(Icons.inventory_2_outlined), label: context.l10n.text('Batches')),
        NavigationDestination(icon: const Icon(Icons.assessment_outlined), label: context.l10n.text('Reports')),
        NavigationDestination(icon: const Icon(Icons.history), label: context.l10n.text('Movements')),
      ],
    ),
    body: Stack(children: [
      FutureBuilder<_StockData>(
        future: _data,
        builder: (context, snapshot) {
          if (snapshot.hasError) {
            return AppErrorView(
              error: snapshot.error!,
              stackTrace: snapshot.stackTrace ?? StackTrace.current,
              onRetry: _refresh,
            );
          }
          if (!snapshot.hasData) {
            return const Center(child: CircularProgressIndicator());
          }
          final data = snapshot.data!;
          return Column(children: [
            if (!data.hasCache)
              const ListTile(title: Text('No cached stock yet. Connect to load stock.')),
            if (_syncError != null)
              const ListTile(title: Text('Offline: showing last saved stock data.')),
            Expanded(child: switch (_tab) {
            0 => _batches(data),
            1 => _reports(data),
            _ => _movements(data),
          }),
          ]);
        },
      ),
      if (_busy) const LinearProgressIndicator(),
    ]),
  );

  Widget _batches(_StockData data) => Column(children: [
    Padding(
      padding: const EdgeInsets.fromLTRB(16, 12, 16, 0),
      child: Text(context.l10n.text(
        'Stock actions are saved locally; confirmed balances refresh after upload.',
      )),
    ),
    Padding(
      padding: const EdgeInsets.all(12),
      child: Row(children: [
        FilledButton.icon(
          onPressed: _busy ? null : () => _receive(data),
          icon: const Icon(Icons.add),
          label: Text(context.l10n.text('Receive stock')),
        ),
        const SizedBox(width: 8),
        OutlinedButton.icon(
          onPressed: _busy || _countId != null ||
              !data.batches.any((b) => stockText(b, 'status') != 'cancelled')
              ? null : () => _startCount(data),
          icon: const Icon(Icons.fact_check_outlined),
          label: Text(context.l10n.text('Stock count')),
        ),
      ]),
    ),
    if (_countId != null)
      ListTile(
        leading: const Icon(Icons.fact_check),
        title: Text(context.l10n.text('Count in progress')),
        subtitle: Text(_countId!),
        trailing: const Icon(Icons.chevron_right),
        onTap: () => _openCount(_countId!),
      ),
    Expanded(child: RefreshIndicator(
      onRefresh: _refresh,
      child: ListView.builder(
        itemCount: data.pending.length + data.batches.length,
        itemBuilder: (context, index) {
          if (index < data.pending.length) {
            final command = data.pending[index];
            return ListTile(
              leading: Icon(command.state == 'failed'
                  ? Icons.error_outline : Icons.cloud_upload_outlined),
              title: Text('${command.kind} • ${command.state}'),
              subtitle: command.error == null ? null : Text(command.error!),
              trailing: command.state == 'failed'
                  ? PopupMenuButton<String>(
                      onSelected: (choice) => choice == 'retry'
                          ? _run(() => _store.retry(command.id))
                          : _discard(command.id),
                      itemBuilder: (_) => const [
                        PopupMenuItem(value: 'retry', child: Text('Retry')),
                        PopupMenuItem(value: 'discard', child: Text('Discard failed action')),
                      ],
                    ) : null,
            );
          }
          final batch = data.batches[index - data.pending.length];
          final product = data.product(stockText(batch, 'productId'));
          return ListTile(
            title: Text(product?.name ?? stockText(batch, 'productId')),
            subtitle: Text(
              'Batch: ${stockText(batch, 'batchNumber').isEmpty ? '—' : stockText(batch, 'batchNumber')}'
              '  •  ${stockText(batch, 'status')}'
              '  •  ${stockText(batch, 'expirationDate').split('T').first}',
            ),
            trailing: Text(stockNumber(batch, 'remainingQuantityBase').toString()),
            onTap: () => _batchActions(data, batch),
          );
        },
      ),
    )),
  ]);

  Widget _reports(_StockData data) => Column(children: [
    Padding(
      padding: const EdgeInsets.all(12),
      child: DropdownButtonFormField<String>(
        initialValue: _report,
        decoration: InputDecoration(labelText: context.l10n.text('Stock report')),
        items: const [
          DropdownMenuItem(value: 'current-stock', child: Text('Current stock')),
          DropdownMenuItem(value: 'low-stock', child: Text('Low stock')),
          DropdownMenuItem(value: 'expiring', child: Text('Expiring stock')),
          DropdownMenuItem(value: 'expired', child: Text('Expired stock')),
          DropdownMenuItem(value: 'valuation', child: Text('Valuation')),
          DropdownMenuItem(value: 'reconciliation', child: Text('Reconciliation mismatches')),
        ],
        onChanged: (value) {
          if (value == null) return;
          setState(() { _report = value; _data = _load(); });
        },
      ),
    ),
    Expanded(child: _reportList(data.report)),
  ]);

  Widget _reportList(Object? report) {
    if (report == null) {
      return const Center(child: Text('No saved report yet. Connect to download it.'));
    }
    if (report is StockJson) {
      final items = (report['products'] as List? ?? []).cast<Map>();
      return ListView(children: [
        ListTile(title: Text(context.l10n.text('Total value (minor units)')),
          trailing: Text(stockNumber(report, 'totalInventoryValueMinor').toString())),
        for (final item in items)
          ListTile(title: Text((item['productName'] ?? '').toString()),
            subtitle: Text('Quantity: ${item['quantityBase']}'),
            trailing: Text((item['inventoryValueMinor'] ?? '').toString())),
      ]);
    }
    final items = report as List<StockJson>? ?? [];
    if (items.isEmpty) return Center(child: Text(context.l10n.text('No stock records.')));
    return ListView.builder(
      itemCount: items.length,
      itemBuilder: (context, index) {
        final row = items[index];
        final quantity = row.containsKey('availableQuantityBase')
            ? 'Available: ${row['availableQuantityBase']} / Total: ${row['quantityBase']}'
            : row.containsKey('remainingQuantityBase')
            ? 'Remaining: ${row['remainingQuantityBase']}'
            : 'Difference: ${row['differenceBase']}';
        final detail = row.containsKey('expirationDate')
            ? '$quantity • Expires: ${stockText(row, 'expirationDate').split('T').first}'
            : row.containsKey('reorderPointBase')
            ? '$quantity • Reorder point: ${row['reorderPointBase']}'
            : quantity;
        return ListTile(
          title: Text(stockText(row, 'productName')),
          subtitle: Text(detail),
          trailing: row['isLowStock'] == true ? const Icon(Icons.warning_amber) : null,
        );
      },
    );
  }

  Widget _movements(_StockData data) => ListView.builder(
    itemCount: data.movements.length,
    itemBuilder: (context, index) {
      final row = data.movements[index];
      return ListTile(
        title: Text(stockText(row, 'productName')),
        subtitle: Text(
          '${stockText(row, 'reason')} • ${stockText(row, 'occurredAtUtc')}\n'
          'Batch: ${stockText(row, 'stockBatchId')}',
        ),
        isThreeLine: true,
        trailing: Text(
          '${stockText(row, 'direction') == 'out' ? '-' : '+'}'
          '${stockNumber(row, 'quantityBase')}',
        ),
        onTap: () => _movementActions(row),
      );
    },
  );

  Future<void> _receive(_StockData data) async {
    String? productId;
    String? unitId;
    final quantity = TextEditingController();
    final cost = TextEditingController(text: '0');
    final batchNumber = TextEditingController();
    DateTime? expiry;
    final accepted = await showDialog<bool>(
      context: context,
      builder: (dialogContext) => StatefulBuilder(builder: (context, update) {
        final units = data.units.where((unit) =>
            unit.productId == productId &&
            unit.syncStatus == ProductUnitSyncStatus.synced).toList();
        return AlertDialog(
          title: Text(context.l10n.text('Receive stock')),
          content: SizedBox(width: 400, child: SingleChildScrollView(child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              DropdownButtonFormField<String>(
                initialValue: productId,
                decoration: const InputDecoration(labelText: 'Product'),
                items: data.products.where((p) => p.syncStatus == ProductSyncStatus.synced)
                    .map((p) => DropdownMenuItem(value: p.id, child: Text(p.name))).toList(),
                onChanged: (id) => update(() { productId = id; unitId = null; }),
              ),
              DropdownButtonFormField<String>(
                key: ValueKey(productId),
                initialValue: unitId,
                decoration: const InputDecoration(labelText: 'Product unit'),
                items: units.map((u) => DropdownMenuItem(
                  value: u.id, child: Text(data.unitLabel(u)),
                )).toList(),
                onChanged: (id) => update(() => unitId = id),
              ),
              TextField(controller: quantity, onChanged: (_) => update(() {}),
                decoration: const InputDecoration(labelText: 'Received quantity'),
                keyboardType: const TextInputType.numberWithOptions(decimal: true)),
              TextField(controller: cost, decoration: const InputDecoration(labelText: 'Cost per base unit (minor units)'),
                keyboardType: TextInputType.number, inputFormatters: [FilteringTextInputFormatter.digitsOnly]),
              TextField(controller: batchNumber, decoration: const InputDecoration(labelText: 'Batch number (optional)')),
              TextButton(
                onPressed: () async {
                  final date = await showDatePicker(
                    context: context, firstDate: DateTime.now(),
                    lastDate: DateTime(2100), initialDate: expiry ?? DateTime.now(),
                  );
                  if (date != null) update(() => expiry = date);
                },
                child: Text(expiry == null ? 'Set expiration (optional)' : 'Expires: ${expiry!.toIso8601String().split('T').first}'),
              ),
            ],
          ))),
          actions: [
            TextButton(onPressed: () => Navigator.pop(context, false), child: const Text('Cancel')),
            FilledButton(
              onPressed: productId == null || unitId == null ||
                  (num.tryParse(quantity.text) ?? 0) <= 0 ||
                  int.tryParse(cost.text) == null
                  ? null : () => Navigator.pop(context, true),
              child: const Text('Receive'),
            ),
          ],
        );
      }),
    );
    if (accepted == true && mounted) {
      await _run(() async {
        await _store.enqueue('receipt', {
          'productId': productId!,
          'receivedProductUnitId': unitId!,
          'receivedQuantity': num.parse(quantity.text),
          'unitCostBase': int.parse(cost.text),
          'batchNumber': batchNumber.text.trim().isEmpty ? null : batchNumber.text.trim(),
          'expirationDate': expiry?.toUtc().toIso8601String(),
        });
      }, queued: true);
    }
    quantity.dispose(); cost.dispose(); batchNumber.dispose();
  }

  Future<void> _batchActions(_StockData data, StockJson batch) async {
    final choice = await showModalBottomSheet<String>(
      context: context,
      builder: (context) => SafeArea(child: Column(mainAxisSize: MainAxisSize.min, children: [
        for (final option in ['adjustments', 'damaged-stock', 'expired-stock',
          'customer-returns', 'supplier-returns', 'transfers', 'edit'])
          ListTile(title: Text(option.replaceAll('-', ' ')),
            onTap: () => Navigator.pop(context, option)),
      ])),
    );
    if (choice == null || !mounted) return;
    if (choice == 'edit') { await _editBatch(batch); return; }
    await _operation(data, batch, choice);
  }

  Future<void> _editBatch(StockJson batch) async {
    final number = TextEditingController(text: stockText(batch, 'batchNumber'));
    String status = stockText(batch, 'status');
    DateTime? expiry = DateTime.tryParse(stockText(batch, 'expirationDate'));
    final accepted = await showDialog<bool>(context: context, builder: (context) =>
      StatefulBuilder(builder: (context, update) => AlertDialog(
        title: const Text('Edit batch details'),
        content: Column(mainAxisSize: MainAxisSize.min, children: [
          TextField(controller: number, decoration: const InputDecoration(labelText: 'Batch number')),
          DropdownButtonFormField<String>(
            initialValue: ['active', 'inactive', 'cancelled'].contains(status) ? status : null,
            items: ['active', 'inactive', 'cancelled'].map((s) =>
              DropdownMenuItem(value: s, child: Text(s))).toList(),
            onChanged: (value) => update(() => status = value ?? status),
          ),
          TextButton(onPressed: () async {
            final date = await showDatePicker(
              context: context, firstDate: DateTime(2000), lastDate: DateTime(2100),
              initialDate: expiry ?? DateTime.now(),
            );
            if (date != null) update(() => expiry = date);
          }, child: Text(expiry == null ? 'Set expiration' : 'Expires: ${expiry!.toIso8601String().split('T').first}')),
        ]),
        actions: [
          TextButton(onPressed: () => Navigator.pop(context, false), child: const Text('Cancel')),
          FilledButton(onPressed: () => Navigator.pop(context, true), child: const Text('Save')),
        ],
      )),
    );
    if (accepted == true && mounted) {
      await _run(() async {
        await _store.enqueue('batch-update', {
          'batchId': stockText(batch, 'id'),
          'batchNumber': number.text.trim(),
          'status': status,
          'expirationDate': expiry?.toUtc().toIso8601String(),
        });
      }, queued: true);
    }
    number.dispose();
  }

  Future<void> _operation(_StockData data, StockJson batch, String path) async {
    final units = data.units.where((u) =>
        u.productId == stockText(batch, 'productId') &&
        u.syncStatus == ProductUnitSyncStatus.synced).toList();
    if (units.isEmpty) {
      AppErrorNotification.show(context, const ValidationException('Configure a product unit first.'));
      return;
    }
    String unitId = units.first.id;
    String direction = 'in';
    String? destination;
    final quantity = TextEditingController();
    final accepted = await showDialog<bool>(context: context, builder: (context) =>
      StatefulBuilder(builder: (context, update) => AlertDialog(
        title: Text(path.replaceAll('-', ' ')),
        content: Column(mainAxisSize: MainAxisSize.min, children: [
          Text('Available: ${stockNumber(batch, 'remainingQuantityBase')} base units'),
          DropdownButtonFormField<String>(
            initialValue: unitId,
            items: units.map((u) => DropdownMenuItem(
              value: u.id, child: Text(data.unitLabel(u)),
            )).toList(),
            onChanged: (value) => update(() => unitId = value ?? unitId),
          ),
          TextField(controller: quantity, onChanged: (_) => update(() {}),
            decoration: const InputDecoration(labelText: 'Quantity in selected unit'),
            keyboardType: const TextInputType.numberWithOptions(decimal: true)),
          if (path == 'adjustments')
            DropdownButtonFormField<String>(
              initialValue: direction,
              items: const [DropdownMenuItem(value: 'in', child: Text('Increase')),
                DropdownMenuItem(value: 'out', child: Text('Decrease'))],
              onChanged: (value) => update(() => direction = value ?? direction),
            ),
          if (path == 'transfers')
            DropdownButtonFormField<String>(
              initialValue: destination,
              decoration: const InputDecoration(labelText: 'Destination batch'),
              items: data.batches.where((b) =>
                stockText(b, 'id') != stockText(batch, 'id') &&
                stockText(b, 'productId') == stockText(batch, 'productId'))
                .map((b) => DropdownMenuItem(
                  value: stockText(b, 'id'),
                  child: Text(stockText(b, 'batchNumber').isEmpty
                      ? stockText(b, 'id') : stockText(b, 'batchNumber')),
                )).toList(),
              onChanged: (value) => update(() => destination = value),
            ),
        ]),
        actions: [
          TextButton(onPressed: () => Navigator.pop(context, false), child: const Text('Cancel')),
          FilledButton(
            onPressed: (num.tryParse(quantity.text) ?? 0) <= 0 ||
                (path == 'transfers' && destination == null)
                ? null : () => Navigator.pop(context, true),
            child: const Text('Post movement'),
          ),
        ],
      )),
    );
    if (accepted == true && mounted) {
      final kind = switch (path) {
        'transfers' => 'transfer',
        'adjustments' => 'adjustment',
        'damaged-stock' => 'damage',
        'expired-stock' => 'expiration',
        'customer-returns' => 'customer-return',
        'supplier-returns' => 'supplier-return',
        _ => throw StateError('Unsupported stock operation: $path'),
      };
      await _run(() async {
        await _store.enqueue(kind, path == 'transfers'
            ? {
                'sourceStockBatchId': stockText(batch, 'id'),
                'destinationStockBatchId': destination!,
                'productUnitId': unitId,
                'quantityEntered': num.parse(quantity.text),
              }
            : {
                'stockBatchId': stockText(batch, 'id'),
                'productUnitId': unitId,
                'quantityEntered': num.parse(quantity.text),
                if (path == 'adjustments') 'direction': direction,
              });
      }, queued: true);
    }
    quantity.dispose();
  }

  Future<void> _startCount(_StockData data) async {
    await _run(() async {
      final session = await _api.startCount(
        data.batches.where((b) => stockText(b, 'status') != 'cancelled')
            .map((b) => stockText(b, 'id')).toList(),
      );
      _countId = stockText(session, 'id');
      await _store.cacheCount(session);
      await _storage.write(key: _countStorageKey, value: _countId);
    });
    if (_countId != null && _countId!.isNotEmpty && mounted) {
      await _openCount(_countId!);
    }
  }

  Future<void> _openCount(String id) async {
    try {
      final session = await _store.cachedObject('count/' + id) ??
          await _api.getCount(id);
      if (!mounted) return;
      final lines = (session['lines'] as List? ?? []).map((e) => Map<String, dynamic>.from(e as Map)).toList();
      final controllers = [
        for (final line in lines)
          TextEditingController(text: stockNumber(line, 'expectedQuantityBase').toString()),
      ];
      final choice = await showDialog<String>(context: context, builder: (context) =>
        AlertDialog(
          title: const Text('Physical stock count (base units)'),
          content: SizedBox(width: 450, height: 400, child: ListView.builder(
            itemCount: lines.length,
            itemBuilder: (context, index) => TextField(
              controller: controllers[index],
              keyboardType: const TextInputType.numberWithOptions(decimal: true),
              decoration: InputDecoration(
                labelText: stockText(lines[index], 'productName'),
                helperText: 'Expected: ${stockNumber(lines[index], 'expectedQuantityBase')}',
              ),
            ),
          )),
          actions: [
            TextButton(onPressed: () => Navigator.pop(context, 'cancel'), child: const Text('Cancel count')),
            TextButton(onPressed: () => Navigator.pop(context), child: const Text('Keep draft')),
            FilledButton(onPressed: () => Navigator.pop(context, 'complete'), child: const Text('Complete')),
          ],
        ),
      );
      if (choice == 'complete' && mounted) {
        final values = controllers.map((c) => num.tryParse(c.text.trim())).toList();
        if (values.any((v) => v == null || v < 0)) {
          AppErrorNotification.show(context, const ValidationException('Enter a non-negative count for every batch.'));
        } else {
          final saved = await _run(() async {
            await _store.enqueue('count-complete', {
              'sessionId': id,
              'counts': [
                for (var i = 0; i < lines.length; i++)
                  {'stockBatchId': lines[i]['stockBatchId'], 'countedQuantityBase': values[i]},
              ],
            });
          }, queued: true);
          if (saved) {
            _countId = null;
            await _storage.delete(key: _countStorageKey);
          }
        }
      } else if (choice == 'cancel' && mounted) {
        final confirmed = await showDialog<bool>(context: context,
          builder: (context) => AlertDialog(
            title: const Text('Cancel stock count?'),
            content: const Text('The draft count will be discarded without changing stock.'),
            actions: [
              TextButton(onPressed: () => Navigator.pop(context, false), child: const Text('Keep draft')),
              FilledButton(onPressed: () => Navigator.pop(context, true), child: const Text('Cancel count')),
            ],
          ),
        );
        if (confirmed == true) {
          final cancelled = await _run(() => _api.cancelCount(id));
          if (cancelled) {
            _countId = null;
            await _storage.delete(key: _countStorageKey);
          }
        }
      }
      for (final controller in controllers) { controller.dispose(); }
    } catch (error, stackTrace) {
      if (mounted) AppErrorNotification.show(context, error, stackTrace);
    }
  }

  Future<void> _movementActions(StockJson movement) async {
    final confirm = await showDialog<bool>(context: context, builder: (context) =>
      AlertDialog(
        title: const Text('Reverse movement?'),
        content: const Text('Only eligible standalone inventory movements can be reversed. The original remains in the ledger.'),
        actions: [
          TextButton(onPressed: () => Navigator.pop(context, false), child: const Text('Cancel')),
          FilledButton(onPressed: () => Navigator.pop(context, true), child: const Text('Reverse')),
        ],
      ));
    if (confirm == true && mounted) {
      await _run(() async {
        await _store.enqueue('reverse', {
          'movementId': stockText(movement, 'id'),
        });
      }, queued: true);
    }
  }
}

class _StockData {
  const _StockData({
    required this.batches, required this.products, required this.units,
    required this.measures, required this.hasCache, required this.pending,
    required this.report, required this.movements,
  });
  final bool hasCache;
  final List<PendingStockCommand> pending;
  final List<StockJson> batches;
  final List<Product> products;
  final List<ProductUnit> units;
  final List<UnitOfMeasure> measures;
  final Object? report;
  final List<StockJson> movements;

  Product? product(String id) {
    for (final item in products) {
      if (item.id == id) return item;
    }
    return null;
  }

  String unitLabel(ProductUnit unit) {
    for (final measure in measures) {
      if (measure.id == unit.unitOfMeasureId) {
        return '${measure.name} (×${unit.baseUnitQuantity})';
      }
    }
    return '${unit.unitOfMeasureId} (×${unit.baseUnitQuantity})';
  }
}
