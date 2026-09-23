using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders
{
    public static class RoleSeeder
    {
        public static void DataSeed(
            ModelBuilder modelBuilder
        )
        {
            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = SeedIds.RoleSuperAdmin, Name = SD.Role_Super_Admin,
                    NormalizedName = SD.Role_Super_Admin.ToUpper()
                },
                new ApplicationRole
                    { Id = SeedIds.RoleAdmin, Name = SD.Role_Admin, NormalizedName = SD.Role_Admin.ToUpper() },
                new ApplicationRole
                {
                    Id = SeedIds.RoleAdministration, Name = SD.Role_Administration,
                    NormalizedName = SD.Role_Administration.ToUpper()
                },
                new ApplicationRole
                    { Id = SeedIds.RoleManager, Name = SD.Role_Manager, NormalizedName = SD.Role_Manager.ToUpper() },
                new ApplicationRole
                    { Id = SeedIds.RoleStaff, Name = SD.Role_Staff, NormalizedName = SD.Role_Staff.ToUpper() },
                new ApplicationRole
                    { Id = SeedIds.RoleViewer, Name = SD.Role_Viewer, NormalizedName = SD.Role_Viewer.ToUpper() },
                new ApplicationRole
                    { Id = SeedIds.RoleEditor, Name = SD.Role_Editor, NormalizedName = SD.Role_Editor.ToUpper() },
                new ApplicationRole
                    { Id = SeedIds.RoleUser, Name = SD.Role_User, NormalizedName = SD.Role_User.ToUpper() }
            );
        }
    }
}