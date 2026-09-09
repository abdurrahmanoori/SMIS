import 'package:dio/dio.dart';
import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import '../l10n/app_localizations.dart';

sealed class AppException implements Exception {
  const AppException(this.message, {this.cause});

  final String message;
  final Object? cause;

  @override
  String toString() => message;
}

class LocalStorageException extends AppException {
  const LocalStorageException(super.message, {super.cause});
}

class RemoteTransientException extends AppException {
  const RemoteTransientException(super.message, {super.cause});
}

class RemotePermanentException extends AppException {
  const RemotePermanentException(super.message, {super.cause});
}

class AuthenticationException extends RemotePermanentException {
  const AuthenticationException(super.message, {super.cause});
}

class ValidationException extends RemotePermanentException {
  const ValidationException(super.message, {super.cause});
}

class ApiErrorParser {
  static Never mapAndThrow(Object error, StackTrace stackTrace, {String? fallbackMessage}) {
    if (error is AppException) {
      Error.throwWithStackTrace(error, stackTrace);
    }

    if (error is! DioException) {
      Error.throwWithStackTrace(
        RemoteTransientException(
          fallbackMessage ?? 'An unexpected error occurred.',
          cause: error,
        ),
        stackTrace,
      );
    }

    final status = error.response?.statusCode;
    final message =
        _messageFrom(error.response?.data) ??
        error.message ??
        fallbackMessage ??
        'The server request failed.';

    if (status == 401 || status == 403) {
      Error.throwWithStackTrace(
        AuthenticationException(message, cause: error),
        stackTrace,
      );
    }

    final isTransient =
        status == null ||
        status == 408 ||
        status == 429 ||
        status >= 500 ||
        error.type == DioExceptionType.connectionError ||
        error.type == DioExceptionType.connectionTimeout ||
        error.type == DioExceptionType.receiveTimeout ||
        error.type == DioExceptionType.sendTimeout;

    final mapped = isTransient
        ? RemoteTransientException(message, cause: error)
        : RemotePermanentException(message, cause: error);
    
    Error.throwWithStackTrace(mapped, stackTrace);
  }

  static String? _messageFrom(Object? data) {
    if (data is String && data.trim().isNotEmpty) return data;
    if (data is List) return _firstMessage(data);
    if (data is Map) {
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

  static String? _firstMessage(Object? value) {
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

class AppErrorNotification {
  static void show(BuildContext context, Object error, [StackTrace? stackTrace]) {
    final colors = Theme.of(context).colorScheme;
    final rawMessage = error is AppException ? error.message : error.toString();
    final message = context.l10n.errorMessage(rawMessage);
    
    final content = Column(
      mainAxisSize: MainAxisSize.min,
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Text(message),
        if (kDebugMode) ...[
          const SizedBox(height: 8),
          Text(
            '${context.l10n.text('Debug')}: ${error.runtimeType}',
            style: const TextStyle(fontSize: 10, fontWeight: FontWeight.bold),
          ),
          if (error is AppException && error.cause != null)
            Text(
              '${context.l10n.text('Cause')}: ${error.cause}',
              style: const TextStyle(fontSize: 10),
            ),
        ],
      ],
    );

    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: content,
        backgroundColor: colors.error,
        behavior: SnackBarBehavior.floating,
        action: kDebugMode && stackTrace != null
            ? SnackBarAction(
                label: context.l10n.text('Log').toUpperCase(),
                textColor: colors.onError,
                onPressed: () => debugPrint('Error: $error\n$stackTrace'),
              )
            : null,
      ),
    );
  }
}
