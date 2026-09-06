import 'dart:convert';

import 'package:flutter_secure_storage/flutter_secure_storage.dart';

import '../models/auth_session.dart';

abstract interface class AuthSessionStore {
  Future<AuthSession?> read();

  Future<void> save(AuthSession session);

  Future<void> clear();
}

class SecureAuthSessionStore implements AuthSessionStore {
  SecureAuthSessionStore({FlutterSecureStorage? secureStorage})
    : _secureStorage = secureStorage ?? const FlutterSecureStorage();

  static const _sessionKey = 'smis.auth.session.v1';

  final FlutterSecureStorage _secureStorage;

  @override
  Future<AuthSession?> read() async {
    final rawSession = await _secureStorage.read(key: _sessionKey);
    if (rawSession == null || rawSession.isEmpty) return null;

    try {
      final decoded = jsonDecode(rawSession);
      if (decoded is! Map<String, dynamic>) {
        await clear();
        return null;
      }
      return AuthSession.fromJson(decoded);
    } on FormatException catch (_) {
      await clear();
      return null;
    } on AuthFormatException catch (_) {
      await clear();
      return null;
    }
  }

  @override
  Future<void> save(AuthSession session) => _secureStorage.write(
    key: _sessionKey,
    value: jsonEncode(session.toJson()),
  );

  @override
  Future<void> clear() => _secureStorage.delete(key: _sessionKey);
}
