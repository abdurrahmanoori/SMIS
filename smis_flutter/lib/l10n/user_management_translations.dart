const Map<String, String> userManagementFaTranslations = {
  'User management': 'مدیریت کاربران',
  'User details': 'جزئیات کاربر',
  'Add user': 'افزودن کاربر',
  'Create user': 'ایجاد کاربر',
  'Edit user': 'ویرایش کاربر',
  'Account': 'حساب',
  'Personal information': 'اطلاعات شخصی',
  'Access': 'دسترسی',
  'Update account information, shop assignment, and roles.':
      'اطلاعات حساب، فروشگاه تعیین‌شده و نقش‌ها را به‌روزرسانی کنید.',
  'Create the account in the active session shop and assign its initial access.':
      'حساب را در فروشگاه فعال ایجاد کرده و دسترسی اولیه آن را تعیین کنید.',
  'Password must be at least 6 characters':
      'رمز عبور باید حداقل ۶ نویسه داشته باشد',
  'Example: +93 700 123 456': 'مثال: +93 700 123 456',
  'The new user will be assigned to the shop currently active in your session.':
      'کاربر جدید به فروشگاهی که اکنون در نشست شما فعال است اختصاص داده می‌شود.',
  'Select at least one role.': 'حداقل یک نقش را انتخاب کنید.',
  'Username is required': 'نام کاربری ضروری است.',
  'Username must not exceed 256 characters':
      'نام کاربری نباید بیشتر از ۲۵۶ نویسه باشد.',
  'Username can contain only letters, numbers, and - . _ @ +':
      'نام کاربری فقط می‌تواند شامل حروف، اعداد و - . _ @ + باشد.',
  'Email is required': 'ایمیل ضروری است.',
  'Email must not exceed 256 characters':
      'ایمیل نباید بیشتر از ۲۵۶ نویسه باشد.',
  'Email must be a valid email address': 'ایمیل باید یک آدرس معتبر باشد.',
  'Password is required': 'رمز عبور ضروری است.',
  'First name must not exceed 100 characters':
      'نام نباید بیشتر از ۱۰۰ نویسه باشد.',
  'Last name must not exceed 100 characters':
      'نام خانوادگی نباید بیشتر از ۱۰۰ نویسه باشد.',
  'Phone number must be at least 8 characters':
      'شماره تلفن باید حداقل ۸ نویسه داشته باشد.',
  'Phone number must not exceed 20 characters':
      'شماره تلفن نباید بیشتر از ۲۰ نویسه باشد.',
  'Phone number format is invalid': 'فرمت شماره تلفن معتبر نیست.',
  'Shop is required': 'فروشگاه ضروری است.',
  'User created successfully.': 'کاربر با موفقیت ایجاد شد.',
  'User updated successfully.': 'کاربر با موفقیت به‌روزرسانی شد.',
  'Roles updated for {name}.': 'نقش‌های {name} به‌روزرسانی شد.',
  'Reset password?': 'رمز عبور بازنشانی شود؟',
  'Reset password': 'بازنشانی رمز عبور',
  "Reset {name}'s password? The server will immediately set the password to the user's current username. This operation is online-only and is not stored locally.":
      'رمز عبور {name} بازنشانی شود؟ سرور فوراً نام کاربری فعلی را به‌عنوان رمز عبور قرار می‌دهد. این عملیات فقط آنلاین است و به‌صورت محلی ذخیره نمی‌شود.',
  'Password reset for {name}. The new password is the current username.':
      'رمز عبور {name} بازنشانی شد. رمز عبور جدید همان نام کاربری فعلی است.',
  'Lock': 'قفل',
  'Unlock': 'بازکردن قفل',
  'Lock user?': 'کاربر قفل شود؟',
  'Unlock user?': 'قفل کاربر باز شود؟',
  'Lock {name}? This change is applied immediately on the server.':
      '{name} قفل شود؟ این تغییر فوراً روی سرور اعمال می‌شود.',
  'Unlock {name}? This change is applied immediately on the server.':
      'قفل {name} باز شود؟ این تغییر فوراً روی سرور اعمال می‌شود.',
  '{name} is now locked.': '{name} اکنون قفل است.',
  '{name} is now unlocked.': 'قفل {name} اکنون باز است.',
  'Activate': 'فعال‌سازی',
  'Deactivate': 'غیرفعال‌سازی',
  'Activate user?': 'کاربر فعال شود؟',
  'Deactivate user?': 'کاربر غیرفعال شود؟',
  'Activate {name}? The user will be able to sign in again.':
      '{name} فعال شود؟ کاربر دوباره می‌تواند وارد سیستم شود.',
  'Deactivate {name}? Existing authenticated requests will be rejected immediately.':
      '{name} غیرفعال شود؟ درخواست‌های احراز هویت‌شده موجود فوراً رد می‌شوند.',
  '{name} is now active.': '{name} اکنون فعال است.',
  '{name} is now inactive.': '{name} اکنون غیرفعال است.',
  'Activate all ShopAdmins?': 'همه ShopAdminها فعال شوند؟',
  'Deactivate all ShopAdmins?': 'همه ShopAdminها غیرفعال شوند؟',
  'Activate every ShopAdmin account? Accounts that are also SuperAdmin are excluded.':
      'همه حساب‌های ShopAdmin فعال شوند؟ حساب‌هایی که SuperAdmin نیز هستند شامل نمی‌شوند.',
  'Deactivate every ShopAdmin account? Accounts that are also SuperAdmin are excluded.':
      'همه حساب‌های ShopAdmin غیرفعال شوند؟ حساب‌هایی که SuperAdmin نیز هستند شامل نمی‌شوند.',
  'Activate all': 'فعال‌سازی همه',
  'Deactivate all': 'غیرفعال‌سازی همه',
  'All ShopAdmin accounts are active.': 'همه حساب‌های ShopAdmin فعال هستند.',
  'All ShopAdmin accounts are inactive.':
      'همه حساب‌های ShopAdmin غیرفعال هستند.',
  'Delete user?': 'کاربر حذف شود؟',
  'Delete {name}? This action is performed directly on the server.':
      '{name} حذف شود؟ این عملیات مستقیماً روی سرور انجام می‌شود.',
  '{name} was deleted.': '{name} حذف شد.',
  'Account status: inactive': 'وضعیت حساب: غیرفعال',
  'Account status: unlocked': 'وضعیت حساب: باز',
  'Account status: locked': 'وضعیت حساب: قفل',
  'Account status: locked until {date}': 'وضعیت حساب: قفل تا {date}',
  'Current shop': 'فروشگاه فعلی',
  'User administration requires SuperAdmin or ShopAdmin access.':
      'مدیریت کاربران به دسترسی SuperAdmin یا ShopAdmin نیاز دارد.',
  'Search users...': 'جستجوی کاربران...',
  'Close search': 'بستن جستجو',
  'Search users': 'جستجوی کاربران',
  'ShopAdmin activation': 'فعال‌سازی ShopAdmin',
  'Activate all ShopAdmins': 'فعال‌سازی همه ShopAdminها',
  'Deactivate all ShopAdmins': 'غیرفعال‌سازی همه ShopAdminها',
  'Refresh': 'تازه‌سازی',
  'User administration is online-only. User CRUD, roles, activation, password resets, and lock/unlock changes call the server directly and are never queued in PowerSync or local offline storage.':
      'مدیریت کاربران فقط آنلاین است. ایجاد، ویرایش و حذف کاربر، نقش‌ها، فعال‌سازی، بازنشانی رمز عبور و قفل/بازکردن قفل مستقیماً روی سرور انجام می‌شود و هرگز در PowerSync یا ذخیره‌سازی آفلاین محلی در صف قرار نمی‌گیرد.',
  'No users found.': 'هیچ کاربری یافت نشد.',
  'No matching users.': 'هیچ کاربر مطابقی یافت نشد.',
  'Try a different search term.': 'عبارت جستجوی دیگری را امتحان کنید.',
  'Roles: none': 'نقش‌ها: هیچ',
  'Roles: {roles}': 'نقش‌ها: {roles}',
  'View details': 'مشاهده جزئیات',
  'Manage roles': 'مدیریت نقش‌ها',
  'Unlock account': 'بازکردن قفل حساب',
  'Lock account': 'قفل حساب',
  'Deactivate account': 'غیرفعال‌سازی حساب',
  'Activate account': 'فعال‌سازی حساب',
  'Previous page': 'صفحه قبلی',
  'Next page': 'صفحه بعدی',
  'Page {page} of {totalPages} · {count} users':
      'صفحه {page} از {totalPages} · {count} کاربر',
  'Manage roles · {name}': 'مدیریت نقش‌ها · {name}',
  "The submitted list replaces the user's complete role list on the server.":
      'فهرست ارسال‌شده تمام نقش‌های کاربر را روی سرور جایگزین می‌کند.',
  'Save roles': 'ذخیره نقش‌ها',
  'Display name': 'نام نمایشی',
  'Organization and access': 'سازمان و دسترسی',
  'No roles assigned': 'هیچ نقشی اختصاص داده نشده است',
  'Account status': 'وضعیت حساب',
  'Activation': 'فعال‌سازی',
  'Lock status': 'وضعیت قفل',
  'Lockout end': 'پایان قفل',
  'Locked': 'قفل',
  'Unlocked': 'باز',
};

const Map<String, String> userManagementPsTranslations = {
  'User management': 'د کاروونکو مدیریت',
  'User details': 'د کارونکي جزئیات',
  'Add user': 'کارن زیاتول',
  'Create user': 'کارن جوړول',
  'Edit user': 'کارن سمول',
  'Account': 'حساب',
  'Personal information': 'شخصي معلومات',
  'Access': 'لاسرسی',
  'Update account information, shop assignment, and roles.':
      'د حساب معلومات، ټاکل شوی دوکان او رولونه تازه کړئ.',
  'Create the account in the active session shop and assign its initial access.':
      'حساب په اوسني فعال دوکان کې جوړ او لومړنی لاسرسی ورته وټاکئ.',
  'Password must be at least 6 characters': 'پټنوم باید لږ تر لږه ۶ توري ولري',
  'Example: +93 700 123 456': 'بېلګه: +93 700 123 456',
  'The new user will be assigned to the shop currently active in your session.':
      'نوی کارن به هغه دوکان ته وټاکل شي چې اوس ستاسو په ناسته کې فعال دی.',
  'Select at least one role.': 'لږ تر لږه یو رول وټاکئ.',
  'Username is required': 'کارن نوم اړین دی.',
  'Username must not exceed 256 characters':
      'کارن نوم باید له ۲۵۶ تورو زیات نه وي.',
  'Username can contain only letters, numbers, and - . _ @ +':
      'کارن نوم یوازې توري، شمېرې او - . _ @ + لرلی شي.',
  'Email is required': 'برېښنالیک اړین دی.',
  'Email must not exceed 256 characters':
      'برېښنالیک باید له ۲۵۶ تورو زیات نه وي.',
  'Email must be a valid email address': 'برېښنالیک باید معتبر ادرس وي.',
  'Password is required': 'پټنوم اړین دی.',
  'First name must not exceed 100 characters':
      'نوم باید له ۱۰۰ تورو زیات نه وي.',
  'Last name must not exceed 100 characters':
      'تخلص باید له ۱۰۰ تورو زیات نه وي.',
  'Phone number must be at least 8 characters':
      'د ټیلیفون شمېره باید لږ تر لږه ۸ توري ولري.',
  'Phone number must not exceed 20 characters':
      'د ټیلیفون شمېره باید له ۲۰ تورو زیاته نه وي.',
  'Phone number format is invalid': 'د ټیلیفون شمېرې بڼه ناسمه ده.',
  'Shop is required': 'دوکان اړین دی.',
  'User created successfully.': 'کارن په بریالیتوب جوړ شو.',
  'User updated successfully.': 'کارن په بریالیتوب تازه شو.',
  'Roles updated for {name}.': 'د {name} رولونه تازه شول.',
  'Reset password?': 'پټنوم بیا تنظیم شي؟',
  'Reset password': 'پټنوم بیا تنظیمول',
  "Reset {name}'s password? The server will immediately set the password to the user's current username. This operation is online-only and is not stored locally.":
      'د {name} پټنوم بیا تنظیم شي؟ سرور به سمدستي اوسنی کارن نوم د پټنوم په توګه وټاکي. دا عملیات یوازې آنلاین دي او په ځايي ډول نه ساتل کېږي.',
  'Password reset for {name}. The new password is the current username.':
      'د {name} پټنوم بیا تنظیم شو. نوی پټنوم اوسنی کارن نوم دی.',
  'Lock': 'قفلول',
  'Unlock': 'قفل خلاصول',
  'Lock user?': 'کارن قفل شي؟',
  'Unlock user?': 'د کارن قفل خلاص شي؟',
  'Lock {name}? This change is applied immediately on the server.':
      '{name} قفل شي؟ دا بدلون سمدستي په سرور کې پلي کېږي.',
  'Unlock {name}? This change is applied immediately on the server.':
      'د {name} قفل خلاص شي؟ دا بدلون سمدستي په سرور کې پلي کېږي.',
  '{name} is now locked.': '{name} اوس قفل دی.',
  '{name} is now unlocked.': 'د {name} قفل اوس خلاص دی.',
  'Activate': 'فعالول',
  'Deactivate': 'غیرفعالول',
  'Activate user?': 'کارن فعال شي؟',
  'Deactivate user?': 'کارن غیرفعال شي؟',
  'Activate {name}? The user will be able to sign in again.':
      '{name} فعال شي؟ کارن به بیا د ننوتلو توان ولري.',
  'Deactivate {name}? Existing authenticated requests will be rejected immediately.':
      '{name} غیرفعال شي؟ موجودې تصدیق شوې غوښتنې به سمدستي رد شي.',
  '{name} is now active.': '{name} اوس فعال دی.',
  '{name} is now inactive.': '{name} اوس غیرفعال دی.',
  'Activate all ShopAdmins?': 'ټول ShopAdmin حسابونه فعال شي؟',
  'Deactivate all ShopAdmins?': 'ټول ShopAdmin حسابونه غیرفعال شي؟',
  'Activate every ShopAdmin account? Accounts that are also SuperAdmin are excluded.':
      'ټول ShopAdmin حسابونه فعال شي؟ هغه حسابونه چې SuperAdmin هم دي نه شاملېږي.',
  'Deactivate every ShopAdmin account? Accounts that are also SuperAdmin are excluded.':
      'ټول ShopAdmin حسابونه غیرفعال شي؟ هغه حسابونه چې SuperAdmin هم دي نه شاملېږي.',
  'Activate all': 'ټول فعالول',
  'Deactivate all': 'ټول غیرفعالول',
  'All ShopAdmin accounts are active.': 'ټول ShopAdmin حسابونه فعال دي.',
  'All ShopAdmin accounts are inactive.': 'ټول ShopAdmin حسابونه غیرفعال دي.',
  'Delete user?': 'کارن ړنګ شي؟',
  'Delete {name}? This action is performed directly on the server.':
      '{name} ړنګ شي؟ دا عملیات مستقیم په سرور کې ترسره کېږي.',
  '{name} was deleted.': '{name} ړنګ شو.',
  'Account status: inactive': 'د حساب حالت: غیرفعال',
  'Account status: unlocked': 'د حساب حالت: خلاص',
  'Account status: locked': 'د حساب حالت: قفل',
  'Account status: locked until {date}': 'د حساب حالت: تر {date} پورې قفل',
  'Current shop': 'اوسنی دوکان',
  'User administration requires SuperAdmin or ShopAdmin access.':
      'د کاروونکو مدیریت د SuperAdmin یا ShopAdmin لاسرسي ته اړتیا لري.',
  'Search users...': 'کاروونکي ولټوئ...',
  'Close search': 'لټون بندول',
  'Search users': 'کاروونکي لټول',
  'ShopAdmin activation': 'د ShopAdmin فعالول',
  'Activate all ShopAdmins': 'ټول ShopAdmin فعالول',
  'Deactivate all ShopAdmins': 'ټول ShopAdmin غیرفعالول',
  'Refresh': 'تازه کول',
  'User administration is online-only. User CRUD, roles, activation, password resets, and lock/unlock changes call the server directly and are never queued in PowerSync or local offline storage.':
      'د کاروونکو مدیریت یوازې آنلاین دی. د کارن جوړول، سمول او ړنګول، رولونه، فعالول، د پټنوم بیا تنظیم او قفل/خلاصول مستقیم سرور ته ځي او هېڅکله په PowerSync یا ځايي آفلاین زېرمه کې نه قطار کېږي.',
  'No users found.': 'هېڅ کارن ونه موندل شو.',
  'No matching users.': 'مطابق کارن ونه موندل شو.',
  'Try a different search term.': 'د لټون بله کلمه وازمویئ.',
  'Roles: none': 'رولونه: هېڅ',
  'Roles: {roles}': 'رولونه: {roles}',
  'View details': 'جزئیات کتل',
  'Manage roles': 'رولونه مدیریت کول',
  'Unlock account': 'د حساب قفل خلاصول',
  'Lock account': 'حساب قفلول',
  'Deactivate account': 'حساب غیرفعالول',
  'Activate account': 'حساب فعالول',
  'Previous page': 'مخکینی مخ',
  'Next page': 'بل مخ',
  'Page {page} of {totalPages} · {count} users':
      'مخ {page} له {totalPages} · {count} کاروونکي',
  'Manage roles · {name}': 'رولونه مدیریت کول · {name}',
  "The submitted list replaces the user's complete role list on the server.":
      'لېږل شوی لست په سرور کې د کارن ټول رولونه بدلوي.',
  'Save roles': 'رولونه ساتل',
  'Display name': 'ښودنیز نوم',
  'Organization and access': 'اداره او لاسرسی',
  'No roles assigned': 'هېڅ رول نه دی ټاکل شوی',
  'Account status': 'د حساب حالت',
  'Activation': 'فعالول',
  'Lock status': 'د قفل حالت',
  'Lockout end': 'د قفل پای',
  'Locked': 'قفل',
  'Unlocked': 'خلاص',
};
