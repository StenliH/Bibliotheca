using System;

namespace Bibliotheca
{
	public abstract class User
	{
		/// <summary>
		/// Unique system identification number of each person.
		/// </summary>
		public int Id { get; private set; }
		/// <summary>
		/// Contact information.
		/// </summary>
		public Contact ContactInfo { get; }

		protected User(Contact contactInfo)
		{
			// TODO - how it works with Id - Entity Framework will simply manage?
			ContactInfo = contactInfo;
		}

		/// <summary>
		/// Method for changing the user contact info.
		/// </summary>
		public void SetContactInfo()
		{
			throw new NotImplementedException();
		}
	}
}
