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

        public GridController(ILogger<GridController> logger)
        {
            _logger = logger;
        }

        
    }
}
