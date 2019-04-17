namespace Bibliotheca
{
	public class Contact
	{
		/// <summary>
		/// First name of the person.
		/// </summary>
		public string FirstName { get; private set; }
		/// <summary>
		/// Last name of the person.
		/// </summary>
		public string LastName { get; private set; }
		/// <summary>
		/// Postal address of the person.
		/// </summary>
		public Address PostalAddress { get; private set; }
		/// <summary>
		/// Email of the person.
		/// </summary>
		public string Email { get; private set; }
		/// <summary>
		/// Phone number of the person.
		/// </summary>
		public string PhoneNo { get; private set; }
	}
}
