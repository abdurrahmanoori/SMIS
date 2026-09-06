import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/user_profile.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

abstract interface class ProfileApi {
  Future<UserProfile> getCurrentUser();

  Future<List<ProfileLanguage>> getLanguages();

  Future<UserProfile> updateProfile(String userId, ProfileUpdateDraft draft);

  Future<void> changePassword(String userId, ChangePasswordDraft draft);
}

class DioProfileApi implements ProfileApi {
  DioProfileApi({Dio? dio, AuthSessionStore? sessionStore})
    : _sessionStore = sessionStore ?? SecureAuthSessionStore(),
      _dio =
          dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 20),
              sendTimeout: const Duration(seconds: 20),
              headers: const {'Accept': 'application/json'},
            ),
          ) {
    _dio.interceptors.add(BearerTokenInterceptor(_sessionStore));
  }

  final Dio _dio;
  final AuthSessionStore _sessionStore;

  @override
  Future<UserProfile> getCurrentUser() async {
    try {
      final response = await _dio.get<Map<String, dynamic>>(
        '${AppConfig.accountEndpoint}/me',
        queryParameters: const {'includeShop': true},
      );
      final data = response.data;
      if (data == null) {
        throw const RemotePermanentException('The profile response was empty.');
      }
      final profile = UserProfile.fromJson(data);
      if (profile.id.isEmpty) {
        throw const RemotePermanentException('The profile response did not contain a user ID.');
      }
      return profile;
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<List<ProfileLanguage>> getLanguages() async {
    try {
      final response = await _dio.get<Map<String, dynamic>>(
        AppConfig.languageEndpoint,
        queryParameters: const {'pageNumber': 1, 'pageSize': 100},
      );
      final data = response.data;
      final items = data?['items'] ?? data?['Items'];
      if (items is! List) return const <ProfileLanguage>[];
      return items
          .whereType<Map>()
          .map((item) => ProfileLanguage.fromJson(Map<String, dynamic>.from(item)))
          .where((language) => language.id.isNotEmpty && language.name.isNotEmpty)
          .toList(growable: false);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<UserProfile> updateProfile(
    String userId,
    ProfileUpdateDraft draft,
  ) async {
    try {
      final response = await _dio.put<Map<String, dynamic>>(
        '${AppConfig.accountEndpoint}/$userId',
        data: draft.normalized().toJson(),
      );
      final data = response.data;
      if (data == null) {
        throw const RemotePermanentException('The profile update response was empty.');
      }
      return UserProfile.fromJson(data);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<void> changePassword(
    String userId,
    ChangePasswordDraft draft,
  ) async {
    try {
      await _dio.post<void>(
        '${AppConfig.accountEndpoint}/$userId/change-password',
        data: draft.normalized().toJson(),
      );
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }
}
