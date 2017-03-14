using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Audit
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public int EntityId { get; set; }
        public string Type { get; set; }
        public string XmlOld { get; set; }
        public string XmlNew { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public string Caller { get; set; }
        public Guid? TransactionId { get; set; }
    }
}
