using demo_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_web.Controllers
{
    public class LaiKepController : Controller
    {
        public IActionResult Index()
        {
            //Gọi class rỗng
            LaiKep lk = new LaiKep();
            //Nhớ return về View
            return View(lk);
        }
        //Gọi class, nhớ HttpPost
        //Biến bên Controler phải lấy đúng name bên Index 

        [HttpPost]
        public IActionResult Index(double tiengui, double laisuatgui, double kyhan, double soLanDong)
        {
            LaiKep lk = new LaiKep(tiengui, laisuatgui, kyhan, soLanDong);
            return View(lk);
        }
        //{
        //    ViewData["SoNguyenA"] = songuyen1;
        //    ViewData["SoNguyenB"] = songuyen2;
        //    ViewData["SoNguyenC"] = songuyen3;
        //    double ketqua = (songuyen1 * songuyen2 / 100 * songuyen3 / 12);
        //    ViewData["KetQua1"] = ketqua.ToString("N0");
        //    ViewData["KetQua2"] = (songuyen1 + ketqua).ToString("N0");
        //    return View();
        //}


    }
}
