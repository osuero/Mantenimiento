using System;
using System.Collections.Generic;
using System.Text;

namespace Mantenimiento.Models.IAudithInterface
{
    public interface IAudithVariables
    {

         int CreadoPor { get; set; }
         DateTime? FechaCreacion { get; set; }
         int ActualizadoPor { get; set; }
         DateTime? FechaActualizacion { get; set; }
    }
}
