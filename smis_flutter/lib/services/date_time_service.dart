class DateTimeService {
  const DateTimeService();

  DateTime get nowUtc => DateTime.now().toUtc();

  DateTime get nowLocal => DateTime.now();
}
