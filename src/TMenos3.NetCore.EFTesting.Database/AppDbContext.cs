using Microsoft.EntityFrameworkCore;
using TMenos3.NetCore.EFTesting.Database.Models;

namespace TMenos3.NetCore.EFTesting.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }
    }
}
