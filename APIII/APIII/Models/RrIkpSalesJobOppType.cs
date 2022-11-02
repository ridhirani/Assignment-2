using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace APIII.Models
{
    public partial class RrIkpSalesJobOppType
    {
        public RrIkpSalesJobOppType()
        {
            RrIkpSalesOppPricing = new HashSet<RrIkpSalesOppPricing>();
            RrSalesOpp = new HashSet<RrSalesOpp>();
        }

        public int Id { get; set; }
        public string JobType { get; set; }
        public string SalesOpportunityDivname { get; set; }

        public virtual RrIkpDivision SalesOpportunityDivnameNavigation { get; set; }
        public virtual ICollection<RrIkpSalesOppPricing> RrIkpSalesOppPricing { get; set; }
        public virtual ICollection<RrSalesOpp> RrSalesOpp { get; set; }
    }
}
