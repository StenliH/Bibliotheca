using System.Collections.Generic;


namespace Bibliotheca
{
	public class Bibliotheca
	{
		public List<Employee> Employees { get; private set; }
		public List<Client> Clients { get; private set; }
		public List<Item> Items { get; private set; }
		public List<Admin> Admins { get; private set; }

		public Bibliotheca()
		{
			Employees = new List<Employee>();
			Clients = new List<Client>();
			Items = new List<Item>();
			Admins = new List<Admin>();
		}
	}
}
