using System;


namespace Bibliotheca
{

	public class Employee
	{
		public int Id { get; }
		public string Name { get; private set; }
		private string _password;

		public Employee(int id, string name, string password)
		{
			Id = id;
			Name = name;
			_password = password;
		}

		public bool VerifyPassword(string passToVerify)
		{
			return Authentication.VerifyPassword(_password, passToVerify);
		}

		public void PasswordChange(string passToVerify, string newPass)
		{
			if (Authentication.VerifyPassword(_password, passToVerify))
				_password = newPass;
		}
	}
}
