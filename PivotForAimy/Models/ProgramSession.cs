using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ProgramSession
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public int SessionId { get; set; }
        public int? XeroItemCodeId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual Program Program { get; set; }
        public virtual Session Session { get; set; }
        public virtual XeroItemCode XeroItemCode { get; set; }
    }
}
