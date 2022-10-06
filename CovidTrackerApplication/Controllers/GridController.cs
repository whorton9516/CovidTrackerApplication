using System;
﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using CovidTrackerApplication.Models;
using CovidTrackerApp.Controllers;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;

namespace CovidTrackerApplication.Controllers
{
	public partial class GridController : Controller
    {
        private readonly ILogger<GridController> _logger;
        public GridController() { }

        string Baseurl = "https://api.covidtracking.com/";
        public GridController(ILogger<GridController> logger)
        {
            _logger = logger;
        }

        public async Task<ActionResult> Data_Read()
        {

            List<DailyDataRow> data = new List<DailyDataRow>();

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
