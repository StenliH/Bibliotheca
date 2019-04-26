using NUnit.Framework;

namespace Bibliotheca.UnitTests
{
	[TestFixture]
	public class ClientTests
	{
		private Client _client;

		[SetUp]
		public void SetUp()
		{
			Address address = new Address("Gold Avenue", 1, "Treasure Island", "00000");
			Contact contact = new Contact("John", "Silver", address, "john@pirate.com", "000000000");

			_client = new Client(contact, "123456");
		}

		[Test]
		public void SetCardNo_WhenGivenValidCardNo_SetNewCardNo()
		{
			Address address = new Address("Gold Avenue", 1, "Treasure Island", "00000");
			Contact contact = new Contact("John", "Silver", address, "john@pirate.com", "000000000");

			_client = new Client(contact, "123456");

			_client.SetCardNo("111111");

			Assert.That(_client.CardNo, Is.EqualTo("111111"));
		}

		[Test]
		public void SetCardNo_WhenGivenInvalidCardNo_KeepOldCardNo()
		{
			string oldCardNo = _client.CardNo;

			_client.SetCardNo("");

			Assert.That(_client.CardNo, Is.EqualTo(oldCardNo));
		}


	}
}
