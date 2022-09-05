using Microsoft.EntityFrameworkCore;
using Sklepik.Models;
namespace Sklepik.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(pc => new { pc.Id, pc.Name });

        }

    }
}
