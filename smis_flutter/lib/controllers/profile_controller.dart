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
    await ref.read(authControllerProvider.notifier).refreshSession();
  }

  Future<void> updateLanguageByCode(String languageCode) async {
    final normalizedCode = languageCode.trim().toLowerCase();
    final languages = await _api.getLanguages();
    ProfileLanguage? selectedLanguage;
    for (final language in languages) {
      if (language.code?.trim().toLowerCase() == normalizedCode) {
        selectedLanguage = language;
        break;
      }
    }
    if (selectedLanguage == null) {
      throw const ProfileValidationException(
        'The selected language is not available.',
      );
    }

    final currentProfile = state.value ?? await _api.getCurrentUser();
    if (currentProfile.languageId != selectedLanguage.id) {
      await _api.updateLanguage(currentProfile.id, selectedLanguage.id);
    }

    final updatedProfile = await _api.getCurrentUser();
    state = AsyncData(updatedProfile);
    await ref.read(authControllerProvider.notifier).refreshSession();
  }

  Future<void> changePassword(ChangePasswordDraft draft) async {
    final currentProfile = state.value ?? await _api.getCurrentUser();
    await _api.changePassword(currentProfile.id, draft);
  }
}

final profileApiProvider = Provider<ProfileApi>(
  (ref) => DioProfileApi(sessionStore: ref.watch(authSessionStoreProvider)),
);

final profileLanguagesProvider = FutureProvider<List<ProfileLanguage>>(
  (ref) => ref.watch(profileApiProvider).getLanguages(),
);

final profileControllerProvider =
    AsyncNotifierProvider<ProfileController, UserProfile>(
      ProfileController.new,
    );
