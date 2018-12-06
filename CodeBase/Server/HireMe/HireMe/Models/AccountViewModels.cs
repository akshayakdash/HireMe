using HireMe.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace HireMe.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        //[Required]
        //[Display(Name = "Email")]
        //[EmailAddress]
        //public string Email { get; set; }

        [Required(ErrorMessage = "User Name is required.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        //[Required]
        public int Age { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

        [Required(ErrorMessage = "You must provide a valid phone number")]
        //[Display(Name = "Contact Number")]
        [DataType(DataType.PhoneNumber)]
        //[Phone()]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "UserRoles")]
        public string UserRoles { get; set; }

        public HttpPostedFileBase profile_pic { get; set; }
        public HttpPostedFileBase id_proof { get; set; }

        [Required(ErrorMessage = "Please agree the terms and conditions")]
        [Display(Name = "Agree Terms and Conditions")]
        public bool AgreeTermsAndConditions { get; set; }

        [Required(ErrorMessage = "Please select the security question.")]
        public int SecurityQuestionId { get; set; }
        [Required(ErrorMessage = "Please enter the security question's answer.")]
        public string SecurityQuestionAnswer { get; set; }

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

        #region Agency Section
        [Display(Name = "Company Name")]
        [RequiredIf("UserRoles", "Agency", ErrorMessage = "Comapny name is required")]
        public string CompanyName { get; set; }

        [Display(Name = "Responsible Name")]
        [RequiredIf("UserRoles", "Agency", ErrorMessage = "Responsible name is required")]
        public string ResponsibleName { get; set; }

        [Display(Name = "Website URL")]
        [RequiredIf("UserRoles", "Agency", ErrorMessage = "Website URL is required")]
        [DataType(DataType.Url)]
        public string WebSiteUrl { get; set; }

        [Display(Name = "Company Activities")]
        [RequiredIf("UserRoles", "Agency", ErrorMessage = "Company activity description is required")]
        public string CompanyActivity { get; set; }
        #endregion
    }

    public class UpdateProfileViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        

        public HttpPostedFileBase profile_pic { get; set; }
        public HttpPostedFileBase id_proof { get; set; }

        public int? CountryId { get; set; }
       

        public int? CityId { get; set; }
       

        public int? DistrictId { get; set; }
       

        public string ContactOption { get; set; }

        public bool ProfileVerified { get; set; }

        public int Age { get; set; }

        // TO Do: Agency Section TO Be added
    }

   

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
