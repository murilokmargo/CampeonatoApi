using AutoMapper;
using Domain.Dtos;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<TimeModel, TimeDtoCreate>()
                .ReverseMap();
            CreateMap<TimeModel, TimeDto>()
                .ReverseMap();
            CreateMap<TimeModel, TimeDtoUpdate>()
                .ReverseMap();
        }
    }
}
