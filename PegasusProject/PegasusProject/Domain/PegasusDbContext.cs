using Microsoft.EntityFrameworkCore;
using PegasusProject.Domain.Model;

namespace PegasusProject.Domain
{
    public class PegasusDbContext : DbContext
    {
        public PegasusDbContext(DbContextOptions<PegasusDbContext> options) : base(options)
        {
        }

        public DbSet<SalesDetails> SalesDetails { get; set; }
        public DbSet<SalesHeader> SalesHeader { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
