using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class AchievementTracking
    {
        public int Id { get; set; }
        public int? ChildId { get; set; }
        public int OrgId { get; set; }
        public bool Recruit { get; set; }
        public DateTime? RecruitDate { get; set; }
        public string RecruitNote { get; set; }
        public bool Phase { get; set; }
        public DateTime? PhaseDate { get; set; }
        public string PhaseNote { get; set; }
        public bool FieldPhase { get; set; }
        public DateTime? FieldPhaseDate { get; set; }
        public string FieldPhaseNote { get; set; }
        public bool Navigation { get; set; }
        public DateTime? NavigationDate { get; set; }
        public string NavigationNote { get; set; }
        public bool Ratel { get; set; }
        public DateTime? RatelDate { get; set; }
        public string RatelNote { get; set; }
        public bool FirstAid { get; set; }
        public DateTime? FirstAidDate { get; set; }
        public string FirstAidNote { get; set; }
        public bool Jlc { get; set; }
        public DateTime? JlcDate { get; set; }
        public string JlcNote { get; set; }
        public bool Slc { get; set; }
        public DateTime? SlcDate { get; set; }
        public string SlcNote { get; set; }
        public bool UojuniorLeaderCourse { get; set; }
        public DateTime? UojuniorLeaderCourseDate { get; set; }
        public string UojuniorLeaderCourseNote { get; set; }
        public bool UoseniorLeaderCourse { get; set; }
        public DateTime? UoseniorLeaderCourseDate { get; set; }
        public string UoseniorLeaderCourseNote { get; set; }
        public bool UounderOfficer { get; set; }
        public DateTime? UounderOfficerDate { get; set; }
        public string UounderOfficerNote { get; set; }
        public bool RifleSaftey { get; set; }
        public DateTime? RifleSafteyDate { get; set; }
        public string RifleSafteyNote { get; set; }
        public bool CrossedRifles { get; set; }
        public DateTime? CrossedRiflesDate { get; set; }
        public string CrossedRiflesNote { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string RecruitNote2 { get; set; }
        public string RecruitNote3 { get; set; }
        public bool RecruitCompleted { get; set; }
        public string PhaseNote2 { get; set; }
        public string PhaseNote3 { get; set; }
        public bool PhaseCompleted { get; set; }
        public string FieldPhaseNote2 { get; set; }
        public string FieldPhaseNote3 { get; set; }
        public bool FieldPhaseCompleted { get; set; }
        public string NavigationNote2 { get; set; }
        public string NavigationNote3 { get; set; }
        public bool NavigationCompleted { get; set; }
        public string RatelNote2 { get; set; }
        public string RatelNote3 { get; set; }
        public bool RatelCompleted { get; set; }
        public string FirstAidNote2 { get; set; }
        public string FirstAidNote3 { get; set; }
        public bool FirstAidCompleted { get; set; }
        public string JlcNote2 { get; set; }
        public string JlcNote3 { get; set; }
        public bool JlcCompleted { get; set; }
        public string SlcNote2 { get; set; }
        public string SlcNote3 { get; set; }
        public bool SlcCompleted { get; set; }
        public string UojuniorLeaderCourseNote2 { get; set; }
        public string UojuniorLeaderCourseNote3 { get; set; }
        public bool UojuniorLeaderCourseCompleted { get; set; }
        public string UoseniorLeaderCourseNote2 { get; set; }
        public string UoseniorLeaderCourseNote3 { get; set; }
        public bool UoseniorLeaderCourseCompleted { get; set; }
        public string UounderOfficerNote2 { get; set; }
        public string UounderOfficerNote3 { get; set; }
        public bool UounderOfficerCompleted { get; set; }
        public string RifleSafteyNote2 { get; set; }
        public string RifleSafteyNote3 { get; set; }
        public bool RifleSafteyCompleted { get; set; }
        public string CrossedRiflesNote2 { get; set; }
        public string CrossedRiflesNote3 { get; set; }
        public bool CrossedRiflesCompleted { get; set; }

        public virtual Child Child { get; set; }
        public virtual Org Org { get; set; }
    }
}
