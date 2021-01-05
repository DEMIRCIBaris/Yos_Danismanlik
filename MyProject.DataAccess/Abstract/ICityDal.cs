using MyProject.Core.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Abstract
{
    public interface ICityDal: IEntityRepository<City>
    {
        List<City> GetOrderedNameCities();
    }
}
