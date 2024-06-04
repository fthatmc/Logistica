using Microsoft.AspNetCore.Mvc;

namespace Logistica.WebUI.ViewComponents
{
    public class _ServiceComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
