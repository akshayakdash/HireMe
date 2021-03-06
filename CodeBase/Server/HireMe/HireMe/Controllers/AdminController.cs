﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HireMe.Models;
using HireMe.Utility;
using System.Threading.Tasks;
using PagedList;

namespace HireMe.Controllers
{
    public class AdminController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public ActionResult Agencies(int? page)
        {
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            var agencies = db.Agencies
                .Include(p => p.ApplicationUser)
                .OrderByDescending(p => p.AgencyId)
                .ToPagedList(pageIndex, pageSize);
            return View(agencies);
        }

        public ActionResult ActivateAgency(int id)
        {
            // first get the agency by Id
            var agency = db.Agencies.Find(id);
            // if agency is null throw an exception
            if (agency == null)
                throw new Exception("Agency Not Found.");
            agency.ProfileVerified = true;
            db.SaveChanges();

            NotificationFramework.SendNotification("", agency.AspNetUserId, "Agency Account Activation - JOBTek", "Your Agency Account " + agency.AgencyName + " was activated by Admin on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            // else return success message
            return Json("Agency profile Verified Successfully", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Candidates(int? page)
        {
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            var candidates = db.Candidates
                .Include(p => p.ApplicationUser)
                .Where(p => (p.IdProofDoc != null && p.IdProofDoc != "") && !p.ProfileVerified)
                .OrderByDescending(p => p.CandidateId)
                .ToPagedList(pageIndex, pageSize);
            return View(candidates);
        }

        public async Task<ActionResult> ActivateCandidate(int id)
        {
            // first get the candidate by Id
            var candidate = db.Candidates.Find(id);
            // if candidate is null throw an exception
            if (candidate == null)
                throw new Exception("Candidate Not Found.");
            candidate.ProfileVerified = true;
            db.SaveChanges();

             NotificationFramework.SendNotification("", candidate.AspNetUserId, "Candidate Account Activation - JOBTek", "Your candidate Account " + candidate.FirstName + " was activated by Admin on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            // else return success message
            return Json("Candidate profile Verified Successfully", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Employers(int? page)
        {
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            var employers = db.Employers
                .Include(p => p.ApplicationUser)
                .Where(p => (p.IdProofDoc != null && p.IdProofDoc != "") && !p.ProfileVerified)
                .OrderByDescending(p => p.EmployerId)
                .ToPagedList(pageIndex, pageSize);
            return View(employers);
        }

        public async Task<ActionResult> ActivateEmployer(int id)
        {
            // first get the candidate by Id
            var employer = db.Employers.Find(id);
            // if candidate is null throw an exception
            if (employer == null)
                throw new Exception("Employer Not Found.");
            employer.ProfileVerified = true;
            db.SaveChanges();

            await NotificationFramework.SendNotification("", employer.AspNetUserId, "Account Activation - JOBTek", "Your employer Account " + employer.FirstName + " was activated by Admin on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            // else return success message
            return Json("Employer profile Verified Successfully", JsonRequestBehavior.AllowGet);
        }


        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Agencies.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agency agency = db.Agencies.Find(id);
            if (agency == null)
            {
                return HttpNotFound();
            }
            return View(agency);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgencyId,AspNetUserId,AgencyName,AgencyLogo,AgencyWebsiteURL,ManagerFirstName,ManagerLastName,ManagerAge,CompanyActivityDesc,CountryId,CityId,DistrictId,ProfileVerified,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Agency agency)
        {
            if (ModelState.IsValid)
            {
                db.Agencies.Add(agency);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agency);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agency agency = db.Agencies.Find(id);
            if (agency == null)
            {
                return HttpNotFound();
            }
            return View(agency);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgencyId,AspNetUserId,AgencyName,AgencyLogo,AgencyWebsiteURL,ManagerFirstName,ManagerLastName,ManagerAge,CompanyActivityDesc,CountryId,CityId,DistrictId,ProfileVerified,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Agency agency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agency);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agency agency = db.Agencies.Find(id);
            if (agency == null)
            {
                return HttpNotFound();
            }
            return View(agency);
        }

        [HttpGet]
        public ActionResult ExportMembers()
        {
            return View();
        }

        [HttpGet]
        [Obsolete]
        public ActionResult ValidateUserProfiles()
        {
            return View();
        }


        [HttpGet]
        public ActionResult ValidateJobOffers(int? jobCat, int? page)
        {
            jobCat = jobCat ?? 1;
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;

            var jobOffers = db.JobOffers.AsNoTracking()
               .Include(path => path.Job)
               .Where(p => p.Job.JobCategoryId == jobCat)
               .Include(t => t.Employer)
               .Where(p => !p.VerifiedByAdmin)
               .OrderByDescending(p => p.JobOfferId)
               .ToPagedList(pageIndex, pageSize);
            return View(jobOffers);
        }

        [HttpGet]
        public ActionResult ValidateJobRequests(int? jobCat, int? page )
        {
            jobCat = jobCat ?? 1;
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            //var  = db.Employers
            //    .Include(p => p.ApplicationUser)
            //    .Where(p => (p.IdProofDoc != null && p.IdProofDoc != "") && !p.ProfileVerified)
            //    .OrderByDescending(p => p.EmployerId)
            //    .ToPagedList(pageIndex, pageSize);
            //return View(employers);
             var jobRequests = db.JobRequests.AsNoTracking()
               .Include(path => path.Job)
               .Where(p => p.Job.JobCategoryId == jobCat)
               .Include(t => t.Candidate)
               .Where(p => !p.VerifiedByAdmin)
               .OrderByDescending(p => p.JobRequestId)
               .ToPagedList(pageIndex, pageSize);
            return View(jobRequests);
        }

        [HttpGet]
        public ActionResult ValidateJobRequest(int jobRequestId)
        {
            var jobRequest = db.JobRequests.Find(jobRequestId);
            if (jobRequest == null)
                return HttpNotFound();
            // now update two columns of JobRequest
            jobRequest.VerifiedByAdmin = true;
            jobRequest.VerificationDate = DateTime.Now;
            db.SaveChanges();

            var candidate = db.Candidates.Find(jobRequest.CandidateId);
            if (candidate != null)
            {
                var job = db.Jobs.Find(jobRequest.JobId);
                NotificationFramework.SendNotification("", candidate.AspNetUserId, "Job Request Verified - JOBTek", "Your job requrest for " + job.JobName + " was verified by Admin on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            }
            // we need to send a notification to the user about the job request verifications

            return Json("Job request verified successfully.", JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public ActionResult ValidateJobOffer(int jobOfferId)
        {
            var jobOffer = db.JobOffers.Find(jobOfferId);
            if (jobOffer == null)
                return HttpNotFound();
            // now update two columns of JobRequest
            jobOffer.VerifiedByAdmin = true;
            jobOffer.VerificationDate = DateTime.Now;
            db.SaveChanges();

            // we need to send a notification to the user about the job request verifications
            var employer = db.Employers.Find(jobOffer.EmployerId);
            if (employer != null)
            {
                var job = db.Jobs.Find(jobOffer.JobId);
                NotificationFramework.SendNotification("", employer.AspNetUserId, "Job Offer Verified - JOBTek", "Your job requrest for " + job.JobName + " was verified by Admin on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            }

            return Json("Job offer verified successfully.", JsonRequestBehavior.AllowGet);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Agency agency = db.Agencies.Find(id);
            db.Agencies.Remove(agency);
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
