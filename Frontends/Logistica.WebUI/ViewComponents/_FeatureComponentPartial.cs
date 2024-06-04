using Microsoft.AspNetCore.Mvc;

namespace Logistica.WebUI.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
