using Microsoft.EntityFrameworkCore;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class LoanAccountSeed
{
    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        // Receivables are now created from persisted credit sales. Seeding standalone
        // loan rows would bypass the Sale -> Receivable invariant, so this seeder is
        // intentionally empty until matching Sale/SaleLine seed aggregates are needed.
    }
}