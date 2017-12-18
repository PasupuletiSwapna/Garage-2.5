using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._5.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string OwnerName { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }

        public virtual ICollection<ParkedVehicle> ParkedVehicles { get; set; }
    }
}