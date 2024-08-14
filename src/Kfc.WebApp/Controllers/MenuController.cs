using Microsoft.AspNetCore.Mvc;

namespace Kfc.WebApp.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
