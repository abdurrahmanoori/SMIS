abstract interface class PowerSyncUploadHandler {
  String get table;

  Future<void> create(String id, Map<String, dynamic> row);

  Future<void> update(String id, Map<String, dynamic> row);

  Future<void> delete(String id, String lastModifiedUtc);
}

String normalizePowerSyncTimestamp(String value) {
  var normalized = value.trim().replaceFirst(' ', 'T');
  final hasTimeZone =
      normalized.endsWith('Z') ||
      normalized.endsWith('z') ||
      RegExp(r'[+-]\d{2}:?\d{2}$').hasMatch(normalized);

  if (!hasTimeZone) {
    normalized = '${normalized}Z';
  }

  // Validate while preserving SQL Server datetime2 fractional precision.
  DateTime.parse(normalized);
  return normalized;
}
