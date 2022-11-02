using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace APIII.Models
{
    public partial class RrIkpSalesOppStatus
    {
        public RrIkpSalesOppStatus()
        {
            RrIkpSalesOppStatusReason = new HashSet<RrIkpSalesOppStatusReason>();
            RrSalesOpp = new HashSet<RrSalesOpp>();
        }

        public int Id { get; set; }
        public string SosStatus { get; set; }

        public virtual ICollection<RrIkpSalesOppStatusReason> RrIkpSalesOppStatusReason { get; set; }
        public virtual ICollection<RrSalesOpp> RrSalesOpp { get; set; }
    }
}
