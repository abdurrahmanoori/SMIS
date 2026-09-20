/// The legacy hourly pull/push worker is intentionally disabled now that every
/// business entity currently present in Flutter uses PowerSync.
///
/// The old custom sync services remain in the codebase as a rollback path, but
/// running them alongside PowerSync would upload the same local intent twice.
class BackgroundSyncScheduler {
  const BackgroundSyncScheduler._();

  static Future<void> initialize() async {
    // PowerSync owns synchronization while the app is connected. Platform
    // background execution can be added later as a separate lifecycle concern.
  }
}
