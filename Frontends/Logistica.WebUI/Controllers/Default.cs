using Microsoft.AspNetCore.Mvc;

namespace Logistica.WebUI.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
