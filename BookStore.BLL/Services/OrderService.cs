using System;
using System.Collections.Generic;
using BookStore.DAL.Entities;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Infratructure;
using BookStore.BLL.BusinessModels;
using BookStore.DAL.Interfaces;
using BookStore.BLL.DTO;
using AutoMapper;

namespace BookStore.BLL.Services
{
	public class OrderService : IOrderService
	{
		private IUnitOfWork Database { get; set; }

		public OrderService(IUnitOfWork uow)
		{
			Database = uow;
		}

		public void MakeOrder(OrderDTO orderDTO)
		{
			var book = Database.Books.Get(orderDTO.BookId);

			if (book == null)
			{
				throw new ValidationException("Book cannot be found", "");
			}

			decimal sum = new Discount(0.1m).GetDiscountedPrice(book.Price);

			var order = new Order
			{
				OrderDate = DateTime.Now,
				Address = orderDTO.Address,
				BookId = book.Id,
				PhoneNumber = orderDTO.PhoneNumber
			};

			Database.Orders.Create(order);
			Database.Save();
		}

		public IEnumerable<BookDTO> GetBooks()
		{
			var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookDTO>()).CreateMapper();
			return mapper.Map<IEnumerable<Book>, List<BookDTO>>(Database.Books.GetAll());
		}

		public BookDTO GetBook(int? id)
		{
			if (id == null)
			{
				throw new ValidationException("Id of book cannot be investigated", "");
			}

			var book = Database.Books.Get(id.Value);
			if (book == null)
			{
				throw new ValidationException("Book not found", "");
			}

			return new BookDTO
			{
				Name = book.Name,
				Author = book.Author,
				Description = book.Description,
				Price = book.Price
			};
		}

		public void Dispose()
		{
			Database.Dispose();
		}
	}
}
