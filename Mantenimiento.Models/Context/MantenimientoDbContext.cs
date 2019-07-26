using Mantenimiento.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mantenimiento.Models.Context
{
    public class MantenimientoDbContext:DbContext
    {
        public MantenimientoDbContext()
        {
        }

        public MantenimientoDbContext(DbContextOptions<MantenimientoDbContext> options) 
            : base(options)
        {
        }

        DbSet<Resident> Residents { get; set; }

    }
}
