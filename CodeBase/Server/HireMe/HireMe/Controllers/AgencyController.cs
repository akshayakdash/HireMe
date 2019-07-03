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
using HireMe.Utility;
using Newtonsoft.Json;
using System.Configuration;

namespace HireMe.Controllers
{
    public class AgencyController : BaseController
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
            ViewBag.NewCandidateRegistered = false;
            ViewBag.AgencyProfileVerfied = agency.ProfileVerified;
            ViewData["Country"] = db.Countries.ToList().Select(p => new SelectListItem { Text = p.CountryName, Value = p.CountryId.ToString() }).ToList();
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> RegisterCandidate(RegisterCandidateViewModel model)
        {
            var userId = User.Identity.GetUserId();
            var agency = db.Agencies.FirstOrDefault(p => p.AspNetUserId == userId);

            var randomPassword = System.Web.Security.Membership.GeneratePassword(5, 1);
            var randomUserName = agency.AgencyName + randomPassword;

            var countries = db.Countries.ToList();
            var cities = db.Cities.ToList();
            var districts = db.Districts.ToList();

            //ViewData["Country"] = db.Countries.Select(p => new SelectListItem { Text = p.CountryName, Value = p.CountryId.ToString() }).ToList();
            //ViewBag.Country = countries;
            //ViewBag.City = cities;
            //ViewBag.District = districts;

            if (ModelState.IsValid)
            {
                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();

                int age = 0;
                if (model.DOB != default(DateTime) && !(model.DOB > DateTime.Now))
                {
                    age = DateTime.Now.Year - model.DOB.Year;
                    if (DateTime.Now.DayOfYear < model.DOB.DayOfYear)
                        age = age - 1;
                }
                // now check if it has file associated with it

                #region ProfileImageUpload
                string path = Server.MapPath("~/Uploads/");
                string profileImagePath = string.Empty;
                if (model.profile_pic != null && model.profile_pic.ContentLength > 0)
                {
                    ////Use Namespace called :  System.IO  
                    //string FileName = Path.GetFileNameWithoutExtension(model.profile_pic.FileName);

                    ////To Get File Extension  
                    //string FileExtension = Path.GetExtension(model.profile_pic.FileName);

                    ////Add Current Date To Attached File Name  
                    //FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + FileName.Trim() + FileExtension;

                    ////Get Upload path from Web.Config file AppSettings.  
                    ////string UploadPath = ConfigurationManager.AppSettings["UserImagePath"].ToString();

                    //var UploadPath = Path.Combine(Server.MapPath("~/App_Data/uploads"), FileName);
                    //imagePath = UploadPath;

                    ////Its Create complete path to store in server.  
                    ////model.ImagePath = UploadPath + FileName;

                    ////To copy and save file into server.  
                    //model.profile_pic.SaveAs(imagePath);

                    //string theFileName = Path.GetFileNameWithoutExtension(model.profile_pic.FileName);
                    //byte[] thePictureAsBytes = new byte[model.profile_pic.ContentLength];
                    //using (BinaryReader theReader = new BinaryReader(model.profile_pic.InputStream))
                    //{
                    //    thePictureAsBytes = theReader.ReadBytes(model.profile_pic.ContentLength);
                    //}
                    //profileImagePath = Convert.ToBase64String(thePictureAsBytes);

                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.profile_pic.FileName);
                    byte[] thePictureAsBytes = new byte[model.profile_pic.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.profile_pic.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.profile_pic.ContentLength);
                    }
                    System.IO.File.WriteAllBytes(path + fileName, thePictureAsBytes);
                    profileImagePath = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                }
                #endregion

                #region Id Card
                string idProofImagePath = string.Empty;
                if (model.id_proof != null && model.id_proof.ContentLength > 0)
                {

                    //string theFileName = Path.GetFileNameWithoutExtension(model.id_proof.FileName);
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.id_proof.FileName);
                    byte[] thePictureAsBytes = new byte[model.id_proof.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.id_proof.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.id_proof.ContentLength);
                    }
                    //idProofImagePath = Convert.ToBase64String(thePictureAsBytes);
                    System.IO.File.WriteAllBytes(path + fileName, thePictureAsBytes);
                    idProofImagePath = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                }

                string idProofImagePath1 = string.Empty;
                if (model.id_proof1 != null && model.id_proof1.ContentLength > 0)
                {

                    string theFileName = Path.GetFileNameWithoutExtension(model.id_proof1.FileName);
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.id_proof1.FileName);
                    byte[] thePictureAsBytes = new byte[model.id_proof1.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.id_proof1.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.id_proof1.ContentLength);
                    }
                    idProofImagePath1 = Convert.ToBase64String(thePictureAsBytes);
                    System.IO.File.WriteAllBytes(path + fileName, thePictureAsBytes);
                    idProofImagePath1 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                }
                #endregion

                string contactNumber = model.PhoneNumber.Replace("-", "");
                string phoneNumber = model.CountryCode + contactNumber;
                var user = new ApplicationUser { UserName = randomUserName, Email = model.Email, Address = model.Address, PhoneNumber = phoneNumber, FirstName = model.FirstName, LastName = model.LastName, ProfilePicUrl = profileImagePath, CountryId = model.CountryId, CityId = model.CityId, DistrictId = model.DistrictId };
                //string phoneNumber = model.PhoneNumber.Replace("-", "");


                var candidate = new Candidate { Gender = model.Gender, AgencyId = agency.AgencyId, StaffType = StaffType.Agency, FirstName = model.FirstName, LastName = model.LastName, Address = model.Address, EmailId = model.Email, ContactNo = phoneNumber, CountryId = model.CountryId, CityId = model.CityId, DistrictId = model.DistrictId, ProfilePicUrl = profileImagePath, IdProofDoc = idProofImagePath, IdProofDoc1 = idProofImagePath1, Age = age };
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

                    await NotificationFramework.SendNotification("", user.Id, "Welcome " + candidate.FirstName + " - JobTek", "Welcome to our portal. Your user id is: " + randomUserName + " and Password is : " + randomPassword, 0, true);
                    //Ends Here     
                    //return RedirectToAction("Login", "Account");
                    //return RedirectToAction("GetJobCategories", new { candidateId = candidate.CandidateId });
                    ViewBag.NewCandidateUserName = randomUserName;
                    ViewBag.NewCandidatePassword = randomPassword;
                    ViewBag.NewCandidateRegistered = true;
                    ViewBag.AgencyProfileVerfied = true;

                    ViewData["Country"] = countries.Select(p => new SelectListItem { Text = p.CountryName, Value = p.CountryId.ToString() }).ToList();
                    //ViewBag.Country = countries;
                    ViewBag.City = cities;
                    ViewBag.District = districts;
                    return RedirectToAction("RegisterCandidate");
                }
                //var country = context.Countries.ToList();
                //var city = context.Cities.ToList();
                //var district = context.Districts.ToList();
                ViewData["Country"] = countries.Select(p => new SelectListItem { Text = p.CountryName, Value = p.CountryId.ToString() }).ToList();
                ViewBag.Country = countries;
                ViewBag.City = cities;
                ViewBag.District = districts;
                //model.CountryId = ViewData["Country"] as List<SelectListItem>();
                AddErrors(result);
            }
            // If we got this far, something failed, redisplay form   

            ViewBag.NewCandidateRegistered = false;
            ViewBag.AgencyProfileVerfied = true;
            ViewData["Country"] = countries.Select(p => new SelectListItem { Text = p.CountryName, Value = p.CountryId.ToString() }).ToList();
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
            var candidates = db.Candidates.Include(path => path.ApplicationUser).Where(p => p.AgencyId == agency.AgencyId && p.StaffType == StaffType.Agency).ToList();
            return View(candidates);
        }

        public async Task<ActionResult> ActivateCandidate(int id)
        {
            var userId = User.Identity.GetUserId();
            var agency = db.Agencies.First(p => p.AspNetUserId == userId);
            // get the agencyid
            // first get the candidate by Id
            var candidate = db.Candidates.Find(id);
            // if candidate is null throw an exception
            if (candidate == null)
                throw new Exception("Candidate Not Found.");
            candidate.ProfileVerified = true;
            db.SaveChanges();

            NotificationFramework.SendNotification(userId, candidate.AspNetUserId, "Candidate Account Activation - JOBTek", "Your candidate Account " + candidate.FirstName + " was activated by Agency" + agency.AgencyName + " on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            // else return success message
            return Json("Candidate profile Verified Successfully", JsonRequestBehavior.AllowGet);
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
            var agency = db.Agencies
                .Include(t => t.ApplicationUser)
                .FirstOrDefault(p => p.AgencyId == agencyId);
            if (agency == null)
                return HttpNotFound();
            if (agency.CountryId != 0 && agency.Country == null)
                agency.Country = db.Countries.FirstOrDefault(p => p.CountryId == agency.CountryId)?.CountryName;
            if (agency.CityId != 0 && agency.City == null)
                agency.City = db.Cities.FirstOrDefault(p => p.CityId == agency.CityId)?.CityName;
            if (agency.DistrictId != 0 && agency.District == null)
                agency.District = db.Districts.FirstOrDefault(p => p.DistrictId == agency.DistrictId)?.DistrictName;
            return PartialView("_agencyDetails", agency);
        }

        /// <summary>
        /// Id is the jobId
        /// </summary>
        /// <param name="jobId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CreateJobRequest(int? jobId)
        {
            // now prepare the job tasks for the job
            ViewBag.JobCategories = db.JobCategories.Include(t => t.Jobs).ToList();
            var userId = User.Identity.GetUserId();
            // get the agencyid
            var agency = db.Agencies.First(p => p.AspNetUserId == userId);
            ViewBag.AgencyProfileVerfied = agency.ProfileVerified;
            // get the job tasks for a job
            if (jobId.HasValue)
            {
                Job job = db.Jobs.Include(p => p.JobTasks).FirstOrDefault(p => p.JobId == jobId);


                var candidates = db.Candidates.Include(path => path.ApplicationUser).Where(p => p.AgencyId == agency.AgencyId && p.StaffType == StaffType.Agency).ToList();
                ViewBag.Candidates = candidates;

                var candidateProfile = new AgencyJobRequestViewModel { JobId = jobId.Value, JobTasks = AutoMapper.Mapper.Map<List<JobTaskViewModel>>(job.JobTasks.Where(p => p.ParentJobTaskId == null).ToList()) };

                ViewBag.Cities = db.Cities.Select(p => new SelectListItem { Text = p.CityName, Value = p.CityId.ToString() }).ToList();
                ViewBag.Districts = db.Districts.Select(p => new SelectListItem { Text = p.DistrictName, Value = p.DistrictId.ToString() }).ToList();

                return View(candidateProfile);
            }
            else
            {
                ViewBag.Cities = db.Cities.Select(p => new SelectListItem { Text = p.CityName, Value = p.CityId.ToString() }).ToList();
                ViewBag.Districts = db.Districts.Select(p => new SelectListItem { Text = p.DistrictName, Value = p.DistrictId.ToString() }).ToList();
                return View(new AgencyJobRequestViewModel { });
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateJobRequest(AgencyJobRequestViewModel candidateProfile)
        {
            var userId = User.Identity.GetUserId();
            var agency = db.Agencies.FirstOrDefault(p => p.AspNetUserId == userId);
            ViewBag.NewJobProfileCreated = false;
            if (ModelState.IsValid)
            {
                string path = Server.MapPath("~/Uploads/");
                var jobRequest = new JobRequest { IsPublished = true, PublishedDate = DateTime.Now, JobRequestDescription = candidateProfile.AdditionalDescription, JobId = candidateProfile.JobId, JobRequestJobTasks = new List<JobRequestJobTask> { }, AgencyJobRequestGroupId = Guid.NewGuid().ToString(), AgencyJobRequestTitle = candidateProfile.Title };
                if (candidateProfile.JobRequestSkillPic1 != null && candidateProfile.JobRequestSkillPic1.ContentLength > 0)
                {
                    var skillPic = candidateProfile.JobRequestSkillPic1;
                    string theFileName = Guid.NewGuid().ToString() + Path.GetExtension(skillPic.FileName);
                    byte[] thePictureAsBytes = new byte[skillPic.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(skillPic.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(skillPic.ContentLength);
                    }

                    //jobRequest.SkillPic1 = Convert.ToBase64String(thePictureAsBytes);

                    System.IO.File.WriteAllBytes(path + theFileName, thePictureAsBytes);
                    jobRequest.SkillPic1 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + theFileName;
                }

                if (candidateProfile.JobRequestSkillPic2 != null && candidateProfile.JobRequestSkillPic2.ContentLength > 0)
                {
                    var skillPic = candidateProfile.JobRequestSkillPic2;
                    string theFileName = Guid.NewGuid().ToString() + Path.GetExtension(skillPic.FileName);
                    byte[] thePictureAsBytes = new byte[skillPic.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(skillPic.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(skillPic.ContentLength);
                    }

                    //jobRequest.SkillPic2 = Convert.ToBase64String(thePictureAsBytes);

                    System.IO.File.WriteAllBytes(path + theFileName, thePictureAsBytes);
                    jobRequest.SkillPic2 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + theFileName;
                }

                if (candidateProfile.JobRequestSkillPic3 != null && candidateProfile.JobRequestSkillPic3.ContentLength > 0)
                {
                    var skillPic = candidateProfile.JobRequestSkillPic3;
                    string theFileName = Guid.NewGuid().ToString() + Path.GetExtension(skillPic.FileName);
                    byte[] thePictureAsBytes = new byte[skillPic.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(skillPic.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(skillPic.ContentLength);
                    }

                    //jobRequest.SkillPic3 = Convert.ToBase64String(thePictureAsBytes);

                    System.IO.File.WriteAllBytes(path + theFileName, thePictureAsBytes);
                    jobRequest.SkillPic1 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + theFileName;
                }



                //candidateProfile.JobTasks.ForEach(task =>
                //{
                //    if (task.Selected)
                //    {
                //        jobRequest.JobRequestJobTasks.Add(new JobRequestJobTask { JobTaskId = task.JobTaskId, TaskResponse = task.Note });
                //    }
                //});

                Action<JobTaskViewModel> saveJobRequestTaskTree = null;

                saveJobRequestTaskTree = (task) =>
                {
                    //Console.WriteLine(n.Value);
                    if (task.Selected)
                    {
                        jobRequest.JobRequestJobTasks.Add(new JobRequestJobTask { JobTaskId = task.JobTaskId, TaskResponse = task.Note });
                    }
                    if (task.SubTasks != null)
                        task.SubTasks.ToList().ForEach(saveJobRequestTaskTree);
                };


                candidateProfile.JobTasks.ForEach(task =>
                {
                    saveJobRequestTaskTree(task);
                });


                // now get the candidates for whom the job request would be created by the agency
                if (candidateProfile.CandidateIds != null && candidateProfile.CandidateIds.Count > 0)
                {
                    //var selectedCandidates = db.Candidates.Include(p => p.JobRequests).Where(p => candidateProfile.CandidateIds.Contains(p.CandidateId)).ToList();
                    candidateProfile.CandidateIds.ForEach(cndId =>
                    {
                        var serializedJobRequest = JsonConvert.SerializeObject(jobRequest);
                        var clonedJobRequest = JsonConvert.DeserializeObject<JobRequest>(serializedJobRequest);
                        //clonedJobRequest.CandidateId = candidate.CandidateId;
                        var candidate = db.Candidates.Include(p => p.JobRequests).FirstOrDefault(t => t.CandidateId == cndId);
                        candidate.Disponibility = candidateProfile.Disponibility;
                        //This was not there I have added the same
                        candidate.ExpectedMinSalary = candidateProfile.ExpectedMinSalary;
                        candidate.ExpectedMaxSalary = candidateProfile.ExpectedMaxSalary;
                        candidate.ExperienceInYears = candidateProfile.ExperienceInYears;
                        candidate.ExperienceInMonths = candidateProfile.ExperienceInMonths;
                        candidate.MinGroupPeople = candidateProfile.MinGroupPeople;
                        candidate.MaxGroupPeople = candidateProfile.MaxGroupPeople;
                        candidate.SalaryType = candidateProfile.SalaryType;
                        candidate.CanRead = candidateProfile.CanRead;
                        candidate.CanWrite = candidateProfile.CanWrite;
                        candidate.SleepOnSite = candidateProfile.SleepOnSite;

                        candidate.JobRequests.Add(clonedJobRequest);
                        db.JobRequests.Add(clonedJobRequest);
                        db.SaveChanges();
                    });

                    //candidateProfile.CandidateIds.ForEach(cndId =>
                    //{
                    //    var serializedJobRequest = JsonConvert.SerializeObject(jobRequest);
                    //    var clonedJobRequest = JsonConvert.DeserializeObject<JobRequest>(serializedJobRequest);
                    //    clonedJobRequest.CandidateId = cndId;
                    //    db.JobRequests.Add(clonedJobRequest);
                    //});
                    //db.SaveChanges();
                    ViewBag.NewJobProfileCreated = true;
                }




                //AddErrors(result);
            }
            // If we got this far, something failed, redisplay form   


            ViewBag.AgencyProfileVerfied = true;


            // get the agencyid
            var candidates = db.Candidates.Include(path => path.ApplicationUser).Where(p => p.AgencyId == agency.AgencyId && p.StaffType == StaffType.Agency).ToList();
            ViewBag.Candidates = candidates;
            ViewBag.Cities = db.Cities.Select(p => new SelectListItem { Text = p.CityName, Value = p.CityId.ToString() }).ToList();
            ViewBag.Districts = db.Districts.Select(p => new SelectListItem { Text = p.DistrictName, Value = p.DistrictId.ToString() }).ToList();
            ViewBag.JobCategories = db.JobCategories.Include(t => t.Jobs).ToList();
            ViewBag.AgencyProfileVerfied = true;
            return View(candidateProfile);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

    }
}