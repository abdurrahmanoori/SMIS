import 'dart:convert';

import 'package:powersync/powersync.dart';
import 'package:uuid/uuid.dart';

import 'data_exception.dart';
import 'purchase_order_offline_store.dart';
import 'supplier_finance_api.dart';

class SupplierPayableBalance {
  const SupplierPayableBalance({
    required this.id,
    required this.purchaseOrderId,
    required this.totalAmount,
    required this.creditAmount,
    required this.paidAmount,
  });

  final String id;
  final String purchaseOrderId;
  final int totalAmount;
  final int creditAmount;
  final int paidAmount;
  // Split a signed balance into debt and supplier credit so neither is shown
  // as a negative amount in the UI.
  int get remaining {
    final value = totalAmount - creditAmount - paidAmount;
    return value < 0 ? 0 : value;
  }
  int get creditDue {
    final value = paidAmount + creditAmount - totalAmount;
    return value < 0 ? 0 : value;
  }
}

class SupplierFinanceSnapshot {
  const SupplierFinanceSnapshot({
    required this.payables,
    required this.payments,
    required this.pendingPayments,
  });

  final List<SupplierPayableBalance> payables;
  final List<Map<String, dynamic>> payments;
  final List<Map<String, dynamic>> pendingPayments;
  int get outstanding => payables.fold(0, (sum, p) => sum + p.remaining);
  int get supplierCredit => payables.fold(0, (sum, p) => sum + p.creditDue);
}

/// Local command outbox; payment balances are NEVER edited in SQLite.
/// Post only when earlier purchase-order commands have cleared the queue.
class SupplierFinanceOfflineStore {
  SupplierFinanceOfflineStore(this._database, this._api, this._purchaseOrders);

  final Future<PowerSyncDatabase> Function() _database;
  final SupplierFinanceApi _api;
  final PurchaseOrderOfflineStore _purchaseOrders;
  static const _uuid = Uuid();
  Future<void>? _syncFuture;
  Object? lastSyncError;

  Future<void> enqueuePayment(
    String supplierId, {
    required int amount,
    required String paymentMethod,
    String? referenceNumber,
    String? notes,
  }) async {
    if (amount <= 0 || paymentMethod.trim().isEmpty) {
      throw ArgumentError('A positive amount and payment method are required.');
    }
    final id = _uuid.v4();
    final db = await _database();
    // The outbox row ID is also the API idempotency key. Retries must reuse it
    // even when a successful server response never reached this device.
    final payload = {
      'amount': amount,
      'paymentMethod': paymentMethod.trim(),
      'paidAtUtc': DateTime.now().toUtc().toIso8601String(),
      'referenceNumber': referenceNumber,
      'notes': notes,
      'idempotencyKey': id,
    };
    await db.execute(
      'INSERT INTO supplier_finance_outbox '
      '(id, supplier_id, kind, payload, created_at_utc, state) '
      'VALUES (?, ?, ?, ?, ?, ?)',
      [id, supplierId, 'payment', jsonEncode(payload),
        DateTime.now().toUtc().toIso8601String(), 'pending'],
    );
  }

  Future<int> pendingCount() async {
    final db = await _database();
    final row = await db.get('SELECT COUNT(*) AS count FROM supplier_finance_outbox');
    return row['count'] as int;
  }

  Future<int> retryableCount() async {
    final db = await _database();
    final row = await db.get(
      'SELECT COUNT(*) AS count FROM supplier_finance_outbox WHERE state = ?',
      ['pending'],
    );
    return row['count'] as int;
  }

  Future<void> retry(String id) async {
    final db = await _database();
    await db.execute(
      'UPDATE supplier_finance_outbox SET state = ?, error = NULL WHERE id = ?',
      ['pending', id],
    );
    await syncNow();
  }

  Future<void> discard(String id) async {
    final db = await _database();
    await db.execute(
      'DELETE FROM supplier_finance_outbox WHERE id = ? AND state = ?',
      [id, 'failed'],
    );
  }

  Future<SupplierFinanceSnapshot> snapshot(String shopId, String supplierId) async {
    final db = await _database();
    // Read only confirmed PowerSync rows. Local pending payments are shown
    // separately instead of prematurely reducing the authoritative balance.
    final payableRows = await db.getAll(
      'SELECT p.id, p.purchase_order_id, p.total_amount, p.credit_amount, '
      '(SELECT COALESCE(SUM(a.amount), 0) FROM supplier_payment_allocation a '
      'WHERE a.supplier_payable_id = p.id) AS paid_amount '
      'FROM supplier_payable p WHERE p.shop_id = ? AND p.supplier_id = ? '
      'ORDER BY p.id',
      [shopId, supplierId],
    );
    final payments = await db.getAll(
      'SELECT id, amount, paid_at_utc, payment_method, reference_number, notes '
      'FROM supplier_payment WHERE shop_id = ? AND supplier_id = ? '
      'ORDER BY paid_at_utc DESC',
      [shopId, supplierId],
    );
    final outboxRows = await db.getAll(
      'SELECT id, payload, state, error FROM supplier_finance_outbox '
      'WHERE supplier_id = ? ORDER BY created_at_utc DESC',
      [supplierId],
    );
    return SupplierFinanceSnapshot(
      payables: payableRows.map((p) => SupplierPayableBalance(
        id: p['id'] as String,
        purchaseOrderId: p['purchase_order_id'] as String,
        totalAmount: (p['total_amount'] as num).toInt(),
        creditAmount: (p['credit_amount'] as num).toInt(),
        paidAmount: (p['paid_amount'] as num).toInt(),
      )).toList(),
      payments: payments.map((p) => Map<String, dynamic>.from(p)).toList(),
      pendingPayments: outboxRows.map((p) => {
        'id': p['id'], 'state': p['state'], 'error': p['error'],
        ...Map<String, dynamic>.from(jsonDecode(p['payload'] as String) as Map),
      }).toList(),
    );
  }

  // Coalesce concurrent retry triggers into a single in-flight upload pass.
  Future<void> syncNow() =>
      _syncFuture ??= _sync().whenComplete(() => _syncFuture = null);

  Future<void> _sync() async {
    lastSyncError = null;
    try {
      // Purchase receipts create debt on the server. Payments must not race them.
      if (await _purchaseOrders.pendingCount() > 0) return;
      final db = await _database();
      final rows = await db.getAll(
        'SELECT id, supplier_id, kind, payload, state FROM supplier_finance_outbox '
        'ORDER BY created_at_utc, id',
      );
      // A failed payment blocks later commands for that supplier. Other
      // suppliers can still progress without reordering this supplier's history.
      final blockedSuppliers = <String>{};
      for (final row in rows) {
        final supplierId = row['supplier_id'] as String;
        if (row['state'] != 'pending' || blockedSuppliers.contains(supplierId)) {
          if (row['state'] == 'failed') blockedSuppliers.add(supplierId);
          continue;
        }
        try {
          if (row['kind'] != 'payment') throw StateError('Unknown finance command');
          await _api.sendPayment(
            supplierId,
            Map<String, dynamic>.from(jsonDecode(row['payload'] as String) as Map),
          );
          await db.execute(
            'DELETE FROM supplier_finance_outbox WHERE id = ?', [row['id']],
          );
        } on AuthenticationException {
          rethrow;
        } on RemotePermanentException catch (error) {
          // Keep rejected commands visible for explicit retry/discard.
          // Removing them silently could hide a missed supplier payment.
          await db.execute(
            'UPDATE supplier_finance_outbox SET state = ?, error = ? WHERE id = ?',
            ['failed', error.message, row['id']],
          );
          blockedSuppliers.add(supplierId);
        } catch (_) {
          blockedSuppliers.add(supplierId);
          rethrow;
        }
      }
    } catch (error) {
      lastSyncError = error;
      rethrow;
    }
  }
}
