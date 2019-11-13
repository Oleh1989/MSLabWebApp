using System.Linq;
using BookStore.DAL.Entities;

namespace BookStore.DAL.EF
{
	public static class InitialData
	{
		public static void Initialize(BookContext context)
		{
			if (!context.Books.Any())
			{
				context.Books.AddRange(
					new Book
					{
						Name = "First Book",
						Author = "First Author",
						Description = "First Description",
						Price = 10
					},
					new Book
					{
						Name = "Second Book",
						Author = "Second Author",
						Description = "Second Description",
						Price = 15
					},
					new Book
					{
						Name = "Third book",
						Author = "Third Author",
						Description = "Third Description",
						Price = 20
					}
				);

				context.SaveChanges();
			}
		}
	}
}
