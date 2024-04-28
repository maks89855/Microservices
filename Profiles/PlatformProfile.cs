using AutoMapper;
using PlatformSerice.Models;
using PlatformService.DTO;

namespace PlatformService.Profiles
{
    public class PlatformProfile: Profile
    {

        public PlatformProfile()
        {
            CreateMap<PlatformReadDTO, Platform>();
            CreateMap<Platform, PlatformReadDTO>();
            CreateMap<PlatformCreateDTO, PlatformReadDTO>();
        }
    }
}
