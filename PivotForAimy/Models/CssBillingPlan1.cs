﻿using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssBillingPlan1
    {
        public CssBillingPlan1()
        {
            CssBillingPlanDetails1 = new HashSet<CssBillingPlanDetails1>();
            Org = new HashSet<Org>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<CssBillingPlanDetails1> CssBillingPlanDetails1 { get; set; }
        public virtual ICollection<Org> Org { get; set; }
    }
}
