# SMIS Flutter — offline-first Categories

This Flutter client implements local-first CRUD and synchronization for the
`Category` entity only. Reading, creating, editing, and deleting Categories use
SQLite and do not make a network request. A network connection is needed only
when a manual or scheduled synchronization runs.

New to Flutter or this architecture? Start with the step-by-step
[`Category offline-first flow`](docs/CATEGORY_OFFLINE_FIRST_FLOW.md). To ask
Codex to implement the same pattern for one other entity, use the reusable
[`$smis-flutter-offline-entity` skill](skills/smis-flutter-offline-entity/SKILL.md).

## Architecture

```text
lib/
├── config/          # API and database settings
├── controllers/     # Riverpod state and providers
├── data/            # SQLite repository and Category API
├── models/          # Category, local record, and API model
├── screens/         # Full application screens
├── services/        # Sync, connectivity, and background work
├── widgets/         # Reusable UI pieces
└── main.dart        # Startup, theme, and root widget
```

The structure is intentionally shallow. `CategoryRepository` owns local CRUD
and SQLite sync state, while `CategoryApi` owns server requests. Riverpod joins
them in `category_controller.dart`. Sync tests still use an in-memory SQLite
database and a fake Category API.

## Backend contract

The implementation follows `SMIS.Api/Controllers/CategoryController.cs` and the
Category DTOs in `SMIS.Application`:

| Operation | Endpoint |
| --- | --- |
| Create | `POST /api/Category` |
| List | `GET /api/Category` |
| Read | `GET /api/Category/{id}` |
| Update | `PUT /api/Category/{id}` |
| Delete | `DELETE /api/Category/{id}` |
| Incremental pull | `GET /api/Category/pull?changedSince={utc}` |

Client-generated UUIDs, `CreatedDate`, `UpdatedDate`, and `LastModifiedUtc` are
sent using the backend's existing offline-sync DTO fields. `ShopId` remains
server-controlled and comes from the authenticated user.

## Synchronization behavior

1. Pull Category changes since the last successful cursor, including server
   tombstones.
2. Merge each record with **last-write-wins** using `LastModifiedUtc` in UTC.
   The server wins exact timestamp ties so all clients converge consistently.
3. Push local creates, updates, and deletes. Each push checks the current server
   version again before writing.
4. Mark acknowledged changes as synced. Failed changes remain durable locally.

Automatic retries use delays of 1, 2, 4, 8, 16, and 32 minutes, with five
automatic attempts per scheduled cycle. The Sync button forces all queued or
failed records to retry immediately. Connectivity status is only a hint; all
timeouts, connection loss, HTTP failures, and malformed responses are still
handled by the network layer. A database-backed lock prevents overlapping
manual/background sync runs.

The background job runs hourly when the OS grants execution and a network is
available. Android WorkManager scheduling is automatic. iOS is configured for
iOS 14+, background processing/fetch, the
`com.example.smisFlutter.categorySync` identifier, and background plugin
registration. Actual timing is controlled by each operating system.

## Run

The Android emulator default points to the local API at
`http://10.0.2.2:5238`; other platforms default to `http://127.0.0.1:5238`.
Override it for a device or deployment:

```powershell
flutter run `
  --dart-define=SMIS_API_BASE_URL=https://api.example.com `
  --dart-define=SMIS_AUTH_TOKEN=your-development-token
```

The API's development middleware can inject its development JWT, so the token
define is optional in that environment. A production authentication module
should provide tokens from secure storage instead of compiling a token into the
application. Cleartext HTTP is enabled only in Android debug/profile manifests;
release builds should use HTTPS.

## Verify

```powershell
flutter analyze
flutter test
```

The test suite covers offline CRUD, unsynced-delete tombstones, both sides of
last-write-wins, transient failure retry metadata, and the Category screen.
