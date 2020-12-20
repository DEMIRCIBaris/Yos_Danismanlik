using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using MyProject.Entities.DTO.AppUserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapperService mapperService;
        private readonly SignInManager<AppUser> _signInManager;
       

        public HomeController(UserManager<AppUser> userManager, IMapperService mapperService, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.mapperService = mapperService;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(UserSignInDto model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user!=null)
            {
                var result = await _signInManager.PasswordSignInAsync(user.UserName,model.Password,model.RememberMe,false);
                if (result.Succeeded)
                {
                    var roles = await userManager.GetRolesAsync(user);
                    if (roles.Contains("Admin"))
                        return RedirectToAction("Index", "Home",new { area="Admin" });
                    else
                        return RedirectToAction("Index", "Home", new { area = "Member" });

                }
                else
                {
                    ModelState.AddModelError("","Kullanıcı Adı veya Şifre Bulunamadı");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserAddDto model)
        {
            var user = mapperService.Mapper.Map<AppUser>(model);
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var roleResult = await userManager.AddToRoleAsync(user,"Member");
                if (roleResult.Succeeded)
                {
                    return RedirectToAction("LogIn");
                }
                else
                {
                    foreach (var item in roleResult.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(model);
        }

        public async Task<IActionResult> LogOut()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("LogIn");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
