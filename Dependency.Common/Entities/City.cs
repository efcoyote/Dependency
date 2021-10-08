using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dependency.Common.Entities
{
	public class City
	{
		public int Id { get; set; }

		[MaxLength(100)]
		public string CityName { get; set; }


		[Column(nameof(Country)), ForeignKey(nameof(Country))]
		public int? CountryId { get; set; }

		public virtual Country Country { get; set; }
	}
}
