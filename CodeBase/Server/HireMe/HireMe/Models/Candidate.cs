using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HireMe.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public int? AspNetUserId { get; set; }
        [ForeignKey("AspNetUserId")]
        public AppUser ApplicationUser { get; set; }
        public int? AgencyId { get; set; }

        public Gender Gender { get; set; }
        [NotMapped]
        public string GenderDesc { get; set; }
        public int Age { get; set; }
        public int ExperienceInYears { get; set; }
        public int ExperienceInMonths { get; set; }

        public string IdProofDoc { get; set; }
        public string IdProofDocDesc { get; set; }

        public bool ProfileVerified { get; set; }
        public StaffType StaffType { get; set; }
        [NotMapped]
        public string StaffTypeDesc { get; set; }
        public DateTime Disponibility { get; set; }

        public int CountryId { get; set; }
        [NotMapped]
        public string Country { get; set; }

        public int CityId { get; set; }
        [NotMapped]
        public string City { get; set; }

        public int DistrictId { get; set; }
        [NotMapped]
        public string District { get; set; }

        public SalaryType SalaryType { get; set; }
        [NotMapped]
        public string SalaryTypeDesc { get; set; }
        public string SalaryTypeOtherDesc { get; set; }

        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }

        public decimal ExpectedMinSalary { get; set; }
        public decimal ExpectedMaxSalary { get; set; }

        public bool SleepOnSite { get; set; }

        public int ExpectedMinRooms { get; set; }
        public int ExpectedMaxRooms { get; set; }

        public int MinGroupPeople { get; set; }
        public int MaxGroupPeople { get; set; }

        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public List<JobRequest> JobRequests { get; set; }
    }


    public class Agency
    {
        public int AgencyId { get; set; }

        public int AspNetUserId { get; set; }
        [ForeignKey("AspNetUserId")]
        public AppUser ApplicationUser { get; set; }
        public string AgencyName { get; set; }
        public string AgencyLogo { get; set; }
        public string AgencyWebsiteURL { get; set; }

        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerAge { get; set; }

        public string CompanyActivityDesc { get; set; }

        public int CountryId { get; set; }
        [NotMapped]
        public string Country { get; set; }

        public int CityId { get; set; }
        [NotMapped]
        public string City { get; set; }

        public int DistrictId { get; set; }
        [NotMapped]
        public string District { get; set; }

        public bool ProfileVerified { get; set; }

        public List<Candidate> Candidates { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
    }

    public class Employer
    {
        public int EmployerId { get; set; }
        public int AspNetUserId { get; set; }
        [ForeignKey("AspNetUserId")]
        public AppUser ApplicationUser { get; set; }

        public Gender Gender { get; set; }
        [NotMapped]
        public string GenderDesc { get; set; }

        public int CountryId { get; set; }
        [NotMapped]
        public string Country { get; set; }

        public int CityId { get; set; }
        [NotMapped]
        public string City { get; set; }

        public int DistrictId { get; set; }
        [NotMapped]
        public string District { get; set; }

        public bool ProfileVerified { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }

        public List<JobOffer> JobOffers { get; set; }
    }

    // Master tables
    public class JobCategory
    {
        public int JobCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string JobGroupName { get; set; }

        public List<Job> Jobs { get; set; }
    }

    public class Job
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public int JobCategoryId { get; set; } // FK
        public string JobDesc { get; set; }
        
        public string IconImage { get; set; }

        public List<JobTask> JobTasks { get; set; }
    }

    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public List<CountryJobMapper> CountryJobMappers { get; set; }
    }

    public class CountryJobMapper
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int JobId { get; set; }
        [ForeignKey("JobId")]
        public Job Job { get; set; }
    }

    public class JobTask
    {
        public JobTask()
        {
            this.SubTasks = new HashSet<JobTask>();
        }
        public int JobTaskId { get; set; }
        public int JobId { get; set; }
        //public int CountryId { get; set; }
        public string JobTaskName { get; set; }
        public string JobTaskDescription { get; set; }
        public string TaskSectionName { get; set; }
        public string TaskGroupName { get; set; }
        public ParamType TaskParamType { get; set; }
        public ParamType TaskParamValueType { get; set; }
        public string ParamAvailableOptions { get; set; }

        public int? ParentJobTaskId { get; set; }
        [ForeignKey("ParentJobTaskId")]
        public virtual ICollection<JobTask> SubTasks { get; set; }
        //public virtual JobTask JobTask1 { get; set; }
        public List<CountryJobTaskMapper> JobTaskCountryMapper { get; set; }
    }

    public class CountryJobTaskMapper
    {
        public int Id { get; set; }
        public int JobTaskId { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("JobTaskId")]
        public JobTask JobTask { get; set; }
    }

    //public class CandidateJobMapper
    //{
    //    public int Id { get; set; }
    //    public int CandidateId { get; set; }
    //    public int JobId { get; set; }
    //}

    public class JobRequest
    {
        public int JobRequestId { get; set; }
        public int CandidateId { get; set; }
        public int JobId { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime ValidTill { get; set; }

        public List<CandidateJobTask> CandidateJobTasks { get; set; }
    }

    public class CandidateJobTask
    {
        public int Id { get; set; }
        public int JobRequestId { get; set; }
        public int CandidateId { get; set; }
        public int JobTaskId { get; set; }
        [ForeignKey("JobTaskId")]
        public JobTask JobTask { get; set; }
        public string TaskResponse { get; set; }
        public string TaskResponseAdditionalDescription { get; set; }
    }

    public class JobOffer
    {
        public int JobOfferId { get; set; }
        public int JobId { get; set; }
        public int EmployerId { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime ValidTill { get; set; }

        public List<EmployerJobTask> EmployerJobTasks { get; set; }
    }

    public class EmployerJobTask
    {
        public int Id { get; set; }
        public int JobOfferId { get; set; }
        public int EmployerId { get; set; }
        public int JobTaskId { get; set; }
        [ForeignKey("JobTaskId")]
        public JobTask JobTask { get; set; }
        public string TaskResponse { get; set; }
        public string TaskResponseAdditionalDescription { get; set; }
    }

    public class SecurityQuestion
    {
        public int SecurityQuestionId { get; set; }
        public string Question { get; set; }
        public ParamType AnswerType { get; set; }
    }

    public class ApplicationUserSecurityQuestionAnswer
    {
        public int Id { get; set; }
        public string AspNetUserId { get; set; }
        [ForeignKey("AspNetUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public int SecurityQuestionId { get; set; }
        [ForeignKey("SecurityQuestionId")]
        public SecurityQuestion SecurityQuestion { get; set; }
        public string Answer { get; set; }
    }

    public class AppUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string ContactNo { get; set; }
        public string Password { get; set; }

        public List<ApplicationUserSecurityQuestionAnswer> UserSecurityQuestionAnswers { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public enum StaffType
    {
        Independent = 0,
        Agency = 1
    }

    public enum SalaryType
    {
        Monthly = 0,
        Hourly = 1,
        Others = 2
    }

    public enum ParamType
    {
        Text = 0,
        CheckBox = 1,
        DatePicker = 2,
        Number = 3,
        SelectBox = 4
    }
}