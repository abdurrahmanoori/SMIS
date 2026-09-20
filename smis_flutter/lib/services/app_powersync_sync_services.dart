import '../data/powersync/app_powersync_database.dart';
import '../data/powersync/product_powersync_repository.dart';
import '../data/powersync/product_unit_powersync_repository.dart';
import '../data/powersync/shop_powersync_repository.dart';
import '../data/powersync/unit_of_measure_powersync_repository.dart';
import 'product_sync_service.dart';
import 'product_unit_sync_service.dart';
import 'shop_sync_service.dart';
import 'unit_of_measure_sync_service.dart';

class PowerSyncCheck {
  const PowerSyncCheck({
    required this.success,
    required this.message,
    this.error,
    this.stackTrace,
  });

  final bool success;
  final String message;
  final Object? error;
  final StackTrace? stackTrace;
}

class AppPowerSyncStatusService {
  AppPowerSyncStatusService(this._database);

  final AppPowerSyncDatabase _database;

  Future<PowerSyncCheck> check() async {
    try {
      final database = await _database.connectForCurrentSession();
      var status = database.currentStatus;
      if (status.anyError != null) {
        throw StateError('PowerSync connection failed: ${status.anyError}');
      }

      if (status.hasSynced != true) {
        status = await database.statusStream
            .firstWhere(
              (value) => value.hasSynced == true || value.anyError != null,
            )
            .timeout(const Duration(seconds: 30));
      }

      if (status.anyError != null) {
        throw StateError('PowerSync connection failed: ${status.anyError}');
      }

      return const PowerSyncCheck(
        success: true,
        message: 'PowerSync is connected and up to date.',
      );
    } catch (error, stackTrace) {
      return PowerSyncCheck(
        success: false,
        message: 'PowerSync could not complete the sync check.',
        error: error,
        stackTrace: stackTrace,
      );
    }
  }
}

class ShopPowerSyncService {
  ShopPowerSyncService(this._status, this._repository);

  final AppPowerSyncStatusService _status;
  final ShopPowerSyncRepository _repository;

  Future<ShopSyncResult> synchronize({bool force = false}) async {
    final check = await _status.check();
    final pending = await _repository.getPendingCount();
    if (check.success) {
      return ShopSyncResult(
        success: true,
        message: pending == 0
            ? 'Shop PowerSync is up to date.'
            : 'Shop PowerSync is connected; $pending local change(s) are still uploading.',
        pending: pending,
      );
    }
    return ShopSyncResult(
      success: false,
      message: check.message,
      pending: pending,
      transientFailure: true,
      failures: [
        ShopSyncFailure(
          phase: 'PowerSync',
          error: check.error!,
          stackTrace: check.stackTrace!,
        ),
      ],
    );
  }
}

class UnitOfMeasurePowerSyncService {
  UnitOfMeasurePowerSyncService(this._status, this._repository);

  final AppPowerSyncStatusService _status;
  final UnitOfMeasurePowerSyncRepository _repository;

  Future<UnitOfMeasureSyncResult> synchronize({
    required String shopId,
    bool force = false,
  }) async {
    final check = await _status.check();
    final pending = await _repository.getPendingCount(shopId);
    if (check.success) {
      return UnitOfMeasureSyncResult(
        success: true,
        message: pending == 0
            ? 'Unit of measure PowerSync is up to date.'
            : 'Unit of measure PowerSync is connected; $pending local change(s) are still uploading.',
        pending: pending,
      );
    }
    return UnitOfMeasureSyncResult(
      success: false,
      message: check.message,
      pending: pending,
      transientFailure: true,
      failures: [
        UnitOfMeasureSyncFailure(
          phase: 'PowerSync',
          error: check.error!,
          stackTrace: check.stackTrace!,
        ),
      ],
    );
  }
}

class ProductPowerSyncService {
  ProductPowerSyncService(this._status, this._repository);

  final AppPowerSyncStatusService _status;
  final ProductPowerSyncRepository _repository;

  Future<ProductSyncResult> synchronize({
    required String shopId,
    bool force = false,
  }) async {
    final check = await _status.check();
    final pending = await _repository.getPendingCount(shopId);
    if (check.success) {
      return ProductSyncResult(
        success: true,
        message: pending == 0
            ? 'Product PowerSync is up to date.'
            : 'Product PowerSync is connected; $pending local change(s) are still uploading.',
        pending: pending,
      );
    }
    return ProductSyncResult(
      success: false,
      message: check.message,
      pending: pending,
      transientFailure: true,
      failures: [
        ProductSyncFailure(
          phase: 'PowerSync',
          error: check.error!,
          stackTrace: check.stackTrace!,
        ),
      ],
    );
  }
}

class ProductUnitPowerSyncService {
  ProductUnitPowerSyncService(this._status, this._repository);

  final AppPowerSyncStatusService _status;
  final ProductUnitPowerSyncRepository _repository;

  Future<ProductUnitSyncResult> synchronize({
    required String shopId,
    bool force = false,
  }) async {
    final check = await _status.check();
    final pending = await _repository.getPendingCount(shopId);
    return ProductUnitSyncResult(
      success: check.success,
      message: check.success
          ? pending == 0
                ? 'Product unit PowerSync is up to date.'
                : 'Product unit PowerSync is connected; $pending local change(s) are still uploading.'
          : check.message,
      pending: pending,
      transientFailure: !check.success,
    );
  }
}
