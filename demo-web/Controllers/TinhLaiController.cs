using demo_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_web.Controllers
{
    public class TinhLaiController : Controller
    {
        public IActionResult Index()
        {
            //Gọi class rỗng
            LaiSuat ls = new LaiSuat();
            //Nhớ return về View
            return View(ls);
        }
        //Gọi class, nhớ HttpPost
        //Biến bên Controler phải lấy đúng name bên Index 

        [HttpPost]
        public IActionResult Index(int tiengui, int laisuatgui, int kyhan)
        {
            LaiSuat ls = new LaiSuat(tiengui, laisuatgui, kyhan); 
            return View(ls);
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

    
}}
