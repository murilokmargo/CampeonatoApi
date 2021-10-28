using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<TimeDtoCreate, TimeEntity>()
                .ReverseMap();

            CreateMap<TimeDTOCreateResult, TimeEntity>()
                .ReverseMap();

            CreateMap<TimeDtoUpdateResult, TimeEntity>()
               .ReverseMap();
        }
    }
}
