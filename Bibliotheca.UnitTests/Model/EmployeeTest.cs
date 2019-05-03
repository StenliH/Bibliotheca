using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheca.UnitTests.Model
{
	[TestFixture]
	public class EmployeeTest
	{
		[Test]
		[TestCase("password", true)]
		[TestCase("wrongPassword", false)]
		public void VerifyPassword_WhenCalled_VerifyGivenPassword(string passToVerify, bool expectedResult)
		{
			var employee = new Employee(1, "John", "password");

			bool result = employee.VerifyPassword(passToVerify);

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[Test]
		public void PasswordChange_CorrectOldPassword_NewPasswordIsSet()
		{
			var employee = new Employee(1, "John", "password");

			employee.PasswordChange("password", "newPassword");
			bool result = employee.VerifyPassword("newPassword");

			Assert.That(result, Is.True);
		}

		[Test]
		public void PasswordChange_WrongOldPassword_PasswordNotChanged()
		{
			var employee = new Employee(1, "John", "password");

			employee.PasswordChange("wrongPassword", "newPassword");
			bool result = employee.VerifyPassword("password");

			Assert.That(result, Is.True);
		}

	}
}
