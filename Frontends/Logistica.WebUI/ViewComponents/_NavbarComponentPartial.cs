using Microsoft.AspNetCore.Mvc;

namespace Logistica.WebUI.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
