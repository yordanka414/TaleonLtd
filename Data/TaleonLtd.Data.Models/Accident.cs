namespace TaleonLtd.Data.Models
{
    using System;

    using TaleonLtd.Data.Common.Models;

    public class Accident : BaseDeletableModel<string>
    {
        public Accident()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public DateTime AccidentDate { get; set; }

        public bool InsuaranceStatus { get; set; }

        public string Description { get; set; }

        public bool PaymentStatus { get; set; }

        public decimal TotalCoast { get; set; }
    }
}
