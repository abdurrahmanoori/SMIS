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
        version: 2,
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
      CREATE TABLE categories (
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
      CREATE INDEX idx_categories_visible
      ON categories(is_deleted, name COLLATE NOCASE)
    ''');
    await database.execute('''
      CREATE INDEX idx_categories_pending
      ON categories(pending_operation, next_retry_at)
    ''');
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
  }
}
