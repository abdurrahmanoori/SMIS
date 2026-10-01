import 'dart:convert';

import 'package:dio/dio.dart';
import 'package:flutter/material.dart';

import '../config/flavor_config.dart';
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

class ApiErrorDetail {
  const ApiErrorDetail({
    required this.description,
    this.code,
    this.property,
    this.type,
  });

  final String? code;
  final String? property;
  final String description;
  final String? type;

  factory ApiErrorDetail.fromMap(
    Map<dynamic, dynamic> json, {
    String? fallbackProperty,
  }) {
    String? text(Object? value) {
      if (value == null) return null;
      final result = value.toString();
      return result.isEmpty ? null : result;
    }

    return ApiErrorDetail(
      code: text(json['code'] ?? json['Code']),
      property: text(json['property'] ?? json['Property']) ?? fallbackProperty,
      description:
          text(
            json['description'] ??
                json['Description'] ??
                json['message'] ??
                json['Message'],
          ) ??
          'The server rejected the request.',
      type: text(json['type'] ?? json['Type']),
    );
  }

  Map<String, Object?> toJson() => {
    'code': code,
    'property': property,
    'description': description,
    'type': type,
  };
}

abstract class RemoteException extends AppException {
  const RemoteException(
    super.message, {
    super.cause,
    this.statusCode,
    this.title,
    this.detail,
    this.errors = const <ApiErrorDetail>[],
    this.traceId,
    this.exceptionId,
    this.rawResponse,
    this.requestMethod,
    this.requestPath,
  });

  final int? statusCode;
  final String? title;
  final String? detail;
  final List<ApiErrorDetail> errors;
  final String? traceId;
  final String? exceptionId;
  final Object? rawResponse;
  final String? requestMethod;
  final String? requestPath;

  bool get isServerResponse => statusCode != null || rawResponse != null;

  String? get referenceId => exceptionId ?? traceId;

  List<String> get serverMessages {
    final result = <String>[];

    void add(String? value) {
      if (value == null || value.isEmpty || result.contains(value)) return;
      result.add(value);
    }

    for (final error in errors) {
      add(error.description);
    }

    add(detail);
    if (result.isEmpty) add(title);
    if (result.isEmpty && rawResponse is String) add(rawResponse as String);
    if (result.isEmpty) add(message);

    return List.unmodifiable(result);
  }

  Map<String, List<ApiErrorDetail>> get fieldErrors {
    final result = <String, List<ApiErrorDetail>>{};
    for (final error in errors) {
      final property = error.property;
      if (property == null || property.isEmpty) continue;
      result.putIfAbsent(property, () => <ApiErrorDetail>[]).add(error);
    }
    return result;
  }
}

class RemoteTransientException extends RemoteException {
  const RemoteTransientException(
    super.message, {
    super.cause,
    super.statusCode,
    super.title,
    super.detail,
    super.errors,
    super.traceId,
    super.exceptionId,
    super.rawResponse,
    super.requestMethod,
    super.requestPath,
  });
}

class RemotePermanentException extends RemoteException {
  const RemotePermanentException(
    super.message, {
    super.cause,
    super.statusCode,
    super.title,
    super.detail,
    super.errors,
    super.traceId,
    super.exceptionId,
    super.rawResponse,
    super.requestMethod,
    super.requestPath,
  });
}

class AuthenticationException extends RemotePermanentException {
  const AuthenticationException(
    super.message, {
    super.cause,
    super.statusCode,
    super.title,
    super.detail,
    super.errors,
    super.traceId,
    super.exceptionId,
    super.rawResponse,
    super.requestMethod,
    super.requestPath,
  });
}

class AuthorizationException extends RemotePermanentException {
  const AuthorizationException(
    super.message, {
    super.cause,
    super.statusCode,
    super.title,
    super.detail,
    super.errors,
    super.traceId,
    super.exceptionId,
    super.rawResponse,
    super.requestMethod,
    super.requestPath,
  });
}

class ValidationException extends RemotePermanentException {
  const ValidationException(
    super.message, {
    super.cause,
    super.statusCode,
    super.title,
    super.detail,
    super.errors,
    super.traceId,
    super.exceptionId,
    super.rawResponse,
    super.requestMethod,
    super.requestPath,
  });
}

class NotFoundException extends RemotePermanentException {
  const NotFoundException(
    super.message, {
    super.cause,
    super.statusCode,
    super.title,
    super.detail,
    super.errors,
    super.traceId,
    super.exceptionId,
    super.rawResponse,
    super.requestMethod,
    super.requestPath,
  });
}

class ConflictException extends RemotePermanentException {
  const ConflictException(
    super.message, {
    super.cause,
    super.statusCode,
    super.title,
    super.detail,
    super.errors,
    super.traceId,
    super.exceptionId,
    super.rawResponse,
    super.requestMethod,
    super.requestPath,
  });
}

class BusinessRuleException extends RemotePermanentException {
  const BusinessRuleException(
    super.message, {
    super.cause,
    super.statusCode,
    super.title,
    super.detail,
    super.errors,
    super.traceId,
    super.exceptionId,
    super.rawResponse,
    super.requestMethod,
    super.requestPath,
  });
}

class CategoryInUseException extends ValidationException {
  CategoryInUseException(this.productCount)
    : super('Category is used by $productCount product(s).');

  final int productCount;
}

class CategoryAlreadyExistsException extends ValidationException {
  CategoryAlreadyExistsException({Object? cause})
    : super(
        'A category with this name already exists in this shop.',
        cause: cause,
      );
}

class UnitOfMeasureInUseException extends ValidationException {
  UnitOfMeasureInUseException(this.productCount)
    : super('Unit of measurement is used by $productCount product(s).');

  final int productCount;
}

class ShopInUseException extends ValidationException {
  ShopInUseException(this.recordCount)
    : super('Shop contains $recordCount local record(s).');

  final int recordCount;
}

class ApiErrorParser {
  static Never mapAndThrow(
    Object error,
    StackTrace stackTrace, {
    String? fallbackMessage,
  }) {
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

    final response = error.response;
    final status = response?.statusCode;

    if (response == null || status == null) {
      Error.throwWithStackTrace(
        RemoteTransientException(
          fallbackMessage ?? _networkMessage(error),
          cause: error,
          requestMethod: error.requestOptions.method,
          requestPath: error.requestOptions.path,
        ),
        stackTrace,
      );
    }

    final parsed = _ParsedApiResponse.from(response.data);
    final message =
        parsed.primaryMessage ??
        fallbackMessage ??
        error.message ??
        'The server request failed.';

    final named = _RemoteMetadata(
      statusCode: status,
      title: parsed.title,
      detail: parsed.detail,
      errors: parsed.errors,
      traceId: parsed.traceId,
      exceptionId: parsed.exceptionId,
      rawResponse: response.data,
      requestMethod: error.requestOptions.method,
      requestPath: error.requestOptions.path,
    );

    final RemoteException mapped;
    if (status == 401) {
      mapped = AuthenticationException(
        message,
        cause: error,
        statusCode: named.statusCode,
        title: named.title,
        detail: named.detail,
        errors: named.errors,
        traceId: named.traceId,
        exceptionId: named.exceptionId,
        rawResponse: named.rawResponse,
        requestMethod: named.requestMethod,
        requestPath: named.requestPath,
      );
    } else if (status == 403) {
      mapped = AuthorizationException(
        message,
        cause: error,
        statusCode: named.statusCode,
        title: named.title,
        detail: named.detail,
        errors: named.errors,
        traceId: named.traceId,
        exceptionId: named.exceptionId,
        rawResponse: named.rawResponse,
        requestMethod: named.requestMethod,
        requestPath: named.requestPath,
      );
    } else if (status == 400) {
      mapped = ValidationException(
        message,
        cause: error,
        statusCode: named.statusCode,
        title: named.title,
        detail: named.detail,
        errors: named.errors,
        traceId: named.traceId,
        exceptionId: named.exceptionId,
        rawResponse: named.rawResponse,
        requestMethod: named.requestMethod,
        requestPath: named.requestPath,
      );
    } else if (status == 404) {
      mapped = NotFoundException(
        message,
        cause: error,
        statusCode: named.statusCode,
        title: named.title,
        detail: named.detail,
        errors: named.errors,
        traceId: named.traceId,
        exceptionId: named.exceptionId,
        rawResponse: named.rawResponse,
        requestMethod: named.requestMethod,
        requestPath: named.requestPath,
      );
    } else if (status == 409) {
      mapped = ConflictException(
        message,
        cause: error,
        statusCode: named.statusCode,
        title: named.title,
        detail: named.detail,
        errors: named.errors,
        traceId: named.traceId,
        exceptionId: named.exceptionId,
        rawResponse: named.rawResponse,
        requestMethod: named.requestMethod,
        requestPath: named.requestPath,
      );
    } else if (status == 422) {
      mapped = BusinessRuleException(
        message,
        cause: error,
        statusCode: named.statusCode,
        title: named.title,
        detail: named.detail,
        errors: named.errors,
        traceId: named.traceId,
        exceptionId: named.exceptionId,
        rawResponse: named.rawResponse,
        requestMethod: named.requestMethod,
        requestPath: named.requestPath,
      );
    } else if (_isTransient(error, status)) {
      mapped = RemoteTransientException(
        message,
        cause: error,
        statusCode: named.statusCode,
        title: named.title,
        detail: named.detail,
        errors: named.errors,
        traceId: named.traceId,
        exceptionId: named.exceptionId,
        rawResponse: named.rawResponse,
        requestMethod: named.requestMethod,
        requestPath: named.requestPath,
      );
    } else {
      mapped = RemotePermanentException(
        message,
        cause: error,
        statusCode: named.statusCode,
        title: named.title,
        detail: named.detail,
        errors: named.errors,
        traceId: named.traceId,
        exceptionId: named.exceptionId,
        rawResponse: named.rawResponse,
        requestMethod: named.requestMethod,
        requestPath: named.requestPath,
      );
    }

    Error.throwWithStackTrace(mapped, stackTrace);
  }

  static List<ApiErrorDetail> errorsFromResponse(Object? data) =>
      _ParsedApiResponse.from(data).errors;

  static bool hasErrorCode(Object? data, String code) =>
      errorsFromResponse(data).any((error) => error.code == code);
  static bool _isTransient(DioException error, int status) =>
      status == 408 ||
      status == 429 ||
      status >= 500 ||
      error.type == DioExceptionType.connectionError ||
      error.type == DioExceptionType.connectionTimeout ||
      error.type == DioExceptionType.receiveTimeout ||
      error.type == DioExceptionType.sendTimeout;

  static String _networkMessage(DioException error) => switch (error.type) {
    DioExceptionType.connectionTimeout ||
    DioExceptionType.sendTimeout ||
    DioExceptionType.receiveTimeout => 'The server request timed out.',
    DioExceptionType.connectionError =>
      'Unable to connect to the server. Check your internet connection.',
    _ => error.message ?? 'The server request failed.',
  };
}

class _RemoteMetadata {
  const _RemoteMetadata({
    required this.statusCode,
    required this.title,
    required this.detail,
    required this.errors,
    required this.traceId,
    required this.exceptionId,
    required this.rawResponse,
    required this.requestMethod,
    required this.requestPath,
  });

  final int statusCode;
  final String? title;
  final String? detail;
  final List<ApiErrorDetail> errors;
  final String? traceId;
  final String? exceptionId;
  final Object? rawResponse;
  final String requestMethod;
  final String requestPath;
}

class _ParsedApiResponse {
  const _ParsedApiResponse({
    this.title,
    this.detail,
    this.errors = const <ApiErrorDetail>[],
    this.traceId,
    this.exceptionId,
  });

  final String? title;
  final String? detail;
  final List<ApiErrorDetail> errors;
  final String? traceId;
  final String? exceptionId;

  String? get primaryMessage {
    if (errors.isNotEmpty) {
      return errors.map((error) => error.description).join('\n');
    }
    if (detail != null && detail!.isNotEmpty) return detail;
    if (title != null && title!.isNotEmpty) return title;
    return null;
  }

  factory _ParsedApiResponse.from(Object? data) {
    if (data is String) {
      return _ParsedApiResponse(detail: data.isEmpty ? null : data);
    }

    if (data is List) {
      return _ParsedApiResponse(errors: _parseErrors(data));
    }

    if (data is! Map) return const _ParsedApiResponse();

    final map = <String, Object?>{
      for (final entry in data.entries) entry.key.toString(): entry.value,
    };

    String? text(Object? value) {
      if (value == null) return null;
      final result = value.toString();
      return result.isEmpty ? null : result;
    }

    final errors = _parseErrors(map['errors'] ?? map['Errors']);
    final detail = text(
      map['detail'] ??
          map['Detail'] ??
          map['message'] ??
          map['Message'] ??
          map['description'] ??
          map['Description'],
    );

    return _ParsedApiResponse(
      title: text(map['title'] ?? map['Title']),
      detail: detail,
      errors: errors,
      traceId: text(map['traceId'] ?? map['TraceId']),
      exceptionId: text(
        map['exceptionId'] ??
            map['ExceptionId'] ??
            map['exception'] ??
            map['Exception'],
      ),
    );
  }

  static List<ApiErrorDetail> _parseErrors(Object? value) {
    final result = <ApiErrorDetail>[];

    if (value is List) {
      for (final item in value) {
        if (item is Map) {
          result.add(ApiErrorDetail.fromMap(item));
        } else if (item is String && item.isNotEmpty) {
          result.add(ApiErrorDetail(description: item));
        }
      }
      return result;
    }

    if (value is Map) {
      final looksLikeSingleError =
          value.containsKey('description') ||
          value.containsKey('Description') ||
          value.containsKey('code') ||
          value.containsKey('Code');
      if (looksLikeSingleError) {
        return [ApiErrorDetail.fromMap(value)];
      }

      for (final entry in value.entries) {
        final property = entry.key.toString();
        final messages = entry.value;
        if (messages is List) {
          for (final message in messages) {
            if (message is String && message.isNotEmpty) {
              result.add(
                ApiErrorDetail(
                  property: property,
                  description: message,
                  type: 'validation',
                ),
              );
            } else if (message is Map) {
              result.add(
                ApiErrorDetail.fromMap(message, fallbackProperty: property),
              );
            }
          }
        } else if (messages is String && messages.isNotEmpty) {
          result.add(
            ApiErrorDetail(
              property: property,
              description: messages,
              type: 'validation',
            ),
          );
        }
      }
    }

    return result;
  }
}

class AppErrorPresentation {
  static List<String> messages(BuildContext context, Object error) {
    if (error is RemoteException && error.isServerResponse) {
      final serverMessages = error.serverMessages;
      if (serverMessages.isNotEmpty) return serverMessages;
    }

    if (error is CategoryInUseException) {
      return [
        context.l10n.text(
          error.productCount == 1
              ? 'This category is used by {count} product. Reassign that product before deleting the category.'
              : 'This category is used by {count} products. Reassign those products before deleting the category.',
          {'count': error.productCount},
        ),
      ];
    }

    if (error is UnitOfMeasureInUseException) {
      return [
        context.l10n.text(
          error.productCount == 1
              ? 'This unit is used by {count} product. Reassign that product before deleting the unit.'
              : 'This unit is used by {count} products. Reassign those products before deleting the unit.',
          {'count': error.productCount},
        ),
      ];
    }

    if (error is ShopInUseException) {
      return [
        context.l10n.text(
          'This shop contains {count} local records. Remove or reassign them before deleting the shop.',
          {'count': error.recordCount},
        ),
      ];
    }

    final rawMessage = error is AppException ? error.message : error.toString();
    return [context.l10n.errorMessage(rawMessage)];
  }

  static String message(BuildContext context, Object error) =>
      messages(context, error).join('\n');

  static String? referenceId(Object error) =>
      error is RemoteException ? error.referenceId : null;

  static bool get showDevelopmentDetails => FlavorConfig.isDevelopment;

  static String developmentDetails(Object error, [StackTrace? stackTrace]) {
    final lines = <String>['Type: ${error.runtimeType}'];

    if (error is RemoteException) {
      if (error.requestMethod != null || error.requestPath != null) {
        lines.add(
          'Request: ${error.requestMethod ?? ''} ${error.requestPath ?? ''}'
              .trim(),
        );
      }
      if (error.statusCode != null) lines.add('HTTP: ${error.statusCode}');
      if (error.title != null) lines.add('Title: ${error.title}');
      if (error.detail != null) lines.add('Detail: ${error.detail}');
      if (error.traceId != null) lines.add('Trace ID: ${error.traceId}');
      if (error.exceptionId != null) {
        lines.add('Exception ID: ${error.exceptionId}');
      }
      if (error.errors.isNotEmpty) {
        lines.add('Errors:');
        for (final apiError in error.errors) {
          lines.add(
            '  - code=${apiError.code ?? '-'}, type=${apiError.type ?? '-'}, '
            'property=${apiError.property ?? '-'}\n    ${apiError.description}',
          );
        }
      }
      if (error.rawResponse != null) {
        lines.add('Raw server response:');
        lines.add(_prettyJson(error.rawResponse));
      }
    }

    if (error is AppException && error.cause != null) {
      lines.add('Cause: ${error.cause.runtimeType}: ${error.cause}');
    }
    if (stackTrace != null) {
      lines.add('Stack trace:');
      lines.add(stackTrace.toString());
    }

    return lines.join('\n');
  }

  static String _prettyJson(Object? value) {
    try {
      return const JsonEncoder.withIndent('  ').convert(value);
    } catch (_) {
      return value.toString();
    }
  }
}

class AppErrorNotification {
  static void show(
    BuildContext context,
    Object error, [
    StackTrace? stackTrace,
  ]) {
    final colors = Theme.of(context).colorScheme;
    final messages = AppErrorPresentation.messages(context, error);
    final referenceId = AppErrorPresentation.referenceId(error);
    final isDevelopment = AppErrorPresentation.showDevelopmentDetails;

    final content = Column(
      mainAxisSize: MainAxisSize.min,
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        for (var index = 0; index < messages.length; index++) ...[
          if (index > 0) const SizedBox(height: 4),
          Text(messages[index]),
        ],
        if (!isDevelopment && referenceId != null) ...[
          const SizedBox(height: 6),
          Text(
            '${context.l10n.text('Reference')}: $referenceId',
            style: const TextStyle(fontSize: 11),
          ),
        ],
        if (isDevelopment && error is RemoteException) ...[
          const SizedBox(height: 6),
          Text(
            [
              if (error.statusCode != null) 'HTTP ${error.statusCode}',
              if (error.errors.isNotEmpty && error.errors.first.code != null)
                error.errors.first.code!,
              if (referenceId != null) 'ref $referenceId',
            ].join(' • '),
            style: const TextStyle(fontSize: 10, fontWeight: FontWeight.bold),
          ),
        ],
      ],
    );

    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: content,
        backgroundColor: colors.error,
        behavior: SnackBarBehavior.floating,
        duration: messages.length > 1
            ? const Duration(seconds: 8)
            : const Duration(seconds: 5),
        action: isDevelopment
            ? SnackBarAction(
                label: context.l10n.text('Details').toUpperCase(),
                textColor: colors.onError,
                onPressed: () =>
                    _showDevelopmentDetails(context, error, stackTrace),
              )
            : null,
      ),
    );
  }

  static Future<void> _showDevelopmentDetails(
    BuildContext context,
    Object error,
    StackTrace? stackTrace,
  ) => showDialog<void>(
    context: context,
    builder: (dialogContext) => AlertDialog(
      title: Text(context.l10n.text('Development details')),
      content: SizedBox(
        width: 720,
        child: SingleChildScrollView(
          child: SelectableText(
            AppErrorPresentation.developmentDetails(error, stackTrace),
            style: const TextStyle(fontFamily: 'monospace', fontSize: 11),
          ),
        ),
      ),
      actions: [
        TextButton(
          onPressed: () => Navigator.of(dialogContext).pop(),
          child: Text(context.l10n.text('Close')),
        ),
      ],
    ),
  );
}
