using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroCreditNoteQueue
    {
        public int Id { get; set; }
        public int CreditNoteId { get; set; }
        public int OrgId { get; set; }
        public bool IsProcessed { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual CreditNote CreditNote { get; set; }
        public virtual Org Org { get; set; }
    }
}
