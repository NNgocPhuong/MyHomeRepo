using AutoMapper;
using Domain.Entities;
using Presentation.Models;

namespace Presentation.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Room, Rooms>();
        }
    }
}