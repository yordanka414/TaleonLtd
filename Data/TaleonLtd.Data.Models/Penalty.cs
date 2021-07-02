namespace TaleonLtd.Data.Models
{
    using System;

    using TaleonLtd.Data.Common.Models;

    public class Penalty : BaseDeletableModel<int>
    {
        public DateTime PenaltyDate { get; set; }

        public string PenaltyDescription { get; set; }

        public bool PenaltyStatus { get; set; }
    }
}
