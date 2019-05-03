using System.Collections.Generic;


namespace Bibliotheca
{
	public class Item
	{
		public string Name { get; private set; }
		public Borrow ActiveBorrow { get; private set; }
		public List<Reservation> Reservations { get; private set; }

		public Item(string name)
		{
			Name = name;
			ActiveBorrow = null;
			Reservations = new List<Reservation>();
		}
	}
}
