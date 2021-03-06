﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HireMe.Models;
using Microsoft.AspNet.Identity;
using HireMe.Utility;

namespace HireMe.Controllers
{
    public class JobOffersController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: JobOffers
        public ActionResult Index()
        {
            // first check if the employer is logged in or not
            var userId = User.Identity.GetUserId();
            //if (!string.IsNullOrWhiteSpace(userId))
            //{
                // get the agencyid
                var employer = db.Employers.FirstOrDefault(p => p.AspNetUserId == userId);

                if (employer != null)
                {
                    var jobOffers = db.JobOffers
                        .Include(path => path.Job)
                        .Include(t => t.Employer)
                        .Where(p => p.EmployerId == employer.EmployerId)
                        .ToList();
                    return View(jobOffers);
                }
                else
                {
                    return View();
                }
            //}
            //else
            //{
            //    // a anonymous user may be interested to see the job offers of the portal

            //    var jobOffers = db.JobOffers
            //           .Include(path => path.Job)
            //           .Include(t => t.Employer)
            //           .OrderByDescending(p => p.JobOfferId)
            //           .ToList();
            //    return View(jobOffers);
            //}


        }

        // GET: JobOffers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobOffer jobOffer = db.JobOffers
                .Include(t => t.JobOfferJobTasks)
                .Include(p => p.Employer)
                .Include(t => t.Job)
                .FirstOrDefault(c => c.JobOfferId == id);

            jobOffer.MasterJobTasks = db.Jobs
                .Include(p => p.JobTasks)
                .FirstOrDefault(p => p.JobId == jobOffer.JobId)
                .JobTasks;

            var userId = jobOffer.Employer.AspNetUserId;
            // get all the feedbacks given to the user
            var userFeedbacks = db.UserFeedbacks.Include(p => p.Sender).Where(p => p.ReceiverId == userId);
            ViewBag.UserFeedbacks = userFeedbacks.ToList();

            if (jobOffer == null)
            {
                return HttpNotFound();
            }
            return View(jobOffer);
        }

        // GET: JobOffers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobOffers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobOfferId,JobId,EmployerId,Gender,Age,MinAge,MaxAge,ExperienceInYears,ExperienceInMonths,IdProofDoc,IdProofDocDesc,ProfileVerified,StaffType,Disponibility,CountryId,CityId,DistrictId,SalaryType,SalaryTypeOtherDesc,CanRead,CanWrite,ExpectedMinSalary,ExpectedMaxSalary,SleepOnSite,ExpectedMinRooms,ExpectedMaxRooms,MinGroupPeople,MaxGroupPeople,IsPublished,PublishedDate,ValidTill")] JobOffer jobOffer)
        {
            if (ModelState.IsValid)
            {
                db.JobOffers.Add(jobOffer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobOffer);
        }

        // GET: JobOffers/Edit/5
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
            return View(jobOffer);
        }

        // POST: JobOffers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobOfferId,JobId,EmployerId,Gender,Age,MinAge,MaxAge,ExperienceInYears,ExperienceInMonths,IdProofDoc,IdProofDocDesc,ProfileVerified,StaffType,Disponibility,CountryId,CityId,DistrictId,SalaryType,SalaryTypeOtherDesc,CanRead,CanWrite,ExpectedMinSalary,ExpectedMaxSalary,SleepOnSite,ExpectedMinRooms,ExpectedMaxRooms,MinGroupPeople,MaxGroupPeople,IsPublished,PublishedDate,ValidTill")] JobOffer jobOffer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobOffer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobOffer);
        }

        // GET: JobOffers/Delete/5
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

        // POST: JobOffers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobOffer jobOffer = db.JobOffers.Find(id);
            db.JobOffers.Remove(jobOffer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult SaveJobOfferNote(JobOfferNote jobOfferNote)
        {
            var userId = User.Identity.GetUserId();
            // get the employer
            var candidate = db.Candidates.FirstOrDefault(p => p.AspNetUserId == userId);
            jobOfferNote.CandidateId = candidate.CandidateId;
            var jobOffer = db.JobOffers
                .Include(d => d.Job)
                .Include(p => p.JobOfferNotes)
                .FirstOrDefault(p => p.JobOfferId == jobOfferNote.JobOfferId);
            if (jobOffer == null)
                return HttpNotFound();
            jobOffer.JobOfferNotes.Add(jobOfferNote);

            // now we need to make an entry to the user feed back
            //var userId = User.Identity.GetUserId();
            var employer = db.Employers.Find(jobOffer.EmployerId);
            // if userId is null then probably we need to get the user id from the employerid from jobrequestnote
            var userFeedback = new UserFeedback { SenderId = userId, ReceiverId = employer.AspNetUserId, CreatedDate = DateTime.Now, Comments = jobOfferNote.Note, JobName = jobOffer.Job.JobName, Rating = jobOfferNote.StarRating };
            db.UserFeedbacks.Add(userFeedback);
            db.SaveChanges();


            // get the userid who has created the job request
            //var employer = db.Employers.Find(jobOffer.EmployerId);
            if (candidate != null)
            {
                NotificationFramework.SendNotification(userId, employer.AspNetUserId, "Job Offer Note", jobOfferNote.Note, 0, true);
            }

            return Json("Note added successfully.", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetJobOfferNotePartialView(int jobOfferId)
        {
            var userId = User.Identity.GetUserId();
            // get the employer
            var candidate = db.Candidates.FirstOrDefault(p => p.AspNetUserId == userId);
            if (candidate != null)
            {
                var jobOffer = db.JobOffers
                    .FirstOrDefault(p => p.JobOfferId == jobOfferId);
                if (jobOffer == null)
                    return HttpNotFound();
                db.Entry(jobOffer).Collection(p => p.JobOfferNotes).Query().Where(p => p.CandidateId == candidate.CandidateId).Load();
                return PartialView("_jobOfferNotes", jobOffer.JobOfferNotes);
            }
            return PartialView("_jobOfferNotes");
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
