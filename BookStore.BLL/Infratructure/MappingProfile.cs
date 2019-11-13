using AutoMapper;
using BookStore.BLL.DTO;
using BookStore.DAL.Entities;

namespace BookStore.BLL.Infratructure
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<BookDTO, Book>();
			CreateMap<OrderDTO, Order>();
		}
	}
}
