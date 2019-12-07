using Microsoft.EntityFrameworkCore;
using Zobi.Domain.Entities;

namespace Zobi.Data
{
    public class ZobiDBContext : DbContext
    {
        public ZobiDBContext(DbContextOptions options)
                   : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("Users");
        }
    }
}
