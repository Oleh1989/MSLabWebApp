using BookStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.EF
{
	public class BookContext : DbContext
	{
		public DbSet<Book> Books { get; set; }
		public DbSet<Order> Orders { get; set; }

		public BookContext(DbContextOptions<BookContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
	}
}
