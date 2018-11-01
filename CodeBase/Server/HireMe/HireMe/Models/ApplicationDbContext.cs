using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HireMe.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(null);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //public DbSet<Candidate> Candidates { get; set; }
        //public DbSet<Agency> Agencies { get; set; }
        //public DbSet<Employer> Employers { get; set; }
        //public DbSet<JobCategory> JobCategories { get; set; }
        //public DbSet<Job> Jobs { get; set; }
        //public DbSet<CountryJobMapper> CountryJobMappers { get; set; }
        //public DbSet<JobRequest> JobRequests { get; set; }
        //public DbSet<JobOffer> JobOffers { get; set; }

        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<ApplicationUserSecurityQuestionAnswer> UserSecurityQuestionAnswers { get; set; }
    }
}