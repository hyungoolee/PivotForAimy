using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Lookup
    {
        public Lookup()
        {
            Activity = new HashSet<Activity>();
            ActivityItem = new HashSet<ActivityItem>();
            Billing = new HashSet<Billing>();
            Booking = new HashSet<Booking>();
            BookingTemplateQueue = new HashSet<BookingTemplateQueue>();
            BookingTypeRule = new HashSet<BookingTypeRule>();
            Contact = new HashSet<Contact>();
            CreditNote = new HashSet<CreditNote>();
            Invoice = new HashSet<Invoice>();
            LocalPayment = new HashSet<LocalPayment>();
            Media = new HashSet<Media>();
            Notification = new HashSet<Notification>();
            Org = new HashSet<Org>();
            OrgDesign = new HashSet<OrgDesign>();
            OrgNotificationSetting = new HashSet<OrgNotificationSetting>();
            OrgStandardDiscount = new HashSet<OrgStandardDiscount>();
            OscarNote = new HashSet<OscarNote>();
            Payment = new HashSet<Payment>();
            PaymentBatch = new HashSet<PaymentBatch>();
            Permission = new HashSet<Permission>();
            ProgramCategoryBookingTemplate = new HashSet<ProgramCategory>();
            ProgramCategorySignInMethod = new HashSet<ProgramCategory>();
            ProgramCategorySignInStrategy = new HashSet<ProgramCategory>();
            ProgramCategorySignOutMethod = new HashSet<ProgramCategory>();
            ProgramCategorySignOutStrategy = new HashSet<ProgramCategory>();
            ProgramCategoryType = new HashSet<ProgramCategory>();
            RoleTrainingModule = new HashSet<RoleTrainingModule>();
            SitePaymentOption = new HashSet<SitePaymentOption>();
            SubsidyPayment = new HashSet<SubsidyPayment>();
            User = new HashSet<User>();
            UserContact = new HashSet<UserContact>();
        }

        public int Id { get; set; }
        public string EntityName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Index { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<ActivityItem> ActivityItem { get; set; }
        public virtual ICollection<Billing> Billing { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<BookingTemplateQueue> BookingTemplateQueue { get; set; }
        public virtual ICollection<BookingTypeRule> BookingTypeRule { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<CreditNote> CreditNote { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<LocalPayment> LocalPayment { get; set; }
        public virtual ICollection<Media> Media { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
        public virtual ICollection<Org> Org { get; set; }
        public virtual ICollection<OrgDesign> OrgDesign { get; set; }
        public virtual ICollection<OrgNotificationSetting> OrgNotificationSetting { get; set; }
        public virtual ICollection<OrgStandardDiscount> OrgStandardDiscount { get; set; }
        public virtual ICollection<OscarNote> OscarNote { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<PaymentBatch> PaymentBatch { get; set; }
        public virtual ICollection<Permission> Permission { get; set; }
        public virtual ICollection<ProgramCategory> ProgramCategoryBookingTemplate { get; set; }
        public virtual ICollection<ProgramCategory> ProgramCategorySignInMethod { get; set; }
        public virtual ICollection<ProgramCategory> ProgramCategorySignInStrategy { get; set; }
        public virtual ICollection<ProgramCategory> ProgramCategorySignOutMethod { get; set; }
        public virtual ICollection<ProgramCategory> ProgramCategorySignOutStrategy { get; set; }
        public virtual ICollection<ProgramCategory> ProgramCategoryType { get; set; }
        public virtual ICollection<RoleTrainingModule> RoleTrainingModule { get; set; }
        public virtual ICollection<SitePaymentOption> SitePaymentOption { get; set; }
        public virtual ICollection<SubsidyPayment> SubsidyPayment { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserContact> UserContact { get; set; }
    }
}
