import 'package:path/path.dart' as p;
import 'package:sqflite/sqflite.dart';

import '../config/app_config.dart';

class AppDatabase {
  AppDatabase({DatabaseFactory? factory, this.databasePath})
    : _factory = factory ?? databaseFactory;

  final DatabaseFactory _factory;
  final String? databasePath;
  Database? _database;

  Future<Database> get instance async {
    final existing = _database;
    if (existing != null) return existing;

    final path =
        databasePath ??
        p.join(await _factory.getDatabasesPath(), AppConfig.databaseName);
    _database = await _factory.openDatabase(
      path,
      options: OpenDatabaseOptions(
        version: 10,
        onConfigure: (database) async {
          await database.execute('PRAGMA foreign_keys = ON');
          // Use rawQuery for journal_mode as it returns a result which some
          // Android versions require to be handled via query methods.
          await database.rawQuery('PRAGMA journal_mode = WAL');
        },
        onCreate: _createSchema,
        onUpgrade: _upgradeSchema,
      ),
    );
    return _database!;
  }

  Future<void> close() async {
    await _database?.close();
    _database = null;
  }

  static Future<void> _createSchema(Database database, int version) async {
    await _createShopsSchema(database);
    await _createCategoriesSchema(database);
    await _createUnitOfMeasuresSchema(database);
    await _createProductsSchema(database);
    await _createProductUnitsSchema(database);
    await database.execute('''
      CREATE TABLE sync_metadata (
        key TEXT PRIMARY KEY,
        value TEXT NOT NULL
      )
    ''');
  }

  static Future<void> _upgradeSchema(
    Database database,
    int oldVersion,
    int newVersion,
  ) async {
    if (oldVersion < 2) {
      await database.execute(
        'ALTER TABLE categories ADD COLUMN server_created_date TEXT',
      );
      await database.execute(
        'ALTER TABLE categories ADD COLUMN server_updated_date TEXT',
      );
      await database.execute(
        'ALTER TABLE categories ADD COLUMN server_created_by TEXT',
      );
      await database.execute(
        'ALTER TABLE categories ADD COLUMN server_updated_by TEXT',
      );
      await database.execute(
        'ALTER TABLE categories ADD COLUMN server_last_modified_utc TEXT',
      );
    }
    if (oldVersion < 3) {
      await _createUnitOfMeasuresSchema(database);
    }
    if (oldVersion < 4) {
      await _createShopsSchema(database);
    }
    if (oldVersion < 5) {
      await _createProductsSchema(database);
    }
    if (oldVersion < 6) {
      // Ensure shop_id exists in categories for multi-tenancy filtering
      try {
        await database.execute(
          'ALTER TABLE categories ADD COLUMN shop_id TEXT',
        );
      } catch (_) {
        // Column might already exist if created with v5 schema
      }

      // Ensure all major tables exist (in case of interrupted creation)
      await database.execute(
        'CREATE TABLE IF NOT EXISTS sync_metadata (key TEXT PRIMARY KEY, value TEXT NOT NULL)',
      );
      await _createUnitOfMeasuresSchema(database);
      await _createShopsSchema(database);
      await _createProductsSchema(database);
    }
    if (oldVersion < 7) {
      await _createCategoryNameUniqueIndex(database);
    }
    if (oldVersion < 8) {
      await _migrateExistingTablesToForeignKeys(database);
    }
    if (oldVersion < 9) {
      await _createProductUnitsSchema(database);
    }
    if (oldVersion == 9) {
      await _migrateProductUnitsToBaseUnitQuantity(database);
    }
  }

  static Future<void> _createCategoriesSchema(
    Database database, {
    String tableName = 'categories',
    bool createIndexes = true,
  }) async {
    await database.execute('''
      CREATE TABLE IF NOT EXISTS $tableName (
        id TEXT PRIMARY KEY,
        name TEXT NOT NULL,
        code TEXT,
        description TEXT,
        is_active INTEGER NOT NULL DEFAULT 1,
        shop_id TEXT,
        created_at TEXT NOT NULL,
        updated_at TEXT NOT NULL,
        last_modified_utc TEXT NOT NULL,
        is_deleted INTEGER NOT NULL DEFAULT 0,
        pending_operation TEXT NOT NULL DEFAULT 'none',
        sync_status TEXT NOT NULL DEFAULT 'synced',
        retry_count INTEGER NOT NULL DEFAULT 0,
        next_retry_at TEXT,
        last_sync_error TEXT,
        server_created_date TEXT,
        server_updated_date TEXT,
        server_created_by TEXT,
        server_updated_by TEXT,
        server_last_modified_utc TEXT,
        CONSTRAINT fk_categories_shops_shop_id
          FOREIGN KEY (shop_id) REFERENCES shops(id) ON DELETE RESTRICT
      )
    ''');
    if (createIndexes) {
      await _createCategoryIndexes(database);
    }
  }

  static Future<void> _createCategoryIndexes(Database database) async {
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_categories_visible
      ON categories(is_deleted, name COLLATE NOCASE)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_categories_pending
      ON categories(pending_operation, next_retry_at)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_categories_shop_id
      ON categories(shop_id)
    ''');
    await _createCategoryNameUniqueIndex(database);
  }

  static Future<void> _createCategoryNameUniqueIndex(Database database) async {
    await database.execute('''
      CREATE UNIQUE INDEX IF NOT EXISTS ux_categories_shop_name
      ON categories(shop_id, name COLLATE NOCASE)
      WHERE is_deleted = 0 AND shop_id IS NOT NULL
    ''');
  }

  static Future<void> _createUnitOfMeasuresSchema(
    Database database, {
    String tableName = 'unit_of_measures',
    bool createIndexes = true,
  }) async {
    await database.execute('''
      CREATE TABLE IF NOT EXISTS $tableName (
        id TEXT PRIMARY KEY,
        name TEXT NOT NULL,
        symbol TEXT NOT NULL,
        description TEXT,
        shop_id TEXT,
        created_at TEXT NOT NULL,
        updated_at TEXT NOT NULL,
        last_modified_utc TEXT NOT NULL,
        is_deleted INTEGER NOT NULL DEFAULT 0,
        pending_operation TEXT NOT NULL DEFAULT 'none',
        sync_status TEXT NOT NULL DEFAULT 'synced',
        retry_count INTEGER NOT NULL DEFAULT 0,
        next_retry_at TEXT,
        last_sync_error TEXT,
        server_created_date TEXT,
        server_updated_date TEXT,
        server_created_by TEXT,
        server_updated_by TEXT,
        server_last_modified_utc TEXT,
        CONSTRAINT fk_unit_of_measures_shops_shop_id
          FOREIGN KEY (shop_id) REFERENCES shops(id) ON DELETE RESTRICT
      )
    ''');
    if (!createIndexes) return;
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_unit_of_measures_visible
      ON unit_of_measures(is_deleted, name COLLATE NOCASE)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_unit_of_measures_pending
      ON unit_of_measures(pending_operation, next_retry_at)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_unit_of_measures_shop_id
      ON unit_of_measures(shop_id)
    ''');
  }

  static Future<void> _createShopsSchema(Database database) async {
    await database.execute('''
      CREATE TABLE IF NOT EXISTS shops (
        id TEXT PRIMARY KEY,
        name TEXT NOT NULL,
        shop_type TEXT NOT NULL,
        address TEXT,
        phone_number TEXT,
        email TEXT,
        tax_number TEXT,
        is_active INTEGER NOT NULL DEFAULT 1,
        created_at TEXT NOT NULL,
        updated_at TEXT NOT NULL,
        last_modified_utc TEXT NOT NULL,
        is_deleted INTEGER NOT NULL DEFAULT 0,
        pending_operation TEXT NOT NULL DEFAULT 'none',
        sync_status TEXT NOT NULL DEFAULT 'synced',
        retry_count INTEGER NOT NULL DEFAULT 0,
        next_retry_at TEXT,
        last_sync_error TEXT,
        server_last_modified_utc TEXT
      )
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_shops_visible
      ON shops(is_deleted, name COLLATE NOCASE)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_shops_pending
      ON shops(pending_operation, next_retry_at)
    ''');
  }

  static Future<void> _createProductsSchema(
    Database database, {
    String tableName = 'products',
    bool createIndexes = true,
  }) async {
    await database.execute('''
      CREATE TABLE IF NOT EXISTS $tableName (
        id TEXT PRIMARY KEY,
        name TEXT NOT NULL,
        base_unit_id TEXT NOT NULL,
        description TEXT,
        is_active INTEGER NOT NULL DEFAULT 1,
        sku TEXT,
        barcode TEXT,
        image_url TEXT,
        category_id TEXT,
        shop_id TEXT,
        created_at TEXT NOT NULL,
        updated_at TEXT NOT NULL,
        last_modified_utc TEXT NOT NULL,
        is_deleted INTEGER NOT NULL DEFAULT 0,
        pending_operation TEXT NOT NULL DEFAULT 'none',
        sync_status TEXT NOT NULL DEFAULT 'synced',
        retry_count INTEGER NOT NULL DEFAULT 0,
        next_retry_at TEXT,
        last_sync_error TEXT,
        server_created_date TEXT,
        server_updated_date TEXT,
        server_created_by TEXT,
        server_updated_by TEXT,
        server_last_modified_utc TEXT,
        CONSTRAINT fk_products_unit_of_measures_base_unit_id
          FOREIGN KEY (base_unit_id) REFERENCES unit_of_measures(id) ON DELETE RESTRICT,
        CONSTRAINT fk_products_categories_category_id
          FOREIGN KEY (category_id) REFERENCES categories(id) ON DELETE SET NULL,
        CONSTRAINT fk_products_shops_shop_id
          FOREIGN KEY (shop_id) REFERENCES shops(id) ON DELETE RESTRICT
      )
    ''');
    if (!createIndexes) return;
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_visible
      ON products(is_deleted, name COLLATE NOCASE)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_pending
      ON products(pending_operation, next_retry_at)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_base_unit_id
      ON products(base_unit_id)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_category_id
      ON products(category_id)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_shop_id
      ON products(shop_id)
    ''');
  }

  static Future<void> _createProductUnitsSchema(
    Database database, {
    String tableName = 'product_units',
    bool createIndexes = true,
  }) async {
    await database.execute('''
      CREATE TABLE IF NOT EXISTS $tableName (
        id TEXT PRIMARY KEY,
        product_id TEXT NOT NULL,
        unit_of_measure_id TEXT NOT NULL,
        base_unit_quantity REAL NOT NULL,
        created_at TEXT NOT NULL,
        updated_at TEXT NOT NULL,
        last_modified_utc TEXT NOT NULL,
        is_deleted INTEGER NOT NULL DEFAULT 0,
        pending_operation TEXT NOT NULL DEFAULT 'none',
        sync_status TEXT NOT NULL DEFAULT 'synced',
        retry_count INTEGER NOT NULL DEFAULT 0,
        next_retry_at TEXT,
        last_sync_error TEXT,
        server_created_date TEXT,
        server_updated_date TEXT,
        server_created_by TEXT,
        server_updated_by TEXT,
        server_last_modified_utc TEXT,
        CONSTRAINT fk_product_units_product_id
          FOREIGN KEY (product_id) REFERENCES products(id) ON DELETE RESTRICT,
        CONSTRAINT fk_product_units_unit_of_measure_id
          FOREIGN KEY (unit_of_measure_id) REFERENCES unit_of_measures(id) ON DELETE RESTRICT
      )
    ''');
    if (!createIndexes) return;
    await _createProductUnitIndexes(database);
  }

  static Future<void> _createProductUnitIndexes(Database database) async {
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_product_units_visible
      ON product_units(is_deleted, product_id, unit_of_measure_id)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_product_units_pending
      ON product_units(pending_operation, next_retry_at)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_product_units_product_id
      ON product_units(product_id)
    ''');
    await database.execute('''
      CREATE UNIQUE INDEX IF NOT EXISTS ux_product_units_product_unit
      ON product_units(product_id, unit_of_measure_id)
      WHERE is_deleted = 0
    ''');
  }

  static Future<void> _migrateProductUnitsToBaseUnitQuantity(
    Database database,
  ) async {
    final duplicates =
        Sqflite.firstIntValue(
          await database.rawQuery('''
      SELECT COUNT(*)
      FROM (
        SELECT product_id, unit_of_measure_id
        FROM product_units
        WHERE is_deleted = 0
        GROUP BY product_id, unit_of_measure_id
        HAVING COUNT(*) > 1
      )
    '''),
        ) ??
        0;
    if (duplicates > 0) {
      throw StateError(
        'Cannot apply the ProductUnit uniqueness upgrade because $duplicates '
        'duplicate active product-unit pair(s) exist locally. Resolve them first.',
      );
    }
    await _createProductUnitsSchema(
      database,
      tableName: 'product_units_v10',
      createIndexes: false,
    );
    await database.execute('''
      INSERT INTO product_units_v10 (
        id, product_id, unit_of_measure_id, base_unit_quantity,
        created_at, updated_at, last_modified_utc, is_deleted,
        pending_operation, sync_status, retry_count, next_retry_at,
        last_sync_error, server_created_date, server_updated_date,
        server_created_by, server_updated_by, server_last_modified_utc
      )
      SELECT
        id, product_id, unit_of_measure_id, conversion_factor,
        created_at, updated_at, last_modified_utc, is_deleted,
        pending_operation, sync_status, retry_count, next_retry_at,
        last_sync_error, server_created_date, server_updated_date,
        server_created_by, server_updated_by, server_last_modified_utc
      FROM product_units
    ''');
    await database.execute('DROP TABLE product_units');
    await database.execute(
      'ALTER TABLE product_units_v10 RENAME TO product_units',
    );
    await _createProductUnitIndexes(database);
  }

  static Future<void> _migrateExistingTablesToForeignKeys(
    Database database,
  ) async {
    // Nullable historical references can be repaired safely without inventing a
    // parent row. Required product base-unit references cannot be guessed.
    await database.execute('''
      UPDATE categories
      SET shop_id = NULL
      WHERE shop_id IS NOT NULL
        AND TRIM(shop_id) <> ''
        AND NOT EXISTS (SELECT 1 FROM shops WHERE shops.id = categories.shop_id)
    ''');
    await database.execute('''
      UPDATE unit_of_measures
      SET shop_id = NULL
      WHERE shop_id IS NOT NULL
        AND TRIM(shop_id) <> ''
        AND NOT EXISTS (SELECT 1 FROM shops WHERE shops.id = unit_of_measures.shop_id)
    ''');
    await database.execute('''
      UPDATE products
      SET shop_id = NULL
      WHERE shop_id IS NOT NULL
        AND TRIM(shop_id) <> ''
        AND NOT EXISTS (SELECT 1 FROM shops WHERE shops.id = products.shop_id)
    ''');
    await database.execute('''
      UPDATE products
      SET category_id = NULL
      WHERE category_id IS NOT NULL
        AND TRIM(category_id) <> ''
        AND NOT EXISTS (SELECT 1 FROM categories WHERE categories.id = products.category_id)
    ''');

    final invalidBaseUnitCount =
        Sqflite.firstIntValue(
          await database.rawQuery('''
            SELECT COUNT(*)
            FROM products
            WHERE base_unit_id IS NULL
               OR TRIM(base_unit_id) = ''
               OR NOT EXISTS (
                 SELECT 1
                 FROM unit_of_measures
                 WHERE unit_of_measures.id = products.base_unit_id
               )
          '''),
        ) ??
        0;
    if (invalidBaseUnitCount > 0) {
      throw StateError(
        'Cannot enforce product/base-unit foreign keys because '
        '$invalidBaseUnitCount product row(s) reference a missing base unit.',
      );
    }

    await _rebuildCategoriesWithForeignKeys(database);
    await _rebuildUnitOfMeasuresWithForeignKeys(database);
    await _rebuildProductsWithForeignKeys(database);
  }

  static Future<void> _rebuildCategoriesWithForeignKeys(
    Database database,
  ) async {
    await _createCategoriesSchema(
      database,
      tableName: 'categories_v8',
      createIndexes: false,
    );
    await database.execute('''
      INSERT INTO categories_v8 (
        id, name, code, description, is_active, shop_id,
        created_at, updated_at, last_modified_utc, is_deleted,
        pending_operation, sync_status, retry_count, next_retry_at,
        last_sync_error, server_created_date, server_updated_date,
        server_created_by, server_updated_by, server_last_modified_utc
      )
      SELECT
        id, name, code, description, is_active, shop_id,
        created_at, updated_at, last_modified_utc, is_deleted,
        pending_operation, sync_status, retry_count, next_retry_at,
        last_sync_error, server_created_date, server_updated_date,
        server_created_by, server_updated_by, server_last_modified_utc
      FROM categories
    ''');
    await database.execute('DROP TABLE categories');
    await database.execute('ALTER TABLE categories_v8 RENAME TO categories');
    await _createCategoryIndexes(database);
  }

  static Future<void> _rebuildUnitOfMeasuresWithForeignKeys(
    Database database,
  ) async {
    await _createUnitOfMeasuresSchema(
      database,
      tableName: 'unit_of_measures_v8',
      createIndexes: false,
    );
    await database.execute('''
      INSERT INTO unit_of_measures_v8 (
        id, name, symbol, description, shop_id,
        created_at, updated_at, last_modified_utc, is_deleted,
        pending_operation, sync_status, retry_count, next_retry_at,
        last_sync_error, server_created_date, server_updated_date,
        server_created_by, server_updated_by, server_last_modified_utc
      )
      SELECT
        id, name, symbol, description, shop_id,
        created_at, updated_at, last_modified_utc, is_deleted,
        pending_operation, sync_status, retry_count, next_retry_at,
        last_sync_error, server_created_date, server_updated_date,
        server_created_by, server_updated_by, server_last_modified_utc
      FROM unit_of_measures
    ''');
    await database.execute('DROP TABLE unit_of_measures');
    await database.execute(
      'ALTER TABLE unit_of_measures_v8 RENAME TO unit_of_measures',
    );
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_unit_of_measures_visible
      ON unit_of_measures(is_deleted, name COLLATE NOCASE)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_unit_of_measures_pending
      ON unit_of_measures(pending_operation, next_retry_at)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_unit_of_measures_shop_id
      ON unit_of_measures(shop_id)
    ''');
  }

  static Future<void> _rebuildProductsWithForeignKeys(Database database) async {
    await _createProductsSchema(
      database,
      tableName: 'products_v8',
      createIndexes: false,
    );
    await database.execute('''
      INSERT INTO products_v8 (
        id, name, base_unit_id, description, is_active, sku, barcode,
        image_url, category_id, shop_id, created_at, updated_at,
        last_modified_utc, is_deleted, pending_operation, sync_status,
        retry_count, next_retry_at, last_sync_error, server_created_date,
        server_updated_date, server_created_by, server_updated_by,
        server_last_modified_utc
      )
      SELECT
        id, name, base_unit_id, description, is_active, sku, barcode,
        image_url, category_id, shop_id, created_at, updated_at,
        last_modified_utc, is_deleted, pending_operation, sync_status,
        retry_count, next_retry_at, last_sync_error, server_created_date,
        server_updated_date, server_created_by, server_updated_by,
        server_last_modified_utc
      FROM products
    ''');
    await database.execute('DROP TABLE products');
    await database.execute('ALTER TABLE products_v8 RENAME TO products');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_visible
      ON products(is_deleted, name COLLATE NOCASE)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_pending
      ON products(pending_operation, next_retry_at)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_base_unit_id
      ON products(base_unit_id)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_category_id
      ON products(category_id)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_shop_id
      ON products(shop_id)
    ''');
  }
}
