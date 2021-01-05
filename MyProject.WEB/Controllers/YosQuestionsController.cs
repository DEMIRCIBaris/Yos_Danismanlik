using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Entities.DTO.YosQuestionsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Controllers
{
    public class YosQuestionsController : Controller
    {
        private readonly IYosQuestionsService yosQuestionsService;
        private readonly IMapperService mapperService;

        public YosQuestionsController(IYosQuestionsService yosQuestionsService, IMapperService mapperService)
        {
            this.mapperService = mapperService;
            this.yosQuestionsService = yosQuestionsService;
        }
        public IActionResult Index()
        {
            var dBTypes = yosQuestionsService.GetList();
            var types = mapperService.Mapper.Map<List<YosQuestionsGetDto>>(dBTypes);
            return View(types);
        }
        public IActionResult DownloadFile(int id)
        {
            var fileName = yosQuestionsService.Get(i => i.Id == id).DocumentUrl;
            var path = @"~/Document/" + fileName;
            return File(path, "application/pdf", fileName);
        }
    }
}
