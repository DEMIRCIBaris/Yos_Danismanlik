using AutoMapper;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using MyProject.Entities.DTO.AppUserDTO;


namespace MyProject.Bussiness.Mappers.AutoMapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            #region UserApp
            CreateMap<UserAddDto, AppUser>();
            CreateMap<AppUser, UserAddDto>();

            CreateMap<AppUser, UserSignInDto>();
            CreateMap<UserSignInDto, AppUser>();
            #endregion
        }


    }
}
