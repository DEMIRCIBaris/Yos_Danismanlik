﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.DTO.AppUserDTO
{
    public class UserSignInDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
