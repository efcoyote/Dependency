using System.Threading;
using System.Threading.Tasks;
using Dependency.DataAccess;
using Dependency.Service;
using Microsoft.Extensions.Hosting;

namespace Dependency.Console
{
	public class CliService : IHostedService
	{
		private readonly CityService cityService;

		public CliService(DatabaseContext dbContext, CityService cityService)
		{
			this.cityService = cityService;

			// hacky trick for seeding data into database
			dbContext.Database.EnsureCreated();
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			var cities = await cityService.GetCities().ConfigureAwait(false);

			System.Console.WriteLine();

			foreach (var city in cities)
				System.Console.WriteLine(city);

			System.Console.WriteLine();
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}
	}
}
