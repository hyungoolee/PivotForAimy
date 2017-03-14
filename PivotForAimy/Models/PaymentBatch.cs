using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class PaymentBatch
    {
        public PaymentBatch()
        {
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string PaymentReference { get; set; }
        public int PayerId { get; set; }
        public int? SiteId { get; set; }
        public int? TransactionId { get; set; }
        public string Email { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaidOn { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ResponseMessage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public string AccessCode { get; set; }
        public string Errors { get; set; }
        public int? PaymentMethodId { get; set; }
        public string PaidBy { get; set; }
        public string PayerReference { get; set; }

        public virtual ICollection<Payment> Payment { get; set; }
        public virtual User Payer { get; set; }
        public virtual Lookup PaymentMethod { get; set; }
        public virtual Org Site { get; set; }
    }
}
