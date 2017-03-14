using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SitePaymentMethod
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int? TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BankInfo { get; set; }
        public string BankAccountNumber { get; set; }
        public string DirectDebitForm { get; set; }

        public virtual Org Site { get; set; }
    }
}
