using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class StaffClockSignature
    {
        public int Id { get; set; }
        public int RosterId { get; set; }
        public byte[] Signature { get; set; }
        public string ActionType { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public string SignImageFile { get; set; }

        public virtual StaffRoster Roster { get; set; }
    }
}
