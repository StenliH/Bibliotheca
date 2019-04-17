namespace Bibliotheca
{
	public class Employee : Person
	{
		/// <summary>
		/// Username of the person.
		/// </summary>
		public string Username { get; private set; }
		/// <summary>
		/// Password for login.
		/// </summary>
		private string password;
		/// <summary>
		/// States whether employee has admin rights.
		/// </summary>
		public bool IsAdmin { get; private set; }
	}
}
