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
    }
}
