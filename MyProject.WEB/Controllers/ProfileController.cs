
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyProject.Bussiness.Abstract;
using MyProject.Entities.DTO.UniversityDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Controllers

{
    public class ProfileController : Controller
    {
        private readonly IUniversityService universityService;
        private readonly IMapperService mapperService;
        private readonly ICityService cityService;
        private readonly IUniversityTypeService universityTypeService;

        public ProfileController(ICityService cityService, IUniversityService universityService, IMapperService mapperService, IUniversityTypeService universityTypeService)
        {
            this.mapperService = mapperService;
            this.universityService = universityService;
            this.cityService = cityService;
            this.universityTypeService = universityTypeService;
        }

        public IActionResult Index()
        {
            var cities = cityService.GetList();
            ViewBag.Cities = new SelectList(cities, "Id", "Name");

            var type = universityTypeService.GetList();
            ViewBag.Type = new SelectList(type, "Id", "Name");

            var dBTypes = universityService.GetUniversityWithCityAndType();
            var types = mapperService.Mapper.Map<List<UniversityGetDto>>(dBTypes);
            return View(types);
        }
    }
}

