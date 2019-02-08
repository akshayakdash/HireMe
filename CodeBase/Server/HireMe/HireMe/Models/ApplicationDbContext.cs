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
            Database.CommandTimeout = 10000;
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
                 m.ToTable("CandidateFavouriteJobOffer");
             });

            modelBuilder.Entity<Employer>().
            HasMany(c => c.FavouriteJobRequests).
            WithMany().
            Map(
             m =>
             {
                 m.MapLeftKey("CandidateId");
                 m.MapRightKey("JobRequestId");
                 m.ToTable("EmployerFavouriteJobRequest");
             });

            modelBuilder.Entity<ApplicationUser>()
           .HasMany(user => user.Candidates)
           .WithOptional()
           .HasForeignKey(candidate => candidate.AspNetUserId);

            modelBuilder.Entity<ApplicationUser>()
          .HasMany(user => user.Employers)
          .WithOptional()
          .HasForeignKey(empl => empl.AspNetUserId);

            modelBuilder.Entity<ApplicationUser>()
          .HasMany(user => user.Agencies)
          .WithOptional()
          .HasForeignKey(agncy => agncy.AspNetUserId);

            modelBuilder.Entity<Candidate>()
        .HasMany(user => user.JobRequests)
        .WithOptional()
        .HasForeignKey(agncy => agncy.CandidateId);

            //modelBuilder.Entity<JobRequest>()
            //.HasRequired(e => e.Candidate)
            //.WithOptional()
            //.WillCascadeOnDelete(false);

            // uncomment it when we want to create db migration
            //modelBuilder.Ignore<JobTekNotification>();
            //modelBuilder.Ignore<v_SearchJobRequest>();
            //modelBuilder.Ignore<v_ExportJobRequest>();
            //modelBuilder.Ignore<v_ExportJobOffer>();
            //modelBuilder.Ignore<v_JobCount>();
            //modelBuilder.Ignore<v_JobRequest_Count>();
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
        public DbSet<Candidate> Candidates { get; set; }

        public System.Data.Entity.DbSet<HireMe.Models.JobRequest> JobRequests { get; set; }

        public System.Data.Entity.DbSet<HireMe.Models.JobOffer> JobOffers { get; set; }

        public DbSet<Employer> Employers { get; set; }

        public DbSet<Agency> Agencies { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<JobRequestNote> JobRequestNotes { get; set; }

        public DbSet<JobTekNotification> Notifications { get; set; }
        public DbSet<SignalRUserConnection> SignalRConnections { get; set; }
        public DbSet<JobRequestJobTask> JobRequestJobTasks { get; set; }
        public DbSet<UserFeedback> UserFeedbacks { get; set; }

        public DbSet<v_SearchJobRequest> v_JobRequests { get; set; }

        public DbSet<v_SearchJobRequest_Mobile> v_SearchJobRequests_Mobile { get; set; }
        public DbSet<v_SearchJobOffer_Mobile> v_SearchJobOffer_Mobile { get; set; }

        public DbSet<v_ExportJobRequest> v_ExportJobRequests { get; set; }
        public DbSet<v_ExportJobOffer> v_ExportJobOffers { get; set; }
        public DbSet<v_JobCount> v_JobCounts { get; set; }
        public DbSet<v_JobRequest_Count> v_JobRequestCount { get; set; }

        public DbSet<v_JobCount_JobOffer> v_JobOfferDoughnotData { get; set; }
        public DbSet<v_JobOffer_Count> v_JobOfferCount { get; set; }



    }
}