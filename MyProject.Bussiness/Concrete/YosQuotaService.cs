using MyProject.Bussiness.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyProject.Bussiness.Concrete
{
    public class YosQuotaService : IYosQuotaService
    {
        private readonly IYosQuotaDal yosQuotaDal;
        public YosQuotaService(IYosQuotaDal yosQuotaDal)
        {
            this.yosQuotaDal = yosQuotaDal;
        }
        public void Add(YosQuota entity)
        {
            yosQuotaDal.Add(entity);
        }

        public void Delete(YosQuota entity)
        {
            yosQuotaDal.Delete(entity);
        }

        public YosQuota Get(Expression<Func<YosQuota, bool>> filter)
        {
            var yosQuota = yosQuotaDal.Get(filter);
            return yosQuota;
        }

        public List<YosQuota> GetList(Expression<Func<YosQuota, bool>> filter = null)
        {
            var yosQuota = yosQuotaDal.GetList(filter);
            return yosQuota;
        }

        public List<YosQuota> GetOrderedNameQuota()
        {
            var yosQuto = yosQuotaDal.GetOrderedNameQuota();
            return yosQuto;
        }

        public void Update(YosQuota entity)
        {
            yosQuotaDal.Update(entity);
        }
    }
}
