using hotel.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace hotel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Cart CartUse;
        private Login Loginty;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            CartUse = new Cart();
            Loginty = new Login();
        }

        public IActionResult Index()
        {
            CartUse.productName = "Biryani";
            CartUse.pType = productType.NoVeg;
            return View(CartUse);
        }

        public IActionResult Login()
        {
            Loginty.userName = "Admin";
            Loginty.password = "ABC";
            Loginty.lType = loginType.successfully;
            return View(Loginty);
        }

        public IActionResult Menu()
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
