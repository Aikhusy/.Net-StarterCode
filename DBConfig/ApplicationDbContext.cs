using Microsoft.EntityFrameworkCore;
using StarterCode.Models;

namespace StarterCode.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Posts> Posts { get; set; }
    }
}
