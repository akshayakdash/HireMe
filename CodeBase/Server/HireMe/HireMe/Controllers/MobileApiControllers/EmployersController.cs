using HireMe.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Data.Entity;

namespace HireMe.Controllers.MobileApiControllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private JsonMediaTypeFormatter jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;



        public EmployersController()
        {
            var jSettings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            jsonFormatter.SerializerSettings = jSettings;
        }



        #region JobOffers
        [HttpGet]
        [Route("api/Employers/{employerId}/JobOffers")]
        public HttpResponseMessage MyJobOffers(int employerId)
        {
            var myJobOffers = db.JobOffers
                .Include(path => path.Job)
                .Include(t => t.Employer)
                .Where(j => j.EmployerId == employerId)
                .ToList();
            return Request.CreateResponse(HttpStatusCode.OK, myJobOffers, jsonFormatter);
        }

        [HttpPost]
        [Route("api/Employers/{employerId}/JobOffers")]
        public HttpResponseMessage CreateJobOffer([FromUri]int employerId, [FromBody] EmployerJobOfferViewModel employerJobOffer)
        {
            if (ModelState.IsValid)
            {
                
                var existingEmployer = db.Employers.Include(path => path.JobOffers).FirstOrDefault(p => p.EmployerId == employerId);
                if (existingEmployer == null)
                {
                    var appUser = db.Users.Find(existingEmployer.AspNetUserId);
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

                    var appUsr = db.Users.Include(p => p.Employers).FirstOrDefault(p => p.Id == appUser.Id);

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
            }
          
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Job Offer created successfully."});
        }

        [HttpGet]
        [Route("api/Employers/{employerId}/JobOffers/{jobOfferId}")]
        public HttpResponseMessage JobOfferDetails(int employerId, int jobOfferId)
        {
            var myJobOffer = db.JobOffers
                .Include(path => path.Job)
                .Include(t => t.Employer)
                .FirstOrDefault(j => j.EmployerId == employerId && j.JobOfferId == jobOfferId);
            return Request.CreateResponse(HttpStatusCode.OK, myJobOffer, jsonFormatter);
        }
        #endregion

        #region FavouriteJobRequests
        [HttpGet]
        [Route("api/Employers/{employerId}/FavouriteJobRequests")]
        public HttpResponseMessage MyFavouriteJobRequests(int employerId)
        {
            var existingEmployer = db.Employers.Include(t => t.FavouriteJobRequests.Select(c => c.Job)).FirstOrDefault(p => p.EmployerId == employerId);
            if (existingEmployer != null && existingEmployer.FavouriteJobRequests != null && existingEmployer.FavouriteJobRequests.Count > 0)
            {
                existingEmployer.FavouriteJobRequests.ForEach(favJobRequest =>
                {
                    db.Entry(favJobRequest).Reference(p => p.Candidate).Load();
                });
                return Request.CreateResponse(HttpStatusCode.OK, existingEmployer.FavouriteJobRequests, jsonFormatter);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [HttpPost]
        [Route("api/Employers/{employerId}/FavouriteJobRequests/{jobRequestId}")]
        public HttpResponseMessage AddFavouriteJobRequest(int employerId, int jobRequestId)
        {
            var existingEmployer = db.Employers.Include(t => t.FavouriteJobRequests.Select(c => c.Job)).FirstOrDefault(p => p.EmployerId == employerId);
            if (existingEmployer != null && existingEmployer.FavouriteJobRequests != null && existingEmployer.FavouriteJobRequests.Count > 0)
            {
                var jobRequest = db.JobRequests.Find(jobRequestId);
                if (jobRequest != null)
                {
                    existingEmployer.FavouriteJobRequests.Add(jobRequest);
                    db.SaveChanges();
                }
                return Request.CreateResponse(HttpStatusCode.Created, existingEmployer.FavouriteJobRequests, jsonFormatter);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [HttpDelete]
        [Route("api/Employers/{employerId}/FavouriteJobRequests/{jobRequestId}")]
        public HttpResponseMessage DeleteFavouriteJobRequest(int employerId, int jobRequestId)
        {
            var existingEmployer = db.Employers.Include(t => t.FavouriteJobRequests.Select(c => c.Job)).FirstOrDefault(p => p.EmployerId == employerId);
            if (existingEmployer != null && existingEmployer.FavouriteJobRequests != null && existingEmployer.FavouriteJobRequests.Count > 0)
            {
                var jobRequest = db.JobRequests.Find(jobRequestId);
                if (jobRequest != null)
                {
                    existingEmployer.FavouriteJobRequests.Remove(jobRequest);
                    db.SaveChanges();
                }
                return Request.CreateResponse(HttpStatusCode.NoContent, existingEmployer.FavouriteJobRequests, jsonFormatter);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        #endregion

        #region MyNotifications
        [HttpGet]
        [Route("api/Employers/{employerId}/Notifications")]
        public HttpResponseMessage Notifications(int employerId)
        {
            var existingEmployer = db.Employers.FirstOrDefault(p => p.EmployerId == employerId);
            var userId = existingEmployer.AspNetUserId;
            var notifications = db.Notifications
                .Include(path => path.Sender)
                .Include(t => t.Receiver)
                .Where(p => p.ReceiverId == userId)
                .OrderByDescending(r => r.CreatedDate);
            return Request.CreateResponse(HttpStatusCode.OK, notifications.ToList(), jsonFormatter);
        }
        #endregion

        #region MyProfile
        [HttpGet]
        [Route("api/Employers/{employerId}/MyProfile")]
        public HttpResponseMessage MyProfile(int employerId)
        {
            var employer = db.Employers.FirstOrDefault(p => p.EmployerId == employerId);
            var user = db.Users.Find(employer.AspNetUserId);

            var updateProfileViewModel = new UpdateProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Address = user.Address,
                CityId = user.CityId,
                CountryId = user.CountryId,
                DistrictId = user.DistrictId
            };

            updateProfileViewModel.ContactOption = !string.IsNullOrWhiteSpace(employer.ContactOption) ? employer.ContactOption.Split(',') : new string[0];
            updateProfileViewModel.ProfileVerified = employer.ProfileVerified;
            updateProfileViewModel.Age = employer.Age;
            //ViewBag.IdProofDoc = candidate.IdProofDoc;
            return Request.CreateResponse(HttpStatusCode.OK, updateProfileViewModel);

        }

        [HttpPut]
        [Route("api/Employers/{employerId}/MyProfile")]
        public HttpResponseMessage UpdateMyProfile(int employerId, UpdateProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employer = db.Employers.FirstOrDefault(p => p.EmployerId == employerId);
                var user = db.Users.Find(employer.AspNetUserId);
                user.PhoneNumber = model.PhoneNumber;
                user.Email = model.Email;
                user.Address = model.Address;
                user.CityId = model.CityId;
                user.CountryId = model.CountryId;
                user.DistrictId = model.DistrictId;

                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                if (employer != null)
                {
                    employer.FirstName = model.FirstName;
                    employer.LastName = model.LastName;
                    employer.Age = model.Age;
                    employer.ContactOption = model.ContactOption != null && model.ContactOption.Length > 0 ? string.Join(",", model.ContactOption) : "";
                    employer.ContactNo = model.PhoneNumber;
                    employer.EmailId = model.Email;
                    employer.Address = model.Address;
                    employer.CountryId = model.CountryId;
                    employer.CityId = model.CityId;
                    employer.DistrictId = model.DistrictId;
                    db.Entry(employer).State = System.Data.Entity.EntityState.Modified;
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        #endregion

        #region JobRequestNote
        [Route("api/Employers/{employerId}/JobRequestNotes")]
        [HttpPost]
        public HttpResponseMessage SaveJobRequestNote([FromBody]JobRequestNote jobRequestNote, [FromUri]int employerId)
        {
            jobRequestNote.EmployerId = employerId;
            var jobRequest = db.JobRequests
                .Include(t => t.Job)
                .Include(p => p.JobRequestNotes)
                .FirstOrDefault(p => p.JobRequestId == jobRequestNote.JobRequestId);
            if (jobRequest == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            jobRequest.JobRequestNotes.Add(jobRequestNote);

            // now calculate the average star rating for the job request based on the user rating
            // we can use this logic  -- (5*252 + 4*124 + 3*40 + 2*29 + 1*33) / (252+124+40+29+33)
            var averageRating = (int)Math.Ceiling(db.JobRequestNotes.Average(p => p.StarRating));
            jobRequest.StarRating = averageRating;
            db.Entry(jobRequest).Property(p => p.StarRating).IsModified = true;

            // now we need to make an entry to the user feed back
            var employer = db.Employers.Find(employerId);
            var candidate = db.Candidates.Find(jobRequest.CandidateId);
            // if userId is null then probably we need to get the user id from the employerid from jobrequestnote
            var userFeedback = new UserFeedback { SenderId = employer.AspNetUserId, ReceiverId = candidate.AspNetUserId, CreatedDate = DateTime.Now, Comments = jobRequestNote.Note, JobName = jobRequest.Job.JobName, Rating = jobRequestNote.StarRating };
            db.UserFeedbacks.Add(userFeedback);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Created, "Note added successfully.");
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
