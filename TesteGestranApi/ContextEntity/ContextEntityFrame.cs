using Microsoft.EntityFrameworkCore;
using TesteGestranApi.Models;

namespace TesteGestranApi.ContextEntity
{
    public class ContextEntityFrame:DbContext
    {
        public ContextEntityFrame(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Provider> Providers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContextEntityFrame).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
