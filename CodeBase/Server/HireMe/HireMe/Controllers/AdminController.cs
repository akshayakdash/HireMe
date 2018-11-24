using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HireMe.Models;

namespace HireMe.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public ActionResult Agencies()
        {
            return View(db.Agencies.OrderByDescending(p => p.AgencyId).ToList());
        }

        public ActionResult ActivateAgency(int id)
        {
            // first get the agency by Id
            var agency = db.Agencies.Find(id);
            // if agency is null throw an exception
            if (agency == null)
                throw new Exception("Agency Not Found.");
            agency.ProfileVerified = true;
            db.SaveChanges();
            // else return success message
            return Json("Agency profile Verified Successfully", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Candidates()
        {
            var candidates = db.Candidates.Include(p => p.ApplicationUser).OrderByDescending(p => p.CandidateId).ToList();
            return View(candidates);
        }

        public ActionResult ActivateCandidate(int id)
        {
            // first get the candidate by Id
            var candidate = db.Candidates.Find(id);
            // if candidate is null throw an exception
            if (candidate == null)
                throw new Exception("Candidate Not Found.");
            candidate.ProfileVerified = true;
            db.SaveChanges();
            // else return success message
            return Json("Candidate profile Verified Successfully", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Employers()
        {
            var employers = db.Employers.Include(p => p.ApplicationUser).OrderByDescending(p => p.EmployerId).ToList();
            return View(employers);
        }

        public ActionResult ActivateEmployer(int id)
        {
            // first get the candidate by Id
            var employer = db.Employers.Find(id);
            // if candidate is null throw an exception
            if (employer == null)
                throw new Exception("Employer Not Found.");
            employer.ProfileVerified = true;
            db.SaveChanges();
            // else return success message
            return Json("Employer profile Verified Successfully", JsonRequestBehavior.AllowGet);
        }


        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Agencies.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agency agency = db.Agencies.Find(id);
            if (agency == null)
            {
                return HttpNotFound();
            }
            return View(agency);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgencyId,AspNetUserId,AgencyName,AgencyLogo,AgencyWebsiteURL,ManagerFirstName,ManagerLastName,ManagerAge,CompanyActivityDesc,CountryId,CityId,DistrictId,ProfileVerified,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Agency agency)
        {
            if (ModelState.IsValid)
            {
                db.Agencies.Add(agency);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agency);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agency agency = db.Agencies.Find(id);
            if (agency == null)
            {
                return HttpNotFound();
            }
            return View(agency);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgencyId,AspNetUserId,AgencyName,AgencyLogo,AgencyWebsiteURL,ManagerFirstName,ManagerLastName,ManagerAge,CompanyActivityDesc,CountryId,CityId,DistrictId,ProfileVerified,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Agency agency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agency);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agency agency = db.Agencies.Find(id);
            if (agency == null)
            {
                return HttpNotFound();
            }
            return View(agency);
        }

        [HttpGet]
        public ActionResult ExportMembers()
        {
            return View();
        }

        [HttpGet]
        [Obsolete]
        public ActionResult ValidateUserProfiles()
        {
            return View();
        }

     
        [HttpGet]
        public ActionResult ValidateJobOffers()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ValidateJobRequests()
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Agency agency = db.Agencies.Find(id);
            db.Agencies.Remove(agency);
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
