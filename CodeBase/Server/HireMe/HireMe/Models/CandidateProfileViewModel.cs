﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HireMe.Utility;
using System.ComponentModel.DataAnnotations;

namespace HireMe.Models
{
    public class CandidateProfileViewModel
    {
        //public CandidateProfileViewModel()
        //{
        //    JobRequests = new List<JobRequest>();
        //}
        [Key]
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string AspNetUserId { get; set; }
        //[ForeignKey("AspNetUserId")]
        //public AppUser ApplicationUser { get; set; }
        public int? AgencyId { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public string GenderDesc
        {
            get
            {
                if (Gender != default(Gender))
                {
                    return Gender.GetDescription();
                }
                else
                {
                    return "Male";
                }
            }
        }
        //[Required]
        //public int? Age { get; set; }
        [Required]
        public int? ExperienceInYears { get; set; }
        public int? ExperienceInMonths { get; set; }

        public string IdProofDoc { get; set; }
        public string IdProofDocDesc { get; set; }

        public bool ProfileVerified { get; set; }
        [Required]
        public StaffType StaffType { get; set; }
        public string StaffTypeDesc { get; set; }
        [Required]
        public DateTime Disponibility { get; set; }

        public int? CountryId { get; set; }
        public string Country { get; set; }
        [Required]
        public int? CityId { get; set; }
        public string City { get; set; }
        [Required]
        public int? DistrictId { get; set; }
        public string District { get; set; }
        [Required]
        public SalaryType SalaryType { get; set; }
        public string SalaryTypeDesc { get; set; }
        public string SalaryTypeOtherDesc { get; set; }

        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }

        [Required]
        public decimal ExpectedMinSalary { get; set; }
        [Required]
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

        public string AdditionalDescription { get; set; }
        public bool PublishProfile { get; set; }

        public List<JobTaskViewModel> JobTasks { get; set; }

        public List<SelectedJobTask> SelectedJobTasks { get; set; }
        public int JobId { get; set; }

        //public List<JobRequest> JobRequests { get; set; }

        public List<HttpPostedFileBase> JobRequestSkillPics { get; set; }

        public HttpPostedFileBase JobRequestSkillPic1 { get; set; }
        public HttpPostedFileBase JobRequestSkillPic2 { get; set; }
        public HttpPostedFileBase JobRequestSkillPic3 { get; set; }

        public string JobRequestSkillPic1Base64 { get; set; }
        public string JobRequestSkillPic2Base64 { get; set; }
        public string JobRequestSkillPic3Base64 { get; set; }
    }

    public class EmployerJobOfferViewModel
    {
        //public CandidateProfileViewModel()
        //{
        //    JobRequests = new List<JobRequest>();
        //}
        [Key]
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string AspNetUserId { get; set; }
        //[ForeignKey("AspNetUserId")]
        //public AppUser ApplicationUser { get; set; }
        public int? AgencyId { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public string GenderDesc
        {
            get
            {
                if (Gender != default(Gender))
                {
                    return Gender.GetDescription();
                }
                else
                {
                    return "Male";
                }
            }
        }
       
        public int? Age { get; set; }
        [Required]
        public int MinAge { get; set; }
        [Required]
        public int MaxAge { get; set; }
        [Required]
        public int? ExperienceInYears { get; set; }
        //[Required]
        public int? ExperienceInMonths { get; set; }

        public string IdProofDoc { get; set; }
        public string IdProofDocDesc { get; set; }

        public bool ProfileVerified { get; set; }
        public StaffType StaffType { get; set; }
        public string StaffTypeDesc { get; set; }
        [Required]
        public DateTime Disponibility { get; set; }

        public int? CountryId { get; set; }
        public string Country { get; set; }

        [Required]
        public int? CityId { get; set; }
        public string City { get; set; }

        [Required]
        public int? DistrictId { get; set; }
        public string District { get; set; }

        [Required]
        public SalaryType SalaryType { get; set; }
        public string SalaryTypeDesc { get; set; }
        [RequiredIf("SalaryType", SalaryType.PriceOfService)]
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

        public string AdditionalDescription { get; set; }
        public bool PublishProfile { get; set; }

        public List<JobTaskViewModel> JobTasks { get; set; }

        public List<SelectedJobTask> SelectedJobTasks { get; set; }
        public int JobId { get; set; }

        //public List<JobRequest> JobRequests { get; set; }
    }

    public class JobTaskViewModel
    {
        [Key]
        public int Id { get; set; }
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
        public virtual ICollection<JobTaskViewModel> SubTasks { get; set; }
        public bool Selected { get; set; }
        public string Note { get; set; }
    }

    public class SelectedJobTask
    {
        public int SelectedJobTaskId { get; set; }
        public string SelectedJobTaskNote { get; set; }
    }
}