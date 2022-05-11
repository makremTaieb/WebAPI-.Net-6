using Digital.BackOffice.Model;
using Digital.Core;
using Microsoft.EntityFrameworkCore;

namespace Digital.BackOffice.Data
{
    public class DigitalDbContext : DigitalDbContextBase
    {
        public DigitalDbContext(DbContextOptions<DigitalDbContext> options) : base(options)
        {
            //
        }

        public DbSet<Relation> Relations { get; set; }

        public DbSet<Tier> Tiers { get; set; }

        public DbSet<Account> Accounts { get; set; }

        
        public DbSet<RelationTiers> RTiers2 { get; set; }

    }
}
