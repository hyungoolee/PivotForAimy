using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Media
    {
        public Media()
        {
            ChildContactMedia = new HashSet<ChildContactMedia>();
            ChildMedia = new HashSet<ChildMedia>();
            MediaExtension = new HashSet<MediaExtension>();
            MediaLibraryMedia = new HashSet<MediaLibraryMedia>();
            ProgramMedia = new HashSet<ProgramMedia>();
            TimelineEventMedia = new HashSet<TimelineEventMedia>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EntityType { get; set; }
        public int? EntityId { get; set; }
        public int? SiteId { get; set; }
        public int? MediaTypeId { get; set; }
        public string Description { get; set; }
        public string NewFileName { get; set; }
        public string OldFileName { get; set; }
        public string Url { get; set; }
        public bool? IsProfilePicture { get; set; }
        public bool? IsMedicalPdf { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Duration { get; set; }
        public int? Size { get; set; }

        public virtual ICollection<ChildContactMedia> ChildContactMedia { get; set; }
        public virtual ICollection<ChildMedia> ChildMedia { get; set; }
        public virtual ICollection<MediaExtension> MediaExtension { get; set; }
        public virtual ICollection<MediaLibraryMedia> MediaLibraryMedia { get; set; }
        public virtual ICollection<ProgramMedia> ProgramMedia { get; set; }
        public virtual ICollection<TimelineEventMedia> TimelineEventMedia { get; set; }
        public virtual Lookup MediaType { get; set; }
        public virtual Org Site { get; set; }
    }
}
