using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookStore.Web.Models;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Infratructure;
using BookStore.BLL.DTO;
using AutoMapper;
using BookStore.DAL.Interfaces;
using BookStore.DAL.Entities;
using System.Linq;
using System.Diagnostics.Contracts;

namespace BookStore.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IOrderService _orderService;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public HomeController(ILogger<HomeController> logger,
			IOrderService orderService,
			IUnitOfWork unitOfWork,
			IMapper mapper)
		{
			_logger = logger;
			_orderService = orderService;
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			IEnumerable<BookDTO> bookDtos = _orderService.GetBooks();
			var books = _mapper.Map<IEnumerable<BookDTO>, List<BookViewModel>>(bookDtos);

			return View(books);
		}

		public IActionResult AddBook()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddBook(CreateBookViewModel book)
		{
			Contract.Requires<Exception>(book.Price > 0, "Invalid book price");

			var bookToAdd = _mapper.Map<Book>(_mapper.Map<BookDTO>(book));

			_unitOfWork.Books.Create(bookToAdd);
			_unitOfWork.Save();

			return RedirectToAction(nameof(HomeController.Index));
		}

		[HttpGet]
		public IActionResult EditBook(int id)
		{
			var bookToUpdate = _mapper.Map<BookViewModel>(_unitOfWork.Books.Get(id));
			if (bookToUpdate == null)
			{
				return RedirectToAction(nameof(HomeController.Error));
			}

			return View(bookToUpdate);
		}

		[HttpPost]
		public IActionResult EditBook(BookViewModel book)
		{
			var bookToUpdate = _mapper.Map<Book>(_mapper.Map<BookDTO>(book));
			_unitOfWork.Books.Update(bookToUpdate);
			_unitOfWork.Save();

			return RedirectToAction(nameof(HomeController.Index));
		}

		[HttpGet]
		public IActionResult DeleteBook(int id)
		{
			var bookToDelete = _mapper.Map<DeleteBookViewModel>(_unitOfWork.Books.Get(id));
			if (bookToDelete == null)
			{
				return RedirectToAction(nameof(HomeController.Error));
			}

			return View(bookToDelete);
		}

		[HttpPost]
		public IActionResult DeleteBookConfirmed(int id)
		{
			var bookToDelete = _mapper.Map<Book>(_unitOfWork.Books.Get(id));
			_unitOfWork.Books.Delete(bookToDelete.Id);
			_unitOfWork.Save();

			return RedirectToAction(nameof(HomeController.Index));
		}

		public ActionResult MakeOrder(int? id)
		{
			try
			{
				BookDTO book = _orderService.GetBook(id);
				var order = new OrderViewModel { BookId = book.Id };

				return View(order);
			}
			catch (ValidationException ex)
			{
				return Content(ex.Message);
			}
		}

		[HttpPost]
		public ActionResult MakeOrder(OrderViewModel order)
		{
			try
			{
				var orderDto = new OrderDTO
				{
					BookId = order.BookId,
					Address = order.Address,
					PhoneNumber = order.PhoneNumber,
					OrderDate = DateTime.Now
				};
			}
			catch (ValidationException ex)
			{
				ModelState.AddModelError(ex.Property, ex.Message);
			}

			return View(order);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		protected override void Dispose(bool disposing)
		{
			_orderService.Dispose();
			base.Dispose(disposing);
		}
	}
}
