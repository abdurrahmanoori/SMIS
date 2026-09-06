import 'package:flutter_riverpod/flutter_riverpod.dart';

import '../data/profile_api.dart';
import '../models/user_profile.dart';
import 'auth_controller.dart';

class ProfileController extends AsyncNotifier<UserProfile> {
  ProfileApi get _api => ref.read(profileApiProvider);

  @override
  Future<UserProfile> build() => _api.getCurrentUser();

  Future<void> reload() async {
    state = const AsyncLoading();
    state = await AsyncValue.guard(_api.getCurrentUser);
  }

  Future<void> updateProfile(ProfileUpdateDraft draft) async {
    final currentProfile = state.value ?? await _api.getCurrentUser();
    await _api.updateProfile(currentProfile.id, draft);
    // The update route returns only the basic user DTO. Reload the current
    // profile so roles and shop details remain available on this screen.
    final updatedProfile = await _api.getCurrentUser();
    state = AsyncData(updatedProfile);
    await ref
        .read(authControllerProvider.notifier)
        .updateSessionProfile(
          userName: updatedProfile.userName,
          email: updatedProfile.email,
        );
  }

  Future<void> changePassword(ChangePasswordDraft draft) async {
    final currentProfile = state.value ?? await _api.getCurrentUser();
    await _api.changePassword(currentProfile.id, draft);
  }
}

final profileApiProvider = Provider<ProfileApi>(
  (ref) => DioProfileApi(sessionStore: ref.watch(authSessionStoreProvider)),
);

final profileControllerProvider =
    AsyncNotifierProvider<ProfileController, UserProfile>(ProfileController.new);
