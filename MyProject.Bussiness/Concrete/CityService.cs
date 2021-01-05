using MyProject.Bussiness.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyProject.Bussiness.Concrete
{
    public class CityService : ICityService
    {
        private readonly ICityDal cityDal;

        public CityService(ICityDal cityDal)
        {
            this.cityDal = cityDal;
        }

        public void Add(City entity)
        {
            cityDal.Add(entity);
        }

        public void Delete(City entity)
        {
            cityDal.Delete(entity);
        }

        public City Get(Expression<Func<City, bool>> filter)
        {
            var city = cityDal.Get(filter);
            return city;
        }

        public List<City> GetList(Expression<Func<City, bool>> filter = null)
        {
            var cities = cityDal.GetList(filter);
            return cities;
        }

        public List<City> GetOrderedNameCities()
        {
            var cities = cityDal.GetOrderedNameCities();
            return cities;
        }

        public void Update(City entity)
        {
            cityDal.Update(entity);
        }
    }
}
