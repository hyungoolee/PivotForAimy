using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Pnmessage
    {
        public Pnmessage()
        {
            PnmessageResponseOption = new HashSet<PnmessageResponseOption>();
            PnmessageUser = new HashSet<PnmessageUser>();
            Pnqueue = new HashSet<Pnqueue>();
        }

        public int Id { get; set; }
        public string NotificationMessage { get; set; }
        public int OrgId { get; set; }
        public bool HasCustomisedResponse { get; set; }
        public string CustomisedResponsePrompt { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<PnmessageResponseOption> PnmessageResponseOption { get; set; }
        public virtual ICollection<PnmessageUser> PnmessageUser { get; set; }
        public virtual ICollection<Pnqueue> Pnqueue { get; set; }
        public virtual Org Org { get; set; }
    }
}
