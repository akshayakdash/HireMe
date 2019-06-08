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
    public class EmployerJobOffersController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EmployerJobOffers
        public ActionResult Index()
        {
            return View(db.JobOffers.ToList());
        }

        // GET: EmployerJobOffers/Details/5
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

        // GET: EmployerJobOffers/Create here Id is the JobId e.g Nanny
        public ActionResult Create(int? id)
        {
            if (id.HasValue)
            {
                Job job = db.Jobs.Include(p => p.JobTasks).FirstOrDefault(p => p.JobId == id);

                var employerJobOfferViewModel = new EmployerJobOfferViewModel { JobId = id.Value, JobTasks = AutoMapper.Mapper.Map<List<JobTaskViewModel>>(job.JobTasks) };

                ViewBag.Cities = db.Cities.Select(p => new SelectListItem { Text = p.CityName, Value = p.CityId.ToString() }).ToList();
                ViewBag.Districts = db.Districts.Select(p => new SelectListItem { Text = p.DistrictName, Value = p.DistrictId.ToString() }).ToList();

                return View(employerJobOfferViewModel);
            }
            else
            {
                var jobCategories = db.JobCategories
                    .Include(p => p.Jobs)
                    .ToList();
                ViewBag.JobCategories = jobCategories;
                return View(new EmployerJobOfferViewModel { });

                //return RedirectToAction("", "JobCategories");
            }
        }

        // POST: EmployerJobOffers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployerJobOfferViewModel employerJobOffer)
        {
            if (ModelState.IsValid)
            {
                //db.CandidateProfiles.Add(candidateProfile);
                //db.SaveChanges();

                // first check if a candidate exists with the aspnet userid or not
                var userId = User.Identity.GetUserId();

                var existingEmployer = db.Employers.Include(path => path.JobOffers).FirstOrDefault(p => p.AspNetUserId == userId);
                if (existingEmployer == null)
                {
                    var appUser = db.Users.Find(userId);
                    var employer = new Employer { ProfileVerified = false, FirstName = appUser.FirstName, LastName = appUser.LastName, Gender = Gender.Male, JobOffers = new List<JobOffer> { } };

                    var jobOffer = AutoMapper.Mapper.Map<JobOffer>(employerJobOffer);
                    //candidate.UserName = User.Identity.GetUserName();
                    //candidate.ProfilePicUrl = appUser.ProfilePicUrl;

                    //var jobOffer = new JobRequest { IsPublished = true, PublishedDate = DateTime.Now, JobId = employerJobOffer.JobId, JobRequestJobTasks = new List<JobRequestJobTask> { } };

                    jobOffer.PublishedDate = DateTime.Now;
                    jobOffer.JobId = employerJobOffer.JobId;
                    jobOffer.IsPublished = true;
                    jobOffer.JobOfferJobTasks = new List<JobOfferJobTask> { };
                    jobOffer.AdditionalDescription = employerJobOffer.AdditionalDescription;
                    jobOffer.CountryId = 1; // TO Do _Hard coded for Ivory
                    jobOffer.CityId = employerJobOffer.CityId;
                    jobOffer.DistrictId = employerJobOffer.DistrictId;

                    var country = db.Countries.FirstOrDefault(p => p.CountryId == jobOffer.CountryId);
                    if (country != null)
                    {
                        jobOffer.Country = country.CountryName;
                    }


                    var city = db.Cities.FirstOrDefault(p => p.CityId == jobOffer.CityId);
                    if (city != null)
                    {
                        jobOffer.City = city.CityName;
                    }

                    var district = db.Districts.FirstOrDefault(p => p.DistrictId == jobOffer.DistrictId);
                    if (district != null)
                    {
                        jobOffer.District = district.DistrictName;
                    }

                    employerJobOffer.JobTasks.ForEach(task =>
                    {
                        if (task.Selected)
                        {
                            jobOffer.JobOfferJobTasks.Add(new JobOfferJobTask { JobTaskId = task.JobTaskId, TaskResponse = task.Note });
                        }
                    });

                    employer.JobOffers.Add(jobOffer);

                    var appUsr = db.Users.Include(p => p.Employers).FirstOrDefault(p => p.Id == userId);

                    appUsr.Employers.Add(employer);
                    db.SaveChanges();
                }
                else
                {


                    //var jobRequest = new JobRequest { IsPublished = true, PublishedDate = DateTime.Now, JobRequestDescription = candidateProfile.AdditionalDescription, JobId = candidateProfile.JobId, JobRequestJobTasks = new List<JobRequestJobTask> { } };
                    var jobOffer = AutoMapper.Mapper.Map<JobOffer>(employerJobOffer);
                    jobOffer.IsPublished = true;
                    jobOffer.PublishedDate = DateTime.Now;
                    jobOffer.JobId = employerJobOffer.JobId;
                    jobOffer.JobOfferJobTasks = new List<JobOfferJobTask> { };
                    jobOffer.AdditionalDescription = employerJobOffer.AdditionalDescription;

                    jobOffer.CountryId = 1; // TO Do _Hard coded for Ivory
                    jobOffer.CityId = employerJobOffer.CityId;
                    jobOffer.DistrictId = employerJobOffer.DistrictId;

                    var country = db.Countries.FirstOrDefault(p => p.CountryId == jobOffer.CountryId);
                    if (country != null)
                    {
                        jobOffer.Country = country.CountryName;
                    }


                    var city = db.Cities.FirstOrDefault(p => p.CityId == jobOffer.CityId);
                    if (city != null)
                    {
                        jobOffer.City = city.CityName;
                    }

                    var district = db.Districts.FirstOrDefault(p => p.DistrictId == jobOffer.DistrictId);
                    if (district != null)
                    {
                        jobOffer.District = district.DistrictName;
                    }
                    employerJobOffer.JobTasks.ForEach(task =>
                    {
                        if (task.Selected)
                        {
                            jobOffer.JobOfferJobTasks.Add(new JobOfferJobTask { JobTaskId = task.JobTaskId, TaskResponse = task.Note });
                        }
                    });

                    existingEmployer.JobOffers.Add(jobOffer);
                    db.SaveChanges();
                }

                // check the role and navigate to the myjobrequests page or naviget to SearchJobOffers?jobId = jobId
                return RedirectToAction("Index", "JobOffers");
            }
            Job job = db.Jobs.Include(p => p.JobTasks).FirstOrDefault(p => p.JobId == employerJobOffer.JobId);
            employerJobOffer.JobTasks = AutoMapper.Mapper.Map<List<JobTaskViewModel>>(job.JobTasks);
            return View(employerJobOffer);
        }

        // GET: EmployerJobOffers/Edit/5
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

        // POST: EmployerJobOffers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobOfferId,JobId,EmployerId,Gender,Age,ExperienceInYears,ExperienceInMonths,IdProofDoc,IdProofDocDesc,ProfileVerified,StaffType,Disponibility,CountryId,CityId,DistrictId,SalaryType,SalaryTypeOtherDesc,CanRead,CanWrite,ExpectedMinSalary,ExpectedMaxSalary,SleepOnSite,ExpectedMinRooms,ExpectedMaxRooms,MinGroupPeople,MaxGroupPeople,PublishedDate,ValidTill")] JobOffer jobOffer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobOffer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobOffer);
        }

        // GET: EmployerJobOffers/Delete/5
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

        // POST: EmployerJobOffers/Delete/5
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
