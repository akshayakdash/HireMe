using HireMe.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Data.Entity;
using HireMe.Utility;
using System.Web.Http.Cors;
using System.IO;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System.Configuration;

namespace HireMe.Controllers.MobileApiControllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AgenciesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private JsonMediaTypeFormatter jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

        public AgenciesController()
        {
            var jSettings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            jsonFormatter.SerializerSettings = jSettings;
        }

        [HttpGet]
        [Route("api/Agencies/{agencyId}/Candidates")]
        public HttpResponseMessage MyCandidates(int agencyId)
        {
            var candidates = db.Candidates.Include(p => p.ApplicationUser).Where(p => p.AgencyId == agencyId && p.StaffType == StaffType.Agency).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, candidates, jsonFormatter);
        }

        [Route("api/Agencies/{agencyId}/Candidates")]
        [HttpPost]
        public HttpResponseMessage RegisterCandidate([FromBody]RegisterCandidateViewModel model, [FromUri]int agencyId)
        {
            var agency = db.Agencies.FirstOrDefault(p => p.AgencyId == agencyId);

            var randomPassword = System.Web.Security.Membership.GeneratePassword(5, 1);
            var randomUserName = agency.AgencyName + randomPassword;

            var countries = db.Countries.ToList();
            var cities = db.Cities.ToList();
            var districts = db.Districts.ToList();


            if (ModelState.IsValid)
            {
                var userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();

                int age = 0;
                if (model.DOB != default(DateTime) && !(model.DOB > DateTime.Now))
                {
                    age = DateTime.Now.Year - model.DOB.Year;
                    if (DateTime.Now.DayOfYear < model.DOB.DayOfYear)
                        age = age - 1;
                }
                // now check if it has file associated with it
                string path = HttpContext.Current.Server.MapPath("~/Uploads/");
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

                if (!string.IsNullOrWhiteSpace(model.profile_pic_base64))
                {

                    string fileName = Guid.NewGuid().ToString() + ".jpg";// + Base64Extensions.GetFileExtension(model.profile_pic_base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.profile_pic_base64));
                    profileImagePath = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                    //profileImagePath = model.profile_pic_base64;
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

                if (!string.IsNullOrWhiteSpace(model.id_proof_base64))
                {

                    string fileName = Guid.NewGuid().ToString() + ".jpg";// + Base64Extensions.GetFileExtension(model.profile_pic_base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.id_proof_base64));
                    idProofImagePath = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                    //profileImagePath = model.profile_pic_base64;
                }

                string idProofImagePath1 = string.Empty;
                if (model.id_proof1 != null && model.id_proof1.ContentLength > 0)
                {


                    string theFileName = Path.GetFileNameWithoutExtension(model.id_proof1.FileName);
                    byte[] thePictureAsBytes = new byte[model.id_proof1.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.id_proof1.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.id_proof1.ContentLength);
                    }
                    idProofImagePath1 = Convert.ToBase64String(thePictureAsBytes);
                }

                if (!string.IsNullOrWhiteSpace(model.id_proof1_base64))
                {
                    //idProofImagePath = model.id_proof_base64;
                    string fileName = Guid.NewGuid().ToString() + ".jpg";// + Base64Extensions.GetFileExtension(model.id_proof_base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.id_proof1_base64));
                    idProofImagePath1 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                }
                #endregion
                var user = new ApplicationUser
                {
                    UserName = randomUserName,
                    Email = model.Email,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    ProfilePicUrl = profileImagePath,
                    CountryId = model.CountryId,
                    CityId = model.CityId,
                    DistrictId = model.DistrictId
                };
                string phoneNumber = model.PhoneNumber.Replace("-", "");


                var candidate = new Candidate
                {
                    Gender = model.Gender,
                    AgencyId = agency.AgencyId,
                    StaffType = StaffType.Agency,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    EmailId = model.Email,
                    ContactNo = phoneNumber,
                    CountryId = model.CountryId,
                    CityId = model.CityId,
                    DistrictId = model.DistrictId,
                    ProfilePicUrl = profileImagePath,
                    IdProofDoc = idProofImagePath,
                    IdProofDoc1 = idProofImagePath1,
                    Age = age
                };

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

                var UserManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var result = UserManager.CreateAsync(user, randomUserName).Result;

                if (result.Succeeded)
                {
                    //Assign Role to user Here       
                    UserManager.AddToRoleAsync(user.Id, "Candidate");

                    // insert a welcome notification
                    db.Notifications.Add(new JobTekNotification { Content = "One candidate registered " + model.FirstName + " to our Portal.", SenderId = "b6b5fc19-3222-4733-9d71-a4cf5d30ec98", ReceiverId = agency.AspNetUserId, CreatedDate = DateTime.Now });
                    db.SaveChanges();

                    NotificationFramework.SendNotification("", user.Id, "Welcome " + candidate.FirstName + " - JobTek", "Welcome to our portal. Your user id is: " + randomUserName + " and Password is : " + randomPassword, 0, true);

                    return Request.CreateResponse(HttpStatusCode.Created, new { Status = "OK", Message = "Registration successful to the portal." });
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "ERROR", Message = "Internal Server Error." });

            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("api/Agencies/{agencyId}/Candidates/{candidateId}/Activate")]
        public HttpResponseMessage ActivateCandidate(int agencyId, int candidateId)
        {
            var agency = db.Agencies.Find(agencyId);
            if (agency == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Agency Not Found");
            }

            var candidate = db.Candidates.Find(candidateId);
            // if candidate is null throw an exception
            if (candidate == null)
                return Request.CreateResponse(HttpStatusCode.NotFound, "Candidate Not Found.");
            candidate.ProfileVerified = true;
            db.SaveChanges();

            NotificationFramework.SendNotification(agency.AspNetUserId, candidate.AspNetUserId, "Candidate Account Activation - JOBTek", "Your candidate Account " + candidate.FirstName + " was activated by Agency" + agency.AgencyName + " on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);

            return Request.CreateResponse(HttpStatusCode.Created, new { Status = "OK", Message = "Candidate Profile verified successfully." });
        }


        [HttpGet]
        [Route("api/Agencies/{agencyId}/JobRequests")]
        public HttpResponseMessage MyJobRequests(int agencyId)
        {

            var agency = db.Agencies.Find(agencyId);
            if (agency != null)
            {
                //var jobRequests = db.JobRequests.Include(path => path.Job).Include(t => t.Candidate).ToList();
                //jobRequests = jobRequests.Where(p => p.Candidate.StaffType == StaffType.Agency && p.Candidate.AgencyId == agency.AgencyId).ToList();
                //return Request.CreateResponse(HttpStatusCode.OK, jobRequests, jsonFormatter);

                var jobRequests = db.v_SearchJobRequests_Mobile.Where(p => p.AgencyId == agencyId && p.IsPublished).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, jobRequests, jsonFormatter);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpDelete]
        [Route("api/Agencies/{agencyId}/JobRequests/{jobRequestId}")]
        public HttpResponseMessage RemoveJobRequest(int agencyId, int jobRequestId)
        {

            var jobRequest = db.JobRequests.Find(jobRequestId);
            if (jobRequest == null)
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Job Request not found." });
            // delete job request for a single candidate
            jobRequest.IsPublished = false;
            db.Entry(jobRequest).Property(p => p.IsPublished).IsModified = true;

            // uncomment below and comment above to enable deletion of job request created for multiple candidates of agency
            //var groupedJobRequests = db.JobRequests.Where(p => p.AgencyJobRequestGroupId == jobRequest.AgencyJobRequestGroupId).ToList();
            //groupedJobRequests.ForEach(jr => {
            //    jr.IsPublished = false;
            //    db.Entry(jr).Property(p => p.IsPublished).IsModified = true;
            //});

            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Job Request removed successfully." });
        }

        [HttpPost]
        [Route("api/Agencies/{agencyId}/JobRequests")]
        public HttpResponseMessage CreateJobRequest(AgencyJobRequestViewModel candidateProfile)
        {
            var agency = db.Agencies.FirstOrDefault(p => p.AgencyId == candidateProfile.AgencyId);
            if (ModelState.IsValid)
            {
                string path = HttpContext.Current.Server.MapPath("~/Uploads/");
                var jobRequest = new JobRequest
                {
                    IsPublished = true,
                    PublishedDate = DateTime.Now,
                    JobRequestDescription = candidateProfile.AdditionalDescription,
                    JobId = candidateProfile.JobId,
                    JobRequestJobTasks = new List<JobRequestJobTask> { },
                    AgencyJobRequestGroupId = Guid.NewGuid().ToString(),
                    AgencyJobRequestTitle = candidateProfile.Title
                };
                if (candidateProfile.JobRequestSkillPic1 != null && candidateProfile.JobRequestSkillPic1.ContentLength > 0)
                {
                    var skillPic = candidateProfile.JobRequestSkillPic1;
                    //string theFileName = Path.GetFileNameWithoutExtension(skillPic.FileName);
                    //byte[] thePictureAsBytes = new byte[skillPic.ContentLength];
                    //using (BinaryReader theReader = new BinaryReader(skillPic.InputStream))
                    //{
                    //thePictureAsBytes = theReader.ReadBytes(skillPic.ContentLength);
                    //}
                    string fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(skillPic.FileName);
                    skillPic.SaveAs(path + fileName);

                    jobRequest.SkillPic1 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName; //Convert.ToBase64String(thePictureAsBytes);
                }
                else if (!string.IsNullOrWhiteSpace(candidateProfile.JobRequestSkillPic1Base64))
                {
                    //jobRequest.SkillPic1 = jobRequest.SkillPic1Base64;
                    string fileName = Guid.NewGuid().ToString() + ".jpg";//+Base64Extensions.GetFileExtension(jobRequest.SkillPic1Base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(candidateProfile.JobRequestSkillPic1Base64));
                    jobRequest.SkillPic1 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName; //Convert.ToBase64String(thePictureAsBytes);
                }


                if (candidateProfile.JobRequestSkillPic2 != null && candidateProfile.JobRequestSkillPic2.ContentLength > 0)
                {
                    var skillPic = candidateProfile.JobRequestSkillPic2;
                    //string theFileName = Path.GetFileNameWithoutExtension(skillPic.FileName);
                    //byte[] thePictureAsBytes = new byte[skillPic.ContentLength];
                    //using (BinaryReader theReader = new BinaryReader(skillPic.InputStream))
                    //{
                    //    thePictureAsBytes = theReader.ReadBytes(skillPic.ContentLength);
                    //}
                    string fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(skillPic.FileName);
                    skillPic.SaveAs(path + fileName);

                    jobRequest.SkillPic2 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                    //jobRequest.SkillPic2 = Convert.ToBase64String(thePictureAsBytes);
                }
                else if (!string.IsNullOrWhiteSpace(candidateProfile.JobRequestSkillPic2Base64))
                {
                    //jobRequest.SkillPic2 = jobRequest.SkillPic2Base64;
                    string fileName = Guid.NewGuid().ToString() + ".jpg";// + Base64Extensions.GetFileExtension(jobRequest.SkillPic2Base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(candidateProfile.JobRequestSkillPic2Base64));
                    jobRequest.SkillPic2 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName; //Convert.ToBase64String(thePictureAsBytes);
                }

                if (candidateProfile.JobRequestSkillPic3 != null && candidateProfile.JobRequestSkillPic3.ContentLength > 0)
                {
                    var skillPic = candidateProfile.JobRequestSkillPic3;
                    //string theFileName = Path.GetFileNameWithoutExtension(skillPic.FileName);
                    //byte[] thePictureAsBytes = new byte[skillPic.ContentLength];
                    //using (BinaryReader theReader = new BinaryReader(skillPic.InputStream))
                    //{
                    //    thePictureAsBytes = theReader.ReadBytes(skillPic.ContentLength);
                    //}
                    string fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(skillPic.FileName);
                    skillPic.SaveAs(path + fileName);

                    jobRequest.SkillPic3 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName; //Convert.ToBase64String(thePictureAsBytes);
                    //jobRequest.SkillPic3 = Convert.ToBase64String(thePictureAsBytes);
                }
                else if (!string.IsNullOrWhiteSpace(candidateProfile.JobRequestSkillPic3Base64))
                {
                    //jobRequest.SkillPic3 = jobRequest.SkillPic3Base64;
                    string fileName = Guid.NewGuid().ToString() + ".jpg";// Base64Extensions.GetFileExtension(jobRequest.SkillPic3Base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(candidateProfile.JobRequestSkillPic3Base64));
                    jobRequest.SkillPic3 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName; //Convert.ToBase64String(thePictureAsBytes);
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
                }
            }
            return Request.CreateResponse(HttpStatusCode.Created, new { Status = "OK", Message = "Job request created for the selected candidates." });
        }

        [HttpGet]
        [Route("api/Agencies/{agencyId}/Notifications")]
        public HttpResponseMessage Notifications(int agencyId)
        {
            var existingAgency = db.Agencies.FirstOrDefault(p => p.AgencyId == agencyId);
            var userId = existingAgency.AspNetUserId;
            var notifications = db.Notifications
                .Include(path => path.Sender)
                .Include(t => t.Receiver)
                .Where(p => p.ReceiverId == userId)
                .Select(p =>
                    new
                    {
                        p.Category,
                        p.Content,
                        p.CreatedDate,
                        p.Subject,
                        p.SenderId,
                        p.Sender.FirstName,
                        p.Sender.UserName,
                        p.Receiver.Id,
                    })
                .OrderByDescending(r => r.CreatedDate);
            return Request.CreateResponse(HttpStatusCode.OK, notifications.ToList(), jsonFormatter);
        }

        #region MyProfile
        [HttpGet]
        [Route("api/Agencies/{agencyId}/MyProfile")]
        public HttpResponseMessage MyProfile(int agencyId)
        {
            var agency = db.Agencies.FirstOrDefault(p => p.AgencyId == agencyId);
            var user = db.Users.Find(agency.AspNetUserId);

            var updateProfileViewModel = new UpdateProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Address = user.Address,
                CityId = user.CityId,
                CountryId = user.CountryId,
                DistrictId = user.DistrictId,
                profile_pic_base64 = user.ProfilePicUrl,
                id_proof_base64 = agency.IdProofDoc,
                id_proof1_base64 = agency.IdProofDoc1
            };

            //updateProfileViewModel.ContactOption = !string.IsNullOrWhiteSpace(agency.ContactOption) ? agency.ContactOption.Split(',') : new string[0];
            updateProfileViewModel.ContactOption = new string[0];
            updateProfileViewModel.ProfileVerified = agency.ProfileVerified;
            updateProfileViewModel.Age = Convert.ToInt32(agency.ManagerAge);
            //ViewBag.IdProofDoc = candidate.IdProofDoc;
            return Request.CreateResponse(HttpStatusCode.OK, updateProfileViewModel);

        }

        [HttpPut]
        [Route("api/Agencies/{agencyId}/MyProfile")]
        public HttpResponseMessage UpdateMyProfile(int agencyId, UpdateProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var agency = db.Agencies.FirstOrDefault(p => p.AgencyId == agencyId);
                var user = db.Users.Find(agency.AspNetUserId);
                user.PhoneNumber = model.PhoneNumber;
                user.Email = model.Email;
                user.Address = model.Address;
                user.CityId = model.CityId;
                user.CountryId = model.CountryId;
                user.DistrictId = model.DistrictId;

                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                if (agency != null)
                {
                    //agency.ManagerFirstName = model.FirstName;
                    //agency.ManagerLastName = model.LastName;
                    //******Need to relook at the above lines. You cannot update responsible person name with user's first name and last name - 15-Apr-2019
                    agency.ManagerAge = model.Age.ToString();
                    //agency.ContactOption = model.ContactOption != null && model.ContactOption.Length > 0 ? string.Join(",", model.ContactOption) : "";
                    //agency. = model.PhoneNumber;
                    //agency.EmailId = model.Email;
                    //agency.Address = model.Address;
                    agency.CountryId = model.CountryId;
                    agency.CityId = model.CityId;
                    agency.DistrictId = model.DistrictId;
                    db.Entry(agency).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Profile updated successfully.", Data = model });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Model is not valid." });
            }
        }


        [HttpPut]
        [Route("api/Agencies/{agencyId}/ProfilePicture")]
        public HttpResponseMessage UpdateProfilePic([FromUri]int agencyId, [FromBody] UpdateProfilePictureViewModel model)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model.Profile_pic_base64))
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Invalid file content." });
                var existingAgency = db.Agencies.FirstOrDefault(p => p.AgencyId == agencyId);
                if (existingAgency == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Status = "Error", Message = "Agency not found." });
                // now get the application user 
                var user = db.Users.Find(existingAgency.AspNetUserId);

                // store the image to file path and update the location in 2 tables i.e user and   candidate
                string path = HttpContext.Current.Server.MapPath("~/Uploads/");
                string fileName = Guid.NewGuid().ToString() + ".jpg";// + Base64Extensions.GetFileExtension(model.profile_pic_base64);
                File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.Profile_pic_base64));


                user.ProfilePicUrl = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName; //model.Profile_pic_base64;


                //user.ProfilePicUrl = model.Profile_pic_base64;
                db.Entry(user).Property(p => p.ProfilePicUrl).IsModified = true;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Unable to upload the file" });
            }
            finally
            {

            }
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Profile picture updated successfully." });
        }

        [HttpPut]
        [Route("api/Agencies/{agencyId}/IdProofDocs")]
        public HttpResponseMessage UpdateIdCard([FromUri]int agencyId, [FromBody]UpdateIdCardViewModel model)
        {
            #region ProfileImageUpload
            string profileImagePath = string.Empty;
            try
            {
                if (string.IsNullOrWhiteSpace(model.Id_Card_Front_base64) && string.IsNullOrWhiteSpace(model.Id_Card_Back_base64))
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Invalid file content." });

                var existingAgency = db.Agencies.FirstOrDefault(p => p.AgencyId == agencyId);
                if (existingAgency == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Status = "Error", Message = "Agency not found." });

                // now get the application user 
                var user = db.Users.Find(existingAgency.AspNetUserId);

                if (!string.IsNullOrWhiteSpace(model.Id_Card_Front_base64))
                {
                    // store the image to file path and update the location
                    string path = HttpContext.Current.Server.MapPath("~/Uploads/");
                    string fileName = Guid.NewGuid().ToString() + ".jpg";// + Base64Extensions.GetFileExtension(model.profile_pic_base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.Id_Card_Front_base64));

                    existingAgency.IdProofDoc = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName; //model.Id_Card_Front_base64;
                    db.Entry(existingAgency).Property(p => p.IdProofDoc).IsModified = true;
                }

                if (!string.IsNullOrWhiteSpace(model.Id_Card_Back_base64))
                {
                    // store the image to file path and update the location
                    string path = HttpContext.Current.Server.MapPath("~/Uploads/");
                    string fileName = Guid.NewGuid().ToString() + ".jpg";// + Base64Extensions.GetFileExtension(model.profile_pic_base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.Id_Card_Back_base64));

                    existingAgency.IdProofDoc1 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName; //model.Id_Card_Back_base64;
                    db.Entry(existingAgency).Property(p => p.IdProofDoc1).IsModified = true;
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Unable to upload the file" });
            }
            finally
            {

            }
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Id Proof documents updated successfully." });
            #endregion
        }

        [HttpPut]
        [Route("api/Agencies/{agencyId}/PasswordUpdate")]
        public HttpResponseMessage ChangePassword(int agencyId, ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Model is not valid." });
            }
            var UserManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var agency = db.Agencies.Find(agencyId);
            var result = UserManager.ChangePassword(agency.AspNetUserId, model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Password updated successfully." });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "There is some error." });
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/Agencies/{agencyId}")]
        public HttpResponseMessage GetAgencyDetails(int agencyId)
        {
            var agency = db.Agencies
               .Include(t => t.ApplicationUser)
               .FirstOrDefault(p => p.AgencyId == agencyId);
            if (agency == null)
                return Request.CreateResponse(HttpStatusCode.NotFound, new { Status = "Error", Message = "Agency not found."});
            if (agency.CountryId != 0 && agency.Country == null)
                agency.Country = db.Countries.FirstOrDefault(p => p.CountryId == agency.CountryId)?.CountryName;
            if (agency.CityId != 0 && agency.City == null)
                agency.City = db.Cities.FirstOrDefault(p => p.CityId == agency.CityId)?.CityName;
            if (agency.DistrictId != 0 && agency.District == null)
                agency.District = db.Districts.FirstOrDefault(p => p.DistrictId == agency.DistrictId)?.DistrictName;
            return Request.CreateResponse(HttpStatusCode.OK, agency, jsonFormatter);
        }
        #endregion

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
