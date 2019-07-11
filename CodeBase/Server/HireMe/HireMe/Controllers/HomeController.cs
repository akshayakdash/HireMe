using HireMe.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HireMe.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            createRolesandUsers();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contactus contact)
        {
            if (ModelState.IsValid)
            {
                string Name = contact.Name;
                string Email = contact.Email;
                string Message = contact.Message;

                ViewBag.Message = "";

                try
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    message.From = new MailAddress(ConfigurationManager.AppSettings["FromMailUserName"]);
                    message.To.Add(ConfigurationManager.AppSettings["FromMailUserName"]);
                    message.Subject = "Contactus - JobTek";
                    message.IsBodyHtml = true; //to make message body as html  
                    message.Body = "Cher administrateur,<br/>Veuillez trouver le message ci-dessous de " + Name + ".<br/><br/>" + Message + "<br/><br/>" + "S'il vous plaît voir les détails ci-dessous pour la communication future<br/><b>Name : " + Name + "<br/>Email : " + Email;

                    smtp.Port = int.Parse(ConfigurationManager.AppSettings["EmailPort"]);
                    smtp.Host = ConfigurationManager.AppSettings["EmailHost"];
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["FromMailUserName"], ConfigurationManager.AppSettings["FromMailPassword"]);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                }
                catch (Exception) { }

                
            }
                return View(contact);
        }
        public ActionResult FAQ()
        {
            return View();
        }

        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User     

            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin rool    
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                   

                var user = new ApplicationUser();
                user.UserName = "Admin";
                user.Email = "admin1@gmail.com";

                string userPWD = "Akshaya@123";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            //creating Creating Manager role
            if (!roleManager.RoleExists("Employer"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employer";
                roleManager.Create(role);

            }

            // creating Creating Employee role     
            if (!roleManager.RoleExists("Candidate"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Candidate";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Agency"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Agency";
                roleManager.Create(role);
            }


        }
        public ActionResult EmployerInfo()
        {
            return View();
        }
        public ActionResult CandidatInfo()
        {
            return View();
        }
        public ActionResult AgencyInfo()
        {
            return View();
        }
    }
}