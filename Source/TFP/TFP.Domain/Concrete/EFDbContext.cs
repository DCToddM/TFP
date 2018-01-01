using TFP.Domain.Entities;
using System.Data.Entity;

namespace TFP.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
