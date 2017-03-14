using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class User
    {
        public User()
        {
            Attendance = new HashSet<Attendance>();
            AttendancePortfolio = new HashSet<AttendancePortfolio>();
            AttendanceStaging = new HashSet<AttendanceStaging>();
            Billing = new HashSet<Billing>();
            Booking = new HashSet<Booking>();
            BookingAudit = new HashSet<BookingAudit>();
            BookingTemplateQueue = new HashSet<BookingTemplateQueue>();
            ContactGroup = new HashSet<ContactGroup>();
            DashboardViewHistory = new HashSet<DashboardViewHistory>();
            DefaultBillingDiscount = new HashSet<DefaultBillingDiscount>();
            EventDuration = new HashSet<EventDuration>();
            FavouriteReport = new HashSet<FavouriteReport>();
            ImpersonateUserHistoryImpersonatedByNavigation = new HashSet<ImpersonateUserHistory>();
            ImpersonateUserHistoryImpersonatedUserNavigation = new HashSet<ImpersonateUserHistory>();
            MediaExtension = new HashSet<MediaExtension>();
            MessageHistory = new HashSet<MessageHistory>();
            NotificationInstance = new HashSet<NotificationInstance>();
            NotificationUser = new HashSet<NotificationUser>();
            OrgAcceptedTermsAndConditions = new HashSet<OrgAcceptedTermsAndConditions>();
            OrgUser = new HashSet<OrgUser>();
            OscarCoC = new HashSet<OscarCoC>();
            OscarDeclaration = new HashSet<OscarDeclaration>();
            OscarDelarationChild = new HashSet<OscarDelarationChild>();
            OscarRenewalFormTracking = new HashSet<OscarRenewalFormTracking>();
            OscarTracking = new HashSet<OscarTracking>();
            OscarTrackingChild = new HashSet<OscarTrackingChild>();
            OutgoingMessage = new HashSet<OutgoingMessage>();
            PaymentBatch = new HashSet<PaymentBatch>();
            ProfileNote = new HashSet<ProfileNote>();
            PromoCode = new HashSet<PromoCode>();
            PromoCodeUsage = new HashSet<PromoCodeUsage>();
            QrCode = new HashSet<QrCode>();
            RollOverParent = new HashSet<RollOverParent>();
            SiteProgramTerm = new HashSet<SiteProgramTerm>();
            StaffAvailability = new HashSet<StaffAvailability>();
            StaffClock = new HashSet<StaffClock>();
            StaffRoster = new HashSet<StaffRoster>();
            Subsidy = new HashSet<Subsidy>();
            Timeline = new HashSet<Timeline>();
            TimeSheet = new HashSet<TimeSheet>();
            UserChild = new HashSet<UserChild>();
            UserContact = new HashSet<UserContact>();
            UserDiscount = new HashSet<UserDiscount>();
            UserFavouriteSites = new HashSet<UserFavouriteSites>();
            UserMessage = new HashSet<UserMessage>();
            UserOrgAccess = new HashSet<UserOrgAccess>();
            UserOscarSetting = new HashSet<UserOscarSetting>();
            UserPermission = new HashSet<UserPermission>();
            UserTimelineEvent = new HashSet<UserTimelineEvent>();
            UserTrainingModule = new HashSet<UserTrainingModule>();
            XeroInvoice = new HashSet<XeroInvoice>();
        }

        public int Id { get; set; }
        public long? EwayCustomerId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int? ContactId { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public bool CanLogin { get; set; }
        public string EmailConfirmationToken { get; set; }
        public bool? IsEmailConfirmationValid { get; set; }
        public string PasswordResetToken { get; set; }
        public bool? IsPswResetTokenValid { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime? StaffPayrollLatSyncOn { get; set; }
        public decimal? StaffCostPerHour { get; set; }
        public int? TotalHoursToBeSync { get; set; }
        public string Colour { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string PinCode { get; set; }
        public bool IsOrgAdmin { get; set; }
        public DateTime? WorkStartDate { get; set; }
        public DateTime? WorkEndDate { get; set; }
        public int? CurrentOrgId { get; set; }
        public DateTime? LastLogedOn { get; set; }
        public int? RetryAttempt { get; set; }
        public bool SysAdmin { get; set; }
        public string Title { get; set; }
        public string PasswordBackup { get; set; }
        public string EmployeeId { get; set; }
        public bool? QuickRegistered { get; set; }
        public bool? RequiredPasswordChange { get; set; }
        public bool? IsKpfclient { get; set; }
        public bool? IsAimyClient { get; set; }
        public bool? IsIncompleteProfile { get; set; }
        public bool? ShowFavourites { get; set; }
        public string TimeZoneIdentifier { get; set; }
        public string Culture { get; set; }
        public string Language { get; set; }
        public string ImportReference { get; set; }

        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<AttendancePortfolio> AttendancePortfolio { get; set; }
        public virtual ICollection<AttendanceStaging> AttendanceStaging { get; set; }
        public virtual ICollection<Billing> Billing { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<BookingAudit> BookingAudit { get; set; }
        public virtual ICollection<BookingTemplateQueue> BookingTemplateQueue { get; set; }
        public virtual ICollection<ContactGroup> ContactGroup { get; set; }
        public virtual ICollection<DashboardViewHistory> DashboardViewHistory { get; set; }
        public virtual ICollection<DefaultBillingDiscount> DefaultBillingDiscount { get; set; }
        public virtual ICollection<EventDuration> EventDuration { get; set; }
        public virtual ICollection<FavouriteReport> FavouriteReport { get; set; }
        public virtual ICollection<ImpersonateUserHistory> ImpersonateUserHistoryImpersonatedByNavigation { get; set; }
        public virtual ICollection<ImpersonateUserHistory> ImpersonateUserHistoryImpersonatedUserNavigation { get; set; }
        public virtual ICollection<MediaExtension> MediaExtension { get; set; }
        public virtual ICollection<MessageHistory> MessageHistory { get; set; }
        public virtual ICollection<NotificationInstance> NotificationInstance { get; set; }
        public virtual ICollection<NotificationUser> NotificationUser { get; set; }
        public virtual ICollection<OrgAcceptedTermsAndConditions> OrgAcceptedTermsAndConditions { get; set; }
        public virtual ICollection<OrgUser> OrgUser { get; set; }
        public virtual ICollection<OscarCoC> OscarCoC { get; set; }
        public virtual ICollection<OscarDeclaration> OscarDeclaration { get; set; }
        public virtual ICollection<OscarDelarationChild> OscarDelarationChild { get; set; }
        public virtual ICollection<OscarRenewalFormTracking> OscarRenewalFormTracking { get; set; }
        public virtual ICollection<OscarTracking> OscarTracking { get; set; }
        public virtual ICollection<OscarTrackingChild> OscarTrackingChild { get; set; }
        public virtual ICollection<OutgoingMessage> OutgoingMessage { get; set; }
        public virtual ICollection<PaymentBatch> PaymentBatch { get; set; }
        public virtual ICollection<ProfileNote> ProfileNote { get; set; }
        public virtual ICollection<PromoCode> PromoCode { get; set; }
        public virtual ICollection<PromoCodeUsage> PromoCodeUsage { get; set; }
        public virtual ICollection<QrCode> QrCode { get; set; }
        public virtual ICollection<RollOverParent> RollOverParent { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTerm { get; set; }
        public virtual ICollection<StaffAvailability> StaffAvailability { get; set; }
        public virtual ICollection<StaffClock> StaffClock { get; set; }
        public virtual ICollection<StaffRoster> StaffRoster { get; set; }
        public virtual ICollection<Subsidy> Subsidy { get; set; }
        public virtual ICollection<Timeline> Timeline { get; set; }
        public virtual ICollection<TimeSheet> TimeSheet { get; set; }
        public virtual ICollection<UserChild> UserChild { get; set; }
        public virtual ICollection<UserContact> UserContact { get; set; }
        public virtual ICollection<UserDiscount> UserDiscount { get; set; }
        public virtual ICollection<UserFavouriteSites> UserFavouriteSites { get; set; }
        public virtual ICollection<UserMessage> UserMessage { get; set; }
        public virtual ICollection<UserOrgAccess> UserOrgAccess { get; set; }
        public virtual ICollection<UserOscarSetting> UserOscarSetting { get; set; }
        public virtual ICollection<UserPermission> UserPermission { get; set; }
        public virtual ICollection<UserTimelineEvent> UserTimelineEvent { get; set; }
        public virtual ICollection<UserTrainingModule> UserTrainingModule { get; set; }
        public virtual ICollection<XeroInvoice> XeroInvoice { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual IdentityUser IdNavigation { get; set; }
        public virtual Lookup Role { get; set; }
    }
}
