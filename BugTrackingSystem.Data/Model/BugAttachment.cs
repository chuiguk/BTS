using System.ComponentModel.DataAnnotations;

namespace BugTrackingSystem.Data.Model
{
    public class BugAttachment
    {
        public int BugAttachmentID { get; set; }

        [Required]
        public Bug Bug { get; set; }

        public string Attachment { get; set; }
    }
}
