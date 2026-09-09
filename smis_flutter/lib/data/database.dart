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
        version: 6,
        onConfigure: (database) async {
          await database.execute('PRAGMA foreign_keys = ON');
          await database.execute('PRAGMA journal_mode = WAL');
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
    await database.execute('''
      CREATE TABLE IF NOT EXISTS categories (
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
        server_last_modified_utc TEXT
      )
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_categories_visible
      ON categories(is_deleted, name COLLATE NOCASE)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_categories_pending
      ON categories(pending_operation, next_retry_at)
    ''');
    await database.execute('''
      CREATE TABLE sync_metadata (
        key TEXT PRIMARY KEY,
        value TEXT NOT NULL
      )
    ''');
    await _createUnitOfMeasuresSchema(database);
    await _createShopsSchema(database);
    await _createProductsSchema(database);
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
        await database.execute('ALTER TABLE categories ADD COLUMN shop_id TEXT');
      } catch (_) {
        // Column might already exist if created with v5 schema
      }
      
      // Ensure all major tables exist (in case of interrupted creation)
      await database.execute('CREATE TABLE IF NOT EXISTS sync_metadata (key TEXT PRIMARY KEY, value TEXT NOT NULL)');
      await _createUnitOfMeasuresSchema(database);
      await _createShopsSchema(database);
      await _createProductsSchema(database);
    }
  }

  static Future<void> _createUnitOfMeasuresSchema(Database database) async {
    await database.execute('''
      CREATE TABLE IF NOT EXISTS unit_of_measures (
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
        server_last_modified_utc TEXT
      )
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_unit_of_measures_visible
      ON unit_of_measures(is_deleted, name COLLATE NOCASE)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_unit_of_measures_pending
      ON unit_of_measures(pending_operation, next_retry_at)
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

  static Future<void> _createProductsSchema(Database database) async {
    await database.execute('''
      CREATE TABLE IF NOT EXISTS products (
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
        server_last_modified_utc TEXT
      )
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_visible
      ON products(is_deleted, name COLLATE NOCASE)
    ''');
    await database.execute('''
      CREATE INDEX IF NOT EXISTS idx_products_pending
      ON products(pending_operation, next_retry_at)
    ''');
  }
}
