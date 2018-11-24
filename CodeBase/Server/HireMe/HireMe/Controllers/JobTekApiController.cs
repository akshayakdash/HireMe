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

namespace HireMe.Controllers
{
    public class JobTekApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        [HttpGet]
        [Route("api/JobTekApi/SearchJobRequests")]
        public HttpResponseMessage SearchJobRequests([FromUri]JobRequestSearchParam searchParam = null)
        {
            //searchParam = new JobRequestSearchParam { };
            //searchParam.Gender = Gender.Male;
            //searchParam.YearsOfExperience = 3;
            if (searchParam != null)
            {
                object[] queryString = searchParam.GetSearchQuery();
                ArrayList searchArgs = (ArrayList)queryString[1];
                var jobRequests = db.JobRequests
                    .Include(j => j.Candidate)
                    .Include(j => j.Job)
                    .AsQueryable()
                    .Where(queryString[0].ToString(), searchArgs.ToArray());
                return Request.CreateResponse(HttpStatusCode.OK, jobRequests.ToList());
            }
            else {
                return Request.CreateResponse(HttpStatusCode.OK, db.JobRequests.Include(p => p.Candidate).Include(t => t.Job).ToList());
            }
        }

        [HttpGet]
        [Route("api/JobTekApi/SearchJobOffers")]
        public HttpResponseMessage SearchJobOffers([FromUri]JobRequestSearchParam searchParam = null)
        {
            //searchParam = new JobRequestSearchParam { };
            //searchParam.Gender = Gender.Male;
            //searchParam.YearsOfExperience = 3;

            //object[] queryString = searchParam.GetSearchQuery();
            //ArrayList searchArgs = (ArrayList)queryString[1];
            //var jobRequests = db.JobRequests
            //    .Include(j => j.Candidate)
            //    .Include(j => j.Job)
            //    .AsQueryable()
            //    .Where(queryString[0].ToString(), searchArgs.ToArray());

            var jobOffers = db.JobOffers.Include(p => p.Job).Include(t => t.Employer).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, jobOffers);
        }
    }
}
