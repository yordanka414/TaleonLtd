namespace TaleonLtd.Data.Models
{
    using System.Collections.Generic;

    using TaleonLtd.Data.Common.Models;

    public class Vehicle : BaseDeletableModel<int>
    {
        public Vehicle()
        {
            this.Accidents = new HashSet<Accident>();
            this.Penalties = new HashSet<Penalty>();
        }

        public string PlateNumber { get; set; }

        public string OwnerId { get; set; }

        public virtual Owner Owner { get; set; }

        public ICollection<DriverVehicle> Drivers { get; set; }

        public virtual ICollection<Accident> Accidents { get; set; }

        public virtual ICollection<Penalty> Penalties { get; set; }
    }
}
