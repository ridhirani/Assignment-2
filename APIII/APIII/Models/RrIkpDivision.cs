using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace APIII.Models
{
    public partial class RrIkpDivision
    {
        public RrIkpDivision()
        {
            RrIkpProjectType = new HashSet<RrIkpProjectType>();
            RrIkpSalesJobOppType = new HashSet<RrIkpSalesJobOppType>();
            RrSalesOpp = new HashSet<RrSalesOpp>();
        }

        public int DivId { get; set; }
        public string SalesOpportunityDivname { get; set; }

        public virtual ICollection<RrIkpProjectType> RrIkpProjectType { get; set; }
        public virtual ICollection<RrIkpSalesJobOppType> RrIkpSalesJobOppType { get; set; }
        public virtual ICollection<RrSalesOpp> RrSalesOpp { get; set; }
    }
}
