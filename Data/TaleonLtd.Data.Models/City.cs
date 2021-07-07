using TaleonLtd.Data.Common.Models;

namespace TaleonLtd.Data.Models
{
    public class City : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int CoutnryId { get; set; }

        public Country Country { get; set; }
    }
}
