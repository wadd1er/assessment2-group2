﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using assessment2_group2.Models;

namespace assessment2_group2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Blog()
        {
            ViewData["Message"] = "Your Blog page.";

            return View();
        }

        public IActionResult Profile()
        {
            ViewData["Message"] = "Your Profile page.";

            return View();
        }

        public IActionResult Portfolio()
        {
            ViewData["Message"] = "Your Portfolio page.";

            return View();
        }

        public IActionResult Media()
        {
            ViewData["Message"] = "Your Media page.";

            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
