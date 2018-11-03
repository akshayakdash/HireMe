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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Candidate>().
            HasMany(c => c.FavouriteJobOffers).
            WithMany().
            Map(
             m =>
             {
                 m.MapLeftKey("CandidateId");
                 m.MapRightKey("JobOfferId");
                 m.ToTable("CandidateFavouriteJobOffer", "jobtek");
             });

            modelBuilder.Entity<Employer>().
            HasMany(c => c.FavouriteJobRequests).
            WithMany().
            Map(
             m =>
             {
                 m.MapLeftKey("CandidateId");
                 m.MapRightKey("JobRequestId");
                 m.ToTable("EmployerFavouriteJobRequest", "jobtek");
             });

            modelBuilder.Entity<ApplicationUser>()
           .HasMany(user => user.Candidates)
           .WithOptional()
           .HasForeignKey(candidate => candidate.AspNetUserId);


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

        public DbSet<JobCategory> JobCategories { get; set; }

        public DbSet<Job> Jobs { get; set; }
    }
}