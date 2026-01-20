using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Entities.Shop;
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
            #endregion

            // Allow extension from other layers via partial method
            OnModelCreatingPartial(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            optionsBuilder.ConfigureWarnings(warnings =>
       warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<Province> Provinces { get; set; }
        public DbSet<ProvinceTranslation> ProvinceTranslations { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<AppLog> AppLogs { get; set; }
        public DbSet<TranslationKey> TranslationKeys { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<Shop> Shops { get; set; }
    }
}
