using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTrackingSystem.Data.Context;
using BugTrackingSystem.Data.Model;
using BugTrackingSystem.Repository.Entity;

namespace BugTracking.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Dashboard()
        {
            AsignarContext ctx = new AsignarContext("AsignarDB");
           
            var bugs = ctx.Bugs.ToList();
            return View(bugs);
        }
        public ActionResult MyProjects()
        {
            AsignarContext ctx = new AsignarContext("AsignarDB");
            var projects = ctx.Projects.Select(b => b).ToList();
            return PartialView(projects);
        }
        public ActionResult MyProjects2(int id)
        {
            
        }

    }
}