using HireMe.Models;
using HireMe.Utility;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace HireMe.Controllers.MobileApiControllers
{
    public class JobOffersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private JsonMediaTypeFormatter jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

        public JobOffersController()
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
        [Route("api/JobOffers")]
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

        [HttpGet]
        [Route("api/JobOffers/{jobOfferId}")]
        public HttpResponseMessage JobOfferDetails(int jobOfferId)
        {

            JobOffer jobOffer = db.JobOffers
                .Include(t => t.JobOfferJobTasks)
                .Include(p => p.Employer)
                .Include(t => t.Job)
                .FirstOrDefault(c => c.JobOfferId == jobOfferId);
            if (jobOffer == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            jobOffer.MasterJobTasks = db.Jobs
                .Include(p => p.JobTasks)
                .FirstOrDefault(p => p.JobId == jobOffer.JobId)
                .JobTasks;

            //var userId = jobOffer.Employer.AspNetUserId;
            //// get all the feedbacks given to the user
            //var userFeedbacks = db.UserFeedbacks.Include(p => p.Sender).Where(p => p.ReceiverId == userId);
            //ViewBag.UserFeedbacks = userFeedbacks.ToList();


            return Request.CreateResponse(HttpStatusCode.OK, jobOffer, jsonFormatter);
        }
    }
}
