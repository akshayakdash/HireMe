using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HireMe.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System.Transactions;
using PagedList;

namespace HireMe.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ManageUsersController : Controller
    {
        private ApplicationUserManager _userManager;
        private ApplicationDbContext db;// = new ApplicationDbContext();
        public ManageUsersController()
        {
            db = new ApplicationDbContext();
        }

        public ManageUsersController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
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

        // GET: ManageUsers
        public ActionResult Index(int? page)
        {
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;

            var users = db.Users
                .OrderByDescending(p => p.Id)
                .ToPagedList(pageIndex, pageSize);
            return View(users);
        }

        // GET: ManageUsers/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = GetApplicationUserWithAllChildren(id);//db.Users.Find(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }
            return View(applicationUser);
        }

        // GET: ManageUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: ManageUsers/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = db.Users.Find(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }
            return View(applicationUser);
        }

        // POST: ManageUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var user = await UserManager.FindByIdAsync(id);
                var logins = user.Logins;
                var rolesForUser = await UserManager.GetRolesAsync(id);
                var userEntity = db.Users.Find(id);
                var isEmployer = db.Employers.Count(p => p.AspNetUserId == user.Id) > 0;
                if (isEmployer)

                    db.Entry(userEntity).Collection(p => p.Employers).Load();// query.Include(p => p.Employers);
                var isAgency = db.Agencies.Count(p => p.AspNetUserId == user.Id) > 0;
                if (isAgency)
                    db.Entry(userEntity).Collection(p => p.Agencies).Load();
                var isCandidate = db.Candidates.Count(p => p.AspNetUserId == user.Id) > 0;
                if (isCandidate)
                    db.Entry(userEntity).Collection(p => p.Candidates).Load();

                // Load other related entities
                db.Entry(userEntity).Collection(p => p.SignalRConnections).Load();
                db.Entry(userEntity).Collection(p => p.SecurityQuestionAnswers).Load();
                db.Entry(userEntity).Collection(p => p.OTPList).Load();
                IncludeSubNavigationProps(userEntity);

                //using (var transaction = db.Database.BeginTransaction())
                using (var ts = new TransactionScope(TransactionScopeOption.Required,
                                    TimeSpan.FromMinutes(1)))
                {

                    foreach (var login in logins.ToList())
                    {
                        await _userManager.RemoveLoginAsync(login.UserId, new UserLoginInfo(login.LoginProvider, login.ProviderKey));
                    }

                    if (rolesForUser.Count() > 0)
                    {
                        foreach (var item in rolesForUser.ToList())
                        {
                            // item should be the name of the role
                            var result = await UserManager.RemoveFromRoleAsync(user.Id, item);
                        }
                    }

                    // delete signalRConnections, securityQuestionAnswers, OTPLists
                    userEntity.SignalRConnections?.ToList().ForEach(con => { db.SignalRConnections.Remove(con); });
                    userEntity.SecurityQuestionAnswers?.ToList().ForEach(seqQuest => { db.UserSecurityQuestionAnswers.Remove(seqQuest); });
                    userEntity.OTPList?.ToList().ForEach(otp => { db.UserOtps.Remove(otp); });

                    // now delete all job offers and requests
                    if (isEmployer)
                    {
                        var employer = userEntity.Employers?.FirstOrDefault();
                        if (employer != null)
                        {
                            var jobOffers = employer.JobOffers?.ToList();
                            if (jobOffers != null && jobOffers.Count > 0)
                            {
                                jobOffers.ForEach(offer =>
                                {
                                    //// Delete all joboffernotes
                                    //if (offer.JobOfferNotes != null && offer.JobOfferNotes.Count > 0)
                                    //{
                                    //    offer.JobOfferNotes.ForEach(note => {

                                    //    });
                                    //}
                                    //// Delete all joboffertasks
                                    //if (offer.JobOfferJobTasks != null && offer.JobOfferJobTasks.Count > 0)
                                    //{
                                    //    offer.JobOfferJobTasks.ForEach(jobOffTask => {

                                    //    });
                                    //}
                                    db.JobOffers.Remove(offer);
                                    db.Entry(offer).State = EntityState.Deleted;
                                });
                            }

                            var favJobRequests = employer.FavouriteJobRequests?.ToList();
                            if (favJobRequests != null && favJobRequests.Count > 0)
                            {
                                favJobRequests.ForEach(favJobReq =>
                                {
                                    employer.FavouriteJobRequests?.Remove(favJobReq);
                                });
                            }
                        }
                        userEntity.Employers.ToList().ForEach(emp => userEntity.Employers.Remove(emp));
                    }
                    else if (isCandidate)
                    {
                        var candidate = userEntity.Candidates?.FirstOrDefault();
                        if (candidate != null)
                        {
                            var jobRequests = candidate.JobRequests?.ToList();
                            if (jobRequests != null && jobRequests.Count > 0)
                            {
                                jobRequests.ForEach(req =>
                                {
                                    db.JobRequests.Remove(req);
                                    db.Entry(req).State = EntityState.Deleted;
                                });
                            }

                            var favJobOffers = candidate.FavouriteJobOffers?.ToList();
                            if (favJobOffers != null && favJobOffers.Count > 0)
                            {
                                favJobOffers.ForEach(favJobOffer =>
                                {
                                    candidate.FavouriteJobOffers?.Remove(favJobOffer);
                                });
                            }
                        }
                        userEntity.Candidates.ToList().ForEach(cnd => userEntity.Candidates.Remove(cnd));
                    }
                    else if (isAgency)
                    {
                        var agency = userEntity.Agencies?.FirstOrDefault();
                        if (agency != null)
                        {
                            var candidates = agency?.Candidates?.ToList();
                            if (candidates != null && candidates.Count > 0)
                            {
                                candidates.ForEach(candidate => {
                                    if (candidate != null)
                                    {
                                        var jobRequests = candidate.JobRequests?.ToList();
                                        if (jobRequests != null && jobRequests.Count > 0)
                                        {
                                            jobRequests.ForEach(req =>
                                            {
                                                db.JobRequests.Remove(req);
                                                db.Entry(req).State = EntityState.Deleted;
                                            });
                                        }

                                        var favJobOffers = candidate.FavouriteJobOffers?.ToList();
                                        if (favJobOffers != null && favJobOffers.Count > 0)
                                        {
                                            favJobOffers.ForEach(favJobOffer =>
                                            {
                                                candidate.FavouriteJobOffers?.Remove(favJobOffer);
                                            });
                                        }
                                    }
                                    agency.Candidates.ToList().ForEach(cnd => agency.Candidates.Remove(cnd));
                                });
                            }
                            userEntity.Agencies.ToList().ForEach(agn => userEntity.Agencies.Remove(agn));
                        }
                    }

                    db.SaveChanges();
                    await UserManager.DeleteAsync(user);
                    //transaction.Commit();
                    try
                    {
                        ts.Complete();
                    }
                    catch (Exception ex)
                    {

                    }
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        private ApplicationUser GetApplicationUserWithAllChildren(string id)
        {
            try
            {
                var query = db.Set<ApplicationUser>().AsQueryable();
                var navigationProperties = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)db).ObjectContext
                    .CreateObjectSet<ApplicationUser>()
                    .EntitySet
                    .ElementType
                    .NavigationProperties
                    .Select(p => p.Name);
                //foreach (var navProp in navigationProperties)
                //{
                //    query = query.Include(navProp);
                //}



                var isEmployer = db.Employers.Count(p => p.AspNetUserId == id) > 0;
                if (isEmployer)
                    query = query.Include(p => p.Employers);
                var isAgency = db.Agencies.Count(p => p.AspNetUserId == id) > 0;
                if (isAgency)
                    query = query.Include(p => p.Agencies);
                var isCandidate = db.Candidates.Count(p => p.AspNetUserId == id) > 0;
                if (isCandidate)
                    query = query.Include(p => p.Candidates);

                query = query.Include(p => p.Roles)
                    .Include(p => p.SecurityQuestionAnswers)
                    .Include(p => p.Claims)
                    .Include(p => p.SignalRConnections)
                    .Include(p => p.OTPList);
                var result = query.SingleOrDefault(p => p.Id == id);
                if (isEmployer)
                {
                    result.Employers?.ForEach(employer =>
                    {
                        db.Entry(employer).Collection(p => p.JobOffers).Load();
                        db.Entry(employer).Collection(p => p.FavouriteJobRequests).Load();

                        employer.JobOffers?.ForEach(joboffer =>
                        {
                            db.Entry(joboffer).Collection(p => p.JobOfferJobTasks).Load();
                            db.Entry(joboffer).Collection(p => p.JobOfferNotes).Load();
                        });
                    });
                }

                if (isCandidate)
                {
                    result.Candidates?.ForEach(candidate =>
                    {
                        db.Entry(candidate).Collection(p => p.JobRequests).Load();
                        db.Entry(candidate).Collection(p => p.FavouriteJobOffers).Load();

                        candidate.JobRequests?.ForEach(jobrequest =>
                        {
                            db.Entry(jobrequest).Collection(p => p.JobRequestJobTasks).Load();
                            db.Entry(jobrequest).Collection(p => p.JobRequestNotes).Load();
                        });
                    });
                }

                if (isAgency)
                {
                    result.Agencies?.ForEach(agency =>
                    {
                        db.Entry(agency).Collection(p => p.Candidates).Load();

                        agency.Candidates?.ForEach(candidate =>
                        {
                            db.Entry(candidate).Collection(p => p.JobRequests).Load();
                            db.Entry(candidate).Collection(p => p.FavouriteJobOffers).Load();

                            candidate.JobRequests?.ForEach(jobrequest =>
                            {
                                db.Entry(jobrequest).Collection(p => p.JobRequestJobTasks).Load();
                                db.Entry(jobrequest).Collection(p => p.JobRequestNotes).Load();
                            });
                        });
                    });
                }

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void IncludeSubNavigationProps(ApplicationUser result)
        {
            var isEmployer = db.Employers.Count(p => p.AspNetUserId == result.Id) > 0;
            var isAgency = db.Agencies.Count(p => p.AspNetUserId == result.Id) > 0;
            var isCandidate = db.Candidates.Count(p => p.AspNetUserId == result.Id) > 0;

            if (isEmployer)
            {
                result.Employers?.ForEach(employer =>
                {
                    db.Entry(employer).Collection(p => p.JobOffers).Load();
                    db.Entry(employer).Collection(p => p.FavouriteJobRequests).Load();

                    employer.JobOffers?.ForEach(joboffer =>
                    {
                        db.Entry(joboffer).Collection(p => p.JobOfferJobTasks).Load();
                        db.Entry(joboffer).Collection(p => p.JobOfferNotes).Load();
                    });
                });
            }

            if (isCandidate)
            {
                result.Candidates?.ForEach(candidate =>
                {
                    db.Entry(candidate).Collection(p => p.JobRequests).Load();
                    db.Entry(candidate).Collection(p => p.FavouriteJobOffers).Load();

                    candidate.JobRequests?.ForEach(jobrequest =>
                    {
                        db.Entry(jobrequest).Collection(p => p.JobRequestJobTasks).Load();
                        db.Entry(jobrequest).Collection(p => p.JobRequestNotes).Load();
                    });
                });
            }

            if (isAgency)
            {
                result.Agencies?.ForEach(agency =>
                {
                    db.Entry(agency).Collection(p => p.Candidates).Load();

                    agency.Candidates?.ForEach(candidate =>
                    {
                        db.Entry(candidate).Collection(p => p.JobRequests).Load();
                        db.Entry(candidate).Collection(p => p.FavouriteJobOffers).Load();

                        candidate.JobRequests?.ForEach(jobrequest =>
                        {
                            db.Entry(jobrequest).Collection(p => p.JobRequestJobTasks).Load();
                            db.Entry(jobrequest).Collection(p => p.JobRequestNotes).Load();
                        });
                    });
                });
            }
            //return result;
        }

        //private ApplicationUser RecursiveLoadGrandChildren(ApplicationUser parent)
        //{
        //    var ParentFromDatabase = db.Entry(parent).Collection(d => d.Children);//Children are loaded, we can loop them now

        //    foreach (var child in parent.Children)
        //    {
        //        _context.Entry(child).Reference(d => d.OtherProperty).Load();
        //        RecursiveLoad(child);
        //    }
        //    return ParentFromDatabase;
        //}

        // POST: /Users/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(string id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }

        //        var user = await _userManager.FindByIdAsync(id);
        //        var logins = user.Logins;
        //        var rolesForUser = await _userManager.GetRolesAsync(id);

        //        using (var transaction = context.Database.BeginTransaction())
        //        {
        //            foreach (var login in logins.ToList())
        //            {
        //                await _userManager.RemoveLoginAsync(login.UserId, new UserLoginInfo(login.LoginProvider, login.ProviderKey));
        //            }

        //            if (rolesForUser.Count() > 0)
        //            {
        //                foreach (var item in rolesForUser.ToList())
        //                {
        //                    // item should be the name of the role
        //                    var result = await _userManager.RemoveFromRoleAsync(user.Id, item);
        //                }
        //            }

        //            await _userManager.DeleteAsync(user);
        //            transaction.Commit();
        //        }

        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
    }
}
