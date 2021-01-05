using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Entities.Concrete;
using MyProject.Entities.DTO.YosQuestionsDTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Areas.Admin.Controllers
{
    [AutoValidateAntiforgeryToken]
    [Area("Admin")]
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
        [HttpGet]
        public IActionResult AddQuestions()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddQuestions(YosQuestionsAddDto model, IFormFile Dosya)
        {
            if (Dosya != null)
            {
                string dcmExtension = Path.GetExtension(Dosya.FileName);
                string dcmName = Guid.NewGuid() + dcmExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Document/" + dcmName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await Dosya.CopyToAsync(stream);
                }

                model.DocumentUrl = dcmName;
            }

            var question = mapperService.Mapper.Map<YosQuestions>(model);
            yosQuestionsService.Add(question);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteQuestion(int id)
        {
            var quesiton = yosQuestionsService.Get(i => i.Id == id);
            yosQuestionsService.Delete(quesiton);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateQuestion(int id)
        {
            var quesiton = yosQuestionsService.Get(i => i.Id == id);
            var model = mapperService.Mapper.Map<YosQuestionsUpdateDto>(quesiton);
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateQuestion(YosQuestionsUpdateDto model)
        {
            var quesiton = mapperService.Mapper.Map<YosQuestions>(model);
            yosQuestionsService.Update(quesiton);
            return RedirectToAction("Index");
        }

        public IActionResult DownloadFile(int id)
        {
            var fileName = yosQuestionsService.Get(i => i.Id == id).DocumentUrl;
            var path = @"~/Document/" + fileName;
            return File(path,"application/pdf",fileName);
        }

    }
}
