import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/auth_api.dart';
import '../data/data_exception.dart';
import '../models/auth_session.dart';
import '../services/auth_session_store.dart';

class AuthState {
  const AuthState({
    this.session,
    this.savedSessions = const [],
    this.isRestoring = false,
    this.isSigningIn = false,
    this.error,
  });

  final AuthSession? session;
  final List<AuthSession> savedSessions;
  final bool isRestoring;
  final bool isSigningIn;
  final Object? error;

  bool get isAuthenticated => session != null;

  String? get errorMessage => error is AppException ? (error as AppException).message : error?.toString();

  AuthState copyWith({
    AuthSession? session,
    List<AuthSession>? savedSessions,
    bool? isRestoring,
    bool? isSigningIn,
    Object? error,
    bool clearError = false,
    bool clearSession = false,
  }) => AuthState(
    session: clearSession ? null : (session ?? this.session),
    savedSessions: savedSessions ?? this.savedSessions,
    isRestoring: isRestoring ?? this.isRestoring,
    isSigningIn: isSigningIn ?? this.isSigningIn,
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
            : RemotePermanentException('Unable to restore the saved login. Please sign in again.', cause: error),
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
        error: RemoteTransientException('Unable to sign in. Please try again.', cause: error),
        isSigningIn: false,
      );
    }
  }

  Future<void> switchAccount(String userId) async {
    final session = state.savedSessions.firstWhere((s) => s.userId == userId);
    await _sessionStore.save(session);
    state = state.copyWith(session: session);
  }

  Future<void> removeAccount(String userId) async {
    await _sessionStore.deleteSession(userId);
    final savedSessions = await _sessionStore.readAll();
    final activeSession = state.session?.userId == userId ? null : state.session;
    state = state.copyWith(
      session: activeSession,
      savedSessions: savedSessions,
      clearSession: activeSession == null,
    );
  }

  Future<void> logout() async {
    await _sessionStore.clear();
    state = state.copyWith(clearSession: true);
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
    state = state.copyWith(session: updatedSession, savedSessions: savedSessions);
  }
}

final authSessionStoreProvider = Provider<AuthSessionStore>(
  (ref) => SecureAuthSessionStore(),
);

final authApiProvider = Provider<AuthApi>((ref) => DioAuthApi());

final authControllerProvider = NotifierProvider<AuthController, AuthState>(
  AuthController.new,
);
