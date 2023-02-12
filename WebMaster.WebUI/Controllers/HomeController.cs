using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMaster.WebUI.Models;
using WebMaster.Bll;


namespace WebMaster.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductManager productManager = new ProductManager();
        public HomeController(ILogger<HomeController> logger)
        {
             _logger = logger;
        }

        public IActionResult Index()
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