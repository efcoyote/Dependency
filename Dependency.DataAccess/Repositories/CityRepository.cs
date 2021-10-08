using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dependency.Common.Entities;
using Dependency.Common.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Dependency.DataAccess
{
	public class CityRepository : BaseRepository<City, DatabaseContext>
	{
		public CityRepository(DatabaseContext dbContext) : base(dbContext) { }

		public async Task<IEnumerable<CityInfoVO>> GetCityInfos()
		{
			var query = from c in dbContext.Cities
						join co in dbContext.Countries on c.CountryId equals co.Id
						select new CityInfoVO
						{
							Id = c.Id,
							City = c.CityName,
							Country = co.Name
						};

			return await query.ToListAsync().ConfigureAwait(false);
		}
	}
}
