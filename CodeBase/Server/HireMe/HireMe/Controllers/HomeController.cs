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
            string Name = contact.Name;
            string Email = contact.Email;
            string Message = contact.Message;

            ViewBag.Message = "";

            using (SmtpClient client = new SmtpClient())
            {
                try
                {
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;


                    client.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["FromMailUserName"], ConfigurationManager.AppSettings["FromMailPassword"]);

                    MailMessage mail = new MailMessage(Email, ConfigurationManager.AppSettings["FromMailUserName"]);
                    mail.Subject = "Contactus - JobTek";
                    mail.Body = "Dear Administrator,<br/>Please find the message below from " + Name + ".<br/><br/>" + Message;
                    mail.IsBodyHtml = true;
                    mail.BodyEncoding = UTF8Encoding.UTF8;
                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    client.Send(mail);
                    ViewBag.Message = "Merci de rester en contact. Nous reviendrons vers vous au plus tôt.";

                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Désolé pour le dérangement, veuillez réessayer plus tard.";
                }

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