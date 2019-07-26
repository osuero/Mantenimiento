using Mantenimiento.Models.AudithVariables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mantenimiento.Models.EntityModels
{
    public class Resident: GenericModel
    //: AudithVariables.AudithVariables
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
