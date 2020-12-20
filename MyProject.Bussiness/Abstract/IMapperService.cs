using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.Abstract
{
    public interface IMapperService
    {
        IMapper Mapper { get; }
    }
}
