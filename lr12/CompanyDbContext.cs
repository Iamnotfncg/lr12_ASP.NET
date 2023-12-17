using Microsoft.EntityFrameworkCore;

namespace lr12
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions contextOptions) : base(contextOptions) { }

        public DbSet<Company> Companies { get; set; }
    }
}
