using MyProject.Core.Bussiness;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.Abstract
{
    public interface IYosQuotaService :  IGenericService<YosQuota>
    {
        List<YosQuota> GetOrderedNameQuota();
    }
}
