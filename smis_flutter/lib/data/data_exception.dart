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

class RemoteTransientException extends AppException {
  const RemoteTransientException(super.message, {super.cause});
}

class RemotePermanentException extends AppException {
  const RemotePermanentException(super.message, {super.cause});
}
