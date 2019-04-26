namespace Bibliotheca
{
	public class Address
	{
		/// <summary>
		/// Street name
		/// </summary>
		public string Street { get; private set; }
		/// <summary>
		/// House number
		/// </summary>
		public int HouseNumber { get; private set; }
		/// <summary>
		/// City name
		/// </summary>
		public string City { get; private set; }
		/// <summary>
		/// Postcode
		/// </summary>
		public string Postcode { get; private set; }

		/// <summary>
		/// Creating new address.
		/// </summary>
		/// <param name="street"></param>
		/// <param name="houseNumber"></param>
		/// <param name="city"></param>
		/// <param name="postcode"></param>
		public Address(string street, int houseNumber, string city, string postcode)
		{
			Street = street;
			HouseNumber = houseNumber;
			City = city;
			Postcode = postcode;
		}
	}
}
