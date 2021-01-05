using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Areas.Admin.ViewComponents
{

    public class NavbarComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            return View(model: userName);
        }
    }
}
