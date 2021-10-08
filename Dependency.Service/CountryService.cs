using System.Collections.Generic;
using System.Threading.Tasks;
using Dependency.Common.Entities;
using Dependency.DataAccess;

namespace Dependency.Service
{
	public class CountryService
	{
		private readonly CountryRepository countryRepository;

		public CountryService(CountryRepository countryRepository)
		{
			this.countryRepository = countryRepository;
		}

		public Task<IEnumerable<Country>> GetCountries()
		{
			return countryRepository.GetAll();
		}
	}
}
