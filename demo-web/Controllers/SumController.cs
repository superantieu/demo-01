using Microsoft.AspNetCore.Mvc;

namespace demo_web.Controllers
{
    public class SumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int songuyen1, int songuyen2)
        {
            ViewData["SoNguyenA"] = songuyen1;
                ViewData["SoNguyenB"] = songuyen2;
            ViewData["KetQua"] = songuyen1 + songuyen2;
            return View();
        }
    }
}
