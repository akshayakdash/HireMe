namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobRequest_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        CandidateId = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(maxLength: 128, storeType: "nvarchar"),
                        AgencyId = c.Int(),
                        Gender = c.Int(nullable: false),
                        Age = c.Int(),
                        ExperienceInYears = c.Int(),
                        ExperienceInMonths = c.Int(),
                        IdProofDoc = c.String(unicode: false),
                        IdProofDocDesc = c.String(unicode: false),
                        ProfileVerified = c.Boolean(nullable: false),
                        StaffType = c.Int(nullable: false),
                        Disponibility = c.DateTime(nullable: false, precision: 0),
                        CountryId = c.Int(),
                        CityId = c.Int(),
                        DistrictId = c.Int(),
                        SalaryType = c.Int(nullable: false),
                        SalaryTypeOtherDesc = c.String(unicode: false),
                        CanRead = c.Boolean(nullable: false),
                        CanWrite = c.Boolean(nullable: false),
                        ExpectedMinSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpectedMaxSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SleepOnSite = c.Boolean(nullable: false),
                        ExpectedMinRooms = c.Int(),
                        ExpectedMaxRooms = c.Int(),
                        MinGroupPeople = c.Int(),
                        MaxGroupPeople = c.Int(),
                        CreatedDate = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        UpdatedDate = c.String(unicode: false),
                        UpdatedBy = c.String(unicode: false),
                        AdditionalDescription = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CandidateId)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUserId)
                .Index(t => t.AspNetUserId);
            
            CreateTable(
                "dbo.JobOffers",
                c => new
                    {
                        JobOfferId = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        EmployerId = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        ExperienceInYears = c.Int(nullable: false),
                        ExperienceInMonths = c.Int(nullable: false),
                        IdProofDoc = c.String(unicode: false),
                        IdProofDocDesc = c.String(unicode: false),
                        ProfileVerified = c.Boolean(nullable: false),
                        StaffType = c.Int(nullable: false),
                        Disponibility = c.DateTime(nullable: false, precision: 0),
                        CountryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        SalaryType = c.Int(nullable: false),
                        SalaryTypeOtherDesc = c.String(unicode: false),
                        CanRead = c.Boolean(nullable: false),
                        CanWrite = c.Boolean(nullable: false),
                        ExpectedMinSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpectedMaxSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SleepOnSite = c.Boolean(nullable: false),
                        ExpectedMinRooms = c.Int(nullable: false),
                        ExpectedMaxRooms = c.Int(nullable: false),
                        MinGroupPeople = c.Int(nullable: false),
                        MaxGroupPeople = c.Int(nullable: false),
                        PublishedDate = c.DateTime(nullable: false, precision: 0),
                        ValidTill = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.JobOfferId)
                .ForeignKey("dbo.Employers", t => t.EmployerId, cascadeDelete: true)
                .Index(t => t.EmployerId);
            
            CreateTable(
                "dbo.JobOfferJobTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobOfferId = c.Int(nullable: false),
                        EmployerId = c.Int(nullable: false),
                        JobTaskId = c.Int(nullable: false),
                        TaskResponse = c.String(unicode: false),
                        TaskResponseAdditionalDescription = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobTasks", t => t.JobTaskId, cascadeDelete: true)
                .ForeignKey("dbo.JobOffers", t => t.JobOfferId, cascadeDelete: true)
                .Index(t => t.JobOfferId)
                .Index(t => t.JobTaskId);
            
            CreateTable(
                "dbo.JobRequests",
                c => new
                    {
                        JobRequestId = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        JobId = c.Int(nullable: false),
                        IsPublished = c.Boolean(nullable: false),
                        PublishedDate = c.DateTime(nullable: false, precision: 0),
                        ValidTill = c.DateTime(nullable: false, precision: 0),
                        JobRequestDescription = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.JobRequestId)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.JobRequestJobTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobRequestId = c.Int(nullable: false),
                        JobTaskId = c.Int(nullable: false),
                        TaskResponse = c.String(unicode: false),
                        TaskResponseAdditionalDescription = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobTasks", t => t.JobTaskId, cascadeDelete: true)
                .ForeignKey("dbo.JobRequests", t => t.JobRequestId, cascadeDelete: true)
                .Index(t => t.JobRequestId)
                .Index(t => t.JobTaskId);
            
            CreateTable(
                "dbo.Employers",
                c => new
                    {
                        EmployerId = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(unicode: false),
                        Gender = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        ProfileVerified = c.Boolean(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        CreatedDate = c.String(unicode: false),
                        UpdatedBy = c.String(unicode: false),
                        UpdatedDate = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.EmployerId);
            
            CreateTable(
                "jobtek.CandidateFavouriteJobOffer",
                c => new
                    {
                        CandidateId = c.Int(nullable: false),
                        JobOfferId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CandidateId, t.JobOfferId })
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .ForeignKey("dbo.JobOffers", t => t.JobOfferId, cascadeDelete: true)
                .Index(t => t.CandidateId)
                .Index(t => t.JobOfferId);
            
            CreateTable(
                "jobtek.EmployerFavouriteJobRequest",
                c => new
                    {
                        CandidateId = c.Int(nullable: false),
                        JobRequestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CandidateId, t.JobRequestId })
                .ForeignKey("dbo.Employers", t => t.CandidateId, cascadeDelete: true)
                .ForeignKey("dbo.JobRequests", t => t.JobRequestId, cascadeDelete: true)
                .Index(t => t.CandidateId)
                .Index(t => t.JobRequestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobOffers", "EmployerId", "dbo.Employers");
            DropForeignKey("jobtek.EmployerFavouriteJobRequest", "JobRequestId", "dbo.JobRequests");
            DropForeignKey("jobtek.EmployerFavouriteJobRequest", "CandidateId", "dbo.Employers");
            DropForeignKey("dbo.Candidates", "AspNetUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.JobRequests", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.JobRequestJobTasks", "JobRequestId", "dbo.JobRequests");
            DropForeignKey("dbo.JobRequestJobTasks", "JobTaskId", "dbo.JobTasks");
            DropForeignKey("jobtek.CandidateFavouriteJobOffer", "JobOfferId", "dbo.JobOffers");
            DropForeignKey("jobtek.CandidateFavouriteJobOffer", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.JobOfferJobTasks", "JobOfferId", "dbo.JobOffers");
            DropForeignKey("dbo.JobOfferJobTasks", "JobTaskId", "dbo.JobTasks");
            DropIndex("jobtek.EmployerFavouriteJobRequest", new[] { "JobRequestId" });
            DropIndex("jobtek.EmployerFavouriteJobRequest", new[] { "CandidateId" });
            DropIndex("jobtek.CandidateFavouriteJobOffer", new[] { "JobOfferId" });
            DropIndex("jobtek.CandidateFavouriteJobOffer", new[] { "CandidateId" });
            DropIndex("dbo.JobRequestJobTasks", new[] { "JobTaskId" });
            DropIndex("dbo.JobRequestJobTasks", new[] { "JobRequestId" });
            DropIndex("dbo.JobRequests", new[] { "CandidateId" });
            DropIndex("dbo.JobOfferJobTasks", new[] { "JobTaskId" });
            DropIndex("dbo.JobOfferJobTasks", new[] { "JobOfferId" });
            DropIndex("dbo.JobOffers", new[] { "EmployerId" });
            DropIndex("dbo.Candidates", new[] { "AspNetUserId" });
            DropTable("jobtek.EmployerFavouriteJobRequest");
            DropTable("jobtek.CandidateFavouriteJobOffer");
            DropTable("dbo.Employers");
            DropTable("dbo.JobRequestJobTasks");
            DropTable("dbo.JobRequests");
            DropTable("dbo.JobOfferJobTasks");
            DropTable("dbo.JobOffers");
            DropTable("dbo.Candidates");
        }
    }
}
