import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/auth_api.dart';
import '../data/data_exception.dart';
import '../models/auth_session.dart';
import '../services/auth_session_store.dart';
import 'app_dependencies.dart';

class AuthState {
  const AuthState({
    this.session,
    this.savedSessions = const [],
    this.isRestoring = false,
    this.isSigningIn = false,
    this.isSwitchingAccount = false,
    this.isSwitchingShop = false,
    this.error,
  });

  final AuthSession? session;
  final List<AuthSession> savedSessions;
  final bool isRestoring;
  final bool isSigningIn;
  final bool isSwitchingAccount;
  final bool isSwitchingShop;
  final Object? error;

  bool get isAuthenticated => session != null;

  String? get errorMessage => error is AppException
      ? (error as AppException).message
      : error?.toString();

  AuthState copyWith({
    AuthSession? session,
    List<AuthSession>? savedSessions,
    bool? isRestoring,
    bool? isSigningIn,
    bool? isSwitchingAccount,
    bool? isSwitchingShop,
    Object? error,
    bool clearError = false,
    bool clearSession = false,
  }) => AuthState(
    session: clearSession ? null : (session ?? this.session),
    savedSessions: savedSessions ?? this.savedSessions,
    isRestoring: isRestoring ?? this.isRestoring,
    isSigningIn: isSigningIn ?? this.isSigningIn,
    isSwitchingAccount: isSwitchingAccount ?? this.isSwitchingAccount,
    isSwitchingShop: isSwitchingShop ?? this.isSwitchingShop,
    error: clearError ? null : (error ?? this.error),
  );
}

class AuthController extends Notifier<AuthState> {
  AuthApi get _api => ref.read(authApiProvider);

  AuthSessionStore get _sessionStore => ref.read(authSessionStoreProvider);

  @override
  AuthState build() {
    _restoreSession();
    return const AuthState(isRestoring: true);
  }

  Future<void> _restoreSession() async {
    try {
      final session = await _sessionStore.read();
      final savedSessions = await _sessionStore.readAll();
      state = AuthState(session: session, savedSessions: savedSessions);
    } catch (error) {
      state = AuthState(
        error: error is AppException
            ? error
            : RemotePermanentException(
                'Unable to restore the saved login. Please sign in again.',
                cause: error,
              ),
      );
    }
  }

  Future<void> login({required String email, required String password}) async {
    state = state.copyWith(isSigningIn: true, clearError: true);
    try {
      final session = await _api.login(email: email, password: password);
      await _sessionStore.save(session);
      final savedSessions = await _sessionStore.readAll();
      state = state.copyWith(
        session: session,
        savedSessions: savedSessions,
        isSigningIn: false,
      );
    } on AppException catch (error) {
      state = state.copyWith(error: error, isSigningIn: false);
    } catch (error) {
      state = state.copyWith(
        error: RemoteTransientException(
          'Unable to sign in. Please try again.',
          cause: error,
        ),
        isSigningIn: false,
      );
    }
  }

  Future<void> switchAccount(String userId) async {
    final target = state.savedSessions.firstWhere((s) => s.userId == userId);
    final current = state.session;
    if (current?.userId == target.userId && current?.shopId == target.shopId) {
      return;
    }

    final powerSync = ref.read(appPowerSyncDatabaseProvider);
    if (current != null) {
      final pending = await powerSync.pendingCountForCurrentContext();
      if (pending > 0) {
        state = state.copyWith(
          error: LocalStorageException(
            'Synchronize the current account before switching. '
            '$pending local change(s) are still pending.',
          ),
        );
        return;
      }
    }

    state = state.copyWith(isSwitchingAccount: true, clearError: true);
    try {
      await powerSync.close();
      await _sessionStore.save(target);
      await _connectCurrentPowerSyncContext(
        'The account changed, but PowerSync could not refresh the new account yet.',
      );

      final savedSessions = await _sessionStore.readAll();
      state = state.copyWith(
        session: target,
        savedSessions: savedSessions,
        isSwitchingAccount: false,
      );
    } catch (error) {
      await powerSync.close();
      try {
        if (current == null) {
          await _sessionStore.clear();
        } else {
          await _sessionStore.save(current);
          await powerSync.connectForCurrentSession();
        }
      } catch (_) {
        // Preserve the original switching failure. The UI still keeps the
        // previous in-memory session instead of publishing a partial switch.
      }
      state = state.copyWith(error: error, isSwitchingAccount: false);
    }
  }

  Future<AuthSession> switchShop(String shopId) async {
    final current = state.session;
    if (current == null) {
      throw const AuthenticationException(
        'You must be signed in to switch shops.',
      );
    }
    if (!current.isSuperAdmin) {
      throw const AuthenticationException(
        'Only a SuperAdmin can switch the active shop.',
      );
    }
    if (current.shopId == shopId) return current;

    state = state.copyWith(isSwitchingShop: true, clearError: true);
    try {
      final session = await _api.switchShop(shopId);
      await _sessionStore.save(session);
      final savedSessions = await _sessionStore.readAll();
      state = state.copyWith(
        session: session,
        savedSessions: savedSessions,
        isSwitchingShop: false,
      );
      return session;
    } catch (error) {
      state = state.copyWith(error: error, isSwitchingShop: false);
      rethrow;
    }
  }

  Future<void> removeAccount(String userId) async {
    await _sessionStore.deleteSession(userId);
    final savedSessions = await _sessionStore.readAll();
    final activeSession = state.session?.userId == userId
        ? null
        : state.session;
    state = state.copyWith(
      session: activeSession,
      savedSessions: savedSessions,
      clearSession: activeSession == null,
    );
  }

  Future<void> logout() async {
    Object? cleanupError;
    try {
      await ref.read(appPowerSyncDatabaseProvider).close();
    } catch (error) {
      cleanupError = error;
    }

    try {
      await _sessionStore.clear();
    } catch (error) {
      cleanupError ??= error;
    }

    if (cleanupError == null) {
      state = state.copyWith(clearSession: true, clearError: true);
    } else {
      // Do not leave the user on an authenticated screen if local cleanup
      // fails. Pending PowerSync writes remain in the isolated SQLite file and
      // can resume if the same account signs in again.
      state = state.copyWith(
        clearSession: true,
        error: LocalStorageException(
          'Signed out of this app, but some local session cleanup failed.',
          cause: cleanupError,
        ),
      );
    }
  }

  Future<void> _connectCurrentPowerSyncContext(String failureMessage) async {
    final database = await ref
        .read(appPowerSyncDatabaseProvider)
        .connectForCurrentSession();

    var status = database.currentStatus;
    if (status.hasSynced != true && status.anyError == null) {
      status = await database.statusStream
          .firstWhere(
            (value) => value.hasSynced == true || value.anyError != null,
          )
          .timeout(const Duration(seconds: 30));
    }

    if (status.anyError != null) {
      throw RemoteTransientException(failureMessage, cause: status.anyError);
    }
  }

  Future<void> updateSessionProfile({String? userName, String? email}) async {
    final currentSession = state.session;
    if (currentSession == null) return;

    final updatedSession = currentSession.copyWith(
      userName: userName,
      email: email,
    );
    await _sessionStore.save(updatedSession);
    final savedSessions = await _sessionStore.readAll();
    state = state.copyWith(
      session: updatedSession,
      savedSessions: savedSessions,
    );
  }
}

final authSessionStoreProvider = Provider<AuthSessionStore>(
  (ref) => SecureAuthSessionStore(),
);

final authApiProvider = Provider<AuthApi>((ref) => DioAuthApi());

final authControllerProvider = NotifierProvider<AuthController, AuthState>(
  AuthController.new,
);
