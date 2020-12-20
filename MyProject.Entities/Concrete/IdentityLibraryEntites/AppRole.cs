using Microsoft.AspNetCore.Identity;
using MyProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.Concrete.IdentityLibraryEntites
{
    public class AppRole:IdentityRole<int>,IEntity
    {
    }
}
