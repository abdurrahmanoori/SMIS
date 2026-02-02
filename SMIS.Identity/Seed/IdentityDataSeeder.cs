using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Identity.Seed;

public static class IdentityDataSeeder
{
    public static async Task SeedAsync(IServiceProvider services)
    {
        using var scope = services.CreateScope();
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        // Roles to ensure
        var roles = new[] { "Admin", "User" };
        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new ApplicationRole { Name = role });
            }
        }

        // Default admin user
        var adminEmail = "admin@local";
        var adminUserName = "admin";
        var admin = await userManager.FindByNameAsync(adminUserName);
        if (admin == null)
        {
            admin = ApplicationUser.Create(
                adminUserName,
                adminEmail,
                "1", // Default shop ID
                "System",
                "Admin"
            );
            admin.ConfirmEmail();
            
            var adminPassword = "Pass@123";
            var createAdmin = await userManager.CreateAsync(admin, adminPassword);
            if (createAdmin.Succeeded)
            {
                await userManager.AddToRoleAsync(admin, "Admin");
            }
        }

        // Default normal user
        var userEmail = "user@local";
        var userUserName = "user";
        var user = await userManager.FindByNameAsync(userUserName);
        if (user == null)
        {
            user = ApplicationUser.Create(
                userUserName,
                userEmail,
                "1", // Default shop ID
                "Default",
                "User"
            );
            user.ConfirmEmail();
            
            var userPassword = "Pass@123";
            var createUser = await userManager.CreateAsync(user, userPassword);
            if (createUser.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "User");
            }
        }
    }
}
