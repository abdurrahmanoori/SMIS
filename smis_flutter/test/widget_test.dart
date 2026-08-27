import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';
import 'package:flutter_test/flutter_test.dart';
import 'package:smis_flutter/app/app.dart';
import 'package:smis_flutter/features/category/domain/entities/category.dart';
import 'package:smis_flutter/features/category/domain/repositories/category_repository.dart';
import 'package:smis_flutter/features/category/presentation/providers/category_providers.dart';

void main() {
  testWidgets('renders the offline Category screen', (tester) async {
    await tester.pumpWidget(
      ProviderScope(
        overrides: [
          categoryRepositoryProvider.overrideWithValue(_EmptyRepository()),
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

class _EmptyRepository implements CategoryRepository {
  @override
  Future<Category> create(CategoryDraft draft) => throw UnimplementedError();

  @override
  Future<void> delete(String id) => throw UnimplementedError();

  @override
  Future<List<Category>> getAll() async => const [];

  @override
  Future<int> getPendingCount() async => 0;

  @override
  Future<Category> update(String id, CategoryDraft draft) =>
      throw UnimplementedError();
}
