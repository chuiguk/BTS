using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackingSystem.Data.Context;
using BugTrackingSystem.Repository.Entity;

namespace BugTrackingSystem.Repository
{
    public class BugFactory
    {
        public List<MyBug> GetBugsByUser()
        {
            AsignarContext ctx = new AsignarContext("AsignarDB");
                var bugs = ctx.Bugs.Select(b => b);
                List<MyBug> myBugs = new List<MyBug>();
                foreach (var bug in bugs)
                {
                    myBugs.Add(new MyBug
                    {                        
                        Number = bug.Number,
                        Subject = bug.Subject,
                        CreationDate = bug.CreationDate,
                        ModificationDate = bug.ModificationDate,
                        Status = bug.Status,
                        Priority = bug.Priority,
                        Description = bug.Description,
                        Comments = bug.Comments
                    });
                }
                return myBugs;
            
        } 
    }
}
