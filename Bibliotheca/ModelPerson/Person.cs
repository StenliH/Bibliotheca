namespace Bibliotheca
{
	public abstract class Person
	{
		/// <summary>
		/// Unique system identification number of each person.
		/// </summary>
		public int Id { get; private set; }
		/// <summary>
		/// Contact information.
		/// </summary>
		public Contact ContactInfo { get; private set; }
	}
}
