using HireMe.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HireMe.Controllers
{
    [Authorize]
    public class UsersController : BaseController
    {
        private ApplicationDbContext context;

        public UsersController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Users
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ViewBag.Name = user.Name;

                ViewBag.displayMenu = "No";

                if (IsAdminUser())
                {
                    ViewBag.displayMenu = "Yes";
                }

                var usersWithRoles = (from usr in context.Users
                                      select new
                                      {
                                          UserId = usr.Id,
                                          Username = usr.UserName,
                                          Email = usr.Email,
                                          PhoneNumber = usr.PhoneNumber,
                                          Address = usr.Address,
                                          FirstName = usr.FirstName,
                                          LastName = usr.LastName,
                                          RoleNames = (from userRole in usr.Roles
                                                       join role in context.Roles on userRole.RoleId
                                                       equals role.Id
                                                       select role.Name).ToList()
                                      }).ToList().Select(p => new UserInfo()
                                      {
                                          UserId = p.UserId,
                                          Username = p.Username,
                                          FirstName = p.FirstName,
                                          LastName = p.LastName,
                                          Address = p.Address,
                                          PhoneNumber = p.PhoneNumber,
                                          Email = p.Email,
                                          Role = string.Join(",", p.RoleNames)
                                      });
                return View(usersWithRoles);
            }
            else
            {
                ViewBag.Name = "Not Logged IN";
            }
            
            return View();
        }

        public Boolean IsAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s != null && s.Count > 0 && s[0].ToString() == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}