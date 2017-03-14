using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssSetting
    {
        public int Id { get; set; }
        public string XeroConsumerKey { get; set; }
        public int? BillingAccountCode { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public byte[] Version { get; set; }
        public int? BillingMethod { get; set; }
        public decimal? Smscharge { get; set; }
    }
}
