using System.ComponentModel.DataAnnotations;

namespace Dependency.Common.Entities
{
	public class Country
	{
		public int Id { get; set; }

		[MaxLength(100)]
		public string Name { get; set; }
	}
}
