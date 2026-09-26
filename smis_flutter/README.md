# SMIS Flutter — PowerSync offline-first client

The Flutter client uses PowerSync as the local-first data layer for the entities
currently present in `app_powersync_schema.dart`. UI reads and CRUD operate on the
PowerSync SQLite database, while PowerSync owns the durable CRUD queue and remote
replication lifecycle.

## Current architecture

```text
Flutter UI / controllers
        ↓
PowerSync repositories
        ↓
PowerSync SQLite database
        ↓
PowerSync CRUD queue
        ↓
AppPowerSyncConnector
        ↓
per-entity upload handlers
        ↓
ASP.NET Core /sync write endpoints
        ↓
SQL Server
```

The client does not maintain a second manual synchronization queue, pull cursor,
retry table, tombstone table, or `IsSyncedToServer`/pending-operation domain
metadata. Pending status shown by the UI is derived from PowerSync's CRUD queue.

## Synced entities

The current PowerSync schema includes:

- shop
- category
- unit_of_measure
- product
- product_unit
- product_price
- language
- app_user

Only writable tables are handled by `AppPowerSyncConnector.uploadData`.
Read-only replicated tables are not sent through the upload API.

## Conflict timestamp

Writable rows include `last_modified_utc`. Upload handlers send that value as
`clientModifiedDate` to the existing ASP.NET Core `/sync` write endpoints.
The server uses it for conflict comparison. This is active PowerSync behavior,
not the removed legacy manual-sync metadata.

## Verification

```powershell
flutter analyze
flutter test
```

The ASP.NET Core solution should also build successfully after schema or sync
contract changes.
