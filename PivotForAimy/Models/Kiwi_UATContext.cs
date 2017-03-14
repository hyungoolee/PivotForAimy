using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PivotForAimy.Models
{
    public partial class Kiwi_UATContext : DbContext
    {
        public virtual DbSet<AchievementTracking> AchievementTracking { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<ActivityCondition> ActivityCondition { get; set; }
        public virtual DbSet<ActivityInstance> ActivityInstance { get; set; }
        public virtual DbSet<ActivityInstanceChild> ActivityInstanceChild { get; set; }
        public virtual DbSet<ActivityInstanceCondition> ActivityInstanceCondition { get; set; }
        public virtual DbSet<ActivityInstanceStaff> ActivityInstanceStaff { get; set; }
        public virtual DbSet<ActivityItem> ActivityItem { get; set; }
        public virtual DbSet<AimyAcceptedTermsAndConditions> AimyAcceptedTermsAndConditions { get; set; }
        public virtual DbSet<AimyTermsAndConditions> AimyTermsAndConditions { get; set; }
        public virtual DbSet<AppliedDiscount> AppliedDiscount { get; set; }
        public virtual DbSet<ArchivedInvoiceAttendance> ArchivedInvoiceAttendance { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<AttendancePortfolio> AttendancePortfolio { get; set; }
        public virtual DbSet<AttendanceStaging> AttendanceStaging { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<BatchConfirmedInvoice> BatchConfirmedInvoice { get; set; }
        public virtual DbSet<BatchTimeSheets> BatchTimeSheets { get; set; }
        public virtual DbSet<Billing> Billing { get; set; }
        public virtual DbSet<BillingDiscount> BillingDiscount { get; set; }
        public virtual DbSet<BillingExtra> BillingExtra { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<BookingAudit> BookingAudit { get; set; }
        public virtual DbSet<BookingHistoryLookup> BookingHistoryLookup { get; set; }
        public virtual DbSet<BookingManagerNote> BookingManagerNote { get; set; }
        public virtual DbSet<BookingSpt> BookingSpt { get; set; }
        public virtual DbSet<BookingTemplate> BookingTemplate { get; set; }
        public virtual DbSet<BookingTemplateQueue> BookingTemplateQueue { get; set; }
        public virtual DbSet<BookingTemplateQueueChild> BookingTemplateQueueChild { get; set; }
        public virtual DbSet<BookingTypeRule> BookingTypeRule { get; set; }
        public virtual DbSet<Child> Child { get; set; }
        public virtual DbSet<ChildCondition> ChildCondition { get; set; }
        public virtual DbSet<ChildContact> ChildContact { get; set; }
        public virtual DbSet<ChildContactMedia> ChildContactMedia { get; set; }
        public virtual DbSet<ChildDiscount> ChildDiscount { get; set; }
        public virtual DbSet<ChildDiscountHistoryLookup> ChildDiscountHistoryLookup { get; set; }
        public virtual DbSet<ChildMedia> ChildMedia { get; set; }
        public virtual DbSet<ChildNotes> ChildNotes { get; set; }
        public virtual DbSet<ChildOrgGroup> ChildOrgGroup { get; set; }
        public virtual DbSet<ChildTimeline> ChildTimeline { get; set; }
        public virtual DbSet<ChildTimelineEvent> ChildTimelineEvent { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Condition> Condition { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactGroup> ContactGroup { get; set; }
        public virtual DbSet<CopyDataOptions> CopyDataOptions { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CreditNote> CreditNote { get; set; }
        public virtual DbSet<CreditNoteAllocatedInvoice> CreditNoteAllocatedInvoice { get; set; }
        public virtual DbSet<CreditNoteLineItem> CreditNoteLineItem { get; set; }
        public virtual DbSet<CssBilling> CssBilling { get; set; }
        public virtual DbSet<CssBillingGroup> CssBillingGroup { get; set; }
        public virtual DbSet<CssBillingGroupOrg> CssBillingGroupOrg { get; set; }
        public virtual DbSet<CssBillingPlan> CssBillingPlan { get; set; }
        public virtual DbSet<CssBillingPlan1> CssBillingPlan1 { get; set; }
        public virtual DbSet<CssBillingPlanDetails> CssBillingPlanDetails { get; set; }
        public virtual DbSet<CssBillingPlanDetails1> CssBillingPlanDetails1 { get; set; }
        public virtual DbSet<CssBillingRule> CssBillingRule { get; set; }
        public virtual DbSet<CssBillingRule1> CssBillingRule1 { get; set; }
        public virtual DbSet<CssCreditCardAccessCode> CssCreditCardAccessCode { get; set; }
        public virtual DbSet<CssInvoice> CssInvoice { get; set; }
        public virtual DbSet<CssInvoiceLine> CssInvoiceLine { get; set; }
        public virtual DbSet<CssInvoiceLine1> CssInvoiceLine1 { get; set; }
        public virtual DbSet<CssLookup> CssLookup { get; set; }
        public virtual DbSet<CssLookup1> CssLookup1 { get; set; }
        public virtual DbSet<CssPaymentSetup> CssPaymentSetup { get; set; }
        public virtual DbSet<CssSetting> CssSetting { get; set; }
        public virtual DbSet<CssSubscription> CssSubscription { get; set; }
        public virtual DbSet<CssSysAdminUser> CssSysAdminUser { get; set; }
        public virtual DbSet<DailyAttendance> DailyAttendance { get; set; }
        public virtual DbSet<DashboardMessage> DashboardMessage { get; set; }
        public virtual DbSet<DashboardViewHistory> DashboardViewHistory { get; set; }
        public virtual DbSet<DatabaseChangeHistory> DatabaseChangeHistory { get; set; }
        public virtual DbSet<DefaultBillingDiscount> DefaultBillingDiscount { get; set; }
        public virtual DbSet<DefaultTerm> DefaultTerm { get; set; }
        public virtual DbSet<DeletingInvoiceQueue> DeletingInvoiceQueue { get; set; }
        public virtual DbSet<EventDuration> EventDuration { get; set; }
        public virtual DbSet<ExcludeDay> ExcludeDay { get; set; }
        public virtual DbSet<FavouriteReport> FavouriteReport { get; set; }
        public virtual DbSet<FinancialHistory> FinancialHistory { get; set; }
        public virtual DbSet<FlyerTemplate> FlyerTemplate { get; set; }
        public virtual DbSet<Form> Form { get; set; }
        public virtual DbSet<FormField> FormField { get; set; }
        public virtual DbSet<FormFieldValue> FormFieldValue { get; set; }
        public virtual DbSet<FormInstance> FormInstance { get; set; }
        public virtual DbSet<FormTemplate> FormTemplate { get; set; }
        public virtual DbSet<GuardianChild> GuardianChild { get; set; }
        public virtual DbSet<HeadCount> HeadCount { get; set; }
        public virtual DbSet<HeadCountLine> HeadCountLine { get; set; }
        public virtual DbSet<HolidayFlyerDraft> HolidayFlyerDraft { get; set; }
        public virtual DbSet<IdentityRole> IdentityRole { get; set; }
        public virtual DbSet<IdentityUser> IdentityUser { get; set; }
        public virtual DbSet<IdentityUserClaim> IdentityUserClaim { get; set; }
        public virtual DbSet<IdentityUserDevice> IdentityUserDevice { get; set; }
        public virtual DbSet<IdentityUserLogin> IdentityUserLogin { get; set; }
        public virtual DbSet<IdentityUserRole> IdentityUserRole { get; set; }
        public virtual DbSet<ImpersonateUserHistory> ImpersonateUserHistory { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceExtraCharge> InvoiceExtraCharge { get; set; }
        public virtual DbSet<InvoiceHistory> InvoiceHistory { get; set; }
        public virtual DbSet<InvoiceHistoryLine> InvoiceHistoryLine { get; set; }
        public virtual DbSet<InvoiceLine> InvoiceLine { get; set; }
        public virtual DbSet<InvoicePayment> InvoicePayment { get; set; }
        public virtual DbSet<InvoiceSettingAudit> InvoiceSettingAudit { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LocalPayment> LocalPayment { get; set; }
        public virtual DbSet<Lookup> Lookup { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<MediaExtension> MediaExtension { get; set; }
        public virtual DbSet<MediaLibrary> MediaLibrary { get; set; }
        public virtual DbSet<MediaLibraryChild> MediaLibraryChild { get; set; }
        public virtual DbSet<MediaLibraryMedia> MediaLibraryMedia { get; set; }
        public virtual DbSet<MessageHistory> MessageHistory { get; set; }
        public virtual DbSet<ModifiedAttendanceCost> ModifiedAttendanceCost { get; set; }
        public virtual DbSet<MsdjobConfig> MsdjobConfig { get; set; }
        public virtual DbSet<MsdjobQueue> MsdjobQueue { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<NoteLookup> NoteLookup { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<NotificationInstance> NotificationInstance { get; set; }
        public virtual DbSet<NotificationMobile> NotificationMobile { get; set; }
        public virtual DbSet<NotificationReminder> NotificationReminder { get; set; }
        public virtual DbSet<NotificationUser> NotificationUser { get; set; }
        public virtual DbSet<Org> Org { get; set; }
        public virtual DbSet<OrgAcceptedTermsAndConditions> OrgAcceptedTermsAndConditions { get; set; }
        public virtual DbSet<OrgAccountSoftwareSetting> OrgAccountSoftwareSetting { get; set; }
        public virtual DbSet<OrgBillingSetting> OrgBillingSetting { get; set; }
        public virtual DbSet<OrgChild> OrgChild { get; set; }
        public virtual DbSet<OrgContact> OrgContact { get; set; }
        public virtual DbSet<OrgCssBillingRule> OrgCssBillingRule { get; set; }
        public virtual DbSet<OrgCustomize> OrgCustomize { get; set; }
        public virtual DbSet<OrgDesign> OrgDesign { get; set; }
        public virtual DbSet<OrgEmailBodyTemplate> OrgEmailBodyTemplate { get; set; }
        public virtual DbSet<OrgGroup> OrgGroup { get; set; }
        public virtual DbSet<OrgInvoicingSetting> OrgInvoicingSetting { get; set; }
        public virtual DbSet<OrgMyobSetting> OrgMyobSetting { get; set; }
        public virtual DbSet<OrgNotificationSetting> OrgNotificationSetting { get; set; }
        public virtual DbSet<OrgReference> OrgReference { get; set; }
        public virtual DbSet<OrgReferenceSetting> OrgReferenceSetting { get; set; }
        public virtual DbSet<OrgSetting> OrgSetting { get; set; }
        public virtual DbSet<OrgStandardDiscount> OrgStandardDiscount { get; set; }
        public virtual DbSet<OrgTandC> OrgTandC { get; set; }
        public virtual DbSet<OrgTermsConditions> OrgTermsConditions { get; set; }
        public virtual DbSet<OrgTesting> OrgTesting { get; set; }
        public virtual DbSet<OrgTestingSubscription> OrgTestingSubscription { get; set; }
        public virtual DbSet<OrgTrainingModule> OrgTrainingModule { get; set; }
        public virtual DbSet<OrgUser> OrgUser { get; set; }
        public virtual DbSet<OrgUserNote> OrgUserNote { get; set; }
        public virtual DbSet<OscarCoC> OscarCoC { get; set; }
        public virtual DbSet<OscarDeclaration> OscarDeclaration { get; set; }
        public virtual DbSet<OscarDelarationChild> OscarDelarationChild { get; set; }
        public virtual DbSet<OscarNote> OscarNote { get; set; }
        public virtual DbSet<OscarRenewalFormTracking> OscarRenewalFormTracking { get; set; }
        public virtual DbSet<OscarSetting> OscarSetting { get; set; }
        public virtual DbSet<OscarTracking> OscarTracking { get; set; }
        public virtual DbSet<OscarTrackingChild> OscarTrackingChild { get; set; }
        public virtual DbSet<OutgoingMessage> OutgoingMessage { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentBatch> PaymentBatch { get; set; }
        public virtual DbSet<PaymentSource> PaymentSource { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionUser> PermissionUser { get; set; }
        public virtual DbSet<Pnmessage> Pnmessage { get; set; }
        public virtual DbSet<PnmessageResponseOption> PnmessageResponseOption { get; set; }
        public virtual DbSet<PnmessageUser> PnmessageUser { get; set; }
        public virtual DbSet<Pnqueue> Pnqueue { get; set; }
        public virtual DbSet<PortfolioSetting> PortfolioSetting { get; set; }
        public virtual DbSet<ProfileNote> ProfileNote { get; set; }
        public virtual DbSet<ProfileNoteEntity> ProfileNoteEntity { get; set; }
        public virtual DbSet<ProfileNoteSite> ProfileNoteSite { get; set; }
        public virtual DbSet<Program> Program { get; set; }
        public virtual DbSet<ProgramCategory> ProgramCategory { get; set; }
        public virtual DbSet<ProgramMedia> ProgramMedia { get; set; }
        public virtual DbSet<ProgramSession> ProgramSession { get; set; }
        public virtual DbSet<ProgramTags> ProgramTags { get; set; }
        public virtual DbSet<PromoCode> PromoCode { get; set; }
        public virtual DbSet<PromoCodeUsage> PromoCodeUsage { get; set; }
        public virtual DbSet<PromoMsgTemplate> PromoMsgTemplate { get; set; }
        public virtual DbSet<PublicHoliday> PublicHoliday { get; set; }
        public virtual DbSet<PublishedProgram> PublishedProgram { get; set; }
        public virtual DbSet<QrCode> QrCode { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionOption> QuestionOption { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<ReportPeriod> ReportPeriod { get; set; }
        public virtual DbSet<ReportPeriodSubscription> ReportPeriodSubscription { get; set; }
        public virtual DbSet<ReportSubscriber> ReportSubscriber { get; set; }
        public virtual DbSet<ReportSubscription> ReportSubscription { get; set; }
        public virtual DbSet<RoleTrainingModule> RoleTrainingModule { get; set; }
        public virtual DbSet<RollCallHistory> RollCallHistory { get; set; }
        public virtual DbSet<RollCallQueue> RollCallQueue { get; set; }
        public virtual DbSet<RollOverParent> RollOverParent { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<SchoolContact> SchoolContact { get; set; }
        public virtual DbSet<SchoolOrg> SchoolOrg { get; set; }
        public virtual DbSet<SelectedInvoice> SelectedInvoice { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<SessionDiscount> SessionDiscount { get; set; }
        public virtual DbSet<SignoutSignature> SignoutSignature { get; set; }
        public virtual DbSet<SiteDpsdetail> SiteDpsdetail { get; set; }
        public virtual DbSet<SiteGroup> SiteGroup { get; set; }
        public virtual DbSet<SiteGroupBookingSpt> SiteGroupBookingSpt { get; set; }
        public virtual DbSet<SiteNotes> SiteNotes { get; set; }
        public virtual DbSet<SitePaymentGateway> SitePaymentGateway { get; set; }
        public virtual DbSet<SitePaymentMethod> SitePaymentMethod { get; set; }
        public virtual DbSet<SitePaymentOption> SitePaymentOption { get; set; }
        public virtual DbSet<SiteProgramTerm> SiteProgramTerm { get; set; }
        public virtual DbSet<SptExcludeDays> SptExcludeDays { get; set; }
        public virtual DbSet<SptInstance> SptInstance { get; set; }
        public virtual DbSet<SptSession> SptSession { get; set; }
        public virtual DbSet<SptSiteGroup> SptSiteGroup { get; set; }
        public virtual DbSet<StaffAvailability> StaffAvailability { get; set; }
        public virtual DbSet<StaffClock> StaffClock { get; set; }
        public virtual DbSet<StaffClockSignature> StaffClockSignature { get; set; }
        public virtual DbSet<StaffRoster> StaffRoster { get; set; }
        public virtual DbSet<StaffRosterHistory> StaffRosterHistory { get; set; }
        public virtual DbSet<Subsidy> Subsidy { get; set; }
        public virtual DbSet<SubsidyPayment> SubsidyPayment { get; set; }
        public virtual DbSet<SubsidyPaymentIndex> SubsidyPaymentIndex { get; set; }
        public virtual DbSet<TempManualPayment> TempManualPayment { get; set; }
        public virtual DbSet<Term> Term { get; set; }
        public virtual DbSet<Territory> Territory { get; set; }
        public virtual DbSet<TimeSheet> TimeSheet { get; set; }
        public virtual DbSet<Timeline> Timeline { get; set; }
        public virtual DbSet<TimelineEvent> TimelineEvent { get; set; }
        public virtual DbSet<TimelineEventMedia> TimelineEventMedia { get; set; }
        public virtual DbSet<TmpContact> TmpContact { get; set; }
        public virtual DbSet<TmpImport> TmpImport { get; set; }
        public virtual DbSet<TmpImportCanada> TmpImportCanada { get; set; }
        public virtual DbSet<TmpUserContact> TmpUserContact { get; set; }
        public virtual DbSet<TrainingModule> TrainingModule { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserChild> UserChild { get; set; }
        public virtual DbSet<UserContact> UserContact { get; set; }
        public virtual DbSet<UserDiscount> UserDiscount { get; set; }
        public virtual DbSet<UserDiscountAttendance> UserDiscountAttendance { get; set; }
        public virtual DbSet<UserFavouriteSites> UserFavouriteSites { get; set; }
        public virtual DbSet<UserMessage> UserMessage { get; set; }
        public virtual DbSet<UserOrgAccess> UserOrgAccess { get; set; }
        public virtual DbSet<UserOscarSetting> UserOscarSetting { get; set; }
        public virtual DbSet<UserPermission> UserPermission { get; set; }
        public virtual DbSet<UserTimelineEvent> UserTimelineEvent { get; set; }
        public virtual DbSet<UserTrainingModule> UserTrainingModule { get; set; }
        public virtual DbSet<WaitingList> WaitingList { get; set; }
        public virtual DbSet<XeroAccountCode> XeroAccountCode { get; set; }
        public virtual DbSet<XeroContact> XeroContact { get; set; }
        public virtual DbSet<XeroCreditNoteQueue> XeroCreditNoteQueue { get; set; }
        public virtual DbSet<XeroCssaccountCode> XeroCssaccountCode { get; set; }
        public virtual DbSet<XeroCssinvoiceQueue> XeroCssinvoiceQueue { get; set; }
        public virtual DbSet<XeroCssinvoiceUpdateQueue> XeroCssinvoiceUpdateQueue { get; set; }
        public virtual DbSet<XeroEditBookingQueue> XeroEditBookingQueue { get; set; }
        public virtual DbSet<XeroEditInvoiceQueue> XeroEditInvoiceQueue { get; set; }
        public virtual DbSet<XeroInvErrorQueue> XeroInvErrorQueue { get; set; }
        public virtual DbSet<XeroInvoice> XeroInvoice { get; set; }
        public virtual DbSet<XeroInvoiceLine> XeroInvoiceLine { get; set; }
        public virtual DbSet<XeroInvoiceQueue> XeroInvoiceQueue { get; set; }
        public virtual DbSet<XeroItemCode> XeroItemCode { get; set; }
        public virtual DbSet<XeroLookup> XeroLookup { get; set; }
        public virtual DbSet<XeroPayment> XeroPayment { get; set; }
        public virtual DbSet<XeroPaymentQueue> XeroPaymentQueue { get; set; }
        public virtual DbSet<XeroProcessorState> XeroProcessorState { get; set; }
        public virtual DbSet<XeroSubsidyPaymentQueue> XeroSubsidyPaymentQueue { get; set; }
        public virtual DbSet<XeroTrackingCatOption> XeroTrackingCatOption { get; set; }
        public virtual DbSet<XeroTrackingCategory> XeroTrackingCategory { get; set; }
        public virtual DbSet<XeroTransactionLog> XeroTransactionLog { get; set; }

        // Unable to generate entity type for table 'dbo.Query'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ListIdToDelete'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IntermediateSchool'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SchoolTest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.School_Temporary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.StaffRosterStages'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CssInvoice'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TempShin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AttendanceData'. Please see the warning messages.
        
        public Kiwi_UATContext(DbContextOptions<Kiwi_UATContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=db.centralstationsoftware.co.nz;Initial Catalog=Kiwi-UAT;User ID=internaccess;Password=Centra!123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AchievementTracking>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CrossedRiflesDate).HasColumnType("datetime");

                entity.Property(e => e.CrossedRiflesNote).HasColumnType("varchar(max)");

                entity.Property(e => e.CrossedRiflesNote2).HasColumnType("varchar(max)");

                entity.Property(e => e.CrossedRiflesNote3).HasColumnType("varchar(max)");

                entity.Property(e => e.FieldPhaseDate).HasColumnType("datetime");

                entity.Property(e => e.FieldPhaseNote).HasColumnType("varchar(max)");

                entity.Property(e => e.FieldPhaseNote2).HasColumnType("varchar(max)");

                entity.Property(e => e.FieldPhaseNote3).HasColumnType("varchar(max)");

                entity.Property(e => e.FirstAidDate).HasColumnType("datetime");

                entity.Property(e => e.FirstAidNote).HasColumnType("varchar(max)");

                entity.Property(e => e.FirstAidNote2).HasColumnType("varchar(max)");

                entity.Property(e => e.FirstAidNote3).HasColumnType("varchar(max)");

                entity.Property(e => e.Jlc).HasColumnName("JLc");

                entity.Property(e => e.JlcCompleted).HasColumnName("JLcCompleted");

                entity.Property(e => e.JlcDate)
                    .HasColumnName("JLcDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JlcNote)
                    .HasColumnName("JLcNote")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.JlcNote2)
                    .HasColumnName("JLcNote2")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.JlcNote3)
                    .HasColumnName("JLcNote3")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.NavigationDate).HasColumnType("datetime");

                entity.Property(e => e.NavigationNote).HasColumnType("varchar(max)");

                entity.Property(e => e.NavigationNote2).HasColumnType("varchar(max)");

                entity.Property(e => e.NavigationNote3).HasColumnType("varchar(max)");

                entity.Property(e => e.PhaseDate).HasColumnType("datetime");

                entity.Property(e => e.PhaseNote).HasColumnType("varchar(max)");

                entity.Property(e => e.PhaseNote2).HasColumnType("varchar(max)");

                entity.Property(e => e.PhaseNote3).HasColumnType("varchar(max)");

                entity.Property(e => e.RatelDate).HasColumnType("datetime");

                entity.Property(e => e.RatelNote).HasColumnType("varchar(max)");

                entity.Property(e => e.RatelNote2).HasColumnType("varchar(max)");

                entity.Property(e => e.RatelNote3).HasColumnType("varchar(max)");

                entity.Property(e => e.RecruitDate).HasColumnType("datetime");

                entity.Property(e => e.RecruitNote).HasColumnType("varchar(max)");

                entity.Property(e => e.RecruitNote2).HasColumnType("varchar(max)");

                entity.Property(e => e.RecruitNote3).HasColumnType("varchar(max)");

                entity.Property(e => e.RifleSafteyDate).HasColumnType("datetime");

                entity.Property(e => e.RifleSafteyNote).HasColumnType("varchar(max)");

                entity.Property(e => e.RifleSafteyNote2).HasColumnType("varchar(max)");

                entity.Property(e => e.RifleSafteyNote3).HasColumnType("varchar(max)");

                entity.Property(e => e.Slc).HasColumnName("SLc");

                entity.Property(e => e.SlcCompleted).HasColumnName("SLcCompleted");

                entity.Property(e => e.SlcDate)
                    .HasColumnName("SLcDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SlcNote)
                    .HasColumnName("SLcNote")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.SlcNote2)
                    .HasColumnName("SLcNote2")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.SlcNote3)
                    .HasColumnName("SLcNote3")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UojuniorLeaderCourse).HasColumnName("UOJuniorLeaderCourse");

                entity.Property(e => e.UojuniorLeaderCourseCompleted).HasColumnName("UOJuniorLeaderCourseCompleted");

                entity.Property(e => e.UojuniorLeaderCourseDate)
                    .HasColumnName("UOJuniorLeaderCourseDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UojuniorLeaderCourseNote)
                    .HasColumnName("UOJuniorLeaderCourseNote")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UojuniorLeaderCourseNote2)
                    .HasColumnName("UOJuniorLeaderCourseNote2")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UojuniorLeaderCourseNote3)
                    .HasColumnName("UOJuniorLeaderCourseNote3")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UoseniorLeaderCourse).HasColumnName("UOSeniorLeaderCourse");

                entity.Property(e => e.UoseniorLeaderCourseCompleted).HasColumnName("UOSeniorLeaderCourseCompleted");

                entity.Property(e => e.UoseniorLeaderCourseDate)
                    .HasColumnName("UOSeniorLeaderCourseDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UoseniorLeaderCourseNote)
                    .HasColumnName("UOSeniorLeaderCourseNote")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UoseniorLeaderCourseNote2)
                    .HasColumnName("UOSeniorLeaderCourseNote2")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UoseniorLeaderCourseNote3)
                    .HasColumnName("UOSeniorLeaderCourseNote3")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UounderOfficer).HasColumnName("UOUnderOfficer");

                entity.Property(e => e.UounderOfficerCompleted).HasColumnName("UOUnderOfficerCompleted");

                entity.Property(e => e.UounderOfficerDate)
                    .HasColumnName("UOUnderOfficerDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UounderOfficerNote)
                    .HasColumnName("UOUnderOfficerNote")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UounderOfficerNote2)
                    .HasColumnName("UOUnderOfficerNote2")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UounderOfficerNote3)
                    .HasColumnName("UOUnderOfficerNote3")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.AchievementTracking)
                    .HasForeignKey(d => d.ChildId)
                    .HasConstraintName("FK_AchievementTracking_Child");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AchievementTracking)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AchievementTracking_Org");
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.Property(e => e.Budget).HasColumnType("decimal");

                entity.Property(e => e.CostPerChild).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.Instruction).HasMaxLength(2048);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Review).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Activity_Lookup");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_Activity_Org");
            });

            modelBuilder.Entity<ActivityCondition>(entity =>
            {
                entity.ToTable("Activity_Condition");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityCondition)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Activity_Condition_Activity");

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.ActivityCondition)
                    .HasForeignKey(d => d.ConditionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Activity_Condition_Condition");
            });

            modelBuilder.Entity<ActivityInstance>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecurrenceType).HasMaxLength(50);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityInstance)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityInstance_Activity");

                entity.HasOne(d => d.SiteGroup)
                    .WithMany(p => p.ActivityInstance)
                    .HasForeignKey(d => d.SiteGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityInstance_SiteGroup");

                entity.HasOne(d => d.Spt)
                    .WithMany(p => p.ActivityInstance)
                    .HasForeignKey(d => d.SptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityInstance_Site_Program_Term");
            });

            modelBuilder.Entity<ActivityInstanceChild>(entity =>
            {
                entity.ToTable("ActivityInstance_Child");

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ActivityInstance)
                    .WithMany(p => p.ActivityInstanceChild)
                    .HasForeignKey(d => d.ActivityInstanceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityInstance_Attendance_ActivityInstance");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.ActivityInstanceChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityInstance_Child_Child");
            });

            modelBuilder.Entity<ActivityInstanceCondition>(entity =>
            {
                entity.ToTable("ActivityInstance_Condition");

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ActivityInstance)
                    .WithMany(p => p.ActivityInstanceCondition)
                    .HasForeignKey(d => d.ActivityInstanceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityInstance_Condition_ActivityInstance");

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.ActivityInstanceCondition)
                    .HasForeignKey(d => d.ConditionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityInstance_Condition_Condition");
            });

            modelBuilder.Entity<ActivityInstanceStaff>(entity =>
            {
                entity.ToTable("ActivityInstance_Staff");

                entity.Property(e => e.Comment).HasMaxLength(150);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ActivityInstance)
                    .WithMany(p => p.ActivityInstanceStaff)
                    .HasForeignKey(d => d.ActivityInstanceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityInstance_Staff_ActivityInstance");

                entity.HasOne(d => d.Roster)
                    .WithMany(p => p.ActivityInstanceStaff)
                    .HasForeignKey(d => d.RosterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityInstance_Staff_StaffRoster");
            });

            modelBuilder.Entity<ActivityItem>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Verson)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityItem)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityItem_Activity");

                entity.HasOne(d => d.ItemTypeNavigation)
                    .WithMany(p => p.ActivityItem)
                    .HasForeignKey(d => d.ItemType)
                    .HasConstraintName("FK_ActivityItem_Lookup");
            });

            modelBuilder.Entity<AimyAcceptedTermsAndConditions>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EntityType).HasColumnType("varchar(50)");

                entity.Property(e => e.TandCid).HasColumnName("TandCId");

                entity.HasOne(d => d.TandC)
                    .WithMany(p => p.AimyAcceptedTermsAndConditions)
                    .HasForeignKey(d => d.TandCid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Accepted_TermsAndConditions_AimyTermsAndConditions");
            });

            modelBuilder.Entity<AimyTermsAndConditions>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TermsAndConditions).HasColumnType("varchar(max)");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppliedDiscount>(entity =>
            {
                entity.Property(e => e.BookingSptId).HasColumnName("Booking_SptId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountLogicType).HasMaxLength(50);

                entity.Property(e => e.DiscountType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountedRate).HasColumnType("decimal");

                entity.Property(e => e.TotalAppliedAmount).HasColumnType("decimal");

                entity.Property(e => e.TotalAppliedPercentage).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BookingSpt)
                    .WithMany(p => p.AppliedDiscount)
                    .HasForeignKey(d => d.BookingSptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AppliedDiscount_Booking_Spt");

                entity.HasOne(d => d.ChildDiscount)
                    .WithMany(p => p.AppliedDiscount)
                    .HasForeignKey(d => d.ChildDiscountId)
                    .HasConstraintName("FK_AppliedDiscount_ChildDiscount");
            });

            modelBuilder.Entity<ArchivedInvoiceAttendance>(entity =>
            {
                entity.Property(e => e.ActualEnd).HasColumnType("datetime");

                entity.Property(e => e.ActualMin).HasColumnType("decimal");

                entity.Property(e => e.ActualStart).HasColumnType("datetime");

                entity.Property(e => e.BookedEnd).HasColumnType("datetime");

                entity.Property(e => e.BookedStart).HasColumnType("datetime");

                entity.Property(e => e.ChargedMin).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal");

                entity.Property(e => e.FinalCost).HasColumnType("decimal");

                entity.Property(e => e.OriginalCost).HasColumnType("decimal");

                entity.Property(e => e.ProgramName).IsRequired();
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasIndex(e => e.BookingSptId)
                    .HasName("IDX_Attendence_BookingSptId");

                entity.HasIndex(e => e.Status)
                    .HasName("IDX_Attendence_Status");

                entity.HasIndex(e => new { e.BookingSptId, e.Day })
                    .HasName("GetBookingListInTermIndex1");

                entity.HasIndex(e => new { e.ChildId, e.Day, e.BookingSptId })
                    .HasName("NonClusteredIndex-20150716-200058");

                entity.HasIndex(e => new { e.BookingSptId, e.Day, e.HasAttended, e.IsActive })
                    .HasName("SignIn");

                entity.HasIndex(e => new { e.BookingSptId, e.Day, e.IsActive, e.IsMarkedAbsent })
                    .HasName("DailySummary2");

                entity.HasIndex(e => new { e.BookingSptId, e.ChildId, e.Day, e.IsActive, e.ShouldPickup })
                    .HasName("DriverPickup");

                entity.HasIndex(e => new { e.BookingSptId, e.ChildId, e.Day, e.HasAttended, e.IsActive, e.AbsentReason })
                    .HasName("SignInChildList");

                entity.HasIndex(e => new { e.BookingSptId, e.ChildId, e.Day, e.IsActive, e.ShouldPickup, e.HasPickedUp })
                    .HasName("DriverPickupSiteList");

                entity.HasIndex(e => new { e.AbsentReason, e.BookingSptId, e.Day, e.Description, e.HasAttended, e.Id, e.NoPickUpReason, e.ChildId, e.IsActive })
                    .HasName("DailySummary1");

                entity.HasIndex(e => new { e.ActualEnd, e.ActualStart, e.BookedEnd, e.BookedStart, e.BookingSptId, e.ChildId, e.CostAdjustment, e.CostComment, e.HasAttended, e.Id, e.IsActive, e.Status, e.Day })
                    .HasName("BookingRecBilling");

                entity.HasIndex(e => new { e.AbsentReason, e.ActualEnd, e.ActualStart, e.BookedEnd, e.BookedStart, e.BookingSptId, e.ChildId, e.Description, e.HasAttended, e.HasPickedUp, e.Id, e.IsMarkedAbsent, e.NoPickUpReason, e.SessionId, e.SessionName, e.SignedBy, e.SignedInBy, e.Day, e.IsActive })
                    .HasName("IDX_DayActive");

                entity.HasIndex(e => new { e.AbsentReason, e.ActualEnd, e.ActualEndKeyedBy, e.ActualEndKeyedOn, e.ActualStart, e.ActualStartKeyedBy, e.ActualStartKeyedOn, e.BookedEnd, e.BookedStart, e.BookingSptId, e.ChildId, e.DayIndex, e.Description, e.HasAttended, e.HasPickedUp, e.Id, e.IsMarkedAbsent, e.NoPickUpReason, e.RollCallStatus, e.SessionId, e.SessionName, e.SignedBy, e.SignedInBy, e.SignInSignatureId, e.SignoutSignatureId, e.Day, e.IsActive })
                    .HasName("Idx_DayIsActiveInc");

                entity.Property(e => e.AbsentReason).HasMaxLength(250);

                entity.Property(e => e.ActualCost).HasColumnType("decimal");

                entity.Property(e => e.ActualEnd).HasColumnType("datetime");

                entity.Property(e => e.ActualEndKeyedAt).HasColumnType("varchar(50)");

                entity.Property(e => e.ActualEndKeyedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.ActualEndKeyedOn).HasColumnType("datetime");

                entity.Property(e => e.ActualStart).HasColumnType("datetime");

                entity.Property(e => e.ActualStartKeyedAt).HasColumnType("varchar(50)");

                entity.Property(e => e.ActualStartKeyedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.ActualStartKeyedOn).HasColumnType("datetime");

                entity.Property(e => e.BookedEnd).HasColumnType("datetime");

                entity.Property(e => e.BookedStart).HasColumnType("datetime");

                entity.Property(e => e.BookingSptId).HasColumnName("Booking_SptId");

                entity.Property(e => e.Cost).HasColumnType("decimal");

                entity.Property(e => e.CostAdjustment).HasColumnType("decimal");

                entity.Property(e => e.CostComment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Day).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.NoPickUpReason).HasMaxLength(250);

                entity.Property(e => e.PickupKeyedAt).HasMaxLength(250);

                entity.Property(e => e.PickupKeyedBy).HasMaxLength(250);

                entity.Property(e => e.PickupKeyedOn).HasColumnType("datetime");

                entity.Property(e => e.SessionName).HasMaxLength(100);

                entity.Property(e => e.SignInNote).HasMaxLength(255);

                entity.Property(e => e.SignOutNote).HasMaxLength(255);

                entity.Property(e => e.SignedBy).HasMaxLength(255);

                entity.Property(e => e.SignedInBy).HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ActualCostByNavigation)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.ActualCostBy)
                    .HasConstraintName("FK_Attendance_User");

                entity.HasOne(d => d.BookingSpt)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.BookingSptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Attendance_Booking_Spt");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Booking_Child");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_Attendance_Session");

                entity.HasOne(d => d.SignInSignature)
                    .WithMany(p => p.AttendanceSignInSignature)
                    .HasForeignKey(d => d.SignInSignatureId)
                    .HasConstraintName("FK_Attendance_SignoutSignature1");

                entity.HasOne(d => d.SignoutSignature)
                    .WithMany(p => p.AttendanceSignoutSignature)
                    .HasForeignKey(d => d.SignoutSignatureId)
                    .HasConstraintName("FK_Attendance_SignoutSignature");
            });

            modelBuilder.Entity<AttendancePortfolio>(entity =>
            {
                entity.ToTable("Attendance_Portfolio");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Attendance)
                    .WithMany(p => p.AttendancePortfolio)
                    .HasForeignKey(d => d.AttendanceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Attendance_Portfolio_Attendance");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.AttendancePortfolio)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Attendance_Portfolio_Child");

                entity.HasOne(d => d.PortfolioSetting)
                    .WithMany(p => p.AttendancePortfolio)
                    .HasForeignKey(d => d.PortfolioSettingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Attendance_Portfolio_PortfolioSetting");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AttendancePortfolio)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Attendance_Portfolio_User");
            });

            modelBuilder.Entity<AttendanceStaging>(entity =>
            {
                entity.HasIndex(e => e.IsProcessed)
                    .HasName("NonClusteredIndex-20160725-213229");

                entity.Property(e => e.AbsentReason).HasMaxLength(250);

                entity.Property(e => e.ActualCost).HasColumnType("decimal");

                entity.Property(e => e.ActualEnd).HasColumnType("datetime");

                entity.Property(e => e.ActualEndKeyedAt).HasColumnType("varchar(50)");

                entity.Property(e => e.ActualEndKeyedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.ActualEndKeyedOn).HasColumnType("datetime");

                entity.Property(e => e.ActualStart).HasColumnType("datetime");

                entity.Property(e => e.ActualStartKeyedAt).HasColumnType("varchar(50)");

                entity.Property(e => e.ActualStartKeyedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.ActualStartKeyedOn).HasColumnType("datetime");

                entity.Property(e => e.BookedEnd).HasColumnType("datetime");

                entity.Property(e => e.BookedStart).HasColumnType("datetime");

                entity.Property(e => e.BookingSptId).HasColumnName("Booking_SptId");

                entity.Property(e => e.Cost).HasColumnType("decimal");

                entity.Property(e => e.CostAdjustment).HasColumnType("decimal");

                entity.Property(e => e.CostComment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Day).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.NoPickUpReason).HasMaxLength(250);

                entity.Property(e => e.PickupKeyedAt).HasMaxLength(250);

                entity.Property(e => e.PickupKeyedBy).HasMaxLength(250);

                entity.Property(e => e.PickupKeyedOn).HasColumnType("datetime");

                entity.Property(e => e.ProcessedOn).HasColumnType("datetime");

                entity.Property(e => e.SessionName).HasMaxLength(100);

                entity.Property(e => e.SignedBy).HasMaxLength(255);

                entity.Property(e => e.SignedInBy).HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ActualCostByNavigation)
                    .WithMany(p => p.AttendanceStaging)
                    .HasForeignKey(d => d.ActualCostBy)
                    .HasConstraintName("FK_AttendanceStaging_User");

                entity.HasOne(d => d.BookingSpt)
                    .WithMany(p => p.AttendanceStaging)
                    .HasForeignKey(d => d.BookingSptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AttendanceStaging_Booking_Spt");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.AttendanceStaging)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AttendanceStaging_Booking_Child");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.AttendanceStaging)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_AttendanceStaging_Session");

                entity.HasOne(d => d.SignInSignature)
                    .WithMany(p => p.AttendanceStagingSignInSignature)
                    .HasForeignKey(d => d.SignInSignatureId)
                    .HasConstraintName("FK_AttendanceStaging_SignoutSignature1");

                entity.HasOne(d => d.SignoutSignature)
                    .WithMany(p => p.AttendanceStagingSignoutSignature)
                    .HasForeignKey(d => d.SignoutSignatureId)
                    .HasConstraintName("FK_AttendanceStaging_SignoutSignature");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.Property(e => e.Caller)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.XmlNew).HasColumnType("xml");

                entity.Property(e => e.XmlOld).HasColumnType("xml");
            });

            modelBuilder.Entity<BatchConfirmedInvoice>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.BatchConfirmedInvoice)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BatchConfirmedInvoice_Billing");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.BatchConfirmedInvoice)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BatchConfirmedInvoice_Invoice");
            });

            modelBuilder.Entity<BatchTimeSheets>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.BatchTimeSheets)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BatchTimeSheets_Org1");
            });

            modelBuilder.Entity<Billing>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.BookingTemplateId })
                    .HasName("IDX_Billing_BookingTemplateId");

                entity.HasIndex(e => new { e.Id, e.SiteId, e.TermId, e.UserId, e.HasSentToXero, e.IsActive })
                    .HasName("GetOutStandingInvoicesIndex1");

                entity.HasIndex(e => new { e.BookingTemplateId, e.ByTemplateQueueId, e.CreatedBy, e.CreatedOn, e.Description, e.EstimatedCost, e.EstimatedOscar, e.ExtraLineType, e.FinalCost, e.HasSentToXero, e.Id, e.IsInvFreqChanged, e.IsMadeFromTemplate, e.IsQuickBooked, e.IsRollOvered, e.Name, e.OriginalCost, e.OscarIntended, e.ParentNotes, e.PaymentOptionId, e.PromoAmount, e.PromoCodeId, e.PromoPercentage, e.RollOverIntended, e.TermId, e.TotalExtraInvLineAmount, e.UpdatedBy, e.UpdatedOn, e.UserId, e.Version, e.SiteId, e.IsActive })
                    .HasName("IDX_BillingSiteActive");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EstimatedCost).HasColumnType("decimal");

                entity.Property(e => e.EstimatedOscar).HasColumnType("decimal");

                entity.Property(e => e.ExtraLineType).HasMaxLength(50);

                entity.Property(e => e.FinalCost).HasColumnType("decimal");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.OriginalCost).HasColumnType("decimal");

                entity.Property(e => e.PromoAmount).HasColumnType("decimal");

                entity.Property(e => e.PromoPercentage).HasColumnType("decimal");

                entity.Property(e => e.TotalExtraInvLineAmount).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BookingTemplate)
                    .WithMany(p => p.Billing)
                    .HasForeignKey(d => d.BookingTemplateId)
                    .HasConstraintName("FK_Billing_BookingTemplate");

                entity.HasOne(d => d.ByTemplateQueue)
                    .WithMany(p => p.Billing)
                    .HasForeignKey(d => d.ByTemplateQueueId)
                    .HasConstraintName("FK_Billing_BookingTemplateQueue");

                entity.HasOne(d => d.PaymentOption)
                    .WithMany(p => p.Billing)
                    .HasForeignKey(d => d.PaymentOptionId)
                    .HasConstraintName("FK_Billing_Lookup");

                entity.HasOne(d => d.PromoCode)
                    .WithMany(p => p.Billing)
                    .HasForeignKey(d => d.PromoCodeId)
                    .HasConstraintName("FK_Billing_PromoCode");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Billing)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Billing_Org");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.Billing)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_Billing_Term");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Billing)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Billing_User");
            });

            modelBuilder.Entity<BillingDiscount>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.PeriodStart).HasColumnType("datetime");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.BillingDiscount)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BillingDiscount_Billing");
            });

            modelBuilder.Entity<BillingExtra>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.PaymentFrequency)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.PeriodStart).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.BillingExtra)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BillingExtra_Billing");

                entity.HasOne(d => d.ItemCode)
                    .WithMany(p => p.BillingExtra)
                    .HasForeignKey(d => d.ItemCodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BillingExtra_XeroItemCode");

                entity.HasOne(d => d.TrackingCatOpt)
                    .WithMany(p => p.BillingExtra)
                    .HasForeignKey(d => d.TrackingCatOptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BillingExtra_XeroTrackingCatOption");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasIndex(e => e.BillingId)
                    .HasName("BookingBillingIdIndex");

                entity.HasIndex(e => e.ChildId)
                    .HasName("IdxBookingChildId");

                entity.HasIndex(e => new { e.BillingId, e.Status })
                    .HasName("IDX_Booking_BillingIdActive");

                entity.HasIndex(e => new { e.GuardianId, e.SiteId })
                    .HasName("BookingGurdianIdSiteIdIndex");

                entity.HasIndex(e => new { e.BillingId, e.SiteId, e.Status, e.IsActive })
                    .HasName("IDX_Booking_BookingManager");

                entity.HasIndex(e => new { e.GuardianId, e.Id, e.SiteId, e.Status })
                    .HasName("IDX_BookingStatus");

                entity.HasIndex(e => new { e.BillingId, e.Id, e.SiteId, e.Status, e.WhenBooked })
                    .HasName("IndexBookingSSw");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.WhenBooked).HasColumnType("datetime");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Booking_Billing");

                entity.HasOne(d => d.BookingType)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.BookingTypeId)
                    .HasConstraintName("FK_Booking_Lookup");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Booking_Child1");

                entity.HasOne(d => d.Guardian)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.GuardianId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Booking_User");

                entity.HasOne(d => d.ItemCode)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.ItemCodeId)
                    .HasConstraintName("FK_Booking_XeroItemCode");

                entity.HasOne(d => d.ProgramCategory)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.ProgramCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Booking_ProgramCategory");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Booking_Org");

                entity.HasOne(d => d.TrackingCatOpt)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.TrackingCatOptId)
                    .HasConstraintName("FK_Booking_XeroTrackingCatOption");
            });

            modelBuilder.Entity<BookingAudit>(entity =>
            {
                entity.HasIndex(e => new { e.BillingId, e.Caller, e.CreatedOn })
                    .HasName("IDX_BookingAudit");

                entity.Property(e => e.Caller)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.XmlNew).HasColumnType("xml");

                entity.Property(e => e.XmlOld).HasColumnType("xml");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.BookingAudit)
                    .HasForeignKey(d => d.BillingId)
                    .HasConstraintName("FK_BookingAudit_Billing");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.BookingAudit)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingAudit_User");
            });

            modelBuilder.Entity<BookingHistoryLookup>(entity =>
            {
                entity.Property(e => e.CallerName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<BookingManagerNote>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.BookingManagerNote)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingManagerNote_Billing");
            });

            modelBuilder.Entity<BookingSpt>(entity =>
            {
                entity.ToTable("Booking_Spt");

                entity.HasIndex(e => new { e.BookingId, e.Id, e.SptId })
                    .HasName("GetRollSheetsIndex1");

                entity.HasIndex(e => new { e.Id, e.ItemCodeId, e.SptId, e.TrackingCodeId, e.BookingId })
                    .HasName("Booking_SptIndex1");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.BookingSpt)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK_Booking_Spt_Booking");

                entity.HasOne(d => d.ItemCode)
                    .WithMany(p => p.BookingSpt)
                    .HasForeignKey(d => d.ItemCodeId)
                    .HasConstraintName("FK_Booking_Spt_XeroItemCode");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.BookingSpt)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_Booking_Spt_Session");

                entity.HasOne(d => d.Spt)
                    .WithMany(p => p.BookingSpt)
                    .HasForeignKey(d => d.SptId)
                    .HasConstraintName("FK_Booking_Spt_Site_Program_Term");

                entity.HasOne(d => d.TrackingCode)
                    .WithMany(p => p.BookingSpt)
                    .HasForeignKey(d => d.TrackingCodeId)
                    .HasConstraintName("FK_Booking_Spt_XeroTrackingCatOption");
            });

            modelBuilder.Entity<BookingTemplate>(entity =>
            {
                entity.Property(e => e.Cost).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SptInstanceId).HasColumnName("Spt_InstanceId");

                entity.Property(e => e.Term).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.BookingTemplate)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingTemplate_Org");
            });

            modelBuilder.Entity<BookingTemplateQueue>(entity =>
            {
                entity.HasIndex(e => e.IsProcessed)
                    .HasName("NonClusteredIndex-20170125-105508");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ProcessedOn).HasColumnType("datetime");

                entity.HasOne(d => d.BookingTemplate)
                    .WithMany(p => p.BookingTemplateQueue)
                    .HasForeignKey(d => d.BookingTemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingTemplateQueue_BookingTemplate");

                entity.HasOne(d => d.PaymentOption)
                    .WithMany(p => p.BookingTemplateQueue)
                    .HasForeignKey(d => d.PaymentOptionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingTemplateQueue_Lookup");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BookingTemplateQueue)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingTemplateQueue_User");
            });

            modelBuilder.Entity<BookingTemplateQueueChild>(entity =>
            {
                entity.ToTable("BookingTemplateQueue_Child");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.BookingTemplateQueue)
                    .WithMany(p => p.BookingTemplateQueueChild)
                    .HasForeignKey(d => d.BookingTemplateQueueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingTemplateQueue_Child_BookingTemplateQueue");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.BookingTemplateQueueChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingTemplateQueue_Child_Child");
            });

            modelBuilder.Entity<BookingTypeRule>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BookingType)
                    .WithMany(p => p.BookingTypeRule)
                    .HasForeignKey(d => d.BookingTypeId)
                    .HasConstraintName("FK_BookingTypeRule_Lookup");
            });

            modelBuilder.Entity<Child>(entity =>
            {
                entity.Property(e => e.ChildDoctorContact).HasMaxLength(50);

                entity.Property(e => e.ChildDoctorContactFixed).HasMaxLength(50);

                entity.Property(e => e.ChildDoctorName).HasMaxLength(100);

                entity.Property(e => e.ClassRoom).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cyf).HasColumnName("CYF");

                entity.Property(e => e.Cyfdescription).HasColumnName("CYFDescription");

                entity.Property(e => e.Ethnicity).HasMaxLength(50);

                entity.Property(e => e.KnownName).HasMaxLength(50);

                entity.Property(e => e.LanguageSpoken).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.SwimmingCompetency).HasColumnType("varchar(50)");

                entity.Property(e => e.TeacherName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Year).HasMaxLength(50);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ChildContact)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Child_Contact");

                entity.HasOne(d => d.EmergencyContact1)
                    .WithMany(p => p.ChildEmergencyContact1)
                    .HasForeignKey(d => d.EmergencyContact1Id)
                    .HasConstraintName("FK_Child_EmergencyContact1");

                entity.HasOne(d => d.EmergencyContact2)
                    .WithMany(p => p.ChildEmergencyContact2)
                    .HasForeignKey(d => d.EmergencyContact2Id)
                    .HasConstraintName("FK_Child_EmergencyContact2");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Child)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Child_School");
            });

            modelBuilder.Entity<ChildCondition>(entity =>
            {
                entity.ToTable("Child_Condition");

                entity.HasIndex(e => new { e.ConditionId, e.MedicationDesc, e.Severity, e.Symptoms, e.TreatmentDesc, e.ChildId })
                    .HasName("IDX_Child_ConditionChildId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DoctorContact).HasMaxLength(50);

                entity.Property(e => e.DoctorName).HasMaxLength(50);

                entity.Property(e => e.Severity).HasMaxLength(50);

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.ChildCondition)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Child_Condition_Child");

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.ChildCondition)
                    .HasForeignKey(d => d.ConditionId)
                    .HasConstraintName("FK_Child_Condition_Condition");
            });

            modelBuilder.Entity<ChildContact>(entity =>
            {
                entity.ToTable("Child_Contact");

                entity.HasIndex(e => new { e.CanPickup, e.ContactId, e.ChildId })
                    .HasName("IDX_Child_ContactContactIdCanPickup");

                entity.Property(e => e.ActionOnAppear).HasMaxLength(500);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CyfsInformation).HasColumnName("CYFsInformation");

                entity.Property(e => e.IsCyfs).HasColumnName("IsCYFs");

                entity.Property(e => e.PinCode).HasMaxLength(50);

                entity.Property(e => e.Relation).HasMaxLength(500);

                entity.Property(e => e.SocialWorkerId).HasMaxLength(250);

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.ChildContact)
                    .HasForeignKey(d => d.ChildId)
                    .HasConstraintName("FK_Child_Contact_Child");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ChildContactNavigation)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Child_Contact_Contact");
            });

            modelBuilder.Entity<ChildContactMedia>(entity =>
            {
                entity.ToTable("ChildContact_Media");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ChildContact)
                    .WithMany(p => p.ChildContactMedia)
                    .HasForeignKey(d => d.ChildContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ChildCont__Child__42397A36");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.ChildContactMedia)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ChildCont__Media__432D9E6F");
            });

            modelBuilder.Entity<ChildDiscount>(entity =>
            {
                entity.Property(e => e.CasualRate).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FullTimeRate).HasColumnType("decimal");

                entity.Property(e => e.PartTimeRate).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.ChildDiscount)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ChildDiscount_Child");

                entity.HasOne(d => d.ProgramCateogry)
                    .WithMany(p => p.ChildDiscount)
                    .HasForeignKey(d => d.ProgramCateogryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ChildDiscount_ProgramCategory");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ChildDiscount)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_ChildDiscount_Program");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ChildDiscount)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ChildDiscount_Org");
            });

            modelBuilder.Entity<ChildDiscountHistoryLookup>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.ChildDiscountHistoryLookup)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ChildDiscountHistoryLookup_Billing");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.ChildDiscountHistoryLookup)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ChildDiscountHistoryLookup_Booking");

                entity.HasOne(d => d.ChildDisc)
                    .WithMany(p => p.ChildDiscountHistoryLookup)
                    .HasForeignKey(d => d.ChildDiscId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ChildDiscountHistoryLookup_ChildDiscount");

                entity.HasOne(d => d.InvoiceLine)
                    .WithMany(p => p.ChildDiscountHistoryLookup)
                    .HasForeignKey(d => d.InvoiceLineId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ChildDiscountHistoryLookup_InvoiceLine");
            });

            modelBuilder.Entity<ChildMedia>(entity =>
            {
                entity.ToTable("Child_Media");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.ChildMedia)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Child_Media_Child");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.ChildMedia)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Child_Media_Media");
            });

            modelBuilder.Entity<ChildNotes>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Note).HasColumnType("varchar(max)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.ChildNotes)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ChildNotes_Child");
            });

            modelBuilder.Entity<ChildOrgGroup>(entity =>
            {
                entity.ToTable("Child_OrgGroup");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.ChildOrgGroup)
                    .HasForeignKey(d => d.ChildId)
                    .HasConstraintName("FK_Child_OrgGroup_Child");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ChildOrgGroup)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Child_OrgGroup_OrgGroup");
            });

            modelBuilder.Entity<ChildTimeline>(entity =>
            {
                entity.ToTable("Child_Timeline");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.ChildTimeline)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Child_Timeline_Child");

                entity.HasOne(d => d.Timeline)
                    .WithMany(p => p.ChildTimeline)
                    .HasForeignKey(d => d.TimelineId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Child_Timeline_Timeline");
            });

            modelBuilder.Entity<ChildTimelineEvent>(entity =>
            {
                entity.ToTable("Child_TimelineEvent");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.ChildTimelineEvent)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Child_TimelineEvent_Child");

                entity.HasOne(d => d.Timeline)
                    .WithMany(p => p.ChildTimelineEvent)
                    .HasForeignKey(d => d.TimelineId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Child_TimelineEvent_TimelineEvent");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_City_Country");
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("varchar(500)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Treatment).HasColumnType("varchar(max)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.Email })
                    .HasName("IDX_Contact_Email");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.BillingAddress).HasMaxLength(500);

                entity.Property(e => e.BillingCity).HasMaxLength(50);

                entity.Property(e => e.BillingCountry).HasMaxLength(50);

                entity.Property(e => e.BillingPostcode).HasMaxLength(50);

                entity.Property(e => e.BillingStreetNum).HasMaxLength(50);

                entity.Property(e => e.BillingSuburb).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DriverLicence).HasColumnType("varchar(50)");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FaxFixed).HasMaxLength(50);

                entity.Property(e => e.FirstAidExpireyDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HowHear).HasMaxLength(50);

                entity.Property(e => e.Landline).HasMaxLength(50);

                entity.Property(e => e.LandlineFixed).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Lat).HasColumnType("varchar(50)");

                entity.Property(e => e.Lng).HasColumnType("varchar(50)");

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.MobileFixed).HasMaxLength(50);

                entity.Property(e => e.Notes).HasColumnType("varchar(max)");

                entity.Property(e => e.Office).HasMaxLength(50);

                entity.Property(e => e.OfficeExtension).HasMaxLength(50);

                entity.Property(e => e.OfficeFixed).HasMaxLength(50);

                entity.Property(e => e.OscarNum).HasMaxLength(50);

                entity.Property(e => e.PoliceCheckExprieyDate).HasColumnType("datetime");

                entity.Property(e => e.Postcode).HasMaxLength(50);

                entity.Property(e => e.Relation).HasMaxLength(50);

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.SignatureImage).HasColumnType("image");

                entity.Property(e => e.SocialWorkerId).HasMaxLength(250);

                entity.Property(e => e.StreetNum).HasMaxLength(50);

                entity.Property(e => e.Suburb).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Contact_Lookup");
            });

            modelBuilder.Entity<ContactGroup>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.ContactGroup)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ContactGroup_Org");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactGroup)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ContactGroup_User");
            });

            modelBuilder.Entity<CopyDataOptions>(entity =>
            {
                entity.HasKey(e => e.ToSiteId)
                    .HasName("PK_CopyDataOptions");

                entity.Property(e => e.ToSiteId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CallingCode).HasColumnType("varchar(8)");

                entity.Property(e => e.Cctld)
                    .HasColumnName("CCTLD")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Iso2)
                    .HasColumnName("ISO2")
                    .HasColumnType("char(2)");

                entity.Property(e => e.Iso3)
                    .HasColumnName("ISO3")
                    .HasColumnType("char(3)");

                entity.Property(e => e.LongName)
                    .IsRequired()
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.NumCode).HasColumnType("varchar(6)");

                entity.Property(e => e.UnmemberState)
                    .HasColumnName("UNMemberState")
                    .HasColumnType("varchar(12)");
            });

            modelBuilder.Entity<CreditNote>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreditNoteDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ExternalCreditNoteNumber).HasMaxLength(100);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroUpdatedDateUtc)
                    .HasColumnName("XeroUpdatedDateUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.CreditNote)
                    .HasForeignKey(d => d.BillingId)
                    .HasConstraintName("FK_CreditNote_Billing");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.CreditNote)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CreditNote_Lookup");
            });

            modelBuilder.Entity<CreditNoteAllocatedInvoice>(entity =>
            {
                entity.ToTable("CreditNote_AllocatedInvoice");

                entity.Property(e => e.AppliedAmount).HasColumnType("decimal");

                entity.Property(e => e.AppliedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.CreditNoteAllocatedInvoice)
                    .HasForeignKey(d => d.CreditNoteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CreditNote_AllocatedInvoice_CreditNote");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.CreditNoteAllocatedInvoice)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CreditNote_AllocatedInvoice_Invoice");
            });

            modelBuilder.Entity<CreditNoteLineItem>(entity =>
            {
                entity.ToTable("CreditNote_LineItem");

                entity.Property(e => e.AppliedAmount).HasColumnType("decimal");

                entity.Property(e => e.BookingSptId).HasColumnName("Booking_SptId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BookingSpt)
                    .WithMany(p => p.CreditNoteLineItem)
                    .HasForeignKey(d => d.BookingSptId)
                    .HasConstraintName("FK_CreditNote_LineItem_Booking_Spt");

                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.CreditNoteLineItem)
                    .HasForeignKey(d => d.CreditNoteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CreditNote_LineItem_CreditNote");

                entity.HasOne(d => d.OriginalInvoice)
                    .WithMany(p => p.CreditNoteLineItem)
                    .HasForeignKey(d => d.OriginalInvoiceId)
                    .HasConstraintName("FK_XeroCreditNote_AllocatedInvoice_OldInvoice");

                entity.HasOne(d => d.XeroItemCode)
                    .WithMany(p => p.CreditNoteLineItem)
                    .HasForeignKey(d => d.XeroItemCodeId)
                    .HasConstraintName("FK_CreditNote_LineItem_XeroItemCode");

                entity.HasOne(d => d.XeroTrackingCode)
                    .WithMany(p => p.CreditNoteLineItem)
                    .HasForeignKey(d => d.XeroTrackingCodeId)
                    .HasConstraintName("FK_CreditNote_LineItem_XeroTrackingCatOption");
            });

            modelBuilder.Entity<CssBilling>(entity =>
            {
                entity.Property(e => e.BillingEndDate).HasColumnType("datetime");

                entity.Property(e => e.BillingStartDate).HasColumnType("datetime");

                entity.Property(e => e.Error).HasMaxLength(500);

                entity.Property(e => e.PaidBy).HasMaxLength(50);

                entity.Property(e => e.PaidOn).HasColumnType("datetime");

                entity.Property(e => e.PaymentStatus).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.CssBilling)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CssBilling_CssSubscription");
            });

            modelBuilder.Entity<CssBillingGroup>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GroupDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.GroupName).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.CssBillingGroup)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_CssBillingGroup_Org");

                entity.HasOne(d => d.ParentGroup)
                    .WithMany(p => p.InverseParentGroup)
                    .HasForeignKey(d => d.ParentGroupId)
                    .HasConstraintName("FK_CssBillingGroup_CssBillingGroup");
            });

            modelBuilder.Entity<CssBillingGroupOrg>(entity =>
            {
                entity.ToTable("CssBillingGroup_Org");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(max)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(max)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BillingGroup)
                    .WithMany(p => p.CssBillingGroupOrg)
                    .HasForeignKey(d => d.BillingGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CssBillingGroup_Org_CssBillingGroup");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.CssBillingGroupOrg)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CssBillingGroup_Org_Org");
            });

            modelBuilder.Entity<CssBillingPlan>(entity =>
            {
                entity.ToTable("CSS_BillingPlan");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<CssBillingPlan1>(entity =>
            {
                entity.ToTable("CssBillingPlan");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<CssBillingPlanDetails>(entity =>
            {
                entity.ToTable("CSS_BillingPlanDetails");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StarteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BillingRule)
                    .WithMany(p => p.CssBillingPlanDetails)
                    .HasForeignKey(d => d.BillingRuleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CSS_BillingPlanDetails_CSS_BillingRule");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.CssBillingPlanDetails)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CSS_BillingPlanDetails_CSS_BillingPlan");
            });

            modelBuilder.Entity<CssBillingPlanDetails1>(entity =>
            {
                entity.ToTable("CssBillingPlanDetails");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StarteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BillingRule)
                    .WithMany(p => p.CssBillingPlanDetails1)
                    .HasForeignKey(d => d.BillingRuleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CssBillingPlanDetails_CssBillingRule");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.CssBillingPlanDetails1)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CssBillingPlanDetails_CssBillingPlan");
            });

            modelBuilder.Entity<CssBillingRule>(entity =>
            {
                entity.ToTable("CSS_BillingRule");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Formula).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CssBillingRule)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CSS_BillingRule_CSS_Lookup");
            });

            modelBuilder.Entity<CssBillingRule1>(entity =>
            {
                entity.ToTable("CssBillingRule");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Formula).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CssBillingRule1)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CssBillingRule_CssLookup");
            });

            modelBuilder.Entity<CssCreditCardAccessCode>(entity =>
            {
                entity.Property(e => e.AccessCode).IsRequired();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CssCreditCardAccessCode)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CssCreditCardAccessCode_Org");
            });

            modelBuilder.Entity<CssInvoice>(entity =>
            {
                entity.ToTable("CSS_Invoice");

                entity.Property(e => e.AmountDue).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.Discount).HasColumnType("decimal");

                entity.Property(e => e.DiscountReason).HasMaxLength(500);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.PeriodStart).HasColumnType("datetime");

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroInvoiceCode).HasMaxLength(200);

                entity.Property(e => e.XeroUpdatedDateUtc)
                    .HasColumnName("XeroUpdatedDateUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.CssInvoice)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CSS_Invoice_Org");
            });

            modelBuilder.Entity<CssInvoiceLine>(entity =>
            {
                entity.ToTable("CSS_InvoiceLine");

                entity.Property(e => e.Account).HasMaxLength(300);

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.ItemCode).HasMaxLength(300);

                entity.Property(e => e.TaxRate).HasMaxLength(300);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.CssInvoiceLine)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CSS_InvoiceLine_CSS_Invoice");
            });

            modelBuilder.Entity<CssInvoiceLine1>(entity =>
            {
                entity.ToTable("CssInvoiceLine");

                entity.Property(e => e.Account).HasMaxLength(300);

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.ItemCode).HasMaxLength(300);

                entity.Property(e => e.TaxRate).HasMaxLength(300);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<CssLookup>(entity =>
            {
                entity.ToTable("CSS_Lookup");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<CssLookup1>(entity =>
            {
                entity.ToTable("CssLookup");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<CssPaymentSetup>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreditCardType).HasMaxLength(250);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Error).HasMaxLength(500);

                entity.Property(e => e.MaskedCardNumber).HasMaxLength(250);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.CssPaymentSetup)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CssPaymentSetup_Org");
            });

            modelBuilder.Entity<CssSetting>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Smscharge)
                    .HasColumnName("SMSCharge")
                    .HasColumnType("money");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("updatedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroConsumerKey).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CssSubscription>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.BillingPlanDetail)
                    .WithMany(p => p.CssSubscription)
                    .HasForeignKey(d => d.BillingPlanDetailId)
                    .HasConstraintName("FK_CssSubscription_CssBillingPlanDetails");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.CssSubscription)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CssSubscription_Org");
            });

            modelBuilder.Entity<CssSysAdminUser>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(50)");

                entity.Property(e => e.LastName).HasColumnType("varchar(50)");

                entity.Property(e => e.MiddleName).HasColumnType("varchar(50)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PasswordHash).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<DailyAttendance>(entity =>
            {
                entity.HasIndex(e => new { e.SiteId, e.TotalBooking, e.Date })
                    .HasName("IdxDailyAttendanceDate");

                entity.HasIndex(e => new { e.TotalBooking, e.SiteId, e.Date })
                    .HasName("IdxDailyAttendanceSiteDate");

                entity.HasIndex(e => new { e.Date, e.TotalBooking, e.SiteId, e.ProgramCategoryId })
                    .HasName("IdxDailyAttendance2");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.TotalMsdattended).HasColumnName("TotalMSDAttended");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<DashboardMessage>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MessageType).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.DashboardMessage)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DashboardMessage_Org");
            });

            modelBuilder.Entity<DashboardViewHistory>(entity =>
            {
                entity.Property(e => e.Code).HasColumnType("varchar(max)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ProgramCategory)
                    .WithMany(p => p.DashboardViewHistory)
                    .HasForeignKey(d => d.ProgramCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DashboardViewHistory_ProgramCategory");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DashboardViewHistory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DashboardViewHistory_User");
            });

            modelBuilder.Entity<DatabaseChangeHistory>(entity =>
            {
                entity.Property(e => e.Developer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExecutedOn).HasColumnType("datetime");

                entity.Property(e => e.SqlfileName)
                    .IsRequired()
                    .HasColumnName("SQLFileName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<DefaultBillingDiscount>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsRequired();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal");

                entity.Property(e => e.DiscountType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).IsRequired();

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.DefaultBillingDiscount)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DefaultBillingDiscount_Billing");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DefaultBillingDiscount)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DefaultBillingDiscount_User");
            });

            modelBuilder.Entity<DefaultTerm>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<DeletingInvoiceQueue>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsRequired();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).IsRequired();

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.DeletingInvoiceQueue)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeletingInvoiceQueue_Invoice");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.DeletingInvoiceQueue)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeletingInvoiceQueue_OrgSetting");
            });

            modelBuilder.Entity<EventDuration>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EventCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FinishOn).HasColumnType("datetime");

                entity.Property(e => e.StartOn).HasColumnType("datetime");

                entity.Property(e => e.SyncOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.EventDuration)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EventDuration_User");
            });

            modelBuilder.Entity<ExcludeDay>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.ExcludeDay)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExcludeDay_Org");
            });

            modelBuilder.Entity<FavouriteReport>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.FavouriteReport)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FavouriteReport_Org");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FavouriteReport)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FavouriteReport_User");
            });

            modelBuilder.Entity<FinancialHistory>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GrossProfit).HasColumnType("decimal");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NetProfit).HasColumnType("decimal");

                entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.PeriodStart).HasColumnType("datetime");

                entity.Property(e => e.TotalBankBalance).HasColumnType("decimal");

                entity.Property(e => e.TotalIncomeGross).HasColumnType("decimal");

                entity.Property(e => e.TotalOperatingExpense).HasColumnType("decimal");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroLastUpdated).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.FinancialHistory)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FinancialHistory_Org");
            });

            modelBuilder.Entity<FlyerTemplate>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NewFileName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.FlyerTemplate)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_FlyerTemplate_Org");
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<FormField>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Font).HasMaxLength(50);

                entity.Property(e => e.GroupType).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.FormField)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__FormField__FormI__29D71569");
            });

            modelBuilder.Entity<FormFieldValue>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.FormField)
                    .WithMany(p => p.FormFieldValue)
                    .HasForeignKey(d => d.FormFieldId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FormFieldValue_FormField");

                entity.HasOne(d => d.FormInstance)
                    .WithMany(p => p.FormFieldValue)
                    .HasForeignKey(d => d.FormInstanceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__FormField__FormI__3ED2324F");
            });

            modelBuilder.Entity<FormInstance>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.FormInstance)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__FormInsta__FormI__3B01A16B");

                entity.HasOne(d => d.FormTemplate)
                    .WithMany(p => p.FormInstance)
                    .HasForeignKey(d => d.FormTemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__FormInsta__FormT__3BF5C5A4");
            });

            modelBuilder.Entity<FormTemplate>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Thumbnail).HasMaxLength(200);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.FormTemplate)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__FormTempl__FormI__382534C0");
            });

            modelBuilder.Entity<GuardianChild>(entity =>
            {
                entity.ToTable("Guardian_Child");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.GuardianChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Guardian_Child_Child1");

                entity.HasOne(d => d.Guardian)
                    .WithMany(p => p.GuardianChild)
                    .HasForeignKey(d => d.GuardianId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Guardian_Child_Contact");
            });

            modelBuilder.Entity<HeadCount>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Day).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.ProgramName).HasMaxLength(255);

                entity.Property(e => e.SessionName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.HeadCount)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_HeadCount_Org");
            });

            modelBuilder.Entity<HeadCountLine>(entity =>
            {
                entity.HasIndex(e => new { e.HeadCountId, e.AttendanceId })
                    .HasName("NonClusteredIndex-20150720-000332");

                entity.Property(e => e.ChildName).HasMaxLength(255);

                entity.Property(e => e.ChildPhoto).HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.SiteGroups).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Attendance)
                    .WithMany(p => p.HeadCountLine)
                    .HasForeignKey(d => d.AttendanceId)
                    .HasConstraintName("FK_HeadCountLine_Attendance");

                entity.HasOne(d => d.HeadCount)
                    .WithMany(p => p.HeadCountLine)
                    .HasForeignKey(d => d.HeadCountId)
                    .HasConstraintName("FK_HeadCountLine_HeadCount");
            });

            modelBuilder.Entity<HolidayFlyerDraft>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FlyerData)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Spt)
                    .WithMany(p => p.HolidayFlyerDraft)
                    .HasForeignKey(d => d.SptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HolidayFlyerDraft_Site_Program_Term");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<IdentityUser>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("EmailIndex_IdentityUser")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex_IdentityUser")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<IdentityUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IdentityUserClaim)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.IdentityUserClaim_dbo.User_UserId");
            });

            modelBuilder.Entity<IdentityUserDevice>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.DeviceId })
                    .HasName("IX_IdentityUserDevice")
                    .IsUnique();

                entity.Property(e => e.AppVersion).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeviceBrand).HasMaxLength(255);

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DeviceManufacturer).HasMaxLength(255);

                entity.Property(e => e.DeviceModel).HasMaxLength(255);

                entity.Property(e => e.DeviceOsVersion).HasMaxLength(255);

                entity.Property(e => e.LatestIpAddress).HasMaxLength(255);

                entity.Property(e => e.NotificationId).HasMaxLength(255);

                entity.Property(e => e.NotificationPlatform).HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IdentityUserDevice)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IdentityUserDevice_IdentityUser");
            });

            modelBuilder.Entity<IdentityUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.IdentityUserLogin");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IdentityUserLogin)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.IdentityUserLogin_dbo.User_UserId");
            });

            modelBuilder.Entity<IdentityUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.IdentityUserRole");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.IdentityUserRole)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.IdentityUserRole_dbo.IdentityRole_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IdentityUserRole)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.IdentityUserRole_dbo.User_UserId");
            });

            modelBuilder.Entity<ImpersonateUserHistory>(entity =>
            {
                entity.Property(e => e.ImpersonatedFrom).HasColumnType("datetime");

                entity.Property(e => e.ImpersonatedTo).HasColumnType("datetime");

                entity.HasOne(d => d.ImpersonatedByNavigation)
                    .WithMany(p => p.ImpersonateUserHistoryImpersonatedByNavigation)
                    .HasForeignKey(d => d.ImpersonatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ImpersonateUser_ImpersonatedByUser");

                entity.HasOne(d => d.ImpersonatedUserNavigation)
                    .WithMany(p => p.ImpersonateUserHistoryImpersonatedUserNavigation)
                    .HasForeignKey(d => d.ImpersonatedUser)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ImpersonateUser_ImpersonatedUser");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasIndex(e => new { e.StatusId, e.IsActive })
                    .HasName("GetOutStandingInvoicesIndex2");

                entity.Property(e => e.AmountCredited).HasColumnType("decimal");

                entity.Property(e => e.AmountDue).HasColumnType("decimal");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal");

                entity.Property(e => e.DiscountReason).HasMaxLength(500);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EmailStatus).HasMaxLength(50);

                entity.Property(e => e.FirstAttDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.LastAttDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalTotalAmount).HasColumnType("decimal");

                entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.PeriodStart).HasColumnType("datetime");

                entity.Property(e => e.Reference).HasMaxLength(300);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroInvoiceCode).HasMaxLength(200);

                entity.Property(e => e.XeroUpdatedDateUtc)
                    .HasColumnName("XeroUpdatedDateUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Invoice_Billing");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Invoice_Lookup");
            });

            modelBuilder.Entity<InvoiceExtraCharge>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExtraAmount).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceExtraCharge)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InvoiceExtraCharge_Invoice");
            });

            modelBuilder.Entity<InvoiceHistory>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstAtt).HasColumnType("date");

                entity.Property(e => e.LastAtt).HasColumnType("date");

                entity.Property(e => e.PeriodEnd).HasColumnType("date");

                entity.Property(e => e.PeriodStart).HasColumnType("date");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.InvoiceHistory)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InvoiceHistory_Billing");
            });

            modelBuilder.Entity<InvoiceHistoryLine>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.BookingSptId).HasColumnName("Booking_SptId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.BookingSpt)
                    .WithMany(p => p.InvoiceHistoryLine)
                    .HasForeignKey(d => d.BookingSptId)
                    .HasConstraintName("FK_InvoiceHistoryLine_Booking_Spt");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceHistoryLine)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InvoiceHistoryLine_InvoiceHistory");

                entity.HasOne(d => d.ItemCode)
                    .WithMany(p => p.InvoiceHistoryLine)
                    .HasForeignKey(d => d.ItemCodeId)
                    .HasConstraintName("FK_InvoiceHistoryLine_XeroItemCode");

                entity.HasOne(d => d.TrackingCode)
                    .WithMany(p => p.InvoiceHistoryLine)
                    .HasForeignKey(d => d.TrackingCodeId)
                    .HasConstraintName("FK_InvoiceHistoryLine_XeroTrackingCatOption");
            });

            modelBuilder.Entity<InvoiceLine>(entity =>
            {
                entity.HasIndex(e => new { e.InvoiceId, e.IsActive, e.Amount })
                    .HasName("IDX_InvoiceLine1");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.BookingSptId).HasColumnName("Booking_SptId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InvoiceLineType).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BookingSpt)
                    .WithMany(p => p.InvoiceLine)
                    .HasForeignKey(d => d.BookingSptId)
                    .HasConstraintName("FK_InvoiceLine_Booking_Spt");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceLine)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InvoiceLine_Invoice");

                entity.HasOne(d => d.ItemCode)
                    .WithMany(p => p.InvoiceLine)
                    .HasForeignKey(d => d.ItemCodeId)
                    .HasConstraintName("FK_InvoiceLine_XeroItemCode");

                entity.HasOne(d => d.TrackingCatOption)
                    .WithMany(p => p.InvoiceLine)
                    .HasForeignKey(d => d.TrackingCatOptionId)
                    .HasConstraintName("FK_InvoiceLine_XeroTrackingCatOption");
            });

            modelBuilder.Entity<InvoicePayment>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.XeroDateCreated).HasColumnType("datetime");

                entity.Property(e => e.XeroUpdatedDateUtc)
                    .HasColumnName("XeroUpdatedDateUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoicePayment)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InvoicePayment_Invoice");
            });

            modelBuilder.Entity<InvoiceSettingAudit>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrentDescription).IsRequired();

                entity.Property(e => e.LastChangeDescription).IsRequired();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LocalPayment>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal");

                entity.Property(e => e.PaidBy).HasMaxLength(255);

                entity.Property(e => e.PaidOn).HasColumnType("datetime");

                entity.Property(e => e.PaymentReference).HasMaxLength(255);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.LocalPayment)
                    .HasForeignKey(d => d.CreditNoteId)
                    .HasConstraintName("FK_LocalPayment_CreditNote");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.LocalPayment)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LocalPayment_Invoice");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.LocalPayment)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_LocalPayment_Payment");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.LocalPayment)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LocalPayment_Lookup");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.LocalPayment)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LocalPayment_Org");
            });

            modelBuilder.Entity<Lookup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Media>(entity =>
            {
                entity.HasIndex(e => new { e.CreatedBy, e.CreatedOn, e.Description, e.EntityType, e.Id, e.IsMedicalPdf, e.MediaTypeId, e.Name, e.NewFileName, e.OldFileName, e.SiteId, e.UpdatedBy, e.UpdatedOn, e.Url, e.Version, e.EntityId, e.IsProfilePicture, e.IsActive })
                    .HasName("IDX_MediaChildManager");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.EntityType).HasColumnType("varchar(50)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NewFileName).HasMaxLength(1024);

                entity.Property(e => e.OldFileName).HasMaxLength(1024);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(2048);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.MediaType)
                    .WithMany(p => p.Media)
                    .HasForeignKey(d => d.MediaTypeId)
                    .HasConstraintName("FK_Media_Lookup");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Media)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_Media_Org");
            });

            modelBuilder.Entity<MediaExtension>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Caption).HasMaxLength(256);

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Duration).HasColumnType("time(3)");

                entity.Property(e => e.FormatType).HasColumnType("varchar(50)");

                entity.Property(e => e.Tag).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.MediaExtension)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MediaExtension_Media");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MediaExtension)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MediaExtension_User");
            });

            modelBuilder.Entity<MediaLibrary>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<MediaLibraryChild>(entity =>
            {
                entity.ToTable("MediaLibrary_Child");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.MediaLibrary)
                    .WithMany(p => p.MediaLibraryChild)
                    .HasForeignKey(d => d.MediaLibraryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MediaLibrary_Child_MediaLibrary");
            });

            modelBuilder.Entity<MediaLibraryMedia>(entity =>
            {
                entity.ToTable("MediaLibrary_Media");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.MediaLibraryMedia)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MediaLibrary_Media_Media");

                entity.HasOne(d => d.MediaLibrary)
                    .WithMany(p => p.MediaLibraryMedia)
                    .HasForeignKey(d => d.MediaLibraryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MediaLibrary_Media_MediaLibrary");
            });

            modelBuilder.Entity<MessageHistory>(entity =>
            {
                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.DeliveryMethod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Recipients).IsRequired();

                entity.Property(e => e.Subject).IsRequired();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.MessageHistory)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_MessageHistory_Org");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MessageHistory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MessageHistory_User");
            });

            modelBuilder.Entity<ModifiedAttendanceCost>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NewCost).HasColumnType("decimal");

                entity.Property(e => e.OriginalCost).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Att)
                    .WithMany(p => p.ModifiedAttendanceCost)
                    .HasForeignKey(d => d.AttId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ModifiedAttendanceCost_Attendance");
            });

            modelBuilder.Entity<MsdjobConfig>(entity =>
            {
                entity.ToTable("MSDJobConfig");

                entity.Property(e => e.MsdjobId).HasColumnName("MSDJobId");

                entity.HasOne(d => d.Msdjob)
                    .WithMany(p => p.MsdjobConfig)
                    .HasForeignKey(d => d.MsdjobId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MSDJobConfig_MSDJobConfig");
            });

            modelBuilder.Entity<MsdjobQueue>(entity =>
            {
                entity.ToTable("MSDJobQueue");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CretaedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ProcessedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("varchar(50)");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<NoteLookup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("varchar(50)");

                entity.Property(e => e.EntityName).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(255)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Role).HasColumnType("varchar(50)");

                entity.Property(e => e.TypeId).HasColumnName("Type_id");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("char(255)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Notification_Lookup");
            });

            modelBuilder.Entity<NotificationInstance>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(255)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Error).HasColumnType("varchar(250)");

                entity.Property(e => e.Smsprocessed).HasColumnName("SMSProcessed");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.NotificationInstance)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NotificationInstance_Notification");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.NotificationInstance)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NotificationInstance_User");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NotificationInstance)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_NotificationInstance_RealUser");
            });

            modelBuilder.Entity<NotificationMobile>(entity =>
            {
                entity.ToTable("Notification_Mobile");

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).HasMaxLength(1000);

                entity.Property(e => e.MessageBody)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Platform)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NotificationMobile)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Notification_Mobile_IdentityUser");
            });

            modelBuilder.Entity<NotificationReminder>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastProcessedOn).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.Reference).HasMaxLength(550);

                entity.Property(e => e.Source).HasMaxLength(550);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.NotificationReminder)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NotificationReminder_Org");
            });

            modelBuilder.Entity<NotificationUser>(entity =>
            {
                entity.ToTable("Notification_User");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(255)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Devices)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.EmailAddress).HasColumnType("varchar(50)");

                entity.Property(e => e.Smsnumber)
                    .HasColumnName("SMSNumber")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ToValue).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("char(255)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.NotificationUser)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Notification_User_Notification");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NotificationUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Notification_User_User");
            });

            modelBuilder.Entity<Org>(entity =>
            {
                entity.Property(e => e.BankAccNum).HasMaxLength(50);

                entity.Property(e => e.BookingInfoCasual).HasMaxLength(200);

                entity.Property(e => e.BookingInfoRegular).HasMaxLength(200);

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CssbillingPlanId).HasColumnName("CSSBillingPlanId");

                entity.Property(e => e.Csscomment)
                    .HasColumnName("CSSComment")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.CssrevireDate)
                    .HasColumnName("CSSRevireDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Culture).HasMaxLength(50);

                entity.Property(e => e.CurrentBalance).HasColumnType("money");

                entity.Property(e => e.CurrentExpenses).HasColumnType("money");

                entity.Property(e => e.CurrentOverdueAmt).HasColumnType("money");

                entity.Property(e => e.CurrentRevenue).HasColumnType("money");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ExtraChargeType).HasMaxLength(50);

                entity.Property(e => e.ExtraMinRate).HasColumnType("decimal");

                entity.Property(e => e.HeadOfficeLogo).HasMaxLength(250);

                entity.Property(e => e.IsDeductByCcpayment).HasColumnName("IsDeductByCCPayment");

                entity.Property(e => e.IsEmailMsgEnabled).HasColumnName("IsEMailMsgEnabled");

                entity.Property(e => e.IsSmsmsgEnabled).HasColumnName("IsSMSMsgEnabled");

                entity.Property(e => e.Language).HasMaxLength(50);

                entity.Property(e => e.LeaseCostFixed).HasColumnType("decimal");

                entity.Property(e => e.LeaseEnd).HasColumnType("date");

                entity.Property(e => e.LeaseStart).HasColumnType("date");

                entity.Property(e => e.LeasorName).HasMaxLength(50);

                entity.Property(e => e.LicenceEnd).HasColumnType("datetime");

                entity.Property(e => e.LicenceFee).HasColumnType("money");

                entity.Property(e => e.LicenceStart).HasColumnType("datetime");

                entity.Property(e => e.LoginUrl)
                    .HasColumnName("LoginURL")
                    .HasMaxLength(550);

                entity.Property(e => e.Logo).HasMaxLength(255);

                entity.Property(e => e.MasterPin).HasMaxLength(50);

                entity.Property(e => e.MeetingRoom).HasMaxLength(100);

                entity.Property(e => e.MsdNum).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OscarNum).HasMaxLength(50);

                entity.Property(e => e.ShowParentDob).HasColumnName("ShowParentDOB");

                entity.Property(e => e.SiteAddress).HasMaxLength(500);

                entity.Property(e => e.SiteBankAccNum).HasMaxLength(50);

                entity.Property(e => e.SiteCity).HasMaxLength(50);

                entity.Property(e => e.SiteContactEmail).HasMaxLength(100);

                entity.Property(e => e.SiteContactPersone).HasMaxLength(100);

                entity.Property(e => e.SiteContactPhone).HasMaxLength(50);

                entity.Property(e => e.SiteContactPhoneFixed).HasMaxLength(50);

                entity.Property(e => e.SiteCountry).HasMaxLength(50);

                entity.Property(e => e.SiteLandlineNumber).HasMaxLength(50);

                entity.Property(e => e.SiteLandlineNumberFixed).HasMaxLength(50);

                entity.Property(e => e.SiteLatitude).HasMaxLength(250);

                entity.Property(e => e.SiteLongitude).HasMaxLength(250);

                entity.Property(e => e.SitePostCode).HasMaxLength(50);

                entity.Property(e => e.SiteStreetNum).HasMaxLength(50);

                entity.Property(e => e.SiteSuburb).HasMaxLength(50);

                entity.Property(e => e.StaffClockMethod).HasMaxLength(50);

                entity.Property(e => e.TaxNumber).HasColumnType("varchar(250)");

                entity.Property(e => e.TimeZoneIdentifier).HasMaxLength(250);

                entity.Property(e => e.TradingName).HasColumnType("varchar(250)");

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.WeeklyAdminCost).HasColumnType("decimal");

                entity.Property(e => e.WeeklyRentCost).HasColumnType("decimal");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Org)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Org_Contact");

                entity.HasOne(d => d.CssbillingPlan)
                    .WithMany(p => p.Org)
                    .HasForeignKey(d => d.CssbillingPlanId)
                    .HasConstraintName("FK_Org_CssBillingPlan");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Org_Org");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Org)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Org_School");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.Org)
                    .HasForeignKey(d => d.TerritoryId)
                    .HasConstraintName("FK_Org_Territory");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Org)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Org_Lookup");
            });

            modelBuilder.Entity<OrgAcceptedTermsAndConditions>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.OrgTandCid).HasColumnName("OrgTandCId");

                entity.HasOne(d => d.OrgTandC)
                    .WithMany(p => p.OrgAcceptedTermsAndConditions)
                    .HasForeignKey(d => d.OrgTandCid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgAcceptedTermsAndConditions_Org_TermsConditions");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.OrgAcceptedTermsAndConditions)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgAcceptedTermsAndConditions_Org");
            });

            modelBuilder.Entity<OrgAccountSoftwareSetting>(entity =>
            {
                entity.Property(e => e.AccessSecret).HasColumnType("varchar(max)");

                entity.Property(e => e.AccessToken).HasColumnType("varchar(max)");

                entity.Property(e => e.AccountSoftwareGid).HasColumnType("varchar(max)");

                entity.Property(e => e.AccountSoftwareType).HasColumnType("varchar(50)");

                entity.Property(e => e.ClientKey).HasColumnType("varchar(max)");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DataSource).HasColumnType("varchar(50)");

                entity.Property(e => e.RefreshToken).HasColumnType("varchar(max)");

                entity.Property(e => e.RequestSecret).HasColumnType("varchar(max)");

                entity.Property(e => e.RequestToken).HasColumnType("varchar(max)");

                entity.Property(e => e.SecretKey).HasColumnType("varchar(max)");

                entity.Property(e => e.TokenExpireDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgAccountSoftwareSetting)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgAccountSoftwareSetting_Org");
            });

            modelBuilder.Entity<OrgBillingSetting>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EarlyDropOffFlatRate).HasColumnType("decimal");

                entity.Property(e => e.EarlyDropOffType).HasMaxLength(50);

                entity.Property(e => e.EarlyDropoffBasedOn).HasMaxLength(50);

                entity.Property(e => e.EarlyPickupFlatRate).HasColumnType("decimal");

                entity.Property(e => e.EarlyPickupType).HasMaxLength(50);

                entity.Property(e => e.LatePickupBasedOn).HasMaxLength(50);

                entity.Property(e => e.LatePickupFlatRate).HasColumnType("decimal");

                entity.Property(e => e.LatePickupType).HasMaxLength(50);

                entity.Property(e => e.MinimumChargeType).HasMaxLength(50);

                entity.Property(e => e.MinimumFlatRate).HasColumnType("decimal");

                entity.Property(e => e.NonAttendanceType).HasMaxLength(50);

                entity.Property(e => e.NonAttendanceValue).HasColumnType("decimal");

                entity.Property(e => e.SiteEndTime).HasColumnType("time(0)");

                entity.Property(e => e.SiteOpenTime).HasColumnType("time(0)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgBillingSetting)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgBillingSetting_Org");

                entity.HasOne(d => d.ProgramCategory)
                    .WithMany(p => p.OrgBillingSetting)
                    .HasForeignKey(d => d.ProgramCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgBillingSetting_ProgramCategory");
            });

            modelBuilder.Entity<OrgChild>(entity =>
            {
                entity.ToTable("Org_Child");

                entity.HasIndex(e => e.SiteId)
                    .HasName("NonClusteredIndex-20150716-195744");

                entity.HasIndex(e => new { e.ChildId, e.CreatedBy, e.CreatedOn, e.FirstAttendanceDate, e.Id, e.IsLock, e.NewFlagDone, e.SiteId, e.IsActive })
                    .HasName("IDX_Org_Child_ChildManager");

                entity.HasIndex(e => new { e.CreatedBy, e.CreatedOn, e.FirstAttendanceDate, e.Id, e.IsLock, e.NewFlagDone, e.SiteId, e.ChildId, e.IsActive })
                    .HasName("IDX_Org_Child_ChildManager2");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstAttendanceDate).HasColumnType("datetime");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.OrgChild)
                    .HasForeignKey(d => d.ChildId)
                    .HasConstraintName("FK_Org_Child_Child1");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.OrgChild)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_Org_Child_Org");
            });

            modelBuilder.Entity<OrgContact>(entity =>
            {
                entity.ToTable("Org_Contact");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.OrgContact)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Org_Contact_Contact");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgContact)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_Org_Contact_Org");
            });

            modelBuilder.Entity<OrgCssBillingRule>(entity =>
            {
                entity.ToTable("Org_CSS_BillingRule");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreratedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.RuleName).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BillingRule)
                    .WithMany(p => p.OrgCssBillingRule)
                    .HasForeignKey(d => d.BillingRuleId)
                    .HasConstraintName("FK_Org_CSS_BillingRule_CSS_BillingRule");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgCssBillingRule)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_Org_CSS_BillingRule_Org");
            });

            modelBuilder.Entity<OrgCustomize>(entity =>
            {
                entity.Property(e => e.ChildSignoutMethod).HasColumnType("varchar(200)");

                entity.Property(e => e.CountryCode).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Culture).HasMaxLength(50);

                entity.Property(e => e.CurrencySymbol).HasColumnType("varchar(50)");

                entity.Property(e => e.DisableWinzonForm).HasColumnName("DisableWINZonForm");

                entity.Property(e => e.Ethinicity).HasColumnType("varchar(200)");

                entity.Property(e => e.HowHear).HasColumnType("varchar(200)");

                entity.Property(e => e.SchoolInfo).HasColumnType("varchar(200)");

                entity.Property(e => e.TaxName).HasMaxLength(50);

                entity.Property(e => e.TaxRate).HasColumnType("decimal");

                entity.Property(e => e.TermsAndCondition).HasColumnType("varchar(200)");

                entity.Property(e => e.Timezone).HasColumnType("varchar(250)");

                entity.Property(e => e.TimezoneOffset).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Xml)
                    .HasColumnName("XML")
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.OrgCustomize)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_OrgCustomize_Country");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgCustomize)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgCustomize_Org");
            });

            modelBuilder.Entity<OrgDesign>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Colour).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Logo).HasMaxLength(1024);

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.LogoType)
                    .WithMany(p => p.OrgDesign)
                    .HasForeignKey(d => d.LogoTypeId)
                    .HasConstraintName("FK_OrgDesign_Lookup");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.OrgDesign)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_OrgDesign_Org");
            });

            modelBuilder.Entity<OrgEmailBodyTemplate>(entity =>
            {
                entity.Property(e => e.NewRegistrationTemplate).IsRequired();

                entity.Property(e => e.OscarCocapproval).HasColumnName("OscarCOCApproval");

                entity.Property(e => e.OscarCocdecline).HasColumnName("OscarCOCDecline");

                entity.Property(e => e.OscarCocrequest).HasColumnName("OscarCOCRequest");
            });

            modelBuilder.Entity<OrgGroup>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ProgramCategory)
                    .WithMany(p => p.OrgGroup)
                    .HasForeignKey(d => d.ProgramCategoryId)
                    .HasConstraintName("FK_OrgGroup_ProgramCategory");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.OrgGroup)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_OrgGroup_Session");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.OrgGroup)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_OrgGroup_Org");

                entity.HasOne(d => d.Spt)
                    .WithMany(p => p.OrgGroup)
                    .HasForeignKey(d => d.SptId)
                    .HasConstraintName("FK_OrgGroup_Site_Program_Term");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.OrgGroup)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_OrgGroup_Term");
            });

            modelBuilder.Entity<OrgInvoicingSetting>(entity =>
            {
                entity.HasKey(e => e.OrgId)
                    .HasName("PK_OrgInvoicingSetting");

                entity.Property(e => e.OrgId).ValueGeneratedNever();

                entity.Property(e => e.AccessSecret).HasColumnType("varchar(max)");

                entity.Property(e => e.AccessToken).HasColumnType("varchar(max)");

                entity.Property(e => e.AccountingSoftwareType).HasColumnType("varchar(50)");

                entity.Property(e => e.ClientKey).HasColumnType("varchar(max)");

                entity.Property(e => e.ConditionForWeekOfDue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ConditionForWeekOfGen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).IsRequired();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InvoiceReference).IsRequired();

                entity.Property(e => e.QuickBooksDataSource).HasColumnType("varchar(50)");

                entity.Property(e => e.RefreshToken).HasColumnType("varchar(max)");

                entity.Property(e => e.RequestSecret).HasColumnType("varchar(max)");

                entity.Property(e => e.RequestToken).HasColumnType("varchar(max)");

                entity.Property(e => e.SecretKey).HasColumnType("varchar(max)");

                entity.Property(e => e.TokenExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).IsRequired();

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Org)
                    .WithOne(p => p.OrgInvoicingSetting)
                    .HasForeignKey<OrgInvoicingSetting>(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgInvoicingSetting_Org");
            });

            modelBuilder.Entity<OrgMyobSetting>(entity =>
            {
                entity.Property(e => e.AccessToken).HasColumnType("varchar(max)");

                entity.Property(e => e.ClientKey).HasColumnType("varchar(max)");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MyobGid).HasColumnType("varchar(max)");

                entity.Property(e => e.MyobSoftwareType).HasColumnType("varchar(50)");

                entity.Property(e => e.RefreshToken).HasColumnType("varchar(max)");

                entity.Property(e => e.SecretKey).HasColumnType("varchar(max)");

                entity.Property(e => e.TokenExpireDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgMyobSetting)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgMyobSetting_Org");
            });

            modelBuilder.Entity<OrgNotificationSetting>(entity =>
            {
                entity.HasOne(d => d.NotificationTypeNavigation)
                    .WithMany(p => p.OrgNotificationSetting)
                    .HasForeignKey(d => d.NotificationType)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgNotificationSetting_Lookup");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgNotificationSetting)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgNotificationSetting_Org");
            });

            modelBuilder.Entity<OrgReference>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgReference)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgReference_Org");
            });

            modelBuilder.Entity<OrgReferenceSetting>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ReferenceMessage).HasColumnType("varchar(max)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgReferenceSetting)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgReferenceSetting_Org");
            });

            modelBuilder.Entity<OrgSetting>(entity =>
            {
                entity.HasKey(e => e.OrgId)
                    .HasName("PK_OrgSetting");

                entity.Property(e => e.OrgId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DefaultAsccitemCodeId).HasColumnName("DefaultASCCItemCodeId");

                entity.Property(e => e.DefaultAscftitemCodeId).HasColumnName("DefaultASCFTItemCodeId");

                entity.Property(e => e.DefaultAscptitemCodeId).HasColumnName("DefaultASCPTItemCodeId");

                entity.Property(e => e.DefaultAsctrackingId).HasColumnName("DefaultASCTrackingId");

                entity.Property(e => e.DefaultBsccitemCodeId).HasColumnName("DefaultBSCCItemCodeId");

                entity.Property(e => e.DefaultBscftitemCodeId).HasColumnName("DefaultBSCFTItemCodeId");

                entity.Property(e => e.DefaultBscptitemCodeId).HasColumnName("DefaultBSCPTItemCodeId");

                entity.Property(e => e.DefaultBsctrackingId).HasColumnName("DefaultBSCTrackingId");

                entity.Property(e => e.DefaultCcaccCodeId).HasColumnName("DefaultCCAccCodeId");

                entity.Property(e => e.DefaultHolfitemCodeId).HasColumnName("DefaultHOLFItemCodeId");

                entity.Property(e => e.DefaultHolpamitemCodeId).HasColumnName("DefaultHOLPAMItemCodeId");

                entity.Property(e => e.DefaultHolppmitemCodeId).HasColumnName("DefaultHOLPPMItemCodeId");

                entity.Property(e => e.DefaultHolsitemCodeId).HasColumnName("DefaultHOLSItemCodeId");

                entity.Property(e => e.DefaultHoltitemCodeId).HasColumnName("DefaultHOLTItemCodeId");

                entity.Property(e => e.DefaultOpaccCodeId).HasColumnName("DefaultOPAccCodeId");

                entity.Property(e => e.DefaultOscarbankAccCodeId).HasColumnName("DefaultOSCARBankAccCodeId");

                entity.Property(e => e.ExtraMinRate).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroConsumerKey)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.DefaultAsccitemCode)
                    .WithMany(p => p.OrgSettingDefaultAsccitemCode)
                    .HasForeignKey(d => d.DefaultAsccitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode2");

                entity.HasOne(d => d.DefaultAscftitemCode)
                    .WithMany(p => p.OrgSettingDefaultAscftitemCode)
                    .HasForeignKey(d => d.DefaultAscftitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode1");

                entity.HasOne(d => d.DefaultAscptitemCode)
                    .WithMany(p => p.OrgSettingDefaultAscptitemCode)
                    .HasForeignKey(d => d.DefaultAscptitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode");

                entity.HasOne(d => d.DefaultAsctracking)
                    .WithMany(p => p.OrgSettingDefaultAsctracking)
                    .HasForeignKey(d => d.DefaultAsctrackingId)
                    .HasConstraintName("FK_OrgSetting_XeroTrackingCatOption");

                entity.HasOne(d => d.DefaultBsccitemCode)
                    .WithMany(p => p.OrgSettingDefaultBsccitemCode)
                    .HasForeignKey(d => d.DefaultBsccitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode5");

                entity.HasOne(d => d.DefaultBscftitemCode)
                    .WithMany(p => p.OrgSettingDefaultBscftitemCode)
                    .HasForeignKey(d => d.DefaultBscftitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode4");

                entity.HasOne(d => d.DefaultBscptitemCode)
                    .WithMany(p => p.OrgSettingDefaultBscptitemCode)
                    .HasForeignKey(d => d.DefaultBscptitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode3");

                entity.HasOne(d => d.DefaultBsctracking)
                    .WithMany(p => p.OrgSettingDefaultBsctracking)
                    .HasForeignKey(d => d.DefaultBsctrackingId)
                    .HasConstraintName("FK_OrgSetting_XeroTrackingCatOption1");

                entity.HasOne(d => d.DefaultCcaccCode)
                    .WithMany(p => p.OrgSettingDefaultCcaccCode)
                    .HasForeignKey(d => d.DefaultCcaccCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroAccountCode");

                entity.HasOne(d => d.DefaultHolTracking)
                    .WithMany(p => p.OrgSettingDefaultHolTracking)
                    .HasForeignKey(d => d.DefaultHolTrackingId)
                    .HasConstraintName("FK_OrgSetting_XeroTrackingCatOption2");

                entity.HasOne(d => d.DefaultHolfitemCode)
                    .WithMany(p => p.OrgSettingDefaultHolfitemCode)
                    .HasForeignKey(d => d.DefaultHolfitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode6");

                entity.HasOne(d => d.DefaultHolpamitemCode)
                    .WithMany(p => p.OrgSettingDefaultHolpamitemCode)
                    .HasForeignKey(d => d.DefaultHolpamitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode11");

                entity.HasOne(d => d.DefaultHolppmitemCode)
                    .WithMany(p => p.OrgSettingDefaultHolppmitemCode)
                    .HasForeignKey(d => d.DefaultHolppmitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode10");

                entity.HasOne(d => d.DefaultHolsitemCode)
                    .WithMany(p => p.OrgSettingDefaultHolsitemCode)
                    .HasForeignKey(d => d.DefaultHolsitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode8");

                entity.HasOne(d => d.DefaultHoltitemCode)
                    .WithMany(p => p.OrgSettingDefaultHoltitemCode)
                    .HasForeignKey(d => d.DefaultHoltitemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode9");

                entity.HasOne(d => d.DefaultOpaccCode)
                    .WithMany(p => p.OrgSettingDefaultOpaccCode)
                    .HasForeignKey(d => d.DefaultOpaccCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroAccountCode1");

                entity.HasOne(d => d.DefaultOscarbankAccCode)
                    .WithMany(p => p.OrgSettingDefaultOscarbankAccCode)
                    .HasForeignKey(d => d.DefaultOscarbankAccCodeId)
                    .HasConstraintName("FK_OSCARBankAcc");

                entity.HasOne(d => d.DefaultSpecialItemCode)
                    .WithMany(p => p.OrgSettingDefaultSpecialItemCode)
                    .HasForeignKey(d => d.DefaultSpecialItemCodeId)
                    .HasConstraintName("FK_OrgSetting_XeroItemCode7");

                entity.HasOne(d => d.DefaultSpecialTracking)
                    .WithMany(p => p.OrgSettingDefaultSpecialTracking)
                    .HasForeignKey(d => d.DefaultSpecialTrackingId)
                    .HasConstraintName("FK_OrgSetting_XeroTrackingCatOption3");

                entity.HasOne(d => d.InvoiceStatusType)
                    .WithMany(p => p.OrgSetting)
                    .HasForeignKey(d => d.InvoiceStatusTypeId)
                    .HasConstraintName("FK_OrgSetting_XeroLookup");

                entity.HasOne(d => d.Org)
                    .WithOne(p => p.OrgSetting)
                    .HasForeignKey<OrgSetting>(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgSetting_Org");
            });

            modelBuilder.Entity<OrgStandardDiscount>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstChildDiscount).HasColumnType("decimal");

                entity.Property(e => e.Hours).HasColumnType("decimal");

                entity.Property(e => e.SecondChildDiscount).HasColumnType("decimal");

                entity.Property(e => e.ThirdChildDiscount).HasColumnType("decimal");

                entity.Property(e => e.TypeOfHours)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BookingType)
                    .WithMany(p => p.OrgStandardDiscount)
                    .HasForeignKey(d => d.BookingTypeId)
                    .HasConstraintName("FK_OrgStandardDiscount_Lookup");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgStandardDiscount)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgStandardDiscount_Org");

                entity.HasOne(d => d.ProgramCategory)
                    .WithMany(p => p.OrgStandardDiscount)
                    .HasForeignKey(d => d.ProgramCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgStandardDiscount_ProgramCategory");
            });

            modelBuilder.Entity<OrgTandC>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgTandC)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgTandC_Org");
            });

            modelBuilder.Entity<OrgTermsConditions>(entity =>
            {
                entity.ToTable("Org_TermsConditions");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LogoUrl).HasColumnType("varchar(250)");

                entity.Property(e => e.TermConditions).HasColumnType("varchar(max)");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgTermsConditions)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Org_TermsConditions_Org");
            });

            modelBuilder.Entity<OrgTesting>(entity =>
            {
                entity.Property(e => e.BankAccNum).HasMaxLength(50);

                entity.Property(e => e.BookingInfoCasual).HasMaxLength(200);

                entity.Property(e => e.BookingInfoRegular).HasMaxLength(200);

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CssbillingPlanId).HasColumnName("CSSBillingPlanId");

                entity.Property(e => e.Csscomment)
                    .HasColumnName("CSSComment")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.CssrevireDate)
                    .HasColumnName("CSSRevireDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentBalance).HasColumnType("money");

                entity.Property(e => e.CurrentExpenses).HasColumnType("money");

                entity.Property(e => e.CurrentOverdueAmt).HasColumnType("money");

                entity.Property(e => e.CurrentRevenue).HasColumnType("money");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ExtraChargeType).HasMaxLength(50);

                entity.Property(e => e.ExtraMinRate).HasColumnType("decimal");

                entity.Property(e => e.HeadOfficeLogo).HasMaxLength(250);

                entity.Property(e => e.IsEmailMsgEnabled).HasColumnName("IsEMailMsgEnabled");

                entity.Property(e => e.IsSmsmsgEnabled).HasColumnName("IsSMSMsgEnabled");

                entity.Property(e => e.LeaseCostFixed).HasColumnType("decimal");

                entity.Property(e => e.LeaseEnd).HasColumnType("date");

                entity.Property(e => e.LeaseStart).HasColumnType("date");

                entity.Property(e => e.LeasorName).HasMaxLength(50);

                entity.Property(e => e.LicenceEnd).HasColumnType("datetime");

                entity.Property(e => e.LicenceFee).HasColumnType("money");

                entity.Property(e => e.LicenceStart).HasColumnType("datetime");

                entity.Property(e => e.LoginUrl)
                    .HasColumnName("LoginURL")
                    .HasMaxLength(550);

                entity.Property(e => e.Logo).HasMaxLength(255);

                entity.Property(e => e.MasterPin).HasMaxLength(50);

                entity.Property(e => e.MeetingRoom).HasMaxLength(100);

                entity.Property(e => e.MsdNum).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OscarNum).HasMaxLength(50);

                entity.Property(e => e.SiteBankAccNum).HasMaxLength(50);

                entity.Property(e => e.SiteContactEmail).HasMaxLength(100);

                entity.Property(e => e.SiteContactPersone).HasMaxLength(100);

                entity.Property(e => e.SiteContactPhone).HasMaxLength(50);

                entity.Property(e => e.StaffClockMethod).HasMaxLength(50);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.WeeklyAdminCost).HasColumnType("decimal");

                entity.Property(e => e.WeeklyRentCost).HasColumnType("decimal");

                entity.HasOne(d => d.CssbillingPlan)
                    .WithMany(p => p.OrgTesting)
                    .HasForeignKey(d => d.CssbillingPlanId)
                    .HasConstraintName("FK_OrgTesting_CSS_BillingPlan");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_OrgTesting_OrgTesting");
            });

            modelBuilder.Entity<OrgTestingSubscription>(entity =>
            {
                entity.ToTable("Org_Testing_Subscription");

                entity.Property(e => e.BankAccNum).HasMaxLength(50);

                entity.Property(e => e.BookingInfoCasual).HasMaxLength(200);

                entity.Property(e => e.BookingInfoRegular).HasMaxLength(200);

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CssbillingPlanId).HasColumnName("CSSBillingPlanId");

                entity.Property(e => e.Csscomment)
                    .HasColumnName("CSSComment")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.CssrevireDate)
                    .HasColumnName("CSSRevireDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentBalance).HasColumnType("money");

                entity.Property(e => e.CurrentExpenses).HasColumnType("money");

                entity.Property(e => e.CurrentOverdueAmt).HasColumnType("money");

                entity.Property(e => e.CurrentRevenue).HasColumnType("money");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ExtraChargeType).HasMaxLength(50);

                entity.Property(e => e.ExtraMinRate).HasColumnType("decimal");

                entity.Property(e => e.HeadOfficeLogo).HasMaxLength(250);

                entity.Property(e => e.IsEmailMsgEnabled).HasColumnName("IsEMailMsgEnabled");

                entity.Property(e => e.IsSmsmsgEnabled).HasColumnName("IsSMSMsgEnabled");

                entity.Property(e => e.LeaseCostFixed).HasColumnType("decimal");

                entity.Property(e => e.LeaseEnd).HasColumnType("date");

                entity.Property(e => e.LeaseStart).HasColumnType("date");

                entity.Property(e => e.LeasorName).HasMaxLength(50);

                entity.Property(e => e.LicenceEnd).HasColumnType("datetime");

                entity.Property(e => e.LicenceFee).HasColumnType("money");

                entity.Property(e => e.LicenceStart).HasColumnType("datetime");

                entity.Property(e => e.LoginUrl)
                    .HasColumnName("LoginURL")
                    .HasMaxLength(550);

                entity.Property(e => e.Logo).HasMaxLength(255);

                entity.Property(e => e.MasterPin).HasMaxLength(50);

                entity.Property(e => e.MeetingRoom).HasMaxLength(100);

                entity.Property(e => e.MsdNum).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OscarNum).HasMaxLength(50);

                entity.Property(e => e.SiteBankAccNum).HasMaxLength(50);

                entity.Property(e => e.SiteContactEmail).HasMaxLength(100);

                entity.Property(e => e.SiteContactPersone).HasMaxLength(100);

                entity.Property(e => e.SiteContactPhone).HasMaxLength(50);

                entity.Property(e => e.StaffClockMethod).HasMaxLength(50);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.WeeklyAdminCost).HasColumnType("decimal");

                entity.Property(e => e.WeeklyRentCost).HasColumnType("decimal");
            });

            modelBuilder.Entity<OrgTrainingModule>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.OrgTrainingModule)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_OrgTrainingModule_TrainingModule");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgTrainingModule)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_OrgTrainingModule_Org");
            });

            modelBuilder.Entity<OrgUser>(entity =>
            {
                entity.ToTable("Org_User");

                entity.HasIndex(e => e.UserId)
                    .HasName("NonClusteredIndex-20150716-195719");

                entity.HasIndex(e => new { e.OrgId, e.UserId, e.IsActive })
                    .HasName("IndexOrg_UserIsActive");

                entity.HasIndex(e => new { e.CreatedBy, e.CreatedOn, e.Id, e.IsBlackListed, e.IsInSubsidy, e.Notes, e.UpdatedBy, e.UpdatedOn, e.UserId, e.OrgId, e.IsActive })
                    .HasName("IDX_Org_UserOrgId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgUser)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Org_User_Org");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrgUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Org_User_User");
            });

            modelBuilder.Entity<OrgUserNote>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.NoteDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OrgUserId).HasColumnName("Org_UserId");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.OrgUser)
                    .WithMany(p => p.OrgUserNote)
                    .HasForeignKey(d => d.OrgUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrgUserNote_Org_User");
            });

            modelBuilder.Entity<OscarCoC>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FormLodgedDate).HasColumnType("datetime");

                entity.Property(e => e.FormReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.FormSentDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VerifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.OscarCoC)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_OscarCoC_Org");

                entity.HasOne(d => d.TermHoliday)
                    .WithMany(p => p.OscarCoCTermHoliday)
                    .HasForeignKey(d => d.TermHolidayId)
                    .HasConstraintName("FK_OscarCoC_Term1");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.OscarCoCTerm)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_OscarCoC_Term");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OscarCoC)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_OscarCoC_User");
            });

            modelBuilder.Entity<OscarDeclaration>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.Note).HasColumnType("varchar(500)");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnedDate).HasColumnType("datetime");

                entity.Property(e => e.Review).HasColumnType("datetime");

                entity.Property(e => e.Stage1Date).HasColumnType("datetime");

                entity.Property(e => e.Stage2Date).HasColumnType("datetime");

                entity.Property(e => e.Stage3Date).HasColumnType("datetime");

                entity.Property(e => e.Stage4Date).HasColumnType("datetime");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.OscarDeclaration)
                    .HasForeignKey(d => d.ChildId)
                    .HasConstraintName("FK_OscarDeclaration_Child");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.OscarDeclaration)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_OscarDeclaration_Org");

                entity.HasOne(d => d.TermHoliday)
                    .WithMany(p => p.OscarDeclarationTermHoliday)
                    .HasForeignKey(d => d.TermHolidayId)
                    .HasConstraintName("FK_OscarDeclaration_Term1");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.OscarDeclarationTerm)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_OscarDeclaration_Term");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OscarDeclaration)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_OscarDeclaration_User");
            });

            modelBuilder.Entity<OscarDelarationChild>(entity =>
            {
                entity.ToTable("OscarDelaration_Child");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.OscarDelarationChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OscarDelaration_Child_Child");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.OscarDelarationChild)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OscarDelaration_Child_Org");

                entity.HasOne(d => d.Spt)
                    .WithMany(p => p.OscarDelarationChild)
                    .HasForeignKey(d => d.SptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OscarDelaration_Child_Site_Program_Term");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OscarDelarationChild)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OscarDelaration_Child_User");
            });

            modelBuilder.Entity<OscarNote>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Identifier2).HasMaxLength(50);

                entity.Property(e => e.Note).IsRequired();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.OscarNote)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OscarNote_Lookup");
            });

            modelBuilder.Entity<OscarRenewalFormTracking>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrentReviewDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnType("varchar(250)");

                entity.Property(e => e.Note).HasColumnType("varchar(500)");

                entity.Property(e => e.ReactivationDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnedDate).HasColumnType("datetime");

                entity.Property(e => e.Stage1Date).HasColumnType("datetime");

                entity.Property(e => e.Stage2Date).HasColumnType("datetime");

                entity.Property(e => e.Stage3Date).HasColumnType("datetime");

                entity.Property(e => e.Stage4Date).HasColumnType("datetime");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.TermHoliday)
                    .WithMany(p => p.OscarRenewalFormTrackingTermHoliday)
                    .HasForeignKey(d => d.TermHolidayId)
                    .HasConstraintName("FK_OscarRenewalFormTracking_Term1");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.OscarRenewalFormTrackingTerm)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_OscarRenewalFormTracking_Term");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OscarRenewalFormTracking)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_OscarRenewalFormTracking_User");
            });

            modelBuilder.Entity<OscarSetting>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.OscarApplicationApproval).HasColumnType("varchar(max)");

                entity.Property(e => e.OscarApplicationDeclined).HasColumnType("varchar(max)");

                entity.Property(e => e.OscarApplicationRequestEmail).HasColumnType("varchar(max)");

                entity.Property(e => e.OscarCocrequest)
                    .HasColumnName("OscarCOCRequest")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.OscarDeclaration1WeeksOut).HasColumnType("varchar(max)");

                entity.Property(e => e.OscarDeclaration2WeeksOut).HasColumnType("varchar(max)");

                entity.Property(e => e.OscarDeclaration3WeeksOut).HasColumnType("varchar(max)");

                entity.Property(e => e.OscarDeclaration4WeeksOut).HasColumnType("varchar(max)");

                entity.Property(e => e.OscarDeclarationApproval).HasColumnType("varchar(max)");

                entity.Property(e => e.OscarDeclarationDeclined).HasColumnType("varchar(max)");

                entity.Property(e => e.OscarDeclarationRequest).HasColumnType("varchar(max)");

                entity.Property(e => e.OscarRenewalRequest).HasColumnType("varchar(max)");

                entity.Property(e => e.ProgramManagerEmail).HasColumnType("varchar(100)");

                entity.Property(e => e.ProgramManagerName).HasColumnType("varchar(250)");

                entity.Property(e => e.ProgramMangerPhone).HasColumnType("varchar(50)");

                entity.Property(e => e.Signature).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OscarSetting)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OscarSetting_Org");
            });

            modelBuilder.Entity<OscarTracking>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.FormLodgeNote).HasColumnType("varchar(max)");

                entity.Property(e => e.FormLodgeNoteBy).HasColumnType("varchar(50)");

                entity.Property(e => e.FormLodgedDate).HasColumnType("datetime");

                entity.Property(e => e.FormReceivedNote).HasColumnType("varchar(max)");

                entity.Property(e => e.FormReceivedNoteBy).HasColumnType("varchar(50)");

                entity.Property(e => e.FormRecievedDate).HasColumnType("datetime");

                entity.Property(e => e.FormSentDate).HasColumnType("datetime");

                entity.Property(e => e.FormSentNote).HasColumnType("varchar(max)");

                entity.Property(e => e.FormSentNoteBy).HasColumnType("varchar(50)");

                entity.Property(e => e.IntendedDate).HasColumnType("datetime");

                entity.Property(e => e.IntendedNote).HasColumnType("varchar(max)");

                entity.Property(e => e.IntendedNoteBy).HasColumnType("varchar(50)");

                entity.Property(e => e.Note).HasColumnType("varchar(500)");

                entity.Property(e => e.OscarApproveNoteBy).HasColumnType("varchar(50)");

                entity.Property(e => e.OscarApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.OscarApprovedNote).HasColumnType("varchar(max)");

                entity.Property(e => e.ReturnedToParentBy).HasColumnType("varchar(50)");

                entity.Property(e => e.ReturnedToParentDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnedToParentNote).HasColumnType("varchar(max)");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.OscarTracking)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_OscarTracking_Org");

                entity.HasOne(d => d.TermHoliday)
                    .WithMany(p => p.OscarTrackingTermHoliday)
                    .HasForeignKey(d => d.TermHolidayId)
                    .HasConstraintName("FK_OscarTracking_Term1");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.OscarTrackingTerm)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_OscarTracking_Term");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OscarTracking)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_OscarTracking_User");
            });

            modelBuilder.Entity<OscarTrackingChild>(entity =>
            {
                entity.ToTable("OscarTracking_Child");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.OscarTrackingChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OscarTracking_Child_Child");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.OscarTrackingChild)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OscarTracking_Child_Org1");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.OscarTrackingChild)
                    .HasForeignKey(d => d.TermId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OscarTracking_Child_Term");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OscarTrackingChild)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OscarTracking_Child_Org");
            });

            modelBuilder.Entity<OutgoingMessage>(entity =>
            {
                entity.HasIndex(e => new { e.IsProcessed, e.CreatedOn })
                    .HasName("NonClusteredIndex-20150216-164155");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeliveryMethod)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NumberOfSms).HasColumnName("NumberOfSMS");

                entity.Property(e => e.ProcessedOn).HasColumnType("datetime");

                entity.Property(e => e.RecipientEmail).HasColumnType("varchar(200)");

                entity.Property(e => e.RecipientMobile).HasColumnType("varchar(max)");

                entity.Property(e => e.Reference).HasColumnType("varchar(max)");

                entity.Property(e => e.ReplyEmail).HasColumnType("varchar(250)");

                entity.Property(e => e.Source).HasColumnType("varchar(max)");

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OutgoingMessage)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OutgoingMessage_User");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroLastUpdatedUtc)
                    .HasColumnName("XeroLastUpdatedUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.BillingId)
                    .HasConstraintName("FK_Payment_Billing");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_Payment_Invoice1");

                entity.HasOne(d => d.PaymentBatch)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.PaymentBatchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Payment_PaymentBatch");

                entity.HasOne(d => d.XeroInvoice)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.XeroInvoiceId)
                    .HasConstraintName("FK_Payment_XeroInvoice");

                entity.HasOne(d => d.XeroStatus)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.XeroStatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Payment_Lookup");
            });

            modelBuilder.Entity<PaymentBatch>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Errors).HasMaxLength(512);

                entity.Property(e => e.PaidBy).HasMaxLength(255);

                entity.Property(e => e.PaidOn).HasColumnType("datetime");

                entity.Property(e => e.PayerReference).HasMaxLength(255);

                entity.Property(e => e.PaymentReference)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentType).HasMaxLength(255);

                entity.Property(e => e.ResponseMessage).HasMaxLength(512);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Payer)
                    .WithMany(p => p.PaymentBatch)
                    .HasForeignKey(d => d.PayerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PaymentBatch_User");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.PaymentBatch)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_PaymentBatch_Lookup");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.PaymentBatch)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_PaymentBatch_Org");
            });

            modelBuilder.Entity<PaymentSource>(entity =>
            {
                entity.Property(e => e.CreaetedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.PaymentSource)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Payment_Invoice");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.DetailedDescription).HasMaxLength(255);

                entity.Property(e => e.GroupName).HasColumnType("varchar(50)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Permission_Lookup");
            });

            modelBuilder.Entity<PermissionUser>(entity =>
            {
                entity.ToTable("Permission_User");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pnmessage>(entity =>
            {
                entity.ToTable("PNMessage");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomisedResponsePrompt).HasMaxLength(1000);

                entity.Property(e => e.NotificationMessage).IsRequired();

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.Pnmessage)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PNMessage_Org");
            });

            modelBuilder.Entity<PnmessageResponseOption>(entity =>
            {
                entity.ToTable("PNMessageResponseOption");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ResponseOption)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.NotificationMessage)
                    .WithMany(p => p.PnmessageResponseOption)
                    .HasForeignKey(d => d.NotificationMessageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PNMessageResponseOption_PNMessage");
            });

            modelBuilder.Entity<PnmessageUser>(entity =>
            {
                entity.ToTable("PNMessage_User");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RepliedOn).HasColumnType("datetime");

                entity.Property(e => e.ResponseMessage).HasMaxLength(1000);

                entity.HasOne(d => d.NotificationMessage)
                    .WithMany(p => p.PnmessageUser)
                    .HasForeignKey(d => d.NotificationMessageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PNMessage_User_PNMessage");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PnmessageUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PNMessage_User_IdentityUser");
            });

            modelBuilder.Entity<Pnqueue>(entity =>
            {
                entity.ToTable("PNQueue");

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.NotificationMessage)
                    .WithMany(p => p.Pnqueue)
                    .HasForeignKey(d => d.NotificationMessageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PNQueue_PNMessage");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pnqueue)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PNQueue_IdentityUser");
            });

            modelBuilder.Entity<PortfolioSetting>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.PortfolioSetting)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PortfolioSetting_Org");
            });

            modelBuilder.Entity<ProfileNote>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProfileNote)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ProfileNo__UserI__3C80A0E0");
            });

            modelBuilder.Entity<ProfileNoteEntity>(entity =>
            {
                entity.ToTable("ProfileNote_Entity");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.ProfileNoteEntity)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ProfileNo__NoteI__3F5D0D8B");
            });

            modelBuilder.Entity<ProfileNoteSite>(entity =>
            {
                entity.ToTable("ProfileNote_Site");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.ProfileNoteSite)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ProfileNo__NoteI__5087998D");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ProfileNoteSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ProfileNo__SiteI__517BBDC6");
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.ParentId })
                    .HasName("IDX_Program_Program");

                entity.Property(e => e.Color).HasMaxLength(500);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HolPartTimeAmitemCodeId).HasColumnName("HolPartTimeAMItemCodeId");

                entity.Property(e => e.HolPartTimePmitemCodeId).HasColumnName("HolPartTimePMItemCodeId");

                entity.Property(e => e.ImageUrl).HasColumnType("varchar(max)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Rate1).HasColumnType("decimal");

                entity.Property(e => e.Rate2).HasColumnType("decimal");

                entity.Property(e => e.Rate3).HasColumnType("decimal");

                entity.Property(e => e.Rate4).HasColumnType("decimal");

                entity.Property(e => e.Rate5).HasColumnType("decimal");

                entity.Property(e => e.Rate6).HasColumnType("decimal");

                entity.Property(e => e.RateCasual).HasColumnType("decimal");

                entity.Property(e => e.RateFullTime).HasColumnType("decimal");

                entity.Property(e => e.RatePartTime).HasColumnType("decimal");

                entity.Property(e => e.Tags).HasMaxLength(450);

                entity.Property(e => e.TimeDescription1).HasMaxLength(200);

                entity.Property(e => e.TimeDescription2).HasMaxLength(200);

                entity.Property(e => e.TimeDescription3).HasMaxLength(200);

                entity.Property(e => e.TimeDescription4).HasMaxLength(200);

                entity.Property(e => e.TimeDescription5).HasMaxLength(200);

                entity.Property(e => e.TimeDescription6).HasMaxLength(200);

                entity.Property(e => e.TimeEnd1).HasColumnType("time(0)");

                entity.Property(e => e.TimeEnd2).HasColumnType("time(0)");

                entity.Property(e => e.TimeEnd3).HasColumnType("time(0)");

                entity.Property(e => e.TimeEnd4).HasColumnType("time(0)");

                entity.Property(e => e.TimeEnd5).HasColumnType("time(0)");

                entity.Property(e => e.TimeEnd6).HasColumnType("time(0)");

                entity.Property(e => e.TimeName1).HasMaxLength(250);

                entity.Property(e => e.TimeName2).HasMaxLength(150);

                entity.Property(e => e.TimeName3).HasMaxLength(150);

                entity.Property(e => e.TimeName4).HasMaxLength(150);

                entity.Property(e => e.TimeName5).HasMaxLength(150);

                entity.Property(e => e.TimeName6).HasMaxLength(150);

                entity.Property(e => e.TimeStart1).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart2).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart3).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart4).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart5).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart6).HasColumnType("time(0)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.CasualItemCode)
                    .WithMany(p => p.ProgramCasualItemCode)
                    .HasForeignKey(d => d.CasualItemCodeId)
                    .HasConstraintName("FK_Program_XeroCasualItemCode");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Program)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Program_ProgramCategory");

                entity.HasOne(d => d.FullTimeItemCode)
                    .WithMany(p => p.ProgramFullTimeItemCode)
                    .HasForeignKey(d => d.FullTimeItemCodeId)
                    .HasConstraintName("FK_Program_XeroFullTimeItemCode");

                entity.HasOne(d => d.HolFullTimeItemCode)
                    .WithMany(p => p.ProgramHolFullTimeItemCode)
                    .HasForeignKey(d => d.HolFullTimeItemCodeId)
                    .HasConstraintName("FK_Program_XeroHolFTItemCode");

                entity.HasOne(d => d.HolPartTimeAmitemCode)
                    .WithMany(p => p.ProgramHolPartTimeAmitemCode)
                    .HasForeignKey(d => d.HolPartTimeAmitemCodeId)
                    .HasConstraintName("FK_Program_XeroHolPTAMItemCode");

                entity.HasOne(d => d.HolPartTimePmitemCode)
                    .WithMany(p => p.ProgramHolPartTimePmitemCode)
                    .HasForeignKey(d => d.HolPartTimePmitemCodeId)
                    .HasConstraintName("FK_Program_XeroHolPTPMItemCode");

                entity.HasOne(d => d.HolShortItemCode)
                    .WithMany(p => p.ProgramHolShortItemCode)
                    .HasForeignKey(d => d.HolShortItemCodeId)
                    .HasConstraintName("FK_Program_XeroHolShortItemCode");

                entity.HasOne(d => d.HolTripItemCode)
                    .WithMany(p => p.ProgramHolTripItemCode)
                    .HasForeignKey(d => d.HolTripItemCodeId)
                    .HasConstraintName("FK_Program_XeroHolTripItemCode");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Program_Program");

                entity.HasOne(d => d.PartTimeItemCode)
                    .WithMany(p => p.ProgramPartTimeItemCode)
                    .HasForeignKey(d => d.PartTimeItemCodeId)
                    .HasConstraintName("FK_Program_XeroPartTimeItemCode");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Program)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Program_Org");

                entity.HasOne(d => d.SpecialCode)
                    .WithMany(p => p.ProgramSpecialCode)
                    .HasForeignKey(d => d.SpecialCodeId)
                    .HasConstraintName("FK_Program_XeroSpecialItemCode");

                entity.HasOne(d => d.TrackingCatOption)
                    .WithMany(p => p.Program)
                    .HasForeignKey(d => d.TrackingCatOptionId)
                    .HasConstraintName("FK_Program_XeroTrackingCatOption");

                entity.HasOne(d => d.WeeklySession)
                    .WithMany(p => p.Program)
                    .HasForeignKey(d => d.WeeklySessionId)
                    .HasConstraintName("FK_Program_Session");
            });

            modelBuilder.Entity<ProgramCategory>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BookingTemplate)
                    .WithMany(p => p.ProgramCategoryBookingTemplate)
                    .HasForeignKey(d => d.BookingTemplateId)
                    .HasConstraintName("FK_ProgramCategory_Lookup");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.ProgramCategory)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_ProgramCategory_Org");

                entity.HasOne(d => d.SignInMethod)
                    .WithMany(p => p.ProgramCategorySignInMethod)
                    .HasForeignKey(d => d.SignInMethodId)
                    .HasConstraintName("FK_ProgramCategory_LookupSignInMethod");

                entity.HasOne(d => d.SignInStrategy)
                    .WithMany(p => p.ProgramCategorySignInStrategy)
                    .HasForeignKey(d => d.SignInStrategyId)
                    .HasConstraintName("FK_ProgramCategory_LookupSignInStrategy");

                entity.HasOne(d => d.SignOutMethod)
                    .WithMany(p => p.ProgramCategorySignOutMethod)
                    .HasForeignKey(d => d.SignOutMethodId)
                    .HasConstraintName("FK_ProgramCategory_LookupSignOutMethod");

                entity.HasOne(d => d.SignOutStrategy)
                    .WithMany(p => p.ProgramCategorySignOutStrategy)
                    .HasForeignKey(d => d.SignOutStrategyId)
                    .HasConstraintName("FK_ProgramCategory_LookupSignOutStrategy");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ProgramCategoryType)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_ProgramCategory_LookupPCType");
            });

            modelBuilder.Entity<ProgramMedia>(entity =>
            {
                entity.ToTable("Program_Media");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.ProgramMedia)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Program_Media_Media");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramMedia)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Program_Media_Program");
            });

            modelBuilder.Entity<ProgramSession>(entity =>
            {
                entity.ToTable("Program_Session");

                entity.HasIndex(e => e.ProgramId)
                    .HasName("ProgramId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramSession)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Program_Session_Program");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.ProgramSession)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Program_Session_Session");

                entity.HasOne(d => d.XeroItemCode)
                    .WithMany(p => p.ProgramSession)
                    .HasForeignKey(d => d.XeroItemCodeId)
                    .HasConstraintName("FK_Program_Session_XeroItemCode");
            });

            modelBuilder.Entity<ProgramTags>(entity =>
            {
                entity.ToTable("Program_Tags");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramTags)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Program_Tags_Program");
            });

            modelBuilder.Entity<PromoCode>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.Code).HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.FinishOn).HasColumnType("date");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.Percentage).HasColumnType("decimal");

                entity.Property(e => e.StartOn).HasColumnType("date");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.PromoCode)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PromoCode_Org");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PromoCode)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PromoCode_User");
            });

            modelBuilder.Entity<PromoCodeUsage>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateUsed).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.PromoCode)
                    .WithMany(p => p.PromoCodeUsage)
                    .HasForeignKey(d => d.PromoCodeId)
                    .HasConstraintName("FK_PromoCodeUsage_PromoCode");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PromoCodeUsage)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PromoCodeUsage_User");
            });

            modelBuilder.Entity<PromoMsgTemplate>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PromoMsg).IsRequired();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.PromoMsgTemplate)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PromoMsgTemplate_Org");
            });

            modelBuilder.Entity<PublicHoliday>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PublicHoliday)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PublicHoliday_Country");
            });

            modelBuilder.Entity<PublishedProgram>(entity =>
            {
                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CountryName).HasColumnType("varchar(50)");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl).HasColumnType("varchar(max)");

                entity.Property(e => e.PostalCode).HasColumnType("varchar(50)");

                entity.Property(e => e.ProgramCategory)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SchoolName).HasColumnType("varchar(500)");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Street).HasMaxLength(500);

                entity.Property(e => e.Suburb).HasMaxLength(255);

                entity.Property(e => e.Telephone).HasMaxLength(500);

                entity.Property(e => e.TermName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<QrCode>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.QrContent).HasMaxLength(255);

                entity.Property(e => e.QrIdentity).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QrCode)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_QrCode_User");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MoreDetails).IsRequired();

                entity.Property(e => e.QuestionText).IsRequired();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.TrainingModule)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.TrainingModuleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Question_TrainingModule");
            });

            modelBuilder.Entity<QuestionOption>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.OptionText).IsRequired();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionOption)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_QuestionOption_Question");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.RatingNavigation)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Rating_Activity");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_Report_Org");
            });

            modelBuilder.Entity<ReportPeriod>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportPeriod)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportPeriod_Report");
            });

            modelBuilder.Entity<ReportPeriodSubscription>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ReportPeriod)
                    .WithMany(p => p.ReportPeriodSubscription)
                    .HasForeignKey(d => d.ReportPeriodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportPeriodSubscription_ReportPeriod");

                entity.HasOne(d => d.ReportSubscription)
                    .WithMany(p => p.ReportPeriodSubscription)
                    .HasForeignKey(d => d.ReportSubscriptionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportPeriodSubscription_ReportSubscription");
            });

            modelBuilder.Entity<ReportSubscriber>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ReportSubscription)
                    .WithMany(p => p.ReportSubscriber)
                    .HasForeignKey(d => d.ReportSubscriptionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportSubscriber_ReportSubscription");
            });

            modelBuilder.Entity<ReportSubscription>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NextDeliveredOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ReportSubscription)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportSubscription_Org");
            });

            modelBuilder.Entity<RoleTrainingModule>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.RoleTrainingModule)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_RoleTrainingModule_TrainingModule");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleTrainingModule)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleTrainingModule_UserRole");
            });

            modelBuilder.Entity<RollCallHistory>(entity =>
            {
                entity.Property(e => e.AbsentReason).HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HappenedOn).HasColumnType("datetime");

                entity.Property(e => e.KeyedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.KeyedOn).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.SignedBy).HasMaxLength(255);

                entity.HasOne(d => d.Attendance)
                    .WithMany(p => p.RollCallHistory)
                    .HasForeignKey(d => d.AttendanceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RollCallHistory_Attendance");
            });

            modelBuilder.Entity<RollCallQueue>(entity =>
            {
                entity.Property(e => e.AbsentReason).HasMaxLength(255);

                entity.Property(e => e.ActualEnd).HasColumnType("datetime");

                entity.Property(e => e.ActualEndKeyedBy).HasMaxLength(255);

                entity.Property(e => e.ActualEndKeyedOn).HasColumnType("datetime");

                entity.Property(e => e.ActualStart).HasColumnType("datetime");

                entity.Property(e => e.ActualStartKeyedBy).HasMaxLength(255);

                entity.Property(e => e.ActualStartKeyedOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorMsg).HasMaxLength(255);

                entity.Property(e => e.ProceedOn).HasColumnType("datetime");

                entity.Property(e => e.SignedBy).HasMaxLength(255);

                entity.Property(e => e.SignedInBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Attendance)
                    .WithMany(p => p.RollCallQueue)
                    .HasForeignKey(d => d.AttendanceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RollCallQueue_Attendance");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.RollCallQueue)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RollCallQueue_Child");

                entity.HasOne(d => d.Signature)
                    .WithMany(p => p.RollCallQueue)
                    .HasForeignKey(d => d.SignatureId)
                    .HasConstraintName("FK_RollCallQueue_SignoutSignature");
            });

            modelBuilder.Entity<RollOverParent>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.RollOverParent)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RollOverParent_Org");

                entity.HasOne(d => d.ProgramCategory)
                    .WithMany(p => p.RollOverParent)
                    .HasForeignKey(d => d.ProgramCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RollOverParent_ProgramCategory");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RollOverParent)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RollOverParent_User");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Authority).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DefaultTimeZone).HasColumnType("varchar(50)");

                entity.Property(e => e.Definition).HasMaxLength(255);

                entity.Property(e => e.EducationRegion).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.GenderOfStudents).HasMaxLength(255);

                entity.Property(e => e.Latitude).HasColumnType("decimal");

                entity.Property(e => e.Longitude).HasColumnType("decimal");

                entity.Property(e => e.Melaa).HasColumnName("MELAA");

                entity.Property(e => e.MinistryOfEducationLocalOffice).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.PostalAddress1).HasMaxLength(500);

                entity.Property(e => e.PostalAddress2).HasMaxLength(255);

                entity.Property(e => e.PostalAddress3).HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasMaxLength(255);

                entity.Property(e => e.Principal).HasMaxLength(255);

                entity.Property(e => e.RegionalCouncil).HasMaxLength(255);

                entity.Property(e => e.SchoolType).HasMaxLength(255);

                entity.Property(e => e.Street).HasMaxLength(500);

                entity.Property(e => e.Suburb).HasMaxLength(255);

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.TerritorialAuthority).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UrbanArea).HasMaxLength(255);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Ward).HasMaxLength(255);

                entity.Property(e => e.Website).HasMaxLength(500);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<School>(d => d.Id)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_School_School");
            });

            modelBuilder.Entity<SchoolContact>(entity =>
            {
                entity.ToTable("School_Contact");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.SchoolContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_School_Contact_Contact");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.SchoolContact)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_School_Contact_School");
            });

            modelBuilder.Entity<SchoolOrg>(entity =>
            {
                entity.ToTable("School_Org");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PickUpLocation).HasMaxLength(250);

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.SchoolOrg)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_School_Org_Org");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.SchoolOrg)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_School_Org_School");
            });

            modelBuilder.Entity<SelectedInvoice>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TotalCost).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Rate).HasColumnType("decimal");

                entity.Property(e => e.TimeEnd).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart).HasColumnType("time(0)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Session_Org");

                entity.HasOne(d => d.XeroItemCode)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.XeroItemCodeId)
                    .HasConstraintName("FK_Session_XeroItemCode");
            });

            modelBuilder.Entity<SessionDiscount>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountedRate).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ChildDiscount)
                    .WithMany(p => p.SessionDiscount)
                    .HasForeignKey(d => d.ChildDiscountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SessionDiscount_ChildDiscount");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.SessionDiscount)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SessionDiscount_Session");
            });

            modelBuilder.Entity<SignoutSignature>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SignImageFile).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.SignoutSignature)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SignoutSignature_Contact");
            });

            modelBuilder.Entity<SiteDpsdetail>(entity =>
            {
                entity.ToTable("SiteDPSDetail");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PxPayKey).HasColumnType("varchar(max)");

                entity.Property(e => e.PxPayUserId).HasColumnType("varchar(max)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SiteDpsdetail)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SiteDPSDetail_Org");
            });

            modelBuilder.Entity<SiteGroup>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UsageCode).HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SiteGroup)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SiteGroup_Org");
            });

            modelBuilder.Entity<SiteGroupBookingSpt>(entity =>
            {
                entity.ToTable("SiteGroup_Booking_Spt");

                entity.HasIndex(e => new { e.SiteGroupId, e.BookingSptId })
                    .HasName("IDX_SiteGroup_Booking_Spt_SPTID");

                entity.Property(e => e.BookingSptId).HasColumnName("Booking_SptId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.BookingSpt)
                    .WithMany(p => p.SiteGroupBookingSpt)
                    .HasForeignKey(d => d.BookingSptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SiteGroup_Booking_Spt_Booking_Spt");

                entity.HasOne(d => d.SiteGroup)
                    .WithMany(p => p.SiteGroupBookingSpt)
                    .HasForeignKey(d => d.SiteGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SiteGroup_Booking_SiteGroup");
            });

            modelBuilder.Entity<SiteNotes>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ProgramCategory)
                    .WithMany(p => p.SiteNotes)
                    .HasForeignKey(d => d.ProgramCategoryId)
                    .HasConstraintName("FK_SiteNotes_ProgramCategory");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SiteNotes)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SiteNotes_Org");
            });

            modelBuilder.Entity<SitePaymentGateway>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SitePaymentGateway)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SitePaymentGateway_Org");
            });

            modelBuilder.Entity<SitePaymentMethod>(entity =>
            {
                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.BankInfo).HasMaxLength(500);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DirectDebitForm).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SitePaymentMethod)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SitePaymentMethod_Org");
            });

            modelBuilder.Entity<SitePaymentOption>(entity =>
            {
                entity.ToTable("Site_PaymentOption");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PaymentOption)
                    .WithMany(p => p.SitePaymentOption)
                    .HasForeignKey(d => d.PaymentOptionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Site_PaymentOption_PaymentOption");
            });

            modelBuilder.Entity<SiteProgramTerm>(entity =>
            {
                entity.ToTable("Site_Program_Term");

                entity.HasIndex(e => e.TermId)
                    .HasName("IndexSite_Program_TermTermId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HolPartTimeAmitemCodeId).HasColumnName("HolPartTimeAMItemCodeId");

                entity.Property(e => e.HolPartTimePmitemCodeId).HasColumnName("HolPartTimePMItemCodeId");

                entity.Property(e => e.ImgUrl).HasColumnName("ImgURL");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.PublishedDate).HasColumnType("datetime");

                entity.Property(e => e.Rate1).HasColumnType("decimal");

                entity.Property(e => e.Rate2).HasColumnType("decimal");

                entity.Property(e => e.Rate3).HasColumnType("decimal");

                entity.Property(e => e.Rate4).HasColumnType("decimal");

                entity.Property(e => e.Rate5).HasColumnType("decimal");

                entity.Property(e => e.Rate6).HasColumnType("decimal");

                entity.Property(e => e.RateCasual).HasColumnType("decimal");

                entity.Property(e => e.RateFullTime).HasColumnType("decimal");

                entity.Property(e => e.RatePartTime).HasColumnType("decimal");

                entity.Property(e => e.TimeDescription1).HasMaxLength(200);

                entity.Property(e => e.TimeDescription2).HasMaxLength(200);

                entity.Property(e => e.TimeDescription3).HasMaxLength(200);

                entity.Property(e => e.TimeDescription4).HasMaxLength(200);

                entity.Property(e => e.TimeDescription5).HasMaxLength(200);

                entity.Property(e => e.TimeDescription6).HasMaxLength(200);

                entity.Property(e => e.TimeEnd1).HasColumnType("time(0)");

                entity.Property(e => e.TimeEnd2).HasColumnType("time(0)");

                entity.Property(e => e.TimeEnd3).HasColumnType("time(0)");

                entity.Property(e => e.TimeEnd4).HasColumnType("time(0)");

                entity.Property(e => e.TimeEnd5).HasColumnType("time(0)");

                entity.Property(e => e.TimeEnd6).HasColumnType("time(0)");

                entity.Property(e => e.TimeName1).HasMaxLength(150);

                entity.Property(e => e.TimeName2).HasMaxLength(150);

                entity.Property(e => e.TimeName3).HasMaxLength(150);

                entity.Property(e => e.TimeName4).HasMaxLength(150);

                entity.Property(e => e.TimeName5).HasMaxLength(150);

                entity.Property(e => e.TimeName6).HasMaxLength(150);

                entity.Property(e => e.TimeStart1).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart2).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart3).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart4).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart5).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart6).HasColumnType("time(0)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.CasualItemCode)
                    .WithMany(p => p.SiteProgramTermCasualItemCode)
                    .HasForeignKey(d => d.CasualItemCodeId)
                    .HasConstraintName("FK_Site_Program_Term_XeroCasualItemCode");

                entity.HasOne(d => d.FullTimeItemCode)
                    .WithMany(p => p.SiteProgramTermFullTimeItemCode)
                    .HasForeignKey(d => d.FullTimeItemCodeId)
                    .HasConstraintName("FK_Site_Program_Term_XeroFullTimeItemCode");

                entity.HasOne(d => d.HolFullTimeItemCode)
                    .WithMany(p => p.SiteProgramTermHolFullTimeItemCode)
                    .HasForeignKey(d => d.HolFullTimeItemCodeId)
                    .HasConstraintName("FK_Site_Program_Term_XeroHolFullTimeItemCode");

                entity.HasOne(d => d.HolPartTimeAmitemCode)
                    .WithMany(p => p.SiteProgramTermHolPartTimeAmitemCode)
                    .HasForeignKey(d => d.HolPartTimeAmitemCodeId)
                    .HasConstraintName("FK_Site_Program_Term_XeroHolPartTimeAMItemCode");

                entity.HasOne(d => d.HolPartTimePmitemCode)
                    .WithMany(p => p.SiteProgramTermHolPartTimePmitemCode)
                    .HasForeignKey(d => d.HolPartTimePmitemCodeId)
                    .HasConstraintName("FK_Site_Program_Term_XeroHolPartTimePMItemCode");

                entity.HasOne(d => d.HolShortItemCode)
                    .WithMany(p => p.SiteProgramTermHolShortItemCode)
                    .HasForeignKey(d => d.HolShortItemCodeId)
                    .HasConstraintName("FK_Site_Program_Term_XeroHolShortItemCode");

                entity.HasOne(d => d.HolTripItemCode)
                    .WithMany(p => p.SiteProgramTermHolTripItemCode)
                    .HasForeignKey(d => d.HolTripItemCodeId)
                    .HasConstraintName("FK_Site_Program_Term_XeroHolTripItemCode");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.SiteProgramTerm)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Site_Program_Term_User");

                entity.HasOne(d => d.ParentSpt)
                    .WithMany(p => p.InverseParentSpt)
                    .HasForeignKey(d => d.ParentSptId)
                    .HasConstraintName("FK_Site_Program_Term_Site_Program_Term");

                entity.HasOne(d => d.PartTimeItemCode)
                    .WithMany(p => p.SiteProgramTermPartTimeItemCode)
                    .HasForeignKey(d => d.PartTimeItemCodeId)
                    .HasConstraintName("FK_Site_Program_Term_XeroPartTimeItemCode");

                entity.HasOne(d => d.ProgramCategory)
                    .WithMany(p => p.SiteProgramTerm)
                    .HasForeignKey(d => d.ProgramCategoryId)
                    .HasConstraintName("FK_Site_Program_Term_ProgramCategory");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.SiteProgramTerm)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_Site_Program_Term_Program");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SiteProgramTerm)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Site_Program_Term_Org");

                entity.HasOne(d => d.SpecialItemCode)
                    .WithMany(p => p.SiteProgramTermSpecialItemCode)
                    .HasForeignKey(d => d.SpecialItemCodeId)
                    .HasConstraintName("FK_Site_Program_Term_XeroSpecialItemCode");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.SiteProgramTerm)
                    .HasForeignKey(d => d.TermId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Site_Program_Term_Term");

                entity.HasOne(d => d.TrackingCatOption)
                    .WithMany(p => p.SiteProgramTerm)
                    .HasForeignKey(d => d.TrackingCatOptionId)
                    .HasConstraintName("FK_Site_Program_Term_XeroTrackingCatOption");
            });

            modelBuilder.Entity<SptExcludeDays>(entity =>
            {
                entity.ToTable("Spt_ExcludeDays");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExcludeDate).HasColumnType("date");

                entity.HasOne(d => d.Spt)
                    .WithMany(p => p.SptExcludeDays)
                    .HasForeignKey(d => d.SptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Spt_ExcludeDays_Site_Program_Term");
            });

            modelBuilder.Entity<SptInstance>(entity =>
            {
                entity.ToTable("Spt_Instance");

                entity.Property(e => e.Cost).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecurrenceException).HasMaxLength(350);

                entity.Property(e => e.RecurrenceType).HasMaxLength(250);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.SptInstance)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Spt_Instance_Program");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SptInstance)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_Spt_Instance_Org");

                entity.HasOne(d => d.Spt)
                    .WithMany(p => p.SptInstance)
                    .HasForeignKey(d => d.SptId)
                    .HasConstraintName("FK_Spt_Instance_Site_Program_Term");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.SptInstance)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_Spt_Instance_Term");
            });

            modelBuilder.Entity<SptSession>(entity =>
            {
                entity.ToTable("Spt_Session");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.Rate).HasColumnType("decimal");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");

                entity.HasOne(d => d.Spt)
                    .WithMany(p => p.SptSession)
                    .HasForeignKey(d => d.SptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Spt_Session_Site_Program_Term");
            });

            modelBuilder.Entity<SptSiteGroup>(entity =>
            {
                entity.ToTable("Spt_SiteGroup");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.SiteGroup)
                    .WithMany(p => p.SptSiteGroup)
                    .HasForeignKey(d => d.SiteGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Spt_SiteGroup_SiteGroup");

                entity.HasOne(d => d.Spt)
                    .WithMany(p => p.SptSiteGroup)
                    .HasForeignKey(d => d.SptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Spt_SiteGroup_Site_Program_Term");
            });

            modelBuilder.Entity<StaffAvailability>(entity =>
            {
                entity.Property(e => e.Availability)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StaffAvailability)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_StaffAvailability");
            });

            modelBuilder.Entity<StaffClock>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EventCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Lat).HasColumnType("decimal");

                entity.Property(e => e.Long).HasColumnType("decimal");

                entity.Property(e => e.SyncOn).HasColumnType("datetime");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.StaffClock)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StaffClock_User");
            });

            modelBuilder.Entity<StaffClockSignature>(entity =>
            {
                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SignImageFile).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Roster)
                    .WithMany(p => p.StaffClockSignature)
                    .HasForeignKey(d => d.RosterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StaffClockSignature_StaffRoster");
            });

            modelBuilder.Entity<StaffRoster>(entity =>
            {
                entity.HasIndex(e => new { e.Description, e.EndDate, e.Id, e.Reference, e.SalaryCost, e.StaffId, e.StartDate, e.OrgId, e.IsActive })
                    .HasName("IDX_StaffRoster_RpsterStaff");

                entity.Property(e => e.ClockIn).HasColumnType("datetime");

                entity.Property(e => e.ClockInMethod).HasMaxLength(50);

                entity.Property(e => e.ClockOut).HasColumnType("datetime");

                entity.Property(e => e.ClockOutMethod).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Lat).HasColumnType("decimal");

                entity.Property(e => e.LocalCreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LocalUpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Long).HasColumnType("decimal");

                entity.Property(e => e.Reference).HasColumnType("varchar(50)");

                entity.Property(e => e.SalaryCost).HasColumnType("decimal");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.StaffRoster)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StaffRoster_Org");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_StaffRoster_StaffRoster");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.StaffRoster)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StaffRoster_User");

                entity.HasOne(d => d.TimeSheet)
                    .WithMany(p => p.StaffRoster)
                    .HasForeignKey(d => d.TimeSheetId)
                    .HasConstraintName("FK_TimeSheet_StaffRoster");
            });

            modelBuilder.Entity<StaffRosterHistory>(entity =>
            {
                entity.Property(e => e.ClockIn).HasColumnType("datetime");

                entity.Property(e => e.ClockOut).HasColumnType("datetime");

                entity.Property(e => e.Reference).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Roster)
                    .WithMany(p => p.StaffRosterHistory)
                    .HasForeignKey(d => d.RosterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StaffRosterHistory_StaffRoster");
            });

            modelBuilder.Entity<Subsidy>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.ClientNo).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Hour).HasColumnType("decimal");

                entity.Property(e => e.HourlyRate).HasColumnType("decimal");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.Subsidy)
                    .HasForeignKey(d => d.ChildId)
                    .HasConstraintName("FK_Subsidy_Child");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Subsidy)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Subsidy_User");
            });

            modelBuilder.Entity<SubsidyPayment>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceReference).HasMaxLength(200);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentType).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroUpdatedDateUtc)
                    .HasColumnName("XeroUpdatedDateUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.SubsidyPayment)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_SubsidyPayment_Invoice");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.SubsidyPayment)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_SubsidyPayment_Lookup");

                entity.HasOne(d => d.Subsidy)
                    .WithMany(p => p.SubsidyPayment)
                    .HasForeignKey(d => d.SubsidyId)
                    .HasConstraintName("FK_SubsidyPayment_Subsidy");

                entity.HasOne(d => d.SubsidyPaymentIndex)
                    .WithMany(p => p.SubsidyPayment)
                    .HasForeignKey(d => d.SubsidyPaymentIndexId)
                    .HasConstraintName("FK_SubsidyPayment_SubsidyPaymentIndex");

                entity.HasOne(d => d.XeroAccCode)
                    .WithMany(p => p.SubsidyPayment)
                    .HasForeignKey(d => d.XeroAccCodeId)
                    .HasConstraintName("FK_SubsidyPayment_XeroAccountCode");

                entity.HasOne(d => d.XeroTrackingCatOption)
                    .WithMany(p => p.SubsidyPayment)
                    .HasForeignKey(d => d.XeroTrackingCatOptionId)
                    .HasConstraintName("FK_SubsidyPayment_XeroTrackingCatOption");
            });

            modelBuilder.Entity<SubsidyPaymentIndex>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TempManualPayment>(entity =>
            {
                entity.Property(e => e.Amout).HasColumnType("decimal");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.OrgName).HasMaxLength(500);

                entity.Property(e => e.ParentName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Term>(entity =>
            {
                entity.HasIndex(e => new { e.SiteId, e.IsActive, e.DateEnd })
                    .HasName("IDX_TermSiteActiveDateEnd");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.DefaultTerm)
                    .WithMany(p => p.InverseDefaultTerm)
                    .HasForeignKey(d => d.DefaultTermId)
                    .HasConstraintName("FK_Term_Term");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Term)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Term_Org");
            });

            modelBuilder.Entity<Territory>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MfranchiseeId).HasColumnName("MFranchiseeId");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Mfranchisee)
                    .WithMany(p => p.TerritoryNavigation)
                    .HasForeignKey(d => d.MfranchiseeId)
                    .HasConstraintName("FK_Territory_Org");
            });

            modelBuilder.Entity<TimeSheet>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasMaxLength(10);

                entity.Property(e => e.Quantity).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.TimeSheet)
                    .HasForeignKey(d => d.BatchId)
                    .HasConstraintName("FK_TimeSheet_BatchTimeSheets");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.TimeSheet)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TimeSheet_Org");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TimeSheet)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TimeSheet_User");
            });

            modelBuilder.Entity<Timeline>(entity =>
            {
                entity.Property(e => e.Body).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HappendOn).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(255);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Timeline)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Timeline_User");
            });

            modelBuilder.Entity<TimelineEvent>(entity =>
            {
                entity.Property(e => e.Body).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HappendOn).HasColumnType("datetime");

                entity.Property(e => e.Image).HasMaxLength(255);

                entity.Property(e => e.ProfileImage).HasMaxLength(255);

                entity.Property(e => e.ProfileName).HasMaxLength(255);

                entity.Property(e => e.Subject).HasMaxLength(255);
            });

            modelBuilder.Entity<TimelineEventMedia>(entity =>
            {
                entity.ToTable("TimelineEvent_Media");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.TimelineEventMedia)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TimelineEvent_Media_Media");

                entity.HasOne(d => d.TimelineEvent)
                    .WithMany(p => p.TimelineEventMedia)
                    .HasForeignKey(d => d.TimelineEventId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TimelineEvent_Media_TimelineEvent");
            });

            modelBuilder.Entity<TmpContact>(entity =>
            {
                entity.ToTable("tmpContact");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.BillingAddress).HasMaxLength(500);

                entity.Property(e => e.BillingCity).HasMaxLength(50);

                entity.Property(e => e.BillingCountry).HasMaxLength(50);

                entity.Property(e => e.BillingPostcode).HasMaxLength(50);

                entity.Property(e => e.BillingStreetNum).HasMaxLength(50);

                entity.Property(e => e.BillingSuburb).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DriverLicence).HasColumnType("varchar(50)");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FamilyId).HasMaxLength(50);

                entity.Property(e => e.FamilyName).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FirstAidExpireyDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HowHear).HasMaxLength(50);

                entity.Property(e => e.Landline).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Lat).HasColumnType("varchar(50)");

                entity.Property(e => e.Lng).HasColumnType("varchar(50)");

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Notes).HasColumnType("varchar(max)");

                entity.Property(e => e.Office).HasMaxLength(50);

                entity.Property(e => e.OfficeExtension).HasMaxLength(50);

                entity.Property(e => e.OscarNum).HasMaxLength(50);

                entity.Property(e => e.PoliceCheckExprieyDate).HasColumnType("datetime");

                entity.Property(e => e.Postcode).HasMaxLength(50);

                entity.Property(e => e.Relation).HasMaxLength(50);

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.SignatureImage).HasColumnType("image");

                entity.Property(e => e.StreetNum).HasMaxLength(50);

                entity.Property(e => e.Suburb).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TmpImport>(entity =>
            {
                entity.ToTable("tmpImport");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ethnicity).HasMaxLength(50);

                entity.Property(e => e.FamilyId).HasMaxLength(50);

                entity.Property(e => e.FamilyName).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Landline).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Office).HasMaxLength(50);

                entity.Property(e => e.OfficeExtension).HasMaxLength(50);

                entity.Property(e => e.Postcode).HasMaxLength(50);

                entity.Property(e => e.Relation).HasMaxLength(50);

                entity.Property(e => e.SignatureImage).HasColumnType("image");

                entity.Property(e => e.StreetNum).HasMaxLength(50);

                entity.Property(e => e.Suburb).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TmpImportCanada>(entity =>
            {
                entity.ToTable("tmpImportCanada");

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.ChildFirst).HasMaxLength(50);

                entity.Property(e => e.ChildLast).HasMaxLength(50);

                entity.Property(e => e.City1).HasMaxLength(50);

                entity.Property(e => e.City2).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email1).HasMaxLength(50);

                entity.Property(e => e.Email2).HasMaxLength(50);

                entity.Property(e => e.FamilyId).HasMaxLength(50);

                entity.Property(e => e.FamilyName).HasMaxLength(50);

                entity.Property(e => e.First1).HasMaxLength(50);

                entity.Property(e => e.First2).HasMaxLength(50);

                entity.Property(e => e.Last1).HasMaxLength(50);

                entity.Property(e => e.Last2).HasMaxLength(50);

                entity.Property(e => e.Phone1).HasMaxLength(50);

                entity.Property(e => e.Phone2).HasMaxLength(50);

                entity.Property(e => e.Postcode1).HasMaxLength(50);

                entity.Property(e => e.Postcode2).HasMaxLength(50);

                entity.Property(e => e.StreetNum1).HasMaxLength(50);

                entity.Property(e => e.StreetNum2).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TmpUserContact>(entity =>
            {
                entity.ToTable("tmpUser_Contact");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrainingModule>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => new { e.Username, e.IsActive })
                    .HasName("IDX_UserUserNameActive");

                entity.HasIndex(e => new { e.Id, e.RoleId, e.IsActive })
                    .HasName("IndexUserRoleIdIsAvtive");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Colour).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Culture).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeId).HasMaxLength(10);

                entity.Property(e => e.ImportReference).HasMaxLength(50);

                entity.Property(e => e.IsKpfclient).HasColumnName("IsKPFClient");

                entity.Property(e => e.Language).HasMaxLength(50);

                entity.Property(e => e.LastLogedOn).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.PasswordBackup).HasColumnType("varchar(500)");

                entity.Property(e => e.PasswordHash).HasColumnType("varchar(50)");

                entity.Property(e => e.PinCode).HasMaxLength(50);

                entity.Property(e => e.StaffCostPerHour).HasColumnType("decimal");

                entity.Property(e => e.StaffPayrollLatSyncOn).HasColumnType("datetime");

                entity.Property(e => e.TimeZoneIdentifier).HasMaxLength(250);

                entity.Property(e => e.Title).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.WorkEndDate).HasColumnType("datetime");

                entity.Property(e => e.WorkStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_User_Contact");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.Id)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_IdentityUser");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_Lookup");
            });

            modelBuilder.Entity<UserChild>(entity =>
            {
                entity.ToTable("User_Child");

                entity.HasIndex(e => new { e.CreatedBy, e.CreatedOn, e.Id, e.UserId, e.ChildId })
                    .HasName("IDX_User_Child_ChildManager");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.UserChild)
                    .HasForeignKey(d => d.ChildId)
                    .HasConstraintName("FK_User_Child_Child");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserChild)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_User_Child_User");
            });

            modelBuilder.Entity<UserContact>(entity =>
            {
                entity.ToTable("User_Contact");

                entity.HasIndex(e => e.UserId)
                    .HasName("IDX_User_Contact_UserId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.UserContact)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_User_Contact_Contact");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.UserContact)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK_User_Contact_Lookup");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserContact)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_User_Contact_User");
            });

            modelBuilder.Entity<UserDiscount>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstChildDiscount).HasColumnType("decimal");

                entity.Property(e => e.SecondChildDiscount).HasColumnType("decimal");

                entity.Property(e => e.ThirdChildDiscount).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.UserDiscount)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserDiscount_Org");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDiscount)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserDiscount_User");
            });

            modelBuilder.Entity<UserDiscountAttendance>(entity =>
            {
                entity.ToTable("UserDiscount_Attendance");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Attendance)
                    .WithMany(p => p.UserDiscountAttendance)
                    .HasForeignKey(d => d.AttendanceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserDiscount_Attendance_Attendance");
            });

            modelBuilder.Entity<UserFavouriteSites>(entity =>
            {
                entity.ToTable("User_FavouriteSites");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.UserFavouriteSites)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_FavouriteSites_Org");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFavouriteSites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_FavouriteSites_User");
            });

            modelBuilder.Entity<UserMessage>(entity =>
            {
                entity.ToTable("User_Message");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.UserMessage)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_Message_DashboardMessage");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMessage)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_Message_User_Message");
            });

            modelBuilder.Entity<UserOrgAccess>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.UserOrgAccess)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserOrgAccess_Org");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserOrgAccess)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserOrgAccess_User");
            });

            modelBuilder.Entity<UserOscarSetting>(entity =>
            {
                entity.ToTable("User_OscarSetting");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(250)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.OscarSetting)
                    .WithMany(p => p.UserOscarSetting)
                    .HasForeignKey(d => d.OscarSettingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_OscarSetting_OscarSetting");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserOscarSetting)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_OscarSetting_User");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.ToTable("User_Permission");

                entity.HasIndex(e => e.UserId)
                    .HasName("IDX_User_Permission_UserId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_Permission_Permission");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_Permission_User");
            });

            modelBuilder.Entity<UserTimelineEvent>(entity =>
            {
                entity.ToTable("User_TimelineEvent");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.TimelineEvent)
                    .WithMany(p => p.UserTimelineEvent)
                    .HasForeignKey(d => d.TimelineEventId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_TimelineEvent_TimelineEvent");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTimelineEvent)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_TimelineEvent_User");
            });

            modelBuilder.Entity<UserTrainingModule>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfCompletion).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.TrainingModule)
                    .WithMany(p => p.UserTrainingModule)
                    .HasForeignKey(d => d.TrainingModuleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserTrainingModule_TrainingModule");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTrainingModule)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserTrainingModule_User");
            });

            modelBuilder.Entity<WaitingList>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.WaitingList)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WaitingList_Booking");

                entity.HasOne(d => d.Spt)
                    .WithMany(p => p.WaitingList)
                    .HasForeignKey(d => d.SptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WaitingList_Site_Program_Term");
            });

            modelBuilder.Entity<XeroAccountCode>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TaxRate).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroLastUpdatedUtc)
                    .HasColumnName("XeroLastUpdatedUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.XeroStatus)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.XeroAccountCode)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroAccountCode_Org");
            });

            modelBuilder.Entity<XeroContact>(entity =>
            {
                entity.Property(e => e.BillingCity).HasMaxLength(500);

                entity.Property(e => e.BillingCountry).HasMaxLength(500);

                entity.Property(e => e.BillingPostcode).HasMaxLength(500);

                entity.Property(e => e.BillingStreetAddress).HasMaxLength(500);

                entity.Property(e => e.BillingSuburb).HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(500);

                entity.Property(e => e.Country).HasMaxLength(500);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Fax).HasMaxLength(500);

                entity.Property(e => e.FirstName).HasMaxLength(500);

                entity.Property(e => e.Landline).HasMaxLength(500);

                entity.Property(e => e.LastName).HasMaxLength(500);

                entity.Property(e => e.Mobile).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Office).HasMaxLength(500);

                entity.Property(e => e.Postcode).HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.StreetAddress).HasMaxLength(500);

                entity.Property(e => e.Suburb).HasMaxLength(500);

                entity.Property(e => e.XeroConsumerKey)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.XeroUtcupdatedOn)
                    .HasColumnName("XeroUTCUpdatedOn")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.XeroContact)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_XeroContact_Org");
            });

            modelBuilder.Entity<XeroCreditNoteQueue>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.XeroCreditNoteQueue)
                    .HasForeignKey(d => d.CreditNoteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroCreditNoteQueue_CreditNote");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.XeroCreditNoteQueue)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroCreditNoteQueue_Org");
            });

            modelBuilder.Entity<XeroCssaccountCode>(entity =>
            {
                entity.ToTable("XeroCSSAccountCode");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TaxRate).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroLastUpdatedUtc)
                    .HasColumnName("XeroLastUpdatedUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.XeroStatus)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<XeroCssinvoiceQueue>(entity =>
            {
                entity.ToTable("XeroCSSInvoiceQueue");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GenerateInvOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<XeroCssinvoiceUpdateQueue>(entity =>
            {
                entity.ToTable("XeroCSSInvoiceUpdateQueue");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<XeroEditBookingQueue>(entity =>
            {
                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.XeroEditBookingQueue)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroEditBookingQueue_Billing");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.XeroEditBookingQueue)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroEditBookingQueue_Org");
            });

            modelBuilder.Entity<XeroEditInvoiceQueue>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.XeroEditInvoiceQueue)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroEditInvoiceQueue_Invoice");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.XeroEditInvoiceQueue)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroEditInvoiceQueue_Org");
            });

            modelBuilder.Entity<XeroInvErrorQueue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorDescription).IsRequired();

                entity.Property(e => e.ErrorType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.XeroConsumerKey)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.XeroInvQueue)
                    .WithMany(p => p.XeroInvErrorQueue)
                    .HasForeignKey(d => d.XeroInvQueueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroInvErrorQueue_XeroInvoiceQueue");
            });

            modelBuilder.Entity<XeroInvoice>(entity =>
            {
                entity.Property(e => e.AmountCredited).HasColumnType("decimal");

                entity.Property(e => e.AmountDue).HasColumnType("decimal");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.XeroConsumerKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.XeroInvoiceCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.XeroInvoice)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroInvoice_XeroLookup");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.XeroInvoice)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_XeroInvoice_User");
            });

            modelBuilder.Entity<XeroInvoiceLine>(entity =>
            {
                entity.Property(e => e.AccCode).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ProgTrackingCode).HasMaxLength(50);

                entity.Property(e => e.SiteTrackingCode).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.XeroInvoice)
                    .WithMany(p => p.XeroInvoiceLine)
                    .HasForeignKey(d => d.XeroInvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroInvoiceLine_XeroInvoice");
            });

            modelBuilder.Entity<XeroInvoiceQueue>(entity =>
            {
                entity.HasIndex(e => new { e.IsProcessed, e.GenerateInvOn, e.IsActive })
                    .HasName("NonClusteredIndex-20150717-140342");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GenerateInvOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.XeroInvoiceQueue)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroInvoiceQueue_Invoice");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.XeroInvoiceQueue)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroInvoiceQueue_Org");
            });

            modelBuilder.Entity<XeroItemCode>(entity =>
            {
                entity.Property(e => e.CostPrice).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SalePrice).HasColumnType("decimal");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.XeroUpdatedDateUtc)
                    .HasColumnName("XeroUpdatedDateUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.XeroItemCode)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroItemCode_Org");
            });

            modelBuilder.Entity<XeroLookup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<XeroPayment>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.XeroLastUpdatedUtc)
                    .HasColumnName("XeroLastUpdatedUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.XeroInvoice)
                    .WithMany(p => p.XeroPayment)
                    .HasForeignKey(d => d.XeroInvoiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroPayment_XeroInvoice");
            });

            modelBuilder.Entity<XeroPaymentQueue>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.XeroPaymentQueue)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroPaymentQueue_Org");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.XeroPaymentQueue)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroPaymentQueue_Payment");
            });

            modelBuilder.Entity<XeroProcessorState>(entity =>
            {
                entity.HasIndex(e => new { e.LastUpdated, e.XeroConsumerKey, e.IsProcessed, e.EntityType })
                    .HasName("IDX_XeroProcessorState");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.XeroConsumerKey).HasMaxLength(50);

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.XeroProcessorState)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_XeroProcessorState_Org");
            });

            modelBuilder.Entity<XeroSubsidyPaymentQueue>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.XeroSubsidyPaymentQueue)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroSubsidyPaymentQueue_Org");

                entity.HasOne(d => d.SubsidyPayment)
                    .WithMany(p => p.XeroSubsidyPaymentQueue)
                    .HasForeignKey(d => d.SubsidyPaymentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroSubsidyPaymentQueue_SubsidyPayment");
            });

            modelBuilder.Entity<XeroTrackingCatOption>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.TrackingCat)
                    .WithMany(p => p.XeroTrackingCatOption)
                    .HasForeignKey(d => d.TrackingCatId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroTrackingCatOption_XeroTrackingCategory");
            });

            modelBuilder.Entity<XeroTrackingCategory>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TrackingName).IsRequired();

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.XeroTrackingCategory)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_XeroTrackingCategory_Org");
            });

            modelBuilder.Entity<XeroTransactionLog>(entity =>
            {
                entity.Property(e => e.BillingIds).IsRequired();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.XmlData)
                    .IsRequired()
                    .HasColumnType("xml");
            });
        }
    }
}