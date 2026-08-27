import '../entities/category.dart';
import '../repositories/category_repository.dart';

class CategoryUseCases {
  const CategoryUseCases(this._repository);

  final CategoryRepository _repository;

  Future<List<Category>> getAll() => _repository.getAll();

  Future<Category> create(CategoryDraft draft) => _repository.create(draft);

  Future<Category> update(String id, CategoryDraft draft) =>
      _repository.update(id, draft);

  Future<void> delete(String id) => _repository.delete(id);

  Future<int> getPendingCount() => _repository.getPendingCount();
}
