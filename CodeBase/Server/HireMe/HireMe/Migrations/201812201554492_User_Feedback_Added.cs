namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User_Feedback_Added : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.JobTekNotifications",
            //    c => new
            //        {
            //            JobTekNotificationId = c.Int(nullable: false, identity: true),
            //            Subject = c.String(unicode: false),
            //            Content = c.String(unicode: false),
            //            SenderId = c.String(maxLength: 128, storeType: "nvarchar"),
            //            ReceiverId = c.String(maxLength: 128, storeType: "nvarchar"),
            //            Category = c.Int(nullable: false),
            //            CreatedDate = c.DateTime(nullable: false, precision: 0),
            //            SeenByReceiver = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.JobTekNotificationId)
            //    .ForeignKey("dbo.AspNetUsers", t => t.ReceiverId)
            //    .ForeignKey("dbo.AspNetUsers", t => t.SenderId)
            //    .Index(t => t.SenderId)
            //    .Index(t => t.ReceiverId);
            
            CreateTable(
                "dbo.UserFeedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SenderId = c.String(unicode: false),
                        ReceiverId = c.String(unicode: false),
                        Comments = c.String(unicode: false),
                        JobName = c.String(unicode: false),
                        Rating = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.v_ExportJobOffer",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(unicode: false),
            //            EmailId = c.String(unicode: false),
            //            ContactNo = c.String(unicode: false),
            //            Gender = c.String(unicode: false),
            //            Age = c.String(unicode: false),
            //            ProfileVerified = c.String(unicode: false),
            //            JobSought = c.String(unicode: false),
            //            PublishedDate = c.String(unicode: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.v_ExportJobRequest",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(unicode: false),
            //            EmailId = c.String(unicode: false),
            //            ContactNo = c.String(unicode: false),
            //            Gender = c.String(unicode: false),
            //            Age = c.String(unicode: false),
            //            ProfileVerified = c.String(unicode: false),
            //            JobSought = c.String(unicode: false),
            //            PublishedDate = c.String(unicode: false),
            //            Profile = c.String(unicode: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.v_categorywisejobcount",
            //    c => new
            //        {
            //            JobName = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
            //            TotalRequests = c.String(unicode: false),
            //        })
            //    .PrimaryKey(t => t.JobName);
            
            //CreateTable(
            //    "dbo.v_jobRequests",
            //    c => new
            //        {
            //            PK = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
            //            Month = c.String(unicode: false),
            //            JobName = c.String(unicode: false),
            //            TotalRequests = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.PK);
            
            //CreateTable(
            //    "dbo.v_SearchJobRequest",
            //    c => new
            //        {
            //            JobRequestId = c.Int(nullable: false, identity: true),
            //            CandidateId = c.Int(nullable: false),
            //            JobId = c.Int(nullable: false),
            //            IsPublished = c.Boolean(nullable: false),
            //            PublishedDate = c.DateTime(precision: 0),
            //            JobRequestDescription = c.String(unicode: false),
            //            StarRating = c.Int(nullable: false),
            //            VerifiedByAdmin = c.Boolean(nullable: false),
            //            AspNetUserId = c.String(unicode: false),
            //            AgencyId = c.Int(),
            //            ProfilePicUrl = c.String(unicode: false),
            //            Gender = c.Int(nullable: false),
            //            Age = c.Int(),
            //            DOB = c.DateTime(nullable: false, precision: 0),
            //            ExperienceInYears = c.Int(),
            //            ExperienceInMonths = c.Int(),
            //            IdProofDoc = c.String(unicode: false),
            //            IdProofDocDesc = c.String(unicode: false),
            //            ProfileVerified = c.Boolean(nullable: false),
            //            StaffType = c.Int(nullable: false),
            //            Disponibility = c.DateTime(precision: 0),
            //            Country = c.String(unicode: false),
            //            City = c.String(unicode: false),
            //            District = c.String(unicode: false),
            //            SalaryType = c.Int(nullable: false),
            //            SalaryTypeOtherDesc = c.String(unicode: false),
            //            CanRead = c.Boolean(nullable: false),
            //            CanWrite = c.Boolean(nullable: false),
            //            ExpectedMinSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ExpectedMaxSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            SleepOnSite = c.Boolean(nullable: false),
            //            FirstName = c.String(unicode: false),
            //            LastName = c.String(unicode: false),
            //            ContactNo = c.String(unicode: false),
            //            EmailId = c.String(unicode: false),
            //            Address = c.String(unicode: false),
            //            ContactOption = c.String(unicode: false),
            //            JobName = c.String(unicode: false),
            //            JobCategoryId = c.Int(nullable: false),
            //            IconImage = c.String(unicode: false),
            //            AdditionalDescription = c.String(unicode: false),
            //        })
            //    .PrimaryKey(t => t.JobRequestId);
            
            //AddForeignKey("dbo.JobRequestJobTasks", "JobRequestId", "dbo.v_SearchJobRequest", "JobRequestId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.JobRequestJobTasks", "JobRequestId", "dbo.v_SearchJobRequest");
            //DropForeignKey("dbo.JobTekNotifications", "SenderId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.JobTekNotifications", "ReceiverId", "dbo.AspNetUsers");
            //DropIndex("dbo.JobTekNotifications", new[] { "ReceiverId" });
            //DropIndex("dbo.JobTekNotifications", new[] { "SenderId" });
            //DropTable("dbo.v_SearchJobRequest");
            //DropTable("dbo.v_jobRequests");
            //DropTable("dbo.v_categorywisejobcount");
            //DropTable("dbo.v_ExportJobRequest");
            //DropTable("dbo.v_ExportJobOffer");
            //DropTable("dbo.JobTekNotifications");

            DropTable("dbo.UserFeedbacks");
        }
    }
}
