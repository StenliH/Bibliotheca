using System;

namespace Bibliotheca
{
	public class Reservation : Transaction
	{
		/// <summary>
		/// Reservation exists until this date.
		/// </summary>
		public DateTime KeepUntil { get; set; }
	}
}
