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
                    .Include(j => j.JobRequestJobTasks)
                    .AsQueryable()
                    .Where(queryString[0].ToString(), searchArgs.ToArray()).ToList();

                if (searchParam != null && searchParam.Tasks != null && searchParam.Tasks.Count > 0)
                {
                    jobRequests = jobRequests
                        .Where(p => p.JobRequestJobTasks.Select(t => t.JobTaskId).Any(c => searchParam.Tasks.Contains(c))).ToList();
                }
                return Request.CreateResponse(HttpStatusCode.OK, jobRequests);
            }
            else
            {
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

        [HttpGet]
        [Route("api/JobTekApi/SearchMembers")]
        public HttpResponseMessage SearchMembers([FromUri]MemberSearchParam searchParam)
        {
            if (searchParam == null)
                searchParam = new MemberSearchParam { MemberType = MemberType.Candidate };
            if (searchParam.MemberType == MemberType.Candidate)
            {
                var candidates = db.Candidates.Include(path => path.JobRequests.Select(p => p.Job)).Select(p => new
                {
                    Name = p.FirstName + " " + p.LastName,
                    MemberType = "Candidate",
                    Job = p.JobRequests.Select(c => c.Job.JobName),
                    ProfileStatus = p.ProfileVerified,
                    Gender = p.Gender == Gender.Female ? "Female" : "Male",
                    Age = p.Age
                });
                return Request.CreateResponse(HttpStatusCode.OK, candidates);
            }
            else
            {
                var employers = db.Employers.Include(path => path.JobOffers.Select(p => p.Job)).Select(p => new
                {
                    Name = p.FirstName + " " + p.LastName,
                    MemberType = "Employer",
                    Job = p.JobOffers.Select(c => c.Job.JobName),
                    ProfileStatus = p.ProfileVerified,
                    Gender = p.Gender == Gender.Female ? "Female" : "Male",
                    Age = 30
                }).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, employers);
            }

        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/JobTekApi/ExportMembersToExcel")]
        public HttpResponseMessage ExportMembersToExcel([FromUri]MemberSearchParam searchParam = null)
        {
            List<JobTekMember> jobTekMembers = new List<JobTekMember> { };
            if (searchParam == null)
                searchParam = new MemberSearchParam { MemberType = MemberType.Candidate };
            if (searchParam.MemberType == MemberType.Candidate)
            {
                jobTekMembers = db.Candidates.Include(path => path.JobRequests.Select(p => p.Job)).Select(p => new JobTekMember
                {
                    Name = p.FirstName + " " + p.LastName,
                    MemberType = "Candidate",
                    Job = p.JobRequests.Select(c => c.Job.JobName),
                    ProfileStatus = p.ProfileVerified,
                    Gender = p.Gender == Gender.Female ? "Female" : "Male",
                    Age = p.Age.Value
                }).ToList();
            }
            else
            {
                jobTekMembers = db.Employers.Include(path => path.JobOffers.Select(p => p.Job)).Select(p => new JobTekMember
                {
                    Name = p.FirstName + " " + p.LastName,
                    MemberType = "Employer",
                    Job = p.JobOffers.Select(c => c.Job.JobName),
                    ProfileStatus = p.ProfileVerified,
                    Gender = p.Gender == Gender.Female ? "Female" : "Male",
                    Age = 30
                }).ToList();
            }

            var responseDetails = Request.CreateResponse();
            using (var excelFile = new ExcelPackage())
            {
                var worksheet = excelFile.Workbook.Worksheets.Add("Sheet1");
                worksheet.DefaultColWidth = 25;
                worksheet.Cells.Style.WrapText = true;
                worksheet.Cells[1, 1].Value = "SlNo.";
                worksheet.Cells[1, 1].Style.Font.Bold = true;
                worksheet.Cells[1, 2].Value = "Name";
                worksheet.Cells[1, 2].Style.Font.Bold = true;
                worksheet.Cells[1, 3].Value = "Member Type";
                worksheet.Cells[1, 3].Style.Font.Bold = true;
                worksheet.Cells[1, 4].Value = "Member Type";
                worksheet.Cells[1, 4].Style.Font.Bold = true;
                worksheet.Cells[1, 5].Value = "Profile Status";
                worksheet.Cells[1, 5].Style.Font.Bold = true;
                worksheet.Cells[1, 6].Value = "Gender";
                worksheet.Cells[1, 6].Style.Font.Bold = true;
                worksheet.Cells[1, 7].Value = "Age";
                worksheet.Cells[1, 7].Style.Font.Bold = true;
                for (int index = 0; index < jobTekMembers.Count; index++)
                {
                    //  var currentRecord = response.Consumers[index];
                    worksheet.Cells[index + 2, 1].Value = index + 1;
                    worksheet.Cells[index + 2, 2].Value = jobTekMembers[index].Name;
                    worksheet.Cells[index + 2, 3].Value = jobTekMembers[index].MemberType;
                    worksheet.Cells[index + 2, 4].Value = jobTekMembers[index].Job.First();//String.Join(",",jobTekMembers[index].Job);
                    worksheet.Cells[index + 2, 5].Value = jobTekMembers[index].ProfileStatus ? "Verified" : "Not Verified";
                    worksheet.Cells[index + 2, 6].Value = jobTekMembers[index].Gender;
                    worksheet.Cells[index + 2, 7].Value = jobTekMembers[index].Age;
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
        public string MemberType { get; set; }
        public IEnumerable<string> Job { get; set; }
        public bool ProfileStatus { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
