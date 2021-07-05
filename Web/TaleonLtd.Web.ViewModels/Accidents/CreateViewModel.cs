namespace TaleonLtd.Web.ViewModels.Accidents
{
    public class CreateViewModel
    {
        public int VehicleId { get; set; }

        public string ApplicationUserId { get; set; }

        public string AccidentDate { get; set; }

        public bool InsuaranceStatus { get; set; }

        public string Description { get; set; }

        public bool PaymentStatus { get; set; }

        public decimal TotalCoast { get; set; }
    }
}
