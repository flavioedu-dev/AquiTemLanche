using AquiTemLanche.Models;
using Microsoft.EntityFrameworkCore;

namespace AquiTemLanche.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Snack> Snacks { get; set; }
    }
}
