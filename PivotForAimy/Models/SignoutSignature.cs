using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SignoutSignature
    {
        public SignoutSignature()
        {
            AttendanceSignInSignature = new HashSet<Attendance>();
            AttendanceSignoutSignature = new HashSet<Attendance>();
            AttendanceStagingSignInSignature = new HashSet<AttendanceStaging>();
            AttendanceStagingSignoutSignature = new HashSet<AttendanceStaging>();
            RollCallQueue = new HashSet<RollCallQueue>();
        }

        public int Id { get; set; }
        public int ContactId { get; set; }
        public byte[] Signature { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public string SignImageFile { get; set; }

        public virtual ICollection<Attendance> AttendanceSignInSignature { get; set; }
        public virtual ICollection<Attendance> AttendanceSignoutSignature { get; set; }
        public virtual ICollection<AttendanceStaging> AttendanceStagingSignInSignature { get; set; }
        public virtual ICollection<AttendanceStaging> AttendanceStagingSignoutSignature { get; set; }
        public virtual ICollection<RollCallQueue> RollCallQueue { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
