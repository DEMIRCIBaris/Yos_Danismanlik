using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Bussiness.Concrete;
using MyProject.Bussiness.Contants;
using MyProject.Entities.Concrete;
using MyProject.Entities.DTO.YosQuotaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Areas.Admin.Controllers
{
    [AutoValidateAntiforgeryToken]
    [Authorize(Roles = RolesMessages.Admin)]
    [Area("Admin")]
    public class YosQuotaController : Controller
    {
        private readonly IYosQuotaService yosQuotaService;
        private readonly IMapperService mapperService;
        public YosQuotaController(IYosQuotaService yosQuotaService, IMapperService mapperService)
        {
            this.mapperService = mapperService;
            this.yosQuotaService = yosQuotaService;
        }
        public IActionResult Index()
        {
            var dBQuota = yosQuotaService.GetList();
            var quota = mapperService.Mapper.Map<List<YosQuotaGetDto>>(dBQuota);

            return View(quota);
        }
        [HttpGet]
        public IActionResult AddQuota()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddQuota(YosQuotaAddDto model)
        {
            var quota = mapperService.Mapper.Map<YosQuota>(model);
            yosQuotaService.Add(quota);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteQuota(int id)
        {
            var quota = yosQuotaService.Get(i => i.Id == id);
            yosQuotaService.Delete(quota);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateQuota(int id)
        {
            var quota = yosQuotaService.Get(i => i.Id == id);
            var model = mapperService.Mapper.Map<YosQuotaUpdateDto>(quota);

            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateQuota(YosQuotaUpdateDto model)
        {
            var quota = mapperService.Mapper.Map<YosQuota>(model);
            yosQuotaService.Update(quota);

            return RedirectToAction("Index");
        }
    }
}
