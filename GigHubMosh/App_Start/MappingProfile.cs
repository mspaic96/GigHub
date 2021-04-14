using AutoMapper;
using GigHubMosh.Controllers.Api;
using GigHubMosh.Dtos;
using GigHubMosh.Models;

namespace GigHubMosh.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<Gig, GigDto>();
            CreateMap<Notification, NotificationDto>();

        }
    }
}