using HireMe.Models;
using HireMe.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Linq.Dynamic;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.Web.Http.Cors;
using System.IO;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace HireMe.Controllers.MobileApiControllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CandidatesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private JsonMediaTypeFormatter jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

        public CandidatesController()
        {
            var jSettings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            jsonFormatter.SerializerSettings = jSettings;
        }
        #region SearchJobs
        [HttpGet]
        [Route("api/Candidates/SearchJobRequests")]
        public HttpResponseMessage SearchJobRequests([FromUri]V_JobRequestSearchParam searchParam = null)
        {
            if (searchParam != null)
            {
                object[] queryString = searchParam.GetSearchQuery();
                ArrayList searchArgs = (ArrayList)queryString[1];

                var jobRequests = db.v_JobRequests
                    .Include(p => p.JobRequestJobTasks)
                    .Where(p => p.JobId == searchParam.Job)
                    .AsQueryable()
                    .Where(queryString[0].ToString(), searchArgs.ToArray()).ToList();


                if (searchParam != null && searchParam.Tasks != null && searchParam.Tasks.Count > 0)
                {
                    jobRequests = jobRequests
                        .Where(p => p.JobRequestJobTasks.Select(t => t.JobTaskId).Any(c => searchParam.Tasks.Contains(c))).ToList();
                }
                return Request.CreateResponse(HttpStatusCode.OK, jobRequests.OrderByDescending(p => p.JobRequestId).ToList(), jsonFormatter);
            }
            else
            {
                //return Request.CreateResponse(HttpStatusCode.OK, db.JobRequests.Include(p => p.Candidate).Include(t => t.Job).ToList());
                return Request.CreateResponse(HttpStatusCode.OK, db.v_JobRequests.OrderByDescending(p => p.JobRequestId).ToList(), jsonFormatter);
            }
        }

        [HttpGet]
        [Route("api/Candidates/SearchJobOffers")]
        public HttpResponseMessage SearchJobOffers([FromUri]JobOfferSearchParam searchParam = null)
        {
            if (searchParam != null)
            {
                object[] queryString = searchParam.GetSearchQuery();
                ArrayList searchArgs = (ArrayList)queryString[1];
                var jobOffers = db.JobOffers
                    .Include(j => j.Employer)
                    .Include(j => j.Job)
                    .Include(j => j.JobOfferJobTasks)
                    .AsQueryable()
                    .Where(queryString[0].ToString(), searchArgs.ToArray()).ToList();

                if (searchParam != null && searchParam.Tasks != null && searchParam.Tasks.Count > 0)
                {
                    jobOffers = jobOffers
                        .Where(p => p.JobOfferJobTasks.Select(t => t.JobTaskId).Any(c => searchParam.Tasks.Contains(c))).ToList();
                }
                return Request.CreateResponse(HttpStatusCode.OK, jobOffers.OrderByDescending(p => p.JobOfferId).ToList(), jsonFormatter);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.JobOffers
                    .Include(j => j.Employer)
                    .Include(j => j.Job)
                    .Include(j => j.JobOfferJobTasks)
                    .OrderByDescending(p => p.JobOfferId).ToList(), jsonFormatter);
            }
        }
        #endregion

        #region JobRequests
        [HttpGet]
        [Route("api/Candidates/{candidateId}/JobRequests")]
        public HttpResponseMessage MyJobRequests(int candidateId)
        {
            //var myJobRequests = db.JobRequests
            //    .Include(path => path.Job)
            //    .Include(t => t.Candidate)
            //    .Where(j => j.CandidateId == candidateId)
            //    .ToList();

            var myJobRequests = db.v_SearchJobRequests_Mobile
                .Where(p => p.CandidateId == candidateId && p.IsPublished)
                .ToList();
            return Request.CreateResponse(HttpStatusCode.OK, myJobRequests, jsonFormatter);
        }

        [HttpPost]
        [Route("api/Candidates/{candidateId}/JobRequests")]
        public HttpResponseMessage CreateJobRequest([FromUri]int candidateId, [FromBody] CandidateProfileViewModel candidateProfile)
        {

            var existingCandidate = db.Candidates.Include(p => p.JobRequests).FirstOrDefault(t => t.CandidateId == candidateId);
            if (existingCandidate == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Candidate not found.");
            var jobRequest = new JobRequest { IsPublished = true, PublishedDate = DateTime.Now, JobRequestDescription = candidateProfile.AdditionalDescription, JobId = candidateProfile.JobId, JobRequestJobTasks = new List<JobRequestJobTask> { } };

            string path = HttpContext.Current.Server.MapPath("~/Uploads/");

            if (!string.IsNullOrWhiteSpace(candidateProfile.JobRequestSkillPic1Base64))
            {
                //jobRequest.SkillPic1 = candidateProfile.JobRequestSkillPic1Base64;
                string fileName = DateTime.Now.Ticks.ToString() + "." + Base64Extensions.GetFileExtension(candidateProfile.JobRequestSkillPic1Base64);
                File.WriteAllBytes(path + fileName, Convert.FromBase64String(candidateProfile.JobRequestSkillPic1Base64));
                //jobRequest.SkillPic2 = path + fileName;

                jobRequest.SkillPic1 = "http://40.89.160.98/Uploads/" + fileName;
            }

            if (!string.IsNullOrWhiteSpace(candidateProfile.JobRequestSkillPic2Base64))
            {
                //jobRequest.SkillPic2 = candidateProfile.JobRequestSkillPic2Base64;
                string fileName = DateTime.Now.Ticks.ToString() + "." + Base64Extensions.GetFileExtension(candidateProfile.JobRequestSkillPic2Base64);
                File.WriteAllBytes(path + fileName, Convert.FromBase64String(candidateProfile.JobRequestSkillPic2Base64));
                jobRequest.SkillPic2 = "http://40.89.160.98/Uploads/" + fileName;
            }

            if (!string.IsNullOrWhiteSpace(candidateProfile.JobRequestSkillPic3Base64))
            {
                //jobRequest.SkillPic3 = candidateProfile.JobRequestSkillPic3Base64;
                string fileName = DateTime.Now.Ticks.ToString() + "." + Base64Extensions.GetFileExtension(candidateProfile.JobRequestSkillPic3Base64);
                File.WriteAllBytes(path + fileName, Convert.FromBase64String(candidateProfile.JobRequestSkillPic3Base64));
                jobRequest.SkillPic3 = "http://40.89.160.98/Uploads/" + fileName;
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
            return Request.CreateResponse(HttpStatusCode.Created, new { Status = "OK", Message = "Job request created successfully", Data = jobRequest }, jsonFormatter);
        }

        [HttpGet]
        [Route("api/Candidates/{candidateId}/JobRequests/{jobRequestId}")]
        public HttpResponseMessage JobRequestDetails(int candidateId, int jobRequestId)
        {
            var myJobRequest = db.JobRequests
                .Include(path => path.Job)
                .Include(t => t.Candidate)
                .FirstOrDefault(j => j.CandidateId == candidateId && j.JobRequestId == jobRequestId);
            return Request.CreateResponse(HttpStatusCode.OK, myJobRequest, jsonFormatter);
        }

        [HttpDelete]
        [Route("api/Candidates/{candidateId}/JobRequests/{jobRequestId}")]
        public HttpResponseMessage DeleteJobRequest(int candidateId, int jobRequestId)
        {
            // first find the job request
            var jobRequest = db.JobRequests.Find(jobRequestId);
            if (jobRequest == null)
                return Request.CreateResponse(HttpStatusCode.NotFound, "Job request does not exists.");
            jobRequest.IsPublished = false;
            db.Entry(jobRequest).Property(t => t.IsPublished).IsModified = true;
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Job offer removed successfully", Data = jobRequest });
        }

        #endregion

        #region FavouriteJobOffers
        [HttpGet]
        [Route("api/Candidates/{candidateId}/FavouriteJobOffers")]
        public HttpResponseMessage MyFavouriteJobOffers(int candidateId)
        {
            List<JobOffer> newArray = new List<JobOffer>();
            var existingCandidate = db.Candidates.Include(t => t.FavouriteJobOffers.Select(c => c.Job)).FirstOrDefault(p => p.CandidateId == candidateId);
            if (existingCandidate != null && existingCandidate.FavouriteJobOffers != null && existingCandidate.FavouriteJobOffers.Count > 0)
            {
                existingCandidate.FavouriteJobOffers.ForEach(favJobRequest =>
                {
                    db.Entry(favJobRequest).Reference(p => p.Employer).Load();
                });
                return Request.CreateResponse(HttpStatusCode.OK, existingCandidate.FavouriteJobOffers, jsonFormatter);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, newArray);
            }
        }

        [HttpPost]
        [Route("api/Candidates/{candidateId}/FavouriteJobOffers/{jobOfferId}")]
        public HttpResponseMessage AddFavouriteJobOffer(int candidateId, int jobOfferId)
        {
            JobOffer newJob = new JobOffer();
            var existingCandidate = db.Candidates.Include(t => t.FavouriteJobOffers.Select(c => c.Job)).FirstOrDefault(p => p.CandidateId == candidateId);
            if (existingCandidate != null && existingCandidate.FavouriteJobOffers != null && existingCandidate.FavouriteJobOffers.Count > 0)
            {
                var jobOffer = db.JobOffers.Find(jobOfferId);
                if (jobOffer != null)
                {
                    existingCandidate.FavouriteJobOffers.Add(jobOffer);
                    db.SaveChanges();
                }
                return Request.CreateResponse(HttpStatusCode.Created, existingCandidate.FavouriteJobOffers, jsonFormatter);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, newJob);
            }
        }

        [HttpDelete]
        [Route("api/Candidates/{candidateId}/FavouriteJobOffers/{jobOfferId}")]
        public HttpResponseMessage DeleteFavouriteJobOffer(int candidateId, int jobOfferId)
        {
            var existingCandidate = db.Candidates.Include(t => t.FavouriteJobOffers.Select(c => c.Job)).FirstOrDefault(p => p.CandidateId == candidateId);
            if (existingCandidate != null && existingCandidate.FavouriteJobOffers != null && existingCandidate.FavouriteJobOffers.Count > 0)
            {
                var jobOffer = db.JobOffers.Find(jobOfferId);
                if (jobOffer != null)
                {
                    existingCandidate.FavouriteJobOffers.Remove(jobOffer);
                    db.SaveChanges();
                }
                return Request.CreateResponse(HttpStatusCode.NoContent, existingCandidate.FavouriteJobOffers, jsonFormatter);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }


        #endregion

        #region MyNotifications
        [HttpGet]
        [Route("api/Candidates/{candidateId}/Notifications")]
        public HttpResponseMessage Notifications(int candidateId)
        {
            var existingCandidate = db.Candidates.FirstOrDefault(p => p.CandidateId == candidateId);
            var userId = existingCandidate.AspNetUserId;
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
        #endregion

        #region MyProfile
        [HttpGet]
        [Route("api/Candidates/{candidateId}/MyProfile")]
        public HttpResponseMessage MyProfile(int candidateId)
        {
            var candidate = db.Candidates.FirstOrDefault(p => p.CandidateId == candidateId);
            var user = db.Users.Find(candidate.AspNetUserId);

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
                id_proof_base64 = candidate.IdProofDoc,
                id_proof1_base64 = candidate.IdProofDoc1
            };

            updateProfileViewModel.ContactOption = !string.IsNullOrWhiteSpace(candidate.ContactOption) ? candidate.ContactOption.Split(',') : new string[0];
            updateProfileViewModel.ProfileVerified = candidate.ProfileVerified;
            updateProfileViewModel.Age = candidate.Age.HasValue ? candidate.Age.Value : 0;
            //ViewBag.IdProofDoc = candidate.IdProofDoc;
            return Request.CreateResponse(HttpStatusCode.OK, updateProfileViewModel);

        }

        [HttpPut]
        [Route("api/Candidates/{candidateId}/MyProfile")]
        public HttpResponseMessage UpdateMyProfile(int candidateId, UpdateProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var candidate = db.Candidates.FirstOrDefault(p => p.CandidateId == candidateId);
                var user = db.Users.Find(candidate.AspNetUserId);
                user.PhoneNumber = model.PhoneNumber;
                user.Email = model.Email;
                user.Address = model.Address;
                user.CityId = model.CityId;
                user.CountryId = model.CountryId;
                user.DistrictId = model.DistrictId;

                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                if (candidate == null)
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Candidate not found on this id." });

                if (candidate != null)
                {
                    candidate.FirstName = model.FirstName;
                    candidate.LastName = model.LastName;
                    candidate.Age = model.Age;
                    candidate.ContactOption = model.ContactOption != null && model.ContactOption.Length > 0 ? string.Join(",", model.ContactOption) : "";
                    candidate.ContactNo = model.PhoneNumber;
                    candidate.EmailId = model.Email;
                    candidate.Address = model.Address;
                    candidate.CountryId = model.CountryId;
                    candidate.CityId = model.CityId;
                    candidate.DistrictId = model.DistrictId;
                    db.Entry(candidate).State = System.Data.Entity.EntityState.Modified;
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
        [Route("api/Candidates/{candidateId}/ProfilePicture")]
        public HttpResponseMessage UpdateProfilePic([FromUri]int candidateId, [FromBody] UpdateProfilePictureViewModel model)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(model.Profile_pic_base64))
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Invalid file content." });
                var existingCandidate = db.Candidates.FirstOrDefault(p => p.CandidateId == candidateId);
                if (existingCandidate == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Status = "Error", Message = "Candidate not found." });

                // store the image to file path and update the location in 2 tables i.e user and   candidate
                string path = HttpContext.Current.Server.MapPath("~/Uploads/");
                string fileName = DateTime.Now.Ticks.ToString() +"." + Base64Extensions.GetFileExtension(model.Profile_pic_base64);
                File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.Profile_pic_base64));
                // now get the application user 
                var user = db.Users.Find(existingCandidate.AspNetUserId);
                user.ProfilePicUrl = "http://40.89.160.98/Uploads/" + fileName;//path + fileName;


                db.Entry(user).Property(p => p.ProfilePicUrl).IsModified = true;

                existingCandidate.ProfilePicUrl = "http://40.89.160.98/Uploads/" + fileName;//path + fileName;
                db.Entry(existingCandidate).Property(p => p.ProfilePicUrl).IsModified = true;
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
        [Route("api/Candidates/{candidateId}/IdProofDocs")]
        public HttpResponseMessage UpdateIdCard([FromUri]int candidateId, [FromBody]UpdateIdCardViewModel model)
        {
            #region ProfileImageUpload
            string profileImagePath = string.Empty;
            try
            {
                if (string.IsNullOrWhiteSpace(model.Id_Card_Front_base64) && string.IsNullOrWhiteSpace(model.Id_Card_Back_base64))
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Invalid file content." });

                var existingCandidate = db.Candidates.FirstOrDefault(p => p.CandidateId == candidateId);
                if (existingCandidate == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Status = "Error", Message = "Candidate not found." });

                var userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
                // now get the application user 
                var user = db.Users.Find(existingCandidate.AspNetUserId);
                string path = HttpContext.Current.Server.MapPath("~/Uploads/");
                if (!string.IsNullOrWhiteSpace(model.Id_Card_Front_base64))
                {
                    string fileName = DateTime.Now.Ticks.ToString() + "." + Base64Extensions.GetFileExtension(model.Id_Card_Front_base64);
                   File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.Id_Card_Front_base64));
                    
                    existingCandidate.IdProofDoc = "http://40.89.160.98/Uploads/" + fileName;//path + fileName;
                    db.Entry(existingCandidate).Property(p => p.IdProofDoc).IsModified = true;
                }

                if (!string.IsNullOrWhiteSpace(model.Id_Card_Back_base64))
                {
                    string fileName = DateTime.Now.Ticks.ToString() + "." + Base64Extensions.GetFileExtension(model.Id_Card_Back_base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.Id_Card_Back_base64));
                    existingCandidate.IdProofDoc1 = "http://40.89.160.98/Uploads/" + fileName;//path + fileName;
                    db.Entry(existingCandidate).Property(p => p.IdProofDoc1).IsModified = true;
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
        [Route("api/Candidates/{candidateId}/PasswordUpdate")]
        public HttpResponseMessage ChangePassword(int candidateId, ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Model is not valid." });
            }
            var UserManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var candidate = db.Candidates.Find(candidateId);
            var result = UserManager.ChangePassword(candidate.AspNetUserId, model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Password updated successfully." });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "There is some error." });
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

