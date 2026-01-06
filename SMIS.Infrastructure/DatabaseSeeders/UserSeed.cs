using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class UserSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var admin = new ApplicationUser
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@local",
                NormalizedEmail = "ADMIN@LOCAL",
                EmailConfirmed = true,
                FirstName = "System",
                LastName = "Admin",
                SecurityStamp = "admin-seed"
            };
            admin.PasswordHash = hasher.HashPassword(admin, "Pass@123");

            var user = new ApplicationUser
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@local",
                NormalizedEmail = "USER@LOCAL",
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "User",
                SecurityStamp = "user-seed"
            };
            user.PasswordHash = hasher.HashPassword(user, "Pass@123");

            modelBuilder.Entity<ApplicationUser>().HasData(admin, user);
        }
    }
}
