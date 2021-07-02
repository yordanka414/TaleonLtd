namespace TaleonLtd.Data.Models
{
    public class DriverVehicle
    {
        public int Id { get; set; }

        public string DriverId { get; set; }

        public Driver Driver { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}