import 'dart:async';

class AuthSessionInvalidationEvent {
  const AuthSessionInvalidationEvent(this.message);

  final String message;
}

class AuthSessionInvalidation {
  AuthSessionInvalidation._();

  static final _controller =
      StreamController<AuthSessionInvalidationEvent>.broadcast(sync: true);

  static Stream<AuthSessionInvalidationEvent> get events => _controller.stream;

  static void notify(String message) {
    _controller.add(AuthSessionInvalidationEvent(message));
  }
}
