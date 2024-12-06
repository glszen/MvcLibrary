using Microsoft.AspNetCore.Mvc;

namespace MvcLibrary.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
