using Microsoft.AspNetCore.Mvc;

namespace WebMyPham_DOANPM.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
