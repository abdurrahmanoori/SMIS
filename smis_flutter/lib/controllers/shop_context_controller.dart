import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/data_exception.dart';
import '../models/shop.dart';
import 'auth_controller.dart';
import 'category_controller.dart';
import 'product_controller.dart';
import 'product_unit_controller.dart';
import 'shop_controller.dart';
import 'unit_of_measure_controller.dart';

class ShopContextController extends Notifier<bool> {
  @override
  bool build() => false;

  Future<void> switchShop(Shop shop) async {
    final session = ref.read(authControllerProvider).session;
    if (session == null) {
      throw const AuthenticationException(
        'You must be signed in to switch shops.',
      );
    }
    if (!session.isSuperAdmin) {
      throw const AuthenticationException(
        'Only a SuperAdmin can switch the active shop.',
      );
    }
    if (session.shopId == shop.id) return;

    final powerSync = ref.read(appPowerSyncDatabaseProvider);
    final pending = await powerSync.pendingCountForCurrentContext();
    if (pending > 0) {
      throw LocalStorageException(
        'Synchronize the current shop before switching. '
        '$pending local change(s) are still pending.',
      );
    }

    state = true;
    try {
      // Stop the old shop connection before publishing the new session. Riverpod
      // listeners react immediately to shopId changes, so this ordering avoids a
      // race where they open the new context and this method closes it afterward.
      await powerSync.close();
      await ref.read(authControllerProvider.notifier).switchShop(shop.id);

      // The next connection opens a different per-user/per-shop SQLite file, so
      // tenant rows and pending writes never mingle across shop contexts.
      final database = await powerSync.connectForCurrentSession();

      var status = database.currentStatus;
      if (status.hasSynced != true && status.anyError == null) {
        status = await database.statusStream
            .firstWhere(
              (value) => value.hasSynced == true || value.anyError != null,
            )
            .timeout(const Duration(seconds: 30));
      }
      if (status.anyError != null) {
        throw RemoteTransientException(
          'The shop changed, but PowerSync could not refresh the new shop yet.',
          cause: status.anyError,
        );
      }

      ref.invalidate(shopControllerProvider);
      ref.invalidate(categoryControllerProvider);
      ref.invalidate(categoryLookupProvider);
      ref.invalidate(productControllerProvider);
      ref.invalidate(productUnitControllerProvider);
      ref.invalidate(unitOfMeasureControllerProvider);
      ref.invalidate(productLookupProvider);
      ref.invalidate(unitOfMeasureLookupProvider);
    } finally {
      state = false;
    }
  }
}

final shopContextControllerProvider =
    NotifierProvider<ShopContextController, bool>(ShopContextController.new);

final activeShopProvider = Provider<Shop?>((ref) {
  final session = ref.watch(authControllerProvider).session;
  if (session == null) return null;
  final shops =
      ref.watch(shopControllerProvider).value?.shops ?? const <Shop>[];
  for (final shop in shops) {
    if (shop.id == session.shopId) return shop;
  }
  return null;
});
