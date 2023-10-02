using Microsoft.EntityFrameworkCore;
using Models.Account;

namespace Helpers.DataContext
{
    public class DataContext : DbContext{

    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public DbSet<Account> Accounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("BankServiceDatabase"));
    }
}
}
