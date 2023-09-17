using Microsoft.AspNetCore.Mvc;

namespace Library.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
