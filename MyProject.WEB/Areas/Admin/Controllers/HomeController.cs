using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Contants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Areas.Admin.Controllers
{
    [Authorize(Roles =RolesMessages.Admin)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
