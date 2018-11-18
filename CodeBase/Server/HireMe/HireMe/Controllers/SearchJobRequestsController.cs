using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HireMe.Models;
using HireMe.Utility;
using System.Collections;
using System.Linq.Dynamic;

namespace HireMe.Controllers
{
    public class SearchJobRequestsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SearchJobRequests
        public ActionResult Index(Gender? gender = null, string yearsOfExperience = "")
        {
            JobRequestSearchParam searchParam = null;//Session["JobRequestSearchParam"] as JobRequestSearchParam;

            if (gender != null || !string.IsNullOrWhiteSpace(yearsOfExperience))
            {
                searchParam = new JobRequestSearchParam { };
                searchParam.Gender = gender.Value;
                if (!string.IsNullOrWhiteSpace(yearsOfExperience))
                    searchParam.YearsOfExperience = yearsOfExperience;
            }

            if (searchParam == null)
            {
                var jobRequests = db.JobRequests.Include(j => j.Candidate).Include(j => j.Job);
                return View(jobRequests.ToList());
            }
            else
            {
                object[] queryString = searchParam.GetSearchQuery();
                ArrayList searchArgs = (ArrayList)queryString[1];
                var jobRequests = db.JobRequests
                    .Include(j => j.Candidate)
                    .Include(j => j.Job)
                    .AsQueryable()
                    .Where(queryString[0].ToString(), searchArgs.ToArray());


                //var jobRequests = db.JobRequests.Include(j => j.Candidate).Include(j => j.Job);
                return View(jobRequests.ToList());
            }
        }

        [HttpGet]
        public ActionResult SetJobRequestSearchParam(Gender gender, string yearsOfExperience)
        {
            var jobRequestSearchParam = new JobRequestSearchParam { Gender = gender };

            if (string.IsNullOrEmpty(yearsOfExperience) && yearsOfExperience != "undefined")
            {
                jobRequestSearchParam.YearsOfExperience = yearsOfExperience;
            }
            Session["JobRequestSearchParam"] = jobRequestSearchParam;
            return new JsonResult { };
        }

        // GET: SearchJobRequests/Details/5
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

        // GET: SearchJobRequests/Create
        public ActionResult Create()
        {
            ViewBag.CandidateId = new SelectList(db.Candidates, "CandidateId", "AspNetUserId");
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "JobName");
            return View();
        }

        // POST: SearchJobRequests/Create
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

            ViewBag.CandidateId = new SelectList(db.Candidates, "CandidateId", "AspNetUserId", jobRequest.CandidateId);
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "JobName", jobRequest.JobId);
            return View(jobRequest);
        }

        // GET: SearchJobRequests/Edit/5
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
            ViewBag.CandidateId = new SelectList(db.Candidates, "CandidateId", "AspNetUserId", jobRequest.CandidateId);
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "JobName", jobRequest.JobId);
            return View(jobRequest);
        }

        // POST: SearchJobRequests/Edit/5
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
            ViewBag.CandidateId = new SelectList(db.Candidates, "CandidateId", "AspNetUserId", jobRequest.CandidateId);
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "JobName", jobRequest.JobId);
            return View(jobRequest);
        }

        // GET: SearchJobRequests/Delete/5
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

        // POST: SearchJobRequests/Delete/5
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
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            //base.Dispose(disposing);
        }
    }
}
