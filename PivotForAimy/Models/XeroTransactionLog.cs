using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroTransactionLog
    {
        public int Id { get; set; }
        public string EntityType { get; set; }
        public string LogType { get; set; }
        public string XmlData { get; set; }
        public string BillingIds { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
