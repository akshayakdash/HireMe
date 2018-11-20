using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HireMe.Models;
using Microsoft.AspNet.Identity;

namespace HireMe.Controllers
{
    public class FavouriteJobRequestsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FavouriteJobRequests
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();

            var existingEmployer = db.Employers.Include(t => t.FavouriteJobRequests.Select(c => c.Job)).FirstOrDefault(p => p.AspNetUserId == userId);
            if (existingEmployer != null && existingEmployer.FavouriteJobRequests != null && existingEmployer.FavouriteJobRequests.Count > 0)
            {
                existingEmployer.FavouriteJobRequests.ForEach(favJobRequest =>
                {
                    db.Entry(favJobRequest).Reference(p => p.Candidate).Load();
                });
                return View(existingEmployer.FavouriteJobRequests);
            }

            return View();
        }

        // GET: FavouriteJobRequests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer employer = db.Employers.Find(id);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer);
        }

        // GET: FavouriteJobRequests/Create
        [HttpGet]
        public ActionResult Create(int id)
        {

            // first get the logged in user id -- Employer
            var userId = User.Identity.GetUserId();

            var existingEmployer = db.Employers.Include(t => t.FavouriteJobRequests).FirstOrDefault(p => p.AspNetUserId == userId);

            if (existingEmployer != null)
            {
                // now get the job request from id
                var jobRequest = db.JobRequests.Find(id);

                existingEmployer.FavouriteJobRequests.Add(jobRequest);
            }
            db.SaveChanges();

            //return View();
            return Json("Successfully added to favourites.", JsonRequestBehavior.AllowGet);
        }

        // POST: FavouriteJobRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployerId,AspNetUserId,Gender,CountryId,CityId,DistrictId,ProfileVerified,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,FirstName,LastName")] Employer employer)
        {
            if (ModelState.IsValid)
            {
                db.Employers.Add(employer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employer);
        }

        // GET: FavouriteJobRequests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer employer = db.Employers.Find(id);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer);
        }

        // POST: FavouriteJobRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployerId,AspNetUserId,Gender,CountryId,CityId,DistrictId,ProfileVerified,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,FirstName,LastName")] Employer employer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employer);
        }

        // GET: FavouriteJobRequests/Delete/5
        public ActionResult Delete(int? id)
        {
            // first get the logged in user id -- Employer
            var userId = User.Identity.GetUserId();

            var existingEmployer = db.Employers.Include(t => t.FavouriteJobRequests).FirstOrDefault(p => p.AspNetUserId == userId);

            if (existingEmployer != null)
            {
                // now get the job request from id
                var jobRequest = db.JobRequests.Find(id);

                existingEmployer.FavouriteJobRequests.Remove(jobRequest);
            }
            db.SaveChanges();
            return Json("Successfully removed from your favourites.", JsonRequestBehavior.AllowGet);
        }

        // POST: FavouriteJobRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employer employer = db.Employers.Find(id);
            db.Employers.Remove(employer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
