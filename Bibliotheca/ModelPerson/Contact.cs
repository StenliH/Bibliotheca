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

		/// <summary>
		/// Creating new Contact Info.
		/// </summary>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="postalAddress"></param>
		/// <param name="email"></param>
		/// <param name="phoneNo"></param>
		public Contact(string firstName, string lastName, Address postalAddress, string email = null, string phoneNo = null)
		{
			FirstName = firstName;
			LastName = lastName;
			PostalAddress = postalAddress;
			Email = email;
			PhoneNo = phoneNo;
		}
	}
}
