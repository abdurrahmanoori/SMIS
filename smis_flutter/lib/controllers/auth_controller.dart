import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/auth_api.dart';
import '../models/auth_session.dart';
import '../services/auth_session_store.dart';

class AuthState {
  const AuthState({
    this.session,
    this.isRestoring = false,
    this.isSigningIn = false,
    this.errorMessage,
  });

  final AuthSession? session;
  final bool isRestoring;
  final bool isSigningIn;
  final String? errorMessage;

  bool get isAuthenticated => session != null;
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
      state = AuthState(session: session);
    } catch (_) {
      state = const AuthState(
        errorMessage: 'Unable to restore the saved login. Please sign in again.',
      );
    }
  }

  Future<void> login({required String email, required String password}) async {
    state = AuthState(session: state.session, isSigningIn: true);
    try {
      final session = await _api.login(email: email, password: password);
      await _sessionStore.save(session);
      state = AuthState(session: session);
    } on LoginException catch (error) {
      state = AuthState(errorMessage: error.message);
    } on AuthFormatException catch (error) {
      state = AuthState(errorMessage: error.message);
    } catch (_) {
      state = const AuthState(
        errorMessage: 'Unable to sign in. Please try again.',
      );
    }
  }

  Future<void> logout() async {
    await _sessionStore.clear();
    state = const AuthState();
  }

  Future<void> updateSessionProfile({String? userName, String? email}) async {
    final currentSession = state.session;
    if (currentSession == null) return;

    final updatedSession = currentSession.copyWith(
      userName: userName,
      email: email,
    );
    await _sessionStore.save(updatedSession);
    state = AuthState(session: updatedSession);
  }
}

final authSessionStoreProvider = Provider<AuthSessionStore>(
  (ref) => SecureAuthSessionStore(),
);

final authApiProvider = Provider<AuthApi>((ref) => DioAuthApi());

final authControllerProvider = NotifierProvider<AuthController, AuthState>(
  AuthController.new,
);
