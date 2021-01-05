using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Bussiness.Contants;
using MyProject.WEB.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Areas.Admin.Controllers
{
    [Authorize(Roles =RolesMessages.Admin)]
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IUniversityService universityService;
        private readonly IAppUserService appUserService;

        public HomeController(IUniversityService universityService, IAppUserService appUserService)
        {
            this.universityService = universityService;
            this.appUserService = appUserService;
        }


        public IActionResult Index()
        {
            var model = new HomeInfo();
            model.StudentsCount = appUserService.UserCount();
            model.UniversitiesCount = universityService.GetList().Count();
            return View(model);
        }
    }
}
