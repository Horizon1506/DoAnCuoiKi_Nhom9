using DoAnCuoiKi_Nhom9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoAnCuoiKi_Nhom9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //SHOP
        public IActionResult Shop()
        {
            return View();
        }

        //WISHLIST
        public IActionResult Wishlist()
        {
            return View();
        }

		//Product_single
		public IActionResult Product_single()
		{
			return View();
		}

        //Cart
        public IActionResult Cart()
        {
            return View();
        }

		//Checkout
		public IActionResult Checkout()
		{
			return View();
		}

		//About
		public IActionResult About()
		{
			return View();
		}

        //Blog
        public IActionResult Blog()
        {
            return View();
        }

        //Blog single
        public IActionResult Blog_single()
        {
            return View();
        }

        //Contact
        public IActionResult Contact()
        {
            return View();
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