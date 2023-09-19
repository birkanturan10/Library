using Microsoft.AspNetCore.Mvc;
using Library.DataLayer;

namespace Library.UI.Controllers
{
    public class HomeController : Controller
    {
        Context context = new Context();

        public IActionResult Index()
        {
            return View(context.BookLists);
        }
    }
}
