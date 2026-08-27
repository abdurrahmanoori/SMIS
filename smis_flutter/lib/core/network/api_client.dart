import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../error/app_exception.dart';

class ApiClient {
  ApiClient({Dio? dio})
    : dio =
          dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 20),
              sendTimeout: const Duration(seconds: 20),
              headers: {
                'Accept': 'application/json',
                if (AppConfig.authToken.isNotEmpty)
                  'Authorization': 'Bearer ${AppConfig.authToken}',
              },
            ),
          );

  final Dio dio;

  Never mapAndThrow(Object error) {
    if (error is! DioException) {
      throw RemoteTransientException(
        'The server request failed unexpectedly.',
        cause: error,
      );
    }

    final status = error.response?.statusCode;
    final message =
        _messageFrom(error.response?.data) ??
        error.message ??
        'The server request failed.';
    final transient =
        status == null ||
        status == 408 ||
        status == 429 ||
        status >= 500 ||
        error.type == DioExceptionType.connectionError ||
        error.type == DioExceptionType.connectionTimeout ||
        error.type == DioExceptionType.receiveTimeout ||
        error.type == DioExceptionType.sendTimeout;

    if (transient) {
      throw RemoteTransientException(message, cause: error);
    }
    throw RemotePermanentException(message, cause: error);
  }

  String? _messageFrom(Object? data) {
    if (data is String && data.trim().isNotEmpty) return data;
    if (data is Map<String, dynamic>) {
      final message = data['message'] ?? data['title'];
      if (message is String) return message;
    }
    if (data is List && data.isNotEmpty) {
      final first = data.first;
      if (first is Map<String, dynamic>) {
        final message = first['message'] ?? first['description'];
        if (message is String) return message;
      }
    }
    return null;
  }
}
