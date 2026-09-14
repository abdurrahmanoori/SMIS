import 'package:flutter/material.dart';
import '../screens/home_screen.dart';

class HomeAction extends StatelessWidget {
  const HomeAction({super.key});

  @override
  Widget build(BuildContext context) {
    return IconButton(
      icon: const Icon(Icons.home_outlined),
      tooltip: 'Home',
      onPressed: () {
        Navigator.of(context).pushAndRemoveUntil(
          MaterialPageRoute<void>(builder: (context) => const HomeScreen()),
          (route) => false,
        );
      },
    );
  }
}
