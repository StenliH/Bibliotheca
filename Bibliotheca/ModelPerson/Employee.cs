using System;

namespace Bibliotheca
{
	public class Employee : User
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

		public Employee(Contact contactInfo, string username, string password, bool isAdmin)
			:base (contactInfo)
		{
			Username = username;
			this.password = password;
			IsAdmin = isAdmin;
		}

		public void ChangeMyUsername(string newUsername)
		{
			Username = newUsername;
		}

		public bool VerifyMyPassword(string passwordToVerify)
		{
			return (password == passwordToVerify);
		}

		public void ChangeMyPassword(string oldPassword, string newPassword)
		{
			if (oldPassword == password)
				password = newPassword;
			else
				throw new UnauthorizedAccessException("Wrong password.");
		}

	}
}
