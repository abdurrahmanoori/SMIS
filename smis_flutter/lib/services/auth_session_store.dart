import 'dart:convert';

import 'package:flutter_secure_storage/flutter_secure_storage.dart';

import '../models/auth_session.dart';

abstract interface class AuthSessionStore {
  Future<AuthSession?> read();

  Future<List<AuthSession>> readAll();

  Future<void> save(AuthSession session);

  Future<void> deleteSession(String userId);

  Future<void> clear();
}

class SecureAuthSessionStore implements AuthSessionStore {
  SecureAuthSessionStore({FlutterSecureStorage? secureStorage})
    : _secureStorage = secureStorage ?? const FlutterSecureStorage();

  static const _activeSessionKey = 'smis.auth.session.v1';
  static const _allSessionsKey = 'smis.auth.sessions.v1';

  final FlutterSecureStorage _secureStorage;

  @override
  Future<AuthSession?> read() async {
    final rawSession = await _secureStorage.read(key: _activeSessionKey);
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
  Future<List<AuthSession>> readAll() async {
    final rawSessions = await _secureStorage.read(key: _allSessionsKey);
    if (rawSessions == null || rawSessions.isEmpty) return const [];

    try {
      final decoded = jsonDecode(rawSessions);
      if (decoded is! Map<String, dynamic>) return const [];
      
      return decoded.values
          .map((e) => AuthSession.fromJson(e as Map<String, dynamic>))
          .toList();
    } catch (_) {
      return const [];
    }
  }

  @override
  Future<void> save(AuthSession session) async {
    // Save as active session
    await _secureStorage.write(
      key: _activeSessionKey,
      value: jsonEncode(session.toJson()),
    );

    // Update all sessions list
    final sessions = await _readAllMap();
    sessions[session.userId] = session.toJson();
    await _secureStorage.write(
      key: _allSessionsKey,
      value: jsonEncode(sessions),
    );
  }

  @override
  Future<void> deleteSession(String userId) async {
    final sessions = await _readAllMap();
    if (sessions.containsKey(userId)) {
      sessions.remove(userId);
      await _secureStorage.write(
        key: _allSessionsKey,
        value: jsonEncode(sessions),
      );
    }

    final active = await read();
    if (active?.userId == userId) {
      await clear();
    }
  }

  @override
  Future<void> clear() => _secureStorage.delete(key: _activeSessionKey);

  Future<Map<String, dynamic>> _readAllMap() async {
    final raw = await _secureStorage.read(key: _allSessionsKey);
    if (raw == null || raw.isEmpty) return {};
    try {
      final decoded = jsonDecode(raw);
      if (decoded is Map<String, dynamic>) return decoded;
    } catch (_) {}
    return {};
  }
}
