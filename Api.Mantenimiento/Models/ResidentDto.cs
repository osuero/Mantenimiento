using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Mantenimiento.Models
{
    public class ResidentDto
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdCardNumber { get; set; }
        public string CellNumber { get; set; }
        public int AppartmentId { get; set; }
        public string AppartmentLetter { get; set; }
        public string ApartmentBlock { get; set; }
    }
}
