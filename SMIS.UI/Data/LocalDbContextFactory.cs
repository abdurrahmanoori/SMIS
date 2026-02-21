using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SMIS.UI.Data.Interceptors;
using SMIS.UI.Services.Auth;

namespace SMIS.UI.Data;

public class LocalDbContextFactory : IDesignTimeDbContextFactory<LocalDbContext>
{
    public LocalDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<LocalDbContext>();
        optionsBuilder.UseSqlite("Data Source=smis_local.db");
        
        var currentUser = new MauiCurrentUser();
        var auditInterceptor = new AuditInterceptor(currentUser);
        
        return new LocalDbContext(optionsBuilder.Options, auditInterceptor);
    }
}
