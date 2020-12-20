using MyProject.Core.DataAccess.EntityFramework;
using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete.EntityFramework.Context;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class EfUniversityTypeDal : EfEntityRepositoryBase<MyDataContext, UniversityType>, IUniversityTypeDal
    {
    }
}
