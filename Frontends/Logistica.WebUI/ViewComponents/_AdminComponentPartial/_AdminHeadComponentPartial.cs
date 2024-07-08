using Microsoft.AspNetCore.Mvc;

namespace Logistica.WebUI.ViewComponents._AdminComponentPartial
{
	public class _AdminHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
