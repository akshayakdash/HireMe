using HireMe.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HireMe.Models
{
    //public class RegisterCandidateViewModel
    //{
    //    [Required]
    //    [EmailAddress]
    //    [Display(Name = "Email")]
    //    public string Email { get; set; }

    //    [Required]
    //    [Display(Name = "First Name")]
    //    public string FirstName { get; set; }

    //    [Display(Name = "Last Name")]
    //    public string LastName { get; set; }

    //    [Display(Name = "Address")]
    //    public string Address { get; set; }

    //    [Required(ErrorMessage = "You must provide a phone number")]
    //    [Display(Name = "Contact Number")]
    //    [DataType(DataType.PhoneNumber)]
    //    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    //    public string PhoneNumber { get; set; }

    //    public HttpPostedFileBase profile_pic { get; set; }
    //    public HttpPostedFileBase id_proof { get; set; }
    //}

    public class RegisterCandidateViewModel
    {
        [Required(ErrorMessage = "Moyens entrez l'e-mail.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Moyens entrez prénom.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Moyens entrez Nom.")]
        public string LastName { get; set; }

        //[Required]
        public int Age
        {
            get
            {
                if (DOB != null && DOB != default(DateTime) && DOB <= DateTime.Today)
                {
                    // Save today's date.
                    var today = DateTime.Today;
                    // Calculate the age.
                    var age = today.Year - DOB.Year;
                    // Go back to the year the person was born in case of a leap year
                    if (DOB > today.AddYears(-age)) age--;
                    return age;
                }
                else
                {
                    return 0;
                }
            }
        }

        [Required(ErrorMessage = "Veuillez entrer votre date de naissance.")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Veuillez choisir le sexe.")]
        public Gender Gender { get; set; }

        [Display(Name = "Address")]
        //[Required]
        public string Address { get; set; }

        [Required(ErrorMessage = "Vous devez fournir un numéro de téléphone valide.")]
        //[Display(Name = "Contact Number")]
        //[DataType(DataType.PhoneNumber)]
        //[Phone()]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        //[Required]
        public string CountryCode { get; set; }


        public HttpPostedFileBase profile_pic { get; set; }
        public HttpPostedFileBase id_proof { get; set; }
        public HttpPostedFileBase id_proof1 { get; set; }

        // for mobile
        public string profile_pic_base64 { get; set; }
        public string id_proof_base64 { get; set; }
        public string id_proof1_base64 { get; set; }

        [Required(ErrorMessage = "S'il vous plaît sélectionnez votre pays.")]
        public int? CountryId { get; set; }
        [NotMapped]
        public string Country { get; set; }

        [Required(ErrorMessage = "S'il vous plaît sélectionnez votre ville.")]
        public int? CityId { get; set; }
        [NotMapped]
        public string City { get; set; }

        //[Required]
        public int? DistrictId { get; set; }
        [NotMapped]
        public string District { get; set; }
    }

    public class AgencyJobRequestViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int CandidateId { get; set; }
        public string AspNetUserId { get; set; }
        //[ForeignKey("AspNetUserId")]
        //public AppUser ApplicationUser { get; set; }
        public int? AgencyId { get; set; }
        [Required]
        public Gender Gender { get; set; }
        
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
        public List<int> CandidateIds { get; set; }
    }
}