import '../data/powersync/category_powersync_database.dart';
import 'category_sync_service.dart';

/// Small adapter used by the existing Category UI's "Sync now" action.
/// Normal PowerSync operation is continuous; this method mainly provides a
/// visible connectivity/initial-sync check for the Category proof-of-concept.
class CategoryPowerSyncService {
  CategoryPowerSyncService(this._database);

  final CategoryPowerSyncDatabase _database;

  Future<CategorySyncResult> synchronize({
    required String shopId,
    bool force = false,
  }) async {
    try {
      final database = await _database.connectIfConfigured();
      var status = database.currentStatus;
      if (status.anyError != null) {
        throw StateError('PowerSync connection failed: ${status.anyError}');
      }

      if (status.hasSynced != true) {
        status = await database.statusStream
            .firstWhere(
              (status) => status.hasSynced == true || status.anyError != null,
            )
            .timeout(const Duration(seconds: 30));
      }

      if (status.anyError != null) {
        throw StateError('PowerSync connection failed: ${status.anyError}');
      }

      final pending = (await database.getUploadQueueStats()).count;
      return CategorySyncResult(
        success: true,
        message: pending == 0
            ? 'Category PowerSync is up to date.'
            : 'Category PowerSync is connected; $pending local change(s) are still uploading.',
        pending: pending,
      );
    } catch (error, stackTrace) {
      final database = await _database.database;
      return CategorySyncResult(
        success: false,
        message: 'Category PowerSync could not complete the sync check.',
        pending: (await database.getUploadQueueStats()).count,
        transientFailure: true,
        failures: [
          CategorySyncFailure(
            phase: 'PowerSync',
            error: error,
            stackTrace: stackTrace,
          ),
        ],
      );
    }
  }
}
