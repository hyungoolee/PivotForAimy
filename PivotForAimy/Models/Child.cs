using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Child
    {
        public Child()
        {
            AchievementTracking = new HashSet<AchievementTracking>();
            ActivityInstanceChild = new HashSet<ActivityInstanceChild>();
            Attendance = new HashSet<Attendance>();
            AttendancePortfolio = new HashSet<AttendancePortfolio>();
            AttendanceStaging = new HashSet<AttendanceStaging>();
            Booking = new HashSet<Booking>();
            BookingTemplateQueueChild = new HashSet<BookingTemplateQueueChild>();
            ChildCondition = new HashSet<ChildCondition>();
            ChildContact = new HashSet<ChildContact>();
            ChildDiscount = new HashSet<ChildDiscount>();
            ChildMedia = new HashSet<ChildMedia>();
            ChildNotes = new HashSet<ChildNotes>();
            ChildOrgGroup = new HashSet<ChildOrgGroup>();
            ChildTimeline = new HashSet<ChildTimeline>();
            ChildTimelineEvent = new HashSet<ChildTimelineEvent>();
            GuardianChild = new HashSet<GuardianChild>();
            OrgChild = new HashSet<OrgChild>();
            OscarDeclaration = new HashSet<OscarDeclaration>();
            OscarDelarationChild = new HashSet<OscarDelarationChild>();
            OscarTrackingChild = new HashSet<OscarTrackingChild>();
            RollCallQueue = new HashSet<RollCallQueue>();
            Subsidy = new HashSet<Subsidy>();
            UserChild = new HashSet<UserChild>();
        }

        public int Id { get; set; }
        public int? ContactId { get; set; }
        public string Name { get; set; }
        public string KnownName { get; set; }
        public int? EmergencyContact1Id { get; set; }
        public int? EmergencyContact2Id { get; set; }
        public int? YearEnrolled { get; set; }
        public string Ethnicity { get; set; }
        public string LanguageSpoken { get; set; }
        public bool? CustodyDispute { get; set; }
        public string CustodyDisputeDescription { get; set; }
        public bool? WearsGlasses { get; set; }
        public bool? HearingAid { get; set; }
        public string Instructions { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public int? SchoolId { get; set; }
        public bool? AllowPhotoTag { get; set; }
        public string ClassRoom { get; set; }
        public string TeacherName { get; set; }
        public bool? Cyf { get; set; }
        public string Cyfdescription { get; set; }
        public bool? IsVegererian { get; set; }
        public bool? GlutenFree { get; set; }
        public string Notes { get; set; }
        public string ChildDoctorName { get; set; }
        public string ChildDoctorContactFixed { get; set; }
        public bool? IsTetanusImmunised { get; set; }
        public string SwimmingCompetency { get; set; }
        public string Subject { get; set; }
        public string Year { get; set; }
        public string ChildDoctorContact { get; set; }

        public virtual ICollection<AchievementTracking> AchievementTracking { get; set; }
        public virtual ICollection<ActivityInstanceChild> ActivityInstanceChild { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<AttendancePortfolio> AttendancePortfolio { get; set; }
        public virtual ICollection<AttendanceStaging> AttendanceStaging { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<BookingTemplateQueueChild> BookingTemplateQueueChild { get; set; }
        public virtual ICollection<ChildCondition> ChildCondition { get; set; }
        public virtual ICollection<ChildContact> ChildContact { get; set; }
        public virtual ICollection<ChildDiscount> ChildDiscount { get; set; }
        public virtual ICollection<ChildMedia> ChildMedia { get; set; }
        public virtual ICollection<ChildNotes> ChildNotes { get; set; }
        public virtual ICollection<ChildOrgGroup> ChildOrgGroup { get; set; }
        public virtual ICollection<ChildTimeline> ChildTimeline { get; set; }
        public virtual ICollection<ChildTimelineEvent> ChildTimelineEvent { get; set; }
        public virtual ICollection<GuardianChild> GuardianChild { get; set; }
        public virtual ICollection<OrgChild> OrgChild { get; set; }
        public virtual ICollection<OscarDeclaration> OscarDeclaration { get; set; }
        public virtual ICollection<OscarDelarationChild> OscarDelarationChild { get; set; }
        public virtual ICollection<OscarTrackingChild> OscarTrackingChild { get; set; }
        public virtual ICollection<RollCallQueue> RollCallQueue { get; set; }
        public virtual ICollection<Subsidy> Subsidy { get; set; }
        public virtual ICollection<UserChild> UserChild { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Contact EmergencyContact1 { get; set; }
        public virtual Contact EmergencyContact2 { get; set; }
        public virtual School School { get; set; }
    }
}
