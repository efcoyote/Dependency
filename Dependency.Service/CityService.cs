using System.Collections.Generic;
using System.Threading.Tasks;
using Dependency.Common.ValueObjects;
using Dependency.DataAccess;

namespace Dependency.Service
{
	public class CityService
	{
		private readonly CityRepository cityRepository;

		public CityService(CityRepository cityRepository)
		{
			this.cityRepository = cityRepository;
		}

		public Task<IEnumerable<CityInfoVO>> GetCities()
		{
			return cityRepository.GetCityInfos();
		}
	}
}
