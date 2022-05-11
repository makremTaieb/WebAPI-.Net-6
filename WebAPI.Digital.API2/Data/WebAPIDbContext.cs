using Microsoft.EntityFrameworkCore;
using WebAPI.Digital.API2.Domain;

namespace WebAPI.Digital.API2.Data
{
    public class WebAPIDbContext :DbContext
    {
        public WebAPIDbContext(DbContextOptions<WebAPIDbContext> options) : base(options)
        {

        }


        public DbSet<Relations> Relations { get; set; }
        public DbSet<Tiers> Tiers { get; set; }
        
        

    }
}
