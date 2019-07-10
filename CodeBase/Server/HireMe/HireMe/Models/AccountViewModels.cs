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

        [Required(ErrorMessage = "Nom d'utilisateur est nécessaire.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mot de passe est nécessaire.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Souviens-toi de moi?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "S'il vous plaît entrer Email.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Veuillez entrer votre nom d'utilisateur.")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "S'il vous plaît entrer Prénom.")]
        [Display(Name = "Prénom")]
        public string FirstName { get; set; }

        [Display(Name = "Nom")]
        [Required(ErrorMessage = "S'il vous plaît entrer Nom.")]
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

        [Required(ErrorMessage = "S'il vous plaît entrer la date de naissance.")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "S'il vous plaît sélectionner le sexe.")]
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
        [Required(ErrorMessage = "Vous devez fournir un numéro de téléphone valide.")]
        public string ConfirmPhoneNumber { get; set; }

        //[Required]
        public string CountryCode { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage = "Le mot de passe doit comporter 6 caractères et doit contenir" +
            "au moins une lettre majuscule, une lettre minuscule, un chiffre, un caractère " +
            "spécial (ne peut être que  # $ ^ + = ! * ( ) @ % &) " +
            "par exemple Pass@123")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Le mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "UserRoles")]
        public string UserRoles { get; set; }

        public HttpPostedFileBase profile_pic { get; set; }
        public HttpPostedFileBase id_proof { get; set; }
        public HttpPostedFileBase id_proof_back { get; set; }

        public string profile_pic_base64 { get; set; }
        public string id_proof_base64 { get; set; }
        public string id_proof_back_base64 { get; set; }

        
        //[Range(typeof(bool), "true", "true", ErrorMessage = "Veuillez accepter les termes et conditions.")]
        //[Display(Name = "J'accepte les termes et conditions")]
        public bool AgreeTermsAndConditions { get; set; }

        //[Required(ErrorMessage = "Please select the security question.")]
        public int SecurityQuestionId { get; set; }
        //[Required(ErrorMessage = "Please enter the security question's answer.")]
        public string SecurityQuestionAnswer { get; set; }

        [Required(ErrorMessage = "Veuillez sélectionner un pays.")]
        public int? CountryId { get; set; }
        [NotMapped]
        public string Country { get; set; }

        [Required(ErrorMessage = "Veuillez choisir une ville.")]
        public int? CityId { get; set; }
        [NotMapped]
        public string City { get; set; }

        //[Required]
        public int? DistrictId { get; set; }
        [NotMapped]
        public string District { get; set; }

        #region Agency Section
        [Display(Name = "Nom de la compagnie")]
        [RequiredIf("UserRoles", "Agency", ErrorMessage = "Le nom de l'entreprise est obligatoire.")]
        public string CompanyName { get; set; }

        [Display(Name = "Nom du responsable")]
        [RequiredIf("UserRoles", "Agency", ErrorMessage = "Le nom du responsable est requis.")]
        public string ResponsibleName { get; set; }

        [Display(Name = "URL du site")]
        [RequiredIf("UserRoles", "Agency", ErrorMessage = "L'URL du site est obligatoire.")]
        [DataType(DataType.Url)]
        public string WebSiteUrl { get; set; }

        [Display(Name = "Activités de l'entreprise")]
        [RequiredIf("UserRoles", "Agency", ErrorMessage = "Une description de l'activité de l'entreprise est requise.")]
        public string CompanyActivity { get; set; }
        #endregion
    }

    public class UpdateProfileViewModel
    {
        //[Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }



        //[Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        //[Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Contact Number")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }



        public HttpPostedFileBase profile_pic { get; set; }
        public HttpPostedFileBase id_proof { get; set; }
        public HttpPostedFileBase id_proof1 { get; set; }

        public string profile_pic_base64 { get; set; }
        public string id_proof_base64 { get; set; }
        public string id_proof1_base64 { get; set; }

        public int? CountryId { get; set; }


        public int? CityId { get; set; }


        public int? DistrictId { get; set; }


        public string[] ContactOption { get; set; }

        public bool ProfileVerified { get; set; }

        public int Age { get; set; }

        // TO Do: Agency Section TO Be added
    }

    public class UpdateProfilePictureViewModel
    {
        public string Profile_pic_base64 { get; set; }
    }

    public class UpdateIdCardViewModel
    {
        public string Id_Card_Front_base64 { get; set; }
        public string Id_Card_Back_base64 { get; set; }
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
