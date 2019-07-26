using Api.Mantenimiento.Models;
using AutoMapper;
using Mantenimiento.Models.EntityModels;
using Mantenimiento.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Mantenimiento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentController : BaseApiController<Resident, ResidentDto>
    {
        
        public ResidentController(IMapper mapper, ResidentRepository repository) : base(mapper, repository)
        {
        }
    }
}
