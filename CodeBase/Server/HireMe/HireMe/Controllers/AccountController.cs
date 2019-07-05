using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using HireMe.Models;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Configuration;

namespace HireMe.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationDbContext context;
        public AccountController()
        {
            context = new ApplicationDbContext();
        }

        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var result = await SignInManager.PasswordSignInAsync(model.UserName.Trim(), model.Password, model.RememberMe, shouldLockout: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
            }
        }

        //
        // GET: /Account/VerifyCode
        [AllowAnonymous]
        public async Task<ActionResult> VerifyCode(string provider, string returnUrl, bool rememberMe)
        {
            // Require that the user has already logged in via username/password or external login
            if (!await SignInManager.HasBeenVerifiedAsync())
            {
                return View("Error");
            }
            return View(new VerifyCodeViewModel { Provider = provider, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/VerifyCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyCode(VerifyCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // The following code protects for brute force attacks against the two factor codes. 
            // If a user enters incorrect codes for a specified amount of time then the user account 
            // will be locked out for a specified amount of time. 
            // You can configure the account lockout settings in IdentityConfig
            var result = await SignInManager.TwoFactorSignInAsync(model.Provider, model.Code, isPersistent: model.RememberMe, rememberBrowser: model.RememberBrowser);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(model.ReturnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid code.");
                    return View(model);
            }
        }

        [AllowAnonymous]
        public JsonResult CheckEmailExists(string emailId)
        {
            var emailIdExists =  context.Users.Count(p => p.Email == emailId) > 0 ? true : false;
            return Json(emailIdExists, JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register(string userRole = "")
        {
            ViewBag.SecurityQuestions = context.SecurityQuestions.ToList();
            if (!string.IsNullOrWhiteSpace(userRole))
            {
                ViewBag.UserRolesViewBag = new SelectList(context.Roles.Where(u => !u.Name.Contains("Admin"))
                                       .ToList(), "Name", "Name", userRole);
                ViewBag.SelectedRole = userRole;
            }
            else
            {
                ViewBag.UserRolesViewBag = new SelectList(context.Roles.Where(u => !u.Name.Contains("Admin"))
                                        .ToList(), "Name", "Name", "Candidate");
                ViewBag.SelectedRole = "Candidate";
            }
            var country = context.Countries.ToList();
            var city = context.Cities.ToList();
            var district = context.Districts.ToList();

            ViewBag.Country = country;
            ViewBag.City = city;
            ViewBag.District = district;

            ViewData["Country"] = context.Countries.Select(p => new SelectListItem { Text = p.CountryName, Value = p.CountryId.ToString() }).ToList();
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            //    var result = await UserManager.CreateAsync(user, model.Password);
            //    if (result.Succeeded)
            //    {
            //        await SignInManager.SignInAsync(user, isPersistent:false, rememberBrowser:false);

            //        // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
            //        // Send an email with this link
            //        // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
            //        // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
            //        // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

            //        return RedirectToAction("Index", "Home");
            //    }
            //    AddErrors(result);
            //}

            //// If we got this far, something failed, redisplay form
            //return View(model);
            var countries = context.Countries.ToList();
            var cities = context.Cities.ToList();
            var districts = context.Districts.ToList();
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
                string path = Server.MapPath("~/Uploads/");
                string profileImagePath = string.Empty;
                if (model.profile_pic != null && model.profile_pic.ContentLength > 0)
                {
                    ////Use Namespace called :  System.IO  
                    //string FileName = Path.GetFileNameWithoutExtension(model.profile_pic.FileName);

                    ////To Get File Extension  
                    //string FileExtension = Path.GetExtension(model.profile_pic.FileName);

                    ////Add Current Date To Attached File Name  
                    //FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + FileName.Trim() + FileExtension;

                    ////Get Upload path from Web.Config file AppSettings.  
                    ////string UploadPath = ConfigurationManager.AppSettings["UserImagePath"].ToString();

                    //var UploadPath = Path.Combine(Server.MapPath("~/App_Data/uploads"), FileName);
                    //imagePath = UploadPath;

                    ////Its Create complete path to store in server.  
                    ////model.ImagePath = UploadPath + FileName;

                    ////To copy and save file into server.  
                    //model.profile_pic.SaveAs(imagePath);

                    //string theFileName = Path.GetFileNameWithoutExtension(model.profile_pic.FileName);
                    //byte[] thePictureAsBytes = new byte[model.profile_pic.ContentLength];
                    //using (BinaryReader theReader = new BinaryReader(model.profile_pic.InputStream))
                    //{
                    //    thePictureAsBytes = theReader.ReadBytes(model.profile_pic.ContentLength);
                    //}
                    //profileImagePath = Convert.ToBase64String(thePictureAsBytes);

                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.profile_pic.FileName);
                    byte[] thePictureAsBytes = new byte[model.profile_pic.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.profile_pic.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.profile_pic.ContentLength);
                    }
                    System.IO.File.WriteAllBytes(path + fileName, thePictureAsBytes);
                    profileImagePath = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                }
                #endregion

                #region Id Card
                string idProofImagePath = string.Empty;
                if (model.id_proof != null && model.id_proof.ContentLength > 0)
                {

                    //string theFileName = Path.GetFileNameWithoutExtension(model.id_proof.FileName);
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.id_proof.FileName);
                    byte[] thePictureAsBytes = new byte[model.id_proof.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.id_proof.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.id_proof.ContentLength);
                    }
                    //idProofImagePath = Convert.ToBase64String(thePictureAsBytes);
                    System.IO.File.WriteAllBytes(path + fileName, thePictureAsBytes);
                    idProofImagePath = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                }

                string idProofImagePath1 = string.Empty;
                if (model.id_proof_back != null && model.id_proof_back.ContentLength > 0)
                {

                    string theFileName = Path.GetFileNameWithoutExtension(model.id_proof_back.FileName);
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.id_proof_back.FileName);
                    byte[] thePictureAsBytes = new byte[model.id_proof_back.ContentLength];
                    using (BinaryReader theReader = new BinaryReader(model.id_proof_back.InputStream))
                    {
                        thePictureAsBytes = theReader.ReadBytes(model.id_proof_back.ContentLength);
                    }
                    //idProofImagePath1 = Convert.ToBase64String(thePictureAsBytes);
                    System.IO.File.WriteAllBytes(path + fileName, thePictureAsBytes);
                    idProofImagePath1 = ConfigurationManager.AppSettings["ImageUploadBaseURL"] + "Uploads/" + fileName;
                }
                #endregion
                string contactNumber = model.PhoneNumber.Replace("-", "");
                string phoneNumber = model.CountryCode + contactNumber;
                //var securityQuestionAnswer = new ApplicationUserSecurityQuestionAnswer { SecurityQuestionId = model.SecurityQuestionId, Answer = model.SecurityQuestionAnswer };
                var user = new ApplicationUser { UserName = model.UserName, Email = model.Email, Address = model.Address, PhoneNumber = phoneNumber, FirstName = model.FirstName, LastName = model.LastName, ProfilePicUrl = profileImagePath, CountryId = model.CountryId, CityId = model.CityId, DistrictId = model.DistrictId };
                //user.SecurityQuestionAnswers = new System.Collections.Generic.List<ApplicationUserSecurityQuestionAnswer> { securityQuestionAnswer };

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

                var result = await UserManager.CreateAsync(user, model.Password);

                // now save the security question answer for the user
                //context.UserSecurityQuestionAnswers.Add(new ApplicationUserSecurityQuestionAnswer { AspNetUserId = user.Id, SecurityQuestionId = model.SecurityQuestionId, Answer = model.SecurityQuestionAnswer });

                // now based on role we need to make an entry to the corresponding tables Candidate, Employer and Agency

                //await context.SaveChangesAsync();



                if (result.Succeeded)
                {
                    //  await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771    
                    // Send an email with this link    
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);    
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);    
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");    
                    //Assign Role to user Here       
                    await this.UserManager.AddToRoleAsync(user.Id, model.UserRoles);

                    // insert a welcome notification
                    context.Notifications.Add(new JobTekNotification { Content = "Welcome " + model.UserName + " to our Portal.", SenderId = "b6b5fc19-3222-4733-9d71-a4cf5d30ec98", ReceiverId = user.Id, CreatedDate = DateTime.Now });
                    context.SaveChanges();
                    //Ends Here     
                    return RedirectToAction("Login", "Account");
                }
                //var country = context.Countries.ToList();
                //var city = context.Cities.ToList();
                //var district = context.Districts.ToList();
                ViewData["Country"] = context.Countries.Select(p => new SelectListItem { Text = p.CountryName, Value = p.CountryId.ToString() }).ToList();
                //ViewBag.Country = countries;
                ViewBag.City = cities;
                ViewBag.District = districts;
                AddErrors(result);
            }
            ViewBag.UserRolesViewBag = new SelectList(context.Roles.Where(u => !u.Name.Contains("Admin"))
                                         .ToList(), "Name", "Name");

            ViewData["Country"] = countries.Select(p => new SelectListItem { Text = p.CountryName, Value = p.CountryId.ToString() }).ToList();
            // If we got this far, something failed, redisplay form   
            ViewBag.SelectedRole = model.UserRoles;
            ViewBag.SecurityQuestions = context.SecurityQuestions.ToList().Take(3);
            //ViewBag.Country = countries;
            ViewBag.City = cities;
            ViewBag.District = districts;
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        //[AllowHtml]
        public JsonResult ValidateCaptcha(string gcaptchaResp)
        {
            string secret = System.Web.Configuration.WebConfigurationManager.AppSettings["recaptchaPrivateKey"];
            var client = new WebClient();
            var jsonResult = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secret, gcaptchaResp));
            return Json(JsonConvert.DeserializeObject<CaptchaResponse>(jsonResult.ToString()), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [AllowAnonymous]
        public JsonResult ValidateInfoBipPin(string pinId, string pin)
        {
            var vm = new { pin = pin };
            var infoBipPublicKey = System.Web.Configuration.WebConfigurationManager.AppSettings["infoBipPublicKey"];
            using (var client = new WebClient())
            {
                var dataString = JsonConvert.SerializeObject(vm);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                client.Headers.Add(HttpRequestHeader.Authorization, "App " + infoBipPublicKey);
                var res = client.UploadString(new Uri("https://gn9g6.api.infobip.com/2fa/1/pin/" + pinId + "/verify"), "POST", dataString);
                return Json(JsonConvert.DeserializeObject<InfoBipResponse>(res.ToString()), JsonRequestBehavior.AllowGet);
            }
            //return Json("", JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Account/ConfirmEmail
        [AllowAnonymous]
        public async Task<ActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var result = await UserManager.ConfirmEmailAsync(userId, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }

        //
        // GET: /Account/ForgotPassword
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        //
        // POST: /Account/ForgotPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByNameAsync(model.Email);
                if (user == null || !(await UserManager.IsEmailConfirmedAsync(user.Id)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return View("ForgotPasswordConfirmation");
                }

                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                // Send an email with this link
                // string code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
                // var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);		
                // await UserManager.SendEmailAsync(user.Id, "Reset Password", "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>");
                // return RedirectToAction("ForgotPasswordConfirmation", "Account");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ForgotPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        //
        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public ActionResult ResetPassword(string code)
        {
            return code == null ? View("Error") : View();
        }

        //
        // POST: /Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await UserManager.FindByNameAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction("ResetPasswordConfirmation", "Account");
            }
            var result = await UserManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("ResetPasswordConfirmation", "Account");
            }
            AddErrors(result);
            return View();
        }

        //
        // GET: /Account/ResetPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        //
        // POST: /Account/ExternalLogin
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            // Request a redirect to the external login provider
            return new ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl }));
        }

        //
        // GET: /Account/SendCode
        [AllowAnonymous]
        public async Task<ActionResult> SendCode(string returnUrl, bool rememberMe)
        {
            var userId = await SignInManager.GetVerifiedUserIdAsync();
            if (userId == null)
            {
                return View("Error");
            }
            var userFactors = await UserManager.GetValidTwoFactorProvidersAsync(userId);
            var factorOptions = userFactors.Select(purpose => new SelectListItem { Text = purpose, Value = purpose }).ToList();
            return View(new SendCodeViewModel { Providers = factorOptions, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/SendCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendCode(SendCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            // Generate the token and send it
            if (!await SignInManager.SendTwoFactorCodeAsync(model.SelectedProvider))
            {
                return View("Error");
            }
            return RedirectToAction("VerifyCode", new { Provider = model.SelectedProvider, ReturnUrl = model.ReturnUrl, RememberMe = model.RememberMe });
        }

        //
        // GET: /Account/ExternalLoginCallback
        [AllowAnonymous]
        public async Task<ActionResult> ExternalLoginCallback(string returnUrl)
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("Login");
            }

            // Sign in the user with this external login provider if the user already has a login
            var result = await SignInManager.ExternalSignInAsync(loginInfo, isPersistent: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = false });
                case SignInStatus.Failure:
                default:
                    // If the user does not have an account, then prompt the user to create an account
                    ViewBag.ReturnUrl = returnUrl;
                    ViewBag.LoginProvider = loginInfo.Login.LoginProvider;
                    return View("ExternalLoginConfirmation", new ExternalLoginConfirmationViewModel { Email = loginInfo.Email });
            }
        }

        //
        // POST: /Account/ExternalLoginConfirmation
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model, string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Manage");
            }

            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await AuthenticationManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return View("ExternalLoginFailure");
                }
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await UserManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await UserManager.AddLoginAsync(user.Id, info.Login);
                    if (result.Succeeded)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                        return RedirectToLocal(returnUrl);
                    }
                }
                AddErrors(result);
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/ExternalLoginFailure
        [AllowAnonymous]
        public ActionResult ExternalLoginFailure()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userManager != null)
                {
                    _userManager.Dispose();
                    _userManager = null;
                }

                if (_signInManager != null)
                {
                    _signInManager.Dispose();
                    _signInManager = null;
                }
            }

            base.Dispose(disposing);
        }

        [AllowAnonymous]
        [HttpGet]
        public JsonResult GetCities(int id)
        {

            List<SelectListItem> cities = new List<SelectListItem>();
            cities = context.Cities.Where(t => t.CountryId == id).Select(p => new SelectListItem { Text = p.CityName, Value = p.CityId.ToString() }).ToList();

            return Json(new SelectList(cities, "Value", "Text"), JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        [HttpGet]
        public JsonResult GetDistricts(int id)
        {

            List<SelectListItem> districts = new List<SelectListItem>();
            districts = context.Districts.Where(t => t.CityId == id).Select(p => new SelectListItem { Text = p.DistrictName, Value = p.DistrictId.ToString() }).ToList();

            return Json(new SelectList(districts, "Value", "Text"), JsonRequestBehavior.AllowGet);
        }

        #region Helpers
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Users");
        }

        internal class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }
        #endregion

    }

    public class CaptchaResponse
    {
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }
        [JsonProperty("error-codes")]
        public List<string> ErrorMessage
        {
            get;
            set;
        }
    }

    public class InfoBipResponse
    {
        [JsonProperty("pinId")]
        public string PinId { get; set; }
        [JsonProperty("msisdn")]
        public string Msisdn { get; set; }
        [JsonProperty("verified")]
        public bool Verified { get; set; }
        [JsonProperty("attemptsRemaining")]
        public int AttemptsRemaining { get; set; }
    }
}