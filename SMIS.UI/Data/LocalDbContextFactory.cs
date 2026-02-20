using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SMIS.UI.Data;

public class LocalDbContextFactory : IDesignTimeDbContextFactory<LocalDbContext>
{
    public LocalDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<LocalDbContext>();
        optionsBuilder.UseSqlite("Data Source=smis_local.db");
        
        return new LocalDbContext(optionsBuilder.Options);
    }
}
