using Microsoft.EntityFrameworkCore;
using MyProject.Core.DataAccess.EntityFramework;
using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete.EntityFramework.Context;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class EfUniversityDal : EfEntityRepositoryBase<MyDataContext, University>, IUniversityDal
    {
       
    }
}
