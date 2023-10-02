using BankService.Models;
using Microsoft.EntityFrameworkCore;
using Models.Transaction;

namespace BankService.Data
{
    public class AccountsContext : DbContext{
    protected readonly IConfiguration Configuration;

    public AccountsContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
  => options.UseNpgsql(Configuration.GetConnectionString("BankServiceDatabase"));
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}
}
