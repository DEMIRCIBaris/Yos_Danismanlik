using AutoMapper;
using MyProject.Entities.Concrete;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using MyProject.Entities.DTO.UniversityDTO;
using MyProject.Entities.DTO.UniversityTypeDTO;
using MyProject.Entities.DTO.AppUserDTO;
using MyProject.Entities.DTO.BasePointDTO;
using MyProject.Entities.DTO.YosQuestionsDTO;
using MyProject.Entities.DTO.YosQuotaDTO;

namespace MyProject.Bussiness.Mappers.AutoMapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            #region UserApp
            CreateMap<UserAddDto, AppUser>();
            CreateMap<AppUser, UserAddDto>();

            CreateMap<UserUpdateDto, AppUser>();
            CreateMap<AppUser, UserUpdateDto>();

            CreateMap<AppUser, UserSignInDto>();
            CreateMap<UserSignInDto, AppUser>();

            CreateMap<AppUser, UserGetDto>();
            CreateMap<UserGetDto, AppUser>();

            CreateMap<UniversityAddDto, University>();
            CreateMap<University, UniversityAddDto>();

            CreateMap<UniversityGetDto, University>();
            CreateMap<University, UniversityGetDto>();

            CreateMap<UniversityUpdateDto, University>();
            CreateMap<University, UniversityUpdateDto>();

            CreateMap<UniversityTypeAddDto, UniversityType>();
            CreateMap<UniversityType, UniversityTypeAddDto>();

            CreateMap<UniversityTypeGetDto, UniversityType>();
            CreateMap<UniversityType, UniversityTypeGetDto>();

            CreateMap<UniversityTypeUpdateDto, UniversityType>();
            CreateMap<UniversityType, UniversityTypeUpdateDto>();

            CreateMap<YosQuestionsAddDto, YosQuestions>();
            CreateMap<YosQuestions, YosQuestionsAddDto>();

            CreateMap<YosQuestionsUpdateDto, YosQuestions>();
            CreateMap<YosQuestions, YosQuestionsUpdateDto>();

            CreateMap<YosQuestionsGetDto, YosQuestions>();
            CreateMap<YosQuestions, YosQuestionsGetDto>();

            CreateMap<YosQuotaAddDto, YosQuota>();
            CreateMap<YosQuota, YosQuotaAddDto>();

            CreateMap<YosQuotaUpdateDto, YosQuota>();
            CreateMap<YosQuota, YosQuotaUpdateDto>();

            CreateMap<YosQuotaGetDto, YosQuota>();
            CreateMap<YosQuota, YosQuotaGetDto>();

            CreateMap<BasePointGetDto, BasePoint>();
            CreateMap<BasePoint, BasePointGetDto>();

            CreateMap<BasePointAddDto, BasePoint>();
            CreateMap<BasePoint, BasePointAddDto>();

            CreateMap<BasePointUpdateDto, BasePoint>();
            CreateMap<BasePoint, BasePointUpdateDto>();

            #endregion
        }


    }
}
