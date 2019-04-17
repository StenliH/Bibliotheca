using System;

namespace Bibliotheca
{
	public class Borrow : Transaction
	{
		/// <summary>
		/// Item must be returned before this date.
		/// </summary>
		public DateTime Expiration { get; private set; }
	}
}
