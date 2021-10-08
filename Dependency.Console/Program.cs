using System.Threading.Tasks;
using Dependency.DataAccess;
using Dependency.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Dependency.Console
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			await Host.CreateDefaultBuilder(args)
				.ConfigureServices((_, services) =>
				{
					// startup class
					services.AddHostedService<CliService>();

					// dependency injection
					services.AddTransient<CityService>();
					services.AddTransient<CountryService>();

					services.AddTransient<CityRepository>();
					services.AddTransient<CountryRepository>();

					// in-memory database
					services.AddDbContext<DatabaseContext>(o => o.UseInMemoryDatabase("TestDatabase"));
				})
				.RunConsoleAsync();
		}
	}
}
