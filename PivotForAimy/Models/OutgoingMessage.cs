using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OutgoingMessage
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? NumberOfSms { get; set; }
        public string Subject { get; set; }
        public string Reference { get; set; }
        public string AttachmentFilePath { get; set; }
        public string Data { get; set; }
        public string DeliveryMethod { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientMobile { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public string Error { get; set; }
        public int RetryCount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public byte[] Version { get; set; }
        public string Source { get; set; }
        public string ReplyEmail { get; set; }

        public virtual User User { get; set; }
    }
}
