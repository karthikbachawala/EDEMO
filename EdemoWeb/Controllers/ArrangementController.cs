using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EdemoWeb.Controllers
{

    public class ArrangementController : Controller
    {
        private readonly ILogger<ArrangementController> _logger;

        public ArrangementController(ILogger<ArrangementController> logger)
        {
            _logger = logger;
        }

        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }


    }
}