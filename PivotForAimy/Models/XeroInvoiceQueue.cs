﻿using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroInvoiceQueue
    {
        public XeroInvoiceQueue()
        {
            XeroInvErrorQueue = new HashSet<XeroInvErrorQueue>();
        }

        public int Id { get; set; }
        public int OrgId { get; set; }
        public int InvoiceId { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime GenerateInvOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<XeroInvErrorQueue> XeroInvErrorQueue { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Org Org { get; set; }
    }
}
