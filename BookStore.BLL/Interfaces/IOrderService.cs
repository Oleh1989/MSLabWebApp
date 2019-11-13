using BookStore.BLL.DTO;
using System.Collections.Generic;

namespace BookStore.BLL.Interfaces
{
	public interface IOrderService
	{
		void MakeOrder(OrderDTO orderDTO);

		BookDTO GetBook(int? id);
		IEnumerable<BookDTO> GetBooks();

		void Dispose();
	}
}
