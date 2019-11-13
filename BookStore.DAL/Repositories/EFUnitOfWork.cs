using System;
using BookStore.DAL.EF;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Repositories
{
	public class EFUnitOfWork : IUnitOfWork
	{
		private readonly BookContext _context;
		private readonly Lazy<BookRepository> _bookRepository;
		private readonly Lazy<OrderRepository> _orderRepository;

		public EFUnitOfWork(DbContextOptions<BookContext> options)
		{
			_context = new BookContext(options);
			_bookRepository = new Lazy<BookRepository>(new BookRepository(_context));
			_orderRepository = new Lazy<OrderRepository>(new OrderRepository(_context));
		}

		public IRepository<Book> Books
		{
			get
			{
				if (_bookRepository.IsValueCreated)
				{
					return _bookRepository.Value;
				}
				else
				{
					return null;
				}
			}
		}

		public IRepository<Order> Orders
		{
			get
			{
				if (_orderRepository.IsValueCreated)
				{
					return _orderRepository.Value;
				}
				else
				{
					return null;
				}
			}
		}

		public void Save()
		{
			_context.SaveChanges();
		}

		private bool disposed = false;

		public virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}

				disposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
