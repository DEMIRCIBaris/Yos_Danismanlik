
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyProject.Bussiness.Abstract;
using MyProject.Bussiness.Contants;
using MyProject.DataAccess.Concrete.EntityFramework;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using MyProject.Entities.DTO.AppUserDTO;
using MyProject.Entities.DTO.UniversityDTO;
using MyProject.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Controllers

{

    [Authorize(Roles = RolesMessages.Member)]

    public class ProfileController : Controller
    {
        private readonly IUniversityService universityService;
        private readonly IMapperService mapperService;
        private readonly ICityService cityService;
        private readonly IUniversityTypeService universityTypeService;
        private readonly IAppUserService appUserService;
        private readonly UserManager<AppUser> userManager;
        private readonly IMailService mailService;

        public ProfileController(IMailService mailService,IAppUserService appUserService,ICityService cityService, IUniversityService universityService, IMapperService mapperService, IUniversityTypeService universityTypeService, UserManager<AppUser> userManager)
        {
            this.mapperService = mapperService;
            this.universityService = universityService;
            this.cityService = cityService;
            this.universityTypeService = universityTypeService;
            this.userManager = userManager;
            this.appUserService = appUserService;
            this.mailService = mailService;
        }

        public async Task<IActionResult> Index()
        {
            var cities = cityService.GetList();
            ViewBag.Cities = new SelectList(cities, "Id", "Name");

            var type = universityTypeService.GetList();
            ViewBag.Type = new SelectList(type, "Id", "Name");

            var userName = User.Identity.Name;
            var user = await userManager.FindByNameAsync(userName);
            ViewBag.Name = user.Name;

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Settings()
        {
            var userName = User.Identity.Name;
            var user =await userManager.FindByNameAsync(userName);
            var model = mapperService.Mapper.Map<UserUpdateDto>(user);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Settings(UserUpdateDto user)
        {
            var appUser = userManager.Users.FirstOrDefault(i => i.Id == user.Id);

            appUser.UserName = user.UserName;
            appUser.Name = user.Name;
            appUser.Email = user.Email;
            appUser.PhoneNumber = user.PhoneNumber;
            appUser.Surname = user.Surname;

            await userManager.UpdateAsync(appUser);

            return RedirectToAction("Index","Static");
        }

        public async Task<IActionResult> PartialProfileUniversities(string search)
        {
            var dBTypes = universityService.GetUniversityWithCityAndType(search);
            var viewModel = new List<GetViewModelUniversity>();

            var userName = User.Identity.Name;
            var user = await userManager.FindByNameAsync(userName);
            var userId = user.Id;

          
            var dBUser = appUserService.GetUserWithUniversities(userId);


            foreach (var university in dBTypes)
            {
                viewModel.Add(new GetViewModelUniversity
                {
                    Id = university.Id,
                    City = university.City,
                    Name = university.Name,
                    PictureUrl = university.PictureUrl,
                    URL = university.URL,
                    UniversityType = university.UniversityType,
                    BasvuruTarih = university.BasvuruTarih.Year == 0001 ? "-" : university.BasvuruTarih.ToShortDateString(),
                    SonucTarihi = university.SonucTarihi.Year == 0001 ? "-" : university.SonucTarihi.ToShortDateString(),
                    SinavTarihi = university.SinavTarihi.Year == 0001 ? "-" : university.SinavTarihi.ToShortDateString(),
                    IsAdded = dBUser.UsersUniversities.Any(i => i.UniversitiesId == university.Id)
                });
            }

            return PartialView("_PartialProfileUniversities", viewModel);

        }
        public async Task SelectUniversity(int universityId)
        {
            var userName = User.Identity.Name;
            var user = await userManager.FindByNameAsync(userName);
            var university = universityService.Get(i => i.Id == universityId);

            var dBUser = appUserService.GetUserWithUniversities(user.Id);
            dBUser.UsersUniversities.Add(new Entities.Concrete.UserUniversity {AppUser=user,University=university});

            mailService.SendMail(dBUser.Email, $"{university.Name} ni eklediniz hayırlı olsun", "Üniversite Ekleme Uyarısı");

            appUserService.Update(dBUser);
        }

        public async Task PopUniversity(int universityId)
        {
            var userName = User.Identity.Name;
            var user = await userManager.FindByNameAsync(userName);
            appUserService.DeleteUserUniversity(user.Id,universityId);
        }
    }
}

