using Microsoft.AspNetCore.Mvc;

namespace Logistica.WebUI.ViewComponents._AdminComponentPartial
{
    public class _AdminScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
