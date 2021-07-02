namespace TaleonLtd.Data.Models
{
    using System.Collections.Generic;

    using TaleonLtd.Data.Common.Models;

    public class Route : BaseDeletableModel<int>
    {
        public Route()
        {
            this.Stops = new HashSet<Stop>();
        }

        public string RouteNumber { get; set; }

        public string FDId { get; set; }

        public FD FD { get; set; }

        public virtual ICollection<Stop> Stops { get; set; }

        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public string ApplicationUserId { get; set; }
    }
}
