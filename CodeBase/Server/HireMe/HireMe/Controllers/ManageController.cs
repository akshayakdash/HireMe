using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using HireMe.Models;
using System.IO;

namespace HireMe.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationDbContext context;

        public ManageController()
        {
            context = new ApplicationDbContext();
        }

        public ManageController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
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
        // GET: /Manage/Index
        public async Task<ActionResult> Index(ManageMessageId? message)
        {
            //ViewBag.StatusMessage =
            //    message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
            //    : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
            //    : message == ManageMessageId.SetTwoFactorSuccess ? "Your two-factor authentication provider has been set."
            //    : message == ManageMessageId.Error ? "An error has occurred."
            //    : message == ManageMessageId.AddPhoneSuccess ? "Your phone number was added."
            //    : message == ManageMessageId.RemovePhoneSuccess ? "Your phone number was removed."
            //    : "";

            //var userId = User.Identity.GetUserId();
            //var model = new IndexViewModel
            //{
            //    HasPassword = HasPassword(),
            //    PhoneNumber = await UserManager.GetPhoneNumberAsync(userId),
            //    TwoFactor = await UserManager.GetTwoFactorEnabledAsync(userId),
            //    Logins = await UserManager.GetLoginsAsync(userId),
            //    BrowserRemembered = await AuthenticationManager.TwoFactorBrowserRememberedAsync(userId)
            //};
            //return View(model);

            var user = context.Users.Find(User.Identity.GetUserId());


            // get the role of the user
            var roles = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims
                            .Where(c => c.Type == System.Security.Claims.ClaimTypes.Role)
                            .Select(c => c.Value);
            string role = roles.FirstOrDefault();

            var updateProfileViewModel = new UpdateProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Address = user.Address,
                CityId = user.CityId,
                CountryId = user.CountryId,
                DistrictId = user.DistrictId
            };

            if (role == "Candidate")
            {
                var candidate = context.Candidates.FirstOrDefault(p => p.AspNetUserId == user.Id);
                updateProfileViewModel.ContactOption = !string.IsNullOrWhiteSpace(candidate.ContactOption) ? candidate.ContactOption.Split(',') : new string[0];
                updateProfileViewModel.ProfileVerified = candidate.ProfileVerified;
                updateProfileViewModel.Age = candidate.Age.HasValue ? candidate.Age.Value : 0;
                ViewBag.IdProofDoc = candidate.IdProofDoc;

            }
            else if (role == "Employer")
            {
                var employer = context.Employers.FirstOrDefault(p => p.AspNetUserId == user.Id);
                updateProfileViewModel.ContactOption = !string.IsNullOrWhiteSpace(employer.ContactOption) ? employer.ContactOption.Split(',') : new string[0];
                updateProfileViewModel.ProfileVerified = employer.ProfileVerified;
                updateProfileViewModel.Age = employer.Age;
                ViewBag.IdProofDoc = employer.IdProofDoc;
            }
            else if (role == "Agency")
            {
                var agency = context.Agencies.FirstOrDefault(p => p.AspNetUserId == user.Id);
                //updateProfileViewModel.ContactOption = agency.ContactOption;
                updateProfileViewModel.ProfileVerified = agency.ProfileVerified;
                // updateProfileViewModel.Age = int.Parse(agency.ManagerAge);
                ViewBag.IdProofDoc = agency.AgencyLogo;
            }

            var country = context.Countries.ToList();
            var city = context.Cities.ToList();
            var district = context.Districts.ToList();

            ViewBag.Country = country;
            ViewBag.City = city;
            ViewBag.District = district;
            ViewBag.ProfilePicUrl = user.ProfilePicUrl;

            return View(updateProfileViewModel);
        }

        [HttpPost]
        public ActionResult UpdateProfile(UpdateProfileViewModel model)
        {
            // TODO : need to write the logic for updating the profile

            if (ModelState.IsValid)
            {
                var user = context.Users.Find(User.Identity.GetUserId());

                // get the role of the user
                var roles = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims
                                .Where(c => c.Type == System.Security.Claims.ClaimTypes.Role)
                                .Select(c => c.Value);
                string role = roles.FirstOrDefault();

                //var registrationViewModel = new UpdateProfileViewModel
                //{
                //    FirstName = user.FirstName,
                //    LastName = user.LastName,
                //    PhoneNumber = user.PhoneNumber,
                //    Email = user.Email,
                //    Address = user.Address,
                //    CityId = user.CityId,
                //    CountryId = user.CountryId,
                //    DistrictId = user.DistrictId
                //};

               // user.FirstName = model.FirstName;
               // user.LastName = model.LastName;
                user.PhoneNumber = model.PhoneNumber;
                user.Email = model.Email;
                user.Address = model.Address;
                user.CityId = model.CityId;
                user.CountryId = model.CountryId;
                user.DistrictId = model.DistrictId;

                context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                var userId = User.Identity.GetUserId();
                // now if role is candidate
                if (role == "Candidate")
                {
                    var candidate = context.Candidates.FirstOrDefault(p => p.AspNetUserId == userId);
                    if (candidate != null)
                    {
                       // candidate.FirstName = model.FirstName;
                       // candidate.LastName = model.LastName;
                       // candidate.Age = model.Age;
                        candidate.ContactOption = model.ContactOption != null && model.ContactOption.Length > 0 ? string.Join(",", model.ContactOption) : "";
                        candidate.ContactNo = model.PhoneNumber;
                        candidate.EmailId = model.Email;
                        candidate.Address = model.Address;
                        candidate.CountryId = model.CountryId;
                        candidate.CityId = model.CityId;
                        candidate.DistrictId = model.DistrictId;
                        context.Entry(candidate).State = System.Data.Entity.EntityState.Modified;
                    }

                }
                else if (role == "Employer")
                {
                    var employer = context.Employers.FirstOrDefault(p => p.AspNetUserId == userId);
                    if (employer != null)
                    {
                      //  employer.FirstName = model.FirstName;
                       // employer.LastName = model.LastName;
                       // employer.Age = model.Age;
                        employer.ContactOption = model.ContactOption != null && model.ContactOption.Length > 0 ? string.Join(",", model.ContactOption) : "";
                        employer.ContactNo = model.PhoneNumber;
                        employer.EmailId = model.Email;
                        employer.Address = model.Address;
                        employer.CountryId = model.CountryId;
                        employer.CityId = model.CityId;
                        employer.DistrictId = model.DistrictId;
                        context.Entry(employer).State = System.Data.Entity.EntityState.Modified;
                    }
                }

                context.SaveChanges();
            }

            var user1 = context.Users.Find(User.Identity.GetUserId());
            var registrationViewModel = new UpdateProfileViewModel
            {
                FirstName = user1.FirstName,
                LastName = user1.LastName,
                PhoneNumber = user1.PhoneNumber,
                Email = user1.Email,
                Address = user1.Address,
                CityId = user1.CityId,
                CountryId = user1.CountryId,
                DistrictId = user1.DistrictId
            };

            //var country = context.Countries.ToList();
            //var city = context.Cities.ToList();
            //var district = context.Districts.ToList();

            //ViewBag.Country = country;
            //ViewBag.City = city;
            //ViewBag.District = district;
            //ViewBag.ProfilePicUrl = user1.ProfilePicUrl;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdateProfilePic()
        {
            #region ProfileImageUpload
            string profileImagePath = string.Empty;
            try
            {
                if (Request.Files != null && Request.Files.Count > 0)
                {
                    ////To copy and save file into server.  
                    //model.profile_pic.SaveAs(imagePath);
                    var file = Request.Files[0];
                    if (file != null && file.ContentLength > 0)
                    {
                        string theFileName = Path.GetFileNameWithoutExtension(file.FileName);
                        byte[] thePictureAsBytes = new byte[file.ContentLength];
                        using (BinaryReader theReader = new BinaryReader(file.InputStream))
                        {
                            thePictureAsBytes = theReader.ReadBytes(file.ContentLength);
                        }
                        profileImagePath = Convert.ToBase64String(thePictureAsBytes);
                    }
                }
                var userId = User.Identity.GetUserId();
                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                // now get the application user 
                var user = context.Users.Find(userId);
                user.ProfilePicUrl = profileImagePath;
                context.Entry(user).Property(p => p.ProfilePicUrl).IsModified = true;
                if (userManager.IsInRole(userId, "Candidate"))
                {
                    var existingCandidate = context.Candidates.FirstOrDefault(p => p.AspNetUserId == userId);
                    existingCandidate.ProfilePicUrl = profileImagePath;
                    context.Entry(existingCandidate).Property(p => p.ProfilePicUrl).IsModified = true;
                }
                if (userManager.IsInRole(userId, "Employer"))
                {
                    var existingEmployer = context.Employers.FirstOrDefault(p => p.AspNetUserId == userId);
                    existingEmployer.ProfilePicUrl = profileImagePath;
                    context.Entry(existingEmployer).Property(p => p.ProfilePicUrl).IsModified = true;
                }
                context.SaveChanges();

            }
            finally
            {

            }
            return Json("Success", JsonRequestBehavior.AllowGet);
            #endregion
        }

        [HttpPost]
        public ActionResult UpdateIdCard()
        {
            #region ProfileImageUpload
            string profileImagePath = string.Empty;
            try
            {
                if (Request.Files != null && Request.Files.Count > 0)
                {
                    ////To copy and save file into server.  
                    //model.profile_pic.SaveAs(imagePath);
                    var file = Request.Files[0];
                    if (file != null && file.ContentLength > 0)
                    {
                        string theFileName = Path.GetFileNameWithoutExtension(file.FileName);
                        byte[] thePictureAsBytes = new byte[file.ContentLength];
                        using (BinaryReader theReader = new BinaryReader(file.InputStream))
                        {
                            thePictureAsBytes = theReader.ReadBytes(file.ContentLength);
                        }
                        profileImagePath = Convert.ToBase64String(thePictureAsBytes);
                    }
                }
                var userId = User.Identity.GetUserId();
                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                if (userManager.IsInRole(userId, "Candidate"))
                {
                    var existingCandidate = context.Candidates.FirstOrDefault(p => p.AspNetUserId == userId);
                    existingCandidate.IdProofDoc = profileImagePath;
                    context.Entry(existingCandidate).Property(p => p.IdProofDoc).IsModified = true;
                }
                if (userManager.IsInRole(userId, "Employer"))
                {
                    var existingEmployer = context.Employers.FirstOrDefault(p => p.AspNetUserId == userId);
                    existingEmployer.IdProofDoc = profileImagePath;
                    context.Entry(existingEmployer).Property(p => p.IdProofDoc).IsModified = true;
                }
                context.SaveChanges();

            }
            finally
            {

            }
            return Json("Success", JsonRequestBehavior.AllowGet);
            #endregion
        }

        //
        // POST: /Manage/RemoveLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemoveLogin(string loginProvider, string providerKey)
        {
            ManageMessageId? message;
            var result = await UserManager.RemoveLoginAsync(User.Identity.GetUserId(), new UserLoginInfo(loginProvider, providerKey));
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                message = ManageMessageId.RemoveLoginSuccess;
            }
            else
            {
                message = ManageMessageId.Error;
            }
            return RedirectToAction("ManageLogins", new { Message = message });
        }

        //
        // GET: /Manage/AddPhoneNumber
        public ActionResult AddPhoneNumber()
        {
            return View();
        }

        //
        // POST: /Manage/AddPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddPhoneNumber(AddPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // Generate the token and send it
            var code = await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), model.Number);
            if (UserManager.SmsService != null)
            {
                var message = new IdentityMessage
                {
                    Destination = model.Number,
                    Body = "Your security code is: " + code
                };
                await UserManager.SmsService.SendAsync(message);
            }
            return RedirectToAction("VerifyPhoneNumber", new { PhoneNumber = model.Number });
        }

        //
        // POST: /Manage/EnableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EnableTwoFactorAuthentication()
        {
            await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), true);
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", "Manage");
        }

        //
        // POST: /Manage/DisableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DisableTwoFactorAuthentication()
        {
            await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), false);
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", "Manage");
        }

        //
        // GET: /Manage/VerifyPhoneNumber
        public async Task<ActionResult> VerifyPhoneNumber(string phoneNumber)
        {
            var code = await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), phoneNumber);
            // Send an SMS through the SMS provider to verify the phone number
            return phoneNumber == null ? View("Error") : View(new VerifyPhoneNumberViewModel { PhoneNumber = phoneNumber });
        }

        //
        // POST: /Manage/VerifyPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyPhoneNumber(VerifyPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await UserManager.ChangePhoneNumberAsync(User.Identity.GetUserId(), model.PhoneNumber, model.Code);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                return RedirectToAction("Index", new { Message = ManageMessageId.AddPhoneSuccess });
            }
            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "Failed to verify phone");
            return View(model);
        }

        //
        // POST: /Manage/RemovePhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemovePhoneNumber()
        {
            var result = await UserManager.SetPhoneNumberAsync(User.Identity.GetUserId(), null);
            if (!result.Succeeded)
            {
                return RedirectToAction("Index", new { Message = ManageMessageId.Error });
            }
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", new { Message = ManageMessageId.RemovePhoneSuccess });
        }

        //
        // GET: /Manage/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Manage/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                return RedirectToAction("Index", new { Message = ManageMessageId.ChangePasswordSuccess });
            }
            AddErrors(result);
            return View(model);
        }

        //
        // GET: /Manage/SetPassword
        public ActionResult SetPassword()
        {
            return View();
        }

        //
        // POST: /Manage/SetPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SetPassword(SetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await UserManager.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword);
                if (result.Succeeded)
                {
                    var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                    if (user != null)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                    }
                    return RedirectToAction("Index", new { Message = ManageMessageId.SetPasswordSuccess });
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Manage/ManageLogins
        public async Task<ActionResult> ManageLogins(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
                : message == ManageMessageId.Error ? "An error has occurred."
                : "";
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user == null)
            {
                return View("Error");
            }
            var userLogins = await UserManager.GetLoginsAsync(User.Identity.GetUserId());
            var otherLogins = AuthenticationManager.GetExternalAuthenticationTypes().Where(auth => userLogins.All(ul => auth.AuthenticationType != ul.LoginProvider)).ToList();
            ViewBag.ShowRemoveButton = user.PasswordHash != null || userLogins.Count > 1;
            return View(new ManageLoginsViewModel
            {
                CurrentLogins = userLogins,
                OtherLogins = otherLogins
            });
        }

        //
        // POST: /Manage/LinkLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LinkLogin(string provider)
        {
            // Request a redirect to the external login provider to link a login for the current user
            return new AccountController.ChallengeResult(provider, Url.Action("LinkLoginCallback", "Manage"), User.Identity.GetUserId());
        }

        //
        // GET: /Manage/LinkLoginCallback
        public async Task<ActionResult> LinkLoginCallback()
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync(XsrfKey, User.Identity.GetUserId());
            if (loginInfo == null)
            {
                return RedirectToAction("ManageLogins", new { Message = ManageMessageId.Error });
            }
            var result = await UserManager.AddLoginAsync(User.Identity.GetUserId(), loginInfo.Login);
            return result.Succeeded ? RedirectToAction("ManageLogins") : RedirectToAction("ManageLogins", new { Message = ManageMessageId.Error });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _userManager != null)
            {
                _userManager.Dispose();
                _userManager = null;
            }

            base.Dispose(disposing);
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

        private bool HasPassword()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PasswordHash != null;
            }
            return false;
        }

        private bool HasPhoneNumber()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PhoneNumber != null;
            }
            return false;
        }

        public enum ManageMessageId
        {
            AddPhoneSuccess,
            ChangePasswordSuccess,
            SetTwoFactorSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            RemovePhoneSuccess,
            Error
        }

        #endregion
    }
}