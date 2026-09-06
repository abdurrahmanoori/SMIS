# Implement Multiple Account Switching

Support multiple account login and switching, allowing users to switch between saved sessions without re-entering credentials.

## Proposed Changes

### [Authentication Service]

#### [MODIFY] [auth_session_store.dart](file:///E:/Repo/SMIS/smis_flutter/lib/services/auth_session_store.dart)
- Update `AuthSessionStore` interface to include:
    - `getAllSavedSessions()`: Retrieves all previously logged-in sessions.
    - `removeSession(String userId)`: Deletes a specific session.
    - `activateSession(String userId)`: Sets a saved session as the active one.
- Update `SecureAuthSessionStore` to persist the list of saved sessions using a new storage key.
- Update `save()` to automatically add/update the session in the saved list.
- Update `clear()` to only clear the active session, renamed to `clearActiveSession()` (or kept as `clear()` for logout, while keeping saved ones).

### [Authentication Controller]

#### [MODIFY] [auth_controller.dart](file:///E:/Repo/SMIS/smis_flutter/lib/controllers/auth_controller.dart)
- Update `AuthState` to include `savedSessions`.
- Update `AuthController` to:
    - Load saved sessions on initialization.
    - Implement `switchAccount(String userId)` to swap the active session.
    - Implement `removeAccount(String userId)` to remove a saved session.
    - Update `login` to handle the multiple sessions logic.
    - Update `logout` to clear the active session but keep saved ones (allowing switching back).

## Verification Plan

### Manual Verification
- Log in with Account A -> Verify it's saved.
- Log in with Account B -> Verify it's saved.
- Switch back to Account A -> Verify Account A is active without password prompt.
- Remove Account B -> Verify it's no longer in the switcher.
- Logout from Account A -> Verify Account A is still in the switcher but not active.
