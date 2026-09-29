using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class ApplicationComponentSeeder
{
    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<ApplicationComponent>().HasData(
            new ApplicationComponent
            {
                Id = AuthorizationSeedIds.ComponentCategories,
                Key = ApplicationComponentKeys.Categories,
                Name = "Categories",
                DisplayOrder = 1,
                ShowInMenu = true,
                IsActive = true
            });
    }
}
