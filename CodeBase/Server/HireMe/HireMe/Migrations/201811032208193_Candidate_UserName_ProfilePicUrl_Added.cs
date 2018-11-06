namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Candidate_UserName_ProfilePicUrl_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "UserName", c => c.String(unicode: false));
            AddColumn("dbo.Candidates", "ProfilePicUrl", c => c.String(unicode: false));
            CreateIndex("dbo.JobRequests", "JobId");
            AddForeignKey("dbo.JobRequests", "JobId", "dbo.Jobs", "JobId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobRequests", "JobId", "dbo.Jobs");
            DropIndex("dbo.JobRequests", new[] { "JobId" });
            DropColumn("dbo.Candidates", "ProfilePicUrl");
            DropColumn("dbo.Candidates", "UserName");
        }
    }
}
