using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Entities.Localization;
using SMIS.Infrastructure.DatabaseSeeders;
using System.Reflection;

namespace SMIS.Infrastructure.Context
{
    public partial class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply all IEntityTypeConfiguration classes from this assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region Seed Database
            UserSeed.DataSeed(modelBuilder);
            LanguageSeed.DataSeed(modelBuilder);
            #endregion

            // Allow extension from other layers via partial method
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<Province> Provinces { get; set; }
        public DbSet<ProvinceTranslation> ProvinceTranslations { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
