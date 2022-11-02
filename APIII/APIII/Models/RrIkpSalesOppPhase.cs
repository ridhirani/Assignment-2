using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace APIII.Models
{
    public partial class RrIkpSalesOppPhase
    {
        public RrIkpSalesOppPhase()
        {
            RrSalesOppPhaseNavigation = new HashSet<RrSalesOpp>();
            RrSalesOppPhsPrcNavigation = new HashSet<RrSalesOpp>();
        }

        public int Id { get; set; }
        public string Phase { get; set; }
        public double? PhsPrc { get; set; }

        public virtual ICollection<RrSalesOpp> RrSalesOppPhaseNavigation { get; set; }
        public virtual ICollection<RrSalesOpp> RrSalesOppPhsPrcNavigation { get; set; }
    }
}
