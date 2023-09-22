using Microsoft.AspNetCore.Mvc;
using Library.DataLayer;
using Library.TypeLayer;

namespace Library.UI.Controllers
{
	public class HomeController : Controller
	{
		Context context = new Context();

		public IActionResult Index()
		{
			return View(context.BookLists);
		}

		public IActionResult AddBook()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddBook([Bind("BookName,Author,NumberOfPages,PublicationDate,Publisher")] BookList bookList)
		{
			if (ModelState.IsValid)
			{
				context.Add(bookList);
				context.SaveChanges();
			}
			return View(bookList);
		}
	}
}
