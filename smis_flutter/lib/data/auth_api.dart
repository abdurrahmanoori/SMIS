import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/auth_session.dart';

abstract interface class AuthApi {
  Future<AuthSession> login({required String email, required String password});
}

class DioAuthApi implements AuthApi {
  DioAuthApi({Dio? dio})
    : _dio =
          dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 20),
              sendTimeout: const Duration(seconds: 20),
              headers: const {'Accept': 'application/json'},
            ),
          );

  final Dio _dio;

  @override
  Future<AuthSession> login({
    required String email,
    required String password,
  }) async {
    try {
      final response = await _dio.post<Map<String, dynamic>>(
        AppConfig.loginEndpoint,
        data: {'email': email.trim(), 'password': password},
      );
      final data = response.data;
      if (data == null) {
        throw const AuthFormatException('The login response was empty.');
      }
      return AuthSession.fromJson(data);
    } on DioException catch (error) {
      throw LoginException(_messageFrom(error.response?.data) ?? _fallback(error));
    }
  }

  String _fallback(DioException error) {
    if (error.type == DioExceptionType.connectionError ||
        error.type == DioExceptionType.connectionTimeout ||
        error.type == DioExceptionType.receiveTimeout ||
        error.type == DioExceptionType.sendTimeout) {
      return 'Unable to reach the server. Check your connection and try again.';
    }
    if (error.response?.statusCode == 401 || error.response?.statusCode == 403) {
      return 'Invalid email or password.';
    }
    return 'Unable to sign in. Please try again.';
  }

  String? _messageFrom(Object? data) {
    if (data is String && data.trim().isNotEmpty) return data;
    if (data is List && data.isNotEmpty) {
      return _messageFrom(data.first);
    }
    if (data is Map) {
      final message = data['message'] ?? data['Message'] ?? data['title'];
      if (message is String && message.trim().isNotEmpty) return message;
      final errors = data['errors'] ?? data['Errors'];
      if (errors is List && errors.isNotEmpty) {
        final first = errors.first;
        if (first is String && first.trim().isNotEmpty) return first;
        if (first is Map) {
          final errorMessage =
              first['message'] ?? first['Message'] ?? first['description'];
          if (errorMessage is String && errorMessage.trim().isNotEmpty) {
            return errorMessage;
          }
        }
      }
      final description = data['description'] ?? data['Description'];
      if (description is String && description.trim().isNotEmpty) {
        return description;
      }
    }
    return null;
  }
}

class LoginException implements Exception {
  const LoginException(this.message);

  final String message;

  @override
  String toString() => message;
}
