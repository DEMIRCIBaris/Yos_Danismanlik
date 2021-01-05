using MyProject.Core.DataAccess.EntityFramework;
using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete.EntityFramework.Context;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : EfEntityRepositoryBase<MyDataContext, City>, ICityDal
    {
        public List<City> GetOrderedNameCities()
        {
            using(var dB=new MyDataContext())
            {
                var cities = dB.Cities.OrderBy(i => i.Name).ToList();
                return cities;
            }
        }
    }
}
