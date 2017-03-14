using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroInvErrorQueue
    {
        public int Id { get; set; }
        public int XeroInvQueueId { get; set; }
        public string XeroConsumerKey { get; set; }
        public string ErrorType { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsProcessed { get; set; }

        public virtual XeroInvoiceQueue XeroInvQueue { get; set; }
    }
}
