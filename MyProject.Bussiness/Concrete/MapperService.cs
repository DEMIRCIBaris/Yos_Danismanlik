using AutoMapper;
using MyProject.Bussiness.Abstract;
using MyProject.Bussiness.Mappers.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.Concrete
{
    public class MapperService : IMapperService
    {
        public IMapper Mapper
        {
            get
            {
                return ObjectMapper.mymapper;
            }
        }
    }
}
