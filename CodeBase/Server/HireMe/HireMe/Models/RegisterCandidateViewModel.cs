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
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
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

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

        [Required(ErrorMessage = "You must provide a valid phone number")]
        //[Display(Name = "Contact Number")]
        //[DataType(DataType.PhoneNumber)]
        //[Phone()]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        //[Required]
        public string CountryCode { get; set; }


        public HttpPostedFileBase profile_pic { get; set; }
        public HttpPostedFileBase id_proof { get; set; }

        [Required]
        public int? CountryId { get; set; }
        [NotMapped]
        public string Country { get; set; }

        [Required]
        public int? CityId { get; set; }
        [NotMapped]
        public string City { get; set; }

        [Required]
        public int? DistrictId { get; set; }
        [NotMapped]
        public string District { get; set; }
    }
}