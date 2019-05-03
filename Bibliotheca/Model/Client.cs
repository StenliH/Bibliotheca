using System.Collections.Generic;


namespace Bibliotheca
{
	public class Client
	{
		public string CardNo { get; private set; }
		public List<Borrow> Borrows { get; private set; }
		public List<Reservation> Reservations { get; private set; }

		public Client(string cardNo)
		{
			this.CardNo = cardNo;
			Borrows = new List<Borrow>();
			Reservations = new List<Reservation>();
		}
	}
}
