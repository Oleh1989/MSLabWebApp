using System;
using System.Collections.Generic;

namespace BookStore.DAL.Interfaces
{
	public interface IRepository<T> where T : class
	{
		IReadOnlyCollection<T> GetAll();

		T Get(int id);

		IReadOnlyCollection<T> Find(Func<T, bool> predicate);

		void Create(T item);

		void Update(T item);

		void Delete(int id);
	}
}
