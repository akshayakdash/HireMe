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
using System.Threading.Tasks;
using System.Web.Security;
using Microsoft.AspNet.Identity.Owin;

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
            var userId = User.Identity.GetUserId();
            // get the agencyid
            var agency = db.Agencies.FirstOrDefault(p => p.AspNetUserId == userId);

            ViewBag.AgencyProfileVerfied = agency.ProfileVerified;

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> RegisterCandidate(RegisterCandidateViewModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    #region ProfileImageUpload
            //    string imagePath = string.Empty;
            //    if (model.profile_pic != null && model.profile_pic.ContentLength > 0)
            //    {
            //        //Use Namespace called :  System.IO  
            //        string FileName = Path.GetFileNameWithoutExtension(model.profile_pic.FileName);

            //        //To Get File Extension  
            //        string FileExtension = Path.GetExtension(model.profile_pic.FileName);

            //        //Add Current Date To Attached File Name  
            //        FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + FileName.Trim() + FileExtension;

            //        //Get Upload path from Web.Config file AppSettings.  
            //        //string UploadPath = ConfigurationManager.AppSettings["UserImagePath"].ToString();

            //        var UploadPath = Path.Combine(Server.MapPath("~/App_Data/uploads"), FileName);
            //        imagePath = UploadPath;

            //        //Its Create complete path to store in server.  
            //        //model.ImagePath = UploadPath + FileName;

            //        //To copy and save file into server.  
            //        model.profile_pic.SaveAs(imagePath);
            //    }
            //    #endregion
            //    var candidate = AutoMapper.Mapper.Map<Candidate>(model);
            //    candidate.EmailId = model.Email;
            //    candidate.ContactNo = model.PhoneNumber;
            //    candidate.StaffType = StaffType.Agency;
            //    var userId = User.Identity.GetUserId();
            //    // get the agencyid
            //    var agency = db.Agencies.FirstOrDefault(p => p.AspNetUserId == userId);
            //    candidate.AgencyId = agency.AgencyId;
            //    candidate.AspNetUserId = null;
            //    db.Candidates.Add(candidate);
            //    db.SaveChanges();
            //    //return RedirectToAction("GetAgencyCandidates");
            //    return RedirectToAction("GetJobCategories", new { candidateId = candidate.CandidateId });
            //}
            //return View(model);

            var userId = User.Identity.GetUserId();
            var agency = db.Agencies.FirstOrDefault(p => p.AspNetUserId == userId);

            var randomPassword = System.Web.Security.Membership.GeneratePassword(5, 1);
            var randomUserName = agency.AgencyName + randomPassword;

            var countries = db.Countries.ToList();
            var cities = db.Cities.ToList();
            var districts = db.Districts.ToList();
            if (ModelState.IsValid)
            {
                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                // now check if it has file associated with it

                #region ProfileImageUpload
                string profileImagePath = string.Empty;
                if (model.profile_pic != null && model.profile_pic.ContentLength > 0)
                {

                    string theFileName = Path.GetFileNameWithoutExtension(model.profile_pic.FileName);
                    byte[] thePictureAsBytes = new byte[model.profile_pic.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.profile_pic.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.profile_pic.ContentLength);
                    }
                    profileImagePath = Convert.ToBase64String(thePictureAsBytes);
                }
                #endregion

                #region Id Card
                string idProofImagePath = string.Empty;
                if (model.id_proof != null && model.id_proof.ContentLength > 0)
                {


                    string theFileName = Path.GetFileNameWithoutExtension(model.id_proof.FileName);
                    byte[] thePictureAsBytes = new byte[model.id_proof.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.id_proof.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.id_proof.ContentLength);
                    }
                    idProofImagePath = Convert.ToBase64String(thePictureAsBytes);
                }
                #endregion
                var user = new ApplicationUser { UserName = randomUserName, Email = model.Email, Address = model.Address, PhoneNumber = model.PhoneNumber, FirstName = model.FirstName, LastName = model.LastName, ProfilePicUrl = profileImagePath, CountryId = model.CountryId, CityId = model.CityId, DistrictId = model.DistrictId };
                string phoneNumber = model.PhoneNumber.Replace("-", "");


                var candidate = new Candidate { StaffType = StaffType.Agency, FirstName = model.FirstName, LastName = model.LastName, Address = model.Address, EmailId = model.Email, ContactNo = phoneNumber, CountryId = model.CountryId, CityId = model.CityId, DistrictId = model.DistrictId, ProfilePicUrl = profileImagePath, IdProofDoc = idProofImagePath, Age = model.Age };
                candidate.CreatedDate = DateTime.Now.ToString();
                var cntry = countries.FirstOrDefault(p => p.CountryId == candidate.CountryId);
                if (cntry != null)
                    candidate.Country = cntry.CountryName;
                var cty = cities.FirstOrDefault(p => p.CityId == candidate.CityId);
                if (cty != null)
                    candidate.City = cities.FirstOrDefault(p => p.CityId == candidate.CityId).CityName;
                var dstrct = districts.FirstOrDefault(p => p.DistrictId == candidate.DistrictId);
                if (dstrct != null)
                    candidate.District = districts.FirstOrDefault(p => p.DistrictId == candidate.DistrictId).DistrictName;
                user.Candidates = new List<Candidate> { candidate };



                var result = await userManager.CreateAsync(user, randomUserName);

                // now save the security question answer for the user
                //context.UserSecurityQuestionAnswers.Add(new ApplicationUserSecurityQuestionAnswer { AspNetUserId = user.Id, SecurityQuestionId = model.SecurityQuestionId, Answer = model.SecurityQuestionAnswer });

                // now based on role we need to make an entry to the corresponding tables Candidate, Employer and Agency

                //await context.SaveChangesAsync();



                if (result.Succeeded)
                {
                    //  await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771    
                    // Send an email with this link    
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);    
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);    
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");    
                    //Assign Role to user Here       
                    await userManager.AddToRoleAsync(user.Id, "Candidate");

                    // insert a welcome notification
                    db.Notifications.Add(new JobTekNotification { Content = "One candidate registered " + model.FirstName + " to our Portal.", SenderId = "b6b5fc19-3222-4733-9d71-a4cf5d30ec98", ReceiverId = agency.AspNetUserId, CreatedDate = DateTime.Now });
                    db.SaveChanges();
                    //Ends Here     
                    //return RedirectToAction("Login", "Account");
                }
                //var country = context.Countries.ToList();
                //var city = context.Cities.ToList();
                //var district = context.Districts.ToList();

                ViewBag.Country = countries;
                ViewBag.City = cities;
                ViewBag.District = districts;
                //AddErrors(result);
            }
            // If we got this far, something failed, redisplay form   
            ViewBag.Country = countries;
            ViewBag.City = cities;
            ViewBag.District = districts;
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
                //existingCandidate.Age = candidateProfile.Age;
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
            if (agency != null)
            {
                var jobRequests = db.JobRequests.Include(path => path.Job).Include(t => t.Candidate).ToList();
                jobRequests = jobRequests.Where(p => p.Candidate.StaffType == StaffType.Agency && p.Candidate.AgencyId == agency.AgencyId).ToList();
                return View(jobRequests);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult GetAgencyDetailsPartialView(int agencyId)
        {
            var agency = db.Agencies.Find(agencyId);
            if (agency == null)
                return HttpNotFound();
            return PartialView("_agencyDetails", agency);
        }
    }
}