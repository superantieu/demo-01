using Microsoft.AspNetCore.Mvc;

namespace demo_web.Controllers
{
    public class SumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
