using HireMe.Hubs;
using HireMe.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HireMe.Utility
{
    public enum TypeOfNotification
    {
        CandidateRegistration = 0,
        Admin_CandidateRegistration = 1,
        AgencyRegistration = 2,
        Admin_AgencyRegistration = 3,
        ResetPassword = 4,
        NotRequired = 99

    }
    public static class NotificationFramework
    {
        public static async Task SendNotification(string senderId, string receiverId, string subject, string content, TypeOfNotification NotificationType, bool sendAsEmail)
        {

            await Task.Factory.StartNew(() =>
            {
                using (var db = new ApplicationDbContext())
                {
                    // if senderId is "" then it's admin so set it : TO DO
                    var notification = new JobTekNotification { SenderId = senderId, ReceiverId = receiverId, Subject = subject, Content = content, CreatedDate = DateTime.Now, SeenByReceiver = false };
                    db.Notifications.Add(notification);
                    db.SaveChangesAsync();

                    var hubContext = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
                    //hubContext.Clients.Client("").addNewMessageToPage(chat.Name, chat.Message);
                    var user = db.Users.Find(receiverId);
                    if (user == null)
                    {
                        //hubContext.Clients.Caller.showErrorMessage("Could not find that user.");
                    }
                    else
                    {
                        db.Entry(user)
                            .Collection(u => u.SignalRConnections)
                            .Query()
                            .Where(c => c.Connected)
                            .Load();

                        if (user.SignalRConnections == null)
                        {
                            //hubContext.Clients.Caller.showErrorMessage("The user is no longer connected.");
                        }
                        else
                        {
                            foreach (var connection in user.SignalRConnections)
                            {
                                hubContext.Clients.Client(connection.ConnectionId)
                                    .showNotification(subject, content);
                            }
                        }
                    }

                    if (sendAsEmail)
                    {
                        var emailTemplate = db.EmailTemplate.Where(p => p.EmailType == (int)NotificationType).FirstOrDefault();
                        using (SmtpClient client = new SmtpClient())
                        {
                            try
                            {
                                client.Port = int.Parse(ConfigurationManager.AppSettings["EmailPort"]);
                                client.Host = ConfigurationManager.AppSettings["EmailHost"];
                                client.EnableSsl = true;
                                client.Timeout = 10000;
                                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                                client.UseDefaultCredentials = false;

                                var reciever = db.Users.Find(receiverId);

                                if (reciever != null)
                                {
                                    client.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["FromMailUserName"], ConfigurationManager.AppSettings["FromMailPassword"]);

                                    MailMessage mail = new MailMessage(ConfigurationManager.AppSettings["FromMailUserName"], reciever.Email);
                                    mail.From = new MailAddress(ConfigurationManager.AppSettings["FromMailUserName"]);

                                    mail.Subject = emailTemplate.EmailSubject;
                                    mail.Body = emailTemplate.EmailBody;
                                    mail.IsBodyHtml = true;
                                    mail.BodyEncoding = Encoding.UTF8;
                                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                                    client.Send(mail);
                                }
                            }
                            catch (Exception ex)
                            {
                                // ignored
                            }
                        }
                    }
                }



                // now if the user has chosen sendAsEmail to true -- then prepare the mail and send it
                //MailMessage mail = new MailMessage("you@yourcompany.com", "user@hotmail.com");


            });
        }
    }
}