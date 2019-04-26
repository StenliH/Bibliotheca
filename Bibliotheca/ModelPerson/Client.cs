using System.Collections.Generic;

namespace Bibliotheca
{
	public class Client : User
	{
		/// <summary>
		/// Unique identification number of client card.
		/// </summary>
		public string CardNo { get; private set; }
		private const int _CardNoLength = 6;
		/// <summary>
		/// List of all actual reservations of the client.
		/// </summary>
		public ICollection<Reservation> ClientReservations { get; set; }
		/// <summary>
		/// List of all actual borrows of the client.
		/// </summary>
		public ICollection<Borrow> ClientBorrows { get; set; }

		public Client(Contact contactInfo, string cardNo)
			:base(contactInfo)
		{
			if (cardNo.Length == 6)
				CardNo = cardNo;

			ClientReservations = new HashSet<Reservation>();
			ClientBorrows = new HashSet<Borrow>();
		}

		public void SetCardNo(string newCardNo)
		{
			if (newCardNo.Length == _CardNoLength)
				CardNo = newCardNo;
		}
	}
}
