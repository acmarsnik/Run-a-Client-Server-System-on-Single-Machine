using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class WorldDbContext : DbContext
    {
        public WorldDbContext(DbContextOptions<WorldDbContext> options)
        : base(options) { }

        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<CountryLanguage> CountryLanguage { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryLanguage>()
                .HasKey(countryLanguage => new { countryLanguage.CountryCode, countryLanguage.Language});
        }
    }

    public class WorldDbContextFactory
    {
        public WorldDbContext Create(string connectionStirng)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WorldDbContext>();
            optionsBuilder.UseMySQL(connectionStirng);
            var dbContext = new WorldDbContext(optionsBuilder.Options);
            return dbContext;
        }
    }
}
