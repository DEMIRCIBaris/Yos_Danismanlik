using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Entities.DTO.BasePointDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Controllers
{
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
    }
}
