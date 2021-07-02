namespace TaleonLtd.Data.Models
{
    using System;
    using System.Collections.Generic;

    using TaleonLtd.Data.Common.Models;

    public class FD : BaseDeletableModel<string>
    {
        public FD()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Routes = new HashSet<Route>();
        }

        public string OwnerId { get; set; }

        public Owner Owner { get; set; }

        public ICollection<Route> Routes { get; set; }
    }
}
