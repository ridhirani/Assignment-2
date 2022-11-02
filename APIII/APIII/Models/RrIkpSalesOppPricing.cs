using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace APIII.Models
{
    public partial class RrIkpSalesOppPricing
    {
        public RrIkpSalesOppPricing()
        {
            RrSalesOpp = new HashSet<RrSalesOpp>();
        }

        public int Id { get; set; }
        public decimal PriDollarAmt { get; set; }
        public string PrjtType { get; set; }
        public string JobType { get; set; }

        public virtual RrIkpSalesJobOppType JobTypeNavigation { get; set; }
        public virtual RrIkpProjectType PrjtTypeNavigation { get; set; }
        public virtual ICollection<RrSalesOpp> RrSalesOpp { get; set; }
    }
}
