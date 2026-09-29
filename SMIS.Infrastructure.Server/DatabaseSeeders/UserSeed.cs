using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class UserSeed
{
    // Every seeded account uses its canonical role name at its shop domain.
    // The password for each seeded account is exactly the same as its username.

    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<ApplicationUser>().HasData(
            // Main Store
            CreateUser(SeedIds.UserSuperAdmin, SD.Role_Super_Admin, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainShopAdmin, SD.Role_Shop_Admin, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainManager, SD.Role_Manager, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainInventoryManager, SD.Role_Inventory_Manager, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainSalesManager, SD.Role_Sales_Manager, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainCashier, SD.Role_Cashier, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainStaff, SD.Role_Staff, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainViewer, SD.Role_Viewer, SeedIds.Shop1),

            // Branch Store
            CreateUser(SeedIds.UserBranchShopAdmin, SD.Role_Shop_Admin, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchManager, SD.Role_Manager, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchInventoryManager, SD.Role_Inventory_Manager, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchSalesManager, SD.Role_Sales_Manager, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchCashier, SD.Role_Cashier, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchStaff, SD.Role_Staff, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchViewer, SD.Role_Viewer, SeedIds.Shop2),

            // Wasil Shop
            CreateUser(SeedIds.UserWasilShopAdmin, SD.Role_Shop_Admin, SeedIds.ShopWasil)
        );
    }

    internal static string GetSeedEmail(
        string roleName,
        string shopId
    )
        => $"{roleName.ToLowerInvariant()}@{GetShopDomain(shopId)}.com";

    private static ApplicationUser CreateUser(
        string id,
        string roleName,
        string shopId
    )
    {
        var email = GetSeedEmail(roleName, shopId);
        var user = ApplicationUser.Create(email, email, shopId, GetShopName(shopId), roleName, null, SeedIds.LangEn);

        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.Id))!.SetValue(user, id);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.ShopName))!.SetValue(user, GetShopName(shopId));
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.EmailConfirmed))!.SetValue(user, true);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.PhoneNumberConfirmed))!.SetValue(user, true);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.SecurityStamp))!.SetValue(user, id);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.ConcurrencyStamp))!.SetValue(user, id);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.NormalizedUserName))!.SetValue(user,
            email.ToUpperInvariant());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.NormalizedEmail))!.SetValue(user, email.ToUpper());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.PasswordHash))!.SetValue(user,
            GetSeedPasswordHash(email));

        return user;
    }

    private static string GetSeedPasswordHash(
        string userName
    ) => userName switch
    {
        "superadmin@mainstore.com" =>
            "AQAAAAIAAYagAAAAEKlhy7lx1/qM3NGtL0ETO5AXxyobVtC66UBBAmw+bxawQIYCLg/C7sxqZ3YZ7gtibw==",
        "shopadmin@mainstore.com" =>
            "AQAAAAIAAYagAAAAEAFyC/O4IYX4EqJ6uemvh6qLpM+RL+BzKde7gcjIZ+EeBVHOMYioelyn63fO2B6l4Q==",
        "inventorymanager@mainstore.com" =>
            "AQAAAAIAAYagAAAAEEqFdgkYefuwPNEn1jTrnNDT2cXrDJjRORjUibCLxCbqp+d/Kr5OMbAlYu4ecVLJCw==",
        "manager@mainstore.com" =>
            "AQAAAAIAAYagAAAAEACWFVheXXg44bF1SnLnHmLMlQio+gXK/CewFdlElgv/87pZMNXarSylYHHQM9TDzw==",
        "staff@mainstore.com" =>
            "AQAAAAIAAYagAAAAEDmcAaC68oLRPp7N62uOQxou38wJStu0PDnRTX7dYoBbT8wnkzWzn2Fzm7FDRCDRzw==",
        "viewer@mainstore.com" =>
            "AQAAAAIAAYagAAAAEB7prP7koVE/OUlR9s4TSx0GR+FdUNWA27pdMMmjDqKs6M7hBNN8p4/i/xKH6NPLug==",
        "salesmanager@mainstore.com" =>
            "AQAAAAIAAYagAAAAEO1n88zJKKBvI/cGAfFb7BVkPvG1N5u7XG3fLVxfrTyKxpdaLJzpsdiPt6TBWNtFtQ==",
        "cashier@mainstore.com" =>
            "AQAAAAIAAYagAAAAED9+2xjrPAaZ+O1VQQy0sIgJ0EplJ5KrJspahcT6o3VFNrdy0SvSC6oqfg2lVAmtug==",
        "shopadmin@branchstore.com" =>
            "AQAAAAIAAYagAAAAED0yMSW4bbZ6Wgcrk1YnSidOV95fGUDyNIQ4L4hB4b5pVdp2NN/RInGrFcwCIFRcFg==",
        "inventorymanager@branchstore.com" =>
            "AQAAAAIAAYagAAAAEP2Dxp0S7KUBx6SLgPX0gGv5eBzRIhYkQUuP+FL1OUD8X34glIKrFNRnqMgsgvtEnQ==",
        "manager@branchstore.com" =>
            "AQAAAAIAAYagAAAAEPtblkwvX2iBlaKTmNy5Es40KZ04OXcOKC0Y0J2ZAHrbhbg8AChjPMIG2KI/Caq0nA==",
        "staff@branchstore.com" =>
            "AQAAAAIAAYagAAAAECbKJmJ0XQ08tMqwegOAlUNXOVYOfcFTRZ/bvegWVIDBLAwked7Mt1piJlMWzVusjw==",
        "viewer@branchstore.com" =>
            "AQAAAAIAAYagAAAAEOXSRj3/KMViNcF6fj3Z2pE5+MWC7CEBL3uziK5Pg+pvt44SYOn5L+ZrqH5tBehhDg==",
        "salesmanager@branchstore.com" =>
            "AQAAAAIAAYagAAAAEIxjMnDpe8QRnCOUl5C5oxwfF4A48n+oSX4yqe6nUhfGgASCAZlnqD0mVh/FrDOIsA==",
        "cashier@branchstore.com" =>
            "AQAAAAIAAYagAAAAEIoxjwiSMSqM3gzeKFCKj5vPuGOl/5qjBMCmV1j3YT1FXFVc6GHZiArNXc3kZ8VBOw==",
        "shopadmin@wasilshop.com" =>
            "AQAAAAIAAYagAAAAEJOEjUXSHxHnUnYrH7jcO97NRqThEvOEb7hL5hWacH9PLNP1VHRAPfLih3PUZc1utQ==",
        _ => throw new InvalidOperationException($"No seeded password hash is configured for '{userName}'.")
    };

    private static string GetShopDomain(
        string shopId
    ) => shopId switch
    {
        SeedIds.Shop1 => "mainstore",
        SeedIds.Shop2 => "branchstore",
        SeedIds.Shop3 => "warehouse",
        SeedIds.ShopWasil => "wasilshop",
        _ => "smis"
    };

    private static string? GetShopName(
        string shopId
    ) => shopId switch
    {
        SeedIds.Shop1 => "Main Store",
        SeedIds.Shop2 => "Branch Store",
        SeedIds.Shop3 => "Warehouse",
        SeedIds.ShopWasil => "Wasil Shop",
        _ => null
    };
}