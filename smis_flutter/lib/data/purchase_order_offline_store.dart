import 'dart:convert';

import 'package:powersync/powersync.dart';
import 'package:uuid/uuid.dart';

import '../models/purchase_order.dart';
import 'data_exception.dart';
import 'purchase_order_api.dart';

class PendingPurchaseOrderCommand {
  const PendingPurchaseOrderCommand({
    required this.id,
    required this.aggregateId,
    required this.kind,
    required this.payload,
    required this.state,
    this.error,
  });

  final String id;
  final String aggregateId;
  final String kind;
  final Map<String, dynamic> payload;
  final String state;
  final String? error;
}

/// Purchase-order writes are business commands, not independent row uploads.
/// Confirmed aggregate state is downloaded by PowerSync; this local outbox keeps
/// commands ordered per purchase order and retries them with stable idempotency keys.
class PurchaseOrderOfflineStore {
  PurchaseOrderOfflineStore(this._database, this._api);

  final Future<PowerSyncDatabase> Function() _database;
  final PurchaseOrderApi _api;
  Future<void>? _syncFuture;
  Object? lastSyncError;
  static const _uuid = Uuid();

  Future<String> enqueueCreate(Map<String, dynamic> payload) async {
    final aggregateId = (payload['id'] as String?) ?? _uuid.v4();
    final lines = (payload['lines'] as List<dynamic>? ?? const []).map((item) {
      final line = Map<String, dynamic>.from(item as Map);
      line['id'] ??= _uuid.v4();
      return line;
    }).toList();

    return _enqueue(aggregateId, 'create', {
      ...payload,
      'id': aggregateId,
      'lines': lines,
    });
  }

  Future<String> enqueue(
    String aggregateId,
    String kind,
    Map<String, dynamic> payload,
  ) => _enqueue(aggregateId, kind, payload);

  Future<String> _enqueue(
    String aggregateId,
    String kind,
    Map<String, dynamic> payload,
  ) async {
    final id = _uuid.v4();
    final db = await _database();
    final body = Map<String, dynamic>.from(payload)
      ..['idempotencyKey'] = payload['idempotencyKey'] ?? id;
    await db.execute(
      'INSERT INTO purchase_order_outbox '
      '(id, aggregate_id, kind, payload, created_at_utc, state) '
      'VALUES (?, ?, ?, ?, ?, ?)',
      [
        id,
        aggregateId,
        kind,
        jsonEncode(body),
        DateTime.now().toUtc().toIso8601String(),
        'pending',
      ],
    );
    return id;
  }

  Future<List<PendingPurchaseOrderCommand>> pending() async {
    final db = await _database();
    return _pending(db);
  }

  Future<List<PendingPurchaseOrderCommand>> _pending(
    PowerSyncDatabase db,
  ) async {
    final rows = await db.getAll(
      'SELECT id, aggregate_id, kind, payload, state, error '
      'FROM purchase_order_outbox ORDER BY created_at_utc, id',
    );
    return rows
        .map(
          (row) => PendingPurchaseOrderCommand(
            id: row['id'] as String,
            aggregateId: row['aggregate_id'] as String,
            kind: row['kind'] as String,
            payload: Map<String, dynamic>.from(
              jsonDecode(row['payload'] as String) as Map,
            ),
            state: row['state'] as String,
            error: row['error'] as String?,
          ),
        )
        .toList(growable: false);
  }

  Future<int> pendingCount() async {
    final db = await _database();
    final row = await db.get(
      'SELECT COUNT(*) AS count FROM purchase_order_outbox',
    );
    return row['count'] as int;
  }

  Future<int> retryableCount() async {
    final db = await _database();
    final row = await db.get(
      'SELECT COUNT(*) AS count FROM purchase_order_outbox WHERE state = ?',
      ['pending'],
    );
    return row['count'] as int;
  }

  Future<void> retry(String id) async {
    final db = await _database();
    await db.execute(
      'UPDATE purchase_order_outbox SET state = ?, error = NULL WHERE id = ?',
      ['pending', id],
    );
    await syncNow();
  }

  Future<void> discard(String id) async {
    final db = await _database();
    await db.execute(
      'DELETE FROM purchase_order_outbox WHERE id = ? AND state = ?',
      [id, 'failed'],
    );
  }

  Future<List<PurchaseOrder>> list(String shopId) async {
    final db = await _database();
    final orders = await db.getAll(
      'SELECT po.id, po.shop_id, po.supplier_id, s.name AS supplier_name, '
      'po.reference_number, po.ordered_at_utc, po.status, po.notes '
      'FROM purchase_order po '
      'LEFT JOIN supplier s ON s.id = po.supplier_id '
      'WHERE po.shop_id = ? ORDER BY po.ordered_at_utc DESC',
      [shopId],
    );

    final result = <PurchaseOrder>[];
    for (final order in orders) {
      final orderId = order['id'] as String;
      final lineRows = await db.getAll(
        'SELECT pol.id, pol.product_id, p.name AS product_name, '
        'pol.product_unit_id, pol.ordered_quantity_entered, '
        'pol.received_quantity_entered, pol.returned_quantity_entered, '
        'pol.unit_cost_base FROM purchase_order_line pol '
        'LEFT JOIN product p ON p.id = pol.product_id '
        'WHERE pol.purchase_order_id = ? ORDER BY pol.id',
        [orderId],
      );
      final lines = lineRows
          .map(
            (line) => PurchaseOrderLine(
              id: line['id'] as String,
              productId: line['product_id'] as String,
              productName: line['product_name'] as String? ?? '',
              productUnitId: line['product_unit_id'] as String,
              orderedQuantity: (line['ordered_quantity_entered'] as num)
                  .toDouble(),
              receivedQuantity: (line['received_quantity_entered'] as num)
                  .toDouble(),
              returnedQuantity: (line['returned_quantity_entered'] as num)
                  .toDouble(),
              remainingQuantity:
                  (line['ordered_quantity_entered'] as num).toDouble() -
                  (line['received_quantity_entered'] as num).toDouble(),
              netReceivedQuantity:
                  (line['received_quantity_entered'] as num).toDouble() -
                  (line['returned_quantity_entered'] as num).toDouble(),
              unitCostBase: (line['unit_cost_base'] as num).toInt(),
            ),
          )
          .toList(growable: false);

      result.add(
        PurchaseOrder(
          id: orderId,
          shopId: order['shop_id'] as String,
          supplierId: order['supplier_id'] as String,
          supplierName: order['supplier_name'] as String? ?? '',
          orderedAtUtc: DateTime.parse(order['ordered_at_utc'] as String),
          status: (order['status'] ?? '').toString(),
          referenceNumber: order['reference_number'] as String?,
          notes: order['notes'] as String?,
          lines: lines,
        ),
      );
    }
    return result;
  }

  Future<void> syncNow() =>
      _syncFuture ??= _sync().whenComplete(() => _syncFuture = null);

  Future<void> _sync() async {
    lastSyncError = null;
    try {
      final db = await _database();
      final commands = await _pending(db);
      final blockedAggregates = <String>{};

      for (final command in commands) {
        if (command.state != 'pending' ||
            blockedAggregates.contains(command.aggregateId)) {
          continue;
        }

        try {
          await _api.sendQueued(
            command.kind,
            command.aggregateId,
            command.payload,
          );
          await db.execute('DELETE FROM purchase_order_outbox WHERE id = ?', [
            command.id,
          ]);
        } on AuthenticationException {
          rethrow;
        } on RemotePermanentException catch (error) {
          await db.execute(
            'UPDATE purchase_order_outbox SET state = ?, error = ? WHERE id = ?',
            ['failed', error.message, command.id],
          );
          blockedAggregates.add(command.aggregateId);
        } catch (_) {
          // A transient failure keeps this command pending and prevents later
          // commands for the same aggregate from overtaking it.
          blockedAggregates.add(command.aggregateId);
          rethrow;
        }
      }
    } catch (error) {
      lastSyncError = error;
      rethrow;
    }
  }
}
