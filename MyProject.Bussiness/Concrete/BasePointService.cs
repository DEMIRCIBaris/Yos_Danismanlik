using MyProject.Bussiness.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyProject.Bussiness.Concrete
{
    public class BasePointService : IBasePointService
    {
        private readonly IBasePointDal basePointDal;

        public BasePointService(IBasePointDal basePointDal)
        {
            this.basePointDal = basePointDal;
        }
        public void Add(BasePoint entity)
        {
            basePointDal.Add(entity);
        }

        public void Delete(BasePoint entity)
        {
            basePointDal.Delete(entity);
        }

        public BasePoint Get(Expression<Func<BasePoint, bool>> filter)
        {
            var point = basePointDal.Get(filter);
            return point; 
        }

        public List<BasePoint> GetList(Expression<Func<BasePoint, bool>> filter = null)
        {
            var point = basePointDal.GetList(filter);
            return point;
        }

        public void Update(BasePoint entity)
        {
            basePointDal.Update(entity);
        }
    }
}
