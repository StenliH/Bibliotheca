using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bibliotheca
{
	public class BibliothecaContext : DbContext
	{
		public BibliothecaContext(): base()
		{

		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<Borrow> Borrows { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
