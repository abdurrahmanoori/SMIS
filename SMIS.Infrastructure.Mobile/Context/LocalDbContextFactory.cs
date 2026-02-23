using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SMIS.Infrastructure.Mobile.Interceptors;
using SMIS.Infrastructure.Mobile.Services.Identity;

namespace SMIS.Infrastructure.Mobile.Context;

public class LocalDbContextFactory : IDesignTimeDbContextFactory<LocalDbContext>
{
    public LocalDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<LocalDbContext>();
        optionsBuilder.UseSqlite("Data Source=smis_local.db");
        
        return new LocalDbContext(optionsBuilder.Options);
    }
}
