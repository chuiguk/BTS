using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTrackingSystem.Data.Context;
using BugTrackingSystem.Data.Model;

namespace BugTracking.Controllers
{
    public class ProjectsController : Controller
    {
        //
        // GET: /Projects/
        public ActionResult Projects()
        {
            List<Project> list;
            using (AsignarContext ctx = new AsignarContext("AsignarDB"))
            {
                list = ctx.Projects.Select(p => p).ToList();
            }
                return View(list);
        }
	}
}