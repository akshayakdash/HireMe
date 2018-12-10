using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using HireMe.Models;
using System.Data.Entity;

namespace HireMe.Hubs
{
    public class NotificationHub : Hub
    {
        //public void Hello()
        //{
        //    Clients.All.hello();
        //}


        public void SendNotification(string aspNetUserId, string message)
        {
            var name = Context.User.Identity.Name;
            using (var db = new ApplicationDbContext())
            {
                var user = db.Users.Find(aspNetUserId);
                if (user == null)
                {
                    Clients.Caller.showErrorMessage("Could not find that user.");
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
                        Clients.Caller.showErrorMessage("The user is no longer connected.");
                    }
                    else
                    {
                        foreach (var connection in user.SignalRConnections.Where(p => p.Connected))
                        {
                            Clients.Client(connection.ConnectionId)
                                .showNotification(name + ": " + message);
                        }
                    }
                }
            }
        }

        public override Task OnConnected()
        {
            var name = Context.User.Identity.Name;
            using (var db = ApplicationDbContext.Create())
            {
                var user = db.Users
                    .Include(u => u.SignalRConnections)
                    .SingleOrDefault(u => u.UserName == name);

                user.SignalRConnections.Add(new SignalRUserConnection
                {
                    ConnectionId = Context.ConnectionId,
                    UserAgent = Context.Request.Headers["User-Agent"],
                    Connected = true
                });
                db.SaveChanges();
            }
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            using (var db = new ApplicationDbContext())
            {
                var connection = db.SignalRConnections.FirstOrDefault(p => p.ConnectionId == Context.ConnectionId);
                if (connection != null)
                {
                    connection.Connected = false;
                    db.Entry(connection).Property(p => p.Connected).IsModified = true;
                    db.SaveChanges();
                }

                //// now we can remove the connections which are not active
                // we will run a batch job to clean the inactive connection to be in the safer side
                //var inActiveConnections = db.SignalRConnections.Where(p => !p.Connected);
                //lock (inActiveConnections)
                //{
                //    db.SignalRConnections.RemoveRange(inActiveConnections);
                //    db.SaveChanges();
                //}
            }
            return base.OnDisconnected(stopCalled);
        }
    }
}
