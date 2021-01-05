using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Entities.Concrete;
using MyProject.Entities.DTO.UniversityDTO;
using MyProject.Entities.DTO.UniversityTypeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Areas.Admin.Controllers
{
    [AutoValidateAntiforgeryToken]
    [Area("Admin")]
    public class UniversityTypesController : Controller
    {
        private readonly IUniversityTypeService universityTypeService;
        private readonly IMapperService mapperService;

        public UniversityTypesController(IUniversityTypeService universityTypeService, IMapperService mapperService)
        {
            this.universityTypeService = universityTypeService;
            this.mapperService = mapperService;
        }
        public IActionResult Index()
        {
            var dBTypes = universityTypeService.GetList();
            var types = mapperService.Mapper.Map<List<UniversityTypeGetDto>>(dBTypes);
            return View(types);
        }

        [HttpGet]
        public IActionResult AddType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddType(UniversityTypeAddDto model)
        {
            var type = mapperService.Mapper.Map<UniversityType>(model);
            universityTypeService.Add(type);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteType(int id)
        {
            var type = universityTypeService.Get(i=>i.Id==id);
            universityTypeService.Delete(type);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateType(int id)
        {
            var type = universityTypeService.Get(i => i.Id == id);
            var model = mapperService.Mapper.Map<UniversityTypeUpdateDto>(type);
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateType(UniversityTypeUpdateDto model)
        {
            var type = mapperService.Mapper.Map<UniversityType>(model);
            universityTypeService.Update(type);
            return RedirectToAction("Index");
        }

    }
}
