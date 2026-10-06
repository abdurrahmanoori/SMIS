import 'dart:convert';

import 'package:powersync/powersync.dart';

import '../../services/auth_session_store.dart';
import '../../services/date_time_service.dart';
import '../data_exception.dart';
import 'app_powersync_write_api.dart';
import 'powersync_auth_api.dart';

class AppPowerSyncConnector extends PowerSyncBackendConnector {
  AppPowerSyncConnector(
    this._sessionStore,
    this._authApi,
    this._writeApi,
    this._dateTimeService,
  );

  final AuthSessionStore _sessionStore;
  final PowerSyncAuthApi _authApi;
  final AppPowerSyncWriteApi _writeApi;
  final DateTimeService _dateTimeService;

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
      final table = operation.table;
      if (!_supportedTables.contains(table)) {
        throw StateError('Unexpected PowerSync upload table: $table');
      }

      try {
        switch (operation.op) {
          case UpdateType.put:
            final row = await _currentRow(database, table, operation.id);
            if (row != null) await _writeApi.create(table, operation.id, row);
          case UpdateType.patch:
            final row = await _currentRow(database, table, operation.id);
            if (row != null) await _writeApi.update(table, operation.id, row);
          case UpdateType.delete:
            final timestamp =
                operation.previousValues?['last_modified_utc']?.toString() ??
                _dateTimeService.nowUtc.toIso8601String();
            await _writeApi.delete(table, operation.id, timestamp);
        }

        await _clearSyncError(database, table, operation.id);
      } catch (error, stackTrace) {
        await _recordSyncError(
          database,
          table: table,
          recordId: operation.id,
          operation: operation.op.name,
          error: error,
        );
        Error.throwWithStackTrace(error, stackTrace);
      }
    }

    await transaction.complete();
  }

  Future<Map<String, dynamic>?> _currentRow(
    PowerSyncDatabase database,
    String table,
    String id,
  ) async {
    final row = await database.getOptional(
      'SELECT * FROM $table WHERE id = ?',
      [id],
    );
    return row == null ? null : Map<String, dynamic>.from(row);
  }

  Future<void> _recordSyncError(
    PowerSyncDatabase database, {
    required String table,
    required String recordId,
    required String operation,
    required Object error,
  }) async {
    final message = error is RemoteException
        ? error.serverMessages.join('\n')
        : error is AppException
        ? error.message
        : error.toString();

    final details = error is RemoteException
        ? jsonEncode({
            'statusCode': error.statusCode,
            'title': error.title,
            'detail': error.detail,
            'errors': error.errors.map((item) => item.toJson()).toList(),
            'traceId': error.traceId,
            'exceptionId': error.exceptionId,
          })
        : null;

    await database.execute(
      'INSERT OR REPLACE INTO sync_error '
      '(id, table_name, record_id, operation, message, details, created_at_utc) '
      'VALUES (?, ?, ?, ?, ?, ?, ?)',
      [
        '$table:$recordId',
        table,
        recordId,
        operation,
        message,
        details,
        _dateTimeService.nowUtc.toIso8601String(),
      ],
    );
  }

  Future<void> _clearSyncError(
    PowerSyncDatabase database,
    String table,
    String recordId,
  ) => database.execute('DELETE FROM sync_error WHERE id = ?', [
    '$table:$recordId',
  ]);

  static const _supportedTables = {
    'shop',
    'category',
    'unit_of_measure',
    'product',
    'product_unit',
    'product_price',
    'supplier',
  };
}
