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
    public class EfYosQuotaDal : EfEntityRepositoryBase<MyDataContext, YosQuota>, IYosQuotaDal
    {
        public List<YosQuota> GetOrderedNameQuota()
        {
            using(var dB=new MyDataContext())
            {
                var quota = dB.YosQuotas.OrderBy(i => i.UniversityName).ToList();
                return quota;
            }
        }
    }
}
