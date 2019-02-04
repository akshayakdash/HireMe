﻿using HireMe.Models;
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
            var myJobRequests = db.JobRequests
                .Include(path => path.Job)
                .Include(t => t.Candidate)
                .Where(j => j.CandidateId == candidateId)
                .ToList();
            return Request.CreateResponse(HttpStatusCode.OK, myJobRequests, jsonFormatter);
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

        [HttpPost]
        [Route("api/Candidates/{candidateId}/JobRequests")]
        public HttpResponseMessage CreateJobRequest(CandidateProfileViewModel candidateProfile)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region FavouriteJobOffers
        [HttpGet]
        [Route("api/Candidates/{candidateId}/FavouriteJobOffers")]
        public HttpResponseMessage MyFavouriteJobOffers(int candidateId)
        {
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
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [HttpPost]
        [Route("api/Candidates/{candidateId}/FavouriteJobOffers/{jobOfferId}")]
        public HttpResponseMessage AddFavouriteJobOffer(int candidateId, int jobOfferId)
        {
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
                return Request.CreateResponse(HttpStatusCode.OK);
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
                DistrictId = user.DistrictId
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
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK);
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

