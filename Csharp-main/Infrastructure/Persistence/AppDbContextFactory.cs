using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Infrastructure.Persistence;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        
        var connectionString = Environment.GetEnvironmentVariable("ORACLE_CONN_STRING");

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException("ORACLE_CONN_STRING environment variable is not set.");
        }

        optionsBuilder.UseOracle(connectionString);

        return new AppDbContext(optionsBuilder.Options);
    }
}
