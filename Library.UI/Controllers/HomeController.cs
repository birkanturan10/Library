using Microsoft.AspNetCore.Mvc;
using Library.DataLayer;
using Library.TypeLayer;
using Microsoft.EntityFrameworkCore;

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
				return RedirectToAction(nameof(Index));
			}
			return View(bookList);
		}

		public IActionResult Update(int? ID)
		{
			if (ID==null||context.BookLists==null)
			{
				return NotFound();
			}

			var bookList = context.BookLists.Find(ID);

			if (bookList==null) 
			{
				return NotFound();
			}

			return View(bookList);
		}

		[HttpPost]
		public IActionResult Update(int ID, [Bind("BookID,BookName,Author,NumberOfPages,PublicationDate,Publisher")]BookList bookList)
		{
			if (ID!=bookList.BookID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					context.Update(bookList);
					context.SaveChanges();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!BookListExists(bookList.BookID))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(bookList);
		}

		private bool BookListExists(int ID)
		{
			return context.BookLists.Any(x => x.BookID == ID);
		}

		public IActionResult Delete(int? ID)
		{
			if (ID == null || context.BookLists == null)
			{
				return NotFound();
			}

			var bookList = context.BookLists.FirstOrDefault(x => x.BookID == ID);

			if (bookList == null)
			{
				return NotFound();
			}

			return View(bookList);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int ID)
		{
			if (context.BookLists == null)
			{
				return Problem("Entity set 'context.Students'  is null.");
			}

			var bookList = context.BookLists.Find(ID);

			if (bookList != null)
			{
				context.BookLists.Remove(bookList);
			}

			context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}
	}
}
