using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyProject.Bussiness.Abstract;
using MyProject.Bussiness.Contants;
using MyProject.Core.Helpers.FileHelper;
using MyProject.Entities.Concrete;
using MyProject.Entities.DTO.UniversityDTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Areas.Admin.Controllers
{

    [AutoValidateAntiforgeryToken]
    [Authorize(Roles = RolesMessages.Admin)]
    [Area("Admin")]
    public class UniversitiesController : Controller
    {
        private readonly IUniversityService universityService;
        private readonly IMapperService mapperService;
        private readonly ICityService cityService;
        private readonly IUniversityTypeService universityTypeService;
        private readonly IMailService mailService;

        public UniversitiesController(IMailService mailService,ICityService cityService, IUniversityService universityService, IMapperService mapperService, IUniversityTypeService universityTypeService)
        {
            this.mapperService = mapperService;
            this.universityService = universityService;
            this.cityService = cityService;
            this.universityTypeService = universityTypeService;
            this.mailService = mailService;
        }

        public IActionResult Index()
        {
            var dBTypes = universityService.GetUniversityWithCityAndType();
            var types = mapperService.Mapper.Map<List<UniversityGetDto>>(dBTypes);
            return View(types);
        }

        [HttpGet]
        public IActionResult AddUniversity()
        {
            var cities = cityService.GetList();
            ViewBag.Cities = new SelectList(cities, "Id", "Name");

            var types = universityTypeService.GetList();
            ViewBag.Types = new SelectList(types,"Id","Name");

            return View();
        }

       

        [HttpPost]

        public async Task<IActionResult> AddUniversity(UniversityAddDto model, IFormFile Resim)
        {
            model.PictureUrl = await CreateFile.FileCreater(Resim, "Image");

            var type = mapperService.Mapper.Map<University>(model);
            universityService.Add(type);

            return RedirectToAction("Index");
        }


        public IActionResult DeleteUniversity(int id)
        {
            var type = universityService.Get(i => i.Id == id);
            universityService.Delete(type);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateUniversity(int id)
        {

         
            var cities = cityService.GetList();
            ViewBag.Cities = new SelectList(cities, "Id", "Name");

            var types = universityTypeService.GetList();
            ViewBag.Types = new SelectList(types, "Id", "Name");

            var type = universityService.Get(i => i.Id == id);
            var model = mapperService.Mapper.Map<UniversityUpdateDto>(type);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUniversity(UniversityUpdateDto model,IFormFile Resim)
        {
            model.PictureUrl = Resim!=null?await CreateFile.FileCreater(Resim, "Image"):model.PictureUrl;

            var type = mapperService.Mapper.Map<University>(model);
            universityService.Update(type);

            var users = universityService.GetUniversitiesUsers(model.Id);
            foreach (var user in users)
            {
                mailService.SendMail(user.Email, $"{model.Name} nin Başvuru Tarihi {model.BasvuruTarih} Sınav Tarihi {model.SinavTarihi} Sonuc Tarihi {model.SonucTarihi} olarak güncellendi","Seçtiğiniz Üniversite Bilgileri Güncellendi");
            }

            return RedirectToAction("Index");
        }
    }
}
