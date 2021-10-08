using Dependency.Common.Entities;

namespace Dependency.DataAccess
{
	public class CountryRepository : BaseRepository<Country, DatabaseContext>
	{
		public CountryRepository(DatabaseContext dbContext) : base(dbContext) { }
	}
}
