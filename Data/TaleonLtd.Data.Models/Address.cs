namespace TaleonLtd.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using TaleonLtd.Data.Common.Models;

    public class Address : BaseDeletableModel<int>
    {
        public string LineOne { get; set; }

        public string LineTwo { get; set; }

        public string LineTree { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        [RegularExpression(@"^[a-z]{1,2}\d[a-z\d]?\s*\d[a-z]{2}$")]
        public string PostCode { get; set; }

        public string Country { get; set; }

    }
}
