// Link tới model
using demo_web.Models;
using Microsoft.AspNetCore.Mvc;
using demo_web.Models;

namespace demo_web.Controllers
{
    public class SanPhamController : Controller
    {
        //Lấy từ class SanPham bên model
        public static List<SanPham> products = new List<SanPham>();
        public IActionResult Index(bool? check = false)
        {
            if ((bool)check)
            {
                products.Clear();
            }
            else
            {
                return View(products.ToList());
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(string tensanpham, int soluong, int dongia)
        {
            var homeProducts = new SanPham(tensanpham, soluong, dongia);
            products.Add(homeProducts);
            return View(products);
        }

        public IActionResult RemoveProduct(int position)
        {
            products.RemoveAt(position - 1);
            return RedirectToAction("Index", "SanPham");
        }
    }
}
