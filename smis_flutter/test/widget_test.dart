import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';
import 'package:flutter_test/flutter_test.dart';
import 'package:smis_flutter/controllers/category_controller.dart';
import 'package:smis_flutter/main.dart';

void main() {
  testWidgets('renders the offline Category screen', (tester) async {
    await tester.pumpWidget(
      ProviderScope(
        overrides: [
          categoryControllerProvider.overrideWith(_EmptyCategoryController.new),
        ],
        child: const SmisApp(),
      ),
    );
    await tester.pump();
    await tester.pump(const Duration(milliseconds: 100));

    expect(find.text('Categories'), findsOneWidget);
    expect(find.text('No categories yet'), findsOneWidget);
    expect(
      find.widgetWithText(FloatingActionButton, 'Add category'),
      findsOneWidget,
    );
  });
}

class _EmptyCategoryController extends CategoryController {
  @override
  Future<CategoryScreenState> build() async =>
      const CategoryScreenState(categories: [], pendingCount: 0);
}
