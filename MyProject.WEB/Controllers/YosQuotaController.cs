using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
using MyProject.Entities.DTO.YosQuotaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Controllers
{
    public class YosQuotaController : Controller
    {
        private readonly IYosQuotaService yosQuotaService;
        private readonly IMapperService mapperService;

        public YosQuotaController(IMapperService mapperService, IYosQuotaService yosQuotaService)
        {
            this.mapperService = mapperService;
            this.yosQuotaService = yosQuotaService;
        }
        public IActionResult Index()
        {
            var dBQuota = yosQuotaService.GetOrderedNameQuota();
            var quota = mapperService.Mapper.Map<List<YosQuotaGetDto>>(dBQuota);

            return View(quota);
        }
    }
}
