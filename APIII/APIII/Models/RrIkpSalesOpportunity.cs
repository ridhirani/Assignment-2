using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace APIII.Models
{
    public partial class RrIkpSalesOpportunity
    {
        public RrIkpSalesOpportunity()
        {
            RrSalesOpp = new HashSet<RrSalesOpp>();
        }

        public int Id { get; set; }
        public int SoNumSites { get; set; }

        public virtual ICollection<RrSalesOpp> RrSalesOpp { get; set; }
    }
}
