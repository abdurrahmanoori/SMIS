import 'package:powersync/powersync.dart';

/// PowerSync schema for the Category proof-of-concept only.
///
/// The server table is dbo.Category. The Sync Stream aliases its columns to
/// these lower-case names so the client schema stays portable across database
/// engines. `id` is implicit in every PowerSync table and must not be declared
/// here.
const categoryPowerSyncSchema = Schema([
  Table('category', [
    Column.text('name'),
    Column.text('code'),
    Column.text('description'),
    Column.integer('is_active'),
    Column.text('shop_id'),
  ]),
]);
