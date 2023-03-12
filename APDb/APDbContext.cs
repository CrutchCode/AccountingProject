using Microsoft.EntityFrameworkCore;

namespace APDb
{
    public class APDbContext : DbContext
    {
        public APDbContext(DbContextOptions<APDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Initialization data
            //modelBuilder.Entity<User>().HasData(
            //        new User { Id = 1, FirstName = "Tom", LastName = "WEWEW", Address = "TEST", Phone = "TEST" }
            //);
        }
    }
}