using Microsoft.AspNetCore.Mvc;

namespace WebMaster.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
