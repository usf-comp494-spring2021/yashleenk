/**
 * Author:           Yashleen Kheterpal
 * Date:             03/29/2021
 * Assignment:       Midterm
 * Course: COMP494:  C#
 * Purpose: To connect MVC project to the API
 *
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using KheterpalFinalAplication.Models;

namespace KheterpalFinalAplication.Controllers
{
    public class HomeController : Controller
    {
    private readonly ILogger<HomeController> _logger;

    private readonly IHttpClientFactory clientFactory;

    public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        clientFactory = httpClientFactory;
    }

        public IActionResult Index()
        {
            return View();
        }

    // Derived the code from docs.microsoft.com
    // Controller for Weather Forecast
    [HttpGet]
    [ProducesResponseType(200,
      Type = typeof(IEnumerable<WeatherForecast>))]
    public async Task<IActionResult> Weather()
    {
        string uri = "WeatherForecast";

        var client = clientFactory.CreateClient(name: "WeatherForecast");

        var request = new HttpRequestMessage(
        method: HttpMethod.Get, requestUri: uri);

        HttpResponseMessage response = await client.SendAsync(request);

        var model = await response.Content.ReadFromJsonAsync<WeatherForecast>();

        return View(model);
    }

    //Controller for Detailed Forecast
    [HttpGet]
    [ProducesResponseType(200,
       Type = typeof(IEnumerable<DetailedForecast>))]
    public async Task<IActionResult> Detailed()
    {
        string uri = "WeatherForecast/details";

        //ViewData["Title"] = $"Weather Forecast";
        //uri = $"http://csc494a-sp21-final.azurewebsites.net/WeatherForecast/details";

        var client = clientFactory.CreateClient(name: "WeatherForecast");

        var request = new HttpRequestMessage(
        method: HttpMethod.Get, requestUri: uri);

        HttpResponseMessage response = await client.SendAsync(request);

        var model = await response.Content.ReadFromJsonAsync<DetailedForecast>();


        return View(model);
    }

    //Controller for Hourly Forecast
    [HttpGet]
    [ProducesResponseType(200,
        Type = typeof(IEnumerable<HourlyForecast>))]
    public async Task<IActionResult> Hourly()
    {
        string uri = "WeatherForecast/hourly";

        //ViewData["Title"] = $"Hourly Forecast";
        //uri = $"http://csc494a-sp21-final.azurewebsites.net/WeatherForecast/hourly";

        var client = clientFactory.CreateClient(name: "WeatherForecast");

        var request = new HttpRequestMessage(
        method: HttpMethod.Get, requestUri: uri);

        HttpResponseMessage response = await client.SendAsync(request);

        var model = await response.Content.ReadFromJsonAsync<IEnumerable<HourlyForecast>>();

        return View(model);
    }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}
