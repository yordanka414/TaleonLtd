namespace TaleonLtd.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Customers")]
    public class Customer : ApplicationUser
    {

        public TypeOfOrder TypeOfOrder { get; set; }
    }
}
