using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._5.Models
{
    public class VehicleType
    {

        public int VehicleTypeId { get; set; }
        public string VType { get; set; }

        public virtual ICollection<ParkedVehicle> Parkedvehicles { get; set; }
    }
}