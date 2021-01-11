using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Bussiness.Contants;
using MyProject.Entities.Concrete;
using MyProject.Entities.DTO.BasePointDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Areas.Admin.Controllers
{
    [AutoValidateAntiforgeryToken]
    [Authorize(Roles = RolesMessages.Admin)]
    [Area("Admin")]
    public class BasePointController : Controller
    {
        private readonly IBasePointService basePointService;
        private readonly IMapperService mapperService;

        public BasePointController(IBasePointService basePointService, IMapperService mapperService)
        {
            this.mapperService = mapperService;
            this.basePointService = basePointService;
        }
        public IActionResult Index()
        {
            var dBPoint = basePointService.GetList();
            var point = mapperService.Mapper.Map<List<BasePointGetDto>>(dBPoint);

            return View(point);
        }
        [HttpGet]
        public IActionResult AddPoint()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPoint(BasePointAddDto model)
        {
            var point = mapperService.Mapper.Map<BasePoint>(model);
            basePointService.Add(point);

            return RedirectToAction("Index");
        }
        public IActionResult DeletePoint(int id)
        {
            var point = basePointService.Get(i => i.Id == id);
            basePointService.Delete(point);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePoint(int id)
        {
            var point = basePointService.Get(i => i.Id == id);
            var model = mapperService.Mapper.Map<BasePointUpdateDto>(point);

            return View(model);
        }
        [HttpPost]
        public IActionResult UpdatePoint(BasePointUpdateDto model)
        {
            var point = mapperService.Mapper.Map<BasePoint>(model);
            basePointService.Update(point);

            return RedirectToAction("Index");
        }
    }
}
