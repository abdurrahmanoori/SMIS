import 'package:dio/dio.dart';
import 'package:uuid/uuid.dart';

import '../config/app_config.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

typedef StockJson = Map<String, dynamic>;

StockJson _object(Object? value) => Map<String, dynamic>.from(value as Map);
List<StockJson> _list(Object? value) =>
    (value as List).map((item) => _object(item)).toList();

String stockText(StockJson row, String key) => (row[key] ?? '').toString();
num stockNumber(StockJson row, String key) =>
    (row[key] as num?) ?? num.tryParse((row[key] ?? '').toString()) ?? 0;

/// Inventory changes are posted by the API as atomic ledger transactions.
class StockApi {
  StockApi({Dio? dio, AuthSessionStore? sessionStore})
    : _dio = dio ??
          Dio(BaseOptions(
            baseUrl: AppConfig.apiBaseUrl,
            connectTimeout: const Duration(seconds: 10),
            receiveTimeout: const Duration(seconds: 25),
            sendTimeout: const Duration(seconds: 25),
            headers: const {'Accept': 'application/json'},
          )) {
    _dio.interceptors.add(
      BearerTokenInterceptor(sessionStore ?? SecureAuthSessionStore()),
    );
  }

  final Dio _dio;
  static const _uuid = Uuid();

  Future<T> _request<T>(Future<T> Function() action) async {
    try {
      return await action();
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  Future<List<StockJson>> batches() => _request(() async {
    final batches = <StockJson>[];
    const size = 100;
    for (var page = 1; ; page++) {
      Response<StockJson> response;
      try {
        response = await _dio.get<StockJson>(
          AppConfig.stockBatchEndpoint,
          queryParameters: {'pageNumber': page, 'pageSize': size},
        );
      } on DioException catch (error) {
        // The existing list endpoint returns 400/EmptyList for an empty page.
        final body = error.response?.data;
        if (body is List &&
            body.any((item) => item is Map && item['code'] == 'EmptyList')) {
          break;
        }
        rethrow;
      }
      final items = _list(response.data?['items'] ?? response.data?['Items'] ?? []);
      batches.addAll(items);
      if (items.length < size) break;
    }
    return batches;
  });

  Future<void> receive({
    required String productId,
    required String productUnitId,
    required num quantity,
    required int unitCostBase,
    String? batchNumber,
    String? expirationDate,
  }) => _request(() async {
    await _dio.post<Object?>(
      AppConfig.stockBatchEndpoint,
      data: {
        'productId': productId,
        'receivedProductUnitId': productUnitId,
        'receivedQuantity': quantity,
        'unitCostBase': unitCostBase,
        'batchNumber': batchNumber,
        'expirationDate': expirationDate,
        'idempotencyKey': _uuid.v4(),
      },
    );
  });

  Future<void> updateBatch(
    String id, {
    String? batchNumber,
    String? expirationDate,
    String? status,
  }) => _request(() async {
    await _dio.put<Object?>(
      AppConfig.stockBatchEndpoint + '/' + id,
      data: {
        'batchNumber': batchNumber,
        'expirationDate': expirationDate,
        'status': status,
      },
    );
  });

  Future<void> postBatchOperation({
    required String path,
    required String batchId,
    required String productUnitId,
    required num quantity,
    String? direction,
  }) => _request(() async {
    await _dio.post<Object?>(
      AppConfig.inventoryEndpoint + '/' + path,
      data: {
        'stockBatchId': batchId,
        'productUnitId': productUnitId,
        'quantityEntered': quantity,
        if (direction != null) 'direction': direction,
        'idempotencyKey': _uuid.v4(),
      },
    );
  });

  Future<void> transfer({
    required String sourceId,
    required String destinationId,
    required String productUnitId,
    required num quantity,
  }) => _request(() async {
    await _dio.post<Object?>(
      AppConfig.inventoryEndpoint + '/transfers',
      data: {
        'sourceStockBatchId': sourceId,
        'destinationStockBatchId': destinationId,
        'productUnitId': productUnitId,
        'quantityEntered': quantity,
        'idempotencyKey': _uuid.v4(),
      },
    );
  });

  Future<StockJson> startCount(List<String> batchIds) => _request(() async {
    final response = await _dio.post<StockJson>(
      AppConfig.inventoryEndpoint + '/stock-counts',
      data: {'stockBatchIds': batchIds},
    );
    return _object(response.data);
  });

  Future<StockJson> getCount(String id) => _request(() async {
    final response = await _dio.get<StockJson>(
      AppConfig.inventoryEndpoint + '/stock-counts/' + id,
    );
    return _object(response.data);
  });

  Future<void> completeCount(String id, List<StockJson> counts) =>
      _request(() async {
        await _dio.post<Object?>(
          AppConfig.inventoryEndpoint + '/stock-counts/' + id + '/complete',
          data: {'counts': counts, 'idempotencyKey': _uuid.v4()},
        );
      });

  Future<void> cancelCount(String id) => _request(() async {
    await _dio.post<Object?>(
      AppConfig.inventoryEndpoint + '/stock-counts/' + id + '/cancel',
    );
  });

  Future<List<StockJson>> report(String path, {
    Map<String, dynamic>? query,
  }) => _request(() async {
    final response = await _dio.get<List<dynamic>>(
      AppConfig.inventoryEndpoint + '/reports/' + path,
      queryParameters: query,
    );
    return _list(response.data ?? []);
  });

  Future<StockJson> valuation() => _request(() async {
    final response = await _dio.get<StockJson>(
      AppConfig.inventoryEndpoint + '/reports/valuation',
    );
    return _object(response.data);
  });

  Future<List<StockJson>> reconciliation({bool onlyMismatches = true}) =>
      _request(() async {
        final response = await _dio.get<List<dynamic>>(
          AppConfig.inventoryEndpoint + '/reconciliation',
          queryParameters: {'onlyMismatches': onlyMismatches},
        );
        return _list(response.data ?? []);
      });

  Future<void> reverse(String movementId) => _request(() async {
    await _dio.post<Object?>(
      AppConfig.stockMovementEndpoint + '/' + movementId + '/reverse',
    );
  });
}
