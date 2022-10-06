using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CovidTrackerApplication.Models;
using Newtonsoft.Json;
using System.Net;
using System.Data;
using System.EnterpriseServices;
using System.Web.Mvc;
using System.Web;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using Kendo.Mvc.UI;
using CovidTrackerApplication.Controllers;

namespace CovidTrackerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<GridController> _logger;
        public HomeController() { }

        string Baseurl = "https://api.covidtracking.com/";
        public HomeController(ILogger<GridController> logger)
        {
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            IEnumerable<DailyDataRow> data = new List<DailyDataRow>();

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(Baseurl);

                httpClient.DefaultRequestHeaders.Clear();

                //Define request data format  
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  

                HttpResponseMessage Res = await httpClient.GetAsync("v1/states/daily.json");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var dataResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    data = JsonConvert.DeserializeObject<List<DailyDataRow>>(dataResponse);
                }

                //returning the employee list to view  
                return View(data);
            }
        }

    }
}