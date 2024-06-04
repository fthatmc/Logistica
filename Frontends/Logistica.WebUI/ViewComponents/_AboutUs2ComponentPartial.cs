using Logistica.Dto.AboutUsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Logistica.WebUI.ViewComponents
{
    public class _AboutUs2ComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUs2ComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7184/api/AboutUs2");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AboutUs2Dto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
