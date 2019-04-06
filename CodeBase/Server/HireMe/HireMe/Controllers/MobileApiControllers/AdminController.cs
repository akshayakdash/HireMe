using HireMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Data.Entity;
using Newtonsoft.Json;
using HireMe.Utility;
using OfficeOpenXml;
using System.Collections;
using System.Linq.Dynamic;
using System.Net.Http.Headers;
using System.Web.Http.Cors;

namespace HireMe.Controllers.MobileApiControllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdminController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private JsonMediaTypeFormatter jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

        public AdminController()
        {
            var jSettings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            jsonFormatter.SerializerSettings = jSettings;
        }

        #region Candidate
        [HttpGet]
        [Route("api/Admin/UnverifiedCandidates")]
        public HttpResponseMessage UnverifiedCandidates()
        {
            var unverifiedCandidates = db.Candidates
                .Include(p => p.ApplicationUser)
                .Where(p => (p.IdProofDoc != null && p.IdProofDoc != "") && !p.ProfileVerified)
                .OrderByDescending(p => p.CandidateId)
                .ToList();
            return Request.CreateResponse(HttpStatusCode.OK, unverifiedCandidates, jsonFormatter);
        }

        [Route("api/Admin/ActivateCandidate/{candidateId}")]
        [HttpPost]
        public HttpResponseMessage ActivateCandidate(int candidateId)
        {
            // first get the candidate by Id
            var candidate = db.Candidates.Find(candidateId);
            // if candidate is null throw an exception
            if (candidate == null)
                throw new Exception("Candidate Not Found.");
            candidate.ProfileVerified = true;
            db.SaveChanges();
            NotificationFramework.SendNotification("", candidate.AspNetUserId, "Candidate Account Activation - JOBTek", "Your candidate Account " + candidate.FirstName + " was activated by Admin on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Candidate Profile verified successfully.", Data = candidate });
        }

        #endregion

        #region Employer
        [HttpGet]
        [Route("api/Admin/UnverifiedEmployers")]
        public HttpResponseMessage UnVerifiedEmployers()
        {
            var unverifiedEmployers = db.Employers
                .Include(p => p.ApplicationUser)
                //.Where(p => (p.IdProofDoc != null && p.IdProofDoc != "") && !p.ProfileVerified)
                .Where(p => !p.ProfileVerified) // note : as per charles we have added this condition, but it is problematic 
                .OrderByDescending(p => p.EmployerId)
                .ToList();
            return Request.CreateResponse(HttpStatusCode.OK, unverifiedEmployers, jsonFormatter);
        }

        [Route("api/Admin/ActivateEmployer/{employerId}")]
        [HttpPost]
        public HttpResponseMessage ActivateEmployer(int employerId)
        {
            // first get the candidate by Id
            var employer = db.Employers.Find(employerId);
            // if candidate is null throw an exception
            if (employer == null)
                throw new Exception("Employer Not Found.");
            employer.ProfileVerified = true;
            db.SaveChanges();
            NotificationFramework.SendNotification("", employer.AspNetUserId, "Employer Account Activation - JOBTek", "Your employer Account " + employer.FirstName + " was activated by Admin on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "employeer Profile verified successfully.", Data = employer });
        }
        #endregion

        #region Agency
        [HttpGet]
        [Route("api/Admin/UnverifiedAgencies")]
        public HttpResponseMessage UnverifiedAgencies()
        {
            var unverifiedAgencies = db.Agencies
                .Include(p => p.ApplicationUser)
                //.Where(p => (p.IdProofDoc != null && p.IdProofDoc != "") && !p.ProfileVerified)
                .Where(p => !p.ProfileVerified)
                .OrderByDescending(p => p.AgencyId)
                .ToList();
            return Request.CreateResponse(HttpStatusCode.OK, unverifiedAgencies, jsonFormatter);
        }

        [Route("api/Admin/ActivateAgency/{agencyId}")]
        [HttpPost]
        public HttpResponseMessage ActivateAgency(int agencyId)
        {
            // first get the agency by Id
            var agency = db.Agencies.Find(agencyId);
            // if candidate is null throw an exception
            if (agency == null)
                throw new Exception("Agency Not Found.");
            agency.ProfileVerified = true;
            db.SaveChanges();
            NotificationFramework.SendNotification("", agency.AspNetUserId, "Agency Account Activation - JOBTek", "Your agency Account " + agency.AgencyName + " was activated by Admin on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Agency Profile verified successfully.", Data = agency });
        }
        #endregion

        #region JobRequest
        [HttpGet]
        [Route("api/Admin/UnverifiedJobRequests")]
        public HttpResponseMessage UnverifiedJobRequests()
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.JobRequests.AsNoTracking()
               .Include(path => path.Job)
               .Include(t => t.Candidate)
               .Where(p => !p.VerifiedByAdmin)
               .OrderByDescending(p => p.JobRequestId)
               .ToList(), jsonFormatter);
        }

        [HttpPost]
        [Route("api/Admin/VerifyJobRequest/{jobRequestId}")]
        public HttpResponseMessage ValidateJobRequest(int jobRequestId)
        {
            var jobRequest = db.JobRequests.Find(jobRequestId);
            if (jobRequest == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            // now update two columns of JobRequest
            jobRequest.VerifiedByAdmin = true;
            jobRequest.VerificationDate = DateTime.Now;
            db.SaveChanges();

            var candidate = db.Candidates.Find(jobRequest.CandidateId);
            if (candidate != null)
            {
                var job = db.Jobs.Find(jobRequest.JobId);
                NotificationFramework.SendNotification("", candidate.AspNetUserId, "Job Request Verified - JOBTek", "Your job requrest for " + job.JobName + " was verified by Admin on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            }
            // we need to send a notification to the user about the job request verifications

            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Job request verified successfully.", Data = jobRequest });
        }
        #endregion

        #region JobOffer
        [HttpGet]
        [Route("api/Admin/UnverifiedJobOffers")]
        public HttpResponseMessage UnverifiedJobOffers()
        {
            var unverifiedJobOffers = db.JobOffers.AsNoTracking()
               .Include(path => path.Job)
               .Include(t => t.Employer)
               .Where(p => !p.VerifiedByAdmin)
               .OrderByDescending(p => p.JobOfferId)
               .ToList();
            return Request.CreateResponse(HttpStatusCode.OK, unverifiedJobOffers, jsonFormatter);
        }

        [HttpPost]
        [Route("api/Admin/VerifyJobOffer/{jobOfferId}")]
        public HttpResponseMessage ValidateJobOffer(int jobOfferId)
        {
            var jobOffer = db.JobOffers.Find(jobOfferId);
            if (jobOffer == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            // now update two columns of JobRequest
            jobOffer.VerifiedByAdmin = true;
            jobOffer.VerificationDate = DateTime.Now;
            db.SaveChanges();

            // we need to send a notification to the user about the job request verifications
            var employer = db.Employers.Find(jobOffer.EmployerId);
            if (employer != null)
            {
                var job = db.Jobs.Find(jobOffer.JobId);
                NotificationFramework.SendNotification("", employer.AspNetUserId, "Job Offer Verified - JOBTek", "Your job requrest for " + job.JobName + " was verified by Admin on " + DateTime.Now.Date.ToString("dd-MMM-yyyy"), 0, true);
            }

            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Job offer verified successfully.", Data = jobOffer });
        }
        #endregion

        #region KPI

        [HttpPost]
        [Route("api/Admin/SearchMembers")]
        public HttpResponseMessage SearchMembers(MemberSearchParam searchParam)
        {
            if (searchParam == null)
                searchParam = new MemberSearchParam { MemberType = MemberType.Candidate };

            object[] queryString = searchParam.GetSearchQuery();

            if (queryString != null)
            {
                ArrayList searchArgs = (ArrayList)queryString[1];
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
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/Admin/ExportMembersToExcel")]
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

        [Route("api/Admin/GetJobRequestDoughnotData")]
        [HttpGet]
        public HttpResponseMessage GetJobCounts(int year = 0)
        {
            year = year == 0 ? DateTime.Today.Year : year;
            var jobCounts = db.v_JobCounts;
            return Request.CreateResponse(HttpStatusCode.OK, jobCounts);
        }


        [Route("api/Admin/GetJobRequestCounts")]
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

        [Route("api/Admin/GetJobOfferDoughnotData")]
        [HttpGet]
        public HttpResponseMessage GetJobOfferDoghnotData(int year = 0)
        {
            year = year == 0 ? DateTime.Today.Year : year;
            var jobCounts = db.v_JobOfferDoughnotData;
            return Request.CreateResponse(HttpStatusCode.OK, jobCounts);
        }


        [Route("api/Admin/GetJobOfferCounts")]
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
