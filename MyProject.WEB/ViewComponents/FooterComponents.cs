﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.ViewComponents
{
    public class FooterComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}