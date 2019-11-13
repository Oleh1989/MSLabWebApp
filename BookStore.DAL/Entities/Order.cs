using System;

namespace BookStore.DAL.Entities
{
	public class Order
	{
		public int Id { get; set; }

		public string PhoneNumber { get; set; }

		public string Address { get; set; }

		public DateTime OrderDate { get; set; }

		public int BookId { get; set; }

		public Book Book { get; set; }
	}
}
