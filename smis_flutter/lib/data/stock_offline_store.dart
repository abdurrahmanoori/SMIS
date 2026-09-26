import 'dart:convert';

import 'package:powersync/powersync.dart';
import 'package:uuid/uuid.dart';

import 'data_exception.dart';
import 'stock_api.dart';

class PendingStockCommand {
  const PendingStockCommand({
    required this.id,
    required this.kind,
    required this.payload,
    required this.state,
    this.error,
  });

  final String id;
  final String kind;
  final StockJson payload;
  final String state;
  final String? error;
}

/// Uses local-only PowerSync tables. Stock writes never mutate confirmed balances:
/// the server validates them and the next refresh replaces cached snapshots.
class StockOfflineStore {
  StockOfflineStore(this._database, this._api);

  final Future<PowerSyncDatabase> Function() _database;
  final StockApi _api;
  Future<void>? _syncFuture;
  Object? lastSyncError;
  static const _uuid = Uuid();

  Future<String> enqueue(String kind, StockJson payload) async {
    final id = _uuid.v4();
    final db = await _database();
    final body = Map<String, dynamic>.from(payload)
      ..['idempotencyKey'] = id;
    await db.execute(
      'INSERT INTO stock_outbox (id, kind, payload, created_at_utc, state) '
      'VALUES (?, ?, ?, ?, ?)',
      [id, kind, jsonEncode(body), DateTime.now().toUtc().toIso8601String(),
        'pending'],
    );
    return id;
  }

  Future<List<PendingStockCommand>> pending() async {
    final db = await _database();
    return _pending(db);
  }

  Future<List<PendingStockCommand>> _pending(PowerSyncDatabase db) async {
    final rows = await db.getAll(
      'SELECT id, kind, payload, state, error FROM stock_outbox '
      'ORDER BY created_at_utc, id',
    );
    return rows.map((row) => PendingStockCommand(
      id: row['id'] as String,
      kind: row['kind'] as String,
      payload: Map<String, dynamic>.from(jsonDecode(row['payload'] as String) as Map),
      state: row['state'] as String,
      error: row['error'] as String?,
    )).toList();
  }

  Future<int> pendingCount() async {
    final db = await _database();
    final row = await db.get(
      'SELECT COUNT(*) AS count FROM stock_outbox',
    );
    return row['count'] as int;
  }

  Future<void> retry(String id) async {
    final db = await _database();
    await db.execute(
      'UPDATE stock_outbox SET state = ?, error = NULL WHERE id = ?',
      ['pending', id],
    );
    final active = _syncFuture;
    if (active != null) {
      try { await active; } catch (_) { /* The next attempt reports its result. */ }
    }
    await syncNow();
  }

  Future<void> discard(String id) async {
    final db = await _database();
    await db.execute('DELETE FROM stock_outbox WHERE id = ? AND state = ?', [
      id, 'failed',
    ]);
  }

  Future<List<StockJson>?> cachedList(String name) async {
    final value = await _cached(name);
    return value == null
        ? null
        : (value as List).map((item) =>
            Map<String, dynamic>.from(item as Map)).toList();
  }

  Future<StockJson?> cachedObject(String name) async {
    final value = await _cached(name);
    return value == null ? null : Map<String, dynamic>.from(value as Map);
  }

  Future<void> cacheCount(StockJson session) =>
      _cacheCount(session);

  Future<void> _cacheCount(StockJson session) async {
    final db = await _database();
    await _cache(db, 'count/' + (session['id'] as String), session);
  }

  Future<Object?> _cached(String name) async {
    final db = await _database();
    final row = await db.getOptional(
      'SELECT payload FROM stock_cache WHERE id = ?', [name],
    );
    return row == null ? null : jsonDecode(row['payload'] as String);
  }

  Future<void> _cache(PowerSyncDatabase db, String name, Object value) async {
    await db.execute(
      'INSERT OR REPLACE INTO stock_cache (id, payload, cached_at_utc) '
      'VALUES (?, ?, ?)',
      [name, jsonEncode(value), DateTime.now().toUtc().toIso8601String()],
    );
  }

  Future<void> syncNow() => _syncFuture ??= _sync().whenComplete(
    () => _syncFuture = null,
  );

  Future<void> _sync() async {
    lastSyncError = null;
    try {
      final db = await _database();
      for (final command in await _pending(db)) {
        if (command.state != 'pending') continue;
        try {
          await _api.sendQueued(command.kind, command.payload);
          await db.execute('DELETE FROM stock_outbox WHERE id = ?', [command.id]);
        } on AuthenticationException {
          rethrow;
        } on RemotePermanentException catch (error) {
          await db.execute(
            'UPDATE stock_outbox SET state = ?, error = ? WHERE id = ?',
            ['failed', error.message, command.id],
          );
        }
      }

      await _cache(db, 'batches', await _api.batches());
      await _cache(db, 'movements', await _api.report('movements',
        query: {'limit': 250}));
      for (final name in ['current-stock', 'low-stock', 'expiring', 'expired']) {
        await _cache(db, name, await _api.report(name));
      }
      await _cache(db, 'valuation', await _api.valuation());
      await _cache(db, 'reconciliation', await _api.reconciliation());
    } catch (error) {
      lastSyncError = error;
      rethrow;
    }
  }
}
