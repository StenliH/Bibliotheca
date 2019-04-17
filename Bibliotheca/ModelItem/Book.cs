namespace Bibliotheca
{
	public class Book : Item
	{
		/// <summary>
		/// Title of the book
		/// </summary>
		public string Title { get; private set; }
		/// <summary>
		/// Name of the author
		/// </summary>
		public string Author { get; private set; }
		/// <summary>
		/// International Standard Book Number
		/// </summary>
		public string Isbn { get; private set; }
		/// <summary>
		/// Number of pages
		/// </summary>
		public int NumberOfPages { get; private set; }
	}
}
