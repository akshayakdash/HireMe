using HireMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace HireMe.Controllers
{
    public class PublishedJobsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: PublishedJobs
        public ActionResult Index(int? id)
        {

            if (id != null && id.HasValue)
            {
                return View();
            }
            else
            {
                var categories = db.JobCategories.Include(p => p.Jobs).ToList();
                var jobs = db.Jobs.ToList();
                return View(categories);
            }
        }
    }
}