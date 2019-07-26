using Mantenimiento.Common.Repository;
using Mantenimiento.Models.Context;
using Mantenimiento.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mantenimiento.Services.Repositories
{
    public class ResidentRepository: GenericRepository<Resident>
    {
        private readonly MantenimientoDbContext _context;

        public ResidentRepository(MantenimientoDbContext _context) : base(_context)
        {

        }
    }
}
