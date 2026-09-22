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
  String? _databaseContextKey;
  String? _connectedContextKey;
  Future<void>? _switchFuture;

  Future<PowerSyncDatabase> databaseForCurrentSession() async {
    final session = await _sessionStore.read();
    if (session == null) throw StateError('User is not authenticated.');
    final contextKey = _contextKey(session.userId, session.shopId);
    if (_database != null && _databaseContextKey == contextKey) {
      return _database!;
    }

    await (_switchFuture ??= _switchToUser(
      session.userId,
      session.shopId,
    )).whenComplete(() => _switchFuture = null);
    return _database!;
  }

  Future<PowerSyncDatabase> connectForCurrentSession() async {
    final session = await _sessionStore.read();
    if (session == null) throw StateError('User is not authenticated.');
    final database = await databaseForCurrentSession();
    final contextKey = _contextKey(session.userId, session.shopId);
    if (_connectedContextKey == contextKey) return database;

    final authApi = PowerSyncAuthApi(sessionStore: _sessionStore);
    final writeApi = AppPowerSyncWriteApi(sessionStore: _sessionStore);
    await database.connect(
      connector: AppPowerSyncConnector(_sessionStore, authApi, writeApi),
    );
    _connectedContextKey = contextKey;
    return database;
  }

  Future<int> pendingCountForCurrentContext() async {
    final database = await databaseForCurrentSession();
    return (await database.getUploadQueueStats()).count;
  }

  Future<void> _switchToUser(String userId, String shopId) async {
    final existing = _database;
    if (existing != null) await existing.close();

    final contextKey = _contextKey(userId, shopId);
    final fileName = 'smis_powersync_$contextKey.db';
    final path = kIsWeb
        ? fileName
        : p.join((await getApplicationSupportDirectory()).path, fileName);
    final database = PowerSyncDatabase(schema: appPowerSyncSchema, path: path);
    await database.initialize();
    await _repairMissingProductCategories(database);
    _database = database;
    _databaseContextKey = contextKey;
    _connectedContextKey = null;
  }

  String _contextKey(String userId, String shopId) =>
      '${userId}_$shopId'.replaceAll(RegExp(r'[^A-Za-z0-9_-]'), '_');

  Future<void> _repairMissingProductCategories(
    PowerSyncDatabase database,
  ) async {
    await database.execute(
      'UPDATE product '
      'SET category_id = ('
      'SELECT category.id FROM category '
      'WHERE category.shop_id = product.shop_id '
      'ORDER BY RANDOM() LIMIT 1'
      ') '
      'WHERE category_id IS NULL '
      'AND EXISTS ('
      'SELECT 1 FROM category WHERE category.shop_id = product.shop_id'
      ')',
    );

    final unresolved = await database.get(
      'SELECT COUNT(*) AS count FROM product WHERE category_id IS NULL',
    );
    if ((unresolved['count'] as int) > 0) {
      throw StateError(
        'Every product requires a category, but at least one local product '
        'belongs to a shop with no available category.',
      );
    }
  }

  Future<void> close() async {
    await _database?.close();
    _database = null;
    _databaseContextKey = null;
    _connectedContextKey = null;
  }
}
