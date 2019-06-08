using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HireMe.Models;
using Microsoft.AspNet.Identity;

namespace HireMe.Controllers
{
    public class NotificationController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Notification
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var notifications = db.Notifications
                .Include(path => path.Sender)
                .Include(t => t.Receiver)
                .Where(p => p.ReceiverId == userId)
                .OrderByDescending(r => r.CreatedDate);
            return View(notifications.ToList());
        }

        // GET: Notification/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobTekNotification jobTekNotification = db.Notifications.Find(id);
            if (jobTekNotification == null)
            {
                return HttpNotFound();
            }
            return View(jobTekNotification);
        }

        // GET: Notification/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notification/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobTekNotificationId,Content,SenderId,ReceiverId,Category,CreatedDate,SeenByReceiver")] JobTekNotification jobTekNotification)
        {
            if (ModelState.IsValid)
            {
                db.Notifications.Add(jobTekNotification);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobTekNotification);
        }

        // GET: Notification/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobTekNotification jobTekNotification = db.Notifications.Find(id);
            if (jobTekNotification == null)
            {
                return HttpNotFound();
            }
            return View(jobTekNotification);
        }

        // POST: Notification/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobTekNotificationId,Content,SenderId,ReceiverId,Category,CreatedDate,SeenByReceiver")] JobTekNotification jobTekNotification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobTekNotification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobTekNotification);
        }

        // GET: Notification/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobTekNotification jobTekNotification = db.Notifications.Find(id);
            if (jobTekNotification == null)
            {
                return HttpNotFound();
            }
            return View(jobTekNotification);
        }

        // POST: Notification/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobTekNotification jobTekNotification = db.Notifications.Find(id);
            db.Notifications.Remove(jobTekNotification);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
