---
name: smis-flutter-offline-entity
description: Implement offline-first CRUD and synchronization for one requested SMIS Flutter entity by inspecting its real ASP.NET API contract and following the existing Category architecture. Use when adding another Category-like entity to smis_flutter; do not use for server-only, online-only, or multi-entity feature requests.
---

# SMIS Flutter offline-first entity

Implement exactly the entity requested by the user. Preserve the existing
Category feature as the reference implementation, but adapt to the requested
entity's actual backend contract rather than copying assumptions.

When the target repository contains
`smis_flutter/docs/CATEGORY_OFFLINE_FIRST_FLOW.md`, read it for an explanation
of the reference flow before implementing a new entity. Inspect the source
files themselves whenever the documentation and code differ; code is
authoritative.

## Non-negotiable invariants

- SQLite is the application source of truth. UI reads and CRUD must work without
  internet and must never wait for a remote request.
- Save a local mutation and its pending operation atomically before attempting
  synchronization.
- Keep models, local repository, remote API, synchronization, controller, and
  UI responsibilities separate without adding pass-through layers.
- Use UTC timestamps and deterministic last-write-wins conflict handling. The
  newer write wins; the server wins exact ties unless the backend defines a
  different deterministic rule.
- Pull remote changes before pushing local changes, then re-read the individual
  remote record before overwriting it.
- Retain failed work durably with retry count, next retry time, and an actionable
  error. Manual sync must be able to force a retry.
- A local delete of a never-synced create removes it locally. A previously
  synchronized delete remains as a hidden tombstone until acknowledged.
- Do not add CRUD for related or unrelated entities. Read a related ID only when
  the requested entity's contract genuinely requires it.
- Do not hardcode credentials, shop IDs, user IDs, production URLs, or server
  response values.
- Do not drop or recreate an existing user database to introduce a schema
  change. Add a versioned migration.

## Inspect before designing

Start with read-only inspection of the repository, local instructions, dirty
files, and the requested entity's backend implementation. Find and read:

1. API controller routes and HTTP methods.
2. Response, create, and update DTOs, including inherited base DTO fields.
3. Create/update/delete command handlers and validators.
4. Incremental pull query or other synchronization endpoint.
5. Domain entity validation and identifiers.
6. Repository query filters, tenant/shop filtering, and authorization.
7. Audit and soft-delete interceptors that set timestamps or hide rows.
8. JSON naming, authentication, base URL, response bodies, 404 behavior, and
   idempotency behavior.
9. Existing mobile/Flutter implementations that establish project conventions.

Write down the verified endpoint and field mapping before editing. If the
backend lacks a required capability—such as client-provided IDs, deletion
tombstones, incremental pull, or undelete—do not pretend the client can provide
it. Implement the safe subset, retain local work on failure, and clearly report
the backend gap. Modify the backend only when the user's request authorizes the
full workflow and the change is a necessary, scoped part of it.

## Design the entity feature

Follow the shallow structure established by Category:

```text
lib/
├── models/<entity>.dart
├── models/<entity>_local_record.dart
├── models/<entity>_remote_model.dart
├── data/<entity>_repository.dart
├── data/<entity>_api.dart
├── services/<entity>_sync_service.dart
├── controllers/<entity>_controller.dart
├── screens/<entities>_screen.dart
└── widgets/<entity>_form_dialog.dart
```

Reuse `lib/config`, `lib/data/database.dart`, and general services when their
behavior is truly shared. Keep file and identifier names in Dart's standard
snake_case and UpperCamelCase conventions. Do not add repository
interface/implementation pairs or use-case facades unless they perform real
work needed by the requested feature.

### Models

Create a UI-facing entity and validated draft/input. Match backend validation
limits and required fields. Expose synchronization status only when the UI
needs to display it.

### Local storage

Add an additive database migration and useful indexes. Store the entity data
plus the state needed to resume synchronization after process death:

- stable client/server ID;
- UTC creation, update, and last-modified times;
- hidden-deletion/tombstone flag;
- pending operation (`none`, `create`, `update`, `delete`);
- UI sync state;
- retry count, next retry time, and last error;
- tenant/shop scope when required by the API.

Put local CRUD and sync-state methods in the entity repository: visible reads,
ID lookup including tombstones, upsert, permanent delete, eligible pending
selection, pending count, pull cursor, and synchronization locking. Scope
cursors by account/shop if multiple sessions can use the same database.

### Offline repository

Implement CRUD only against SQLite through the entity repository:

- Create: normalize/validate, generate a client ID only if supported, timestamp,
  mark pending create, and insert.
- Update: read locally, validate, assign a timestamp strictly newer than the
  previous local write, preserve pending create when not yet acknowledged,
  otherwise mark pending update, and clear old retry state.
- Delete: physically remove a pending create; otherwise hide it and mark pending
  delete.
- Read/list: return visible local rows only.

After every mutation, refresh state from the repository. Do not make CRUD methods
conditionally remote when connectivity happens to exist; that creates two
different correctness paths.

### Remote adapter

Create request/response models that match the verified JSON contract. Keep
local-only queue fields out of request payloads. Implement only the requested
entity's endpoints.

Classify failures consistently:

- transient: connection/timeouts, 408, 429, and 5xx;
- permanent until user/configuration changes: authentication, authorization,
  validation, and other non-retryable 4xx responses;
- 404: interpret per operation and verified server semantics, not globally.

Connectivity plugins are hints only. Always catch real HTTP failures.

## Implement synchronization

Use a persistent lock so manual and background runs cannot overlap. Always
release it in `finally`, and allow a conservative stale-lock timeout.

### Pull

1. Read the entity/account-scoped pull cursor.
2. Request server changes since that cursor.
3. For each server row or tombstone, compare its UTC modification time with the
   local row, including pending rows.
4. Apply the newer version. Apply the server version on an exact tie.
5. Do not create a new outbound tombstone when applying a server deletion.
6. Advance the cursor only after the pull and local merge commit succeeds.
7. If the endpoint uses strict `>`, retain a small cursor overlap or another
   proven boundary strategy so equal timestamps are not missed.

### Push

Select eligible pending rows in deterministic order. For each row, read the
current server copy immediately before writing:

| Pending operation | Decision |
| --- | --- |
| Create/update, server missing | Create/upsert only if the contract supports the local ID and intended operation. |
| Create/update, local newer | Update server and merge the response locally. |
| Create/update, server newer/equal | Apply server locally and count a resolved conflict. |
| Delete, server missing | Remove local tombstone as acknowledged. |
| Delete, local newer | Delete remotely, then remove local tombstone. |
| Delete, server newer/equal | Restore/apply server locally and count a resolved conflict. |

Use the canonical server response after a successful create/update so server
fields such as shop ID are retained. Do not mark a record synchronized before
the remote operation succeeds.

### Retry

Persist exponential backoff with a reasonable ceiling and cap automatic
attempts to prevent battery/network loops. Manual sync may ignore the next
retry time and automatic-attempt cap. On connection loss, retain all unprocessed
rows and stop issuing more requests in that run. Return a summary containing
pulled, pushed, failed, conflicts, and remaining pending counts.

## Wire background work

Prefer one existing Workmanager dispatcher and recurring sync orchestration over
creating an unrelated job per entity. Background callbacks run in another
isolate, so initialize Flutter/plugin registration, open the database, and
recreate dependencies inside the callback. Close resources afterward.

Use OS network constraints, but keep runtime error handling. Treat schedules as
best-effort; do not promise exact execution time. Add native Android/iOS setup
only when required by the installed plugin version, and preserve existing app
identifiers and deployment settings.

## Presentation and state

Keep the Riverpod providers and controller together in the entity controller
file unless they become large enough to justify separation. The UI must:

- load local data on startup;
- provide create, edit, delete, and manual Sync actions;
- update immediately after local CRUD;
- show pending/failed state and pending count without blocking normal use;
- show useful sync summaries/errors;
- refresh local state after returning from a possible background run;
- avoid CRUD controls for any entity outside the user's requested scope.

Keep validation in the model/repository even if the form also validates for a
better user experience.

## Verification

Add focused tests using in-memory SQLite and fake remote/connectivity adapters.
At minimum cover:

1. offline create/update/delete without any API;
2. pending-create coalescing and deletion without a tombstone;
3. tombstone creation for a synchronized row;
4. local-newer conflict pushed to server;
5. server-newer conflict applied locally;
6. exact-tie behavior;
7. server tombstone pull;
8. transient failure persistence/backoff and later retry;
9. manual force retry;
10. a presentation smoke test.

Run formatting, `flutter analyze`, and `flutter test`. If native background
configuration changed, attempt the relevant native build. Distinguish host/tool
failures from source failures and report them accurately.

## Documentation and handoff

Update the project documentation with the new entity's field mapping, API
routes, database migration, CRUD flow, conflict policy, retry behavior,
configuration, platform setup, known backend limitations, and verification
results. Keep the existing Category guide intact unless the shared architecture
actually changes.

Before finishing, confirm:

- only the requested entity received CRUD;
- normal operations never require internet;
- all pending work survives restart and failure;
- timestamps and delete semantics match the server;
- manual and background sync use the same engine;
- existing unrelated user changes were preserved;
- tests and analysis results are stated, including any verification blocker.
