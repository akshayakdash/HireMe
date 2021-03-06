﻿using HireMe.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Data.Entity;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using HireMe.Utility;
using System.Configuration;

namespace HireMe.Controllers.MobileApiControllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AccountsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private JsonMediaTypeFormatter jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

        public AccountsController()
        {
            var jSettings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            jsonFormatter.SerializerSettings = jSettings;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Accounts/Register")]
        public HttpResponseMessage Register(RegisterViewModel model)
        {
            var countries = db.Countries.ToList();
            var cities = db.Cities.ToList();
            var districts = db.Districts.ToList();
            model.SecurityQuestionId = 1;
            model.SecurityQuestionAnswer = "default";

            if (ModelState.IsValid)
            {

                // now check if it has file associated with it
                int age = 0;
                if (model.DOB != default(DateTime) && !(model.DOB > DateTime.Now))
                {
                    age = DateTime.Now.Year - model.DOB.Year;
                    if (DateTime.Now.DayOfYear < model.DOB.DayOfYear)
                        age = age - 1;
                }
                #region ProfileImageUpload
                string path = HttpContext.Current.Server.MapPath("~/Uploads/");
                string profileImagePath = string.Empty;
                if (model.profile_pic != null && model.profile_pic.ContentLength > 0)
                {

                    string theFileName = Path.GetFileNameWithoutExtension(model.profile_pic.FileName);
                    byte[] thePictureAsBytes = new byte[model.profile_pic.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.profile_pic.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.profile_pic.ContentLength);
                    }
                    profileImagePath = Convert.ToBase64String(thePictureAsBytes);
                }

                if (!string.IsNullOrWhiteSpace(model.profile_pic_base64))
                {

                    string fileName = Guid.NewGuid().ToString() + ".jpg";// + Base64Extensions.GetFileExtension(model.profile_pic_base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.profile_pic_base64));
                    profileImagePath = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                    //profileImagePath = model.profile_pic_base64;
                }
                #endregion

                #region Id Card
                string idProofImagePath = string.Empty;
                if (model.id_proof != null && model.id_proof.ContentLength > 0)
                {


                    string theFileName = Path.GetFileNameWithoutExtension(model.id_proof.FileName);
                    byte[] thePictureAsBytes = new byte[model.id_proof.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.id_proof.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.id_proof.ContentLength);
                    }
                    idProofImagePath = Convert.ToBase64String(thePictureAsBytes);
                }

                // store for mobile
                if (!string.IsNullOrWhiteSpace(model.id_proof_base64))
                {
                    //idProofImagePath = model.id_proof_base64;
                    string fileName = Guid.NewGuid().ToString() + ".jpg";// + Base64Extensions.GetFileExtension(model.id_proof_base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.id_proof_base64));
                    idProofImagePath = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                }

                string idProofImagePath1 = string.Empty;
                if (model.id_proof != null && model.id_proof.ContentLength > 0)
                {


                    string theFileName = Path.GetFileNameWithoutExtension(model.id_proof_back.FileName);
                    byte[] thePictureAsBytes = new byte[model.id_proof_back.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.id_proof_back.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.id_proof_back.ContentLength);
                    }
                    idProofImagePath1 = Convert.ToBase64String(thePictureAsBytes);
                }

                if (!string.IsNullOrWhiteSpace(model.id_proof_back_base64))
                {
                    //idProofImagePath1 = model.id_proof_back_base64;
                    string fileName = Guid.NewGuid().ToString() + ".jpg";// + Base64Extensions.GetFileExtension(model.id_proof_back_base64);
                    File.WriteAllBytes(path + fileName, Convert.FromBase64String(model.id_proof_back_base64));
                    idProofImagePath1 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                }
                #endregion
                string contactNumber = model.PhoneNumber.Replace("-", "");
                string phoneNumber = model.CountryCode + contactNumber;
                var securityQuestionAnswer = new ApplicationUserSecurityQuestionAnswer { SecurityQuestionId = model.SecurityQuestionId, Answer = model.SecurityQuestionAnswer };
                var user = new ApplicationUser { UserName = model.UserName, Email = model.Email, Address = model.Address, PhoneNumber = phoneNumber, FirstName = model.FirstName, LastName = model.LastName, ProfilePicUrl = profileImagePath, CountryId = model.CountryId, CityId = model.CityId, DistrictId = model.DistrictId };
                user.SecurityQuestionAnswers = new System.Collections.Generic.List<ApplicationUserSecurityQuestionAnswer> { securityQuestionAnswer };

                if (model.UserRoles.Contains("Agency"))
                {

                    var agency = new Agency { AgencyName = model.CompanyName, CompanyActivityDesc = model.CompanyActivity, AgencyWebsiteURL = model.WebSiteUrl, ManagerFirstName = model.ResponsibleName, AgencyLogo = profileImagePath, ManagerAge = age.ToString(), IdProofDoc = idProofImagePath, IdProofDoc1 = idProofImagePath1 };
                    agency.CreatedDate = DateTime.Now.ToString();
                    var cntry = countries.FirstOrDefault(p => p.CountryId == model.CountryId);
                    if (cntry != null)
                        agency.Country = cntry.CountryName;
                    var cty = cities.FirstOrDefault(p => p.CityId == model.CityId);
                    if (cty != null)
                        agency.City = cities.FirstOrDefault(p => p.CityId == model.CityId).CityName;
                    var dstrct = districts.FirstOrDefault(p => p.DistrictId == model.DistrictId);
                    if (dstrct != null)
                        agency.District = districts.FirstOrDefault(p => p.DistrictId == model.DistrictId).DistrictName;
                    agency.ProfileVerified = false;
                    user.Agencies = new System.Collections.Generic.List<Agency> { agency };
                }
                else if (model.UserRoles.Contains("Candidate"))
                {
                    var candidate = new Candidate { Gender = model.Gender, StaffType = StaffType.Independent, FirstName = model.FirstName, LastName = model.LastName, Address = model.Address, EmailId = model.Email, ContactNo = phoneNumber, CountryId = model.CountryId, CityId = model.CityId, DistrictId = model.DistrictId, ProfilePicUrl = profileImagePath, IdProofDoc = idProofImagePath, IdProofDoc1 = idProofImagePath1, Age = age };
                    candidate.CreatedDate = DateTime.Now.ToString();
                    candidate.ContactOption = "Email,Phone";// added on 6th Apr 2019
                    candidate.EmailId = model.Email;
                    var cntry = countries.FirstOrDefault(p => p.CountryId == candidate.CountryId);
                    if (cntry != null)
                        candidate.Country = cntry.CountryName;
                    var cty = cities.FirstOrDefault(p => p.CityId == candidate.CityId);
                    if (cty != null)
                        candidate.City = cities.FirstOrDefault(p => p.CityId == candidate.CityId).CityName;
                    var dstrct = districts.FirstOrDefault(p => p.DistrictId == candidate.DistrictId);
                    if (dstrct != null)
                        candidate.District = districts.FirstOrDefault(p => p.DistrictId == candidate.DistrictId).DistrictName;
                    user.Candidates = new List<Candidate> { candidate };
                }
                else if (model.UserRoles.Contains("Employer"))
                {
                    var employer = new Employer { Gender = model.Gender, FirstName = model.FirstName, LastName = model.LastName, ContactNo = phoneNumber, CountryId = model.CountryId, CityId = model.CityId, DistrictId = model.DistrictId, ProfilePicUrl = profileImagePath, IdProofDoc = idProofImagePath, IdProofDoc1 = idProofImagePath1, Age = age };
                    employer.CreatedDate = DateTime.Now.ToString();
                    employer.ContactOption = "Email,Phone"; // added on 6th Apr 2019
                    employer.EmailId = model.Email;
                    var cntry = countries.FirstOrDefault(p => p.CountryId == employer.CountryId);
                    if (cntry != null)
                        employer.Country = cntry.CountryName;
                    var cty = cities.FirstOrDefault(p => p.CityId == employer.CityId);
                    if (cty != null)
                        employer.City = cities.FirstOrDefault(p => p.CityId == employer.CityId).CityName;
                    var dstrct = districts.FirstOrDefault(p => p.DistrictId == employer.DistrictId);
                    if (dstrct != null)
                        employer.District = districts.FirstOrDefault(p => p.DistrictId == employer.DistrictId).DistrictName;
                    // need to add countryid, cityId and districtId to Employer entity
                    user.Employers = new List<Employer> { employer };
                }



                var UserManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
                // first check if there is any user already exists on this user name
                ApplicationUser userExists = UserManager.FindByNameAsync(model.UserName).Result;
                    if (userExists == null)
                        // then check if there is any user already exists on this email id
                        userExists = UserManager.FindByEmailAsync(model.Email).Result;
                if (userExists != null)
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "ERROR", Message = "User Name already taken." });

                var result = UserManager.CreateAsync(user, model.Password).Result;

                if (result.Succeeded)
                {
                    UserManager.AddToRoleAsync(user.Id, model.UserRoles);

                    // insert a welcome notification
                    db.Notifications.Add(new JobTekNotification { Content = "Welcome " + model.UserName + " to our Portal.", SenderId = "b6b5fc19-3222-4733-9d71-a4cf5d30ec98", ReceiverId = user.Id, CreatedDate = DateTime.Now });
                    db.SaveChanges();
                }
                
                return Request.CreateResponse(HttpStatusCode.Created, new { Status = "OK", Message = "Registration successful to the portal." });
            }
            else
            {
                // the code below should probably be refactored into a GetModelErrors
                // method on your BaseApiController or something like that

                var errors = new List<string>();
                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.OK, new { Status = "ERROR", Message = errors.First() });
            }
            //return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "ERROR", Message = "Internal Server Error." });

        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Accounts/Login")]
        public HttpResponseMessage Login(LoginViewModel model)
        {
            var user = db.Users.Include(p => p.Roles).FirstOrDefault(p => p.UserName == model.UserName || p.Email == model.UserName);
            var roleId = user?.Roles.ElementAt(0).RoleId;
            var role = db.Roles.FirstOrDefault(t => t.Id == roleId);
            int userId = 0;

            var SignInManager = HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();

            var res = SignInManager.PasswordSignInAsync(user.UserName.Trim(), model.Password, model.RememberMe, shouldLockout: false).Result;

            if (res == SignInStatus.Success)
            {
                if (role.Name == "Admin")
                {
                    userId = 1;
                }
                else if (role.Name == "Candidate")
                {
                    var candidate = db.Candidates.FirstOrDefault(p => p.AspNetUserId == user.Id);
                    if (candidate != null)
                    {
                        userId = candidate.CandidateId;
                    }
                }
                else if (role.Name == "Employer")
                {
                    var employer = db.Employers.FirstOrDefault(p => p.AspNetUserId == user.Id);
                    if (employer != null)
                    {
                        userId = employer.EmployerId;
                    }
                }
                else if (role.Name == "Agency")
                {
                    var agency = db.Agencies.FirstOrDefault(p => p.AspNetUserId == user.Id);
                    if (agency != null)
                    {
                        userId = agency.AgencyId;
                    }
                }

                var result = new { user.FirstName, Role = role.Name == "Candidate" ? "Employee" : role.Name, AspNetUserId = user.Id, user.UserName, user.Email, UserId = userId };
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "ERROR", Message = "Invalid Credentials." });
            }

        }

        [AllowAnonymous]
        [Route("api/Accounts/SecurityQuestions")]
        [HttpGet]
        public HttpResponseMessage SecurityQuestions()
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.SecurityQuestions.ToList());
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Accounts/ForgotPassword")]
        public HttpResponseMessage ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.FirstOrDefault(p => p.Email == model.Email);
                if (user == null)
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Error in forgot password." });
                }
                var newOtp = new Random().Next(99999, 999999);
                var UserManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
                string code = UserManager.GeneratePasswordResetTokenAsync(user.Id).Result;


                //first find the OTP repository to get the active OTP
                var existingActiveOTP = db.UserOtps.FirstOrDefault(p => p.AspNetUserId == user.Id);

                // if existing otp record found then update it else create a new entry
                if (existingActiveOTP != null)
                {
                    existingActiveOTP.OTP = newOtp.ToString();
                    existingActiveOTP.UniqueCode = code;
                    existingActiveOTP.IsActive = true;
                    existingActiveOTP.CreatedDate = DateTime.Now;
                    db.Entry(existingActiveOTP).Property(p => p.OTP).IsModified = true;
                    db.Entry(existingActiveOTP).Property(p => p.UniqueCode).IsModified = true;
                    db.Entry(existingActiveOTP).Property(p => p.IsActive).IsModified = true;
                    db.Entry(existingActiveOTP).Property(p => p.CreatedDate).IsModified = true;
                }
                else
                {
                    db.UserOtps.Add(new JOBTekOtp { AspNetUserId = user.Id, IsActive = true, OTP = newOtp.ToString(), UniqueCode = code, CreatedDate = DateTime.Now });
                }
                db.SaveChanges();

                // send email with the code
                NotificationFramework.SendNotification("", user.Id, "Reset password code", "Your unique code to reset password is : " + newOtp.ToString(), TypeOfNotification.ResetPassword, true);

                return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Your unique code to reset password is generated successfully and sent to your email.", Data = new { OTP = newOtp, Code = code } });

                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                // Send an email with this link
                // string code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
                // var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);		
                // await UserManager.SendEmailAsync(user.Id, "Reset Password", "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>");
                // return RedirectToAction("ForgotPasswordConfirmation", "Account");

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Invalid model." });
            }

            // If we got this far, something failed, redisplay form
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Accounts/PasswordReset")]
        public HttpResponseMessage ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Invalid model" });
            }
            var user = db.Users.FirstOrDefault(p => p.Email == model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist or is not confirmed
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Error in forgot password." });
            }

            // Need to check for the active OTP
            var existingOtp = db.UserOtps.FirstOrDefault(p => p.AspNetUserId == user.Id && p.OTP == model.Code);
            if (existingOtp == null)
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Invalid OTP" });

            var UserManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            //string code = UserManager.GeneratePasswordResetTokenAsync(user.Id).Result;
            var result = UserManager.ResetPasswordAsync(user.Id, existingOtp.UniqueCode, model.Password).Result;
            if (result.Succeeded)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { Status = "OK", Message = "Password reset successfully." });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = "Unable to reset the password." });
        }

    }
}
