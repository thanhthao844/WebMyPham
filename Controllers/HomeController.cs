using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMyPham_DOANPM.Models;
using WebMyPham_DOANPM.Repository;
using Microsoft.EntityFrameworkCore;


namespace WebMyPham_DOANPM.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _dataContext = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _dataContext.Products.Include(p => p.ProductVariant).ToListAsync();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}