using AutoMapper;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.TeacherDTOs;
using EntityLayer.Concrete;

namespace CindaSoftAcedemyCore6.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<TeacherAddDTOs, Teacher>();
            CreateMap<Teacher, TeacherAddDTOs>();

            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTOs>();

            CreateMap<AppUserLoginDTOs, AppUser>();
            CreateMap<AppUser, AppUserLoginDTOs>();

        }

    }
}
