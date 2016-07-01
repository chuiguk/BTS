using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTrackingSystem.Data.Model
{
    public class User
    {
        public int UserID { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public virtual ICollection<Filter> Filters { get; set; }
        
        public virtual ICollection<Bug> Bugs { get; set; }  

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Index(IsUnique = true)]
        public string Login { get; set; }

        public string Password { get; set; }

        [Index(IsUnique = true)]
        public string Email { get; set; }

        public byte Role { get; set; }

        public string Photo { get; set; }
    }
}
