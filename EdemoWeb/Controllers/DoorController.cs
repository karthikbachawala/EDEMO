using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EdemoWeb.Controllers
{

    public class DoorController : Controller
    {
        private readonly ILogger<DoorController> _logger;

        public DoorController(ILogger<DoorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Search()
        {
            return View();
        }

    }
}