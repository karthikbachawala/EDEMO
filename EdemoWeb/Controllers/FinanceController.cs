using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EdemoWeb.Controllers
{

    public class FinanceController : Controller
    {
        private readonly ILogger<FinanceController> _logger;

        public FinanceController(ILogger<FinanceController> logger)
        {
            _logger = logger;
        }

        public IActionResult SearchInvoice()
        {
            return View();
        }

        public IActionResult CreateInvoice()
        {
            return View();
        }

        public IActionResult LogSearch()
        {
            return View();
        }


    }
}