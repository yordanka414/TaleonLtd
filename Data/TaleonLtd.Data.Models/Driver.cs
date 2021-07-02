﻿namespace TaleonLtd.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Drivers")]
    public class Driver : ApplicationUser
    {
        public string DrivingLicense { get; set; }

        public virtual ICollection<DriverVehicle> Vehicles { get; set; }
    }
}
