using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyProject.Bussiness.Abstract;
using MyProject.Entities.DTO.UniversityDTO;
using MyProject.Entities.DTO.UniversityTypeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Controllers
{
    public class UniversitiesController : Controller
    {
        private readonly IUniversityService universityService;
        private readonly IMapperService mapperService;
        private readonly ICityService cityService;
        private readonly IUniversityTypeService universityTypeService;

        public UniversitiesController(ICityService cityService, IUniversityService universityService, IMapperService mapperService, IUniversityTypeService universityTypeService)
        {
            this.mapperService = mapperService;
            this.universityService = universityService;
            this.cityService = cityService;
            this.universityTypeService = universityTypeService;
        }

        public IActionResult Index()
        {
            var cities = cityService.GetOrderedNameCities();
            ViewBag.Cities = new SelectList(cities, "Id", "Name");

            var type = mapperService.Mapper.Map<List<UniversityTypeGetDto>>(universityTypeService.GetList());
            ViewBag.Type = type;

            return View();
        }

        public IActionResult Partial_Universities(int typeValue, int cityValue)
        {
            var dBTypes = universityService.GetUniversityWithQuery(typeValue, cityValue);
            var types = mapperService.Mapper.Map<List<UniversityGetDto>>(dBTypes);
            return PartialView("_PartialUniversities", types);
        }

    }
}
