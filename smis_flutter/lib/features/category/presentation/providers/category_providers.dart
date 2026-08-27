import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../../../../core/database/app_database.dart';
import '../../../../core/network/api_client.dart';
import '../../../../core/network/connectivity_service.dart';
import '../../data/datasources/category_local_data_source.dart';
import '../../data/datasources/category_remote_data_source.dart';
import '../../data/repositories/category_repository_impl.dart';
import '../../data/sync/category_sync_service.dart';
import '../../domain/repositories/category_repository.dart';
import '../../domain/usecases/category_use_cases.dart';
import '../state/category_controller.dart';

/// Dependency Injection using Riverpod.
/// In Flutter, providers are like a mix of ServiceCollection and IServiceProvider.
/// They define how to create an object and automatically manage its lifecycle.

/// This provider is declared but not initialized here.
/// It MUST be overridden in the [ProviderScope] at the root of the app (main.dart).
/// This is a common pattern for dependencies that need async initialization before the UI starts.
final appDatabaseProvider = Provider<AppDatabase>(
  (ref) => throw StateError('AppDatabase must be overridden at bootstrap.'),
);

/// ref.watch() is used here to resolve dependencies. 
/// It's similar to constructor injection in .NET Core.
final categoryLocalDataSourceProvider = Provider<CategoryLocalDataSource>(
  (ref) => CategoryLocalDataSource(ref.watch(appDatabaseProvider)),
);

final apiClientProvider = Provider<ApiClient>((ref) => ApiClient());

final categoryRemoteDataSourceProvider = Provider<CategoryRemoteDataSource>(
  (ref) => CategoryRemoteDataSourceImpl(ref.watch(apiClientProvider)),
);

final connectivityProvider = Provider<NetworkConnectivity>(
  (ref) => ConnectivityService(),
);

final categoryRepositoryProvider = Provider<CategoryRepository>(
  (ref) => CategoryRepositoryImpl(ref.watch(categoryLocalDataSourceProvider)),
);

final categoryUseCasesProvider = Provider<CategoryUseCases>(
  (ref) => CategoryUseCases(ref.watch(categoryRepositoryProvider)),
);

final categorySyncServiceProvider = Provider<CategorySyncService>(
  (ref) => CategorySyncService(
    ref.watch(categoryLocalDataSourceProvider),
    ref.watch(categoryRemoteDataSourceProvider),
    ref.watch(connectivityProvider),
  ),
);

/// AsyncNotifierProvider is used for state that is loaded asynchronously.
/// It links the [CategoryController] logic to the [CategoryScreenState] data.
/// The UI will "watch" this provider to get updates when the state changes.
final categoryControllerProvider =
    AsyncNotifierProvider<CategoryController, CategoryScreenState>(
      CategoryController.new,
    );
