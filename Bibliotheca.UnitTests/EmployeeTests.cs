using NUnit.Framework;
using System;

namespace Bibliotheca.UnitTests
{
	[TestFixture]
	public class EmployeeTests
	{
		private Employee _employee;

		[SetUp]
		public void SetUp()
		{
			Address address = new Address("Gold Avenue", 1, "Treasure Island", "00000");
			Contact contact = new Contact("John", "Silver", address, "john@pirate.com", "000000000");

			_employee = new Employee(contact, "Captain", "password", false);
		}

		[Test]
		public void ChangeUsername_EmployeeChangesHisUsername_NameIsChanged()
		{
			_employee.ChangeMyUsername("Emil");

			Assert.That(_employee.Username == "Emil");
		}

		[Test]
		public void VerifyPassword_CheckingOfCorrectPassword_ReturnTrue()
		{
			bool result = _employee.VerifyMyPassword("password");

			Assert.That(result, Is.True);
		}

		[Test]
		public void ChangeMyPassword_EmployeeChangingHisPasswordWithValidOldPassword_PasswordIsChanged()
		{
			_employee.ChangeMyPassword("password", "newpass");

			Assert.That(_employee.VerifyMyPassword("newpass"));
		}

		[Test]
		public void ChangeMyPassword_EmployeeChangingHisPasswordWithInvalidOldPassword_PasswordIsNotChanged()
		{
			Assert.That(() => _employee.ChangeMyPassword("InvalidOldPassword", "newPass"), Throws.Exception);
		}

	}
}
