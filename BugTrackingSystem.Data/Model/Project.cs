using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTrackingSystem.Data.Model
{
    public class Project
    {

        public int ProjectID { get; set; }

        [Index(IsUnique = true)]
        public string Name { get; set; }

        [Index(IsUnique = true)]
        public string Prefix { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual  ICollection<Bug> Bugs { get; set; } 
    }
}
