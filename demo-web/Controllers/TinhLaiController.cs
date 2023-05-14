using Microsoft.AspNetCore.Mvc;

namespace demo_web.Controllers
{
    public class TinhLaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int songuyen1, int songuyen2, int songuyen3)
        {
            ViewData["SoNguyenA"] = songuyen1;
            ViewData["SoNguyenB"] = songuyen2;
            ViewData["SoNguyenC"] = songuyen3;
            double ketqua = (songuyen1 * songuyen2 / 100 * songuyen3 / 12);
            ViewData["KetQua1"] = ketqua.ToString("N0");
            ViewData["KetQua2"] = (songuyen1 + ketqua).ToString("N0");
            return View();
        }
    }
}
