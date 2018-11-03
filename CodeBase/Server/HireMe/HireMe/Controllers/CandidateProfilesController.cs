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
    public class CandidateProfilesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //// GET: CandidateProfiles
        //public ActionResult Index()
        //{
        //    return View(db.CandidateProfiles.ToList());
        //}

        //// GET: CandidateProfiles/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CandidateProfile candidateProfile = db.CandidateProfiles.Find(id);
        //    if (candidateProfile == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(candidateProfile);
        //}

        // GET: CandidateProfiles/Create
        public ActionResult Create(int? id)
        {
            // now prepare the job tasks for the job

            // get the job tasks for a job

            Job job = db.Jobs.Include(p => p.JobTasks).FirstOrDefault(p => p.JobId == id);
          
            var candidateProfile = new CandidateProfileViewModel { JobTasks = AutoMapper.Mapper.Map<List<JobTaskViewModel>>(job.JobTasks) };

            return View(candidateProfile);
        }

        // POST: CandidateProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CandidateProfileViewModel candidateProfile)
        {
            if (ModelState.IsValid)
            {
                //db.CandidateProfiles.Add(candidateProfile);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(candidateProfile);
        }

        // GET: CandidateProfiles/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CandidateProfile candidateProfile = db.CandidateProfiles.Find(id);
        //    if (candidateProfile == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(candidateProfile);
        //}

        // POST: CandidateProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CandidateId,AspNetUserId,AgencyId,Gender,Age,ExperienceInYears,ExperienceInMonths,IdProofDoc,IdProofDocDesc,ProfileVerified,StaffType,StaffTypeDesc,Disponibility,CountryId,Country,CityId,City,DistrictId,District,SalaryType,SalaryTypeDesc,SalaryTypeOtherDesc,CanRead,CanWrite,ExpectedMinSalary,ExpectedMaxSalary,SleepOnSite,ExpectedMinRooms,ExpectedMaxRooms,MinGroupPeople,MaxGroupPeople,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,PublishProfile")] CandidateProfileViewModel candidateProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidateProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(candidateProfile);
        }

        // GET: CandidateProfiles/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CandidateProfile candidateProfile = db.CandidateProfiles.Find(id);
        //    if (candidateProfile == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(candidateProfile);
        //}

        // POST: CandidateProfiles/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    CandidateProfile candidateProfile = db.CandidateProfiles.Find(id);
        //    db.CandidateProfiles.Remove(candidateProfile);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
