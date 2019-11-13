using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.DAL.EF;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Repositories
{
	public class OrderRepository : IRepository<Order>
	{
		private readonly BookContext _context;

		public OrderRepository(BookContext context)
		{
			_context = context;
		}

		public IReadOnlyCollection<Order> GetAll()
		{
			return _context.Orders.ToList();
		}

		public Order Get(int id)
		{
			return _context.Orders.Find(id);
		}

		public IReadOnlyCollection<Order> Find(Func<Order, bool> predicate)
		{
			return _context.Orders.Where(predicate).ToList();
		}


		public void Create(Order order)
		{
			_context.Orders.Add(order);
		}

		public void Update(Order order)
		{
			_context.Entry(order).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			var order = Get(id);
			if (order != null)
				_context.Orders.Remove(order);
		}
	}
}
