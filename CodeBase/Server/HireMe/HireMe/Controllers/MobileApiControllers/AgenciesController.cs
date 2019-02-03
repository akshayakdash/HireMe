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

namespace HireMe.Controllers.MobileApiControllers
{
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

            return Request.CreateResponse(HttpStatusCode.OK);
        }


        [HttpGet]
        [Route("api/Agencies/{agencyId}/JobRequests")]
        public HttpResponseMessage MyJobRequests(int agencyId)
        {
          
            var agency = db.Agencies.Find(agencyId);
            if (agency != null)
            {
                var jobRequests = db.JobRequests.Include(path => path.Job).Include(t => t.Candidate).ToList();
                jobRequests = jobRequests.Where(p => p.Candidate.StaffType == StaffType.Agency && p.Candidate.AgencyId == agency.AgencyId).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, jobRequests, jsonFormatter);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
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
