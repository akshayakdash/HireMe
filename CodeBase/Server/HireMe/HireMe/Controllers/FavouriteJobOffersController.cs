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
using Microsoft.AspNet.Identity;
namespace HireMe.Controllers
{
    public class FavouriteJobOffersController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FavouriteJobOffers
        //public ActionResult Index()
        //{
        //    var userId = User.Identity.GetUserId();
        //    if (userId != null) { 
        //    var candidate = db.Candidates.Include(t=>t.FavouriteJobOffers).FirstOrDefault(p => p.AspNetUserId == userId);
        //    return View(candidate.FavouriteJobOffers.ToList());
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}

        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();

            var existingCandidate = db.Candidates.Include(t => t.FavouriteJobOffers.Select(c => c.Job)).FirstOrDefault(p => p.AspNetUserId == userId);
            if (existingCandidate != null && existingCandidate.FavouriteJobOffers != null && existingCandidate.FavouriteJobOffers.Count > 0)
            {
                existingCandidate.FavouriteJobOffers.ForEach(favJobRequest =>
                {
                    db.Entry(favJobRequest).Reference(p => p.Employer).Load();
                });
                return View(existingCandidate.FavouriteJobOffers);
            }

            return View();
        }

        // GET: FavouriteJobOffers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidate candidate = db.Candidates.Find(id);
            if (candidate == null)
            {
                return HttpNotFound();
            }
            return View(candidate);
        }

        // GET: FavouriteJobOffers/Create
        // GET: FavouriteJobRequests/Create
        [HttpGet]
        public ActionResult Create(int id)
        {

            // first get the logged in user id -- Employer
            var userId = User.Identity.GetUserId();

            var existingCandidate = db.Candidates.Include(t => t.FavouriteJobOffers).FirstOrDefault(p => p.AspNetUserId == userId);

            if (existingCandidate != null)
            {
                // now get the job request from id
                var jobOffer = db.JobOffers.Find(id);

                existingCandidate.FavouriteJobOffers.Add(jobOffer);
            }
            db.SaveChanges();

            NotificationFramework.SendNotification("", userId, "Job offer Shortlisted", "Job offer added to favourites");
            //return View();
            return Json("Successfully added to favourites.", JsonRequestBehavior.AllowGet);
        }

        // POST: FavouriteJobOffers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CandidateId,AspNetUserId,AgencyId,UserName,ProfilePicUrl,Gender,Age,ExperienceInYears,ExperienceInMonths,IdProofDoc,IdProofDocDesc,ProfileVerified,StaffType,Disponibility,CountryId,CityId,DistrictId,SalaryType,SalaryTypeOtherDesc,CanRead,CanWrite,ExpectedMinSalary,ExpectedMaxSalary,SleepOnSite,ExpectedMinRooms,ExpectedMaxRooms,MinGroupPeople,MaxGroupPeople,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,FirstName,LastName,ContactNo,EmailId,Address,AdditionalDescription")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                db.Candidates.Add(candidate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(candidate);
        }

        // GET: FavouriteJobOffers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidate candidate = db.Candidates.Find(id);
            if (candidate == null)
            {
                return HttpNotFound();
            }
            return View(candidate);
        }

        // POST: FavouriteJobOffers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CandidateId,AspNetUserId,AgencyId,UserName,ProfilePicUrl,Gender,Age,ExperienceInYears,ExperienceInMonths,IdProofDoc,IdProofDocDesc,ProfileVerified,StaffType,Disponibility,CountryId,CityId,DistrictId,SalaryType,SalaryTypeOtherDesc,CanRead,CanWrite,ExpectedMinSalary,ExpectedMaxSalary,SleepOnSite,ExpectedMinRooms,ExpectedMaxRooms,MinGroupPeople,MaxGroupPeople,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,FirstName,LastName,ContactNo,EmailId,Address,AdditionalDescription")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(candidate);
        }

        // GET: FavouriteJobOffers/Delete/5
        public ActionResult Delete(int? id)
        {
            // first get the logged in user id -- Employer
            var userId = User.Identity.GetUserId();

            var existingCandidate = db.Candidates.Include(t => t.FavouriteJobOffers).FirstOrDefault(p => p.AspNetUserId == userId);

            if (existingCandidate != null)
            {
                // now get the job request from id
                var jobOffer = db.JobOffers.Find(id);

                existingCandidate.FavouriteJobOffers.Remove(jobOffer);
            }
            db.SaveChanges();
            return Json("Successfully removed from your favourites.", JsonRequestBehavior.AllowGet);
        }

        // POST: FavouriteJobOffers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Candidate candidate = db.Candidates.Find(id);
            db.Candidates.Remove(candidate);
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
