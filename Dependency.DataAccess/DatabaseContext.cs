using Dependency.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dependency.DataAccess
{
	public class DatabaseContext : DbContext
	{
		public virtual DbSet<City> Cities { get; set; }
		public virtual DbSet<Country> Countries { get; set; }

		public DatabaseContext() : base() { }
		public DatabaseContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Country>().HasData(
				new Country { Id = 1, Name = "Germany" }
			);

			modelBuilder.Entity<City>().HasData(
				new City { Id = 1, CityName = "Berlin", CountryId = 1 },
				new City { Id = 2, CityName = "Nürnberg", CountryId = 1 }
			);
		}
	}
}
