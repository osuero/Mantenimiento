using Mantenimiento.Models.IAudithInterface;
using System;

namespace Mantenimiento.Models.AudithVariables
{
    public class AudithVariables : IAudithVariables
    {
        public int CreadoPor { get; set; } = 0;
        public DateTime? FechaCreacion { get; set; }
        public int ActualizadoPor { get; set; } = 0;
        public DateTime? FechaActualizacion { get; set; }
    }
}
