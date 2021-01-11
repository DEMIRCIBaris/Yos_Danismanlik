using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Bussiness.Contants;
using MyProject.Core.Helpers.JsonHelpers;
using MyProject.Entities.Concrete;


namespace MyProject.WEB.Controllers
{
    //[Authorize("Admin")]
    public class ConfigureController : Controller
    {
        private readonly ICityService cityService;

        public ConfigureController(ICityService cityService)
        {
            this.cityService = cityService;
        }
        public IActionResult Index()
        {
            var result = SeedHelper.SeedData<City>("Cities.Json");
            foreach (var item in result)
            {
                cityService.Add(item); 
            }
            return RedirectToAction("LogIn","Home");
        }
    }
}
