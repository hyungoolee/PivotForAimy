using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class AttendanceStaging
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public DateTime Day { get; set; }
        public int? SignoutSignatureId { get; set; }
        public int BookingSptId { get; set; }
        public bool HasAttended { get; set; }
        public DateTime BookedStart { get; set; }
        public DateTime BookedEnd { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualEnd { get; set; }
        public string ActualStartKeyedBy { get; set; }
        public DateTime? ActualStartKeyedOn { get; set; }
        public string ActualStartKeyedAt { get; set; }
        public string ActualEndKeyedBy { get; set; }
        public DateTime? ActualEndKeyedOn { get; set; }
        public string ActualEndKeyedAt { get; set; }
        public int? ExtraMins { get; set; }
        public decimal? CostAdjustment { get; set; }
        public decimal? Cost { get; set; }
        public decimal? ActualCost { get; set; }
        public int? ActualCostBy { get; set; }
        public string CostComment { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string SignedBy { get; set; }
        public bool? IsAdjusted { get; set; }
        public bool? IsInvoiced { get; set; }
        public string Status { get; set; }
        public bool? ShouldPickup { get; set; }
        public bool? HasPickedUp { get; set; }
        public DateTime? PickupKeyedOn { get; set; }
        public string PickupKeyedAt { get; set; }
        public string PickupKeyedBy { get; set; }
        public string NoPickUpReason { get; set; }
        public string AbsentReason { get; set; }
        public int? SignInSignatureId { get; set; }
        public bool? IsMarkedAbsent { get; set; }
        public int? SessionId { get; set; }
        public string SessionName { get; set; }
        public string SignedInBy { get; set; }
        public int? DayIndex { get; set; }
        public int? RollCallStatus { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime? ProcessedOn { get; set; }

        public virtual User ActualCostByNavigation { get; set; }
        public virtual BookingSpt BookingSpt { get; set; }
        public virtual Child Child { get; set; }
        public virtual Session Session { get; set; }
        public virtual SignoutSignature SignInSignature { get; set; }
        public virtual SignoutSignature SignoutSignature { get; set; }
    }
}
