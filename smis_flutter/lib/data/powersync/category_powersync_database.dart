import 'package:flutter/foundation.dart';
import 'package:path/path.dart' as p;
import 'package:path_provider/path_provider.dart';
import 'package:powersync/powersync.dart';

import '../../services/auth_session_store.dart';
import 'category_powersync_connector.dart';
import 'category_powersync_schema.dart';
import 'category_powersync_write_api.dart';
import 'powersync_auth_api.dart';

/// Owns the separate PowerSync database used only by Category during the POC.
/// Other SMIS entities continue using the existing sqflite database and custom
/// synchronization code until the approach has been validated.
class CategoryPowerSyncDatabase {
  CategoryPowerSyncDatabase(this._sessionStore);

  final AuthSessionStore _sessionStore;

  PowerSyncDatabase? _database;
  Future<PowerSyncDatabase>? _openFuture;
  bool _connectStarted = false;

  Future<PowerSyncDatabase> get database => _open();

  Future<PowerSyncDatabase> connectIfConfigured() async {
    final database = await _open();
    if (_connectStarted) return database;

    _connectStarted = true;
    try {
      final writeApi = CategoryPowerSyncWriteApi(sessionStore: _sessionStore);
      final authApi = PowerSyncAuthApi(sessionStore: _sessionStore);
      await database.connect(
        connector: CategoryPowerSyncConnector(_sessionStore, authApi, writeApi),
      );
    } catch (_) {
      _connectStarted = false;
      rethrow;
    }
    return database;
  }

  Future<PowerSyncDatabase> _open() {
    final existing = _database;
    if (existing != null) return Future.value(existing);
    return _openFuture ??= _create();
  }

  Future<PowerSyncDatabase> _create() async {
    final path = kIsWeb
        ? 'smis_powersync.db'
        : p.join(
            (await getApplicationSupportDirectory()).path,
            'smis_powersync.db',
          );

    final database = PowerSyncDatabase(
      schema: categoryPowerSyncSchema,
      path: path,
    );
    await database.initialize();
    _database = database;
    return database;
  }
}
