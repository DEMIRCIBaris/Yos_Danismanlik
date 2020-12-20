using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Areas.Admin.Controllers
{
    public class YosQuestions : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
