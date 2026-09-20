import 'dart:convert';

import 'package:powersync/powersync.dart';

import 'app_powersync_database.dart';

abstract class PowerSyncRepositorySupport {
  PowerSyncRepositorySupport(this.powerSync);

  final AppPowerSyncDatabase powerSync;

  Future<PowerSyncDatabase> get database =>
      powerSync.connectForCurrentSession();

  Future<int> pendingCount(String table) async {
    final operations = await _pendingOperations(table);
    return operations.length;
  }

  Future<Map<String, String>> pendingOperations(String table) =>
      _pendingOperations(table);

  Future<Map<String, String>> _pendingOperations(String table) async {
    final db = await database;
    final rows = await db.getAll('SELECT data FROM ps_crud ORDER BY id');
    final result = <String, String>{};
    for (final row in rows) {
      final raw = row['data'];
      if (raw is! String) continue;
      final data = jsonDecode(raw);
      if (data is! Map<String, dynamic> || data['type'] != table) continue;
      final id = data['id']?.toString();
      final op = data['op']?.toString();
      if (id != null && op != null) result[id] = op;
    }
    return result;
  }

  DateTime timestamp(Object? value) {
    if (value is String) {
      final parsed = DateTime.tryParse(value);
      if (parsed != null) return parsed.toUtc();
    }
    return DateTime.fromMillisecondsSinceEpoch(0, isUtc: true);
  }

  String nowIso() => DateTime.now().toUtc().toIso8601String();
}
