import 'package:flutter/foundation.dart';
import 'package:path/path.dart' as p;
import 'package:path_provider/path_provider.dart';
import 'package:powersync/powersync.dart';

import '../../services/auth_session_store.dart';
import 'app_powersync_connector.dart';
import 'app_powersync_schema.dart';
import 'app_powersync_write_api.dart';
import 'powersync_auth_api.dart';

class AppPowerSyncDatabase {
  AppPowerSyncDatabase(this._sessionStore);

  final AuthSessionStore _sessionStore;
  PowerSyncDatabase? _database;
  String? _databaseUserId;
  String? _connectedUserId;
  Future<void>? _switchFuture;

  Future<PowerSyncDatabase> databaseForCurrentSession() async {
    final session = await _sessionStore.read();
    if (session == null) throw StateError('User is not authenticated.');
    if (_database != null && _databaseUserId == session.userId) {
      return _database!;
    }

    await (_switchFuture ??= _switchToUser(
      session.userId,
    )).whenComplete(() => _switchFuture = null);
    return _database!;
  }

  Future<PowerSyncDatabase> connectForCurrentSession() async {
    final session = await _sessionStore.read();
    if (session == null) throw StateError('User is not authenticated.');
    final database = await databaseForCurrentSession();
    if (_connectedUserId == session.userId) return database;

    final authApi = PowerSyncAuthApi(sessionStore: _sessionStore);
    final writeApi = AppPowerSyncWriteApi(sessionStore: _sessionStore);
    await database.connect(
      connector: AppPowerSyncConnector(_sessionStore, authApi, writeApi),
    );
    _connectedUserId = session.userId;
    return database;
  }

  Future<void> _switchToUser(String userId) async {
    final existing = _database;
    if (existing != null) await existing.close();

    final fileName = 'smis_powersync_$userId.db';
    final path = kIsWeb
        ? fileName
        : p.join((await getApplicationSupportDirectory()).path, fileName);
    final database = PowerSyncDatabase(schema: appPowerSyncSchema, path: path);
    await database.initialize();
    _database = database;
    _databaseUserId = userId;
    _connectedUserId = null;
  }

  Future<void> close() async {
    await _database?.close();
    _database = null;
    _databaseUserId = null;
    _connectedUserId = null;
  }
}
