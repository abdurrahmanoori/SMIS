import 'package:flutter/material.dart';
import 'package:flutter_localizations/flutter_localizations.dart';

class AppLocalizations {
  AppLocalizations(this.locale);

  final Locale locale;

  static const supportedLocales = [Locale('en'), Locale('fa'), Locale('ps')];

  static const localizationsDelegates = [
    GlobalMaterialLocalizations.delegate,
    GlobalWidgetsLocalizations.delegate,
    GlobalCupertinoLocalizations.delegate,
  ];

  static const _translations = <String, Map<String, String>>{
    'fa': {
      'English': 'English',
      'Dari': 'دری',
      'Pashto': 'پښتو',
      'Language': 'زبان',
      'Appearance': 'نمایش',
      'System default': 'پیش‌فرض سیستم',
      'Light mode': 'حالت روشن',
      'Dark mode': 'حالت تاریک',
      'Home': 'خانه',
      'Shops': 'فروشگاه‌ها',
      'Units of measurement': 'واحدهای اندازه‌گیری',
      'Categories': 'دسته‌بندی‌ها',
      'Products': 'محصولات',
      'My profile': 'پروفایل من',
      'Sign out': 'خروج',
      'Sign in to SMIS': 'ورود به SMIS',
      'Use your SMIS account to synchronize your local changes.':
          'برای همگام‌سازی تغییرات محلی از حساب SMIS خود استفاده کنید.',
      'Email': 'ایمیل',
      'Password': 'رمز عبور',
      'Show password': 'نمایش رمز عبور',
      'Hide password': 'پنهان‌کردن رمز عبور',
      'Sign in': 'ورود',
      'Signing in…': 'در حال ورود…',
      'Email is required.': 'ایمیل ضروری است.',
      'Enter a valid email address.': 'یک آدرس ایمیل معتبر وارد کنید.',
      'Password is required.': 'رمز عبور ضروری است.',
      'Saved accounts': 'حساب‌های ذخیره‌شده',
      'OR SIGN IN WITH ANOTHER ACCOUNT': 'یا با حساب دیگری وارد شوید',
      'After signing in once, your local work remains available offline.':
          'پس از یک بار ورود، کارهای محلی شما بدون اینترنت نیز در دسترس است.',
      'Welcome back, {name}': 'خوش آمدید، {name}',
      'Choose an area to continue managing your shop.':
          'برای ادامه مدیریت فروشگاه، یک بخش را انتخاب کنید.',
      'Manage your local category list.': 'فهرست دسته‌بندی‌های محلی را مدیریت کنید.',
      'View your account, shop details, and profile settings.':
          'حساب، جزئیات فروشگاه و تنظیمات پروفایل را ببینید.',
      'Manage your local measurement units.':
          'واحدهای اندازه‌گیری محلی را مدیریت کنید.',
      'Manage locally available shops.': 'فروشگاه‌های محلی را مدیریت کنید.',
      'Manage your local product catalog.': 'فهرست محصولات محلی را مدیریت کنید.',
      '{count} local change waiting to sync.':
          '{count} تغییر محلی در انتظار همگام‌سازی است.',
      '{count} local changes waiting to sync.':
          '{count} تغییر محلی در انتظار همگام‌سازی است.',
      '{count} pending': '{count} در انتظار',
      'Offline-first data': 'اطلاعات آفلاین‌محور',
      'Your local changes are synchronized.': 'تغییرات محلی شما همگام شده‌اند.',
      '{count} local change is safely stored and waiting to synchronize.':
          '{count} تغییر محلی با امنیت ذخیره شده و منتظر همگام‌سازی است.',
      '{count} local changes are safely stored and waiting to synchronize.':
          '{count} تغییر محلی با امنیت ذخیره شده و منتظر همگام‌سازی است.',
      'Local-first inventory setup': 'تنظیمات موجودی آفلاین‌محور',
      'Local-first administration': 'مدیریت آفلاین‌محور',
      'Sync categories': 'همگام‌سازی دسته‌بندی‌ها',
      'Sync units of measurement': 'همگام‌سازی واحدهای اندازه‌گیری',
      'Sync products': 'همگام‌سازی محصولات',
      'Sync shops': 'همگام‌سازی فروشگاه‌ها',
      'Add category': 'افزودن دسته‌بندی',
      'Add unit': 'افزودن واحد',
      'Add product': 'افزودن محصول',
      'Add shop': 'افزودن فروشگاه',
      'New category': 'دسته‌بندی جدید',
      'Edit category': 'ویرایش دسته‌بندی',
      'New unit of measurement': 'واحد اندازه‌گیری جدید',
      'Edit unit of measurement': 'ویرایش واحد اندازه‌گیری',
      'New product': 'محصول جدید',
      'Edit product': 'ویرایش محصول',
      'New shop': 'فروشگاه جدید',
      'Edit shop': 'ویرایش فروشگاه',
      'Name *': 'نام *',
      'Name': 'نام',
      'Name is required.': 'نام ضروری است.',
      'Code': 'کُد',
      'Description': 'توضیحات',
      'Active': 'فعال',
      'Inactive': 'غیرفعال',
      'Symbol *': 'نماد *',
      'Symbol is required.': 'نماد ضروری است.',
      'Example: kg, pcs, L': 'مثال: kg، pcs، L',
      'Base unit *': 'واحد اصلی *',
      'Select a base unit.': 'یک واحد اصلی انتخاب کنید.',
      'Category': 'دسته‌بندی',
      'No category': 'بدون دسته‌بندی',
      'SKU': 'کُد کالا',
      'Barcode': 'بارکد',
      'Image URL': 'نشانی تصویر',
      'Shop type *': 'نوع فروشگاه *',
      'Retail shop': 'فروشگاه پرچون',
      'Wholesale shop': 'فروشگاه عمده‌فروشی',
      'Address': 'آدرس',
      'Phone number': 'شماره تلفن',
      'Tax number': 'شماره مالیاتی',
      'Cancel': 'لغو',
      'Save offline': 'ذخیره آفلاین',
      'Edit': 'ویرایش',
      'Delete': 'حذف',
      'Delete offline': 'حذف آفلاین',
      'Delete category?': 'دسته‌بندی حذف شود؟',
      'Delete unit of measurement?': 'واحد اندازه‌گیری حذف شود؟',
      'Delete product?': 'محصول حذف شود؟',
      'Delete shop?': 'فروشگاه حذف شود؟',
      '“{name}” will disappear now and its deletion will sync later.':
          '«{name}» اکنون ناپدید می‌شود و حذف آن بعداً همگام خواهد شد.',
      'Category saved locally.': 'دسته‌بندی به‌صورت محلی ذخیره شد.',
      'Category updated locally.': 'دسته‌بندی به‌صورت محلی به‌روز شد.',
      'Category deleted locally.': 'دسته‌بندی به‌صورت محلی حذف شد.',
      'Unit of measurement saved locally.': 'واحد اندازه‌گیری به‌صورت محلی ذخیره شد.',
      'Unit of measurement updated locally.': 'واحد اندازه‌گیری به‌صورت محلی به‌روز شد.',
      'Unit of measurement deleted locally.': 'واحد اندازه‌گیری به‌صورت محلی حذف شد.',
      'Product saved locally.': 'محصول به‌صورت محلی ذخیره شد.',
      'Product updated locally.': 'محصول به‌صورت محلی به‌روز شد.',
      'Product deleted locally.': 'محصول به‌صورت محلی حذف شد.',
      'Shop saved locally.': 'فروشگاه به‌صورت محلی ذخیره شد.',
      'Shop updated locally.': 'فروشگاه به‌صورت محلی به‌روز شد.',
      'Shop deleted locally.': 'فروشگاه به‌صورت محلی حذف شد.',
      'Synced': 'همگام شد',
      'Sync failed': 'همگام‌سازی ناموفق بود',
      'Waiting to sync': 'در انتظار همگام‌سازی',
      'Synchronization completed.': 'همگام‌سازی تکمیل شد.',
      'Synchronization completed with {count} failed requests.':
          'همگام‌سازی با {count} درخواست ناموفق تکمیل شد.',
      'Offline. Local changes are saved and will retry later.':
          'آفلاین هستید. تغییرات محلی ذخیره شده و بعداً دوباره تلاش می‌شود.',
      'A synchronization is already running.':
          'یک همگام‌سازی از قبل در حال اجرا است.',
      'Pulled {pulled}, pushed {pushed}, conflicts resolved {conflicts}, pending {pending}.':
          'دریافت {pulled}، ارسال {pushed}، رفع تعارض {conflicts}، در انتظار {pending}.',
      'No categories yet': 'هنوز دسته‌بندی‌ای وجود ندارد',
      'No units of measurement yet': 'هنوز واحد اندازه‌گیری‌ای وجود ندارد',
      'No products yet': 'هنوز محصولی وجود ندارد',
      'No shops yet': 'هنوز فروشگاهی وجود ندارد',
      'Add one now—even while completely offline.':
          'همین حالا یکی اضافه کنید—حتی کاملاً آفلاین.',
      'Create or sync a unit of measurement before adding a product.':
          'پیش از افزودن محصول، یک واحد اندازه‌گیری بسازید یا همگام کنید.',
      'Manage units': 'مدیریت واحدها',
      'Base unit: {name}': 'واحد اصلی: {name}',
      'Category: {name}': 'دسته‌بندی: {name}',
      'SKU: {value}': 'کُد کالا: {value}',
      'Your account can view and update its assigned shop. Only a SuperAdmin can create or delete shops.':
          'حساب شما می‌تواند فروشگاه تعیین‌شده را ببیند و ویرایش کند. تنها مدیر کل می‌تواند فروشگاه بسازد یا حذف کند.',
      'OK': 'تأیید',
      'Refresh profile': 'تازه‌سازی پروفایل',
      'Personal details': 'اطلاعات شخصی',
      'Update the contact information associated with your account.':
          'اطلاعات تماس مربوط به حساب خود را به‌روز کنید.',
      'First name': 'نام',
      'Last name': 'نام خانوادگی',
      'Username': 'نام کاربری',
      'Username must be between 1 and 256 characters.':
          'نام کاربری باید بین ۱ تا ۲۵۶ نویسه باشد.',
      'Unable to load languages. Your current selection will be kept.':
          'زبان‌ها بارگیری نشدند. انتخاب فعلی شما حفظ می‌شود.',
      'Select a language.': 'یک زبان انتخاب کنید.',
      'Optional. The server keeps the current value when left blank.':
          'اختیاری است. اگر خالی بماند، سرور مقدار فعلی را نگه می‌دارد.',
      'Save changes': 'ذخیره تغییرات',
      'Profile updated.': 'پروفایل به‌روز شد.',
      '{field} must not exceed 100 characters.':
          '{field} نباید بیشتر از ۱۰۰ نویسه باشد.',
      'Change your account password.': 'رمز عبور حساب خود را تغییر دهید.',
      'Change password': 'تغییر رمز عبور',
      'Current password': 'رمز عبور فعلی',
      'New password': 'رمز عبور جدید',
      'Confirm new password': 'تأیید رمز عبور جدید',
      'New password must be at least 6 characters.':
          'رمز عبور جدید باید حداقل ۶ نویسه باشد.',
      'Passwords do not match.': 'رمزهای عبور یکسان نیستند.',
      '{field} is required.': '{field} ضروری است.',
      'Saving…': 'در حال ذخیره…',
      'Password changed.': 'رمز عبور تغییر کرد.',
      'Account information': 'اطلاعات حساب',
      'User ID': 'شناسه کاربر',
      'Language ID': 'شناسه زبان',
      'Email verification': 'تأیید ایمیل',
      'Phone verification': 'تأیید تلفن',
      'Confirmed': 'تأیید شده',
      'Not confirmed': 'تأیید نشده',
      'Roles': 'نقش‌ها',
      'No assigned roles': 'هیچ نقشی تعیین نشده',
      'Shop ID': 'شناسه فروشگاه',
      'Shop': 'فروشگاه',
      'Type': 'نوع',
      'Phone': 'تلفن',
      'Status': 'وضعیت',
      'Not set': 'تعیین نشده',
      'Current language': 'زبان فعلی',
      'Something went wrong': 'مشکلی رخ داد',
      'Try again': 'تلاش دوباره',
      'Development details': 'جزئیات توسعه',
      'Cause type': 'نوع علت',
      'Cause message': 'پیام علت',
      'None': 'هیچ',
      'Network details': 'جزئیات شبکه',
      'Method': 'روش',
      'Path': 'مسیر',
      'Stack trace': 'ردیابی پشته',
      'Debug': 'اشکال‌زدایی',
      'Cause': 'علت',
      'Log': 'گزارش',
      'The login response was empty.': 'پاسخ ورود خالی بود.',
      'Unable to sign in. Please try again.':
          'ورود ممکن نشد. لطفاً دوباره تلاش کنید.',
      'Unable to restore the saved login. Please sign in again.':
          'ورود ذخیره‌شده بازیابی نشد. لطفاً دوباره وارد شوید.',
      'Signed out of this app, but the saved session could not be removed.':
          'از برنامه خارج شدید، اما نشست ذخیره‌شده حذف نشد.',
      'An unexpected error occurred.': 'یک خطای غیرمنتظره رخ داد.',
      'The server request failed.': 'درخواست سرور ناموفق بود.',
    },
    'ps': {
      'English': 'English',
      'Dari': 'دری',
      'Pashto': 'پښتو',
      'Language': 'ژبه',
      'Appearance': 'بڼه',
      'System default': 'د سیسټم تلواله',
      'Light mode': 'روښانه حالت',
      'Dark mode': 'تیاره حالت',
      'Home': 'کور',
      'Shops': 'دوکانونه',
      'Units of measurement': 'د اندازه کولو واحدونه',
      'Categories': 'کټګورۍ',
      'Products': 'محصولات',
      'My profile': 'زما پروفایل',
      'Sign out': 'وتل',
      'Sign in to SMIS': 'SMIS ته ننوتل',
      'Use your SMIS account to synchronize your local changes.':
          'د خپلو ځايي بدلونونو د همغږي کولو لپاره د SMIS حساب وکاروئ.',
      'Email': 'برېښنالیک',
      'Password': 'پټنوم',
      'Show password': 'پټنوم ښکاره کړئ',
      'Hide password': 'پټنوم پټ کړئ',
      'Sign in': 'ننوتل',
      'Signing in…': 'د ننوتلو په حال کې…',
      'Email is required.': 'برېښنالیک اړین دی.',
      'Enter a valid email address.': 'یو سم برېښنالیک ولیکئ.',
      'Password is required.': 'پټنوم اړین دی.',
      'Saved accounts': 'ساتل شوي حسابونه',
      'OR SIGN IN WITH ANOTHER ACCOUNT': 'یا په بل حساب ننوځئ',
      'After signing in once, your local work remains available offline.':
          'یو ځل له ننوتلو وروسته، ستاسو ځايي کار له انټرنېټ پرته هم شته.',
      'Welcome back, {name}': 'بیا ښه راغلاست، {name}',
      'Choose an area to continue managing your shop.':
          'د خپل دوکان د مدیریت لپاره یوه برخه وټاکئ.',
      'Manage your local category list.': 'خپل ځايي کټګورۍ مدیریت کړئ.',
      'View your account, shop details, and profile settings.':
          'خپل حساب، د دوکان معلومات او د پروفایل امستنې وګورئ.',
      'Manage your local measurement units.': 'ځايي اندازه واحدونه مدیریت کړئ.',
      'Manage locally available shops.': 'ځايي دوکانونه مدیریت کړئ.',
      'Manage your local product catalog.': 'خپل ځايي محصولات مدیریت کړئ.',
      '{count} local change waiting to sync.':
          '{count} ځايي بدلون همغږۍ ته منتظر دی.',
      '{count} local changes waiting to sync.':
          '{count} ځايي بدلونونه همغږۍ ته منتظر دي.',
      '{count} pending': '{count} منتظر',
      'Offline-first data': 'آفلاین-لومړی معلومات',
      'Your local changes are synchronized.': 'ستاسو ځايي بدلونونه همغږي شوي.',
      '{count} local change is safely stored and waiting to synchronize.':
          '{count} ځايي بدلون خوندي ساتل شوی او همغږۍ ته منتظر دی.',
      '{count} local changes are safely stored and waiting to synchronize.':
          '{count} ځايي بدلونونه خوندي ساتل شوي او همغږۍ ته منتظر دي.',
      'Local-first inventory setup': 'آفلاین-لومړی د زېرمتون امستنه',
      'Local-first administration': 'آفلاین-لومړی اداره',
      'Sync categories': 'کټګورۍ همغږي کړئ',
      'Sync units of measurement': 'اندازه واحدونه همغږي کړئ',
      'Sync products': 'محصولات همغږي کړئ',
      'Sync shops': 'دوکانونه همغږي کړئ',
      'Add category': 'کټګوري زیاته کړئ',
      'Add unit': 'واحد زیات کړئ',
      'Add product': 'محصول زیات کړئ',
      'Add shop': 'دوکان زیات کړئ',
      'New category': 'نوې کټګوري',
      'Edit category': 'کټګوري سمول',
      'New unit of measurement': 'د اندازه کولو نوی واحد',
      'Edit unit of measurement': 'د اندازه کولو واحد سمول',
      'New product': 'نوی محصول',
      'Edit product': 'محصول سمول',
      'New shop': 'نوی دوکان',
      'Edit shop': 'دوکان سمول',
      'Name *': 'نوم *',
      'Name': 'نوم',
      'Name is required.': 'نوم اړین دی.',
      'Code': 'کوډ',
      'Description': 'تشریح',
      'Active': 'فعال',
      'Inactive': 'غیرفعال',
      'Symbol *': 'نښه *',
      'Symbol is required.': 'نښه اړینه ده.',
      'Example: kg, pcs, L': 'بېلګه: kg، pcs، L',
      'Base unit *': 'اصلي واحد *',
      'Select a base unit.': 'اصلي واحد وټاکئ.',
      'Category': 'کټګوري',
      'No category': 'بې کټګورۍ',
      'SKU': 'د توکي کوډ',
      'Barcode': 'بارکوډ',
      'Image URL': 'د انځور پته',
      'Shop type *': 'د دوکان ډول *',
      'Retail shop': 'پرچون دوکان',
      'Wholesale shop': 'عمده پلورنځی',
      'Address': 'پته',
      'Phone number': 'د ټیلیفون شمېره',
      'Tax number': 'د مالیې شمېره',
      'Cancel': 'لغوه',
      'Save offline': 'آفلاین ساتل',
      'Edit': 'سمول',
      'Delete': 'ړنګول',
      'Delete offline': 'آفلاین ړنګول',
      'Delete category?': 'کټګوري ړنګه شي؟',
      'Delete unit of measurement?': 'د اندازه کولو واحد ړنګ شي؟',
      'Delete product?': 'محصول ړنګ شي؟',
      'Delete shop?': 'دوکان ړنګ شي؟',
      '“{name}” will disappear now and its deletion will sync later.':
          '«{name}» به اوس لیرې شي او ړنګول به یې وروسته همغږي شي.',
      'Category saved locally.': 'کټګوري په ځايي ډول وساتل شوه.',
      'Category updated locally.': 'کټګوري په ځايي ډول تازه شوه.',
      'Category deleted locally.': 'کټګوري په ځايي ډول ړنګه شوه.',
      'Unit of measurement saved locally.': 'د اندازه کولو واحد په ځايي ډول وساتل شو.',
      'Unit of measurement updated locally.': 'د اندازه کولو واحد په ځايي ډول تازه شو.',
      'Unit of measurement deleted locally.': 'د اندازه کولو واحد په ځايي ډول ړنګ شو.',
      'Product saved locally.': 'محصول په ځايي ډول وساتل شو.',
      'Product updated locally.': 'محصول په ځايي ډول تازه شو.',
      'Product deleted locally.': 'محصول په ځايي ډول ړنګ شو.',
      'Shop saved locally.': 'دوکان په ځايي ډول وساتل شو.',
      'Shop updated locally.': 'دوکان په ځايي ډول تازه شو.',
      'Shop deleted locally.': 'دوکان په ځايي ډول ړنګ شو.',
      'Synced': 'همغږي شو',
      'Sync failed': 'همغږي ناکامه شوه',
      'Waiting to sync': 'همغږۍ ته منتظر',
      'Synchronization completed.': 'همغږي بشپړه شوه.',
      'Synchronization completed with {count} failed requests.':
          'همغږي د {count} ناکامو غوښتنو سره بشپړه شوه.',
      'Offline. Local changes are saved and will retry later.':
          'آفلاین یاست. ځايي بدلونونه ساتل شوي او وروسته به بیا هڅه وشي.',
      'A synchronization is already running.':
          'یوه همغږي لا دمخه روانه ده.',
      'Pulled {pulled}, pushed {pushed}, conflicts resolved {conflicts}, pending {pending}.':
          'ترلاسه {pulled}، لېږل {pushed}، حل شوې شخړې {conflicts}، منتظر {pending}.',
      'No categories yet': 'تر اوسه کټګورۍ نشته',
      'No units of measurement yet': 'تر اوسه د اندازه کولو واحدونه نشته',
      'No products yet': 'تر اوسه محصولات نشته',
      'No shops yet': 'تر اوسه دوکانونه نشته',
      'Add one now—even while completely offline.':
          'همدا اوس یو زیات کړئ—حتی په بشپړ آفلاین حالت کې.',
      'Create or sync a unit of measurement before adding a product.':
          'د محصول له زیاتولو مخکې د اندازه کولو واحد جوړ یا همغږی کړئ.',
      'Manage units': 'واحدونه مدیریت کړئ',
      'Base unit: {name}': 'اصلي واحد: {name}',
      'Category: {name}': 'کټګوري: {name}',
      'SKU: {value}': 'د توکي کوډ: {value}',
      'Your account can view and update its assigned shop. Only a SuperAdmin can create or delete shops.':
          'ستاسو حساب ټاکل شوی دوکان لیدلی او سمولی شي. یوازې لوی مدیر دوکان جوړولی یا ړنګولی شي.',
      'OK': 'سمه ده',
      'Refresh profile': 'پروفایل تازه کړئ',
      'Personal details': 'شخصي معلومات',
      'Update the contact information associated with your account.':
          'له خپل حساب سره تړلي د اړیکې معلومات تازه کړئ.',
      'First name': 'نوم',
      'Last name': 'تخلص',
      'Username': 'کارن نوم',
      'Username must be between 1 and 256 characters.':
          'کارن نوم باید له ۱ تر ۲۵۶ تورو وي.',
      'Unable to load languages. Your current selection will be kept.':
          'ژبې پورته نه شوې. اوسنی انتخاب به وساتل شي.',
      'Select a language.': 'یوه ژبه وټاکئ.',
      'Optional. The server keeps the current value when left blank.':
          'اختیاري. که تش پرېښودل شي سرور اوسنی ارزښت ساتي.',
      'Save changes': 'بدلونونه ساتل',
      'Profile updated.': 'پروفایل تازه شو.',
      '{field} must not exceed 100 characters.':
          '{field} باید له ۱۰۰ تورو زیات نه وي.',
      'Change your account password.': 'د خپل حساب پټنوم بدل کړئ.',
      'Change password': 'پټنوم بدلول',
      'Current password': 'اوسنی پټنوم',
      'New password': 'نوی پټنوم',
      'Confirm new password': 'نوی پټنوم تایید کړئ',
      'New password must be at least 6 characters.':
          'نوی پټنوم باید لږ تر لږه ۶ توري ولري.',
      'Passwords do not match.': 'پټنومونه سره یو شان نه دي.',
      '{field} is required.': '{field} اړین دی.',
      'Saving…': 'د ساتلو په حال کې…',
      'Password changed.': 'پټنوم بدل شو.',
      'Account information': 'د حساب معلومات',
      'User ID': 'د کارن پېژند',
      'Language ID': 'د ژبې پېژند',
      'Email verification': 'د برېښنالیک تایید',
      'Phone verification': 'د ټیلیفون تایید',
      'Confirmed': 'تایید شوی',
      'Not confirmed': 'نه دی تایید شوی',
      'Roles': 'رولونه',
      'No assigned roles': 'هیڅ رول نه دی ټاکل شوی',
      'Shop ID': 'د دوکان پېژند',
      'Shop': 'دوکان',
      'Type': 'ډول',
      'Phone': 'ټیلیفون',
      'Status': 'حالت',
      'Not set': 'نه دی ټاکل شوی',
      'Current language': 'اوسنۍ ژبه',
      'Something went wrong': 'ستونزه رامنځته شوه',
      'Try again': 'بیا هڅه وکړئ',
      'Development details': 'د پراختیا جزئیات',
      'Cause type': 'د علت ډول',
      'Cause message': 'د علت پیغام',
      'None': 'هیڅ',
      'Network details': 'د شبکې جزئیات',
      'Method': 'طریقه',
      'Path': 'لاره',
      'Stack trace': 'سټک ټرېس',
      'Debug': 'ډیبګ',
      'Cause': 'لامل',
      'Log': 'ثبت',
      'The login response was empty.': 'د ننوتلو ځواب تش و.',
      'Unable to sign in. Please try again.':
          'ننوتل ممکن نه شول. بیا هڅه وکړئ.',
      'Unable to restore the saved login. Please sign in again.':
          'ساتل شوی ننوتل بېرته ترلاسه نه شول. بیا ننوځئ.',
      'Signed out of this app, but the saved session could not be removed.':
          'له اپ څخه ووتئ، خو ساتل شوې ناسته ړنګه نه شوه.',
      'An unexpected error occurred.': 'یوه ناڅاپي تېروتنه رامنځته شوه.',
      'The server request failed.': 'د سرور غوښتنه ناکامه شوه.',
    },
  };

  String text(String key, [Map<String, Object> values = const {}]) {
    var value = _translations[locale.languageCode]?[key] ?? key;
    for (final entry in values.entries) {
      value = value.replaceAll('{${entry.key}}', entry.value.toString());
    }
    return value;
  }

  String syncMessage(String message) {
    if (locale.languageCode == 'en') return message;

    if (message.contains('already active') ||
        message.contains('already running')) {
      return text('A synchronization is already running.');
    }
    if (message.startsWith('Offline.')) {
      return text('Offline. Local changes are saved and will retry later.');
    }
    if (message.endsWith('sync completed.')) {
      return text('Synchronization completed.');
    }

    final failedCount = RegExp(r'completed with (\d+) failed request')
        .firstMatch(message)
        ?.group(1);
    if (failedCount != null) {
      return text(
        'Synchronization completed with {count} failed requests.',
        {'count': failedCount},
      );
    }

    // Server validation and development diagnostics stay verbatim so useful
    // technical information is never hidden by a broad translation.
    return message;
  }

  String errorMessage(String message) {
    const knownMessages = {
      'The login response was empty.',
      'Unable to sign in. Please try again.',
      'Unable to restore the saved login. Please sign in again.',
      'Signed out of this app, but the saved session could not be removed.',
      'An unexpected error occurred.',
      'The server request failed.',
    };
    return knownMessages.contains(message) ? text(message) : message;
  }

  bool get isRtl => locale.languageCode == 'fa' || locale.languageCode == 'ps';
}

extension AppLocalizationsContext on BuildContext {
  AppLocalizations get l10n => AppLocalizations(Localizations.localeOf(this));
}
