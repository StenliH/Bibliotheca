using System;


namespace Bibliotheca
{
	public class Reservation
	{
		public DateTime ReservedFrom { get; }
		public DateTime ReservedUntil { get; private set; }
		public Client Who { get; }
		public Item What { get; }
		public bool IsActive { get; private set; }

		public Reservation(DateTime reservedFrom, DateTime reservedUntil, Client who, Item what)
		{
			ReservedFrom = reservedFrom;
			ReservedUntil = reservedUntil;
			Who = who;
			What = what;
			IsActive = true;
		}

	}
}
