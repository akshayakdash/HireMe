namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Job_Request_Profile_PicUpload_Option_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobRequests", "SkillPic1", c => c.String(unicode: false));
            AddColumn("dbo.JobRequests", "SkillPic2", c => c.String(unicode: false));
            AddColumn("dbo.JobRequests", "SkillPic3", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobRequests", "SkillPic3");
            DropColumn("dbo.JobRequests", "SkillPic2");
            DropColumn("dbo.JobRequests", "SkillPic1");
        }
    }
}
