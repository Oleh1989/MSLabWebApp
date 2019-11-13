using BookStore.DAL.EF;
using BookStore.DAL.Interfaces;
using BookStore.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Ninject.Modules;

namespace BookStore.BLL.Infratructure
{
	public class ServiceModule : NinjectModule
	{
		private readonly DbContextOptions<BookContext> _options;

		public ServiceModule(DbContextOptions<BookContext> options)
		{
			_options = options;
		}

		public override void Load()
		{
			Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(_options);
		}
	}
}
