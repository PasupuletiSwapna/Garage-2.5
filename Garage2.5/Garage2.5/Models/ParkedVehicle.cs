using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Garage2._5.Models
{
    public class ParkedVehicle
    {

        public int Id { get; set; }

        public int MemberId { get; set; }
        public int VehicleTypeId { get; set; }
        [Required]
        [StringLength(7, MinimumLength = 6, ErrorMessage = "Enter Proper RegNo with min 6charaters")]
        [Display(Name = "Registration Number")]
        public string RegNum { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        [DisplayName("Number Of Wheels")]
        public int NoOfWheels { get; set; }
        public int SeatCapacity { get; set; }

        [DisplayName("CheckIn")]
        public DateTime ParkingTime { get; set; }
        //public DateTime CheckOut { get; set; } 

        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }
        [ForeignKey("VehicleTypeId")]
        public virtual VehicleType VehicleType { get; set; }
    }

}
}