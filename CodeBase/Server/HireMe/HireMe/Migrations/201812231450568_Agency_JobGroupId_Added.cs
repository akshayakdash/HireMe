namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agency_JobGroupId_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobRequests", "AgencyJobRequestGroupId", c => c.String(unicode: false));
            AddColumn("dbo.JobRequests", "AgencyJobRequestTitle", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobRequests", "AgencyJobRequestTitle");
            DropColumn("dbo.JobRequests", "AgencyJobRequestGroupId");
        }
    }
}
