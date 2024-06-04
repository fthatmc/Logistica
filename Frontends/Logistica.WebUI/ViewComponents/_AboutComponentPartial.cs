﻿using Logistica.Dto.AboutUsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Logistica.WebUI.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7184/api/AboutUs/1");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<AboutUsDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
