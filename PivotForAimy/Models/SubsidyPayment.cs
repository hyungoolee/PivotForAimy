using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SubsidyPayment
    {
        public SubsidyPayment()
        {
            XeroSubsidyPaymentQueue = new HashSet<XeroSubsidyPaymentQueue>();
        }

        public int Id { get; set; }
        public int? InvoiceId { get; set; }
        public int? SubsidyId { get; set; }
        public int? XeroAccCodeId { get; set; }
        public int? StatusId { get; set; }
        public Guid? XeroTransactionId { get; set; }
        public string Email { get; set; }
        public DateTime? Date { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public string InvoiceReference { get; set; }
        public decimal Amount { get; set; }
        public string SubsidyPaymentReference { get; set; }
        public int? SubsidyPaymentIndexId { get; set; }
        public DateTime? XeroUpdatedDateUtc { get; set; }
        public bool? Error { get; set; }
        public string ErrorDescription { get; set; }
        public bool HasAdded { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }
        public int? ExternalInvId { get; set; }
        public int? XeroTrackingCatOptionId { get; set; }

        public virtual ICollection<XeroSubsidyPaymentQueue> XeroSubsidyPaymentQueue { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Lookup Status { get; set; }
        public virtual Subsidy Subsidy { get; set; }
        public virtual SubsidyPaymentIndex SubsidyPaymentIndex { get; set; }
        public virtual XeroAccountCode XeroAccCode { get; set; }
        public virtual XeroTrackingCatOption XeroTrackingCatOption { get; set; }
    }
}
