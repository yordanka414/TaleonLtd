namespace TaleonLtd.Data.Models
{
    using System;

    using TaleonLtd.Data.Common.Models;

    public class Stop : BaseDeletableModel<int>
    {
        public DateTime Date { get; set; }

        public int Count { get; set; }

        public int TotalParcels { get; set; }

        public int ExcessParcels { get; set; }

        public decimal StopPrice { get; set; }

        public int Parcels { get; set; }

        public decimal Total { get; set; }

        public int RouteId { get; set; }

        public virtual Route Route { get; set; }

        public string FdId { get; set; }

        public virtual FD Fd { get; set; }
    }
}
