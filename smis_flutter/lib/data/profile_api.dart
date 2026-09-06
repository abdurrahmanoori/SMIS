import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/user_profile.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';

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
        throw const ProfileApiException('The profile response was empty.');
      }
      final profile = UserProfile.fromJson(data);
      if (profile.id.isEmpty) {
        throw const ProfileApiException('The profile response did not contain a user ID.');
      }
      return profile;
    } on DioException catch (error) {
      throw ProfileApiException(_messageFrom(error.response?.data) ?? _fallback(error));
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
    } on DioException catch (error) {
      throw ProfileApiException(_messageFrom(error.response?.data) ?? _fallback(error));
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
        throw const ProfileApiException('The profile update response was empty.');
      }
      return UserProfile.fromJson(data);
    } on DioException catch (error) {
      throw ProfileApiException(_messageFrom(error.response?.data) ?? _fallback(error));
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
    } on DioException catch (error) {
      throw ProfileApiException(_messageFrom(error.response?.data) ?? _fallback(error));
    }
  }

  String _fallback(DioException error) {
    if (error.type == DioExceptionType.connectionError ||
        error.type == DioExceptionType.connectionTimeout ||
        error.type == DioExceptionType.receiveTimeout ||
        error.type == DioExceptionType.sendTimeout) {
      return 'Unable to reach the server. Check your connection and try again.';
    }
    if (error.response?.statusCode == 401) {
      return 'Your login session has expired. Please sign in again.';
    }
    return 'Unable to update your profile. Please try again.';
  }

  String? _messageFrom(Object? data) {
    if (data is String && data.trim().isNotEmpty) return data;
    if (data is List) return _firstMessage(data);
    if (data is Map) {
      // ASP.NET Core validation responses usually put a generic title such as
      // "One or more validation errors occurred." beside field-specific
      // messages in `errors`. Prefer the useful field message for the user.
      final validationMessage = _firstMessage(data['errors'] ?? data['Errors']);
      if (validationMessage != null) return validationMessage;

      final message = data['message'] ?? data['Message'] ?? data['title'];
      if (message is String && message.trim().isNotEmpty) return message;
      final description = data['description'] ?? data['Description'];
      if (description is String && description.trim().isNotEmpty) {
        return description;
      }
    }
    return null;
  }

  String? _firstMessage(Object? value) {
    if (value is String && value.trim().isNotEmpty) return value;
    if (value is List) {
      for (final item in value) {
        final message = _firstMessage(item);
        if (message != null) return message;
      }
    }
    if (value is Map) {
      final directMessage =
          value['message'] ?? value['Message'] ?? value['description'] ?? value['Description'];
      if (directMessage is String && directMessage.trim().isNotEmpty) {
        return directMessage;
      }
      for (final item in value.values) {
        final message = _firstMessage(item);
        if (message != null) return message;
      }
    }
    return null;
  }
}

class ProfileApiException implements Exception {
  const ProfileApiException(this.message);

  final String message;

  @override
  String toString() => message;
}
