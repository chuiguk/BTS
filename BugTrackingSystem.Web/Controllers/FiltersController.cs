using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTrackingSystem.Data.Context;

namespace BugTracking.Controllers
{
    public class FiltersController : Controller
    {
        //
        // GET: /Filters/
        public ActionResult Filters()
        {
            AsignarContext ctx = new AsignarContext("AsignarDB");
            var filters = ctx.Filters.Select(f => f).ToList();
            return View(filters);
        }
	}
}