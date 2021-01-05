﻿using MyProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.Concrete
{
    public class YosQuota: IEntity
    {
        public int Id { get; set; }
        public string UniversityName { get; set; }
        public string Departments { get; set; }
        public string Time { get; set; }
        public string Quota { get; set; }
    }
}
