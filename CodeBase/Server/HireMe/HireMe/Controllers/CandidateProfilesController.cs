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
using AutoMapper;
using System.IO;

namespace HireMe.Controllers
{
    public class CandidateProfilesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //// GET: CandidateProfiles
        public ActionResult Index()
        {
            var candidatesEntity = db.Candidates
                .Include(p => p.JobRequests.Select(t => t.JobRequestJobTasks))
                .ToList();
            var candidates = Mapper.Map<List<CandidateProfileViewModel>>(candidatesEntity);
            return View(candidates);
        }

        //// GET: CandidateProfiles/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CandidateProfile candidateProfile = db.CandidateProfiles.Find(id);
        //    if (candidateProfile == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(candidateProfile);
        //}

        // GET: CandidateProfiles/Create
        public ActionResult Create(int? id)
        {
            // now prepare the job tasks for the job

            // get the job tasks for a job
            if (id.HasValue)
            {
                Job job = db.Jobs.Include(p => p.JobTasks).FirstOrDefault(p => p.JobId == id);

                var candidateProfile = new CandidateProfileViewModel { JobId = id.Value, JobTasks = AutoMapper.Mapper.Map<List<JobTaskViewModel>>(job.JobTasks) };

                ViewBag.Cities = db.Cities.Select(p => new SelectListItem { Text = p.CityName, Value = p.CityId.ToString() }).ToList();
                ViewBag.Districts = db.Districts.Select(p => new SelectListItem { Text = p.DistrictName, Value = p.DistrictId.ToString() }).ToList();

                return View(candidateProfile);
            }
            else
            {
                ViewBag.Cities = db.Cities.Select(p => new SelectListItem { Text = p.CityName, Value = p.CityId.ToString() }).ToList();
                ViewBag.Districts = db.Districts.Select(p => new SelectListItem { Text = p.DistrictName, Value = p.DistrictId.ToString() }).ToList();
                return View(new CandidateProfileViewModel { });
            }
        }

        // POST: CandidateProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CandidateProfileViewModel candidateProfile)
        {
            if (ModelState.IsValid)
            {
                //db.CandidateProfiles.Add(candidateProfile);
                //db.SaveChanges();

                // first check if a candidate exists with the aspnet userid or not
                var userId = User.Identity.GetUserId();

                var existingCandidate = db.Candidates.Include(path => path.JobRequests).FirstOrDefault(p => p.AspNetUserId == userId);
                if (existingCandidate == null)
                {
                    var appUser = db.Users.Find(userId);
                    var candidate = AutoMapper.Mapper.Map<Candidate>(candidateProfile);
                    candidate.UserName = User.Identity.GetUserName();
                    candidate.ProfilePicUrl = appUser.ProfilePicUrl;
                    var jobRequest = new JobRequest { IsPublished = true, PublishedDate = DateTime.Now, JobRequestDescription = candidateProfile.AdditionalDescription, JobId = candidateProfile.JobId, JobRequestJobTasks = new List<JobRequestJobTask> { } };

                    candidateProfile.JobTasks.ForEach(task =>
                    {
                        if (task.Selected)
                        {
                            jobRequest.JobRequestJobTasks.Add(new JobRequestJobTask { JobTaskId = task.JobTaskId, TaskResponse = task.Note });
                        }
                    });

                    candidate.JobRequests.Add(jobRequest);

                    var appUsr = db.Users.Include(p => p.Candidates).FirstOrDefault(p => p.Id == userId);

                    appUsr.Candidates.Add(candidate);
                    db.SaveChanges();
                }
                else
                {


                    var jobRequest = new JobRequest { IsPublished = true, PublishedDate = DateTime.Now, JobRequestDescription = candidateProfile.AdditionalDescription, JobId = candidateProfile.JobId, JobRequestJobTasks = new List<JobRequestJobTask> { } };
                    if (candidateProfile.JobRequestSkillPic1 != null && candidateProfile.JobRequestSkillPic1.ContentLength > 0)
                    {
                        var skillPic = candidateProfile.JobRequestSkillPic1;
                        string theFileName = Path.GetFileNameWithoutExtension(skillPic.FileName);
                        byte[] thePictureAsBytes = new byte[skillPic.ContentLength];
                        using (BinaryReader theReader = new BinaryReader(skillPic.InputStream))
                        {
                            thePictureAsBytes = theReader.ReadBytes(skillPic.ContentLength);
                        }

                        jobRequest.SkillPic1 = Convert.ToBase64String(thePictureAsBytes);
                    }

                    if (candidateProfile.JobRequestSkillPic2 != null && candidateProfile.JobRequestSkillPic2.ContentLength > 0)
                    {
                        var skillPic = candidateProfile.JobRequestSkillPic2;
                        string theFileName = Path.GetFileNameWithoutExtension(skillPic.FileName);
                        byte[] thePictureAsBytes = new byte[skillPic.ContentLength];
                        using (BinaryReader theReader = new BinaryReader(skillPic.InputStream))
                        {
                            thePictureAsBytes = theReader.ReadBytes(skillPic.ContentLength);
                        }

                        jobRequest.SkillPic2 = Convert.ToBase64String(thePictureAsBytes);
                    }

                    if (candidateProfile.JobRequestSkillPic3 != null && candidateProfile.JobRequestSkillPic3.ContentLength > 0)
                    {
                        var skillPic = candidateProfile.JobRequestSkillPic3;
                        string theFileName = Path.GetFileNameWithoutExtension(skillPic.FileName);
                        byte[] thePictureAsBytes = new byte[skillPic.ContentLength];
                        using (BinaryReader theReader = new BinaryReader(skillPic.InputStream))
                        {
                            thePictureAsBytes = theReader.ReadBytes(skillPic.ContentLength);
                        }

                        jobRequest.SkillPic3 = Convert.ToBase64String(thePictureAsBytes);
                    }



                    candidateProfile.JobTasks.ForEach(task =>
                    {
                        if (task.Selected)
                        {
                            jobRequest.JobRequestJobTasks.Add(new JobRequestJobTask { JobTaskId = task.JobTaskId, TaskResponse = task.Note });
                        }
                    });

                    existingCandidate.Disponibility = candidateProfile.Disponibility;
                    existingCandidate.ExpectedMinSalary = candidateProfile.ExpectedMinSalary;
                    existingCandidate.ExpectedMaxSalary = candidateProfile.ExpectedMaxSalary;
                    existingCandidate.CanRead = candidateProfile.CanRead;
                    existingCandidate.CanWrite = candidateProfile.CanWrite;
                    existingCandidate.SleepOnSite = candidateProfile.SleepOnSite;
                    existingCandidate.ExperienceInYears = candidateProfile.ExperienceInYears;
                    existingCandidate.ExperienceInMonths = candidateProfile.ExperienceInMonths;
                    if (candidateProfile.SleepOnSite)
                    {
                        existingCandidate.ExpectedMinRooms = candidateProfile.ExpectedMinRooms;
                        existingCandidate.ExpectedMaxRooms = candidateProfile.ExpectedMaxRooms;
                    }

                    existingCandidate.JobRequests.Add(jobRequest);
                    db.Entry(existingCandidate).State = EntityState.Modified;
                    db.SaveChanges();
                }

                // check the role and navigate to the myjobrequests page or naviget to SearchJobOffers?jobId = jobId
                return RedirectToAction("Index", "JobRequests");
            }
            Job job = db.Jobs.Include(p => p.JobTasks).FirstOrDefault(p => p.JobId == candidateProfile.JobId);
            candidateProfile.JobTasks = AutoMapper.Mapper.Map<List<JobTaskViewModel>>(job.JobTasks);
            return View(candidateProfile);
        }

        // GET: CandidateProfiles/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CandidateProfile candidateProfile = db.CandidateProfiles.Find(id);
        //    if (candidateProfile == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(candidateProfile);
        //}

        // POST: CandidateProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CandidateId,AspNetUserId,AgencyId,Gender,Age,ExperienceInYears,ExperienceInMonths,IdProofDoc,IdProofDocDesc,ProfileVerified,StaffType,StaffTypeDesc,Disponibility,CountryId,Country,CityId,City,DistrictId,District,SalaryType,SalaryTypeDesc,SalaryTypeOtherDesc,CanRead,CanWrite,ExpectedMinSalary,ExpectedMaxSalary,SleepOnSite,ExpectedMinRooms,ExpectedMaxRooms,MinGroupPeople,MaxGroupPeople,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,PublishProfile")] CandidateProfileViewModel candidateProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidateProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(candidateProfile);
        }

        // GET: CandidateProfiles/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CandidateProfile candidateProfile = db.CandidateProfiles.Find(id);
        //    if (candidateProfile == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(candidateProfile);
        //}

        // POST: CandidateProfiles/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    CandidateProfile candidateProfile = db.CandidateProfiles.Find(id);
        //    db.CandidateProfiles.Remove(candidateProfile);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
