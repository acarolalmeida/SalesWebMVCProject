using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Department> Department { get; set; }
        public DbSet<Models.Seller> Seller { get; set; } 
        public DbSet<Models.SalesRecord> SalesRecord { get; set; }
    }
}
