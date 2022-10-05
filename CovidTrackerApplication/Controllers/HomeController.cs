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
using Microsoft.AspNetCore.Mvc;
using Kendo.Mvc.UI;

namespace CovidTrackerApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}