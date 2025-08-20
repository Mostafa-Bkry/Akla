using Microsoft.EntityFrameworkCore;

namespace Akla.SharedData.Context
{
    public class AklaDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
