using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OscarNote
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public int TypeId { get; set; }
        public int Identifier { get; set; }
        public string Identifier2 { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int UpdatedById { get; set; }
        public bool EditableByOther { get; set; }
        public bool IsActive { get; set; }
        public bool IsLatest { get; set; }

        public virtual Lookup Type { get; set; }
    }
}
