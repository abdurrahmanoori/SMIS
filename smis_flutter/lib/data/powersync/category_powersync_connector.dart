import 'package:powersync/powersync.dart';

import '../../services/auth_session_store.dart';
import 'category_powersync_write_api.dart';
import 'powersync_auth_api.dart';

class CategoryPowerSyncConnector extends PowerSyncBackendConnector {
  CategoryPowerSyncConnector(this._sessionStore, this._authApi, this._writeApi);

  final AuthSessionStore _sessionStore;
  final PowerSyncAuthApi _authApi;
  final CategoryPowerSyncWriteApi _writeApi;

  @override
  Future<PowerSyncCredentials?> fetchCredentials() async {
    final session = await _sessionStore.read();
    if (session == null) return null;

    final credentials = await _authApi.fetchCredentials();

    return PowerSyncCredentials(
      endpoint: credentials.endpoint,
      token: credentials.token,
      userId: session.userId,
      expiresAt: credentials.expiresAtUtc,
    );
  }

  @override
  Future<void> uploadData(PowerSyncDatabase database) async {
    final transaction = await database.getNextCrudTransaction();
    if (transaction == null) return;

    for (final operation in transaction.crud) {
      if (operation.table != 'category') {
        throw StateError(
          'Unexpected PowerSync upload table: ${operation.table}.',
        );
      }

      switch (operation.op) {
        case UpdateType.put:
          final row = await _currentRow(database, operation.id);
          await _writeApi.create(operation.id, row);
        case UpdateType.patch:
          final row = await _currentRow(database, operation.id);
          await _writeApi.update(operation.id, row);
        case UpdateType.delete:
          await _writeApi.delete(operation.id);
      }
    }

    // A transaction is removed from the local upload queue only after every
    // API request above succeeds. Throwing leaves it queued for PowerSync retry.
    await transaction.complete();
  }

  Future<Map<String, dynamic>> _currentRow(
    PowerSyncDatabase database,
    String id,
  ) async {
    final row = await database.getOptional(
      'SELECT name, code, description, is_active, shop_id '
      'FROM category WHERE id = ?',
      [id],
    );

    if (row == null) {
      throw StateError(
        'Category $id no longer exists in local PowerSync data.',
      );
    }

    return Map<String, dynamic>.from(row);
  }
}
