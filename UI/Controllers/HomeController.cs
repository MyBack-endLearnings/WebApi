using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _factory;

        public HomeController(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient httpClient = _factory.CreateClient();

            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            Uri uri = new Uri("https://localhost:44310/api/product");

            try
            {
                HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    ViewBag.Message = "Success";
                }
                else
                {
                    ViewBag.Message = "Failed";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
