using Microsoft.AspNetCore.Mvc;

namespace Kfc.WebApp.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Promotions()
        {
            return View();
        }

        public IActionResult NewItems()
        {
            return View();
        }

        public IActionResult SingleCombo()
        {
            return View();
        }

        public IActionResult GroupCombo()
        {
            return View();
        }

        public IActionResult Chicken()
        {
            return View();
        }

        public IActionResult MainCourse()
        {
            return View();
        }

        public IActionResult Snacks()
        {
            return View();
        }

        public IActionResult Beverages()
        {
            return View();
        }
    }
}
