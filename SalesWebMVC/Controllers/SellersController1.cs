using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC.Controllers
{
    public class SellersController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
