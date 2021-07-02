namespace TaleonLtd.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Owners")]
    public class Owner : ApplicationUser
    {
        public Owner()
        {
            this.FDs = new HashSet<FD>();
            this.Vehicles = new HashSet<Vehicle>();
            this.Customers = new HashSet<Customer>();
        }

        public virtual ICollection<Customer> Customers { get; set; }

        public virtual ICollection<FD> FDs { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
