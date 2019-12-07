using Microsoft.EntityFrameworkCore;
using Zobi.Domain.Entities;

namespace Zobi.Domain
{
    public class ZobiDBContext : DbContext, IZobiDBContext
    {
        public ZobiDBContext(DbContextOptions options)
                   : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Projects>().ToTable("Projects");

        }
    }
}
