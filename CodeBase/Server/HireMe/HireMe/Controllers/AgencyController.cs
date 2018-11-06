using HireMe.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using AutoMapper;

namespace HireMe.Controllers
{
    public class AgencyController : Controller
    {
        ApplicationDbContext db = ApplicationDbContext.Create();
        // GET: Agency
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RegisterCandidate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterCandidate(RegisterCandidateViewModel model)
        {
            if (ModelState.IsValid)
            {
                #region ProfileImageUpload
                string imagePath = string.Empty;
                if (model.profile_pic != null && model.profile_pic.ContentLength > 0)
                {
                    //Use Namespace called :  System.IO  
                    string FileName = Path.GetFileNameWithoutExtension(model.profile_pic.FileName);

                    //To Get File Extension  
                    string FileExtension = Path.GetExtension(model.profile_pic.FileName);

                    //Add Current Date To Attached File Name  
                    FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + FileName.Trim() + FileExtension;

                    //Get Upload path from Web.Config file AppSettings.  
                    //string UploadPath = ConfigurationManager.AppSettings["UserImagePath"].ToString();

                    var UploadPath = Path.Combine(Server.MapPath("~/App_Data/uploads"), FileName);
                    imagePath = UploadPath;

                    //Its Create complete path to store in server.  
                    //model.ImagePath = UploadPath + FileName;

                    //To copy and save file into server.  
                    model.profile_pic.SaveAs(imagePath);
                }
                #endregion
                var candidate = AutoMapper.Mapper.Map<Candidate>(model);
                candidate.EmailId = model.Email;
                candidate.ContactNo = model.PhoneNumber;
                candidate.StaffType = StaffType.Agency;
                var userId = User.Identity.GetUserId();
                // get the agencyid
                var agency = db.Agencies.FirstOrDefault(p => p.AspNetUserId == userId);
                candidate.AgencyId = agency.AgencyId;
                candidate.AspNetUserId = null;
                db.Candidates.Add(candidate);
                db.SaveChanges();
                //return RedirectToAction("GetAgencyCandidates");
                return RedirectToAction("GetJobCategories", new { candidateId = candidate.CandidateId });
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult GetAgencyCandidates()
        {
            var userId = User.Identity.GetUserId();
            // get the agencyid
            var agency = db.Agencies.First(p => p.AspNetUserId == userId);
            var candidates = db.Candidates.Where(p => p.AgencyId == agency.AgencyId).ToList();
            return View(candidates);
        }

        [HttpGet]
        public ActionResult GetCandidateCriteria(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateCandidateProfile(int candidateId, int jobId)
        {

            if (jobId != 0)
            {
                Job job = db.Jobs.Include(p => p.JobTasks).FirstOrDefault(p => p.JobId == jobId);

                //var candidateProfile = new CandidateProfileViewModel { JobId = id.Value, JobTasks = AutoMapper.Mapper.Map<List<JobTaskViewModel>>(job.JobTasks) };
                var candidateProfile = Mapper.Map<CandidateProfileViewModel>(db.Candidates.FirstOrDefault(p => p.CandidateId == candidateId));
                candidateProfile.JobTasks = AutoMapper.Mapper.Map<List<JobTaskViewModel>>(job.JobTasks);
                candidateProfile.JobId = jobId;

                return View(candidateProfile);
            }
            else
            {
                return View(new CandidateProfileViewModel { });
            }

        }

        [HttpPost]
        public ActionResult CreateCandidateProfile(CandidateProfileViewModel candidateProfile)
        {
            if (ModelState.IsValid)
            {
                //db.CandidateProfiles.Add(candidateProfile);
                //db.SaveChanges();

                // first check if a candidate exists with the aspnet userid or not
                //var userId = User.Identity.GetUserId();

                var existingCandidate = db.Candidates.Include(path => path.JobRequests).FirstOrDefault(p => p.CandidateId == candidateProfile.CandidateId);
                existingCandidate.AdditionalDescription = candidateProfile.AdditionalDescription;
                existingCandidate.Age = candidateProfile.Age;
                existingCandidate.CanRead = candidateProfile.CanRead;
                existingCandidate.CanWrite = candidateProfile.CanWrite;
                existingCandidate.Disponibility = candidateProfile.Disponibility;
                existingCandidate.ExperienceInYears = candidateProfile.ExperienceInYears;
                existingCandidate.ExpectedMinSalary = candidateProfile.ExpectedMinSalary;
                existingCandidate.ExpectedMaxSalary = candidateProfile.ExpectedMaxSalary;
                existingCandidate.SleepOnSite = candidateProfile.SleepOnSite;
                existingCandidate.ExpectedMinRooms = candidateProfile.ExpectedMinRooms;
                existingCandidate.ExpectedMaxRooms = candidateProfile.ExpectedMaxRooms;
                existingCandidate.MinGroupPeople = candidateProfile.MinGroupPeople;
                existingCandidate.MaxGroupPeople = candidateProfile.MaxGroupPeople;
                existingCandidate.CityId = candidateProfile.CityId;
                existingCandidate.CountryId = candidateProfile.CountryId;
                existingCandidate.SalaryType = candidateProfile.SalaryType;

                var jobRequest = new JobRequest { IsPublished = true, PublishedDate = DateTime.Now, JobRequestDescription = candidateProfile.AdditionalDescription, JobId = candidateProfile.JobId, JobRequestJobTasks = new List<JobRequestJobTask> { } };

                candidateProfile.JobTasks.ForEach(task =>
                {
                    if (task.Selected)
                    {
                        jobRequest.JobRequestJobTasks.Add(new JobRequestJobTask { JobTaskId = task.JobTaskId, TaskResponse = task.Note });
                    }
                });

                existingCandidate.JobRequests.Add(jobRequest);
                db.SaveChanges();

                // check the role and navigate to the myjobrequests page or naviget to SearchJobOffers?jobId = jobId
                return RedirectToAction("GetAgencyCandidates");
            }
            Job job = db.Jobs.Include(p => p.JobTasks).FirstOrDefault(p => p.JobId == candidateProfile.JobId);
            candidateProfile.JobTasks = AutoMapper.Mapper.Map<List<JobTaskViewModel>>(job.JobTasks);

            return View(candidateProfile);
        }
        [HttpGet]
        public ActionResult GetJobCategories(int candidateId)
        {
            var categories = db.JobCategories.Include(p => p.Jobs).ToList();

            var jobs = db.Jobs.Include(path => path.JobTasks).ToList();
            ViewBag.CandidateId = candidateId;
            return View(categories);
        }

        [HttpGet]
        public ActionResult GetJobRequests()
        {
            // get the job requests for the agency
            var userId = User.Identity.GetUserId();
            // get the agencyid
            var agency = db.Agencies.FirstOrDefault(p => p.AspNetUserId == userId);
            var jobRequests = db.JobRequests.Include(path => path.Job).Include(t => t.Candidate).ToList();
            jobRequests = jobRequests.Where(p => p.Candidate.StaffType == StaffType.Agency && p.Candidate.AgencyId == agency.AgencyId).ToList();
            return View(jobRequests);
        }
    }
}