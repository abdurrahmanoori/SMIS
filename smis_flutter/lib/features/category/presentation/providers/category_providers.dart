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

final appDatabaseProvider = Provider<AppDatabase>(
  (ref) => throw StateError('AppDatabase must be overridden at bootstrap.'),
);

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

final categoryControllerProvider =
    AsyncNotifierProvider<CategoryController, CategoryScreenState>(
      CategoryController.new,
    );
