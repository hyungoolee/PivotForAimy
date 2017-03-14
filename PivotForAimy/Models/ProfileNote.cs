using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ProfileNote
    {
        public ProfileNote()
        {
            ProfileNoteEntity = new HashSet<ProfileNoteEntity>();
            ProfileNoteSite = new HashSet<ProfileNoteSite>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Note { get; set; }
        public bool RelateToChild { get; set; }
        public bool EditableByOther { get; set; }
        public bool IsActive { get; set; }
        public bool IsLatest { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int ModifiedById { get; set; }

        public virtual ICollection<ProfileNoteEntity> ProfileNoteEntity { get; set; }
        public virtual ICollection<ProfileNoteSite> ProfileNoteSite { get; set; }
        public virtual User User { get; set; }
    }
}
