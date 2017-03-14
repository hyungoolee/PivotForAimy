using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Org
    {
        public Org()
        {
            AchievementTracking = new HashSet<AchievementTracking>();
            Activity = new HashSet<Activity>();
            BatchTimeSheets = new HashSet<BatchTimeSheets>();
            Billing = new HashSet<Billing>();
            Booking = new HashSet<Booking>();
            BookingTemplate = new HashSet<BookingTemplate>();
            ChildDiscount = new HashSet<ChildDiscount>();
            ContactGroup = new HashSet<ContactGroup>();
            CssBillingGroup = new HashSet<CssBillingGroup>();
            CssBillingGroupOrg = new HashSet<CssBillingGroupOrg>();
            CssCreditCardAccessCode = new HashSet<CssCreditCardAccessCode>();
            CssInvoice = new HashSet<CssInvoice>();
            CssPaymentSetup = new HashSet<CssPaymentSetup>();
            CssSubscription = new HashSet<CssSubscription>();
            DashboardMessage = new HashSet<DashboardMessage>();
            ExcludeDay = new HashSet<ExcludeDay>();
            FavouriteReport = new HashSet<FavouriteReport>();
            FinancialHistory = new HashSet<FinancialHistory>();
            FlyerTemplate = new HashSet<FlyerTemplate>();
            HeadCount = new HashSet<HeadCount>();
            LocalPayment = new HashSet<LocalPayment>();
            Media = new HashSet<Media>();
            MessageHistory = new HashSet<MessageHistory>();
            NotificationInstance = new HashSet<NotificationInstance>();
            NotificationReminder = new HashSet<NotificationReminder>();
            OrgAccountSoftwareSetting = new HashSet<OrgAccountSoftwareSetting>();
            OrgBillingSetting = new HashSet<OrgBillingSetting>();
            OrgChild = new HashSet<OrgChild>();
            OrgContact = new HashSet<OrgContact>();
            OrgCssBillingRule = new HashSet<OrgCssBillingRule>();
            OrgCustomize = new HashSet<OrgCustomize>();
            OrgDesign = new HashSet<OrgDesign>();
            OrgGroup = new HashSet<OrgGroup>();
            OrgMyobSetting = new HashSet<OrgMyobSetting>();
            OrgNotificationSetting = new HashSet<OrgNotificationSetting>();
            OrgReference = new HashSet<OrgReference>();
            OrgReferenceSetting = new HashSet<OrgReferenceSetting>();
            OrgStandardDiscount = new HashSet<OrgStandardDiscount>();
            OrgTandC = new HashSet<OrgTandC>();
            OrgTermsConditions = new HashSet<OrgTermsConditions>();
            OrgTrainingModule = new HashSet<OrgTrainingModule>();
            OrgUser = new HashSet<OrgUser>();
            OscarCoC = new HashSet<OscarCoC>();
            OscarDeclaration = new HashSet<OscarDeclaration>();
            OscarDelarationChild = new HashSet<OscarDelarationChild>();
            OscarSetting = new HashSet<OscarSetting>();
            OscarTracking = new HashSet<OscarTracking>();
            OscarTrackingChild = new HashSet<OscarTrackingChild>();
            PaymentBatch = new HashSet<PaymentBatch>();
            Pnmessage = new HashSet<Pnmessage>();
            PortfolioSetting = new HashSet<PortfolioSetting>();
            ProfileNoteSite = new HashSet<ProfileNoteSite>();
            Program = new HashSet<Program>();
            ProgramCategory = new HashSet<ProgramCategory>();
            PromoCode = new HashSet<PromoCode>();
            PromoMsgTemplate = new HashSet<PromoMsgTemplate>();
            Report = new HashSet<Report>();
            ReportSubscription = new HashSet<ReportSubscription>();
            RollOverParent = new HashSet<RollOverParent>();
            SchoolOrg = new HashSet<SchoolOrg>();
            Session = new HashSet<Session>();
            SiteDpsdetail = new HashSet<SiteDpsdetail>();
            SiteGroup = new HashSet<SiteGroup>();
            SiteNotes = new HashSet<SiteNotes>();
            SitePaymentGateway = new HashSet<SitePaymentGateway>();
            SitePaymentMethod = new HashSet<SitePaymentMethod>();
            SiteProgramTerm = new HashSet<SiteProgramTerm>();
            SptInstance = new HashSet<SptInstance>();
            StaffRoster = new HashSet<StaffRoster>();
            Term = new HashSet<Term>();
            TerritoryNavigation = new HashSet<Territory>();
            TimeSheet = new HashSet<TimeSheet>();
            UserDiscount = new HashSet<UserDiscount>();
            UserFavouriteSites = new HashSet<UserFavouriteSites>();
            UserOrgAccess = new HashSet<UserOrgAccess>();
            XeroAccountCode = new HashSet<XeroAccountCode>();
            XeroContact = new HashSet<XeroContact>();
            XeroCreditNoteQueue = new HashSet<XeroCreditNoteQueue>();
            XeroEditBookingQueue = new HashSet<XeroEditBookingQueue>();
            XeroEditInvoiceQueue = new HashSet<XeroEditInvoiceQueue>();
            XeroInvoiceQueue = new HashSet<XeroInvoiceQueue>();
            XeroItemCode = new HashSet<XeroItemCode>();
            XeroPaymentQueue = new HashSet<XeroPaymentQueue>();
            XeroProcessorState = new HashSet<XeroProcessorState>();
            XeroSubsidyPaymentQueue = new HashSet<XeroSubsidyPaymentQueue>();
            XeroTrackingCategory = new HashSet<XeroTrackingCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? SchoolId { get; set; }
        public int? OldId { get; set; }
        public string CompanyName { get; set; }
        public int? TypeId { get; set; }
        public int? ParentId { get; set; }
        public int? TerritoryId { get; set; }
        public int? ContactId { get; set; }
        public int? Decile { get; set; }
        public int? Roll { get; set; }
        public int? RollApproved { get; set; }
        public DateTime? LeaseStart { get; set; }
        public DateTime? LeaseEnd { get; set; }
        public string LeasorName { get; set; }
        public decimal? LeaseCostFixed { get; set; }
        public string MeetingRoom { get; set; }
        public string BankAccNum { get; set; }
        public string MsdNum { get; set; }
        public string OscarNum { get; set; }
        public string Comments { get; set; }
        public string ExtraChargeType { get; set; }
        public decimal? ExtraMinRate { get; set; }
        public int? BeforeThreshold { get; set; }
        public int? AfterThreshold { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdateOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool HasSaved { get; set; }
        public byte[] Version { get; set; }
        public DateTime? LicenceStart { get; set; }
        public DateTime? LicenceEnd { get; set; }
        public decimal? WeeklyAdminCost { get; set; }
        public decimal? WeeklyRentCost { get; set; }
        public decimal? CurrentRevenue { get; set; }
        public decimal? CurrentExpenses { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? CurrentOverdueAmt { get; set; }
        public string MasterPin { get; set; }
        public bool? IsChildPhotoEnabled { get; set; }
        public bool? IsAuthPhotoEnabled { get; set; }
        public bool? IsStaffPhotoEnabled { get; set; }
        public bool? IsMultiSitePickupEnabled { get; set; }
        public bool? IsFreeTrial { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string StaffClockMethod { get; set; }
        public int? LeaseCostPercentage { get; set; }
        public bool? IsPaymentGatewayEnabled { get; set; }
        public string SiteBankAccNum { get; set; }
        public decimal? LicenceFee { get; set; }
        public bool? IsDashboardMsgEnabled { get; set; }
        public bool? IsEmailMsgEnabled { get; set; }
        public bool? IsSmsmsgEnabled { get; set; }
        public string SiteContactPersone { get; set; }
        public string SiteContactPhoneFixed { get; set; }
        public string SiteContactEmail { get; set; }
        public bool InvoiceDateSetting { get; set; }
        public string HeadOfficeLogo { get; set; }
        public bool? IsWizard { get; set; }
        public int? LastStep { get; set; }
        public bool? IsProgrammePriceVisible { get; set; }
        public bool? IsBookingPromoMsgVisible { get; set; }
        public string BookingPromotionMsg { get; set; }
        public bool? IsHolBookingPromoMsgVisible { get; set; }
        public string HolBookingPromoMsg { get; set; }
        public bool? IsSpecialBookingPromoMsgVisible { get; set; }
        public string SpecialBookingPromoMsg { get; set; }
        public string LoginUrl { get; set; }
        public bool ShowCustomisedBooking { get; set; }
        public int? InvoiceDay { get; set; }
        public int? InvoiceDueDays { get; set; }
        public int InvoiceGenDay { get; set; }
        public int InvoiceGenWeek { get; set; }
        public int InvoiceDueDay { get; set; }
        public int InvoiceDueWeek { get; set; }
        public bool? IsInvArrearBasedOnStart { get; set; }
        public int? CssbillingPlanId { get; set; }
        public DateTime? CssrevireDate { get; set; }
        public string Csscomment { get; set; }
        public string BookingInfoRegular { get; set; }
        public string BookingInfoCasual { get; set; }
        public bool? IsNew { get; set; }
        public int? CurrentStatus { get; set; }
        public string Logo { get; set; }
        public bool? AllowOverdueNotification { get; set; }
        public bool? IsCreditCardPaymentDisabled { get; set; }
        public int? NewChildFlagDays { get; set; }
        public bool? ExclusionDayIsChargeable { get; set; }
        public bool? IsAimyClient { get; set; }
        public bool? CustomisedBookingCalendarReadOnly { get; set; }
        public bool? ShowParentDob { get; set; }
        public bool? IsMergeReconcilInvoice { get; set; }
        public bool? IsDeductByCcpayment { get; set; }
        public string SiteLandlineNumberFixed { get; set; }
        public string SiteStreetNum { get; set; }
        public string SiteAddress { get; set; }
        public string SiteSuburb { get; set; }
        public string SiteCity { get; set; }
        public string SitePostCode { get; set; }
        public string SiteCountry { get; set; }
        public string SiteLatitude { get; set; }
        public string SiteLongitude { get; set; }
        public string TimeZoneIdentifier { get; set; }
        public string Culture { get; set; }
        public string Language { get; set; }
        public string SiteContactPhone { get; set; }
        public string SiteLandlineNumber { get; set; }
        public string TradingName { get; set; }
        public string TaxNumber { get; set; }

        public virtual ICollection<AchievementTracking> AchievementTracking { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<BatchTimeSheets> BatchTimeSheets { get; set; }
        public virtual ICollection<Billing> Billing { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<BookingTemplate> BookingTemplate { get; set; }
        public virtual ICollection<ChildDiscount> ChildDiscount { get; set; }
        public virtual ICollection<ContactGroup> ContactGroup { get; set; }
        public virtual ICollection<CssBillingGroup> CssBillingGroup { get; set; }
        public virtual ICollection<CssBillingGroupOrg> CssBillingGroupOrg { get; set; }
        public virtual ICollection<CssCreditCardAccessCode> CssCreditCardAccessCode { get; set; }
        public virtual ICollection<CssInvoice> CssInvoice { get; set; }
        public virtual ICollection<CssPaymentSetup> CssPaymentSetup { get; set; }
        public virtual ICollection<CssSubscription> CssSubscription { get; set; }
        public virtual ICollection<DashboardMessage> DashboardMessage { get; set; }
        public virtual ICollection<ExcludeDay> ExcludeDay { get; set; }
        public virtual ICollection<FavouriteReport> FavouriteReport { get; set; }
        public virtual ICollection<FinancialHistory> FinancialHistory { get; set; }
        public virtual ICollection<FlyerTemplate> FlyerTemplate { get; set; }
        public virtual ICollection<HeadCount> HeadCount { get; set; }
        public virtual ICollection<LocalPayment> LocalPayment { get; set; }
        public virtual ICollection<Media> Media { get; set; }
        public virtual ICollection<MessageHistory> MessageHistory { get; set; }
        public virtual ICollection<NotificationInstance> NotificationInstance { get; set; }
        public virtual ICollection<NotificationReminder> NotificationReminder { get; set; }
        public virtual ICollection<OrgAccountSoftwareSetting> OrgAccountSoftwareSetting { get; set; }
        public virtual ICollection<OrgBillingSetting> OrgBillingSetting { get; set; }
        public virtual ICollection<OrgChild> OrgChild { get; set; }
        public virtual ICollection<OrgContact> OrgContact { get; set; }
        public virtual ICollection<OrgCssBillingRule> OrgCssBillingRule { get; set; }
        public virtual ICollection<OrgCustomize> OrgCustomize { get; set; }
        public virtual ICollection<OrgDesign> OrgDesign { get; set; }
        public virtual ICollection<OrgGroup> OrgGroup { get; set; }
        public virtual OrgInvoicingSetting OrgInvoicingSetting { get; set; }
        public virtual ICollection<OrgMyobSetting> OrgMyobSetting { get; set; }
        public virtual ICollection<OrgNotificationSetting> OrgNotificationSetting { get; set; }
        public virtual ICollection<OrgReference> OrgReference { get; set; }
        public virtual ICollection<OrgReferenceSetting> OrgReferenceSetting { get; set; }
        public virtual OrgSetting OrgSetting { get; set; }
        public virtual ICollection<OrgStandardDiscount> OrgStandardDiscount { get; set; }
        public virtual ICollection<OrgTandC> OrgTandC { get; set; }
        public virtual ICollection<OrgTermsConditions> OrgTermsConditions { get; set; }
        public virtual ICollection<OrgTrainingModule> OrgTrainingModule { get; set; }
        public virtual ICollection<OrgUser> OrgUser { get; set; }
        public virtual ICollection<OscarCoC> OscarCoC { get; set; }
        public virtual ICollection<OscarDeclaration> OscarDeclaration { get; set; }
        public virtual ICollection<OscarDelarationChild> OscarDelarationChild { get; set; }
        public virtual ICollection<OscarSetting> OscarSetting { get; set; }
        public virtual ICollection<OscarTracking> OscarTracking { get; set; }
        public virtual ICollection<OscarTrackingChild> OscarTrackingChild { get; set; }
        public virtual ICollection<PaymentBatch> PaymentBatch { get; set; }
        public virtual ICollection<Pnmessage> Pnmessage { get; set; }
        public virtual ICollection<PortfolioSetting> PortfolioSetting { get; set; }
        public virtual ICollection<ProfileNoteSite> ProfileNoteSite { get; set; }
        public virtual ICollection<Program> Program { get; set; }
        public virtual ICollection<ProgramCategory> ProgramCategory { get; set; }
        public virtual ICollection<PromoCode> PromoCode { get; set; }
        public virtual ICollection<PromoMsgTemplate> PromoMsgTemplate { get; set; }
        public virtual ICollection<Report> Report { get; set; }
        public virtual ICollection<ReportSubscription> ReportSubscription { get; set; }
        public virtual ICollection<RollOverParent> RollOverParent { get; set; }
        public virtual ICollection<SchoolOrg> SchoolOrg { get; set; }
        public virtual ICollection<Session> Session { get; set; }
        public virtual ICollection<SiteDpsdetail> SiteDpsdetail { get; set; }
        public virtual ICollection<SiteGroup> SiteGroup { get; set; }
        public virtual ICollection<SiteNotes> SiteNotes { get; set; }
        public virtual ICollection<SitePaymentGateway> SitePaymentGateway { get; set; }
        public virtual ICollection<SitePaymentMethod> SitePaymentMethod { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTerm { get; set; }
        public virtual ICollection<SptInstance> SptInstance { get; set; }
        public virtual ICollection<StaffRoster> StaffRoster { get; set; }
        public virtual ICollection<Term> Term { get; set; }
        public virtual ICollection<Territory> TerritoryNavigation { get; set; }
        public virtual ICollection<TimeSheet> TimeSheet { get; set; }
        public virtual ICollection<UserDiscount> UserDiscount { get; set; }
        public virtual ICollection<UserFavouriteSites> UserFavouriteSites { get; set; }
        public virtual ICollection<UserOrgAccess> UserOrgAccess { get; set; }
        public virtual ICollection<XeroAccountCode> XeroAccountCode { get; set; }
        public virtual ICollection<XeroContact> XeroContact { get; set; }
        public virtual ICollection<XeroCreditNoteQueue> XeroCreditNoteQueue { get; set; }
        public virtual ICollection<XeroEditBookingQueue> XeroEditBookingQueue { get; set; }
        public virtual ICollection<XeroEditInvoiceQueue> XeroEditInvoiceQueue { get; set; }
        public virtual ICollection<XeroInvoiceQueue> XeroInvoiceQueue { get; set; }
        public virtual ICollection<XeroItemCode> XeroItemCode { get; set; }
        public virtual ICollection<XeroPaymentQueue> XeroPaymentQueue { get; set; }
        public virtual ICollection<XeroProcessorState> XeroProcessorState { get; set; }
        public virtual ICollection<XeroSubsidyPaymentQueue> XeroSubsidyPaymentQueue { get; set; }
        public virtual ICollection<XeroTrackingCategory> XeroTrackingCategory { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual CssBillingPlan1 CssbillingPlan { get; set; }
        public virtual Org Parent { get; set; }
        public virtual ICollection<Org> InverseParent { get; set; }
        public virtual School School { get; set; }
        public virtual Territory Territory { get; set; }
        public virtual Lookup Type { get; set; }
    }
}
