using Microsoft.AspNetCore.Mvc;

namespace Logistica.WebUI.ViewComponents
{
    public class _FactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
