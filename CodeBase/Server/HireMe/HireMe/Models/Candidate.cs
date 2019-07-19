using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DateTime DOB { get; set; }
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
        public string IdProofDoc1 { get; set; }

        [NotMapped]
        public Agency Agency { get; set; }
    }


    public class Agency
    {
        public Agency()
        {
            Candidates = new List<Candidate>();
        }
        public int AgencyId { get; set; }

        public string AspNetUserId { get; set; }
        [ForeignKey("AspNetUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public string AgencyName { get; set; }
        public string AgencyLogo { get; set; }
        public string AgencyWebsiteURL { get; set; }

        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerAge { get; set; }
        public DateTime ManagerDOB { get; set; }

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

        public string IdProofDoc { get; set; }

        [NotMapped]
        public string PhoneNo
        {
            get
            {
                if (ApplicationUser != null)
                {
                    return ApplicationUser.PhoneNumber;
                }
                return "";
            }
        }
        [NotMapped]
        public string EmailId
        {
            get
            {
                if (ApplicationUser != null)
                {
                    return ApplicationUser.Email;
                }
                return "";
            }
        }

        [NotMapped]
        public string ProfilePicUrl
        {
            get
            {
                if (ApplicationUser != null)
                {
                    return ApplicationUser.ProfilePicUrl;
                }
                return "";
            }
        }

        public string IdProofDoc1 { get; internal set; }
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

        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string IdProofDoc1 { get; internal set; }
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

        public string IconImage { get; set; }

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

        public int StarRating { get; set; } // This field will hold the average star ratings from the job request notes


        public bool VerifiedByAdmin { get; set; }
        public DateTime? VerificationDate { get; set; }
        public string AgencyJobRequestGroupId { get; set; }
        public string AgencyJobRequestTitle { get; set; }
        [NotMapped]
        public string SkillPic1Base64 { get; internal set; }
        [NotMapped]
        public string SkillPic2Base64 { get; internal set; }
        [NotMapped]
        public string SkillPic3Base64 { get; internal set; }
        //public int CrewMemberCount { get; set; }

        [NotMapped]
        public List<UserFeedback> UserFeedbacks { get; set; }
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

        public int StarRating { get; set; }

        [NotMapped]
        public List<JobTask> MasterJobTasks { get; set; }

        public List<JobOfferNote> JobOfferNotes { get; set; }
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

    public class JobOfferNote
    {
        public int JobOfferNoteId { get; set; }
        public int JobOfferId { get; set; }
        public string Note { get; set; }
        public int StarRating { get; set; }
        public int CandidateId { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
    }

    public class JobTekNotification
    {
        public int JobTekNotificationId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string SenderId { get; set; }
        [ForeignKey("SenderId")]
        //[NotMapped]
        public ApplicationUser Sender { get; set; }
        public string ReceiverId { get; set; }
        [ForeignKey("ReceiverId")]
        //[NotMapped]
        public ApplicationUser Receiver { get; set; }
        public int Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool SeenByReceiver { get; set; }
    }

    public class SignalRUserConnection
    {
        public int Id { get; set; }
        public string AspNetUserId { get; set; }
        [ForeignKey("AspNetUserId")]
        public ApplicationUser User { get; set; }
        public string ConnectionId { get; set; }
        public string UserAgent { get; set; }
        public bool Connected { get; set; }
    }

    public class UserFeedback
    {
        public int Id { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        [ForeignKey("SenderId")]
        public ApplicationUser Sender { get; set; }
        //[ForeignKey("ReceiverId")]
        //public ApplicationUser Receiver { get; set; }
        public string Comments { get; set; }
        public string JobName { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }

    }

    public class JOBTekOtp
    {
        public int Id { get; set; }
        public string AspNetUserId { get; set; }
        public string OTP { get; set; }
        public string UniqueCode { get; set; }
        public string Reason { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    #region DB Views
    public class v_SearchJobRequest
    {
        [Key]
        public int JobRequestId { get; set; }
        public int CandidateId { get; set; }
        public int JobId { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string JobRequestDescription { get; set; }
        public int StarRating { get; set; }
        public bool VerifiedByAdmin { get; set; }
        public string AspNetUserId { get; set; }
        public int? AgencyId { get; set; }
        public string ProfilePicUrl { get; set; }
        public Gender Gender { get; set; }
        public int? Age { get; set; }
        public DateTime DOB { get; set; }
        public int? ExperienceInYears { get; set; }
        public int? ExperienceInMonths { get; set; }
        public string IdProofDoc { get; set; }
        public string IdProofDocDesc { get; set; }
        public bool ProfileVerified { get; set; }
        public StaffType StaffType { get; set; }
        public DateTime? Disponibility { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int? DistrictId { get; set; }
        public SalaryType SalaryType { get; set; }
        public string SalaryTypeOtherDesc { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
        public decimal ExpectedMinSalary { get; set; }
        public decimal ExpectedMaxSalary { get; set; }
        public bool SleepOnSite { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string ContactOption { get; set; }
        public string JobName { get; set; }
        public int JobCategoryId { get; set; }
        public string IconImage { get; set; }
        public string AdditionalDescription { get; set; }
        public List<JobRequestJobTask> JobRequestJobTasks { get; set; }
    }

    public class v_SearchJobRequest_Mobile
    {
        [Key]
        public int JobRequestId { get; set; }
        public int CandidateId { get; set; }
        public int JobId { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string JobRequestDescription { get; set; }
        public int StarRating { get; set; }
        public bool VerifiedByAdmin { get; set; }
        
        public int? AgencyId { get; set; }
       
        public Gender Gender { get; set; }
        public int? Age { get; set; }
        public DateTime DOB { get; set; }
        public int? ExperienceInYears { get; set; }
        public int? ExperienceInMonths { get; set; }
       
        public bool ProfileVerified { get; set; }
        public StaffType StaffType { get; set; }
        public DateTime? Disponibility { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }

        public decimal ExpectedMinSalary { get; set; }
        public decimal ExpectedMaxSalary { get; set; }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string ContactOption { get; set; }
        public string JobName { get; set; }
        public int JobCategoryId { get; set; }
        public string IconImage { get; set; }
        public string AdditionalDescription { get; set; }
        [ForeignKey("JobRequestId")]
        public List<JobRequestJobTask> JobRequestJobTasks { get; set; }
        public string ProfilePicUrl { get; set; }
    }

    public class v_SearchJobOffer_Mobile
    {
        [Key]
        public int JobofferId { get; set; }
        public int JobId { get; set; }
        public int EmployerId { get; set; }
        public int ProfileVerified { get; set; } // view modified...added profile verified column
        public bool VerifiedByAdmin { get; set; } // view modified...added this column on 14-Apr-2019
        public Gender Gender { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int MinExperience { get; set; }
        public int MaxExperience { get; set; }
        public StaffType StaffType { get; set; }
        public SalaryType SalaryType { get; set; }
        public string SalaryTypeOtherDesc { get; set; }
        public DateTime Disponibility { get; set; }
        public decimal ExpectedMinSalary { get; set; }
        public decimal ExpectedMaxSalary { get; set; }
        public int NoOfChildren { get; set; }
        public int NoOfAdults { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string AdditionalDescription { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string JobName { get; set; }
        public int JobCategoryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public string ContactOption { get; set; }
        public List<JobOfferJobTask> JobOfferJobTasks { get; set; }
        public string ProfilePicUrl { get; set; }
    }

    public class v_ExportJobRequest
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string ProfileVerified { get; set; }
        public string JobSought { get; set; }
        public string PublishedDate { get; set; }
        public string Profile { get; set; }
    }

    public class v_ExportJobOffer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string ProfileVerified { get; set; }
        public string JobSought { get; set; }
        public string PublishedDate { get; set; }
    }

    [Table("v_categorywisejobcount")]
    public class v_JobCount
    {
        [Key]
        public string JobName { get; set; }
        public string TotalRequests { get; set; }
        public int Year { get; set; }
    }
    [Table("v_jobRequests")]
    public class v_JobRequest_Count
    {
        [Key]
        public string PK { get; set; }
        public string Month { get; set; }
        public string JobName { get; set; }
        public int TotalRequests { get; set; }
        public int Year { get; set; }
    }

    [Table("v_categorywiseoffercount")]
    public class v_JobCount_JobOffer
    {
        [Key]
        public string JobName { get; set; }
        //public int TotalOffers { get; set; }
        [Column("TotalOffers")]
        public int TotalRequests { get; set; }
        public int Year { get; set; }
    }

    [Table("v_joboffers")]
    public class v_JobOffer_Count
    {
        [Key]
        public string PK { get; set; }
        public string Month { get; set; }
        public string JobName { get; set; }
        //public int TotalOffers { get; set; }
        [Column("TotalOffers")]
        public int TotalRequests { get; set; }
        public int Year { get; set; }
    }
    #endregion


    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    public enum StaffType
    {
        DoesNotMatter = 0,
        Independent = 1,
        Agency = 2
    }

    public enum SalaryType
    {
        Monthly = 1,
        Hourly = 2,
        PriceOfService = 3
    }

    public enum ParamType
    {
        Text = 1,
        CheckBox = 2,
        DatePicker = 3,
        Number = 4,
        SelectBox = 5
    }

    //public enum CountryEnum
    //{
    //    Country1,
    //    Country2,
    //    Country3,
    //    Country4
    //}

    //public enum CityEnum
    //{
    //    Abidjan,
    //    Yamoussoukro
    //}

    //public enum DistrictEnum
    //{
    //    Abobo,
    //    Adjamé,
    //    Anyama,
    //    Attécoubé,
    //    Bingerville,
    //    Cocody,
    //    Koumassi,
    //    Marcory,
    //    Plateau,
    //    Portbouët,
    //    Treichville,
    //    Songon,
    //    Yopougon

    //}
}