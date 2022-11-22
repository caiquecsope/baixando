using Microsoft.AspNetCore.Mvc;

namespace EMPRESA
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
