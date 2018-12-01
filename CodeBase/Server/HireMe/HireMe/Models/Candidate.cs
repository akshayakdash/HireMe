using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HireMe.Models
{
    public class Candidate
    {
        public Candidate()
        {
            JobRequests = new List<JobRequest>();
        }
        public int CandidateId { get; set; }
        public string AspNetUserId { get; set; }
        //[ForeignKey("AspNetUserId")]
        //public AppUser ApplicationUser { get; set; }
        [ForeignKey("AspNetUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public int? AgencyId { get; set; }

        public string UserName { get; set; }
        public string ProfilePicUrl { get; set; }

        public Gender Gender { get; set; }
        [NotMapped]
        public string GenderDesc { get; set; }
        public int? Age { get; set; }
        public int? ExperienceInYears { get; set; }
        public int? ExperienceInMonths { get; set; }

        public string IdProofDoc { get; set; }
        public string IdProofDocDesc { get; set; }

        public bool ProfileVerified { get; set; }
        public StaffType StaffType { get; set; }
        [NotMapped]
        public string StaffTypeDesc { get; set; }
        public DateTime Disponibility { get; set; }


        public int? CountryId { get; set; }
        public string Country { get; set; }
        [ForeignKey("CountryId")]
        public Country CountryEntity { get; set; }

        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public City CityEntity { get; set; }
        public string City { get; set; }

        public int? DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public District DistrictEntity { get; set; }
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

        public int? ExpectedMinRooms { get; set; }
        public int? ExpectedMaxRooms { get; set; }

        public int? MinGroupPeople { get; set; }
        public int? MaxGroupPeople { get; set; }

        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }

        public string AdditionalDescription { get; set; }

        public List<JobRequest> JobRequests { get; set; }

        public List<JobOffer> FavouriteJobOffers { get; set; }

        // This field is added later to check the consent of the user
        // if contact option is blank then both email and phone no will be visible
        public string ContactOption { get; set; } 

    }


    public class Agency
    {
        public Agency()
        {
            Candidates = new List<Candidate>();
        }
        public int AgencyId { get; set; }

        public string AspNetUserId { get; set; }
        //[ForeignKey("AspNetUserId")]
        //public AppUser ApplicationUser { get; set; }
        public string AgencyName { get; set; }
        public string AgencyLogo { get; set; }
        public string AgencyWebsiteURL { get; set; }

        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerAge { get; set; }

        public string CompanyActivityDesc { get; set; }


        public int? CountryId { get; set; }
        public string Country { get; set; }
        [ForeignKey("CountryId")]
        public Country CountryEntity { get; set; }

        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public City CityEntity { get; set; }
        public string City { get; set; }

        public int? DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public District DistrictEntity { get; set; }
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
        public Employer()
        {
            JobOffers = new List<JobOffer>();
            FavouriteJobRequests = new List<JobRequest>();
        }
        public int EmployerId { get; set; }
        public string AspNetUserId { get; set; }
        //[ForeignKey("AspNetUserId")]
        //public AppUser ApplicationUser { get; set; }
        [ForeignKey("AspNetUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        public Gender Gender { get; set; }
        [NotMapped]
        public string GenderDesc { get; set; }

        public int? CountryId { get; set; }
        public string Country { get; set; }
        [ForeignKey("CountryId")]
        public Country CountryEntity { get; set; }

        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public City CityEntity { get; set; }
        public string City { get; set; }

        public int? DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public District DistrictEntity { get; set; }
        public string District { get; set; }

        public bool ProfileVerified { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }

        public List<JobOffer> JobOffers { get; set; }

        public List<JobRequest> FavouriteJobRequests { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Columns added later 
        public string IdProofDoc { get; set; }
        public string IdProofDocDesc { get; set; }

         public string ProfilePicUrl { get; set; }

        public string EmailId { get; set; }
        public string ContactNo { get; set; }

        public string ContactOption { get; set; }

        public string Address { get; set; }
    }

    // Master tables
    public class JobCategory
    {
        public int JobCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string IconImage { get; set; }
        //public string JobGroupName { get; set; }

        public List<Job> Jobs { get; set; }
    }

    public class Job
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public int JobCategoryId { get; set; } // FK

        public string JobGroup { get; set; }

        public string JobDesc { get; set; }
        
        public string IconImage { get; set; }

        public List<JobTask> JobTasks { get; set; }
    }

    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public List<CountryJobMapper> CountryJobMappers { get; set; }
        public List<City> Cities { get; set; }
    }

    public class City
    {
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public List<District> Districts { get; set; }
    }

    public class District
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
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

        [NotMapped]
        public bool Selected { get; set; }
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
        [ForeignKey("CandidateId")]
        public Candidate Candidate { get; set; }
        public int JobId { get; set; }
        [ForeignKey("JobId")]
        public Job Job { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime ValidTill { get; set; }
        public string JobRequestDescription { get; set; }
        public List<JobRequestJobTask> JobRequestJobTasks { get; set; }
        [NotMapped]
        public List<JobTask> MasterJobTasks { get; set; }
        public List<JobRequestNote> JobRequestNotes { get; set; }

        public string SkillPic1 { get; set; }
        public string SkillPic2 { get; set; }
        public string SkillPic3 { get; set; }


        public bool VerifiedByAdmin { get; set; }
        public DateTime? VerificationDate { get; set; }
    }

    public class JobRequestJobTask
    {
        public int Id { get; set; }
        public int JobRequestId { get; set; }
        //public int CandidateId { get; set; }
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
        [ForeignKey("JobId")]
        public Job Job { get; set; }
        public int EmployerId { get; set; }
        [ForeignKey("EmployerId")]
        public Employer Employer { get; set; }

        public Gender Gender { get; set; }
        [NotMapped]
        public string GenderDesc { get; set; }
        public int Age { get; set; }

        public int MinAge { get; set; }
        public int MaxAge { get; set; }

        public int ExperienceInYears { get; set; }
        public int ExperienceInMonths { get; set; }

        public string IdProofDoc { get; set; }
        public string IdProofDocDesc { get; set; }

        public bool ProfileVerified { get; set; }
        public StaffType StaffType { get; set; }
        [NotMapped]
        public string StaffTypeDesc { get; set; }
        public DateTime Disponibility { get; set; }

        public int? CountryId { get; set; }
        public string Country { get; set; }

        public int? CityId { get; set; }
        public string City { get; set; }

        public int? DistrictId { get; set; }
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


        public bool IsPublished { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime ValidTill { get; set; }

        public string AdditionalDescription { get; set; }

        public List<JobOfferJobTask> JobOfferJobTasks { get; set; }


        public bool VerifiedByAdmin { get; set; }
        public DateTime? VerificationDate { get; set; }

        [NotMapped]
        public List<JobTask> MasterJobTasks { get; set; }
    }

    public class JobOfferJobTask
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

    ////Please note this is only a mapper table
    //public class CandidateFavouriteJobOffer
    //{
    //    public int CandidateId { get; set; }
    //    public int JobOfferId { get; set; }
    //}

    //// Please note this is only a mapper table
    //public class EmployerFavouriteJobRequest
    //{
    //    public int EmployerId { get; set; }
    //    public int JobRequestId { get; set; }
    //}

    //public class AppUser
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string UserName { get; set; }
    //    public string ContactNo { get; set; }
    //    public string Password { get; set; }

    //    public List<ApplicationUserSecurityQuestionAnswer> UserSecurityQuestionAnswers { get; set; }
    //}


    public class JobRequestNote
    {
        public int JobRequestNoteId { get; set; }
        public int JobRequestId { get; set; }
        public string Note { get; set; }
        public int StarRating { get; set; }
        public int EmployerId { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
    }
    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    public enum StaffType
    {
        Independent = 1,
        Agency = 2
    }

    public enum SalaryType
    {
        Monthly = 1,
        Hourly = 2,
        Others = 3
    }

    public enum ParamType
    {
        Text = 1,
        CheckBox = 2,
        DatePicker = 3,
        Number = 4,
        SelectBox = 5
    }

    public enum CountryEnum
    {
        Country1,
        Country2,
        Country3,
        Country4
    }

    public enum CityEnum
    {
        Abidjan,
        Yamoussoukro
    }

    public enum DistrictEnum
    {
        Abobo,
        Adjamé,
        Anyama,
        Attécoubé,
        Bingerville,
        Cocody,
        Koumassi,
        Marcory,
        Plateau,
        Portbouët,
        Treichville,
        Songon,
        Yopougon

    }
}