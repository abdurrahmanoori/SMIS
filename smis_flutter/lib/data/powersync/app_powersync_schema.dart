import 'package:powersync/powersync.dart';

const _trackTimestamp = TrackPreviousValuesOptions(
  columnFilter: ['last_modified_utc'],
);

/// Only entities that currently exist in the Flutter application are included.
/// Adding a .NET entity does not automatically make it part of offline sync.
const appPowerSyncSchema = Schema([
  Table('language', [
    Column.text('name'),
    Column.text('code'),
    Column.integer('is_active'),
    Column.text('last_modified_utc'),
  ]),
  Table('app_user', [
    Column.text('language_id'),
    Column.text('last_modified_utc'),
  ]),
  Table('shop', [
    Column.text('name'),
    Column.text('shop_type'),
    Column.text('address'),
    Column.text('phone_number'),
    Column.text('email'),
    Column.text('tax_number'),
    Column.integer('is_active'),
    Column.text('last_modified_utc'),
  ], trackPreviousValues: _trackTimestamp),
  Table('category', [
    Column.text('name'),
    Column.text('name_dari'),
    Column.text('name_localized_text_id'),
    Column.text('code'),
    Column.text('description'),
    Column.integer('is_active'),
    Column.text('shop_id'),
    Column.text('last_modified_utc'),
  ], trackPreviousValues: _trackTimestamp),
  Table('unit_of_measure', [
    Column.text('name'),
    Column.text('symbol'),
    Column.text('description'),
    Column.text('last_modified_utc'),
  ], trackPreviousValues: _trackTimestamp),
  Table('product', [
    Column.text('name'),
    Column.text('base_unit_id'),
    Column.text('sku'),
    Column.text('description'),
    Column.integer('is_active'),
    Column.text('barcode'),
    Column.text('image_url'),
    Column.text('category_id'),
    Column.text('shop_id'),
    Column.real('reorder_point_base'),
    Column.real('reorder_quantity_base'),
    Column.text('last_modified_utc'),
  ], trackPreviousValues: _trackTimestamp),
  Table('product_unit', [
    Column.text('product_id'),
    Column.text('unit_of_measure_id'),
    Column.real('base_unit_quantity'),
    Column.text('last_modified_utc'),
  ], trackPreviousValues: _trackTimestamp),
  Table('product_price', [
    Column.text('product_unit_id'),
    Column.integer('sell_price'),
    Column.text('effective_date'),
    Column.text('end_date'),
    Column.text('last_modified_utc'),
  ], trackPreviousValues: _trackTimestamp),
]);
