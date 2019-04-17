using System;

namespace Bibliotheca
{
	public class Audio : Item
	{
		/// <summary>
		/// Title
		/// </summary>
		public string Title { get; private set; }
		/// <summary>
		/// Artist
		/// </summary>
		public string Artist { get; private set; }
		/// <summary>
		/// Total time
		/// </summary>
		public TimeSpan TotalTime { get; set; }
	}
}
