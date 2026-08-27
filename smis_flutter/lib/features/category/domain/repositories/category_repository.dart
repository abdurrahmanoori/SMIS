import '../entities/category.dart';

abstract interface class CategoryRepository {
  Future<List<Category>> getAll();

  Future<Category> create(CategoryDraft draft);

  Future<Category> update(String id, CategoryDraft draft);

  Future<void> delete(String id);

  Future<int> getPendingCount();
}
