using HireMe.Hubs;
using HireMe.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HireMe.Utility
{
    public static class NotificationFramework
    {
        public static async Task SendNotification(string senderId, string receiverId, string subject, string content, int category = 0, bool sendAsEmail = true)
        {

            await Task.Factory.StartNew(() =>
            {
                using (var db = new ApplicationDbContext())
                {
                    // if senderId is "" then it's admin so set it : TO DO
                    var notification = new JobTekNotification { SenderId = senderId, ReceiverId = receiverId, Subject = subject, Content = content, CreatedDate = DateTime.Now, SeenByReceiver = false };
                    if (string.IsNullOrWhiteSpace(senderId))
                    {
                        var admin = db.Users.FirstOrDefault(p => p.UserName == "admin1@gmail.com"); // TO DO: Need to store this in a config file
                        notification.SenderId = admin.Id;
                    }
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
                            .Where(c => c.Connected == true)
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

                   
                }

               

                // now if the user has chosen sendAsEmail to true -- then prepare the mail and send it
                //MailMessage mail = new MailMessage("you@yourcompany.com", "user@hotmail.com");

                //using (SmtpClient client = new SmtpClient())
                //{
                //    try
                //    {
                //        //client.Port = 25;
                //        //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //        //client.UseDefaultCredentials = false;
                //        //client.Host = "smtp.gmail.com";
                //        //mail.Subject = "this is a test email.";
                //        //mail.Body = "this is my test email body";
                //        //client.Send(mail);


                //        // SmtpClient client = new SmtpClient();
                //        client.Port = 587;
                //        client.Host = "smtp.gmail.com";
                //        client.EnableSsl = true;
                //        client.Timeout = 10000;
                //        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //        client.UseDefaultCredentials = false;
                //        client.Credentials = new System.Net.NetworkCredential("user@gmail.com", "password");

                //        MailMessage mail = new MailMessage("donotreply@domain.com", "sendtomyemail@domain.co.uk");
                //        mail.Subject = subject;
                //        mail.Body = content;
                //        mail.IsBodyHtml = true;
                //        mail.BodyEncoding = UTF8Encoding.UTF8;
                //        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                //        client.SendMailAsync(mail);
                //    }
                //    catch (Exception ex)
                //    {

                //    }
                //}
            });
        }
    }
}