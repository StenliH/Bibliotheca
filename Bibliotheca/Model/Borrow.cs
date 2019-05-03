using System;


namespace Bibliotheca
{
	public class Borrow
	{
		public DateTime FromDate { get; }
		public DateTime ReturnDate { get; private set; }
		public Client ToWhom { get; }
		public Item What { get; }
		public bool IsActive { get; private set; }

		public Borrow(DateTime fromDate, DateTime returnDate, Client toWhom, Item what)
		{
			FromDate = fromDate;
			ReturnDate = returnDate;
			ToWhom = toWhom;
			What = what;
			IsActive = true;
		}
	}
}
