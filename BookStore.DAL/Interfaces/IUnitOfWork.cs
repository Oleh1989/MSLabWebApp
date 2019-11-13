using System;
using BookStore.DAL.Entities;

namespace BookStore.DAL.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<Book> Books { get; }
		IRepository<Order> Orders { get; }

		void Save();
	}
}
