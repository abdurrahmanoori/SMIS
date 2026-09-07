# Unit of Measurement: offline-first flow

This feature manages only the `UnitOfMeasure` entity. The screen works without
an internet connection: every create, edit, and delete is saved in the local
SQLite database first. The server is contacted only when the user selects Sync
or when the supported background task runs.

## Where the flow starts and ends

1. The user opens **Units of measurement** from Home or the navigation drawer.
   `lib/screens/unit_of_measures_screen.dart` reads state from
   `UnitOfMeasureController`.
2. The add/edit dialog validates the backend limits locally: name (100), symbol
   (20, required), and description (500).
   `lib/widgets/unit_of_measure_form_dialog.dart`
3. `UnitOfMeasureController` delegates the action to
   `UnitOfMeasureRepository`. The repository writes one record to
   `unit_of_measures` in SQLite and marks it as `pendingCreate`,
   `pendingUpdate`, or `pendingDelete`.
4. The screen immediately reloads from SQLite and informs the user that the
   change is saved locally. No remote request is necessary for CRUD.
5. Sync calls `UnitOfMeasureSyncService`, either from the screen Sync button or
   `BackgroundSyncScheduler`. It first pulls changes, then pushes queued local
   changes through `UnitOfMeasureApi`.
6. On success, the returned server record replaces the local queued record and
   it becomes `synced`. A completed delete removes the local tombstone.

## Backend contract used

The implementation was matched to `SMIS.Api/Controllers/UnitOfMeasureController.cs`
and `SMIS.Application/DTO/UnitOfMeasures/UnitOfMeasureSyncDtos.cs`.

| Purpose | Route |
| --- | --- |
| Pull changed records | `GET /api/UnitOfMeasure/pull?changedSince=...` |
| Read one record before pushing | `GET /api/UnitOfMeasure/{id}` |
| Sync create | `POST /api/UnitOfMeasure/sync` |
| Sync update | `PUT /api/UnitOfMeasure/{id}/sync` |
| Sync delete | `DELETE /api/UnitOfMeasure/{id}/sync` |

The regular create/update endpoints accept `shopId`, but the sync endpoints
derive the shop from the authenticated user. Therefore the Flutter sync payload
does not send a client-controlled shop ID. The `shopId` returned by the API is
stored locally for display/audit purposes.

## Conflict, retry, and offline behavior

- Conflicts use **last-update-wins**. A record with a newer
  `clientModifiedDate` is pushed; a newer server record replaces the local
  record. If timestamps tie, the server wins, so every device converges.
- Deletes use local tombstones so an offline delete is not accidentally
  recreated on the next pull.
- Transient network failures are queued again with exponential backoff (1, 2,
  4, 8, 16, then 32 minutes). The Sync button uses force mode so the user can
  retry immediately.
- The local queue, its pull cursor, and its sync lock use entity-specific keys;
  Unit of Measurement sync cannot block Category sync.
- In debug mode, an unsuccessful sync renders detailed exception information in
  one place only: the upper sync summary on the Unit screen. Release builds keep
  the summary safe and concise.

## Files by responsibility

| Responsibility | Files |
| --- | --- |
| Presentation | `screens/unit_of_measures_screen.dart`, `widgets/unit_of_measure_form_dialog.dart` |
| State | `controllers/unit_of_measure_controller.dart` |
| Domain/local record | `models/unit_of_measure*.dart` |
| Local storage | `data/unit_of_measure_repository.dart`, `data/database.dart` |
| Remote API | `data/unit_of_measure_api.dart` |
| Synchronization | `services/unit_of_measure_sync_service.dart`, `services/background_sync.dart` |

The database schema is version 3. Existing installations migrate additively: no
Category data is removed or rewritten.
