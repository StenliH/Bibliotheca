using System;


namespace Bibliotheca
{
	public class Admin
	{
		public string Name { get; private set; }
		private string _password;

		public bool VerifyPassword(string passToVerify)
		{
			throw new NotImplementedException();
		}

		private void PasswordChange(string currentPass, string newPass)
		{
			throw new NotImplementedException();
		}
	}
}
