using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackingSystem.Data.Context;

namespace BugTrackingSystem.Model
{
    public class MyBug
    {
        public string Name { get; set; }
        public string Name2 { get; set; }
    }
    public class BugFactory
    {
        public MyBug GetBug()
        {
            using (AsignarContext db = new AsignarContext("AsignarDB"))
            {
                var bug = db.Bugs.First();
                var bug2 = new MyBug {Name = bug.Subject, Name2 = bug.Comments};
                return bug2;
            }
            
            
        }
    }
}
