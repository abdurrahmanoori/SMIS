import 'package:flutter_riverpod/flutter_riverpod.dart';

/// A service to handle date and time consistently across the application.
/// 
/// Since you're coming from a .NET background, this matches your `DateTimeService` 
/// static class pattern. It provides a central place for all time-related logic.
class DateTimeService {
  DateTimeService._(); // Private constructor to prevent instantiation.

  /// Returns the current UTC time.
  /// Equivalent to C# `DateTime.UtcNow`.
  static DateTime get nowUtc => DateTime.now().toUtc();

  /// Returns the current local time.
  /// Equivalent to C# `DateTime.Now`.
  static DateTime get nowLocal => DateTime.now();

  /// Normalizes a [DateTime] to UTC.
  /// 
  /// In Dart, [DateTime] objects have an `isUtc` property. 
  /// This method ensures the returned value is always in UTC, 
  /// matching your .NET `NormalizeUtc` logic.
  static DateTime normalizeUtc(DateTime value) {
    if (value.isUtc) return value;
    return value.toUtc();
  }

  /// Helper to parse a string and ensure it's UTC.
  static DateTime parseUtc(String formattedString) {
    return normalizeUtc(DateTime.parse(formattedString));
  }
}

/// A provider to make the service available for Riverpod dependency injection.
/// This allows you to mock time in unit tests by overriding this provider.
final dateTimeServiceProvider = Provider((ref) => DateTimeService);
