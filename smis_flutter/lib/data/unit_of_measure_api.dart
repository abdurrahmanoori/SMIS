import 'package:dio/dio.dart';

import '../config/app_config.dart';
import '../models/unit_of_measure_local_record.dart';
import '../models/unit_of_measure_remote_model.dart';
import '../services/auth_session_store.dart';
import '../services/bearer_token_interceptor.dart';
import 'data_exception.dart';

abstract interface class UnitOfMeasureApi {
  Future<List<UnitOfMeasureRemoteModel>> pull(DateTime changedSince);

  Future<UnitOfMeasureRemoteModel?> getById(String id);

  Future<UnitOfMeasureRemoteModel> create(UnitOfMeasureLocalRecord unit);

  Future<UnitOfMeasureRemoteModel> update(UnitOfMeasureLocalRecord unit);

  Future<void> delete(UnitOfMeasureLocalRecord unit);
}

class DioUnitOfMeasureApi implements UnitOfMeasureApi {
  DioUnitOfMeasureApi({Dio? dio, AuthSessionStore? sessionStore})
    : _sessionStore = sessionStore ?? SecureAuthSessionStore(),
      _dio =
          dio ??
          Dio(
            BaseOptions(
              baseUrl: AppConfig.apiBaseUrl,
              connectTimeout: const Duration(seconds: 10),
              receiveTimeout: const Duration(seconds: 20),
              sendTimeout: const Duration(seconds: 20),
              headers: {'Accept': 'application/json'},
            ),
          ) {
    _dio.interceptors.add(BearerTokenInterceptor(_sessionStore));
  }

  final Dio _dio;
  final AuthSessionStore _sessionStore;

  @override
  Future<List<UnitOfMeasureRemoteModel>> pull(DateTime changedSince) async {
    try {
      final response = await _dio.get<List<dynamic>>(
        '${AppConfig.unitOfMeasureEndpoint}/pull',
        queryParameters: {
          'changedSince': changedSince.toUtc().toIso8601String(),
        },
      );
      return (response.data ?? const <dynamic>[])
          .map(
            (item) => UnitOfMeasureRemoteModel.fromJson(
              Map<String, dynamic>.from(item as Map),
            ),
          )
          .toList(growable: false);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<UnitOfMeasureRemoteModel?> getById(String id) async {
    try {
      final response = await _dio.get<Map<String, dynamic>>(
        '${AppConfig.unitOfMeasureEndpoint}/$id',
      );
      return UnitOfMeasureRemoteModel.fromJson(response.data!);
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return null;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<UnitOfMeasureRemoteModel> create(UnitOfMeasureLocalRecord unit) async {
    try {
      final response = await _dio.post<Map<String, dynamic>>(
        '${AppConfig.unitOfMeasureEndpoint}/sync',
        data: UnitOfMeasureRemoteModel.createPayload(unit),
      );
      return UnitOfMeasureRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<UnitOfMeasureRemoteModel> update(UnitOfMeasureLocalRecord unit) async {
    try {
      final response = await _dio.put<Map<String, dynamic>>(
        '${AppConfig.unitOfMeasureEndpoint}/${unit.id}/sync',
        data: UnitOfMeasureRemoteModel.updatePayload(unit),
      );
      return UnitOfMeasureRemoteModel.fromJson(response.data!);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }

  @override
  Future<void> delete(UnitOfMeasureLocalRecord unit) async {
    try {
      await _dio.delete<void>(
        '${AppConfig.unitOfMeasureEndpoint}/${unit.id}/sync',
        data: UnitOfMeasureRemoteModel.deletePayload(unit),
      );
    } on DioException catch (error, stackTrace) {
      if (error.response?.statusCode == 404) return;
      ApiErrorParser.mapAndThrow(error, stackTrace);
    } catch (error, stackTrace) {
      ApiErrorParser.mapAndThrow(error, stackTrace);
    }
  }
}
