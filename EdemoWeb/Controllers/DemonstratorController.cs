using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EdemoWeb.Controllers
{
    public class DemonstratorController : Controller
    {
        private readonly ILogger<DemonstratorController> _logger;

        public DemonstratorController(ILogger<DemonstratorController> logger)
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