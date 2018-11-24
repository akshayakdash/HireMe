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
    public class JobRequestsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: JobRequests
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            // get the candidateId
            var candidate = db.Candidates.FirstOrDefault(p => p.AspNetUserId == userId);
            return View(db.JobRequests
                .Include(path => path.Job)
                .Include(t => t.Candidate)
                .Where(j => j.CandidateId == candidate.CandidateId)
                .ToList());
        }

        // GET: JobRequests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobRequest jobRequest = db.JobRequests.Find(id);
            if (jobRequest == null)
            {
                return HttpNotFound();
            }
            return View(jobRequest);
        }

        // GET: JobRequests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobRequestId,CandidateId,JobId,IsPublished,PublishedDate,ValidTill,JobRequestDescription")] JobRequest jobRequest)
        {
            if (ModelState.IsValid)
            {
                db.JobRequests.Add(jobRequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobRequest);
        }

        // GET: JobRequests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobRequest jobRequest = db.JobRequests.Find(id);
            if (jobRequest == null)
            {
                return HttpNotFound();
            }
            return View(jobRequest);
        }

        // POST: JobRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobRequestId,CandidateId,JobId,IsPublished,PublishedDate,ValidTill,JobRequestDescription")] JobRequest jobRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobRequest);
        }

        // GET: JobRequests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobRequest jobRequest = db.JobRequests.Find(id);
            if (jobRequest == null)
            {
                return HttpNotFound();
            }
            return View(jobRequest);
        }

        // POST: JobRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobRequest jobRequest = db.JobRequests.Find(id);
            db.JobRequests.Remove(jobRequest);
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
