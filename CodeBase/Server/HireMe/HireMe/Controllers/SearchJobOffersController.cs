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
    public class SearchJobOffersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        /// <summary>
        /// This method checks if the candidate profile exists or not 
        /// if the candidate profile exists then it will navigate to the search employer page
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CheckCandidateProfileExists()
        {
            var userId = User.Identity.GetUserId();

            var existingCandidate = db.Candidates.Include(path => path.JobRequests).FirstOrDefault(p => p.AspNetUserId == userId);

            if (existingCandidate != null && existingCandidate.JobRequests != null && existingCandidate.JobRequests.Count > 0)
            {
                return RedirectToAction("", "SearchJobOffers", null);
            }
            else
            {
                return RedirectToAction("", "JobCategories", null);
            }
        }

        // GET: SearchJobOffers
        public ActionResult Index()
        {
            //var jobOffers = db.JobOffers.Include(j => j.Employer).Include(j => j.Job);
            return View();
        }

        // GET: SearchJobOffers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobOffer jobOffer = db.JobOffers.Find(id);
            if (jobOffer == null)
            {
                return HttpNotFound();
            }
            return View(jobOffer);
        }

        // GET: SearchJobOffers/Create
        public ActionResult Create()
        {
            ViewBag.EmployerId = new SelectList(db.Employers, "EmployerId", "AspNetUserId");
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "JobName");
            return View();
        }

        // POST: SearchJobOffers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobOfferId,JobId,EmployerId,Gender,Age,MinAge,MaxAge,ExperienceInYears,ExperienceInMonths,IdProofDoc,IdProofDocDesc,ProfileVerified,StaffType,Disponibility,CountryId,CityId,DistrictId,SalaryType,SalaryTypeOtherDesc,CanRead,CanWrite,ExpectedMinSalary,ExpectedMaxSalary,SleepOnSite,ExpectedMinRooms,ExpectedMaxRooms,MinGroupPeople,MaxGroupPeople,IsPublished,PublishedDate,ValidTill,AdditionalDescription")] JobOffer jobOffer)
        {
            if (ModelState.IsValid)
            {
                db.JobOffers.Add(jobOffer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployerId = new SelectList(db.Employers, "EmployerId", "AspNetUserId", jobOffer.EmployerId);
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "JobName", jobOffer.JobId);
            return View(jobOffer);
        }

        // GET: SearchJobOffers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobOffer jobOffer = db.JobOffers.Find(id);
            if (jobOffer == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployerId = new SelectList(db.Employers, "EmployerId", "AspNetUserId", jobOffer.EmployerId);
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "JobName", jobOffer.JobId);
            return View(jobOffer);
        }

        // POST: SearchJobOffers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobOfferId,JobId,EmployerId,Gender,Age,MinAge,MaxAge,ExperienceInYears,ExperienceInMonths,IdProofDoc,IdProofDocDesc,ProfileVerified,StaffType,Disponibility,CountryId,CityId,DistrictId,SalaryType,SalaryTypeOtherDesc,CanRead,CanWrite,ExpectedMinSalary,ExpectedMaxSalary,SleepOnSite,ExpectedMinRooms,ExpectedMaxRooms,MinGroupPeople,MaxGroupPeople,IsPublished,PublishedDate,ValidTill,AdditionalDescription")] JobOffer jobOffer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobOffer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployerId = new SelectList(db.Employers, "EmployerId", "AspNetUserId", jobOffer.EmployerId);
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "JobName", jobOffer.JobId);
            return View(jobOffer);
        }

        // GET: SearchJobOffers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobOffer jobOffer = db.JobOffers.Find(id);
            if (jobOffer == null)
            {
                return HttpNotFound();
            }
            return View(jobOffer);
        }

        // POST: SearchJobOffers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobOffer jobOffer = db.JobOffers.Find(id);
            db.JobOffers.Remove(jobOffer);
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
