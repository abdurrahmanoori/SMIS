namespace SMIS.Infrastructure.Server.DatabaseSeeders;

/// <summary>
/// Centralized deterministic GUIDs for all seed data.
/// Using fixed GUIDs ensures stable migrations and referential integrity.
/// </summary>
internal static class SeedIds
{
    // Shops
    public const string Shop1 = "11111111-0000-0000-0000-000000000001";
    public const string Shop2 = "11111111-0000-0000-0000-000000000002";
    public const string Shop3 = "11111111-0000-0000-0000-000000000003";

    // Languages
    public const string LangEn = "22222222-0000-0000-0000-000000000001";
    public const string LangPs = "22222222-0000-0000-0000-000000000002";
    public const string LangFa = "22222222-0000-0000-0000-000000000003";

    // Roles
    public const string RoleSuperAdmin        = "33333333-0000-0000-0000-000000000001";
    public const string RoleWShopAdmin        = "33333333-0000-0000-0000-000000000002";
    public const string RoleWShopAdministration = "33333333-0000-0000-0000-000000000003";
    public const string RoleWShopManager      = "33333333-0000-0000-0000-000000000004";
    public const string RoleWShopStaff        = "33333333-0000-0000-0000-000000000005";
    public const string RoleWShopViewer       = "33333333-0000-0000-0000-000000000006";
    public const string RoleWShopEditor       = "33333333-0000-0000-0000-000000000007";
    public const string RoleWShopUser         = "33333333-0000-0000-0000-000000000008";
    public const string RoleRShopAdmin        = "33333333-0000-0000-0000-000000000009";
    public const string RoleRShopAdministration = "33333333-0000-0000-0000-000000000010";
    public const string RoleRShopManager      = "33333333-0000-0000-0000-000000000011";
    public const string RoleRShopStaff        = "33333333-0000-0000-0000-000000000012";
    public const string RoleRShopViewer       = "33333333-0000-0000-0000-000000000013";
    public const string RoleRShopEditor       = "33333333-0000-0000-0000-000000000014";
    public const string RoleRShopUser         = "33333333-0000-0000-0000-000000000015";

    // Users
    public const string UserSuperAdmin      = "44444444-0000-0000-0000-000000000001";
    public const string UserWAdmin          = "44444444-0000-0000-0000-000000000002";
    public const string UserWAdministration = "44444444-0000-0000-0000-000000000003";
    public const string UserWManager        = "44444444-0000-0000-0000-000000000004";
    public const string UserWStaff          = "44444444-0000-0000-0000-000000000005";
    public const string UserWViewer         = "44444444-0000-0000-0000-000000000006";
    public const string UserWEditor         = "44444444-0000-0000-0000-000000000007";
    public const string UserWUser           = "44444444-0000-0000-0000-000000000008";
    public const string UserRAdmin          = "44444444-0000-0000-0000-000000000009";
    public const string UserRAdministration = "44444444-0000-0000-0000-000000000010";
    public const string UserRManager        = "44444444-0000-0000-0000-000000000011";
    public const string UserRStaff          = "44444444-0000-0000-0000-000000000012";
    public const string UserRViewer         = "44444444-0000-0000-0000-000000000013";
    public const string UserREditor         = "44444444-0000-0000-0000-000000000014";
    public const string UserRUser           = "44444444-0000-0000-0000-000000000015";

    // TranslationKeys
    public const string TKey1 = "55555555-0000-0000-0000-000000000001";
    public const string TKey2 = "55555555-0000-0000-0000-000000000002";
    public const string TKey3 = "55555555-0000-0000-0000-000000000003";
    public const string TKey4 = "55555555-0000-0000-0000-000000000004";
    public const string TKey5 = "55555555-0000-0000-0000-000000000005";
    public const string TKey6 = "55555555-0000-0000-0000-000000000006";
    public const string TKey7 = "55555555-0000-0000-0000-000000000007";
    public const string TKey8 = "55555555-0000-0000-0000-000000000008";

    // Translations
    public const string Trans1  = "66666666-0000-0000-0000-000000000001";
    public const string Trans2  = "66666666-0000-0000-0000-000000000002";
    public const string Trans3  = "66666666-0000-0000-0000-000000000003";
    public const string Trans4  = "66666666-0000-0000-0000-000000000004";
    public const string Trans5  = "66666666-0000-0000-0000-000000000005";
    public const string Trans6  = "66666666-0000-0000-0000-000000000006";
    public const string Trans7  = "66666666-0000-0000-0000-000000000007";
    public const string Trans8  = "66666666-0000-0000-0000-000000000008";
    public const string Trans9  = "66666666-0000-0000-0000-000000000009";
    public const string Trans10 = "66666666-0000-0000-0000-000000000010";
    public const string Trans11 = "66666666-0000-0000-0000-000000000011";
    public const string Trans12 = "66666666-0000-0000-0000-000000000012";

    // Provinces
    public const string ProvinceKabul    = "77777777-0000-0000-0000-000000000001";
    public const string ProvinceHerat    = "77777777-0000-0000-0000-000000000002";
    public const string ProvinceKandahar = "77777777-0000-0000-0000-000000000003";
    public const string ProvinceBalkh    = "77777777-0000-0000-0000-000000000004";

    // ProvinceTranslations
    public const string PTrans1  = "88888888-0000-0000-0000-000000000001";
    public const string PTrans2  = "88888888-0000-0000-0000-000000000002";
    public const string PTrans3  = "88888888-0000-0000-0000-000000000003";
    public const string PTrans4  = "88888888-0000-0000-0000-000000000004";
    public const string PTrans5  = "88888888-0000-0000-0000-000000000005";
    public const string PTrans6  = "88888888-0000-0000-0000-000000000006";
    public const string PTrans7  = "88888888-0000-0000-0000-000000000007";
    public const string PTrans8  = "88888888-0000-0000-0000-000000000008";
    public const string PTrans9  = "88888888-0000-0000-0000-000000000009";
    public const string PTrans10 = "88888888-0000-0000-0000-000000000010";
    public const string PTrans11 = "88888888-0000-0000-0000-000000000011";
    public const string PTrans12 = "88888888-0000-0000-0000-000000000012";

    // Districts
    public const string DistrictKabulCenter  = "99999999-0000-0000-0000-000000000001";
    public const string DistrictKabulNorth   = "99999999-0000-0000-0000-000000000002";
    public const string DistrictHeratCenter  = "99999999-0000-0000-0000-000000000003";

    // UnitOfMeasures
    public const string UnitPiece      = "aaaaaaaa-0000-0000-0000-000000000001";
    public const string UnitBottle     = "aaaaaaaa-0000-0000-0000-000000000002";
    public const string UnitPack       = "aaaaaaaa-0000-0000-0000-000000000003";
    public const string UnitBox        = "aaaaaaaa-0000-0000-0000-000000000004";
    public const string UnitCarton     = "aaaaaaaa-0000-0000-0000-000000000005";
    public const string UnitLiter      = "aaaaaaaa-0000-0000-0000-000000000006";
    public const string UnitKilogram   = "aaaaaaaa-0000-0000-0000-000000000007";
    public const string UnitGram       = "aaaaaaaa-0000-0000-0000-000000000008";
    public const string UnitMilliliter = "aaaaaaaa-0000-0000-0000-000000000009";
    public const string UnitDozen      = "aaaaaaaa-0000-0000-0000-000000000010";

    // Categories
    public const string CatBeverages   = "bbbbbbbb-0000-0000-0000-000000000001";
    public const string CatFood        = "bbbbbbbb-0000-0000-0000-000000000002";
    public const string CatStationery  = "bbbbbbbb-0000-0000-0000-000000000003";
    public const string CatGrocery     = "bbbbbbbb-0000-0000-0000-000000000004";
    public const string CatPersonalCare = "bbbbbbbb-0000-0000-0000-000000000005";
    public const string CatElectronics = "bbbbbbbb-0000-0000-0000-000000000006";

    // Products
    public const string ProdCocaCola     = "cccccccc-0000-0000-0000-000000000001";
    public const string ProdPepsi        = "cccccccc-0000-0000-0000-000000000002";
    public const string ProdMineralWater = "cccccccc-0000-0000-0000-000000000003";
    public const string ProdOreo         = "cccccccc-0000-0000-0000-000000000004";
    public const string ProdLays         = "cccccccc-0000-0000-0000-000000000005";
    public const string ProdNoodles      = "cccccccc-0000-0000-0000-000000000006";
    public const string ProdNotebook     = "cccccccc-0000-0000-0000-000000000007";
    public const string ProdBluePen      = "cccccccc-0000-0000-0000-000000000008";
    public const string ProdPencilSet    = "cccccccc-0000-0000-0000-000000000009";
    public const string ProdCookingOil   = "cccccccc-0000-0000-0000-000000000010";
    public const string ProdRice         = "cccccccc-0000-0000-0000-000000000011";
    public const string ProdSugar        = "cccccccc-0000-0000-0000-000000000012";
    public const string ProdShampoo      = "cccccccc-0000-0000-0000-000000000013";
    public const string ProdToothpaste   = "cccccccc-0000-0000-0000-000000000014";
    public const string ProdUsbCable     = "cccccccc-0000-0000-0000-000000000015";
    public const string ProdCharger      = "cccccccc-0000-0000-0000-000000000016";

    // ProductUnits
    public const string PU1  = "dddddddd-0000-0000-0000-000000000001";
    public const string PU2  = "dddddddd-0000-0000-0000-000000000002";
    public const string PU3  = "dddddddd-0000-0000-0000-000000000003";
    public const string PU4  = "dddddddd-0000-0000-0000-000000000004";
    public const string PU5  = "dddddddd-0000-0000-0000-000000000005";
    public const string PU6  = "dddddddd-0000-0000-0000-000000000006";
    public const string PU7  = "dddddddd-0000-0000-0000-000000000007";
    public const string PU8  = "dddddddd-0000-0000-0000-000000000008";
    public const string PU9  = "dddddddd-0000-0000-0000-000000000009";
    public const string PU10 = "dddddddd-0000-0000-0000-000000000010";
    public const string PU11 = "dddddddd-0000-0000-0000-000000000011";
    public const string PU12 = "dddddddd-0000-0000-0000-000000000012";
    public const string PU13 = "dddddddd-0000-0000-0000-000000000013";
    public const string PU14 = "dddddddd-0000-0000-0000-000000000014";
    public const string PU15 = "dddddddd-0000-0000-0000-000000000015";
    public const string PU16 = "dddddddd-0000-0000-0000-000000000016";
    public const string PU17 = "dddddddd-0000-0000-0000-000000000017";
    public const string PU18 = "dddddddd-0000-0000-0000-000000000018";
    public const string PU19 = "dddddddd-0000-0000-0000-000000000019";
    public const string PU20 = "dddddddd-0000-0000-0000-000000000020";
    public const string PU21 = "dddddddd-0000-0000-0000-000000000021";
    public const string PU22 = "dddddddd-0000-0000-0000-000000000022";
    public const string PU23 = "dddddddd-0000-0000-0000-000000000023";
    public const string PU24 = "dddddddd-0000-0000-0000-000000000024";
    public const string PU25 = "dddddddd-0000-0000-0000-000000000025";
    public const string PU26 = "dddddddd-0000-0000-0000-000000000026";
    public const string PU27 = "dddddddd-0000-0000-0000-000000000027";
    public const string PU28 = "dddddddd-0000-0000-0000-000000000028";
    public const string PU29 = "dddddddd-0000-0000-0000-000000000029";
    public const string PU30 = "dddddddd-0000-0000-0000-000000000030";
    public const string PU31 = "dddddddd-0000-0000-0000-000000000031";
    public const string PU32 = "dddddddd-0000-0000-0000-000000000032";
    public const string PU33 = "dddddddd-0000-0000-0000-000000000033";
    public const string PU34 = "dddddddd-0000-0000-0000-000000000034";
    public const string PU35 = "dddddddd-0000-0000-0000-000000000035";
    public const string PU36 = "dddddddd-0000-0000-0000-000000000036";
    public const string PU37 = "dddddddd-0000-0000-0000-000000000037";
    public const string PU38 = "dddddddd-0000-0000-0000-000000000038";
    public const string PU39 = "dddddddd-0000-0000-0000-000000000039";
    public const string PU40 = "dddddddd-0000-0000-0000-000000000040";
    public const string PU41 = "dddddddd-0000-0000-0000-000000000041";
    public const string PU42 = "dddddddd-0000-0000-0000-000000000042";
    public const string PU43 = "dddddddd-0000-0000-0000-000000000043";
    public const string PU44 = "dddddddd-0000-0000-0000-000000000044";
    public const string PU45 = "dddddddd-0000-0000-0000-000000000045";
    public const string PU46 = "dddddddd-0000-0000-0000-000000000046";
    public const string PU47 = "dddddddd-0000-0000-0000-000000000047";

    // Customers
    public const string Cust1  = "eeeeeeee-0000-0000-0000-000000000001";
    public const string Cust2  = "eeeeeeee-0000-0000-0000-000000000002";
    public const string Cust3  = "eeeeeeee-0000-0000-0000-000000000003";
    public const string Cust4  = "eeeeeeee-0000-0000-0000-000000000004";
    public const string Cust5  = "eeeeeeee-0000-0000-0000-000000000005";
    public const string Cust6  = "eeeeeeee-0000-0000-0000-000000000006";
    public const string Cust7  = "eeeeeeee-0000-0000-0000-000000000007";
    public const string Cust8  = "eeeeeeee-0000-0000-0000-000000000008";
    public const string Cust9  = "eeeeeeee-0000-0000-0000-000000000009";
    public const string Cust10 = "eeeeeeee-0000-0000-0000-000000000010";

    // ShopOwners
    public const string ShopOwner1 = "ffffffff-0000-0000-0000-000000000001";
    public const string ShopOwner2 = "ffffffff-0000-0000-0000-000000000002";
    public const string ShopOwner3 = "ffffffff-0000-0000-0000-000000000003";

    // StockBatches
    public const string Batch1 = "11111111-1111-0000-0000-000000000001";
    public const string Batch2 = "11111111-1111-0000-0000-000000000002";
    public const string Batch3 = "11111111-1111-0000-0000-000000000003";
    public const string Batch4 = "11111111-1111-0000-0000-000000000004";

    // StockTransactions
    public const string STrans1  = "22222222-2222-0000-0000-000000000001";
    public const string STrans2  = "22222222-2222-0000-0000-000000000002";
    public const string STrans3  = "22222222-2222-0000-0000-000000000003";
    public const string STrans4  = "22222222-2222-0000-0000-000000000004";
    public const string STrans5  = "22222222-2222-0000-0000-000000000005";
    public const string STrans6  = "22222222-2222-0000-0000-000000000006";
    public const string STrans7  = "22222222-2222-0000-0000-000000000007";
    public const string STrans8  = "22222222-2222-0000-0000-000000000008";
    public const string STrans9  = "22222222-2222-0000-0000-000000000009";
    public const string STrans10 = "22222222-2222-0000-0000-000000000010";

    // ProductPrices
    public const string PP1  = "33333333-3333-0000-0000-000000000001";
    public const string PP2  = "33333333-3333-0000-0000-000000000002";
    public const string PP3  = "33333333-3333-0000-0000-000000000003";
    public const string PP4  = "33333333-3333-0000-0000-000000000004";
    public const string PP5  = "33333333-3333-0000-0000-000000000005";
    public const string PP6  = "33333333-3333-0000-0000-000000000006";
    public const string PP7  = "33333333-3333-0000-0000-000000000007";
    public const string PP8  = "33333333-3333-0000-0000-000000000008";
    public const string PP9  = "33333333-3333-0000-0000-000000000009";
    public const string PP10 = "33333333-3333-0000-0000-000000000010";
    public const string PP11 = "33333333-3333-0000-0000-000000000011";
    public const string PP12 = "33333333-3333-0000-0000-000000000012";
    public const string PP13 = "33333333-3333-0000-0000-000000000013";
    public const string PP14 = "33333333-3333-0000-0000-000000000014";
    public const string PP15 = "33333333-3333-0000-0000-000000000015";
    public const string PP16 = "33333333-3333-0000-0000-000000000016";
    public const string PP17 = "33333333-3333-0000-0000-000000000017";
    public const string PP18 = "33333333-3333-0000-0000-000000000018";
    public const string PP19 = "33333333-3333-0000-0000-000000000019";
    public const string PP20 = "33333333-3333-0000-0000-000000000020";
    public const string PP21 = "33333333-3333-0000-0000-000000000021";
    public const string PP22 = "33333333-3333-0000-0000-000000000022";
    public const string PP23 = "33333333-3333-0000-0000-000000000023";
    public const string PP24 = "33333333-3333-0000-0000-000000000024";
    public const string PP25 = "33333333-3333-0000-0000-000000000025";
    public const string PP26 = "33333333-3333-0000-0000-000000000026";
    public const string PP27 = "33333333-3333-0000-0000-000000000027";
    public const string PP28 = "33333333-3333-0000-0000-000000000028";
    public const string PP29 = "33333333-3333-0000-0000-000000000029";
    public const string PP30 = "33333333-3333-0000-0000-000000000030";
    public const string PP31 = "33333333-3333-0000-0000-000000000031";
    public const string PP32 = "33333333-3333-0000-0000-000000000032";
    public const string PP33 = "33333333-3333-0000-0000-000000000033";
    public const string PP34 = "33333333-3333-0000-0000-000000000034";
    public const string PP35 = "33333333-3333-0000-0000-000000000035";
    public const string PP36 = "33333333-3333-0000-0000-000000000036";
    public const string PP37 = "33333333-3333-0000-0000-000000000037";
    public const string PP38 = "33333333-3333-0000-0000-000000000038";
    public const string PP39 = "33333333-3333-0000-0000-000000000039";
    public const string PP40 = "33333333-3333-0000-0000-000000000040";
    public const string PP41 = "33333333-3333-0000-0000-000000000041";
    public const string PP42 = "33333333-3333-0000-0000-000000000042";
    public const string PP43 = "33333333-3333-0000-0000-000000000043";
    public const string PP44 = "33333333-3333-0000-0000-000000000044";
    public const string PP45 = "33333333-3333-0000-0000-000000000045";
    public const string PP46 = "33333333-3333-0000-0000-000000000046";
    public const string PP47 = "33333333-3333-0000-0000-000000000047";

    // LoanAccounts
    public const string Loan1  = "44444444-4444-0000-0000-000000000001";
    public const string Loan2  = "44444444-4444-0000-0000-000000000002";
    public const string Loan3  = "44444444-4444-0000-0000-000000000003";
    public const string Loan4  = "44444444-4444-0000-0000-000000000004";
    public const string Loan5  = "44444444-4444-0000-0000-000000000005";
    public const string Loan6  = "44444444-4444-0000-0000-000000000006";
    public const string Loan7  = "44444444-4444-0000-0000-000000000007";
    public const string Loan8  = "44444444-4444-0000-0000-000000000008";
    public const string Loan9  = "44444444-4444-0000-0000-000000000009";
    public const string Loan10 = "44444444-4444-0000-0000-000000000010";
}
