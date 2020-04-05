using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace MediaRentals.Infrastructure.EntityFramework
{
    public class MediaRentalsContext : DbContext
    {
        public MediaRentalsContext()
        {
        }

        public MediaRentalsContext(DbContextOptions<MediaRentalsContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
