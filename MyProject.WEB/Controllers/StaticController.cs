using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Controllers
{
    public class StaticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WhatYos()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult YosRequirements()
        {
            return View();
        }
        public IActionResult YosExamSubjects()
        {
            return View();
        }
        public IActionResult Yos()
        {
            return View();
        }
    }
}
