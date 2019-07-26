using Api.Mantenimiento.Models;
using AutoMapper;
using Mantenimiento.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Mantenimiento.Mappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ResidentDto, Resident>();
        }
    }
}
