namespace Dependency.Common.ValueObjects
{
	public class CityInfoVO
	{
		public int Id { get; set; }
		public string City { get; set; }
		public string Country { get; set; }

		public override string ToString()
		{
			return $"{ City } / { Country } ({ Id })";
		}
	}
}
