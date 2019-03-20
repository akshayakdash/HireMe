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
using System.Web.Http.Cors;

namespace HireMe.Controllers.MobileApiControllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class JobRequestsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private JsonMediaTypeFormatter jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

        public JobRequestsController()
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
        [Route("api/JobRequests")]
        public HttpResponseMessage SearchJobRequests([FromUri]V_JobRequestSearchParam searchParam = null)
        {
            if (searchParam != null)
            {
                object[] queryString = searchParam.GetSearchQuery();
                ArrayList searchArgs = (ArrayList)queryString[1];

                var jobRequests = db.v_SearchJobRequests_Mobile
                    .Include(p => p.JobRequestJobTasks)
                    .Where(p => p.JobId == searchParam.Job && p.VerifiedByAdmin)
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
                return Request.CreateResponse(HttpStatusCode.OK, db.v_SearchJobRequests_Mobile.Where(t => t.VerifiedByAdmin).OrderByDescending(p => p.JobRequestId).ToList(), jsonFormatter);
            }
        }

        [HttpGet]
        [Route("api/JobRequests/{jobRequestId}")]
        public HttpResponseMessage JobRequestDetails(int jobRequestId)
        {

            JobRequest jobRequest = db.JobRequests
                 .Include(t => t.Job)
                .Include(t => t.JobRequestJobTasks)
                .Include(p => p.Candidate)
               
                .FirstOrDefault(c => c.JobRequestId == jobRequestId);
            if (jobRequest == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            db.Entry(jobRequest.Job).Collection(p => p.JobTasks).Load();
            jobRequest.MasterJobTasks = db.Jobs
                .Include(p => p.JobTasks)
                .FirstOrDefault(p => p.JobId == jobRequest.JobId)
                .JobTasks;

            var userId = jobRequest.Candidate.AspNetUserId;
            // get all the feedbacks given to the user
            var userFeedbacks = db.UserFeedbacks.Include(p => p.Sender).Where(p => p.ReceiverId == userId);
            jobRequest.UserFeedbacks = userFeedbacks.ToList();

            return Request.CreateResponse(HttpStatusCode.OK, jobRequest, jsonFormatter);
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
