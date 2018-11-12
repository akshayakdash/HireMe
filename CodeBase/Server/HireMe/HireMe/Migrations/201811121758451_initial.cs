namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agencies",
                c => new
                    {
                        AgencyId = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(maxLength: 128, storeType: "nvarchar"),
                        AgencyName = c.String(unicode: false),
                        AgencyLogo = c.String(unicode: false),
                        AgencyWebsiteURL = c.String(unicode: false),
                        ManagerFirstName = c.String(unicode: false),
                        ManagerLastName = c.String(unicode: false),
                        ManagerAge = c.String(unicode: false),
                        CompanyActivityDesc = c.String(unicode: false),
                        CountryId = c.Int(),
                        CityId = c.Int(),
                        DistrictId = c.Int(),
                        ProfileVerified = c.Boolean(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        CreatedDate = c.String(unicode: false),
                        UpdatedBy = c.String(unicode: false),
                        UpdatedDate = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.AgencyId)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUserId)
                .Index(t => t.AspNetUserId);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        CandidateId = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(maxLength: 128, storeType: "nvarchar"),
                        AgencyId = c.Int(),
                        UserName = c.String(unicode: false),
                        ProfilePicUrl = c.String(unicode: false),
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
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        ContactNo = c.String(unicode: false),
                        EmailId = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        AdditionalDescription = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CandidateId)
                .ForeignKey("dbo.Agencies", t => t.AgencyId)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUserId)
                .Index(t => t.AspNetUserId)
                .Index(t => t.AgencyId);
            
            CreateTable(
                "dbo.JobOffers",
                c => new
                    {
                        JobOfferId = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        EmployerId = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        MinAge = c.Int(nullable: false),
                        MaxAge = c.Int(nullable: false),
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
                        IsPublished = c.Boolean(nullable: false),
                        PublishedDate = c.DateTime(nullable: false, precision: 0),
                        ValidTill = c.DateTime(nullable: false, precision: 0),
                        AdditionalDescription = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.JobOfferId)
                .ForeignKey("dbo.Employers", t => t.EmployerId, cascadeDelete: true)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId)
                .Index(t => t.EmployerId);
            
            CreateTable(
                "dbo.Employers",
                c => new
                    {
                        EmployerId = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(maxLength: 128, storeType: "nvarchar"),
                        Gender = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        ProfileVerified = c.Boolean(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        CreatedDate = c.String(unicode: false),
                        UpdatedBy = c.String(unicode: false),
                        UpdatedDate = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.EmployerId)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUserId)
                .Index(t => t.AspNetUserId);
            
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
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.CandidateId)
                .Index(t => t.JobId);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        JobId = c.Int(nullable: false, identity: true),
                        JobName = c.String(unicode: false),
                        JobCategoryId = c.Int(nullable: false),
                        JobGroup = c.String(unicode: false),
                        JobDesc = c.String(unicode: false),
                        IconImage = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.JobId)
                .ForeignKey("dbo.JobCategories", t => t.JobCategoryId, cascadeDelete: true)
                .Index(t => t.JobCategoryId);
            
            CreateTable(
                "dbo.JobTasks",
                c => new
                    {
                        JobTaskId = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        JobTaskName = c.String(unicode: false),
                        JobTaskDescription = c.String(unicode: false),
                        TaskSectionName = c.String(unicode: false),
                        TaskGroupName = c.String(unicode: false),
                        TaskParamType = c.Int(nullable: false),
                        TaskParamValueType = c.Int(nullable: false),
                        ParamAvailableOptions = c.String(unicode: false),
                        ParentJobTaskId = c.Int(),
                    })
                .PrimaryKey(t => t.JobTaskId)
                .ForeignKey("dbo.JobTasks", t => t.ParentJobTaskId)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId)
                .Index(t => t.ParentJobTaskId);
            
            CreateTable(
                "dbo.CountryJobTaskMappers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTaskId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobTasks", t => t.JobTaskId, cascadeDelete: true)
                .Index(t => t.JobTaskId);
            
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
                "dbo.JobCategories",
                c => new
                    {
                        JobCategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        IconImage = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.JobCategoryId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(nullable: false, maxLength: 256, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        RoleId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.SecurityQuestions",
                c => new
                    {
                        SecurityQuestionId = c.Int(nullable: false, identity: true),
                        Question = c.String(unicode: false),
                        AnswerType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SecurityQuestionId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        ProfilePicUrl = c.String(unicode: false),
                        ActiveUntil = c.DateTime(precision: 0),
                        Email = c.String(maxLength: 256, storeType: "nvarchar"),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(unicode: false),
                        SecurityStamp = c.String(unicode: false),
                        PhoneNumber = c.String(unicode: false),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(precision: 0),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ClaimType = c.String(unicode: false),
                        ClaimValue = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ProviderKey = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        UserId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ApplicationUserSecurityQuestionAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(maxLength: 128, storeType: "nvarchar"),
                        SecurityQuestionId = c.Int(nullable: false),
                        Answer = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUserId)
                .ForeignKey("dbo.SecurityQuestions", t => t.SecurityQuestionId, cascadeDelete: true)
                .Index(t => t.AspNetUserId)
                .Index(t => t.SecurityQuestionId);
            
            CreateTable(
                "dbo.EmployerFavouriteJobRequest",
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
            
            CreateTable(
                "dbo.CandidateFavouriteJobOffer",
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationUserSecurityQuestionAnswers", "SecurityQuestionId", "dbo.SecurityQuestions");
            DropForeignKey("dbo.ApplicationUserSecurityQuestionAnswers", "AspNetUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Employers", "AspNetUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Candidates", "AspNetUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Agencies", "AspNetUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Jobs", "JobCategoryId", "dbo.JobCategories");
            DropForeignKey("dbo.Candidates", "AgencyId", "dbo.Agencies");
            DropForeignKey("dbo.CandidateFavouriteJobOffer", "JobOfferId", "dbo.JobOffers");
            DropForeignKey("dbo.CandidateFavouriteJobOffer", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.JobOfferJobTasks", "JobOfferId", "dbo.JobOffers");
            DropForeignKey("dbo.JobOfferJobTasks", "JobTaskId", "dbo.JobTasks");
            DropForeignKey("dbo.JobOffers", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.JobOffers", "EmployerId", "dbo.Employers");
            DropForeignKey("dbo.EmployerFavouriteJobRequest", "JobRequestId", "dbo.JobRequests");
            DropForeignKey("dbo.EmployerFavouriteJobRequest", "CandidateId", "dbo.Employers");
            DropForeignKey("dbo.JobRequestJobTasks", "JobRequestId", "dbo.JobRequests");
            DropForeignKey("dbo.JobRequestJobTasks", "JobTaskId", "dbo.JobTasks");
            DropForeignKey("dbo.JobRequests", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.JobTasks", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.JobTasks", "ParentJobTaskId", "dbo.JobTasks");
            DropForeignKey("dbo.CountryJobTaskMappers", "JobTaskId", "dbo.JobTasks");
            DropForeignKey("dbo.JobRequests", "CandidateId", "dbo.Candidates");
            DropIndex("dbo.CandidateFavouriteJobOffer", new[] { "JobOfferId" });
            DropIndex("dbo.CandidateFavouriteJobOffer", new[] { "CandidateId" });
            DropIndex("dbo.EmployerFavouriteJobRequest", new[] { "JobRequestId" });
            DropIndex("dbo.EmployerFavouriteJobRequest", new[] { "CandidateId" });
            DropIndex("dbo.ApplicationUserSecurityQuestionAnswers", new[] { "SecurityQuestionId" });
            DropIndex("dbo.ApplicationUserSecurityQuestionAnswers", new[] { "AspNetUserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.JobOfferJobTasks", new[] { "JobTaskId" });
            DropIndex("dbo.JobOfferJobTasks", new[] { "JobOfferId" });
            DropIndex("dbo.JobRequestJobTasks", new[] { "JobTaskId" });
            DropIndex("dbo.JobRequestJobTasks", new[] { "JobRequestId" });
            DropIndex("dbo.CountryJobTaskMappers", new[] { "JobTaskId" });
            DropIndex("dbo.JobTasks", new[] { "ParentJobTaskId" });
            DropIndex("dbo.JobTasks", new[] { "JobId" });
            DropIndex("dbo.Jobs", new[] { "JobCategoryId" });
            DropIndex("dbo.JobRequests", new[] { "JobId" });
            DropIndex("dbo.JobRequests", new[] { "CandidateId" });
            DropIndex("dbo.Employers", new[] { "AspNetUserId" });
            DropIndex("dbo.JobOffers", new[] { "EmployerId" });
            DropIndex("dbo.JobOffers", new[] { "JobId" });
            DropIndex("dbo.Candidates", new[] { "AgencyId" });
            DropIndex("dbo.Candidates", new[] { "AspNetUserId" });
            DropIndex("dbo.Agencies", new[] { "AspNetUserId" });
            DropTable("dbo.CandidateFavouriteJobOffer");
            DropTable("dbo.EmployerFavouriteJobRequest");
            DropTable("dbo.ApplicationUserSecurityQuestionAnswers");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.SecurityQuestions");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.JobCategories");
            DropTable("dbo.JobOfferJobTasks");
            DropTable("dbo.JobRequestJobTasks");
            DropTable("dbo.CountryJobTaskMappers");
            DropTable("dbo.JobTasks");
            DropTable("dbo.Jobs");
            DropTable("dbo.JobRequests");
            DropTable("dbo.Employers");
            DropTable("dbo.JobOffers");
            DropTable("dbo.Candidates");
            DropTable("dbo.Agencies");
        }
    }
}
