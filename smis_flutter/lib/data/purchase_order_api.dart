import 'dart:convert';

import 'package:dio/dio.dart';
import 'package:uuid/uuid.dart';

import '../config/app_config.dart';
import '../models/purchase_order.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

class PurchaseOrderApi {
  PurchaseOrderApi({Dio? dio, AuthSessionStore? sessionStore})
    : _dio =
          dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 25),
              sendTimeout: const Duration(seconds: 25),
              headers: const {'Accept': 'application/json'},
            ),
          ) {
    _dio.interceptors.add(
      BearerTokenInterceptor(sessionStore ?? SecureAuthSessionStore()),
    );
  }

  final Dio _dio;
  static const _uuid = Uuid();
  final Map<String, String> _retryKeys = {};

  Future<T> _request<T>(Future<T> Function() action) async {
    try {
      return await action();
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  Future<List<PurchaseOrder>> list({int page = 1}) => _request(() async {
    final response = await _dio.get<Map<String, dynamic>>(
      AppConfig.purchaseOrderEndpoint,
      queryParameters: {'pageNumber': page, 'pageSize': 25},
    );
    final rows = response.data?['items'] as List<dynamic>? ?? const [];
    return rows
        .map(
          (row) =>
              PurchaseOrder.fromJson(Map<String, dynamic>.from(row as Map)),
        )
        .toList();
  });

  Future<PurchaseOrder> create(Map<String, dynamic> payload) =>
      _post(AppConfig.purchaseOrderEndpoint, payload);

  Future<PurchaseOrder> receive(String id, Map<String, dynamic> payload) =>
      _post('${AppConfig.purchaseOrderEndpoint}/$id/receipts', payload);

  Future<PurchaseOrder> supplierReturn(
    String id,
    Map<String, dynamic> payload,
  ) =>
      _post('${AppConfig.purchaseOrderEndpoint}/$id/supplier-returns', payload);

  Future<PurchaseOrder> cancel(String id) => _request(() async {
    final response = await _dio.post<Map<String, dynamic>>(
      '${AppConfig.purchaseOrderEndpoint}/$id/cancel',
    );
    return PurchaseOrder.fromJson(response.data!);
  });

  // Keep a key for an uncertain response, including a lost response after a commit.
  // A changed payload has a different fingerprint and receives a new key.
  Future<PurchaseOrder> _post(String path, Map<String, dynamic> payload) =>
      _request(() async {
        final fingerprint = '$path:${jsonEncode(payload)}';
        final key = _retryKeys.putIfAbsent(fingerprint, _uuid.v4);
        try {
          final response = await _dio.post<Map<String, dynamic>>(
            path,
            data: {...payload, 'idempotencyKey': key},
          );
          _retryKeys.remove(fingerprint);
          return PurchaseOrder.fromJson(response.data!);
        } on DioException catch (error) {
          if (error.response?.statusCode case final status?
              when status < 500 &&
                  status != 409 &&
                  status != 408 &&
                  status != 429) {
            _retryKeys.remove(fingerprint);
          }
          rethrow;
        }
      });

  Future<List<String>> receivedBatchIds(String lineId) => _request(() async {
    final ids = <String>{};
    for (var page = 1; ; page++) {
      final response = await _dio.get<Map<String, dynamic>>(
        AppConfig.stockMovementEndpoint,
        queryParameters: {
          'referenceType': 'PurchaseOrderLine',
          'referenceId': lineId,
          'reason': 'PurchaseReceipt',
          'pageNumber': page,
          'pageSize': 100,
        },
      );
      final rows = response.data?['items'] as List<dynamic>? ?? const [];
      for (final row in rows) {
        final id = (row as Map)['stockBatchId'] as String?;
        if (id != null) ids.add(id);
      }
      if (rows.length < 100) break;
    }
    return ids.toList();
  });
}
