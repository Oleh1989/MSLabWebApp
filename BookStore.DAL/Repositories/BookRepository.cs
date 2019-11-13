using System;
using System.Collections.Generic;
using BookStore.DAL.EF;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Repositories
{
	public class BookRepository : IRepository<Book>
	{
		private readonly BookContext _context;

		public BookRepository(BookContext context)
		{
			_context = context;
		}

		public IReadOnlyCollection<Book> GetAll()
		{
			return _context.Books.ToList();
		}

		public Book Get(int id)
		{
			return _context.Books.Find(id);
		}

		public IReadOnlyCollection<Book> Find(Func<Book, bool> predicate)
		{
			return _context.Books.Where(predicate).ToList();
		}

		public void Create(Book book)
		{
			_context.Books.Add(book);
		}

		public void Update(Book book)
		{
			_context.Entry(book).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			Book book = Get(id);
			if (book != null)
			{
				_context.Books.Remove(book);
			}
		}
	}
}
