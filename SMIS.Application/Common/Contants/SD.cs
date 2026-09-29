namespace SMIS.Application.Common.Contants;

public static class SD
{
    public const string Role_Super_Admin = "SuperAdmin";
    public const string Role_Shop_Admin = "ShopAdmin";
    public const string Role_Manager = "Manager";
    public const string Role_Inventory_Manager = "InventoryManager";
    public const string Role_Sales_Manager = "SalesManager";
    public const string Role_Cashier = "Cashier";
    public const string Role_Staff = "Staff";
    public const string Role_Viewer = "Viewer";

    public static readonly string[] AllRoles =
    [
        Role_Super_Admin,
        Role_Shop_Admin,
        Role_Manager,
        Role_Inventory_Manager,
        Role_Sales_Manager,
        Role_Cashier,
        Role_Staff,
        Role_Viewer
    ];

    public static string? GetCanonicalRole(
        string? role
    )
    {
        if (string.IsNullOrWhiteSpace(role)) return null;

        var trimmedRole = role.Trim();
        foreach (var supportedRole in AllRoles)
        {
            if (string.Equals(supportedRole, trimmedRole, StringComparison.OrdinalIgnoreCase))
                return supportedRole;
        }

        return null;
    }
}