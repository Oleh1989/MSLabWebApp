using System;

namespace BookStore.BLL.DTO
{
	public class OrderDTO
	{
		public int Id { get; set; }

		public string PhoneNumber { get; set; }

		public string Address { get; set; }

		public int BookId { get; set; }

		public DateTime? OrderDate { get; set; }
	}
}
