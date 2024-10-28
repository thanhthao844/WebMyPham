using Microsoft.AspNetCore.Mvc;

namespace WebMyPham_DOANPM.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}
