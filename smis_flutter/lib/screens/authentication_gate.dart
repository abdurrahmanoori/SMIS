import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../controllers/auth_controller.dart';
import 'home_screen.dart';
import 'login_screen.dart';

/// The app's root route. It reacts to authentication changes so both login and
/// logout replace the visible area without relying on a stale navigation stack.
class AuthenticationGate extends ConsumerWidget {
  const AuthenticationGate({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final auth = ref.watch(authControllerProvider);
    if (auth.isRestoring) {
      return const Scaffold(
        body: Center(child: CircularProgressIndicator()),
      );
    }
    return auth.isAuthenticated ? const HomeScreen() : const LoginScreen();
  }
}
