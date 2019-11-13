using AutoMapper;
using BookStore.Web.Models;
using BookStore.BLL.DTO;
using BookStore.DAL.Entities;

namespace BookStore.Web.Util
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateBookViewModel, BookDTO>();
			CreateMap<BookViewModel, BookDTO>();
			CreateMap<DeleteBookViewModel, BookDTO>();
			
			CreateMap<Book, DeleteBookViewModel>();
			CreateMap<BookDTO, BookViewModel>();
			CreateMap<Book, BookViewModel>();

		}
	}
}
