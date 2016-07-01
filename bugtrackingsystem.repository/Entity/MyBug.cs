using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.Repository.Entity
{
    public class MyBug
    {        

        public string ProjectPrefix { get; set; }

        public int Number { get; set; }

        public string Subject { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModificationDate { get; set; }

        public byte Status { get; set; }

        public byte Priority { get; set; }

        public string Description { get; set; }

        public string Comments { get; set; }
    }
}
