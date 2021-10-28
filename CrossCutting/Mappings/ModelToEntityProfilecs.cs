using AutoMapper;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings
{
    public class ModelToEntityProfilecs : Profile
    {
        public ModelToEntityProfilecs()
        {
            CreateMap<TimeEntity, TimeModel>()
                .ReverseMap();
        }
    }
}
