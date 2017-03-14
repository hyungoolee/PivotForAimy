using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgEmailBodyTemplate
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string NewRegistrationTemplate { get; set; }
        public string ParentUpdateNotification { get; set; }
        public string ChildUpdateNotification { get; set; }
        public string NewBookingAlertForUser { get; set; }
        public string NewBookingAlertForAdmin { get; set; }
        public string BookingConfirmed { get; set; }
        public string FirstOverduePaymentAlert { get; set; }
        public string SecondOverduePaymentAlert { get; set; }
        public string ThirdOverduePaymentAlert { get; set; }
        public string PaymentMadeSuccess { get; set; }
        public string ResetPassword { get; set; }
        public string StaffRosterAlert { get; set; }
        public string AbsentAlert { get; set; }
        public string PoliceCertificateExpire { get; set; }
        public string FirstAidCertificateExpire { get; set; }
        public string StaffProfileUpdateNotification { get; set; }
        public string OscarApplicationRequestEmail { get; set; }
        public string OscarApplicationApproval { get; set; }
        public string OscarApplicationDeclined { get; set; }
        public string OscarDeclarationRequest { get; set; }
        public string OscarDeclarationApproval { get; set; }
        public string OscarDeclarationDeclined { get; set; }
        public string OscarDeclaration4WeeksOut { get; set; }
        public string OscarDeclaration3WeeksOut { get; set; }
        public string OscarDeclaration2WeeksOut { get; set; }
        public string OscarDeclaration1WeeksOut { get; set; }
        public string OscarCocrequest { get; set; }
        public string OscarRenewalRequest { get; set; }
        public string OscarRenewal4WeeksOut { get; set; }
        public string OscarRenewal3WeeksOut { get; set; }
        public string OscarRenewal2WeeksOut { get; set; }
        public string OscarRenewal1WeeksOut { get; set; }
        public string OscarRenewalApproval { get; set; }
        public string OscarRenewalDecline { get; set; }
        public string OscarCocapproval { get; set; }
        public string OscarCocdecline { get; set; }
    }
}
