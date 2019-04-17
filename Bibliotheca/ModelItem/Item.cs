using System;
using System.Collections.Generic;

namespace Bibliotheca
{
	public abstract class Item
	{
		/// <summary>
		/// Unique identifier of the item.
		/// </summary>
		public int Id { get; private set; }
		/// <summary>
		/// Actual borrow of the item (null if not borrowed).
		/// </summary>
		public Borrow ItemBorrowed { get; private set; }
		/// <summary>
		/// List of active reservations made on the item.
		/// </summary>
		public ICollection<Reservation> ItemReservations { get; private set; }
		/// <summary>
		/// Date when item was added to the system.
		/// </summary>
		public DateTime AddedToBibliotheca { get; set; }
	}
}
