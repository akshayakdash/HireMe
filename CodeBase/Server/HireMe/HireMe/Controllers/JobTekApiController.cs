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
using OfficeOpenXml;
using System.Net.Http.Headers;
using Microsoft.AspNet.Identity;

namespace HireMe.Controllers
{
    public class JobTekApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/JobTekApi/SearchJobRequests")]
        public HttpResponseMessage SearchJobRequests([FromUri]V_JobRequestSearchParam searchParam = null)
        {
            //searchParam = new JobRequestSearchParam { };
            //searchParam.Gender = Gender.Male;
            //searchParam.YearsOfExperience = 3;
            if (searchParam != null)
            {
                object[] queryString = searchParam.GetSearchQuery();
                ArrayList searchArgs = (ArrayList)queryString[1];
                //var jobRequests = db.JobRequests
                //    .Include(j => j.Candidate)
                //    .Include(j => j.Job)
                //    .Include(j => j.JobRequestJobTasks)
                //    .AsQueryable()
                //    .Where(queryString[0].ToString(), searchArgs.ToArray()).ToList();

                //var query = from JobRequest in db.JobRequests.Where(p => p.JobId == searchParam.Job)
                //            from Candidate in db.Candidates.Where(p => p.CandidateId == JobRequest.CandidateId)
                //            from Job in db.Jobs.Where(p => p.JobId == JobRequest.JobId)
                //            from JobRequestJobTasks in db.JobRequestJobTasks.Where(p => p.JobRequestId == JobRequest.JobId)
                //            select new { JobRequest, Candidate, Job, JobRequestJobTasks };

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
                return Request.CreateResponse(HttpStatusCode.OK, jobRequests.OrderByDescending(p => p.JobRequestId).ToList());
            }
            else
            {
                //return Request.CreateResponse(HttpStatusCode.OK, db.JobRequests.Include(p => p.Candidate).Include(t => t.Job).ToList());
                return Request.CreateResponse(HttpStatusCode.OK, db.v_JobRequests.OrderByDescending(p => p.JobRequestId).ToList());
            }
        }

        [HttpGet]
        [Route("api/JobTekApi/SearchJobOffers")]
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
                return Request.CreateResponse(HttpStatusCode.OK, jobOffers.OrderByDescending(p => p.JobOfferId).ToList());

                //return Request.CreateResponse(HttpStatusCode.OK, db.JobOffers
                //      .Include(j => j.Employer)
                //      .Include(j => j.Job)
                //      .Include(j => j.JobOfferJobTasks)
                //      .OrderByDescending(p => p.JobOfferId).ToList());
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.JobOffers
                    .Include(j => j.Employer)
                    .Include(j => j.Job)
                    .Include(j => j.JobOfferJobTasks)
                    .OrderByDescending(p => p.JobOfferId).ToList());
            }
        }

        //[HttpGet]
        //[Route("api/JobTekApi/SearchJobOffers")]
        //public HttpResponseMessage SearchJobOffers([FromUri]JobRequestSearchParam searchParam = null)
        //{
        //    //searchParam = new JobRequestSearchParam { };
        //    //searchParam.Gender = Gender.Male;
        //    //searchParam.YearsOfExperience = 3;

        //    //object[] queryString = searchParam.GetSearchQuery();
        //    //ArrayList searchArgs = (ArrayList)queryString[1];
        //    //var jobRequests = db.JobRequests
        //    //    .Include(j => j.Candidate)
        //    //    .Include(j => j.Job)
        //    //    .AsQueryable()
        //    //    .Where(queryString[0].ToString(), searchArgs.ToArray());

        //    var jobOffers = db.JobOffers.Include(p => p.Job).Include(t => t.Employer).ToList();
        //    return Request.CreateResponse(HttpStatusCode.OK, jobOffers);
        //}

        [HttpGet]
        [Route("api/JobTekApi/SearchMembers")]
        public HttpResponseMessage SearchMembers([FromUri]MemberSearchParam searchParam)
        {
            if (searchParam == null)
                searchParam = new MemberSearchParam { MemberType = MemberType.Candidate };

            object[] queryString = searchParam.GetSearchQuery();

            if (queryString != null)
            {
                ArrayList searchArgs = (ArrayList)queryString[1];

                //if (searchParam.MemberType == MemberType.Candidate)
                //{
                //var candidates = db.Candidates.Include(path => path.JobRequests.Select(p => p.Job)).Select(p => new
                //{
                //    Name = p.FirstName + " " + p.LastName,
                //    MemberType = "Candidate",
                //    Job = p.JobRequests.Select(c => c.Job.JobName),
                //    ProfileStatus = p.ProfileVerified,
                //    Gender = p.Gender == Gender.Female ? "Female" : "Male",
                //    Age = p.Age
                //});

                var candidates = db.v_ExportJobRequests.Where(queryString[0].ToString(), searchArgs.ToArray()).Select(p => new JobTekMember
                {
                    Name = p.Name,
                    EmailId = p.EmailId,
                    ContactNo = p.ContactNo,
                    Gender = p.Gender,
                    Age = p.Age,
                    MemberType = p.Profile,
                    ProfileVerified = p.ProfileVerified,
                    JobSought = p.JobSought,
                    PublishedDate = p.PublishedDate
                }).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, candidates);
            }
            else
            {
                var candidates = db.v_ExportJobRequests.Select(p => new JobTekMember
                {
                    Name = p.Name,
                    EmailId = p.EmailId,
                    ContactNo = p.ContactNo,
                    Gender = p.Gender,
                    Age = p.Age,
                    MemberType = p.Profile,
                    ProfileVerified = p.ProfileVerified,
                    JobSought = p.JobSought,
                    PublishedDate = p.PublishedDate
                }).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, candidates);
            }
            //}
            //else
            //{
            //var employers = db.Employers.Include(path => path.JobOffers.Select(p => p.Job)).Select(p => new
            //{
            //    Name = p.FirstName + " " + p.LastName,
            //    MemberType = "Employer",
            //    Job = p.JobOffers.Select(c => c.Job.JobName),
            //    ProfileStatus = p.ProfileVerified,
            //    Gender = p.Gender == Gender.Female ? "Female" : "Male",
            //    Age = 30
            //}).ToList();

            //var employers = db.v_ExportJobOffers.Where(queryString[0].ToString(), searchArgs.ToArray()).Select(p => new JobTekMember
            //{
            //    Name = p.Name,
            //    EmailId = p.EmailId,
            //    ContactNo = p.ContactNo,
            //    Gender = p.Gender,
            //    Age = p.Age,
            //    ProfileVerified = p.ProfileVerified,
            //    JobSought = p.JobSought,
            //    PublishedDate = p.PublishedDate
            //}).ToList();
            //return Request.CreateResponse(HttpStatusCode.OK, employers);
            //}

        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/JobTekApi/ExportMembersToExcel")]
        public HttpResponseMessage ExportMembersToExcel([FromUri]MemberSearchParam searchParam = null)
        {
            List<JobTekMember> jobTekMembers = new List<JobTekMember> { };
            if (searchParam == null)
                searchParam = new MemberSearchParam { MemberType = MemberType.Candidate };
            object[] queryString = searchParam.GetSearchQuery();

            if (queryString != null)
            {
                ArrayList searchArgs = (ArrayList)queryString[1];


                jobTekMembers = db.v_ExportJobRequests.Where(queryString[0].ToString(), searchArgs.ToArray()).Select(p => new JobTekMember
                {
                    Name = p.Name,
                    EmailId = p.EmailId,
                    ContactNo = p.ContactNo,
                    Gender = p.Gender,
                    Age = p.Age,
                    MemberType = p.Profile,
                    ProfileVerified = p.ProfileVerified,
                    JobSought = p.JobSought,
                    PublishedDate = p.PublishedDate
                }).ToList();
            }
            else
            {
                jobTekMembers = db.v_ExportJobRequests.Select(p => new JobTekMember
                {
                    Name = p.Name,
                    EmailId = p.EmailId,
                    ContactNo = p.ContactNo,
                    Gender = p.Gender,
                    Age = p.Age,
                    MemberType = p.Profile,
                    ProfileVerified = p.ProfileVerified,
                    JobSought = p.JobSought,
                    PublishedDate = p.PublishedDate
                }).ToList();
            }

            //jobTekMembers = db.v_ExportJobRequests.Select(p => new JobTekMember
            //{
            //    Name = p.Name,
            //    EmailId = p.EmailId,
            //    ContactNo = p.ContactNo,
            //    Gender = p.Gender,
            //    Age = p.Age,
            //    MemberType = p.Profile,
            //    ProfileVerified = p.ProfileVerified,
            //    JobSought = p.JobSought,
            //    PublishedDate = p.PublishedDate
            //}).ToList();
            //}
            //else
            //{
            //    //jobTekMembers = db.Employers.Include(path => path.JobOffers.Select(p => p.Job)).Select(p => new JobTekMember
            //    //{
            //    //    Name = p.FirstName + " " + p.LastName,
            //    //    MemberType = "Employer",
            //    //    Job = p.JobOffers.Select(c => c.Job.JobName),
            //    //    ProfileStatus = p.ProfileVerified,
            //    //    Gender = p.Gender == Gender.Female ? "Female" : "Male",
            //    //    Age = 30
            //    //}).ToList();

            //    jobTekMembers = db.v_ExportJobOffers.Select(p => new JobTekMember
            //    {
            //        Name = p.Name,
            //        EmailId = p.EmailId,
            //        ContactNo = p.ContactNo,
            //        Gender = p.Gender,
            //        Age = p.Age,
            //        ProfileVerified = p.ProfileVerified,
            //        JobSought = p.JobSought,
            //        PublishedDate = p.PublishedDate
            //    }).ToList();
            //}

            var responseDetails = Request.CreateResponse();
            using (var excelFile = new ExcelPackage())
            {
                var worksheet = excelFile.Workbook.Worksheets.Add("Sheet1");
                worksheet.DefaultColWidth = 25;

                worksheet.Cells[1, 1].Value = "Name";
                worksheet.Cells[1, 1].Style.Font.Bold = true;
                worksheet.Cells[1, 2].Value = "Email";
                worksheet.Cells[1, 2].Style.Font.Bold = true;
                worksheet.Cells[1, 3].Value = "Role";
                worksheet.Cells[1, 3].Style.Font.Bold = true;

                worksheet.Cells[1, 4].Value = "Contact No";
                worksheet.Cells[1, 4].Style.Font.Bold = true;
                worksheet.Cells[1, 5].Value = "Gender";
                worksheet.Cells[1, 5].Style.Font.Bold = true;
                worksheet.Cells[1, 6].Value = "Age(in yrs)";
                worksheet.Cells[1, 6].Style.Font.Bold = true;
                worksheet.Cells[1, 7].Value = "ProfileVerified";
                worksheet.Cells[1, 7].Style.Font.Bold = true;
                worksheet.Cells[1, 8].Value = "Job Request";
                worksheet.Cells[1, 8].Style.Font.Bold = true;
                worksheet.Cells[1, 9].Value = "Published Date";
                worksheet.Cells[1, 9].Style.Font.Bold = true;
                for (int index = 0; index < jobTekMembers.Count; index++)
                {
                    //  var currentRecord = response.Consumers[index];

                    worksheet.Cells[index + 2, 1].Value = jobTekMembers[index].Name;
                    worksheet.Cells[index + 2, 2].Value = jobTekMembers[index].EmailId;
                    worksheet.Cells[index + 2, 3].Value = jobTekMembers[index].MemberType;
                    worksheet.Cells[index + 2, 4].Value = jobTekMembers[index].ContactNo;
                    worksheet.Cells[index + 2, 5].Value = jobTekMembers[index].Gender;
                    worksheet.Cells[index + 2, 6].Value = jobTekMembers[index].Age;
                    worksheet.Cells[index + 2, 7].Value = jobTekMembers[index].ProfileVerified;
                    worksheet.Cells[index + 2, 8].Value = jobTekMembers[index].JobSought;
                    worksheet.Cells[index + 2, 9].Value = jobTekMembers[index].PublishedDate;
                }

                responseDetails.Content = new ByteArrayContent(excelFile.GetAsByteArray());
                var contentType = responseDetails.Content.Headers.ContentType;
                contentType = new MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                contentType.CharSet = "UTF-8";

                responseDetails.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                responseDetails.Content.Headers.ContentDisposition.FileName = "members" + DateTime.Now.Date.ToString("ddMMMyyyy") + ".xlsx";
                responseDetails.StatusCode = System.Net.HttpStatusCode.OK;
            }
            return responseDetails;
        }

        [Route("api/JobTekApi/SaveJobRequestNote")]
        [HttpPost]
        public HttpResponseMessage SaveJobRequestNote(JobRequestNote jobRequestNote)
        {
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
            var userId = User.Identity.GetUserId();
            var candidate = db.Candidates.Find(jobRequest.CandidateId);
            // if userId is null then probably we need to get the user id from the employerid from jobrequestnote
            var userFeedback = new UserFeedback { SenderId = userId, ReceiverId = candidate.AspNetUserId, CreatedDate = DateTime.Now, Comments = jobRequestNote.Note, JobName = jobRequest.Job.JobName, Rating = jobRequestNote.StarRating };

            db.UserFeedbacks.Add(userFeedback);

            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Created, "Note added successfully.");
        }

        [Route("api/JobTekApi/GetCountries")]
        [HttpGet]
        public HttpResponseMessage GetCountries()
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.Countries);
        }


        [Route("api/JobTekApi/GetCities")]
        [HttpGet]
        public HttpResponseMessage GetCities(int countryId = 0)
        {
            if (countryId == 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.Cities);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.Cities.Where(p => p.CountryId == countryId));
            }
        }

        [Route("api/JobTekApi/GetDistricts")]
        [HttpGet]
        public HttpResponseMessage GetDistricts(int cityId = 0)
        {
            if (cityId == 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.Districts);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.Districts.Where(p => p.CityId == cityId));
            }
        }
        [Route("api/JobTekApi/GetJobTasks")]
        [HttpGet]
        public HttpResponseMessage GetJobTasks(int jobId)
        {
            var job = db.Jobs.Include(path => path.JobTasks).FirstOrDefault(p => p.JobId == jobId);
            return Request.CreateResponse(HttpStatusCode.OK, job);
        }

        [Route("api/JobTekApi/GetJobs")]
        [HttpGet]
        public HttpResponseMessage GetJobs()
        {
            var job = db.Jobs;
            return Request.CreateResponse(HttpStatusCode.OK, job);
        }
        [Route("api/JobTekApi/GetJobRequestDoughnotData")]
        [HttpGet]
        public HttpResponseMessage GetJobCounts(int year = 0)
        {
            year = year == 0 ? DateTime.Today.Year : year;
            var jobCounts = db.v_JobCounts;
            return Request.CreateResponse(HttpStatusCode.OK, jobCounts);
        }


        [Route("api/JobTekApi/GetJobRequestCounts")]
        [HttpGet]
        public HttpResponseMessage GetJobRequestCounts(int year = 0)
        {
            year = year == 0 ? DateTime.Today.Year : year;
            var jobCounts = db.v_JobRequestCount//.Where(p => p.TotalRequests > 0)
                .GroupBy(p => p.JobName)
                .Select(g => new
                {
                    JobName = g.Key,
                    Items = g.ToList()
                }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, jobCounts);
        }

        [Route("api/JobTekApi/GetJobOfferDoughnotData")]
        [HttpGet]
        public HttpResponseMessage GetJobOfferDoghnotData(int year = 0)
        {
            year = year == 0 ? DateTime.Today.Year : year;
            var jobCounts = db.v_JobOfferDoughnotData;
            return Request.CreateResponse(HttpStatusCode.OK, jobCounts);
        }


        [Route("api/JobTekApi/GetJobOfferCounts")]
        [HttpGet]
        public HttpResponseMessage GetJobOfferCounts(int year = 0)
        {
            year = year == 0 ? DateTime.Today.Year : year;
            var jobCounts = db.v_JobOfferCount//.Where(p => p.TotalRequests > 0)
                .GroupBy(p => p.JobName)
                .Select(g => new
                {
                    JobName = g.Key,
                    Items = g.ToList()
                }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, jobCounts);
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

    public class JobTekMember
    {
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string ProfileVerified { get; set; }
        public string JobSought { get; set; }
        public string PublishedDate { get; set; }

        public string MemberType { get; set; }
        public IEnumerable<string> Job { get; set; }
        public bool ProfileStatus { get; set; }

        public string Age { get; set; }
    }
}
