import 'unit_of_measure_local_record.dart';

class UnitOfMeasureRemoteModel {
  const UnitOfMeasureRemoteModel({
    required this.id,
    required this.name,
    required this.symbol,
    required this.shopId,
    required this.lastModifiedUtc,
    required this.isDeleted,
    this.description,
    this.createdDate,
    this.updatedDate,
    this.createdBy,
    this.updatedBy,
    this.clientCreatedDate,
    this.clientModifiedDate,
    this.clientCreatedBy,
    this.clientModifiedBy,
    DateTime? conflictModifiedUtc,
  }) : conflictModifiedUtc = conflictModifiedUtc ?? lastModifiedUtc;

  final String id;
  final String name;
  final String symbol;
  final String? description;
  final String shopId;
  final DateTime lastModifiedUtc;
  final bool isDeleted;
  final DateTime? createdDate;
  final DateTime? updatedDate;
  final String? createdBy;
  final String? updatedBy;
  final DateTime? clientCreatedDate;
  final DateTime? clientModifiedDate;
  final String? clientCreatedBy;
  final String? clientModifiedBy;
  final DateTime conflictModifiedUtc;

  factory UnitOfMeasureRemoteModel.fromJson(Map<String, dynamic> json) {
    final lastModifiedUtc = _requiredDate(json, 'lastModifiedUtc');
    final createdDate = _optionalDate(json['createdDate']);
    final updatedDate = _optionalDate(json['updatedDate']);
    final clientCreatedDate = _optionalDate(json['clientCreatedDate']);
    final clientModifiedDate = _optionalDate(json['clientModifiedDate']);
    return UnitOfMeasureRemoteModel(
      id: json['id'] as String,
      name: json['name'] as String,
      symbol: json['symbol'] as String,
      description: json['description'] as String?,
      shopId: json['shopId'] as String? ?? '',
      lastModifiedUtc: lastModifiedUtc,
      isDeleted: json['isDeleted'] as bool? ?? false,
      createdDate: createdDate,
      updatedDate: updatedDate,
      createdBy: json['createdBy'] as String?,
      updatedBy: json['updatedBy'] as String?,
      clientCreatedDate: clientCreatedDate,
      clientModifiedDate: clientModifiedDate,
      clientCreatedBy: json['clientCreatedBy'] as String?,
      clientModifiedBy: json['clientModifiedBy'] as String?,
      conflictModifiedUtc:
          _optionalDate(json['conflictModifiedUtc']) ??
          clientModifiedDate ??
          updatedDate ??
          clientCreatedDate ??
          createdDate ??
          lastModifiedUtc,
    );
  }

  static Map<String, Object?> createPayload(UnitOfMeasureLocalRecord record) => {
    'id': record.id,
    'name': record.name,
    'symbol': record.symbol,
    'description': record.description,
    'clientCreatedDate': record.createdAt.toUtc().toIso8601String(),
    'clientModifiedDate': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static Map<String, Object?> updatePayload(UnitOfMeasureLocalRecord record) => {
    'name': record.name,
    'symbol': record.symbol,
    'description': record.description,
    'clientModifiedDate': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static Map<String, Object?> deletePayload(UnitOfMeasureLocalRecord record) => {
    'clientModifiedDate': record.lastModifiedUtc.toUtc().toIso8601String(),
  };

  static DateTime _requiredDate(Map<String, dynamic> json, String key) =>
      DateTime.parse(json[key] as String).toUtc();

  static DateTime? _optionalDate(Object? value) =>
      value == null ? null : DateTime.parse(value as String).toUtc();
}
