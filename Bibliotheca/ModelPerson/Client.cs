using System.Collections.Generic;

namespace Bibliotheca
{
	public class Client : Person
	{
		/// <summary>
		/// Unique identification number of client card.
		/// </summary>
		public string CardNo { get; private set; }
		/// <summary>
		/// List of all actual reservations of the client.
		/// </summary>
		public ICollection<Reservation> ClientReservations { get; private set; }
		/// <summary>
		/// List of all actual borrows of the client.
		/// </summary>
		public ICollection<Borrow> ClientBorrows { get; private set; }
	}
}
