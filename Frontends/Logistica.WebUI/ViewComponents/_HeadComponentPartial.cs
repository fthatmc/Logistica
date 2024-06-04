using Microsoft.AspNetCore.Mvc;

namespace Logistica.WebUI.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
