using System;

namespace Bibliotheca
{
	public abstract class Transaction
	{
		/// <summary>
		/// Transaction identification number.
		/// </summary>
		public int Id { get; private set; }
		/// <summary>
		/// Client involved in the transaction.
		/// </summary>
		public Client Who { get; private set; }
		/// <summary>
		/// Item involved in the transaction.
		/// </summary>
		public Item What { get; private set; }
		/// <summary>
		/// Employee who created the transaction.
		/// </summary>
		public Employee MadeBy { get; private set; }
		/// <summary>
		/// Date and time when transaction happened.
		/// </summary>
		public DateTime TransactionDate { get; private set; }
		/// <summary>
		/// Date and time when transaction was finished and closed.
		/// </summary>
		public DateTime CloseDate { get; private set; }
	}
}
