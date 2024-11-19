using Labs1.Models;
using Microsoft.EntityFrameworkCore;

namespace Labs1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<GameLevel> GameLevels { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<Region> Region { get; set; }
    }
}
