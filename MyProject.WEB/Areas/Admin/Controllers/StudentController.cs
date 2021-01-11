using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Bussiness.Contants;
using MyProject.Entities.DTO.AppUserDTO;
using System.Collections.Generic;

namespace MyProject.WEB.Areas.Admin.Controllers
{
    [Authorize(Roles = RolesMessages.Admin)]
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly IAppUserService appUserService;
        private readonly IMapperService mapperService;

        public StudentController(IAppUserService appUserService, IMapperService mapperService)
        {
            this.mapperService = mapperService;
            this.appUserService = appUserService;
        }
        public IActionResult Index()
        {
            var dBuser = appUserService.GetList();
            var models = mapperService.Mapper.Map<List<UserGetDto>>(dBuser);
            return View(models);
        }
    }
}
