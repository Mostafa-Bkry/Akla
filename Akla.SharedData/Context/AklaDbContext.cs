using Microsoft.EntityFrameworkCore;

namespace Akla.SharedData.Context
{
    public class AklaDbContext : DbContext
    {

        public AklaDbContext(DbContextOptions<AklaDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
