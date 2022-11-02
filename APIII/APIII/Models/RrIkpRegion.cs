using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace APIII.Models
{
    public partial class RrIkpRegion
    {
        public RrIkpRegion()
        {
            RrIkpMarket = new HashSet<RrIkpMarket>();
            RrSalesOpp = new HashSet<RrSalesOpp>();
        }

        public int SoRegionId { get; set; }
        public string Region { get; set; }
        public string Area { get; set; }

        public virtual ICollection<RrIkpMarket> RrIkpMarket { get; set; }
        public virtual ICollection<RrSalesOpp> RrSalesOpp { get; set; }
    }
}
