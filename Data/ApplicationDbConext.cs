using lab4.Model;
using Microsoft.EntityFrameworkCore;
using Lab4COM3773.Data;

namespace lab4.Data
{
    public class ApplicationDbContext: DbContext
    {
	    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<Player>().Property(m => m.TeamName).IsRequired();

            //builder.Entity<Team>().Property(p => p.TeamName).HasMaxLength(30);

            builder.Entity<City>().ToTable("City");
            builder.Entity<Province>().ToTable("Province");
            builder.Seed();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }


}
