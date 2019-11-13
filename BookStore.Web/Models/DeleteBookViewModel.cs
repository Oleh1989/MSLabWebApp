﻿namespace BookStore.Web.Models
{
	public class DeleteBookViewModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Author { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }
	}
}
