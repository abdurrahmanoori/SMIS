abstract interface class PowerSyncUploadHandler {
  String get table;

  Future<void> create(String id, Map<String, dynamic> row);

  Future<void> update(String id, Map<String, dynamic> row);

  Future<void> delete(String id, String lastModifiedUtc);
}
