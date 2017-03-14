using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SitePaymentGateway
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public string DigitalKey { get; set; }

        public virtual Org Site { get; set; }
    }
}
